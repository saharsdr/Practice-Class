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
        int rowIndexTab2Practice;

        public formStudent(string id, string pass)
        {
            InitializeComponent();
            itemColor();
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
                    thisStudent.GetStudentOnGoingClassesList();
                            
                if (onGoingClassesList.Count != 0)
                {
                    dataGridViewTab1.Rows.Clear();
                    dataGridViewTab1.RowCount = onGoingClassesList.Count;
                    for (int i = 0; i < onGoingClassesList.Count; i++)
                    {
                        dataGridViewTab1.Rows[i].Cells["Course"].Value = onGoingClassesList[i].nameCourse;
                        dataGridViewTab1.Rows[i].Cells["TA"].Value = onGoingClassesList[i].fullNameTA;
                        dataGridViewTab1.Rows[i].Cells["Professor"].Value = onGoingClassesList[i].fullNameProfessor;
                        dataGridViewTab1.Rows[i].Cells["Grade"].Value = onGoingClassesList[i].grade;
                    }
                }
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
            toolTip1.Show(thisStudent.GetFullName() + "\n@" + thisStudent.GetID(), iconProfile);

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
            dataGridViewTab1.Rows.Clear();
            if (buttonTab1Archve.Text == "Archive")
            {
                List<ShowClass> archiveClassesList = new List<ShowClass>();
                archiveClassesList = thisStudent.GetStudentArchivedClassesList();   
                if (archiveClassesList.Count != 0)
                {
                    dataGridViewTab1.RowCount = archiveClassesList.Count;
                    for (int i = 0; i < archiveClassesList.Count; i++)
                    {
                        dataGridViewTab1.Rows[i].Cells["Course"].Value = archiveClassesList[i].nameCourse;
                        dataGridViewTab1.Rows[i].Cells["TA"].Value = archiveClassesList[i].fullNameTA;
                        dataGridViewTab1.Rows[i].Cells["Professor"].Value = archiveClassesList[i].fullNameProfessor;
                        dataGridViewTab1.Rows[i].Cells["Grade"].Value = archiveClassesList[i].grade;
                    }
                }

                buttonTab1Archve.Text = "Close Archive";
                labelTab1Title.Text = "Archive of classes";
            }
            else
            {
                if (onGoingClassesList.Count != 0)
                {
                    
                    dataGridViewTab1.RowCount = onGoingClassesList.Count;
                    for (int i = 0; i < onGoingClassesList.Count; i++)
                    {
                        dataGridViewTab1.Rows[i].Cells["Course"].Value = onGoingClassesList[i].nameCourse;
                        dataGridViewTab1.Rows[i].Cells["TA"].Value = onGoingClassesList[i].fullNameTA;
                        dataGridViewTab1.Rows[i].Cells["Professor"].Value = onGoingClassesList[i].fullNameProfessor;
                        dataGridViewTab1.Rows[i].Cells["Grade"].Value = onGoingClassesList[i].grade;
                    }
                }
                buttonTab1Archve.Text = "Archive";
                labelTab1Title.Text = "List of classes";
            }
        }

       

        
        private void buttonTab4SaveNewPassword_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridViewTab1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewTab1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexTab1 = dataGridViewTab1.CurrentRow.Index;
            labelTab1Title.Text = rowIndexTab1.ToString();
            {
                labelTab2NameCourse.Text = onGoingClassesList[rowIndexTab1].nameCourse;
                labelTab2NameProfessor.Text = onGoingClassesList[rowIndexTab1].fullNameProfessor;
                labelTab2NameTa.Text=onGoingClassesList[rowIndexTab1].fullNameTA;

                database_practiceclass db = new database_practiceclass();
                thisPractisClass = new classPracticeClass(db, onGoingClassesList[rowIndexTab1].term,
                    onGoingClassesList[rowIndexTab1].year, onGoingClassesList[rowIndexTab1].groupNumber);
                selectedClassPractice = new List<ShowPractice>();
                selectedClassPractice = thisPractisClass.GetClassPracticeList();

                dataGridViewTab2Practice.Rows.Clear();
                if (selectedClassPractice.Count != 0)
                {
                    dataGridViewTab2Practice.RowCount = selectedClassPractice.Count;
                    for (int i = 0; i < selectedClassPractice.Count; i++)
                    {
                        dataGridViewTab2Practice.Rows[i].Cells["Tab2NumberPractice"].Value = selectedClassPractice[i].number;
                        dataGridViewTab2Practice.Rows[i].Cells["Tab2PartPractice"].Value = selectedClassPractice[i].part;
                        //dataGridViewTab2Practice.Rows[i].Cells["tab2GradePractice"].Value = selectedClassPractice[i].;
                        dataGridViewTab2Practice.Rows[i].Cells["tab2UploadPractice"].Value =
                            global::PracticeClass.Properties.Resources.Icon_feather_upload_2x;
                        dataGridViewTab2Practice.Rows[i].Cells["tab2DownloadPractice"].Value =
                            global::PracticeClass.Properties.Resources.Icon_feather_download_2x;
                    }
                }

            }
        }

      

        
        private void buttonTab3SaveNewPassword_MouseEnter(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab3SaveNewPassword.BackColor = theme.buttonIn;
        }

        

        private void buttonTab3SaveNewPassword_MouseLeave(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab4SaveNewPassword.BackColor = theme.buttonOut;
        }

        private void buttonTab3SaveNewPassword_Click(object sender, EventArgs e)
        {
            //Change the password for student
        }

        private void labelTab2NameProfessor_Click(object sender, EventArgs e)
        {
            //disply resourses of course and info of professor
        }

        private void buttonTab3SaveNewPassword_MouseEnter_1(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab3SaveNewPassword.BackColor = theme.buttonIn;
        }

        private void buttonTab3SaveNewPassword_MouseLeave_1(object sender, EventArgs e)
        {

            classThem theme = new classThem();
            buttonTab3SaveNewPassword.BackColor = theme.buttonOut;
        }

        private void dataGridViewTab2Practice_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if user pressed the download icon
            if(dataGridViewTab2Practice.CurrentCell.ColumnIndex==2)
            {
                rowIndexTab2Practice = dataGridViewTab2Practice.CurrentCell.RowIndex;
                System.Diagnostics.Process.Start(selectedClassPractice[rowIndexTab2Practice].link);

            }
            else if(dataGridViewTab2Practice.CurrentCell.ColumnIndex == 3)
            {
                rowIndexTab2Practice = dataGridViewTab2Practice.CurrentCell.RowIndex;
                
            }
        }


    }
}
