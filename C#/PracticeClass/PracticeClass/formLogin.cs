using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeClass
{
    public partial class formLogin : Form
    {
        public string id = "";
        public string pas = "";

        classBase temp = new classBase();


        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            id = textBoxId.Text;
            pas = textBoxPassword.Text;
            if (radioButtonStudent.Checked == true)
            {
                classStudent accountStudent = null;
                accountStudent = temp.LoginStudent(id, pas);
                if (accountStudent != null)
                {
                    formStudent formForStudent = new formStudent();
                    formForStudent.Activate();
                }
                else
                {
                    MessageBox.Show("Username or password is wrong!");
                    textBoxId.Text = "";
                    textBoxPassword.Text = "";
                }
            }
        }
    }
}
