namespace BMI_winform_
{
    partial class BMI_calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblResultupper = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnRemach = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtboxRighter = new System.Windows.Forms.TextBox();
            this.txtLefter = new System.Windows.Forms.TextBox();
            this.lbllowerr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbllowerr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lblResultupper);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.btnRemach);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtboxRighter);
            this.panel1.Controls.Add(this.txtLefter);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 318);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = ":وزن";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(548, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(33, 29);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = ":قد";
            // 
            // lblResultupper
            // 
            this.lblResultupper.AutoSize = true;
            this.lblResultupper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultupper.Location = new System.Drawing.Point(360, 128);
            this.lblResultupper.Name = "lblResultupper";
            this.lblResultupper.Size = new System.Drawing.Size(221, 29);
            this.lblResultupper.TabIndex = 5;
            this.lblResultupper.Text = ".قد و وزن خود را وارد کنید";
            this.lblResultupper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(434, 234);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 69);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "محاسبه";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnRemach
            // 
            this.btnRemach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemach.Location = new System.Drawing.Point(238, 234);
            this.btnRemach.Name = "btnRemach";
            this.btnRemach.Size = new System.Drawing.Size(147, 69);
            this.btnRemach.TabIndex = 3;
            this.btnRemach.Text = "تنظیم مجدد";
            this.btnRemach.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(47, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 69);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtboxRighter
            // 
            this.txtboxRighter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRighter.Location = new System.Drawing.Point(393, 55);
            this.txtboxRighter.Name = "txtboxRighter";
            this.txtboxRighter.Size = new System.Drawing.Size(188, 45);
            this.txtboxRighter.TabIndex = 0;
            // 
            // txtLefter
            // 
            this.txtLefter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLefter.Location = new System.Drawing.Point(39, 55);
            this.txtLefter.Name = "txtLefter";
            this.txtLefter.Size = new System.Drawing.Size(188, 45);
            this.txtLefter.TabIndex = 1;
            // 
            // lbllowerr
            // 
            this.lbllowerr.AutoSize = true;
            this.lbllowerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllowerr.Location = new System.Drawing.Point(212, 178);
            this.lbllowerr.Name = "lbllowerr";
            this.lbllowerr.Size = new System.Drawing.Size(0, 29);
            this.lbllowerr.TabIndex = 8;
            this.lbllowerr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BMI_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 347);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BMI_calculator";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxRighter;
        private System.Windows.Forms.TextBox txtLefter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnRemach;
        private System.Windows.Forms.Label lblResultupper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbllowerr;
    }
}

