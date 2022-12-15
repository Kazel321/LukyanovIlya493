namespace PerfumeWorld
{
    partial class FormChangeProduct
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeProduct));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelArticle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelMaxSale = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.numericUpDownMaxSale = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.numericUpDownSale = new System.Windows.Forms.NumericUpDown();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.buttonDelPhoto = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTop.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonReturn, 2, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(853, 50);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::PerfumeWorld.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReturn.Location = new System.Drawing.Point(756, 3);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 44);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Location = new System.Drawing.Point(103, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(53, 0, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(647, 50);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Товар";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Controls.Add(this.buttonSave, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.buttonDel, 1, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 502);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(853, 50);
            this.tableLayoutPanelBottom.TabIndex = 1;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.textBoxDesc, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelArticle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelUnit, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelCost, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelMaxSale, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.labelManufacturer, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelProvider, 0, 6);
            this.tableLayoutPanelMain.Controls.Add(this.labelCategory, 0, 7);
            this.tableLayoutPanelMain.Controls.Add(this.labelSale, 0, 8);
            this.tableLayoutPanelMain.Controls.Add(this.labelCount, 0, 9);
            this.tableLayoutPanelMain.Controls.Add(this.labelDesc, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelPhoto, 2, 4);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxArticle, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxCost, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownMaxSale, 1, 4);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxUnit, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxManufacturer, 1, 5);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxProvider, 1, 6);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxCategory, 1, 7);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownSale, 1, 8);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxCount, 1, 9);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxPhoto, 2, 5);
            this.tableLayoutPanelMain.Controls.Add(this.buttonAddPhoto, 2, 9);
            this.tableLayoutPanelMain.Controls.Add(this.buttonDelPhoto, 3, 9);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 10;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(853, 452);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // labelArticle
            // 
            this.labelArticle.AutoSize = true;
            this.labelArticle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelArticle.Location = new System.Drawing.Point(3, 12);
            this.labelArticle.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(205, 23);
            this.labelArticle.TabIndex = 0;
            this.labelArticle.Text = "Артикул:";
            this.labelArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Location = new System.Drawing.Point(3, 57);
            this.labelName.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(205, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUnit.Location = new System.Drawing.Point(3, 102);
            this.labelUnit.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(205, 23);
            this.labelUnit.TabIndex = 2;
            this.labelUnit.Text = "Единицы измерения:";
            this.labelUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCost.Location = new System.Drawing.Point(3, 147);
            this.labelCost.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(205, 23);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Цена:";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelManufacturer.Location = new System.Drawing.Point(3, 237);
            this.labelManufacturer.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(205, 23);
            this.labelManufacturer.TabIndex = 4;
            this.labelManufacturer.Text = "Производитель:";
            this.labelManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaxSale
            // 
            this.labelMaxSale.AutoSize = true;
            this.labelMaxSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMaxSale.Location = new System.Drawing.Point(3, 192);
            this.labelMaxSale.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelMaxSale.Name = "labelMaxSale";
            this.labelMaxSale.Size = new System.Drawing.Size(205, 23);
            this.labelMaxSale.TabIndex = 5;
            this.labelMaxSale.Text = "Максимальная скидка:";
            this.labelMaxSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCategory.Location = new System.Drawing.Point(3, 327);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(205, 23);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Категория:";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProvider.Location = new System.Drawing.Point(3, 282);
            this.labelProvider.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(205, 23);
            this.labelProvider.TabIndex = 7;
            this.labelProvider.Text = "Поставщик:";
            this.labelProvider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSale.Location = new System.Drawing.Point(3, 372);
            this.labelSale.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(205, 23);
            this.labelSale.TabIndex = 8;
            this.labelSale.Text = "Текущая скидка:";
            this.labelSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCount.Location = new System.Drawing.Point(3, 417);
            this.labelCount.Margin = new System.Windows.Forms.Padding(3, 12, 5, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(205, 23);
            this.labelCount.TabIndex = 9;
            this.labelCount.Text = "Количество:";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelDesc, 2);
            this.labelDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDesc.Location = new System.Drawing.Point(429, 0);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(421, 35);
            this.labelDesc.TabIndex = 10;
            this.labelDesc.Text = "Описание";
            this.labelDesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelPhoto, 2);
            this.labelPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPhoto.Location = new System.Drawing.Point(429, 180);
            this.labelPhoto.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(421, 35);
            this.labelPhoto.TabIndex = 11;
            this.labelPhoto.Text = "Фото";
            this.labelPhoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxArticle.Location = new System.Drawing.Point(216, 10);
            this.textBoxArticle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(207, 30);
            this.textBoxArticle.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(216, 55);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 30);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCost.Location = new System.Drawing.Point(216, 145);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(207, 30);
            this.textBoxCost.TabIndex = 14;
            // 
            // numericUpDownMaxSale
            // 
            this.numericUpDownMaxSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMaxSale.Location = new System.Drawing.Point(216, 190);
            this.numericUpDownMaxSale.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.numericUpDownMaxSale.Name = "numericUpDownMaxSale";
            this.numericUpDownMaxSale.Size = new System.Drawing.Size(207, 30);
            this.numericUpDownMaxSale.TabIndex = 15;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(216, 100);
            this.comboBoxUnit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(207, 31);
            this.comboBoxUnit.TabIndex = 16;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(216, 235);
            this.comboBoxManufacturer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(207, 31);
            this.comboBoxManufacturer.TabIndex = 17;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(216, 280);
            this.comboBoxProvider.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(207, 31);
            this.comboBoxProvider.TabIndex = 18;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(216, 325);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(207, 31);
            this.comboBoxCategory.TabIndex = 19;
            // 
            // numericUpDownSale
            // 
            this.numericUpDownSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownSale.Location = new System.Drawing.Point(216, 370);
            this.numericUpDownSale.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.numericUpDownSale.Name = "numericUpDownSale";
            this.numericUpDownSale.Size = new System.Drawing.Size(207, 30);
            this.numericUpDownSale.TabIndex = 20;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCount.Location = new System.Drawing.Point(216, 415);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(207, 30);
            this.textBoxCount.TabIndex = 21;
            // 
            // textBoxDesc
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.textBoxDesc, 2);
            this.textBoxDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDesc.Location = new System.Drawing.Point(429, 48);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.tableLayoutPanelMain.SetRowSpan(this.textBoxDesc, 3);
            this.textBoxDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDesc.Size = new System.Drawing.Size(421, 129);
            this.textBoxDesc.TabIndex = 22;
            // 
            // pictureBoxPhoto
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.pictureBoxPhoto, 2);
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(429, 228);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.tableLayoutPanelMain.SetRowSpan(this.pictureBoxPhoto, 4);
            this.pictureBoxPhoto.Size = new System.Drawing.Size(421, 174);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 23;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddPhoto.Location = new System.Drawing.Point(429, 408);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(207, 41);
            this.buttonAddPhoto.TabIndex = 24;
            this.buttonAddPhoto.Text = "Добавить фото";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // buttonDelPhoto
            // 
            this.buttonDelPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelPhoto.Location = new System.Drawing.Point(642, 408);
            this.buttonDelPhoto.Name = "buttonDelPhoto";
            this.buttonDelPhoto.Size = new System.Drawing.Size(208, 41);
            this.buttonDelPhoto.TabIndex = 25;
            this.buttonDelPhoto.Text = "Удалить фото";
            this.buttonDelPhoto.UseVisualStyleBackColor = true;
            this.buttonDelPhoto.Click += new System.EventHandler(this.buttonDelPhoto_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(50, 3);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(326, 44);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить товар";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDel.Location = new System.Drawing.Point(476, 3);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(327, 44);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Удалить товар";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 552);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(869, 591);
            this.Name = "FormChangeProduct";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.FormChangeProduct_Load);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelMaxSale;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSale;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownSale;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.Button buttonDelPhoto;
    }
}

