using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Models;

namespace MegaDeskWeb.Pages
{
    public class EditModel : PageModel
    {

        public List<Quote.MaterialList> MaterialList = Enum.GetValues(typeof(Quote.MaterialList)).Cast<Quote.MaterialList>().ToList();

        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        public EditModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Quote Quote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quote = await _context.Quote.FirstOrDefaultAsync(m => m.ID == id);

            if (Quote == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Quote.Width * Quote.Depth < Quote.BASESIZE)
            {
                Quote.TotalAmount += Quote.BASEPRICE;

                if (Quote.Material == "Oak")
                {
                    Quote.TotalAmount += Quote.OAKPRICE;
                }
                if (Quote.Material == "Laminate")
                {
                    Quote.TotalAmount += Quote.LAMINATEPRICE;
                }
                if (Quote.Material == "Pine")
                {
                    Quote.TotalAmount += Quote.PINEPRICE;
                }
                if (Quote.Material == "Rosewood")
                {
                    Quote.TotalAmount += Quote.ROSEPRICE;
                }
                if (Quote.Material == "Veneer")
                {
                    Quote.TotalAmount += Quote.VENEERPRICE;
                }

                if (Quote.RushOrder == 3)
                {
                    Quote.TotalAmount += Quote.RUSHDAYS3;
                }

                if (Quote.RushOrder == 5)
                {
                    Quote.TotalAmount += Quote.RUSHDAYS5;
                }
                if (Quote.RushOrder == 7)
                {
                    Quote.TotalAmount += Quote.RUSHDAYS7;
                }
                if (Quote.NumOfDrawers == 0)
                {
                    Quote.TotalAmount += 0;
                }

                if (Quote.NumOfDrawers == 1)
                {
                    Quote.TotalAmount += 50;
                }
                if (Quote.NumOfDrawers == 2)
                {
                    Quote.TotalAmount += 100;
                }
                if (Quote.NumOfDrawers == 3)
                {
                    Quote.TotalAmount += 150;
                }
                if (Quote.NumOfDrawers == 4)
                {
                    Quote.TotalAmount += 200;
                }
                if (Quote.NumOfDrawers == 5)
                {
                    Quote.TotalAmount += 250;
                }
                if (Quote.NumOfDrawers == 6)
                {
                    Quote.TotalAmount += 300;
                }
                if (Quote.NumOfDrawers == 7)
                {
                    Quote.TotalAmount += 350;
                }

            }


            //between 1000 and 2000 inches

            else if (Quote.Width * Quote.Depth < Quote.MIDDLESIZE)
            {
                Quote.TotalAmount += Quote.Width * Quote.Depth;
                if (Quote.Material == "Oak")
                {
                    Quote.TotalAmount += Quote.OAKPRICE;
                }
                if (Quote.Material == "Laminate")
                {
                    Quote.TotalAmount += Quote.LAMINATEPRICE;
                }
                if (Quote.Material == "Pine")
                {
                    Quote.TotalAmount += Quote.PINEPRICE;
                }
                if (Quote.Material == "Rosewood")
                {
                    Quote.TotalAmount += Quote.ROSEPRICE;
                }
                if (Quote.Material == "Veneer")
                {
                    Quote.TotalAmount += Quote.VENEERPRICE;
                }

                if (Quote.RushOrder == 3)
                {
                    Quote.TotalAmount += 70;
                }

                if (Quote.RushOrder == 5)
                {
                    Quote.TotalAmount += 50;
                }
                if (Quote.RushOrder == 7)
                {
                    Quote.TotalAmount += 35;
                }

                if (Quote.NumOfDrawers == 0)
                {
                    Quote.TotalAmount += 0;
                }
                if (Quote.NumOfDrawers == 1)
                {
                    Quote.TotalAmount += 50;
                }
                if (Quote.NumOfDrawers == 2)
                {
                    Quote.TotalAmount += 100;
                }
                if (Quote.NumOfDrawers == 3)
                {
                    Quote.TotalAmount += 150;
                }
                if (Quote.NumOfDrawers == 4)
                {
                    Quote.TotalAmount += 200;
                }
                if (Quote.NumOfDrawers == 5)
                {
                    Quote.TotalAmount += 250;
                }
                if (Quote.NumOfDrawers == 6)
                {
                    Quote.TotalAmount += 300;
                }
                if (Quote.NumOfDrawers == 7)
                {
                    Quote.TotalAmount += 350;
                }
            }


            //Greater than 2000

            else if (Quote.Width * Quote.Depth >= Quote.MIDDLESIZE)
            {
                Quote.TotalAmount += Quote.Width * Quote.Depth;
                if (Quote.Material == "Oak")
                {
                    Quote.TotalAmount += Quote.OAKPRICE;
                }
                if (Quote.Material == "Laminate")
                {
                    Quote.TotalAmount += Quote.LAMINATEPRICE;
                }
                if (Quote.Material == "Pine")
                {
                    Quote.TotalAmount += Quote.PINEPRICE;
                }
                if (Quote.Material == "Rosewood")
                {
                    Quote.TotalAmount += Quote.ROSEPRICE;
                }
                if (Quote.Material == "Veneer")
                {
                    Quote.TotalAmount += Quote.VENEERPRICE;
                }

                if (Quote.RushOrder == 3)
                {
                    Quote.TotalAmount += 80;
                }

                if (Quote.RushOrder == 5)
                {
                    Quote.TotalAmount += 60;
                }
                if (Quote.RushOrder == 7)
                {
                    Quote.TotalAmount += 40;
                }
                if (Quote.NumOfDrawers == 0)
                {
                    Quote.TotalAmount += 0;
                }
                if (Quote.NumOfDrawers == 1)
                {
                    Quote.TotalAmount += 50;
                }
                if (Quote.NumOfDrawers == 2)
                {
                    Quote.TotalAmount += 100;
                }
                if (Quote.NumOfDrawers == 3)
                {
                    Quote.TotalAmount += 150;
                }
                if (Quote.NumOfDrawers == 4)
                {
                    Quote.TotalAmount += 200;
                }
                if (Quote.NumOfDrawers == 5)
                {
                    Quote.TotalAmount += 250;
                }
                if (Quote.NumOfDrawers == 6)
                {
                    Quote.TotalAmount += 300;
                }
                if (Quote.NumOfDrawers == 7)
                {
                    Quote.TotalAmount += 350;
                }
            }


            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Quote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteExists(Quote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool QuoteExists(int id)
        {
            return _context.Quote.Any(e => e.ID == id);
        }
    }
}
