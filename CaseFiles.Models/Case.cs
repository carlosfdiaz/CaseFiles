using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseFiles.Models
{
    public class Case
    {
        public int Id { get; set; }

        [ForeignKey("Note")]
        public int NoteId { get; set; }
        public virtual Note Note { get; set; }
    }
}
