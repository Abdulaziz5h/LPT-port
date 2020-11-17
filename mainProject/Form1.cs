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
    // should add var and asign tootal value to it and compare exprition
    public partial class Form1 : Form
    {
        public static int totalItemsValue = 0;
        public static int leftItemsValue = 0;
        public static int finishedItemsValue = 0;
        public static int totalPaperPrint = 0;
        public static int heatDegree = 0;
        public static bool systemState = false;

        // قيمة حساس وجود قماش تعاد على المنفذ leftItemsValue = IN6
        // قيمة حساس وجود ورق طباعة تعاد على المنفذ totalPaperPrint = IN3
        // قيمة حساس الحرارة تعاد على المنفذ heatDegree = IN5

        // Out0 <= print paper
        // Out1 <= heat press
        // Out3 <= Piston pressure

        int Input, Output;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Output = 0;
            //Out32(0x37A, 0x0B);
            //Out32(0x378, 0x20);
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

            systemState = true;
            // start check paper's print
            set_paper_printer.Enabled = true;
            action_print_Item_Timer.Enabled = true;

            // start check system satatus and heat degree
            heat_press.Enabled = true;

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
            // check is need to paper
            // leftItemsValue = IN6, totalPaperPrint = IN3
            if (leftItemsValue > 0 && totalPaperPrint == 0)// if(((Input & 0xC0) == 0xC0) && ((Input & 0x88) != 0x88))
            {
                // 0x0A = 0000 1010
                // Output &= 0x0A; Out0 = 1
                checkBox_check_paper_print.Checked = true;
                checkBox_print_paper.Checked = true;

                print_paper.Enabled = true;
            }
        }


        private void print_paper_Tick(object sender, EventArgs e)
        {
            // print paper
            paper_printer_number.Text = (++totalPaperPrint).ToString();
            // 0x01 = 0000 0001
            // Output |= 0x01; Out0 = 0
            print_paper.Enabled = false;
            checkBox_print_paper.Checked = false;
        }


        private void action_print_Item_Timer_Tick(object sender, EventArgs e)
        {
            // فحص وقيمة حساس وجود قطع للطباعة    
            // 0xC0 = 1100 0000
            if (leftItemsValue != 0) // if (input & 0xC0 == 0xC0)
            {
                // فحص وقيمة حساس وجود  ورق طباعة وفحص حالة حساس الحرارة
                // 0xA8 = 1010 1000
                if (heatDegree <= 88 && heatDegree >= 80 && totalPaperPrint != 0) // if(( (input & 0x88) == 0x88 ) && ( (dataIn & 0x58) <= 0x58 ) && ( (dataIn & 0x50) >= 0x50))
                {
                    //Out32(0x378, 0x20);
                    // ضغط المكبس على القماش
                    // 0x03 = 0000 0011
                    // Output &= 0x03; Out3 = 1
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
                //Out32(0x378, 0x20);
            }
            else
            {
                finish_semulation_method();
            }
        }


        private void heat_press_Tick(object sender, EventArgs e)
        {
            // قيمة حساس الحرارة تعاد على المنافذ data ports
            // التي تعيد قيمة درجة الحرارة
            // 0x58 = 0101 1000
            if (heatDegree < 88 && systemState) // if((dataIn & 0x58) < 0x58)
            {
                //Out32(0x378, 0x20);
                heatDegree = heatDegree < 24 ? heatDegree + 4 : heatDegree + 8;
            } else
            {
                //Out32(0x378, 0x20);
                heatDegree = heatDegree <= 24 ? heatDegree - 4 : heatDegree - 8;
                if (heatDegree == 0)
                {
                    heat_press.Enabled = false;
                    press_state.BackColor = Color.Gray;
                }
            }
            heat_degree.Text = heatDegree.ToString() + " Cْ";
            heat_degree_progressBar.Value = heatDegree;
        }


        private void finish_semulation_Click(object sender, EventArgs e)
        {
            finish_semulation_method();
        }
        
        
        public void finish_semulation_method()
        {
            // 0x0B = 0000 1011
            // Output = 0x0B; Out1 = 0, Out2 = 0, Out3 = 0, Out4 = 0;
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
            // رفع المكبس بعد نهاية الطباعة
            // 0x08 = 0000 1000
            // Output |= 0x08; Out3 = 0
        }

    }
}
