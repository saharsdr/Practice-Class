namespace PracticeClass
{
    partial class formStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public void itemColor()
        {
            classThem them = new classThem();
            panelSideMenu.BackColor = them.sideMenuBack;
            BackColor = this.tabPage1.BackColor = this.tabPage2.BackColor = them.background;
            tabPage1.ForeColor = this.tabPage2.ForeColor = them.background;
            labelTab1Title.ForeColor = labelTab2Pracitce.ForeColor = labelTab2Quiz.ForeColor = them.mainText;
            labelTab2NameCourse.ForeColor = labelTab2NameProfessor.ForeColor
                 = labelTab2NameTa.ForeColor = them.mainText;

            //dataGridViewTab1;
            dataGridViewTab1.RowHeadersVisible = false;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = 
                new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = them.background;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = them.mainText;
            dataGridViewTab1.RowsDefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab1.BackgroundColor = them.row;
            dataGridViewTab1.ForeColor = System.Drawing.Color.Black;
            dataGridViewTab1.DefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab1.DefaultCellStyle.SelectionForeColor = them.row;
            dataGridViewTab1.DefaultCellStyle.SelectionBackColor = them.unmainText;
            dataGridViewTab1.GridColor = them.unmainText;
            dataGridViewTab1.ColumnHeadersDefaultCellStyle.ForeColor = them.row;
            dataGridViewTab1.ColumnHeadersDefaultCellStyle.BackColor = them.mainText;

            dataGridViewTab2Practice.RowsDefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab2Practice.BackgroundColor = them.row;
            dataGridViewTab2Practice.ForeColor = System.Drawing.Color.Black;
            dataGridViewTab2Practice.DefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab2Practice.DefaultCellStyle.SelectionForeColor = them.row;
            dataGridViewTab2Practice.DefaultCellStyle.SelectionBackColor = them.unmainText;
            dataGridViewTab2Practice.GridColor = them.unmainText;
            dataGridViewTab2Practice.ColumnHeadersDefaultCellStyle.ForeColor = them.row;
            dataGridViewTab2Practice.ColumnHeadersDefaultCellStyle.BackColor = them.mainText;

            dataGridViewTab2Quiz.RowsDefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab2Quiz.BackgroundColor = them.row;
            dataGridViewTab2Quiz.ForeColor = System.Drawing.Color.Black;
            dataGridViewTab2Quiz.DefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab2Quiz.DefaultCellStyle.SelectionForeColor = them.row;
            dataGridViewTab2Quiz.DefaultCellStyle.SelectionBackColor = them.unmainText;
            dataGridViewTab2Quiz.GridColor = them.unmainText;
            dataGridViewTab2Quiz.ColumnHeadersDefaultCellStyle.ForeColor = them.row;
            dataGridViewTab2Quiz.ColumnHeadersDefaultCellStyle.BackColor = them.mainText;

            tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelTab2InfoClass.BackColor = them.row;
            buttonTab4SaveNewPassword.BackColor=
            buttonTab1Archve.BackColor = them.buttonOut;
            buttonTab4SaveNewPassword.ForeColor=
            buttonTab1Archve.ForeColor = them.row;

        }

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.iconSetting = new System.Windows.Forms.PictureBox();
            this.iconProfile = new System.Windows.Forms.PictureBox();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.iconStudentToTa = new System.Windows.Forms.PictureBox();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewTab1 = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTab1Archve = new System.Windows.Forms.Button();
            this.labelTab1Title = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTab2Quiz = new System.Windows.Forms.DataGridView();
            this.tab2NumberQuiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab2DateQuiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab2GradeQuiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTab2Practice = new System.Windows.Forms.DataGridView();
            this.panelTab2InfoClass = new System.Windows.Forms.Panel();
            this.labelTab2NameTa = new System.Windows.Forms.Label();
            this.labelTab2NameProfessor = new System.Windows.Forms.Label();
            this.labelTab2NameCourse = new System.Windows.Forms.Label();
            this.labelTab2Quiz = new System.Windows.Forms.Label();
            this.labelTab2Pracitce = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonTab3SaveNewPassword = new System.Windows.Forms.Button();
            this.labelTab3Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextboxTab3RepeatNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelTab3RepeatNewPassword = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxTab3NewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelTab3NewPass = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxCurrentPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelTab3TitleCurrentPassword = new System.Windows.Forms.Label();
            this.labelTab3Id = new System.Windows.Forms.Label();
            this.labelTab3FullNameStudent = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxTab4PreviewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxTab4NewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxTab4ReapeatNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonTab4SaveNewPassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tab2PartPractice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab2NumberPractice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab2DownloadPractice = new System.Windows.Forms.DataGridViewImageColumn();
            this.tab2UploadPractice = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStudentToTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab2Quiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab2Practice)).BeginInit();
            this.panelTab2InfoClass.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSideMenu.Controls.Add(this.iconSetting);
            this.panelSideMenu.Controls.Add(this.iconProfile);
            this.panelSideMenu.Controls.Add(this.iconSearch);
            this.panelSideMenu.Controls.Add(this.iconStudentToTa);
            this.panelSideMenu.Controls.Add(this.iconHome);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(64, 753);
            this.panelSideMenu.TabIndex = 0;
            // 
            // iconSetting
            // 
            this.iconSetting.Image = global::PracticeClass.Properties.Resources.Icon_ionic_ios_settings_2x;
            this.iconSetting.Location = new System.Drawing.Point(12, 673);
            this.iconSetting.Name = "iconSetting";
            this.iconSetting.Size = new System.Drawing.Size(40, 38);
            this.iconSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconSetting.TabIndex = 6;
            this.iconSetting.TabStop = false;
            // 
            // iconProfile
            // 
            this.iconProfile.Image = global::PracticeClass.Properties.Resources.Icon_material_account_circle_2x;
            this.iconProfile.Location = new System.Drawing.Point(12, 629);
            this.iconProfile.Name = "iconProfile";
            this.iconProfile.Size = new System.Drawing.Size(40, 38);
            this.iconProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconProfile.TabIndex = 5;
            this.iconProfile.TabStop = false;
            this.iconProfile.MouseHover += new System.EventHandler(this.iconProfile_MouseHover);
            // 
            // iconSearch
            // 
            this.iconSearch.Image = global::PracticeClass.Properties.Resources.Search_2x;
            this.iconSearch.Location = new System.Drawing.Point(12, 88);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(40, 38);
            this.iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconSearch.TabIndex = 4;
            this.iconSearch.TabStop = false;
            this.iconSearch.MouseHover += new System.EventHandler(this.iconSearch_MouseHover);
            // 
            // iconStudentToTa
            // 
            this.iconStudentToTa.Image = global::PracticeClass.Properties.Resources.education_2;
            this.iconStudentToTa.Location = new System.Drawing.Point(12, 585);
            this.iconStudentToTa.Name = "iconStudentToTa";
            this.iconStudentToTa.Size = new System.Drawing.Size(40, 38);
            this.iconStudentToTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconStudentToTa.TabIndex = 3;
            this.iconStudentToTa.TabStop = false;
            this.iconStudentToTa.MouseHover += new System.EventHandler(this.iconStudentToTa_MouseHover);
            // 
            // iconHome
            // 
            this.iconHome.Image = global::PracticeClass.Properties.Resources.Icon_home_2x;
            this.iconHome.Location = new System.Drawing.Point(12, 44);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(40, 38);
            this.iconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconHome.TabIndex = 2;
            this.iconHome.TabStop = false;
            this.iconHome.Visible = false;
            this.iconHome.MouseHover += new System.EventHandler(this.iconHome_MouseHover);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(61, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1224, 753);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dataGridViewTab1);
            this.tabPage1.Controls.Add(this.buttonTab1Archve);
            this.tabPage1.Controls.Add(this.labelTab1Title);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1216, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // dataGridViewTab1
            // 
            this.dataGridViewTab1.AllowUserToAddRows = false;
            this.dataGridViewTab1.AllowUserToDeleteRows = false;
            this.dataGridViewTab1.AllowUserToOrderColumns = true;
            this.dataGridViewTab1.AllowUserToResizeRows = false;
            this.dataGridViewTab1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTab1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTab1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTab1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTab1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTab1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTab1.ColumnHeadersHeight = 50;
            this.dataGridViewTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTab1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Professor,
            this.TA,
            this.Grade});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTab1.Location = new System.Drawing.Point(47, 101);
            this.dataGridViewTab1.Name = "dataGridViewTab1";
            this.dataGridViewTab1.ReadOnly = true;
            this.dataGridViewTab1.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab1.RowTemplate.Height = 35;
            this.dataGridViewTab1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTab1.Size = new System.Drawing.Size(1120, 556);
            this.dataGridViewTab1.TabIndex = 3;
            this.dataGridViewTab1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTab1_CellDoubleClick_1);
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Professor
            // 
            this.Professor.HeaderText = "Professor";
            this.Professor.Name = "Professor";
            this.Professor.ReadOnly = true;
            // 
            // TA
            // 
            this.TA.HeaderText = "TA";
            this.TA.Name = "TA";
            this.TA.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.FillWeight = 50F;
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // buttonTab1Archve
            // 
            this.buttonTab1Archve.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab1Archve.Location = new System.Drawing.Point(550, 675);
            this.buttonTab1Archve.Name = "buttonTab1Archve";
            this.buttonTab1Archve.Size = new System.Drawing.Size(133, 36);
            this.buttonTab1Archve.TabIndex = 2;
            this.buttonTab1Archve.Text = "Archive";
            this.buttonTab1Archve.UseVisualStyleBackColor = true;
            this.buttonTab1Archve.Click += new System.EventHandler(this.buttonTab1Archve_Click);
            this.buttonTab1Archve.MouseEnter += new System.EventHandler(this.buttonTab1Archve_MouseEnter);
            this.buttonTab1Archve.MouseLeave += new System.EventHandler(this.buttonTab1Archve_MouseLeave);
            // 
            // labelTab1Title
            // 
            this.labelTab1Title.AutoSize = true;
            this.labelTab1Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab1Title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab1Title.Location = new System.Drawing.Point(39, 39);
            this.labelTab1Title.Name = "labelTab1Title";
            this.labelTab1Title.Size = new System.Drawing.Size(231, 45);
            this.labelTab1Title.TabIndex = 1;
            this.labelTab1Title.Text = "List of classes";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewTab2Quiz);
            this.tabPage2.Controls.Add(this.dataGridViewTab2Practice);
            this.tabPage2.Controls.Add(this.panelTab2InfoClass);
            this.tabPage2.Controls.Add(this.labelTab2Quiz);
            this.tabPage2.Controls.Add(this.labelTab2Pracitce);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1216, 724);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTab2Quiz
            // 
            this.dataGridViewTab2Quiz.AllowUserToAddRows = false;
            this.dataGridViewTab2Quiz.AllowUserToDeleteRows = false;
            this.dataGridViewTab2Quiz.AllowUserToOrderColumns = true;
            this.dataGridViewTab2Quiz.AllowUserToResizeRows = false;
            this.dataGridViewTab2Quiz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTab2Quiz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTab2Quiz.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTab2Quiz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTab2Quiz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTab2Quiz.ColumnHeadersHeight = 50;
            this.dataGridViewTab2Quiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTab2Quiz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tab2NumberQuiz,
            this.tab2DateQuiz,
            this.tab2GradeQuiz});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab2Quiz.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTab2Quiz.Location = new System.Drawing.Point(636, 216);
            this.dataGridViewTab2Quiz.Name = "dataGridViewTab2Quiz";
            this.dataGridViewTab2Quiz.ReadOnly = true;
            this.dataGridViewTab2Quiz.RowHeadersVisible = false;
            this.dataGridViewTab2Quiz.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.RowTemplate.Height = 35;
            this.dataGridViewTab2Quiz.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab2Quiz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTab2Quiz.Size = new System.Drawing.Size(529, 470);
            this.dataGridViewTab2Quiz.TabIndex = 8;
            // 
            // tab2NumberQuiz
            // 
            this.tab2NumberQuiz.HeaderText = "Number";
            this.tab2NumberQuiz.Name = "tab2NumberQuiz";
            this.tab2NumberQuiz.ReadOnly = true;
            // 
            // tab2DateQuiz
            // 
            this.tab2DateQuiz.HeaderText = "Date";
            this.tab2DateQuiz.Name = "tab2DateQuiz";
            this.tab2DateQuiz.ReadOnly = true;
            // 
            // tab2GradeQuiz
            // 
            this.tab2GradeQuiz.FillWeight = 50F;
            this.tab2GradeQuiz.HeaderText = "Grade";
            this.tab2GradeQuiz.Name = "tab2GradeQuiz";
            this.tab2GradeQuiz.ReadOnly = true;
            // 
            // dataGridViewTab2Practice
            // 
            this.dataGridViewTab2Practice.AllowUserToAddRows = false;
            this.dataGridViewTab2Practice.AllowUserToDeleteRows = false;
            this.dataGridViewTab2Practice.AllowUserToOrderColumns = true;
            this.dataGridViewTab2Practice.AllowUserToResizeRows = false;
            this.dataGridViewTab2Practice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTab2Practice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTab2Practice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTab2Practice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTab2Practice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTab2Practice.ColumnHeadersHeight = 50;
            this.dataGridViewTab2Practice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTab2Practice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tab2PartPractice,
            this.Tab2NumberPractice,
            this.tab2DownloadPractice,
            this.tab2UploadPractice});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab2Practice.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTab2Practice.Location = new System.Drawing.Point(46, 216);
            this.dataGridViewTab2Practice.Name = "dataGridViewTab2Practice";
            this.dataGridViewTab2Practice.ReadOnly = true;
            this.dataGridViewTab2Practice.RowHeadersVisible = false;
            this.dataGridViewTab2Practice.RowHeadersWidth = 40;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.RowTemplate.Height = 35;
            this.dataGridViewTab2Practice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab2Practice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewTab2Practice.Size = new System.Drawing.Size(529, 470);
            this.dataGridViewTab2Practice.TabIndex = 7;
            this.dataGridViewTab2Practice.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTab2Practice_CellContentDoubleClick);
            // 
            // panelTab2InfoClass
            // 
            this.panelTab2InfoClass.BackColor = System.Drawing.Color.LightGray;
            this.panelTab2InfoClass.Controls.Add(this.labelTab2NameTa);
            this.panelTab2InfoClass.Controls.Add(this.labelTab2NameProfessor);
            this.panelTab2InfoClass.Controls.Add(this.labelTab2NameCourse);
            this.panelTab2InfoClass.Location = new System.Drawing.Point(-3, 46);
            this.panelTab2InfoClass.Name = "panelTab2InfoClass";
            this.panelTab2InfoClass.Size = new System.Drawing.Size(1219, 46);
            this.panelTab2InfoClass.TabIndex = 5;
            // 
            // labelTab2NameTa
            // 
            this.labelTab2NameTa.AutoSize = true;
            this.labelTab2NameTa.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2NameTa.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2NameTa.Location = new System.Drawing.Point(1045, 1);
            this.labelTab2NameTa.Name = "labelTab2NameTa";
            this.labelTab2NameTa.Size = new System.Drawing.Size(123, 45);
            this.labelTab2NameTa.TabIndex = 8;
            this.labelTab2NameTa.Text = "Quizes";
            // 
            // labelTab2NameProfessor
            // 
            this.labelTab2NameProfessor.AutoSize = true;
            this.labelTab2NameProfessor.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2NameProfessor.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2NameProfessor.Location = new System.Drawing.Point(543, 1);
            this.labelTab2NameProfessor.Name = "labelTab2NameProfessor";
            this.labelTab2NameProfessor.Size = new System.Drawing.Size(123, 45);
            this.labelTab2NameProfessor.TabIndex = 7;
            this.labelTab2NameProfessor.Text = "Quizes";
            this.labelTab2NameProfessor.Click += new System.EventHandler(this.labelTab2NameProfessor_Click);
            // 
            // labelTab2NameCourse
            // 
            this.labelTab2NameCourse.AutoSize = true;
            this.labelTab2NameCourse.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2NameCourse.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2NameCourse.Location = new System.Drawing.Point(41, 1);
            this.labelTab2NameCourse.Name = "labelTab2NameCourse";
            this.labelTab2NameCourse.Size = new System.Drawing.Size(123, 45);
            this.labelTab2NameCourse.TabIndex = 6;
            this.labelTab2NameCourse.Text = "Quizes";
            // 
            // labelTab2Quiz
            // 
            this.labelTab2Quiz.AutoSize = true;
            this.labelTab2Quiz.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2Quiz.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2Quiz.Location = new System.Drawing.Point(628, 129);
            this.labelTab2Quiz.Name = "labelTab2Quiz";
            this.labelTab2Quiz.Size = new System.Drawing.Size(123, 45);
            this.labelTab2Quiz.TabIndex = 4;
            this.labelTab2Quiz.Text = "Quizes";
            // 
            // labelTab2Pracitce
            // 
            this.labelTab2Pracitce.AutoSize = true;
            this.labelTab2Pracitce.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2Pracitce.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2Pracitce.Location = new System.Drawing.Point(38, 129);
            this.labelTab2Pracitce.Name = "labelTab2Pracitce";
            this.labelTab2Pracitce.Size = new System.Drawing.Size(158, 45);
            this.labelTab2Pracitce.TabIndex = 3;
            this.labelTab2Pracitce.Text = "Practices";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.labelTab3Title);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1216, 724);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.buttonTab3SaveNewPassword);
            this.panel3.Location = new System.Drawing.Point(483, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 73);
            this.panel3.TabIndex = 6;
            // 
            // buttonTab3SaveNewPassword
            // 
            this.buttonTab3SaveNewPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab3SaveNewPassword.Location = new System.Drawing.Point(166, 19);
            this.buttonTab3SaveNewPassword.Name = "buttonTab3SaveNewPassword";
            this.buttonTab3SaveNewPassword.Size = new System.Drawing.Size(100, 36);
            this.buttonTab3SaveNewPassword.TabIndex = 11;
            this.buttonTab3SaveNewPassword.Text = "Save";
            this.buttonTab3SaveNewPassword.UseVisualStyleBackColor = true;
            this.buttonTab3SaveNewPassword.Click += new System.EventHandler(this.buttonTab3SaveNewPassword_Click);
            this.buttonTab3SaveNewPassword.MouseEnter += new System.EventHandler(this.buttonTab3SaveNewPassword_MouseEnter_1);
            this.buttonTab3SaveNewPassword.MouseLeave += new System.EventHandler(this.buttonTab3SaveNewPassword_MouseLeave_1);
            // 
            // labelTab3Title
            // 
            this.labelTab3Title.AutoSize = true;
            this.labelTab3Title.Font = new System.Drawing.Font("Segoe UI", 21.8F, System.Drawing.FontStyle.Bold);
            this.labelTab3Title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3Title.Location = new System.Drawing.Point(320, 148);
            this.labelTab3Title.Name = "labelTab3Title";
            this.labelTab3Title.Size = new System.Drawing.Size(147, 50);
            this.labelTab3Title.TabIndex = 5;
            this.labelTab3Title.Text = "Setting";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(303, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 148);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(35, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sign out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(47, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Profile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuMaterialTextboxTab3RepeatNewPassword);
            this.panel1.Controls.Add(this.labelTab3RepeatNewPassword);
            this.panel1.Controls.Add(this.bunifuMaterialTextboxTab3NewPassword);
            this.panel1.Controls.Add(this.labelTab3NewPass);
            this.panel1.Controls.Add(this.bunifuMaterialTextboxCurrentPassword);
            this.panel1.Controls.Add(this.labelTab3TitleCurrentPassword);
            this.panel1.Controls.Add(this.labelTab3Id);
            this.panel1.Controls.Add(this.labelTab3FullNameStudent);
            this.panel1.Location = new System.Drawing.Point(483, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 526);
            this.panel1.TabIndex = 3;
            // 
            // bunifuMaterialTextboxTab3RepeatNewPassword
            // 
            this.bunifuMaterialTextboxTab3RepeatNewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab3RepeatNewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.HintText = "";
            this.bunifuMaterialTextboxTab3RepeatNewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Location = new System.Drawing.Point(46, 344);
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab3RepeatNewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Name = "bunifuMaterialTextboxTab3RepeatNewPassword";
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab3RepeatNewPassword.TabIndex = 13;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelTab3RepeatNewPassword
            // 
            this.labelTab3RepeatNewPassword.AutoSize = true;
            this.labelTab3RepeatNewPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab3RepeatNewPassword.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3RepeatNewPassword.Location = new System.Drawing.Point(40, 307);
            this.labelTab3RepeatNewPassword.Name = "labelTab3RepeatNewPassword";
            this.labelTab3RepeatNewPassword.Size = new System.Drawing.Size(127, 32);
            this.labelTab3RepeatNewPassword.TabIndex = 12;
            this.labelTab3RepeatNewPassword.Text = "Last Name";
            // 
            // bunifuMaterialTextboxTab3NewPassword
            // 
            this.bunifuMaterialTextboxTab3NewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab3NewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab3NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab3NewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab3NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab3NewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab3NewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab3NewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab3NewPassword.HintText = "";
            this.bunifuMaterialTextboxTab3NewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab3NewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab3NewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab3NewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab3NewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab3NewPassword.Location = new System.Drawing.Point(46, 252);
            this.bunifuMaterialTextboxTab3NewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab3NewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab3NewPassword.Name = "bunifuMaterialTextboxTab3NewPassword";
            this.bunifuMaterialTextboxTab3NewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab3NewPassword.TabIndex = 8;
            this.bunifuMaterialTextboxTab3NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelTab3NewPass
            // 
            this.labelTab3NewPass.AutoSize = true;
            this.labelTab3NewPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab3NewPass.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3NewPass.Location = new System.Drawing.Point(40, 215);
            this.labelTab3NewPass.Name = "labelTab3NewPass";
            this.labelTab3NewPass.Size = new System.Drawing.Size(167, 32);
            this.labelTab3NewPass.TabIndex = 7;
            this.labelTab3NewPass.Text = "New Password";
            // 
            // bunifuMaterialTextboxCurrentPassword
            // 
            this.bunifuMaterialTextboxCurrentPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxCurrentPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxCurrentPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxCurrentPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxCurrentPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxCurrentPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxCurrentPassword.HintText = "";
            this.bunifuMaterialTextboxCurrentPassword.isPassword = false;
            this.bunifuMaterialTextboxCurrentPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxCurrentPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxCurrentPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxCurrentPassword.LineThickness = 3;
            this.bunifuMaterialTextboxCurrentPassword.Location = new System.Drawing.Point(46, 162);
            this.bunifuMaterialTextboxCurrentPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxCurrentPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxCurrentPassword.Name = "bunifuMaterialTextboxCurrentPassword";
            this.bunifuMaterialTextboxCurrentPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxCurrentPassword.TabIndex = 6;
            this.bunifuMaterialTextboxCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelTab3TitleCurrentPassword
            // 
            this.labelTab3TitleCurrentPassword.AutoSize = true;
            this.labelTab3TitleCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab3TitleCurrentPassword.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3TitleCurrentPassword.Location = new System.Drawing.Point(40, 125);
            this.labelTab3TitleCurrentPassword.Name = "labelTab3TitleCurrentPassword";
            this.labelTab3TitleCurrentPassword.Size = new System.Drawing.Size(199, 32);
            this.labelTab3TitleCurrentPassword.TabIndex = 5;
            this.labelTab3TitleCurrentPassword.Text = "Current Password";
            // 
            // labelTab3Id
            // 
            this.labelTab3Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTab3Id.Font = new System.Drawing.Font("Segoe UI", 15.2F, System.Drawing.FontStyle.Italic);
            this.labelTab3Id.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3Id.Location = new System.Drawing.Point(93, 62);
            this.labelTab3Id.Name = "labelTab3Id";
            this.labelTab3Id.Size = new System.Drawing.Size(239, 32);
            this.labelTab3Id.TabIndex = 4;
            this.labelTab3Id.Text = "ID : 961845125";
            this.labelTab3Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTab3FullNameStudent
            // 
            this.labelTab3FullNameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTab3FullNameStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab3FullNameStudent.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3FullNameStudent.Location = new System.Drawing.Point(16, 15);
            this.labelTab3FullNameStudent.Name = "labelTab3FullNameStudent";
            this.labelTab3FullNameStudent.Size = new System.Drawing.Size(393, 51);
            this.labelTab3FullNameStudent.TabIndex = 3;
            this.labelTab3FullNameStudent.Text = "Name LName";
            this.labelTab3FullNameStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column4
            // 
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.Name = "Column8";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label11.Location = new System.Drawing.Point(16, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(393, 51);
            this.label11.TabIndex = 3;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.2F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label10.Location = new System.Drawing.Point(93, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 32);
            this.label10.TabIndex = 4;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label9.Location = new System.Drawing.Point(40, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 32);
            this.label9.TabIndex = 5;
            // 
            // bunifuMaterialTextboxTab4PreviewPassword
            // 
            this.bunifuMaterialTextboxTab4PreviewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab4PreviewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab4PreviewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab4PreviewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab4PreviewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab4PreviewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab4PreviewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab4PreviewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab4PreviewPassword.HintText = "";
            this.bunifuMaterialTextboxTab4PreviewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab4PreviewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4PreviewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab4PreviewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4PreviewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab4PreviewPassword.Location = new System.Drawing.Point(46, 167);
            this.bunifuMaterialTextboxTab4PreviewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab4PreviewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab4PreviewPassword.Name = "bunifuMaterialTextboxTab4PreviewPassword";
            this.bunifuMaterialTextboxTab4PreviewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab4PreviewPassword.TabIndex = 6;
            this.bunifuMaterialTextboxTab4PreviewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label8.Location = new System.Drawing.Point(40, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 32);
            this.label8.TabIndex = 7;
            // 
            // bunifuMaterialTextboxTab4NewPassword
            // 
            this.bunifuMaterialTextboxTab4NewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab4NewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab4NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab4NewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab4NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab4NewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab4NewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab4NewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab4NewPassword.HintText = "";
            this.bunifuMaterialTextboxTab4NewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab4NewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4NewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab4NewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4NewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab4NewPassword.Location = new System.Drawing.Point(46, 261);
            this.bunifuMaterialTextboxTab4NewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab4NewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab4NewPassword.Name = "bunifuMaterialTextboxTab4NewPassword";
            this.bunifuMaterialTextboxTab4NewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab4NewPassword.TabIndex = 8;
            this.bunifuMaterialTextboxTab4NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label12.Location = new System.Drawing.Point(40, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 32);
            this.label12.TabIndex = 12;
            // 
            // bunifuMaterialTextboxTab4ReapeatNewPassword
            // 
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.HintText = "";
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Location = new System.Drawing.Point(46, 351);
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Name = "bunifuMaterialTextboxTab4ReapeatNewPassword";
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.TabIndex = 13;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(0, 447);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 79);
            this.panel5.TabIndex = 6;
            // 
            // buttonTab4SaveNewPassword
            // 
            this.buttonTab4SaveNewPassword.Location = new System.Drawing.Point(0, 0);
            this.buttonTab4SaveNewPassword.Name = "buttonTab4SaveNewPassword";
            this.buttonTab4SaveNewPassword.Size = new System.Drawing.Size(75, 23);
            this.buttonTab4SaveNewPassword.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label6.Location = new System.Drawing.Point(47, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 32);
            this.label6.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Location = new System.Drawing.Point(35, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 9;
            // 
            // Tab2PartPractice
            // 
            this.Tab2PartPractice.HeaderText = "Part";
            this.Tab2PartPractice.Name = "Tab2PartPractice";
            this.Tab2PartPractice.ReadOnly = true;
            // 
            // Tab2NumberPractice
            // 
            this.Tab2NumberPractice.HeaderText = "Number";
            this.Tab2NumberPractice.Name = "Tab2NumberPractice";
            this.Tab2NumberPractice.ReadOnly = true;
            // 
            // tab2DownloadPractice
            // 
            this.tab2DownloadPractice.FillWeight = 40F;
            this.tab2DownloadPractice.HeaderText = "DL";
            this.tab2DownloadPractice.Name = "tab2DownloadPractice";
            this.tab2DownloadPractice.ReadOnly = true;
            // 
            // tab2UploadPractice
            // 
            this.tab2UploadPractice.FillWeight = 40F;
            this.tab2UploadPractice.HeaderText = "UP";
            this.tab2UploadPractice.Name = "tab2UploadPractice";
            this.tab2UploadPractice.ReadOnly = true;
            // 
            // formStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formStudent";
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStudentToTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab2Quiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab2Practice)).EndInit();
            this.panelTab2InfoClass.ResumeLayout(false);
            this.panelTab2InfoClass.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.PictureBox iconSetting;
        private System.Windows.Forms.PictureBox iconProfile;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox iconStudentToTa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelTab1Title;
        private System.Windows.Forms.Label labelTab2Quiz;
        private System.Windows.Forms.Label labelTab2Pracitce;
        private System.Windows.Forms.Panel panelTab2InfoClass;
        private System.Windows.Forms.Label labelTab2NameTa;
        private System.Windows.Forms.Label labelTab2NameProfessor;
        private System.Windows.Forms.Label labelTab2NameCourse;
        private System.Windows.Forms.Button buttonTab1Archve;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridView dataGridViewTab1;
        private System.Windows.Forms.DataGridView dataGridViewTab2Quiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn tab2NumberQuiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn tab2DateQuiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn tab2GradeQuiz;
        private System.Windows.Forms.DataGridView dataGridViewTab2Practice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTab4SaveNewPassword;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab4ReapeatNewPassword;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab4NewPassword;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab4PreviewPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab3RepeatNewPassword;
        private System.Windows.Forms.Label labelTab3RepeatNewPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab3NewPassword;
        private System.Windows.Forms.Label labelTab3NewPass;
        private System.Windows.Forms.Label labelTab3FullNameStudent;
        private System.Windows.Forms.Label labelTab3Id;
        private System.Windows.Forms.Label labelTab3TitleCurrentPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxCurrentPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTab3Title;
        private System.Windows.Forms.Button buttonTab3SaveNewPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewImageColumn tab2UploadPractice;
        private System.Windows.Forms.DataGridViewImageColumn tab2DownloadPractice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tab2NumberPractice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tab2PartPractice;
    }
}