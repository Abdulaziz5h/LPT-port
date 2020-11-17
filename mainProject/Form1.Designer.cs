namespace mainProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.system_state = new System.Windows.Forms.Button();
            this.leftItem = new System.Windows.Forms.Label();
            this.finished_item_printed = new System.Windows.Forms.Label();
            this.totalItems = new System.Windows.Forms.Label();
            this.labe5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paper_printer_number = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.press_state = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_print_paper = new System.Windows.Forms.CheckBox();
            this.checkBox_action_print = new System.Windows.Forms.CheckBox();
            this.checkBox_set_system_vars = new System.Windows.Forms.CheckBox();
            this.checkBox_check_paper_print = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.heat_degree = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.heat_degree_progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.finish_semulation = new System.Windows.Forms.Button();
            this.set_system_variables = new System.Windows.Forms.Button();
            this.start_simulation = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.set_paper_printer = new System.Windows.Forms.Timer(this.components);
            this.print_paper = new System.Windows.Forms.Timer(this.components);
            this.action_print_Item_Timer = new System.Windows.Forms.Timer(this.components);
            this.heat_press = new System.Windows.Forms.Timer(this.components);
            this.set_system_var_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.system_state);
            this.groupBox1.Controls.Add(this.leftItem);
            this.groupBox1.Controls.Add(this.finished_item_printed);
            this.groupBox1.Controls.Add(this.totalItems);
            this.groupBox1.Controls.Add(this.labe5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.paper_printer_number);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(35, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(358, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حالة متحولات النظام";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(218, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "عدد قطع القصة";
            // 
            // system_state
            // 
            this.system_state.BackColor = System.Drawing.Color.Silver;
            this.system_state.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.system_state.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.system_state.Location = new System.Drawing.Point(39, 40);
            this.system_state.Name = "system_state";
            this.system_state.Size = new System.Drawing.Size(295, 32);
            this.system_state.TabIndex = 8;
            this.system_state.Text = "النظام في حالة توقف";
            this.system_state.UseVisualStyleBackColor = false;
            // 
            // leftItem
            // 
            this.leftItem.AutoSize = true;
            this.leftItem.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftItem.Location = new System.Drawing.Point(39, 216);
            this.leftItem.Name = "leftItem";
            this.leftItem.Size = new System.Drawing.Size(17, 24);
            this.leftItem.TabIndex = 7;
            this.leftItem.Text = "0";
            // 
            // finished_item_printed
            // 
            this.finished_item_printed.AutoSize = true;
            this.finished_item_printed.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finished_item_printed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finished_item_printed.Location = new System.Drawing.Point(39, 181);
            this.finished_item_printed.Name = "finished_item_printed";
            this.finished_item_printed.Size = new System.Drawing.Size(17, 24);
            this.finished_item_printed.TabIndex = 6;
            this.finished_item_printed.Text = "0";
            // 
            // totalItems
            // 
            this.totalItems.AutoSize = true;
            this.totalItems.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalItems.Location = new System.Drawing.Point(39, 104);
            this.totalItems.Name = "totalItems";
            this.totalItems.Size = new System.Drawing.Size(21, 29);
            this.totalItems.TabIndex = 5;
            this.totalItems.Text = "0";
            // 
            // labe5
            // 
            this.labe5.AutoSize = true;
            this.labe5.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labe5.Location = new System.Drawing.Point(240, 216);
            this.labe5.Name = "labe5";
            this.labe5.Size = new System.Drawing.Size(98, 24);
            this.labe5.TabIndex = 4;
            this.labe5.Text = "الكمية المتبقية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(218, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "ورق الطباعة المتوفر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(254, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(234, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "الكمية المطبوعة";
            // 
            // paper_printer_number
            // 
            this.paper_printer_number.AutoSize = true;
            this.paper_printer_number.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper_printer_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paper_printer_number.Location = new System.Drawing.Point(39, 140);
            this.paper_printer_number.Name = "paper_printer_number";
            this.paper_printer_number.Size = new System.Drawing.Size(17, 24);
            this.paper_printer_number.TabIndex = 0;
            this.paper_printer_number.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.press_state);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox_print_paper);
            this.groupBox2.Controls.Add(this.checkBox_action_print);
            this.groupBox2.Controls.Add(this.checkBox_set_system_vars);
            this.groupBox2.Controls.Add(this.checkBox_check_paper_print);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.heat_degree);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.heat_degree_progressBar);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(424, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(358, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "سير العملية";
            // 
            // press_state
            // 
            this.press_state.BackColor = System.Drawing.Color.Gray;
            this.press_state.Location = new System.Drawing.Point(322, 150);
            this.press_state.Name = "press_state";
            this.press_state.Size = new System.Drawing.Size(14, 14);
            this.press_state.TabIndex = 18;
            this.press_state.Text = "button1";
            this.press_state.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(234, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "حالة المكبس";
            // 
            // checkBox_print_paper
            // 
            this.checkBox_print_paper.AutoSize = true;
            this.checkBox_print_paper.Enabled = false;
            this.checkBox_print_paper.Location = new System.Drawing.Point(321, 256);
            this.checkBox_print_paper.Name = "checkBox_print_paper";
            this.checkBox_print_paper.Size = new System.Drawing.Size(15, 14);
            this.checkBox_print_paper.TabIndex = 16;
            this.checkBox_print_paper.UseVisualStyleBackColor = true;
            // 
            // checkBox_action_print
            // 
            this.checkBox_action_print.AutoSize = true;
            this.checkBox_action_print.Enabled = false;
            this.checkBox_action_print.Location = new System.Drawing.Point(320, 83);
            this.checkBox_action_print.Name = "checkBox_action_print";
            this.checkBox_action_print.Size = new System.Drawing.Size(15, 14);
            this.checkBox_action_print.TabIndex = 15;
            this.checkBox_action_print.UseVisualStyleBackColor = true;
            // 
            // checkBox_set_system_vars
            // 
            this.checkBox_set_system_vars.AutoSize = true;
            this.checkBox_set_system_vars.Enabled = false;
            this.checkBox_set_system_vars.Location = new System.Drawing.Point(321, 116);
            this.checkBox_set_system_vars.Name = "checkBox_set_system_vars";
            this.checkBox_set_system_vars.Size = new System.Drawing.Size(15, 14);
            this.checkBox_set_system_vars.TabIndex = 14;
            this.checkBox_set_system_vars.UseVisualStyleBackColor = true;
            // 
            // checkBox_check_paper_print
            // 
            this.checkBox_check_paper_print.AutoSize = true;
            this.checkBox_check_paper_print.Enabled = false;
            this.checkBox_check_paper_print.Location = new System.Drawing.Point(320, 52);
            this.checkBox_check_paper_print.Name = "checkBox_check_paper_print";
            this.checkBox_check_paper_print.Size = new System.Drawing.Size(15, 14);
            this.checkBox_check_paper_print.TabIndex = 13;
            this.checkBox_check_paper_print.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(204, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 24);
            this.label16.TabIndex = 12;
            this.label16.Text = "تجهيز ورق الطباعة";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(228, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 24);
            this.label15.TabIndex = 11;
            this.label15.Text = "عملية الطباعة";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(188, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "تعديل متحولات النظام";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(186, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 24);
            this.label13.TabIndex = 9;
            this.label13.Text = "التأكد من الورق الطباع";
            // 
            // heat_degree
            // 
            this.heat_degree.AutoSize = true;
            this.heat_degree.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heat_degree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.heat_degree.Location = new System.Drawing.Point(153, 208);
            this.heat_degree.Name = "heat_degree";
            this.heat_degree.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.heat_degree.Size = new System.Drawing.Size(30, 24);
            this.heat_degree.TabIndex = 8;
            this.heat_degree.Text = "0 Cْ ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(225, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "درجة حرارة المكبس";
            // 
            // heat_degree_progressBar
            // 
            this.heat_degree_progressBar.BackColor = System.Drawing.Color.White;
            this.heat_degree_progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.heat_degree_progressBar.Location = new System.Drawing.Point(189, 208);
            this.heat_degree_progressBar.Name = "heat_degree_progressBar";
            this.heat_degree_progressBar.Size = new System.Drawing.Size(146, 23);
            this.heat_degree_progressBar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox3.Controls.Add(this.finish_semulation);
            this.groupBox3.Controls.Add(this.set_system_variables);
            this.groupBox3.Controls.Add(this.start_simulation);
            this.groupBox3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(35, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(747, 105);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اساسيات النظام";
            // 
            // finish_semulation
            // 
            this.finish_semulation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.finish_semulation.Enabled = false;
            this.finish_semulation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finish_semulation.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_semulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finish_semulation.Location = new System.Drawing.Point(520, 42);
            this.finish_semulation.Name = "finish_semulation";
            this.finish_semulation.Size = new System.Drawing.Size(204, 39);
            this.finish_semulation.TabIndex = 2;
            this.finish_semulation.Text = "انهاء المحاكاة";
            this.finish_semulation.UseVisualStyleBackColor = false;
            this.finish_semulation.Click += new System.EventHandler(this.finish_semulation_Click);
            // 
            // set_system_variables
            // 
            this.set_system_variables.BackColor = System.Drawing.Color.LightBlue;
            this.set_system_variables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.set_system_variables.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_system_variables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.set_system_variables.Location = new System.Drawing.Point(46, 42);
            this.set_system_variables.Name = "set_system_variables";
            this.set_system_variables.Size = new System.Drawing.Size(218, 39);
            this.set_system_variables.TabIndex = 1;
            this.set_system_variables.Text = "تحديد عدد القصة";
            this.set_system_variables.UseVisualStyleBackColor = false;
            this.set_system_variables.Click += new System.EventHandler(this.init_variables);
            // 
            // start_simulation
            // 
            this.start_simulation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.start_simulation.Enabled = false;
            this.start_simulation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_simulation.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_simulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_simulation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.start_simulation.Location = new System.Drawing.Point(270, 42);
            this.start_simulation.Name = "start_simulation";
            this.start_simulation.Size = new System.Drawing.Size(244, 39);
            this.start_simulation.TabIndex = 0;
            this.start_simulation.Text = "بداية المحاكاة";
            this.start_simulation.UseVisualStyleBackColor = false;
            this.start_simulation.Click += new System.EventHandler(this.start_simulation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cairo", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(232, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(366, 45);
            this.label11.TabIndex = 3;
            this.label11.Text = "محاكاة عملية الطباعة على القماش";
            // 
            // set_paper_printer
            // 
            this.set_paper_printer.Interval = 3000;
            this.set_paper_printer.Tick += new System.EventHandler(this.set_paper_printer_Tick);
            // 
            // print_paper
            // 
            this.print_paper.Interval = 1000;
            this.print_paper.Tick += new System.EventHandler(this.print_paper_Tick);
            // 
            // action_print_Item_Timer
            // 
            this.action_print_Item_Timer.Interval = 1000;
            this.action_print_Item_Timer.Tick += new System.EventHandler(this.action_print_Item_Timer_Tick);
            // 
            // heat_press
            // 
            this.heat_press.Interval = 3000;
            this.heat_press.Tick += new System.EventHandler(this.heat_press_Tick);
            // 
            // set_system_var_timer
            // 
            this.set_system_var_timer.Interval = 3000;
            this.set_system_var_timer.Tick += new System.EventHandler(this.set_system_var_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(822, 514);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الرئيسية";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label leftItem;
        private System.Windows.Forms.Label finished_item_printed;
        private System.Windows.Forms.Label totalItems;
        private System.Windows.Forms.Label labe5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label paper_printer_number;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar heat_degree_progressBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label heat_degree;
        private System.Windows.Forms.Button finish_semulation;
        private System.Windows.Forms.Button set_system_variables;
        private System.Windows.Forms.Button start_simulation;
        private System.Windows.Forms.Button system_state;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer set_paper_printer;
        private System.Windows.Forms.Timer print_paper;
        private System.Windows.Forms.Timer action_print_Item_Timer;
        private System.Windows.Forms.Timer heat_press;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox_check_paper_print;
        private System.Windows.Forms.CheckBox checkBox_print_paper;
        private System.Windows.Forms.CheckBox checkBox_action_print;
        private System.Windows.Forms.CheckBox checkBox_set_system_vars;
        private System.Windows.Forms.Timer set_system_var_timer;
        private System.Windows.Forms.Button press_state;
        private System.Windows.Forms.Label label1;
    }
}

