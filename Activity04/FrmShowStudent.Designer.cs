namespace Activity04
{
    partial class FrmShowStudent
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentmobileNo = new System.Windows.Forms.TextBox();
            this.studentCity = new System.Windows.Forms.TextBox();
            this.studentAddress = new System.Windows.Forms.TextBox();
            this.studentLastname = new System.Windows.Forms.TextBox();
            this.studentName = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "MobileNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Student Name:";
            // 
            // studentmobileNo
            // 
            this.studentmobileNo.Location = new System.Drawing.Point(273, 282);
            this.studentmobileNo.Name = "studentmobileNo";
            this.studentmobileNo.Size = new System.Drawing.Size(125, 27);
            this.studentmobileNo.TabIndex = 14;
            // 
            // studentCity
            // 
            this.studentCity.Location = new System.Drawing.Point(273, 229);
            this.studentCity.Name = "studentCity";
            this.studentCity.Size = new System.Drawing.Size(125, 27);
            this.studentCity.TabIndex = 13;
            // 
            // studentAddress
            // 
            this.studentAddress.Location = new System.Drawing.Point(273, 182);
            this.studentAddress.Name = "studentAddress";
            this.studentAddress.Size = new System.Drawing.Size(125, 27);
            this.studentAddress.TabIndex = 12;
            // 
            // studentLastname
            // 
            this.studentLastname.Location = new System.Drawing.Point(273, 135);
            this.studentLastname.Name = "studentLastname";
            this.studentLastname.Size = new System.Drawing.Size(125, 27);
            this.studentLastname.TabIndex = 11;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(273, 84);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(125, 27);
            this.studentName.TabIndex = 10;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(495, 87);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(192, 224);
            this.listBox.TabIndex = 20;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // FrmShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
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
            this.Name = "FrmShowStudent";
            this.Text = "FrmShowStudent";
            this.Load += new System.EventHandler(this.FrmShowStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox studentmobileNo;
        private TextBox studentCity;
        private TextBox studentAddress;
        private TextBox studentLastname;
        private TextBox studentName;
        private ListBox listBox;
    }
}