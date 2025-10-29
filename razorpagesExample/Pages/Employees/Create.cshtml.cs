using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorpagesExample.Models;
using razorpagesExample.Repository;

namespace razorpagesExample.Pages;

public class CreateModel : PageModel
{
    private readonly IEmployeeRepository _repo;

    [BindProperty]
    public Employee Employee { get; set; }

    public CreateModel(IEmployeeRepository repo)
    {
        _repo = repo;
    }
    public void OnGet()
    {

    }
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _repo.Create(Employee);
        return RedirectToPage("/Employees/Index");
    }
}