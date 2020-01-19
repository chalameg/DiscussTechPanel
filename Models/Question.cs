using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussTechPanel.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }

        //secret code to remove question
        public string SecretCode { get; set; }

        public virtual List<Answer> Answers { get; set; }
    }
}
