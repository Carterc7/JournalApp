using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Pages.Journal;

public class ViewModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<ViewModel> _logger;

    public ViewModel(ApplicationDbContext context, ILogger<ViewModel> logger)
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
                _logger.LogWarning($"Journal post with ID {id} not found");
                return Page();
            }

            _logger.LogInformation($"Retrieved journal post with ID: {id}");
            return Page();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error retrieving journal post with ID: {id}");
            return Page();
        }
    }
} 