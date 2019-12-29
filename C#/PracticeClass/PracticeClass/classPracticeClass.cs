using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeClass {
    class classPracticeClass {
        //variables
        //to access to app database
        private database_practiceclass database;
        private bool term { get; }
        private short numberYearFromStart { get; }
        private short groupNumber { get; }
        //   private string idCourse { get; }
        private string nameCourse { get; }
        private string idProfessor { get; }
        private string fullNameProfessor { get; }
        private string idTA { get; }
        private string fullNameTA { get; }
        //methods
        public classPracticeClass(database_practiceclass database, bool term, short numberYearFromStart, short groupNumber) {
            //set basic data
            this.database = database;
            this.term = term;
            this.numberYearFromStart = numberYearFromStart;
            this.groupNumber = groupNumber;
            //get other basic data from database
            var temp = from practiceClass in database.viewlistclass
                       where (
                                 practiceClass.numberYearFromStart == this.numberYearFromStart &&
                                 practiceClass.termPracticeClass == this.term &&
                                 practiceClass.groupeNumberPracticeClass == this.groupNumber
                                 )
                       select new {
                           nameCourse = practiceClass.nameCourse,
                           //idCourse = practiceClass.idCourse,
                           fullNameTA = practiceClass.tafn + ' ' + practiceClass.taln,
                           idTA = practiceClass.idTA,
                           fullNameProfessor = practiceClass.prffn + ' ' + practiceClass.pfln,
                           idProfessor = practiceClass.idProfessor,
                       };
            //this.idCourse = temp.First().idCourse;
            this.nameCourse = temp.First().nameCourse;
            this.idProfessor = temp.First().idProfessor;
            this.fullNameProfessor = temp.First().fullNameProfessor;
            this.idTA = temp.First().idTA;
            this.fullNameTA = temp.First().fullNameTA;
        }
        public List<ShowQuiz> GetClassQuizList() {
            //get quizList from database
            var quizList = from quiz in database.table_quiz
                           where (
                           quiz.groupeNumberPracticeClass == this.groupNumber &&
                           quiz.numberYearFromStart == this.numberYearFromStart &&
                           quiz.termPracticeClass == this.term &&
                           quiz.deleted == false
                           )
                           select new {
                               date = quiz.dateQuiz.ToString(),
                               number = quiz.numberQuiz
                           };
            //convert quizList to a List of struct "ShoeQuiz"
            List<ShowQuiz> result = new List<ShowQuiz>();
            foreach (var item in quizList)
                result.Add(new ShowQuiz {
                    date = DateTime.Parse(item.date),
                    number = item.number
                });
            return result;
        }
        public List<ShowPractice> GetClassPracticeList() {
            var practiceList = from practice in database.table_practice
                               where (
                               practice.groupeNumberPracticeClass == this.groupNumber &&
                               practice.numberYearFromStart == this.numberYearFromStart &&
                               practice.termPracticeClass == this.term &&
                               practice.deleted == false
                               )
                               select new {
                                   number = practice.numberPractice,
                                   link = practice.linkPractice,
                                   part = practice.partPractice,
                                   idUploader = practice.idUploader
                               };
            List<ShowPractice> result = new List<ShowPractice>();
            foreach (var item in practiceList)
                result.Add(new ShowPractice {
                    number = item.number,
                    link = item.link,
                    part = item.part,
                    idUploader = item.idUploader
                });
            return result;
        }
        private bool IsStudentOfClass(string id) {
            return this.database.table_studentpracticeclass.Any(
                    practiceClass =>
                    practiceClass.groupeNumberPracticeClass == this.groupNumber &&
                    practiceClass.numberYearFromStart == this.numberYearFromStart &&
                    practiceClass.termPracticeClass == this.term &&
                    practiceClass.idStudent == id &&
                    practiceClass.deleted == false
                );
        }
        private bool IsPracticeOfClass(short number, short part) {
            return this.database.table_practice.Any(
                    practice =>
                    practice.groupeNumberPracticeClass == this.groupNumber &&
                    practice.numberYearFromStart == this.numberYearFromStart &&
                    practice.termPracticeClass == this.term &&
                    practice.numberPractice == number &&
                    practice.partPractice == part &&
                    practice.deleted == false
                );
        }
        //"-2" means "wrong student id", "-3" means "wrong practice (does not exists)", "-4" means "reapeted solved pracrice or link"
        public int AddSolvedPractice(short practiceNumber, short practicePart, string userID, string SolvedPracticelink) {
            if (!IsStudentOfClass(userID))
                return -2;
            if (!IsPracticeOfClass(practiceNumber, practicePart))
                return -3;
            if (this.database.table_practicestudent.Any(solvedPractice =>
                        (solvedPractice.groupeNumberPracticeClass == this.groupNumber &&
                        solvedPractice.numberYearFromStart == this.numberYearFromStart &&
                        solvedPractice.termPracticeClass == this.term &&
                        solvedPractice.partPractice == practicePart &&
                        solvedPractice.numberPractice == practiceNumber &&
                        solvedPractice.idStudent == userID) ||
                        solvedPractice.linkSolvedPractice == SolvedPracticelink)
                )
                return -4;
            database.table_practicestudent.Add(new table_practicestudent {
                groupeNumberPracticeClass = this.groupNumber,
                numberYearFromStart = this.numberYearFromStart,
                termPracticeClass = this.term,
                partPractice = practicePart,
                numberPractice = practiceNumber,
                idStudent = userID,
                linkSolvedPractice = SolvedPracticelink,
                timePracticeStudent = DateTime.Now
            });
            return 1;
        }

    }
}
