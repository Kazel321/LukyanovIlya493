namespace PerfumeWorld
{
    partial class FormProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonShowOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameCount = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.ColumnArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCost = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
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
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1116, 50);
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
            this.buttonReturn.Location = new System.Drawing.Point(1019, 3);
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
            this.labelTitle.Size = new System.Drawing.Size(910, 50);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Каталог товаров";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Controls.Add(this.buttonAddProduct, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.buttonShowOrder, 1, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 586);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(1116, 50);
            this.tableLayoutPanelBottom.TabIndex = 1;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddProduct.Location = new System.Drawing.Point(50, 3);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(458, 44);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Добавить товар";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Visible = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonShowOrder
            // 
            this.buttonShowOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowOrder.Location = new System.Drawing.Point(608, 3);
            this.buttonShowOrder.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.buttonShowOrder.Name = "buttonShowOrder";
            this.buttonShowOrder.Size = new System.Drawing.Size(458, 44);
            this.buttonShowOrder.TabIndex = 1;
            this.buttonShowOrder.Text = "Показать заказ";
            this.buttonShowOrder.UseVisualStyleBackColor = true;
            this.buttonShowOrder.Visible = false;
            this.buttonShowOrder.Click += new System.EventHandler(this.buttonShowOrder_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 6;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelMain.Controls.Add(this.labelNameCount, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelCost, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelDiscount, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelNameProduct, 4, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelCount, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelFullName, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewProduct, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxCost, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxDiscount, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxProductName, 5, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1116, 536);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // labelNameCount
            // 
            this.labelNameCount.AutoSize = true;
            this.labelNameCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameCount.Location = new System.Drawing.Point(3, 0);
            this.labelNameCount.Name = "labelNameCount";
            this.labelNameCount.Size = new System.Drawing.Size(179, 53);
            this.labelNameCount.TabIndex = 0;
            this.labelNameCount.Text = "Количество товаров: ";
            this.labelNameCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCost.Location = new System.Drawing.Point(3, 65);
            this.labelCost.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(179, 23);
            this.labelCost.TabIndex = 1;
            this.labelCost.Text = "Цена: ";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDiscount.Location = new System.Drawing.Point(373, 65);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(179, 23);
            this.labelDiscount.TabIndex = 2;
            this.labelDiscount.Text = "Скидка: ";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.AutoSize = true;
            this.labelNameProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNameProduct.Location = new System.Drawing.Point(743, 65);
            this.labelNameProduct.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(179, 23);
            this.labelNameProduct.TabIndex = 3;
            this.labelNameProduct.Text = "Название: ";
            this.labelNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCount.Location = new System.Drawing.Point(188, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(179, 53);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Count";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelFullName, 3);
            this.labelFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFullName.Location = new System.Drawing.Point(558, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(555, 53);
            this.labelFullName.TabIndex = 5;
            this.labelFullName.Text = "ФИО";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AllowUserToResizeColumns = false;
            this.dataGridViewProduct.AllowUserToResizeRows = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.ColumnHeadersVisible = false;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnArticle,
            this.ColumnPhoto,
            this.ColumnDesc,
            this.ColumnDiscount});
            this.tableLayoutPanelMain.SetColumnSpan(this.dataGridViewProduct, 6);
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.Location = new System.Drawing.Point(3, 109);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1110, 424);
            this.dataGridViewProduct.TabIndex = 6;
            this.dataGridViewProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewProduct_MouseClick);
            // 
            // ColumnArticle
            // 
            this.ColumnArticle.Frozen = true;
            this.ColumnArticle.HeaderText = "ColumnArticle";
            this.ColumnArticle.Name = "ColumnArticle";
            this.ColumnArticle.ReadOnly = true;
            this.ColumnArticle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnArticle.Visible = false;
            // 
            // ColumnPhoto
            // 
            this.ColumnPhoto.Frozen = true;
            this.ColumnPhoto.HeaderText = "ColumnPhoto";
            this.ColumnPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnPhoto.Name = "ColumnPhoto";
            this.ColumnPhoto.ReadOnly = true;
            this.ColumnPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPhoto.Width = 150;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDesc.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDesc.HeaderText = "ColumnDesc";
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDiscount
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDiscount.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDiscount.HeaderText = "ColumnDiscount";
            this.ColumnDiscount.Name = "ColumnDiscount";
            this.ColumnDiscount.ReadOnly = true;
            this.ColumnDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDiscount.Width = 400;
            // 
            // comboBoxCost
            // 
            this.comboBoxCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCost.FormattingEnabled = true;
            this.comboBoxCost.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.comboBoxCost.Location = new System.Drawing.Point(188, 63);
            this.comboBoxCost.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxCost.Name = "comboBoxCost";
            this.comboBoxCost.Size = new System.Drawing.Size(179, 31);
            this.comboBoxCost.TabIndex = 7;
            this.comboBoxCost.SelectedIndexChanged += new System.EventHandler(this.filter);
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Items.AddRange(new object[] {
            "все диапазоны",
            "0-10%",
            "11-14%",
            "15% и более"});
            this.comboBoxDiscount.Location = new System.Drawing.Point(558, 63);
            this.comboBoxDiscount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(179, 31);
            this.comboBoxDiscount.TabIndex = 8;
            this.comboBoxDiscount.SelectedIndexChanged += new System.EventHandler(this.filter);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProductName.Location = new System.Drawing.Point(928, 63);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(185, 30);
            this.textBoxProductName.TabIndex = 9;
            this.textBoxProductName.TextChanged += new System.EventHandler(this.filter);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 636);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1132, 675);
            this.Name = "FormProduct";
            this.Text = "Каталог товаров";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelNameCount;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelNameProduct;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.ComboBox comboBoxCost;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArticle;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscount;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonShowOrder;
    }
}

