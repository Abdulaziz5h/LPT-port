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

        // 1 In6 0 0 IN3 0 0 0
        // قيمة حساس وجود قماش تعاد على المنفذ leftItemsValue = IN6
        // قيمة حساس وجود ورق طباعة تعاد على المنفذ totalPaperPrint = IN3

        // قيمة حساس الحرارة تعاد على المنافذ heatDegree = dataInput

        // 0 0 Out5 0 Out3 0 Out1 Out0
        // Out0 <= print paper
        // Out1 <= heat press
        // Out2 <= not used 
        // Out3 <= Piston pressure
        // Out5 <= set dataPort to input

        int Input, Output, dataIn;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Output = 0;
            //0x2B = 0010 1011
            //Out32(0x37A, 0x2B);

            //dataIn = input32(0x378)
            //Input = input32(0x379)
        }


        public void init_Date_From_modal()
        {
            totalItems.Text = totalItemsValue.ToString();
            leftItem.Text   = leftItemsValue.ToString();

            if(leftItemsValue > 0) // if((Input & 0x40) == 0x40)
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
            if (leftItemsValue > 0 && totalPaperPrint == 0)// if(((Input & 0x40) == 0x40) && !((Input & 0x08) == 0x08))
            {
                // 0x2A = 0010 1010
                // Output &= 0x2A; Out0 = 1
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
            if (leftItemsValue > 0) // if (input & 0x40 == 0x40)
            {
                // فحص وقيمة حساس وجود  ورق طباعة وفحص حالة حساس الحرارة
                // 0x88 = 1000 1000
                // 0xB4 = 1011 0100
                // 0xA8 = 1010 1000
                // الشرط بفرض  اننا حولنا من منافذ الداتا قيمة عشرية لمعرفة درجة الحرارة
                if (heatDegree <= 180 && heatDegree >= 168 && totalPaperPrint != 0) // if(( (input & 0x08) == 0x08 ) && ( (dataIn & 0xB4) <= 0xB4 ) && ( (dataIn & 0xA8) >= 0xA8))
                {
                    // ضغط المكبس على القماش
                    // 0x23 = 0010 0011
                    // Output &= 0x23; Out3 = 1
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
            // قيمة حساس الحرارة تعاد على المنافذ data ports
            // التي تعيد قيمة درجة الحرارة
            // 0xB4 = 1011 0100
            if (heatDegree < 180 && systemState) // if((dataIn & 0xB4) < 0xB4)
            {
                // 0x29 = 0010 1001
                // Output &= 0x29; Out1 = 1
                heatDegree = heatDegree < 48 ? heatDegree + 8 : heatDegree + 12;
            } else
            {
                heatDegree = heatDegree <= 48 ? heatDegree - 8 : heatDegree - 12;
                if (heatDegree == 0)
                {
                    // 0x03 = 0000 0011
                    // Output |= 0x02; Out1 = 0
                    heat_press.Enabled = false;
                    press_state.BackColor = Color.Gray;
                }
            }
            heat_degree.Text = heatDegree.ToString() + " Cْ";
            heat_degree_progressBar.Value = heatDegree /2;
        }


        private void finish_semulation_Click(object sender, EventArgs e)
        {
            finish_semulation_method();
        }
        
        
        public void finish_semulation_method()
        {
            // 0x0B = 0010 1011
            // Output = 0x2B; Out1 = 0, Out2 = 0, Out3 = 0, Out4 = 0;
            set_paper_printer.Enabled = false;

            print_paper.Enabled = false;

            action_print_Item_Timer.Enabled = false;

            systemState = false;

            set_system_variables.Text = "تحديد عدد القصة";
            system_state.Text = "النظام في حالة توقف";
            system_state.BackColor = Color.Silver;
            
            checkBox_check_paper_print.Checked = false;

            checkBox_set_system_vars.Checked = false;
            checkBox_action_print.Checked = false;
            finish_semulation.Enabled = false;
            finish_semulation.BackColor = Color.WhiteSmoke;
            press_state.BackColor = Color.Gray;

            if (leftItemsValue == 0) // if(Input & 0x40) == 0x40)
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
