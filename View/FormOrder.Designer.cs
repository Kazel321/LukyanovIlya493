namespace PerfumeWorld
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelOrderContent = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelProductPhoto = new System.Windows.Forms.Label();
            this.labelOrderInfo = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelProductInfo = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.textBoxProductInfo = new System.Windows.Forms.TextBox();
            this.textBoxOrderInfo = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.listBoxPoints = new System.Windows.Forms.ListBox();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonCreateCoupon = new System.Windows.Forms.Button();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
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
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1189, 50);
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
            this.buttonReturn.Location = new System.Drawing.Point(1092, 3);
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
            this.labelTitle.Size = new System.Drawing.Size(983, 50);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Заказ";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Controls.Add(this.buttonCreateOrder, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.buttonCreateCoupon, 1, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 580);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(1189, 50);
            this.tableLayoutPanelBottom.TabIndex = 1;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.Controls.Add(this.labelOrderContent, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelFullName, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelProductPhoto, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelOrderInfo, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelPoints, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelProductInfo, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewOrder, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxProductInfo, 2, 3);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxOrderInfo, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxPhoto, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.listBoxPoints, 1, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1189, 530);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // labelOrderContent
            // 
            this.labelOrderContent.AutoSize = true;
            this.labelOrderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrderContent.Location = new System.Drawing.Point(3, 0);
            this.labelOrderContent.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelOrderContent.Name = "labelOrderContent";
            this.labelOrderContent.Size = new System.Drawing.Size(390, 43);
            this.labelOrderContent.TabIndex = 0;
            this.labelOrderContent.Text = "Состав заказа";
            this.labelOrderContent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFullName.Location = new System.Drawing.Point(399, 0);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(390, 43);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "ФИО";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelProductPhoto
            // 
            this.labelProductPhoto.AutoSize = true;
            this.labelProductPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductPhoto.Location = new System.Drawing.Point(795, 0);
            this.labelProductPhoto.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelProductPhoto.Name = "labelProductPhoto";
            this.labelProductPhoto.Size = new System.Drawing.Size(391, 43);
            this.labelProductPhoto.TabIndex = 2;
            this.labelProductPhoto.Text = "Фото товара";
            this.labelProductPhoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelOrderInfo
            // 
            this.labelOrderInfo.AutoSize = true;
            this.labelOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrderInfo.Location = new System.Drawing.Point(3, 265);
            this.labelOrderInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelOrderInfo.Name = "labelOrderInfo";
            this.labelOrderInfo.Size = new System.Drawing.Size(390, 43);
            this.labelOrderInfo.TabIndex = 3;
            this.labelOrderInfo.Text = "Описание заказа";
            this.labelOrderInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPoints.Location = new System.Drawing.Point(399, 265);
            this.labelPoints.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(390, 43);
            this.labelPoints.TabIndex = 4;
            this.labelPoints.Text = "Пункты выдачи";
            this.labelPoints.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelProductInfo
            // 
            this.labelProductInfo.AutoSize = true;
            this.labelProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductInfo.Location = new System.Drawing.Point(795, 265);
            this.labelProductInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelProductInfo.Name = "labelProductInfo";
            this.labelProductInfo.Size = new System.Drawing.Size(391, 43);
            this.labelProductInfo.TabIndex = 5;
            this.labelProductInfo.Text = "Описание товара";
            this.labelProductInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.AllowUserToResizeColumns = false;
            this.dataGridViewOrder.AllowUserToResizeRows = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProductName,
            this.ColumnProductCount,
            this.ColumnDel});
            this.tableLayoutPanelMain.SetColumnSpan(this.dataGridViewOrder, 2);
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrder.Location = new System.Drawing.Point(3, 56);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersVisible = false;
            this.dataGridViewOrder.Size = new System.Drawing.Size(786, 206);
            this.dataGridViewOrder.TabIndex = 6;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellContentClick);
            this.dataGridViewOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellEndEdit);
            this.dataGridViewOrder.SelectionChanged += new System.EventHandler(this.dataGridViewOrder_SelectionChanged);
            // 
            // textBoxProductInfo
            // 
            this.textBoxProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProductInfo.Location = new System.Drawing.Point(795, 321);
            this.textBoxProductInfo.Multiline = true;
            this.textBoxProductInfo.Name = "textBoxProductInfo";
            this.textBoxProductInfo.ReadOnly = true;
            this.textBoxProductInfo.Size = new System.Drawing.Size(391, 206);
            this.textBoxProductInfo.TabIndex = 8;
            // 
            // textBoxOrderInfo
            // 
            this.textBoxOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOrderInfo.Location = new System.Drawing.Point(3, 321);
            this.textBoxOrderInfo.Multiline = true;
            this.textBoxOrderInfo.Name = "textBoxOrderInfo";
            this.textBoxOrderInfo.ReadOnly = true;
            this.textBoxOrderInfo.Size = new System.Drawing.Size(390, 206);
            this.textBoxOrderInfo.TabIndex = 9;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(795, 56);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(391, 206);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 10;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.IntegralHeight = false;
            this.listBoxPoints.ItemHeight = 23;
            this.listBoxPoints.Location = new System.Drawing.Point(399, 321);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(390, 206);
            this.listBoxPoints.TabIndex = 11;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateOrder.Location = new System.Drawing.Point(50, 3);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(494, 44);
            this.buttonCreateOrder.TabIndex = 0;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonCreateCoupon
            // 
            this.buttonCreateCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateCoupon.Enabled = false;
            this.buttonCreateCoupon.Location = new System.Drawing.Point(644, 3);
            this.buttonCreateCoupon.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.buttonCreateCoupon.Name = "buttonCreateCoupon";
            this.buttonCreateCoupon.Size = new System.Drawing.Size(495, 44);
            this.buttonCreateCoupon.TabIndex = 1;
            this.buttonCreateCoupon.Text = "Сформировать талон";
            this.buttonCreateCoupon.UseVisualStyleBackColor = true;
            this.buttonCreateCoupon.Click += new System.EventHandler(this.buttonCreateCoupon_Click);
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnProductName.HeaderText = "Название товара";
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            // 
            // ColumnProductCount
            // 
            this.ColumnProductCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnProductCount.HeaderText = "Количество";
            this.ColumnProductCount.Name = "ColumnProductCount";
            // 
            // ColumnDel
            // 
            this.ColumnDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDel.HeaderText = "Управление";
            this.ColumnDel.Name = "ColumnDel";
            this.ColumnDel.ReadOnly = true;
            this.ColumnDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 630);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1205, 669);
            this.Name = "FormOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonCreateCoupon;
        private System.Windows.Forms.Label labelOrderContent;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelProductPhoto;
        private System.Windows.Forms.Label labelOrderInfo;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelProductInfo;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.TextBox textBoxProductInfo;
        private System.Windows.Forms.TextBox textBoxOrderInfo;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.ListBox listBoxPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductCount;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDel;
    }
}

