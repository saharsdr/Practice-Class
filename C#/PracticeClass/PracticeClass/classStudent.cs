using System.Collections.Generic;
using System.Linq;

namespace PracticeClass {
    class classStudent : classUser {
        //variables
        private string id;
        private string firstName;
        private string lastName;
        private short numberYearFromStart;
        private bool term;
        //1 = student, 2 = TA
        private int accessLevel;
        //to access to app database
        private database_practiceclass database;

        //methods
        public classStudent(string newID, database_practiceclass newDatabase, bool newIsTA, short newNumberYearFromStart, bool newTerm) {
            //set values on creat
            this.id = newID;
            this.accessLevel = newIsTA ? 2 : 1;
            this.database = newDatabase;
            this.numberYearFromStart = newNumberYearFromStart;
            this.term = newTerm;
            var firstAndLastName = from strudent in database.table_user
                                   where (strudent.idUser == this.id)
                                   select new {
                                       firstName = strudent.firstNameUser,
                                       lastName = strudent.lastNameUser
                                   };
            this.firstName = firstAndLastName.First().firstName;
            this.lastName = firstAndLastName.First().lastName;
        }
        //returns student homePage's list of classes as a list of struct "ShowClass"
        public override string GetID() {
            return this.id;
        }
        //return full name
        public override string GetFullName() {
            return firstName + ' ' + lastName;
        }
        public override int GetAccessLevel() {
            return this.accessLevel;
        }
        //return on going classes list for this student
        public List<ShowClass> GetStudentOnGoingClassesList() {
            //select values from database and add values to list
            List<ShowClass> practiceClasses = (from practiceClass in database.viewstudentlistclass
                                               where (
                                               practiceClass.numberYearFromStart == this.numberYearFromStart &&
                                               practiceClass.termPracticeClass == this.term &&
                                               practiceClass.status == true &&
                                               practiceClass.idStudent == this.id
                                               )
                                               select new ShowClass {
                                                   nameCourse = practiceClass.nameCourse,
                                                   fullNameTA = practiceClass.tafn + " " + practiceClass.talnm,
                                                   fullNameProfessor = practiceClass.proffnam + " " + practiceClass.proflnam,
                                                   groupNumber = practiceClass.groupeNumberPracticeClass,
                                                   year = this.numberYearFromStart,
                                                   term = this.term,
                                                   grade = 0
                                               }
                                               ).ToList<ShowClass>();
            return practiceClasses;
        }
        public List<ShowClass> GetStudentArchivedClassesList() {
            List<ShowClass> archivedClasses = (from practiceClass in database.viewstudentlistclass
                                               where (
                                               practiceClass.idStudent == this.id &&
                                               practiceClass.numberYearFromStart != this.numberYearFromStart &&
                                               practiceClass.termPracticeClass != this.term
                                               )
                                               select new ShowClass {
                                                   nameCourse = practiceClass.nameCourse,
                                                   fullNameTA = practiceClass.tafn + " " + practiceClass.talnm,
                                                   fullNameProfessor = practiceClass.proffnam + " " + practiceClass.proflnam,
                                                   groupNumber = practiceClass.groupeNumberPracticeClass,
                                                   year = this.numberYearFromStart,
                                                   term = this.term,
                                                   grade = practiceClass.gradePracticeClassStudent
                                               }
                                             ).ToList<ShowClass>();
            return archivedClasses;
        }
        //if user is not student in this term returns "null" else returns "on going classes list" for this TA
        public List<ShowClass> GetTAOnGoingClassesList() {
            //student is not TA
            if (this.accessLevel != 2)
                return null;
            List<ShowClass> classes = (from practiceClass in this.database.viewlistclass
                                       where (
                                       practiceClass.idTA == this.id &&
                                       practiceClass.numberYearFromStart == this.numberYearFromStart &&
                                       practiceClass.termPracticeClass == this.term &&
                                       practiceClass.classDel == false
                                       )
                                       select new ShowClass {
                                           fullNameProfessor = practiceClass.prffn + " " + practiceClass.pfln,
                                           fullNameTA = practiceClass.tafn + " " + practiceClass.taln,
                                           groupNumber = practiceClass.groupeNumberPracticeClass,
                                           nameCourse = practiceClass.nameCourse,
                                           term = practiceClass.termPracticeClass,
                                           year = practiceClass.numberYearFromStart,
                                           grade = -1
                                       }).ToList<ShowClass>();
            return classes;
        }
        public List<ShowClass> GetTAArchivedClassesList() {
            List<ShowClass> classes = (from practiceClass in this.database.viewlistclass
                                       where (
                                       practiceClass.idTA == this.id &&
                                       practiceClass.numberYearFromStart != this.numberYearFromStart &&
                                       practiceClass.termPracticeClass != this.term &&
                                       practiceClass.classDel == false
                                       )
                                       select new ShowClass {
                                           fullNameProfessor = practiceClass.prffn + " " + practiceClass.pfln,
                                           fullNameTA = practiceClass.tafn + " " + practiceClass.taln,
                                           groupNumber = practiceClass.groupeNumberPracticeClass,
                                           nameCourse = practiceClass.nameCourse,
                                           term = practiceClass.termPracticeClass,
                                           year = practiceClass.numberYearFromStart,
                                           grade = -1
                                       }).ToList<ShowClass>();
            return classes;
        }
    }
}
