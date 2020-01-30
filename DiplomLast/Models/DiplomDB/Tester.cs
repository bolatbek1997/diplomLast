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
        [Display(Name = "���")]        
        [StringLength(100, ErrorMessage = "������� ������ ���� 12", MinimumLength = 12)]     
        public string iin { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "������")]       
        public string familiya { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "���")]
        public string name { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "��������")]
        public string fatherName { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "���� ���������")]
        public string spretsialist { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Required]
        [Display(Name = "���� ��������")]
        public DateTime? birthDate { get; set; }

        [StringLength(15)]
        [Required]
        [Display(Name = "����� ��������")]
        public string phoneNumber { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "����� ����������� �����")]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [Display(Name = "���")]
        public bool? pol { get; set; }
        [Required]
        [Display(Name = "���� ������(�������� ��� ����� ������)")]       
        public decimal? opitRboty { get; set; }
        //[Required]
        [Display(Name = "A���� (����� � ��� ������)")]
        public int? adressID { get; set; }
        //[Required]
        [Display(Name = "�������� ���������")]
        public int? semeynoePolojenyeID { get; set; }
        //[Required]
        [Display(Name = "�����������")]
        public int? obrazavanyeID { get; set; }
        //[Required]
        [Display(Name = "�����������")]
        public int? universityID { get; set; }
        //[Required]
        [Display(Name = "�������� ���������")]
        public int? zhelaemayaVakansya { get; set; }   
      
        public int? resultQuizID { get; set; }

        public virtual Adress Adress { get; set; }

        public virtual obrazovanye obrazovanye { get; set; }

        public virtual semeynoePolojenie semeynoePolojenie { get; set; }

        public virtual university university { get; set; }

        public virtual Vakansya Vakansya { get; set; }
    }
}
