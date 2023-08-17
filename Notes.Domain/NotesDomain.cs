using System;

namespace Notes.Domain
{
    public class Note
    {
        public Guid UserId { get; set; }
        public Guid NoteId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
