namespace Activity04
{
    public partial class Form1 : Form
    {
        public static StudentData[] stdData = new StudentData[10];
        public static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = studentName.Text;
            string lastname = studentLastname.Text;
            string address = studentAddress.Text;
            string city = studentCity.Text;
            string mobileNo = studentmobileNo.Text;

            StudentData obj = new StudentData(firstname, lastname, address, city, mobileNo);
            stdData[counter] = obj;
            counter++;
            clearData();

        }
        public void clearData()
        {
            studentName.Text = "";
            studentLastname.Text = "";
            studentAddress.Text = "";
            studentCity.Text = "";
            studentmobileNo.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           FrmShowStudent obj = new FrmShowStudent();
            obj.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class StudentData
    {
        public string firstname, lastname, address, city, mobileNo;
        public StudentData(string firstname, string lastname, string address, string city, string mobileNo)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.mobileNo = mobileNo;
        }
    }
    
}