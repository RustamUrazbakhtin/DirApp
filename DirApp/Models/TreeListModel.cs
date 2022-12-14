using System;

namespace DirApp.Models
{
    public class TreeListModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public Guid? ParentId { get; set; }
        public string SizeFile { get; set; }
        public string MimeType { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
