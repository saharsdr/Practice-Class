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
    public partial class formStudent : Form
    {
        classStudent thisStudent = null;
        classPracticeClass thisPractisClass = null;
        classBase temp = new classBase();
        //false=Practice and quiz , true=Home
        bool isInHome = true;

        //0=Student view , 1=TA view
        public bool mode = false;
        List<ShowClass> onGoingClassesList = null;
        List<ShowPractice> selectedClassPractice = null;
        List<ShowQuiz> selectedClassQuiz = null;
        int rowIndexTab1;

        public formStudent(string id,string pass)
        {
            InitializeComponent();
            //login the student
            thisStudent = temp.LoginStudent(id, pass);

            //disShow TA icon
            if (thisStudent.GetAccessLevel() == 1)
                iconStudentToTa.Visible = false;
            else
                iconStudentToTa.Visible = true;

            if (mode == false)
            {
                //in a simple student mode

                //sorted by professor name
                onGoingClassesList =
                    thisStudent.GetStudentOnGoingClassesList().OrderBy(x => x.fullNameProfessor).ToList();
                if (onGoingClassesList != null)
                    bunifuCustomDataGridTab1.DataSource = onGoingClassesList;
                //if (isInHome == true)
                //{
                //    iconHome.Visible = false;
                //}
                //else
                //{
                //    iconHome.Visible = true;
                //}

                tabPage1.Show();
            }
            
        }

        private void iconHome_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Home", iconHome);
        }

        private void iconSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Search", iconSearch);

        }

        private void iconStudentToTa_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Go to TA mode!", iconStudentToTa);

        }

        private void iconProfile_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(thisStudent.GetFullName()+"\n@"+thisStudent.GetID(), iconProfile);

        }

        private void bunifuCustomDataGridTab2Quiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGridTab2Practice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTab1Archve_MouseEnter(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab1Archve.BackColor = theme.buttonIn;
        }

        private void buttonTab1Archve_MouseLeave(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab1Archve.BackColor = theme.buttonOut;
        }

        private void buttonTab1Archve_Click(object sender, EventArgs e)
        {
            if(buttonTab1Archve.Text=="Archive")
            {
            List<ShowClass> archiveClassesList = new List<ShowClass>();
            archiveClassesList = thisStudent.GetStudentArchivedClassesList();
            bunifuCustomDataGridTab1.DataSource = archiveClassesList;
                buttonTab1Archve.Text = "Close Archive";
                labelTab1Title.Text = "Archive of classes";
            }
            else
            {
                bunifuCustomDataGridTab1.DataSource = onGoingClassesList;
                buttonTab1Archve.Text = "Archive";
                labelTab1Title.Text = "List of classes";
            }
        }
    }
}
