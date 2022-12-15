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

namespace PerfumeWorld
{
    public partial class FormProduct : Form
    {
        string path = Application.StartupPath + "\\Resources\\Товар_import\\";
        
        public FormProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProduct_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelBottom.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelMain.BackColor = Color.FromArgb(255, 255, 255);

            comboBoxCost.SelectedIndexChanged -= filter;
            comboBoxDiscount.SelectedIndexChanged -= filter;
            comboBoxCost.SelectedIndex = 0;
            comboBoxDiscount.SelectedIndex = 0;

            if (Helper.UserFullName != null) labelFullName.Text = Helper.UserFullName;

            updateProduct();

            comboBoxCost.SelectedIndexChanged += filter;
            comboBoxDiscount.SelectedIndexChanged += filter;

            if (Helper.Role == Roles.Администратор) buttonAddProduct.Visible = true; 
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

        /// <summary>
        /// Обновить список товаров
        /// </summary>
        void updateProduct()
        {
            dataGridViewProduct.Rows.Clear();
            int ind = -1;

            using (DB DB = new DB())
            {

                var products = DB.Product.ToList();
                switch (comboBoxDiscount.SelectedIndex)
                {
                    case 1:
                        products = products.Where(x => x.ProductMaxSale < 11).ToList();
                        break;
                    case 2:
                        products = products.Where(x => (x.ProductMaxSale > 10) && (x.ProductMaxSale < 15)).ToList();
                        break;
                    case 3:
                        products = products.Where(x => x.ProductMaxSale > 14).ToList();
                        break;
                }
                switch (comboBoxCost.SelectedIndex)
                {
                    case 0:
                        products = products.OrderBy(x => x.ProductCost).ToList();
                        break;
                    case 1:
                        products = products.OrderByDescending(x => x.ProductCost).ToList();
                        break;
                }

                string find = textBoxProductName.Text;
                foreach (var item in products)
                {
                    if (String.IsNullOrEmpty(find) || item.ProductName.Contains(find))
                    {
                        string desc = "";
                        string discount = "";
                        double discountCost = 0;
                        desc += item.ProductName + Environment.NewLine;
                        desc += item.ProductDescription + Environment.NewLine;
                        desc += "Прозводитель: " + item.Manufacturer.ManufacturerName + Environment.NewLine;
                        desc += "Цена: " + item.ProductCost.ToString("C2");

                        discount += "Скидка: " + item.ProductMaxSale + "%" + Environment.NewLine;
                        discount += "Размер скидки: " + (item.ProductCost * item.ProductMaxSale / 100).ToString("C2") + Environment.NewLine;
                        discountCost = item.ProductCost - (item.ProductCost * item.ProductMaxSale / 100);
                        discount += "Цена без скидки: " + discountCost.ToString("C2");

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

                        ind = dataGridViewProduct.Rows.Add();
                        dataGridViewProduct.Rows[ind].Height = 150;
                        dataGridViewProduct[0, ind].Value = item.ProductArticle;
                        dataGridViewProduct[1, ind].Value = img;
                        dataGridViewProduct[2, ind].Value = desc;
                        dataGridViewProduct[3, ind].Value = discount;

                        if (item.ProductMaxSale > 15)
                        {
                            dataGridViewProduct[2, ind].Style.BackColor = ColorTranslator.FromHtml("#7fff00");
                            dataGridViewProduct[3, ind].Style.BackColor = ColorTranslator.FromHtml("#7fff00");
                        }
                    }
                }

                int count = Helper.DB.Product.Count();

                labelCount.Text = (ind + 1) + " из " + count;
            }
        }

        private void filter(Object sender, EventArgs e)
        {
            updateProduct();
        }

        private void dataGridViewProduct_Click(object sender, EventArgs e)
        {
            if (Helper.Role == Roles.Администратор)
            {
                Helper.FormEvent = FormEvents.Редактирование;
                FormChangeProduct formChangeProduct = new FormChangeProduct(dataGridViewProduct[0, dataGridViewProduct.CurrentRow.Index].Value.ToString());
                Hide();
                formChangeProduct.ShowDialog();
                Show();
                updateProduct();
            }
        }

        /// <summary>
        /// Добавить товар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Helper.FormEvent = FormEvents.Добавление;
            FormChangeProduct formChangeProduct = new FormChangeProduct();
            Hide();
            formChangeProduct.ShowDialog();
            Show();
            updateProduct();
        }

        /// <summary>
        /// Показать заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
