using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JournalApp.Data;
using JournalApp.Models;

namespace JournalApp.Pages.Journal;

public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<CreateModel> _logger;

    public CreateModel(ApplicationDbContext context, ILogger<CreateModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    [BindProperty]
    public JournalPost JournalPost { get; set; } = new();

    public void OnGet()
    {
        // Initialize with current date
        JournalPost.DateCreated = DateTime.Now;
        JournalPost.DateModified = DateTime.Now;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            // Set timestamps
            JournalPost.DateCreated = DateTime.Now;
            JournalPost.DateModified = DateTime.Now;

            _context.JournalPosts.Add(JournalPost);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Created new journal post with ID: {JournalPost.Id}");
            
            // Redirect to the main journal page
            return RedirectToPage("/Journal");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error creating journal post");
            ModelState.AddModelError("", "An error occurred while creating the journal entry. Please try again.");
            return Page();
        }
    }
} 