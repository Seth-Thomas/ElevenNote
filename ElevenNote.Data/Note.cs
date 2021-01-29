using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        //[Range(1,10, ErrorMessage="please choose a number between 1 and 10")]
        //[MaxLength(100, ErrorMessage="too many characters in this field")]
        //[Display(Name="Your Name")]
        public Guid OwnerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
