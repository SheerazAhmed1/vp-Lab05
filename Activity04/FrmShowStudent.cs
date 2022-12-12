using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity04
{
    public partial class FrmShowStudent : Form
    {
        public FrmShowStudent()
        {
            InitializeComponent();
        }

        private void FrmShowStudent_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.counter; i++)
            {

                listBox.Items.Add(Form1.stdData[i].firstname);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            studentName.Text = Form1.stdData[this.listBox.SelectedIndex].firstname;
            studentName.Text = Form1.stdData[this.listBox.SelectedIndex].firstname;
            studentLastname.Text = Form1.stdData[this.listBox.SelectedIndex].lastname;
            studentAddress.Text = Form1.stdData[this.listBox.SelectedIndex].address;
            studentCity.Text = Form1.stdData[this.listBox.SelectedIndex].city;
            studentmobileNo.Text = Form1.stdData[this.listBox.SelectedIndex].mobileNo;

        }
    }
}
