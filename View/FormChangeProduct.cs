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
    public partial class FormChangeProduct : Form
    {
        string article;
        Image img = null;
        string path = Application.StartupPath + "\\Resources\\Товар_import\\";
        string photoPath;
        OpenFileDialog openFileDialog;

        public FormChangeProduct()
        {
            InitializeComponent();
        }

        public FormChangeProduct(string article)
        {
            this.article = article;
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormChangeProduct_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelBottom.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelMain.BackColor = Color.FromArgb(255, 255, 255);

            comboBoxCategory.DataSource = Helper.DB.Category.Select(x => x.CategoryName).ToList();
            comboBoxManufacturer.DataSource = Helper.DB.Manufacturer.Select(x => x.ManufacturerName).ToList();
            comboBoxUnit.DataSource = Helper.DB.Unit.Select(x => x.UnitName).ToList();
            comboBoxProvider.DataSource = Helper.DB.Provider.Select(x => x.ProviderName).ToList();

            comboBoxCategory.SelectedIndex = 0;
            comboBoxManufacturer.SelectedIndex = 0;
            comboBoxUnit.SelectedIndex = 0;
            comboBoxProvider.SelectedIndex = 0;

            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.jpg";

            if (article != null)
            {
                Product product = Helper.DB.Product.Where(x => x.ProductArticle == article).FirstOrDefault();
                textBoxArticle.Enabled = false;
                textBoxArticle.Text = article;
                textBoxName.Text = product.ProductName;
                comboBoxUnit.SelectedIndex = product.UnitId - 1;
                textBoxCost.Text = product.ProductCost.ToString();
                numericUpDownMaxSale.Value = product.ProductMaxSale;
                comboBoxManufacturer.SelectedIndex = product.ManufacturerId - 1;
                comboBoxProvider.SelectedIndex = product.ProviderId - 1;
                comboBoxCategory.SelectedIndex = product.CategoryId - 1;
                numericUpDownSale.Value = product.ProductSale;
                textBoxCount.Text = product.ProductCount.ToString();
                textBoxDesc.Text = product.ProductDescription;
                
                if (!String.IsNullOrEmpty(product.ProductPhoto))
                {
                    Bitmap bmp = new Bitmap(path + product.ProductPhoto);
                    MemoryStream memoryStream = new MemoryStream();
                    bmp.Save(memoryStream, ImageFormat.Jpeg);
                    bmp.Dispose();
                    img = Image.FromStream(memoryStream);
                    memoryStream.Close();
                    pictureBoxPhoto.Image = img;
                }
            }

            if (Helper.FormEvent == FormEvents.Добавление) buttonDel.Enabled = false;
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
        /// Добавление фото
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Equals(path + article + ".jpg")) 
                    return;
                Bitmap bmp = new Bitmap(openFileDialog.FileName);
                MemoryStream memoryStream = new MemoryStream();
                bmp.Save(memoryStream, ImageFormat.Jpeg);
                bmp.Dispose();
                img = Image.FromStream(memoryStream);
                memoryStream.Close();
                pictureBoxPhoto.Image = img;
                photoPath = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Удаление фото
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelPhoto_Click(object sender, EventArgs e)
        {
            img = null;
            pictureBoxPhoto.Image = img;
        }

        /// <summary>
        /// Сохранение товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxArticle.Text) || String.IsNullOrEmpty(textBoxCost.Text) || String.IsNullOrEmpty(textBoxCount.Text) || String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(numericUpDownMaxSale.Value.ToString()) || String.IsNullOrEmpty(numericUpDownSale.Value.ToString()))
            {
                MessageBox.Show("Вы заполнили не все данные", "Сохранение товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            article = textBoxArticle.Text;
            string cost = textBoxCost.Text;
            string count = textBoxCount.Text;
            string name = textBoxName.Text;
            string desc = textBoxDesc.Text;

            int countValue;
            double costValue;

            try
            {
                countValue = (int)Convert.ToUInt32(count);
                costValue = Convert.ToDouble(cost);
            }
            catch
            {
                MessageBox.Show("Неправильный формат данных", "Сохранение товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (costValue <= 0)
            {
                MessageBox.Show("Цена не может быть равна нулю", "Сохранение товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (countValue <= 0)
            {
                MessageBox.Show("Количество не может быть равно нулю", "Сохранение товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maxSale = (int)numericUpDownMaxSale.Value;
            int sale = (int)numericUpDownSale.Value;

            if (maxSale < sale)
            {
                MessageBox.Show("Максимальная скидка не может быть меньше текущей", "Сохранение товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product newProduct;
            if (Helper.FormEvent == FormEvents.Добавление)
            {
                var findArticle = Helper.DB.Product.Where(x => x.ProductArticle == article).FirstOrDefault();
                if (findArticle != null)
                {
                    MessageBox.Show("Товар с таким артикулем уже существует", "Сохранение товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newProduct = new Product();
            }
            else
            {
                newProduct = Helper.DB.Product.Where(x => x.ProductArticle == article).FirstOrDefault();
            }

            newProduct.ProductArticle = article;
            newProduct.ProductName = name;
            newProduct.UnitId = comboBoxUnit.SelectedIndex + 1;
            newProduct.ProductCost = costValue;
            newProduct.ProductMaxSale = maxSale;
            newProduct.ManufacturerId = comboBoxManufacturer.SelectedIndex + 1;
            newProduct.ProviderId = comboBoxProvider.SelectedIndex + 1;
            newProduct.CategoryId = comboBoxCategory.SelectedIndex + 1;
            newProduct.ProductSale = sale;
            newProduct.ProductDescription = desc;

            if (img == null)
            {
                newProduct.ProductPhoto = null;
            }
            else if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                if (File.Exists(path + article + ".jpg")) File.Delete(path + article + ".jpg");
                if (!String.IsNullOrEmpty(photoPath))
                    File.Copy(photoPath, path + article + ".jpg");
                newProduct.ProductPhoto = article + ".jpg";
            }

            if (Helper.FormEvent == FormEvents.Добавление)
            {
                Helper.DB.Product.Add(newProduct);
            }

            Helper.DB.SaveChanges();

            MessageBox.Show("Товар сохранен", "Сохранение товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDel_Click(object sender, EventArgs e)
        {
            Product product = Helper.DB.Product.Where(x => x.ProductArticle == article).FirstOrDefault();
            Helper.DB.Product.Remove(product);
            Helper.DB.SaveChanges();
            MessageBox.Show("Товар удален", "Сохранение товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
