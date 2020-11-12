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
        public static bool systemState = false;
        
        byte Input, Data;

        public Form1()
        {
            InitializeComponent();
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
            action_print_Item_Timer.Enabled = true;

            systemState = true;
            checkBox_check_paper_print.Checked = true;

            system_state.Text = "النظام في حالة عمل";
            system_state.BackColor = Color.LightGreen;
            set_system_variables.Text = "تعديل عدد القصة";

            finish_semulation.Enabled = true;
            finish_semulation.BackColor = Color.LightBlue;

            start_simulation.Enabled = false;
            start_simulation.BackColor = Color.WhiteSmoke;
        }

        private void set_paper_printer_Tick(object sender, EventArgs e)
        {
            if (totalPaperPrint <= leftItemsValue)
            {
                checkBox_check_paper_print.Checked = true;
                print_paper.Enabled = true; 
            }
        }

        private void print_paper_Tick(object sender, EventArgs e)
        {
            if (totalPaperPrint <= leftItemsValue)
            {
                checkBox_print_paper.Checked = true;
                paper_printer_number.Text = (totalPaperPrint++).ToString();
            }
            else
            {
                checkBox_print_paper.Checked = false;
                print_paper.Enabled = false; 
            }
        }

        private void action_print_Item_Timer_Tick(object sender, EventArgs e)
        {
            if(leftItemsValue != 0)
            {
                if (heatDegree <= 180 && heatDegree >= 172 && totalPaperPrint != 0)
                {
                    action_print_Item_Timer.Enabled = false;
                    checkBox_set_system_vars.Checked = false;
                    checkBox_action_print.Checked = true;
                    leftItemsValue--;
                    totalPaperPrint--;
                    finishedItemsValue++;
                    leftItem.Text = leftItemsValue.ToString();
                    paper_printer_number.Text = totalPaperPrint.ToString();
                    finished_item_printed.Text = finishedItemsValue.ToString();
                    set_system_var_timer.Enabled = true;
                    press_state.BackColor = Color.DarkRed;
                }
            }
            else
            {
                finish_semulation_method();
            }
        }

        private void heat_press_Tick(object sender, EventArgs e)
        {
            if (heatDegree < 180 && systemState)
            {
                heatDegree = heatDegree < 28 ? heatDegree + 4 : heatDegree + 8;
            } else
            {
                heatDegree = heatDegree < 28 ? heatDegree - 4 : heatDegree - 8;
                if (heatDegree == 0)
                {
                    heat_press.Enabled = false;
                    press_state.BackColor = Color.Gray;
                }
            }
            heat_degree.Text = heatDegree.ToString() + " Cْ";
            heat_degree_progressBar.Value = heatDegree / 2;
        }

        private void finish_semulation_Click(object sender, EventArgs e)
        {
            finish_semulation_method();
        }
        public void finish_semulation_method()
        {
            set_paper_printer.Enabled = false;
            print_paper.Enabled = false;
            action_print_Item_Timer.Enabled = false;

            systemState = false;

            set_system_variables.Text = "تحديد عدد القصة";
            system_state.Text = "النظام في حالة توقف";
            system_state.BackColor = Color.Silver;

            checkBox_set_system_vars.Checked = false;
            checkBox_action_print.Checked = false;
            finish_semulation.Enabled = false;
            finish_semulation.BackColor = Color.WhiteSmoke;
            press_state.BackColor = Color.Gray;

            if (leftItemsValue == 0)
            {
                start_simulation.Enabled = false;
                start_simulation.BackColor = Color.WhiteSmoke;
                set_system_var_timer.Enabled = false;

            } else
            {
                start_simulation.Enabled = true;
                start_simulation.BackColor = Color.LightBlue;
            }
        }

        private void set_system_var_timer_Tick(object sender, EventArgs e)
        {
            checkBox_set_system_vars.Checked = true;
            checkBox_action_print.Checked = false;
            action_print_Item_Timer.Enabled = true;
            set_system_var_timer.Enabled = false;
            press_state.BackColor = Color.DarkGreen;
        }
    }
}
