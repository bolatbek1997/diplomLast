namespace DiplomLast.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tester")]
    public partial class Tester
    {
        

        public int id { get; set; }

        [Required]
        [Display(Name = "ИИН")]        
        [StringLength(100, ErrorMessage = "Символы должны быть 12", MinimumLength = 12)]     
        public string iin { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Фамиля")]       
        public string familiya { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Имя")]
        public string name { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Отчество")]
        public string fatherName { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Ваша профессия")]
        public string spretsialist { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Required]
        [Display(Name = "Дата рождения")]
        public DateTime? birthDate { get; set; }

        [StringLength(15)]
        [Required]
        [Display(Name = "Номер телефона")]
        public string phoneNumber { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Адрес электронной почты")]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [Display(Name = "Пол")]
        public bool? pol { get; set; }
        [Required]
        [Display(Name = "Опыт работы(написать лет вашей работы)")]       
        public decimal? opitRboty { get; set; }
        //[Required]
        [Display(Name = "Aдрес (Улица и дом номера)")]
        public int? adressID { get; set; }
        //[Required]
        [Display(Name = "Семеиное полажение")]
        public int? semeynoePolojenyeID { get; set; }
        //[Required]
        [Display(Name = "Образавания")]
        public int? obrazavanyeID { get; set; }
        //[Required]
        [Display(Name = "Университет")]
        public int? universityID { get; set; }
        //[Required]
        [Display(Name = "Желаемая должность")]
        public int? zhelaemayaVakansya { get; set; }   
      
        public int? resultQuizID { get; set; }

        public virtual Adress Adress { get; set; }

        public virtual obrazovanye obrazovanye { get; set; }

        public virtual semeynoePolojenie semeynoePolojenie { get; set; }

        public virtual university university { get; set; }

        public virtual Vakansya Vakansya { get; set; }
    }
}
