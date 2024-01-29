using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Project.DAL.Models;
using Project.DAL.Models.Enums;
using Project.PL.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project.PL.Controllers
{
    public class BarcodeController : Controller
    {
        private readonly PdfConverter _converter;

        public BarcodeController()
        {
            _converter = new PdfConverter();
        }
        public IActionResult Index()
        {
            
            List<BarcodeDate> data = new List<BarcodeDate>()
            { 
                new BarcodeDate()
                {
                    Date = "2023-10-26",
                    Shift = 1,
                    Name = "Widget A",
                    Quantity = 100,
                    MachineNumber = 123,
                    Color = "Blue",
                    Worker = "John Smith",
                    QualityInspector = "Jane Doe",
                    Weight = 10.5,
                    Barcode = "CHT54001"
                },
                new BarcodeDate()
                {
                    Date = "2023-10-27",
                    Shift = 2,
                    Name = "Widget B",
                    Quantity = 200,
                    MachineNumber = 456,
                    Color = "Red",
                    Worker = "Jane Doe",
                    QualityInspector = "John Smith",
                    Weight = 15.2,
                    Barcode = "CHT54002"
                },
                new BarcodeDate()
                {
                    Date = "2023-10-28",
                    Shift = 3,
                    Name = "Widget C",
                    Quantity = 50,
                    MachineNumber = 789,
                    Color = "Green",
                    Worker = "Mike Jones",
                    QualityInspector = "Sarah Lee",
                    Weight = 8.7,
                    Barcode = "CHT54003"
                },
            };

          
            return View(data);
        }

        // /Barcode/GeneratePdf
        [HttpPost]
        public IActionResult GeneratePdf(string[] htmlContent)
        {
           
            byte[] pdfBytes = _converter.ConvertHtmlToPdf(htmlContent);

            // Now you can return the PDF as a file or perform other actions.
           
            return File(pdfBytes, "application/pdf", "output.pdf");
        }
    }
}
