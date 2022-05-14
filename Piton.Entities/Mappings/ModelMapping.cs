using AutoMapper;
using Piton.Entities.DTO;
using Piton.Entities.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piton.Entities.Mappings
{
    public class ModelMappin :Profile
    {
        public ModelMappin()
        {
            CreateMap<Activity, ActivityDTO>();
        }
    }
}
