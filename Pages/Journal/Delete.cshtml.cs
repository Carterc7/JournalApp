using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Pages.Journal;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<DeleteModel> _logger;

    public DeleteModel(ApplicationDbContext context, ILogger<DeleteModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public JournalPost? JournalPost { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        try
        {
            JournalPost = await _context.JournalPosts
                .FirstOrDefaultAsync(p => p.Id == id);

            if (JournalPost == null)
            {
                _logger.LogWarning($"Journal post with ID {id} not found for deletion");
                return Page();
            }

            _logger.LogInformation($"Retrieved journal post with ID: {id} for deletion");
            return Page();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error retrieving journal post with ID: {id} for deletion");
            return Page();
        }
    }

    public async Task<IActionResult> OnPostAsync(int id)
    {
        try
        {
            JournalPost = await _context.JournalPosts
                .FirstOrDefaultAsync(p => p.Id == id);

            if (JournalPost == null)
            {
                _logger.LogWarning($"Journal post with ID {id} not found for deletion");
                return RedirectToPage("/Journal");
            }

            _context.JournalPosts.Remove(JournalPost);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Deleted journal post with ID: {id}");
            
            // Redirect to the main journal page
            return RedirectToPage("/Journal");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error deleting journal post with ID: {id}");
            return Page();
        }
    }
} 