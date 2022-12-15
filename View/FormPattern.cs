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
    public partial class FormPattern : Form
    {
        public FormPattern()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPattern_Load(object sender, EventArgs e)
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
    }
}
