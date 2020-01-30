using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiplomLast.Models
{
    public class TesterViewModels
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public partial class OneTesterView
    {
        public int? age { get; set; }

        public string iin { get; set; }

     
        public string fio { get; set; }

   
        //public string name { get; set; }

        //public string fatherName { get; set; }

  
        public string spretsialist { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? birthDate { get; set; }
      

       
        public string phoneNumber { get; set; }

    
        public string email { get; set; }
        
        public string pol { get; set; }
        
        public decimal? opitRboty { get; set; }
        
        public string adressID { get; set; }
     
        public string semeynoePolojenyeID { get; set; }
      
        public string obrazavanyeID { get; set; }
       
        public string universityID { get; set; }
        
        public string zhelaemayaVakansya { get; set; }

        public virtual List<QuizResult> quizResults { get; set; }
    }
}