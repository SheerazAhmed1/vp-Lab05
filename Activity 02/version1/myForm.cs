using System;
using System.Windows.Forms;

namespace MyNameSpace
{

    public MyForm()
    {

        this.Text = "My Form";
    }

    public static void Main(string[] args)
    {
        Application.Run(new MyForm());
    }

}