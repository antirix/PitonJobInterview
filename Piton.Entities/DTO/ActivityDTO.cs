using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piton.Entities.DTO
{
    public class ActivityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String? Desciption { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}