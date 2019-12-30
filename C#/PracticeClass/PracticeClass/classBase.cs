using System;
using System.Linq;

namespace PracticeClass {
    //taples of ClassList
    struct ShowClass {
        public string nameCourse;
        public string fullNameTA;
        public string fullNameProfessor;
        public short groupNumber;
        public bool term;
        public short year;
        //"grade = -1" means no grade or profrssor/TA class list
        public Nullable<float> grade;
    }
    //taples of QuizList
    struct ShowQuiz {
        public DateTime date;
        public short number;
    }
    //taples of PracticeList
    struct ShowPractice {
        public short number;
        public string link;
        public int part;
        public string idUploader;
    }
    struct ShowStudent {
        public string fullName;
        public string id;
        //"grade = -1" means no grade
        public Nullable<float> grade;
    }
    class classBase {
        private database_practiceclass database;
        private classUser user { get; set; }
        private bool userType;
        private short numberYearFromStart;
        private bool term;
        public classBase() {
            database = new database_practiceclass();
            //test basic data
            //set basic App Datas
            //term=this.database.table_systemDatas.termNow;
            term = true;
            //numberYearFromStart= this.database.table_systemDatas.numberYearNow;
            numberYearFromStart = 98;
        }
        public classStudent LoginStudent(string id, string password) {
            //first check if user exists as a Student then check if password is true
            if (database.table_student.Any(user => user.idStudent == id) && database.table_user.Any(user => user.idUser == id && user.password == password)) {
                //return Class student
                return new classStudent(id, database, this.IsTA(id), numberYearFromStart, term);
            }
            return null;
        }
        //return true if user is a TA for a Class or some classes
        public bool IsTA(string id) {
            //return true if exist a class that (TA id = this.id) in this term
            return database.table_practiceclass.Any(practiceClass =>
            practiceClass.idTA == id &&
            practiceClass.numberYearFromStart == this.numberYearFromStart &&
            practiceClass.termPracticeClass == this.term
            );
        }
        //login method and creater of professor
        public classProfessor LoginProfessor(string id, string password) {
            //first check if user exists as a professor then check if password is true
            if (database.table_professor.Any(user => user.idProfessor == id) && database.table_user.Any(user => user.idUser == id && user.password == password)) {
                //return professor if user is valid
                return new classProfessor(id, database, this.IsPrimeProfessor(id), numberYearFromStart, term);
            }
            return null;
        }
        //return true if user is a PrimeProfessor
        public bool IsPrimeProfessor(string id) {
            return database.table_professor.Any(professor => professor.idProfessor == id && professor.isPrime == true);
        }
        //edit first name , last name , password
        //empty string("") means attribute is "unchenged" 
        //"return -1" means "ErroR" and "return 1" means "Done"
        public int EditUser(string newFirstName = "", string newLastName = "", string newPassword = "") {
            var selectedUser = (from item in this.database.table_user
                                where (item.idUser == this.user.GetID())
                                select item).ToList().First();
            if (selectedUser == null)
                return -1;
            if (newFirstName != "")
                selectedUser.firstNameUser = newFirstName;
            if (newLastName != "")
                selectedUser.lastNameUser = newLastName;
            if (newPassword != "")
                selectedUser.password = newPassword;
            this.database.SaveChanges();
            return 1;
        }
        //add new user to database
        //"return -2" means "User exists", "return -3" means "wrong accessLevel" and "return 1" means "Done"
        public int AddNewUser(string id, int accessLevel) {
            if (this.database.table_user.Any(item => item.idUser == id))
                return -2;
            this.database.table_user.Add(new table_user { idUser = id, firstNameUser = "", lastNameUser = "", password = "" });
            if (accessLevel == 1) {
                this.database.table_student.Add(new table_student { idStudent = id });
                this.database.SaveChanges();
                return 1;
            }
            else if (accessLevel == 3 || accessLevel == 4) {
                this.database.table_professor.Add(new table_professor {
                    idProfessor = id,
                    isPrime = (accessLevel == 3) ? false : true
                });
                this.database.SaveChanges();
                return 1;
            }
            else
                return -3;
        }
    }
}


