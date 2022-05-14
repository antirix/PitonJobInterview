using Piton.Entities.EF;
using Piton.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piton.Infrastructure.Repositories
{
    public class EFActivityDal : EFRepository<Activity, BaseContext>, IActivityDal
    {
    }
}
