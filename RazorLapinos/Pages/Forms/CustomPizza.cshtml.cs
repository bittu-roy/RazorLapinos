using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLapinos.Models;
using System.Security.Cryptography.X509Certificates;


namespace RazorLapinos.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        //help us to access and create pizzas from custom pizza views.
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        //property to store final calculated price before sending it out
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        //onPost function will be used when anything is submitted with post method
        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Chicken) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", 
                new { 
                    Pizza.PizzaName, PizzaPrice
                }
            );

        }
    }
}
