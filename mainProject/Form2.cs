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
        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.systemState)
            {
                SetNumItems.Visible = false;
                dec_item_num.Visible = true;
                inc_item_num.Visible = true;
            }
            else
            {
                SetNumItems.Visible = true;
                dec_item_num.Visible = false;
                inc_item_num.Visible = false;
            }
        }
        private void SetNumItems_Click(object sender, EventArgs e)
        {
            if((int)totalItemsTextBox.Value > 0)
            {
                Form1.totalItemsValue   = +(int)totalItemsTextBox.Value;
                Form1.leftItemsValue    = (int)totalItemsTextBox.Value;
                this.Close();
            } else {
                errorHandle.Visible = true;
                errorHandle.Text    = "الرجاء تحديد قيمة اكبر من الصفر";
            }
        }

        private void closeSetItemForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inc_item_num_Click(object sender, EventArgs e)
        {
            Form1.totalItemsValue   += (int)totalItemsTextBox.Value;
            Form1.leftItemsValue    += (int)totalItemsTextBox.Value;
            
            this.Close();
        }

        private void dec_item_num_Click(object sender, EventArgs e)
        {
            if (Form1.leftItemsValue - (int)totalItemsTextBox.Value >= 0)
            {
                Form1.totalItemsValue -= (int)totalItemsTextBox.Value;
                Form1.leftItemsValue -= (int)totalItemsTextBox.Value;
                this.Close();
            }
            else
            {
                errorHandle.Visible = true;
                errorHandle.Text = "لايمكن انقاص الكمية المطلوبة لانه اكبر من عدد القطع المراد طباعتها";
            }
        }
    }
}
