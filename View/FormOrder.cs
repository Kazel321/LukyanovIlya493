using PerfumeWorld.Classes;
using PerfumeWorld.Classes.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace PerfumeWorld
{
    public partial class FormOrder : Form
    {
        string path = Application.StartupPath + "\\Resources\\Товар_import\\";
        public List<OrderProduct> order;

        public FormOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormOrder_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelBottom.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelMain.BackColor = Color.FromArgb(255, 255, 255);

            listBoxPoints.DataSource = Helper.DB.Point.Select(x => x.PointName).ToList();
            listBoxPoints.SelectedIndex = 0;

            if (Helper.Role == Roles.Клиент) labelFullName.Text = Helper.UserFullName;

            updateOrder();
        }

        /// <summary>
        /// Обновить таблицу с содержанием заказа
        /// </summary>
        void updateOrder()
        {
            dataGridViewOrder.RowCount = order.Count;

            for (int i = 0; i < order.Count; i++)
            {
                string article = order[i].ProductArticle;
                Product product = Helper.DB.Product.Where(x => x.ProductArticle == article).FirstOrDefault();
                dataGridViewOrder[0, i].Value = product.ProductName;
                dataGridViewOrder[1, i].Value = order[i].OrderProductCount;
                dataGridViewOrder[2, i].Value = "Удалить";
            }

            updateOrderInfo();
        }

        double sumOrder;
        double sumDiscount;
        double sumOrderWithoutDiscount;
        int count;

        /// <summary>
        /// Обновление информации о заказе
        /// </summary>
        void updateOrderInfo()
        {
            sumOrder = 0;
            sumDiscount = 0;
            sumOrderWithoutDiscount = 0;
            count = 0;

            for (int i = 0; i < order.Count; i++)
            {
                string article = order[i].ProductArticle;
                Product product = Helper.DB.Product.Where(x => x.ProductArticle == article).FirstOrDefault();

                count += order[i].OrderProductCount;
                sumOrderWithoutDiscount += product.ProductCost * order[i].OrderProductCount;
                sumDiscount += ((product.ProductCost * order[i].OrderProductCount) * product.ProductMaxSale) / 100;
                sumOrder += (product.ProductCost * order[i].OrderProductCount) - (((product.ProductCost * order[i].OrderProductCount) * product.ProductMaxSale) / 100);
            }

            string desc = "";
            desc += "Количество позиций в заказе: " + order.Count + Environment.NewLine;
            desc += "Количество товаров в заказе: " + count + Environment.NewLine;
            desc += "Сумма заказа без скидки: " + sumOrderWithoutDiscount.ToString("C2") + Environment.NewLine;
            desc += "Сумма скидки: " + sumDiscount.ToString("C2") + Environment.NewLine;
            desc += "Сумма заказа со скидкой: " + sumOrder.ToString("C2") + Environment.NewLine;

            textBoxOrderInfo.Text = desc;
        }

        /// <summary>
        /// Возращение назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewOrder_SelectionChanged(object sender, EventArgs e)
        {
            string article = order[dataGridViewOrder.CurrentRow.Index].ProductArticle;
            Product item = Helper.DB.Product.Where(x => x.ProductArticle == article).FirstOrDefault();

            string desc = "";
            double discountCost = 0;
            desc += "Название: " + item.ProductName + Environment.NewLine;
            desc += "Описание: " + item.ProductDescription + Environment.NewLine;
            desc += "Прозводитель: " + item.Manufacturer.ManufacturerName + Environment.NewLine;
            desc += "Цена: " + item.ProductCost.ToString("C2") + Environment.NewLine;

            desc += "Скидка: " + item.ProductMaxSale + "%" + Environment.NewLine;
            desc += "Размер скидки: " + (item.ProductCost * item.ProductMaxSale / 100).ToString("C2") + Environment.NewLine;
            discountCost = item.ProductCost - (item.ProductCost * item.ProductMaxSale / 100);
            desc += "Цена без скидки: " + discountCost.ToString("C2");

            textBoxProductInfo.Text = desc;

            Image img = Properties.Resources.picture;
            Bitmap bmp;
            if (String.IsNullOrEmpty(item.ProductPhoto))
            {
                img = Properties.Resources.picture;
            }
            else
            {
                string photopath = path + item.ProductPhoto;
                try
                {
                    bmp = new Bitmap(photopath);
                    MemoryStream memoryStream = new MemoryStream();
                    bmp.Save(memoryStream, ImageFormat.Jpeg);
                    bmp.Dispose();
                    img = Image.FromStream(memoryStream);
                    memoryStream.Close();
                }
                catch
                {; }
            }
            pictureBoxPhoto.Image = img;
        }

        /// <summary>
        /// Удаление товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrder.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                order.RemoveAt(e.RowIndex);
                if (order.Count == 0)
                {
                    MessageBox.Show("Вы удалили все товары", "Удаление товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else updateOrder();
            }
        }

        /// <summary>
        /// Изменение количества
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridViewOrder[1, e.RowIndex].Value.ToString();
            int count;
            try
            {
                count = (int)Convert.ToUInt32(value);
            }
            catch
            {
                MessageBox.Show("Неправильный формат данных", "Изменение количества", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewOrder[1, e.RowIndex].Value = order[e.RowIndex].OrderProductCount;
                return;
            }
            if (count == 0)
            {
                order.RemoveAt(e.RowIndex);
                if (order.Count == 0)
                {
                    MessageBox.Show("Вы удалили все товары", "Изменение количества", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    updateOrder();
                }
            }
            else
            {
                order[e.RowIndex].OrderProductCount = count;
                updateOrderInfo();
            }
        }

        int uniqueCode;
        DateTime dateNow;
        DateTime dateDelivery;

        /// <summary>
        /// Создание заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();

            Random rand = new Random();
            do
            {
                uniqueCode = rand.Next(1000);
            }
            while (Helper.DB.Order.Where(x => x.OrderCode == uniqueCode).FirstOrDefault() != null);

            newOrder.OrderCode = uniqueCode;
            dateNow = DateTime.Now;
            newOrder.OrderDate = dateNow;
            bool isLongDelivery = false;
            for (int i = 0; i < order.Count; i++)
            {
                string article = order[dataGridViewOrder.CurrentRow.Index].ProductArticle;
                Product product = Helper.DB.Product.Where(x => x.ProductArticle == article).FirstOrDefault();

                if (product.ProductCount < 3)
                {
                    isLongDelivery = true;
                    break;
                }
            }
            if (isLongDelivery)
            {
                dateDelivery = dateNow.AddDays(6);
            }
            else
            {
                dateDelivery = dateNow.AddDays(3);
            }
            newOrder.OrderDateDelivery = dateDelivery;
            newOrder.PointId = listBoxPoints.SelectedIndex + 1;

            if (Helper.Role == Roles.Клиент) newOrder.OrderClientName = Helper.UserFullName;
            else newOrder.OrderClientName = null;

            newOrder.StatusId = 1;
            Helper.DB.Order.Add(newOrder);
            Helper.DB.SaveChanges();

            orderInd = Helper.DB.Order.Max(x => x.OrderId);

            for (int i = 0; i < order.Count; i++)
            {
                OrderProduct orderProduct = new OrderProduct();
                orderProduct.OrderId = orderInd;
                orderProduct.ProductArticle = order[i].ProductArticle;
                orderProduct.OrderProductCount = order[i].OrderProductCount;
                Helper.DB.OrderProduct.Add(orderProduct);
            }

            Helper.DB.SaveChanges();

            MessageBox.Show("Вы успешно создали заказ с номером: " + uniqueCode, "Создание заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonCreateOrder.Enabled = false;
            dataGridViewOrder.Enabled = false;
            buttonCreateCoupon.Enabled = true;
        }

        int orderInd;

        /// <summary>
        /// Создание талона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateCoupon_Click(object sender, EventArgs e)
        {
            Order orderCoupon = Helper.DB.Order.Where(x => x.OrderId == orderInd).FirstOrDefault();

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = wordApp.Documents.Add();
            Word.Paragraph wordPar;
            Word.Range wordRange;
            Word.Range wordCellRange;

            Word.InlineShape wordShape;
            Word.Table wordTab;
            Word.Cell wordCell;

            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordRange.Text = "Талон №" + uniqueCode;
            wordRange.Font.Bold = 1;
            wordRange.Font.Size = 14;
            wordRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            wordRange.InsertParagraphAfter();

            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordTab = wordDoc.Tables.Add(wordRange, order.Count + 1, 2, null, null);
            wordTab.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
            wordTab.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            wordCellRange = wordTab.Cell(1, 1).Range;
            wordCellRange.Text = "Название товара";
            wordCellRange = wordTab.Cell(1, 2).Range;
            wordCellRange.Text = "Количество";
            for (int i = 0; i < dataGridViewOrder.Rows.Count; i++)
            {
                wordCellRange = wordTab.Cell(i+2, 1).Range;
                wordCellRange.Text = dataGridViewOrder[0, i].Value.ToString();
                wordCellRange = wordTab.Cell(i + 2, 2).Range;
                wordCellRange.Text = order[i].OrderProductCount.ToString();
            }
            wordRange.InsertParagraphAfter();

            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordRange.Text = "Дата заказа: " + dateNow.ToShortDateString() + Environment.NewLine;
            wordRange.Text += "Дата доставки: " + dateDelivery.ToShortDateString() + Environment.NewLine;
            wordRange.Text += "Сумма заказа без скидки: " + sumOrderWithoutDiscount.ToString("C2") + Environment.NewLine;
            wordRange.Text += "Сумма скидки: " + sumDiscount.ToString("C2") + Environment.NewLine;
            wordRange.Text += "Сумма заказа со скидкой: " + sumOrder.ToString("C2") + Environment.NewLine;
            wordRange.Text += "Пункт выдачи: " + Helper.DB.Point.Where(x => x.PointId == orderCoupon.PointId).FirstOrDefault().PointName;
            wordRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordRange.InsertParagraphAfter();

            wordDoc.Saved = true;
            wordDoc.SaveAs2(Application.StartupPath + "\\Coupon\\" + uniqueCode + ".pdf", Word.WdExportFormat.wdExportFormatPDF);

            wordDoc.Close();
            wordApp.Quit();

            MessageBox.Show("Вы успешно создали талон", "Создание талона", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }

        void releaseComObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                MessageBox.Show("Не удалось очистить объект", "Очистка объекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
