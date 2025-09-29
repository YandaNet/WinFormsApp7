using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            if (txtWord.Text.Trim() == "" || txtMeaning.Text.Trim() == "")
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelWord_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
