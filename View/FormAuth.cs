using PerfumeWorld.Classes;
using PerfumeWorld.Classes.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfumeWorld
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAuth_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelBottom.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelMain.BackColor = Color.FromArgb(255, 255, 255);
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
        /// Авторизация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            Button button = (Button)sender;
            if (button.Text == buttonLogin.Text)
            {
                string login = textBoxLogin.Text;
                string passwd = textBoxPassword.Text;
                User user = Helper.DB.User.Where(x => (x.UserLogin == login) && (x.UserPassword == passwd)).FirstOrDefault();
                if (user != null)
                {
                    Helper.UserId = user.UserId;
                    Helper.Role = (Roles)user.RoleId;
                    Helper.UserFullName = user.UserFullName;
                    isSuccess = true;
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный логин или пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Helper.UserId = 0;
                Helper.Role = Roles.Гость;
                Helper.UserFullName = null;
                isSuccess = true;
            }
            if (isSuccess)
            {
                FormProduct formProduct = new FormProduct();
                MessageBox.Show("Вы вошли с ролью " + Helper.Role, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                formProduct.ShowDialog();
                Show();
            }
        }
    }
}
