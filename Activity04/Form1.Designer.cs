namespace Activity04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentLastname = new System.Windows.Forms.TextBox();
            this.studentAddress = new System.Windows.Forms.TextBox();
            this.studentCity = new System.Windows.Forms.TextBox();
            this.studentmobileNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(385, 42);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(125, 27);
            this.studentName.TabIndex = 0;
            // 
            // studentLastname
            // 
            this.studentLastname.Location = new System.Drawing.Point(385, 93);
            this.studentLastname.Name = "studentLastname";
            this.studentLastname.Size = new System.Drawing.Size(125, 27);
            this.studentLastname.TabIndex = 1;
            // 
            // studentAddress
            // 
            this.studentAddress.Location = new System.Drawing.Point(385, 140);
            this.studentAddress.Name = "studentAddress";
            this.studentAddress.Size = new System.Drawing.Size(125, 27);
            this.studentAddress.TabIndex = 2;
            // 
            // studentCity
            // 
            this.studentCity.Location = new System.Drawing.Point(385, 187);
            this.studentCity.Name = "studentCity";
            this.studentCity.Size = new System.Drawing.Size(125, 27);
            this.studentCity.TabIndex = 3;
            // 
            // studentmobileNo
            // 
            this.studentmobileNo.Location = new System.Drawing.Point(385, 240);
            this.studentmobileNo.Name = "studentmobileNo";
            this.studentmobileNo.Size = new System.Drawing.Size(125, 27);
            this.studentmobileNo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "MobileNo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 52);
            this.button3.TabIndex = 12;
            this.button3.Text = "Show Student Info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentmobileNo);
            this.Controls.Add(this.studentCity);
            this.Controls.Add(this.studentAddress);
            this.Controls.Add(this.studentLastname);
            this.Controls.Add(this.studentName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox studentName;
        private TextBox studentLastname;
        private TextBox studentAddress;
        private TextBox studentCity;
        private TextBox studentmobileNo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}