using System;
using System.ComponentModel.DataAnnotations;


namespace TestCaseUsers.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        [RegularExpression(@"^[a-zA-Z._\(0-9)\-]+$")]
        public string Login { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        [RegularExpression(@"^[A-Za-zА-Яа-яЁё]+$")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        [RegularExpression(@"^[A-Za-zА-Яа-яЁё]+$")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(13)]
        [MinLength(6)]
        [RegularExpression(@"(\+?\d[- .]*){7,13}")]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(5)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(5)]       
        [RegularExpression(@"^[A-Za-zА-Яа-яЁё.,\(0-9)\-\s]+$")]
        public string HomeAddress { get; set; }
    }
}