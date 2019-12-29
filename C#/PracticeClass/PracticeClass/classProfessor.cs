using System.Collections.Generic;
using System.Linq;

namespace PracticeClass {
    class classProfessor : classUser {
        //variables
        private string id;
        private string firstName;
        private string lastName;
        private short numberYearFromStart;
        private bool term;
        //3 = professor, 2 = PrimeProfessor
        private int accessLevel;
        //to access to app database
        private database_practiceclass database;

        //methods
        public classProfessor(string newID, database_practiceclass newDatabase, bool newIsPrimeProfessor, short newNumberYearFromStart, bool newTerm) {
            //set values on creat
            this.id = newID;
            this.accessLevel = newIsPrimeProfessor ? 4 : 3;
            this.database = newDatabase;
            this.numberYearFromStart = newNumberYearFromStart;
            this.term = newTerm;
            var firstAndLastName = from professor in database.table_user
                                   where (professor.idUser == this.id)
                                   select new {
                                       firstName = professor.firstNameUser,
                                       lastName = professor.lastNameUser
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
        public List<ShowClass> GetProfessorClassesList() {
            //select values from database and add them to list
            var practiceClasses = (from practiceClass in database.viewlistclass
                                   where (
                                   practiceClass.numberYearFromStart == this.numberYearFromStart &&
                                   practiceClass.termPracticeClass == this.term &&
                                   practiceClass.status == true &&
                                   practiceClass.idProfessor == this.id
                                   )
                                   select new ShowClass {
                                       fullNameProfessor = practiceClass.prffn + " " + practiceClass.pfln,
                                       fullNameTA = practiceClass.tafn + " " + practiceClass.taln,
                                       groupNumber = practiceClass.groupeNumberPracticeClass,
                                       nameCourse = practiceClass.nameCourse.ToString(),
                                       term = this.term,
                                       year = this.numberYearFromStart,
                                       grade = -1
                                   }).ToList<ShowClass>();
            return practiceClasses;
        }
    }
}
