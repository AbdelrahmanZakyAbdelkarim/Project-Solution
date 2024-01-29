using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Models
{
    //Model
    public class BOM
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid CopiedFromBomId { get; set; } = Guid.NewGuid();
    }
}
