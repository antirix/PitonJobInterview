using Piton.Infrastructure.Event;
using System;

namespace Piton.Entities.EF
{
    public class Activity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String? Desciption { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
