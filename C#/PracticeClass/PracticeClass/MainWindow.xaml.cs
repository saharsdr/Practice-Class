using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PracticeClass {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            classBase baseClass = new classBase();
            classStudent student= baseClass.LoginStudent("961845102", "1");
            List<ShowClass> temp = student.GetStudentOnGoingClassesList();
            ShowClass f = temp.First();
            classPracticeClass pc = new classPracticeClass(f.term, f.year, f.groupNumber);
        }
    }
}
