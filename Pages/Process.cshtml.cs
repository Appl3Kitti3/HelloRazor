using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace MyApp.Namespace
{
    // Business Logic place
    public class ProcessModel : PageModel
    {
        /// <summary>
        /// On Load
        /// </summary>
        public void OnGet()
        {
            // ViewData["Message"] = "This is our first day in the 2024 Fall term";
            // string[] people = {"Frank", "Gabby", "Term"};
            // ViewData["People"] = people;

            var Procs = Process.GetProcesses();
            ViewData["Procs"] = Procs;

        }
    }
}
