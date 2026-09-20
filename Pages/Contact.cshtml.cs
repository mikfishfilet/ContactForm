using ContactApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ContactApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty] 
        public Contact Contact { get; set; }

        private readonly string filePath;

        public ContactModel()
        {
            filePath = Path.Combine(
                Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, 
                "data", 
                "contacts.json"
                );
        }
        
        public void OnGet()
        {
        }
        
        public IActionResult OnPost()
        {
            Console.WriteLine("ONPOST WAS CALLED");
            Console.WriteLine($"FILE PATH: {filePath}");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            List<Contact> contacts = new List<Contact>();
            if (System.IO.File.Exists(filePath))
            {
                string json = System.IO.File.ReadAllText(filePath);

                if (!string.IsNullOrWhiteSpace(json))
                {
                    contacts = JsonSerializer.Deserialize<List<Contact>>(json)
                        ?? new List<Contact>();
                }
            }
            contacts.Add(Contact);

            string updatedJson = JsonSerializer.Serialize(
                contacts, 
                new JsonSerializerOptions { WriteIndented = true 
                });

            System.IO.File.WriteAllText(filePath, updatedJson);

            return RedirectToPage("/ThankYou");
        }
    }
}