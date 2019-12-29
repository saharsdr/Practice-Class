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


            bunifuCustomDataGridTab1.BackgroundColor = them.row;
            bunifuCustomDataGridTab1.ForeColor = them.mainText;
            bunifuCustomDataGridTab1.GridColor = them.unmainText;
            bunifuCustomDataGridTab1.ColumnHeadersDefaultCellStyle.ForeColor = them.row;
            bunifuCustomDataGridTab1.ColumnHeadersDefaultCellStyle.BackColor = them.unmainText;

            tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelTab2InfoClass.BackColor = them.row;
            buttonTab1Archve.BackColor = them.buttonOut;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.iconSetting = new System.Windows.Forms.PictureBox();
            this.iconProfile = new System.Windows.Forms.PictureBox();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.iconStudentToTa = new System.Windows.Forms.PictureBox();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonTab1Archve = new System.Windows.Forms.Button();
            this.labelTab1Title = new System.Windows.Forms.Label();
            this.bunifuCustomDataGridTab1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelTab2InfoClass = new System.Windows.Forms.Panel();
            this.labelTab2NameTa = new System.Windows.Forms.Label();
            this.labelTab2NameProfessor = new System.Windows.Forms.Label();
            this.labelTab2NameCourse = new System.Windows.Forms.Label();
            this.labelTab2Quiz = new System.Windows.Forms.Label();
            this.labelTab2Pracitce = new System.Windows.Forms.Label();
            this.bunifuCustomDataGridTab2Quiz = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuCustomDataGridTab2Practice = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStudentToTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridTab1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelTab2InfoClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridTab2Quiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridTab2Practice)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(62, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1224, 753);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.buttonTab1Archve);
            this.tabPage1.Controls.Add(this.labelTab1Title);
            this.tabPage1.Controls.Add(this.bunifuCustomDataGridTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1216, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
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
            // bunifuCustomDataGridTab1
            // 
            this.bunifuCustomDataGridTab1.AllowUserToAddRows = false;
            this.bunifuCustomDataGridTab1.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGridTab1.AllowUserToOrderColumns = true;
            this.bunifuCustomDataGridTab1.AllowUserToResizeColumns = false;
            this.bunifuCustomDataGridTab1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGridTab1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGridTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGridTab1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGridTab1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.bunifuCustomDataGridTab1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGridTab1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGridTab1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGridTab1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 17F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGridTab1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGridTab1.ColumnHeadersHeight = 45;
            this.bunifuCustomDataGridTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bunifuCustomDataGridTab1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.bunifuCustomDataGridTab1.DoubleBuffered = true;
            this.bunifuCustomDataGridTab1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGridTab1.GridColor = System.Drawing.Color.Silver;
            this.bunifuCustomDataGridTab1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGridTab1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGridTab1.Location = new System.Drawing.Point(47, 107);
            this.bunifuCustomDataGridTab1.Name = "bunifuCustomDataGridTab1";
            this.bunifuCustomDataGridTab1.ReadOnly = true;
            this.bunifuCustomDataGridTab1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGridTab1.RowHeadersVisible = false;
            this.bunifuCustomDataGridTab1.RowTemplate.DividerHeight = 1;
            this.bunifuCustomDataGridTab1.RowTemplate.Height = 30;
            this.bunifuCustomDataGridTab1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGridTab1.Size = new System.Drawing.Size(1120, 556);
            this.bunifuCustomDataGridTab1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Course";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Professor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelTab2InfoClass);
            this.tabPage2.Controls.Add(this.labelTab2Quiz);
            this.tabPage2.Controls.Add(this.labelTab2Pracitce);
            this.tabPage2.Controls.Add(this.bunifuCustomDataGridTab2Quiz);
            this.tabPage2.Controls.Add(this.bunifuCustomDataGridTab2Practice);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1216, 724);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.labelTab2NameProfessor.Location = new System.Drawing.Point(548, 1);
            this.labelTab2NameProfessor.Name = "labelTab2NameProfessor";
            this.labelTab2NameProfessor.Size = new System.Drawing.Size(123, 45);
            this.labelTab2NameProfessor.TabIndex = 7;
            this.labelTab2NameProfessor.Text = "Quizes";
            // 
            // labelTab2NameCourse
            // 
            this.labelTab2NameCourse.AutoSize = true;
            this.labelTab2NameCourse.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2NameCourse.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2NameCourse.Location = new System.Drawing.Point(41, 0);
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
            // bunifuCustomDataGridTab2Quiz
            // 
            this.bunifuCustomDataGridTab2Quiz.AllowUserToAddRows = false;
            this.bunifuCustomDataGridTab2Quiz.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGridTab2Quiz.AllowUserToOrderColumns = true;
            this.bunifuCustomDataGridTab2Quiz.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGridTab2Quiz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuCustomDataGridTab2Quiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGridTab2Quiz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGridTab2Quiz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.bunifuCustomDataGridTab2Quiz.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGridTab2Quiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGridTab2Quiz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGridTab2Quiz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGridTab2Quiz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGridTab2Quiz.ColumnHeadersHeight = 45;
            this.bunifuCustomDataGridTab2Quiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bunifuCustomDataGridTab2Quiz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.bunifuCustomDataGridTab2Quiz.DoubleBuffered = true;
            this.bunifuCustomDataGridTab2Quiz.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGridTab2Quiz.GridColor = System.Drawing.Color.Silver;
            this.bunifuCustomDataGridTab2Quiz.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGridTab2Quiz.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGridTab2Quiz.Location = new System.Drawing.Point(636, 216);
            this.bunifuCustomDataGridTab2Quiz.Name = "bunifuCustomDataGridTab2Quiz";
            this.bunifuCustomDataGridTab2Quiz.ReadOnly = true;
            this.bunifuCustomDataGridTab2Quiz.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGridTab2Quiz.RowHeadersVisible = false;
            this.bunifuCustomDataGridTab2Quiz.RowTemplate.DividerHeight = 1;
            this.bunifuCustomDataGridTab2Quiz.RowTemplate.Height = 30;
            this.bunifuCustomDataGridTab2Quiz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGridTab2Quiz.Size = new System.Drawing.Size(529, 470);
            this.bunifuCustomDataGridTab2Quiz.TabIndex = 2;
            this.bunifuCustomDataGridTab2Quiz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGridTab2Quiz_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Prat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "DL";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "UP";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            // 
            // bunifuCustomDataGridTab2Practice
            // 
            this.bunifuCustomDataGridTab2Practice.AllowUserToAddRows = false;
            this.bunifuCustomDataGridTab2Practice.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGridTab2Practice.AllowUserToOrderColumns = true;
            this.bunifuCustomDataGridTab2Practice.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGridTab2Practice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuCustomDataGridTab2Practice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGridTab2Practice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGridTab2Practice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.bunifuCustomDataGridTab2Practice.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGridTab2Practice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGridTab2Practice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGridTab2Practice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGridTab2Practice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuCustomDataGridTab2Practice.ColumnHeadersHeight = 45;
            this.bunifuCustomDataGridTab2Practice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bunifuCustomDataGridTab2Practice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.bunifuCustomDataGridTab2Practice.DoubleBuffered = true;
            this.bunifuCustomDataGridTab2Practice.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGridTab2Practice.GridColor = System.Drawing.Color.Silver;
            this.bunifuCustomDataGridTab2Practice.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGridTab2Practice.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGridTab2Practice.Location = new System.Drawing.Point(46, 216);
            this.bunifuCustomDataGridTab2Practice.Name = "bunifuCustomDataGridTab2Practice";
            this.bunifuCustomDataGridTab2Practice.ReadOnly = true;
            this.bunifuCustomDataGridTab2Practice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGridTab2Practice.RowHeadersVisible = false;
            this.bunifuCustomDataGridTab2Practice.RowTemplate.DividerHeight = 1;
            this.bunifuCustomDataGridTab2Practice.RowTemplate.Height = 30;
            this.bunifuCustomDataGridTab2Practice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGridTab2Practice.Size = new System.Drawing.Size(529, 470);
            this.bunifuCustomDataGridTab2Practice.TabIndex = 1;
            this.bunifuCustomDataGridTab2Practice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGridTab2Practice_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prat";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Number";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grade";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DL";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "UP";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridTab1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelTab2InfoClass.ResumeLayout(false);
            this.panelTab2InfoClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridTab2Quiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridTab2Practice)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGridTab1;
        private System.Windows.Forms.Label labelTab1Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGridTab2Quiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGridTab2Practice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.Label labelTab2Quiz;
        private System.Windows.Forms.Label labelTab2Pracitce;
        private System.Windows.Forms.Panel panelTab2InfoClass;
        private System.Windows.Forms.Label labelTab2NameTa;
        private System.Windows.Forms.Label labelTab2NameProfessor;
        private System.Windows.Forms.Label labelTab2NameCourse;
        private System.Windows.Forms.Button buttonTab1Archve;
    }
}