//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticeClass
{
    using System;
    using System.Collections.Generic;
    
    public partial class table_student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public table_student()
        {
            this.table_practiceclass = new HashSet<table_practiceclass>();
            this.table_practicestudent = new HashSet<table_practicestudent>();
            this.table_quizstudent = new HashSet<table_quizstudent>();
            this.table_studentpracticeclass = new HashSet<table_studentpracticeclass>();
        }
    
        public string idStudent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_practiceclass> table_practiceclass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_practicestudent> table_practicestudent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_quizstudent> table_quizstudent { get; set; }
        public virtual table_user table_user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_studentpracticeclass> table_studentpracticeclass { get; set; }
    }
}