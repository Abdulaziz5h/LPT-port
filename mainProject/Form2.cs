using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SetNumItems_Click(object sender, EventArgs e)
        {
            if((int)totalItemsTextBox.Value > 0)
            {
                Form1.totalItemsValue = (int)totalItemsTextBox.Value;
                Form1.leftItemsValue = (int)totalItemsTextBox.Value;
                this.Close();
            } else {
                errorHandle.Visible = true;
            }
        }

        private void closeSetItemForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
