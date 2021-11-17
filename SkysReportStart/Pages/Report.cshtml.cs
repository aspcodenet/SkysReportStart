using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace SkysReportStart.Pages
{
    public class ReportModel : PageModel
    {
        private readonly ILogger<ReportModel> _logger;


        public class Item
        {
            public string ProductName { get; set; }
            public string CategoryName { get; set; }
            public decimal Price { get; set; }
            public string SupplierName { get; set; }
        }

        public List<Item> Items { get; set; }

        public ReportModel(ILogger<ReportModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string q)
        {
            //q är det man sökt efter
            Items = new List<Item>();
            Items.AddRange(GetItems(q));
        }

        private IEnumerable<Item> GetItems(string q)
        {
            yield return new Item
            {
                CategoryName = "Frukt",
                Price = 12,
                ProductName = "Åpplen",
                SupplierName = "Karlssons Frukt AB"

            };
            yield return new Item
            {
                CategoryName = "Spelkonsoller",
                Price = 4999,
                ProductName = "PS5",
                SupplierName = "Amazon.se"

            };

            yield return new Item
            {
                CategoryName = "Spelkonsoller",
                Price = 1111,
                ProductName = "Nintendo Switch",
                SupplierName = "Amazon.se"

            };

        }
    }
}
