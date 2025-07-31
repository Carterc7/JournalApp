using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Pages;

public class JournalModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<JournalModel> _logger;

    public JournalModel(ApplicationDbContext context, ILogger<JournalModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public List<JournalPost> JournalPosts { get; set; } = new();

    public async Task OnGetAsync()
    {
        try
        {
            // Fetch all journal posts from the database
            JournalPosts = await _context.JournalPosts
                .OrderByDescending(p => p.DateCreated)
                .ToListAsync();

            _logger.LogInformation($"Retrieved {JournalPosts.Count} journal posts from database");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving journal posts from database");
            // You could set an error message here to display to the user
        }
    }
} 