using System.ComponentModel.DataAnnotations;

namespace JournalApp.Models;

public class JournalPost
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
    public string Title { get; set; } = string.Empty;
    
    [Required]
    [StringLength(5000, ErrorMessage = "Content cannot be longer than 5000 characters.")]
    public string Content { get; set; } = string.Empty;
    
    public DateTime DateCreated { get; set; } = DateTime.Now;
    
    public DateTime DateModified { get; set; } = DateTime.Now;
} 