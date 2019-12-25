using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    class classProfessor : classUser
    {
        //variables
        private string id;
        private string firstName;
        private string lastName;
        private int numberYearFromStart;
        private bool term;
        //3 = professor, 2 = PrimeProfessor
        private int accessLevel;
        //to access to app database
        private database_practiceclass database;

        //methods
        public classProfessor(string newID, database_practiceclass newDatabase, bool newIsPrimeProfessor, int newNumberYearFromStart, bool newTerm)
        {
            //set values on creat
            this.id = newID;
            this.accessLevel = newIsPrimeProfessor ? 4 : 3;
            this.database = newDatabase;
            this.numberYearFromStart = newNumberYearFromStart;
            this.term = newTerm;
            var firstAndLastName = from professor in database.table_user
                                   where (professor.idUser == this.id)
                                   select new
                                   {
                                       firstName = professor.firstNameUser,
                                       lastName = professor.lastNameUser
                                   };
            this.firstName = firstAndLastName.First().firstName;
            this.lastName = firstAndLastName.First().lastName;

        }
        //returns student homePage's list of classes as a list of struct "ShowClass"
        public override string GetID()
        {
            return this.id;
        }
        //return full name
        public override string GetFullName()
        {
            return firstName + ' ' + lastName;
        }
        public override int GetAccessLevel()
        {
            return this.accessLevel;
        }
        public List<ShowClass> GetProfessorClassesList()
        {
            //select values from database
            var practiceClasses = from practiceClass in database.viewlistclass
                                  where (
                                  practiceClass.numberYearFromStart == this.numberYearFromStart &&
                                  practiceClass.termPracticeClass == this.term &&
                                  practiceClass.status == true &&
                                  practiceClass.idProfessor == this.id
                                  )
                                  select new
                                  {
                                      nameCourse = practiceClass.nameCourse.ToString(),
                                      fullNameTA = practiceClass.tafn + " " + practiceClass.taln,
                                      fullNameProfessor = practiceClass.prffn + " " + practiceClass.pfln
                                  };
            //add values to list
            List<ShowClass> result = new List<ShowClass>();
            foreach (var item in practiceClasses)
                result.Add(new ShowClass { nameCourse = item.nameCourse, fullNameTA = item.fullNameTA, fullNameProfessor = item.fullNameProfessor });
            return result;
        }
    }
}
