using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussTechPanel.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
