using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Models
{
    public class BarcodeDate
    {
        public string Date { get; set; }
        public int Shift { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        [Display(Name = "Machine Number")]
        public int MachineNumber { get; set; }
        public string Color { get; set; }
        public string Worker { get; set; }

        [Display(Name= "Quality Inspector")]
        public string QualityInspector { get; set; }
        public double Weight { get; set; }
        public string Barcode { get; set; }
    }
}
