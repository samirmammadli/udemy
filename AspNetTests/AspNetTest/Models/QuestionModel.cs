using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetTest.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public SubjectType Type { get; set; }
        public QuestionModel(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        public QuestionModel()
        {

        }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength]
        public string Question { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength]
        public string Answer { get; set; }
    }
}