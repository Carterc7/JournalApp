using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Pages.Journal;

public class EditModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<EditModel> _logger;

    public EditModel(ApplicationDbContext context, ILogger<EditModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    [BindProperty]
    public JournalPost? JournalPost { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        try
        {
            JournalPost = await _context.JournalPosts
                .FirstOrDefaultAsync(p => p.Id == id);

            if (JournalPost == null)
            {
                _logger.LogWarning($"Journal post with ID {id} not found for editing");
                return Page();
            }

            _logger.LogInformation($"Retrieved journal post with ID: {id} for editing");
            return Page();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error retrieving journal post with ID: {id} for editing");
            return Page();
        }
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (JournalPost == null)
        {
            return NotFound();
        }

        try
        {
            // Update the modified date
            JournalPost.DateModified = DateTime.Now;

            _context.Attach(JournalPost).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Updated journal post with ID: {JournalPost.Id}");
            
            // Redirect to the view page
            return RedirectToPage("/Journal/View", new { id = JournalPost.Id });
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!JournalPostExists(JournalPost.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error updating journal post with ID: {JournalPost.Id}");
            ModelState.AddModelError("", "An error occurred while updating the journal entry. Please try again.");
            return Page();
        }
    }

    private bool JournalPostExists(int id)
    {
        return _context.JournalPosts.Any(e => e.Id == id);
    }
} 