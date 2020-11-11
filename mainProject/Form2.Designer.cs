namespace mainProject
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetNumItems = new System.Windows.Forms.Button();
            this.totalItemsTextBox = new System.Windows.Forms.NumericUpDown();
            this.errorHandle = new System.Windows.Forms.Label();
            this.closeSetItemForm = new System.Windows.Forms.Button();
            this.inc_item_num = new System.Windows.Forms.Button();
            this.dec_item_num = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.totalItemsTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "تهيئة متحولات النظام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "عدد قطع القصة";
            // 
            // SetNumItems
            // 
            this.SetNumItems.BackColor = System.Drawing.Color.PaleGreen;
            this.SetNumItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetNumItems.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetNumItems.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SetNumItems.Location = new System.Drawing.Point(253, 185);
            this.SetNumItems.Name = "SetNumItems";
            this.SetNumItems.Size = new System.Drawing.Size(75, 32);
            this.SetNumItems.TabIndex = 5;
            this.SetNumItems.Text = "تم ";
            this.SetNumItems.UseVisualStyleBackColor = false;
            this.SetNumItems.Click += new System.EventHandler(this.SetNumItems_Click);
            // 
            // totalItemsTextBox
            // 
            this.totalItemsTextBox.Location = new System.Drawing.Point(91, 127);
            this.totalItemsTextBox.Name = "totalItemsTextBox";
            this.totalItemsTextBox.Size = new System.Drawing.Size(237, 20);
            this.totalItemsTextBox.TabIndex = 6;
            // 
            // errorHandle
            // 
            this.errorHandle.AutoSize = true;
            this.errorHandle.ForeColor = System.Drawing.Color.LightCoral;
            this.errorHandle.Location = new System.Drawing.Point(177, 150);
            this.errorHandle.Name = "errorHandle";
            this.errorHandle.Size = new System.Drawing.Size(151, 13);
            this.errorHandle.TabIndex = 7;
            this.errorHandle.Text = "الرجاء تحديد قيمة اكبر من الصفر";
            this.errorHandle.Visible = false;
            // 
            // closeSetItemForm
            // 
            this.closeSetItemForm.BackColor = System.Drawing.Color.Gray;
            this.closeSetItemForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeSetItemForm.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSetItemForm.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.closeSetItemForm.Location = new System.Drawing.Point(91, 185);
            this.closeSetItemForm.Name = "closeSetItemForm";
            this.closeSetItemForm.Size = new System.Drawing.Size(75, 32);
            this.closeSetItemForm.TabIndex = 8;
            this.closeSetItemForm.Text = "عودة";
            this.closeSetItemForm.UseVisualStyleBackColor = false;
            this.closeSetItemForm.Click += new System.EventHandler(this.closeSetItemForm_Click);
            // 
            // inc_item_num
            // 
            this.inc_item_num.BackColor = System.Drawing.Color.Cyan;
            this.inc_item_num.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inc_item_num.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inc_item_num.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.inc_item_num.Location = new System.Drawing.Point(253, 185);
            this.inc_item_num.Name = "inc_item_num";
            this.inc_item_num.Size = new System.Drawing.Size(75, 32);
            this.inc_item_num.TabIndex = 9;
            this.inc_item_num.Text = "زيادة";
            this.inc_item_num.UseVisualStyleBackColor = false;
            this.inc_item_num.Visible = false;
            this.inc_item_num.Click += new System.EventHandler(this.inc_item_num_Click);
            // 
            // dec_item_num
            // 
            this.dec_item_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dec_item_num.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dec_item_num.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_item_num.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dec_item_num.Location = new System.Drawing.Point(172, 185);
            this.dec_item_num.Name = "dec_item_num";
            this.dec_item_num.Size = new System.Drawing.Size(75, 32);
            this.dec_item_num.TabIndex = 10;
            this.dec_item_num.Text = "إنقاص";
            this.dec_item_num.UseVisualStyleBackColor = false;
            this.dec_item_num.Visible = false;
            this.dec_item_num.Click += new System.EventHandler(this.dec_item_num_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(409, 285);
            this.Controls.Add(this.dec_item_num);
            this.Controls.Add(this.inc_item_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeSetItemForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalItemsTextBox);
            this.Controls.Add(this.errorHandle);
            this.Controls.Add(this.SetNumItems);
            this.Name = "Form2";
            this.Text = "تهيئة";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalItemsTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetNumItems;
        private System.Windows.Forms.NumericUpDown totalItemsTextBox;
        private System.Windows.Forms.Label errorHandle;
        private System.Windows.Forms.Button closeSetItemForm;
        private System.Windows.Forms.Button inc_item_num;
        private System.Windows.Forms.Button dec_item_num;
    }
}