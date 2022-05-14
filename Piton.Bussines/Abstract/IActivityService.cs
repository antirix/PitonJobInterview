using Piton.Business.Utilities.Result;
using Piton.Entities.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piton.Business.Abstract
{
    public interface IActivityService
    {
        IDataResult<List<Activity>> GetAll();
        IDataResult<List<Activity>> GetById(int id);
        IDataResult<List<Activity>> GetTodayActivitys();
        IDataResult<List<Activity>> GetBeforeTodayActivitys();
        IDataResult<List<Activity>> GetAfterTodayActivitys();
        IDataResult<List<Activity>> GetWeeklyActivitys();
        IDataResult<List<Activity>> GetMonthlyActivitys();
        IResult Update(Activity activity);
        IResult Delete(int id);
        IResult Add(Activity activity);
    }
}
