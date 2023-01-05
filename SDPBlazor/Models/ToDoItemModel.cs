using System.ComponentModel.DataAnnotations;

namespace SDPBlazor.Models
{
    public class ToDoItemModel
    {
        [StringLength(20, ErrorMessage = "Title is too long. Max 20 characters.")]
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}

