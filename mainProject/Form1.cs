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
    public partial class Form1 : Form
    {
        public static int totalItemsValue = 0;
        public static int leftItemsValue = 0;
        public static int finishedItemsValue = 0;
        public static int totalPaperPrint = 0;
        public static int heatDegree = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void init_Date_From_modal()
        {
            totalItems.Text = totalItemsValue.ToString();
            leftItem.Text   = leftItemsValue.ToString();

            if(totalItemsValue > 0)
            {
                start_simulation.Enabled = true;
                start_simulation.BackColor = Color.LightBlue;
            }
        }

        private void init_variables(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.ShowDialog();
            init_Date_From_modal();
        }

        private void start_simulation_Click(object sender, EventArgs e)
        {
            set_paper_printer.Enabled = true;
            heat_press.Enabled = true;


            radio_check_paper_print.Checked = true;

            system_state.Text = "النظام في حالة عمل";
            system_state.BackColor = Color.LightGreen;
        }

        private void set_paper_printer_Tick(object sender, EventArgs e)
        {
            if (totalPaperPrint <= leftItemsValue)
            {
                print_paper.Enabled = true;
                radio_print_paper.Checked = true;
            }
        }

        private void print_paper_Tick(object sender, EventArgs e)
        {
            if (totalPaperPrint <= leftItemsValue)
            {
                paper_printer_number.Text = (totalPaperPrint++).ToString();
            }
            else
            {
                print_paper.Enabled = false;
            }
        }

        private void action_print_Item_Timer_Tick(object sender, EventArgs e)
        {
            //if ()
            //{

            //}
        }

        private void heat_press_Tick(object sender, EventArgs e)
        {
            if (heatDegree <= 180)
            {
                heatDegree += 4;
                heat_degree.Text = heatDegree.ToString() + " Cْ";
                heat_degree_progressBar.Value = heatDegree / 2;
            }
        }
    }
}
