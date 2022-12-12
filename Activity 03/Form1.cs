namespace Activity_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            Button button = btnAddName;
            button.SetBounds(488,232,94,29);
            Label obj1=new Label();
            TextBox obj2=new TextBox();
            obj2.Name = "txtContact2";
            obj2.SetBounds(278, 232,183,27); 
            this.Controls.Add(obj2);

            obj1.Name = "lblContactNo2";
            obj1.Text = "Enter Contact No#2:";
            obj1.SetBounds(120, 237, 183, 23);
            this.Controls.Add(obj1);
            btnAddName.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtContactNO.Text = "";
            //if (btnAddName.Enabled == false)
           
           /* myform.Hide();
            myform.Close();
            myform.Dispose();
          */

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string contact2 = this.Controls["txtContact2"].Text;
            MessageBox.Show(txtUserName.Text+"\n"+txtPassword.Text+"\n"+txtContactNO.Text+"\n"+contact2);
        }
    }
}