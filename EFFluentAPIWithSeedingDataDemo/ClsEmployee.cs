using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFluentAPIWithSeedingDataDemo
{
    internal class ClsEmployee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpID { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please Enter First Name e.g. John")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Please Enter Last Name e.g. Doe")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Password should not be blank")]
        public string Password { get; set; }


        [DisplayName("Cell Number")] // Form level as we cannot enter sapce in column name in DB it only display in c sharp
        [Required(ErrorMessage = "Cell Number should not be blank")]
        public string CellNumber { get; set; }


        [Required(ErrorMessage = "Enter valid email address")]
        [EmailAddress]
        public string Email { get; set; }

        [NotMapped]
        [DisplayName("Full Name")]
        public string FullName { get; set; } // this is only in your application or in class 

        public virtual ICollection<ClsSkill> ClsSkills { get; set; }
    }
}
