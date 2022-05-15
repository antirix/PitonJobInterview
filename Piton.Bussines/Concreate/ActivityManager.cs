using Piton.Business.Abstract;
using Piton.Business.Utilities.Result;
using Piton.Entities.EF;
using Piton.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piton.Business.Concreate
{
    public class ActivityManager : IActivityService
    {
        IActivityDal _fkRepositoryActivity;
        public ActivityManager(IActivityDal fkRepositoryActivity)
        {
            _fkRepositoryActivity = fkRepositoryActivity;
        }
        public IResult Add(Activity activity)
        {
            if (activity.StartDate < activity.EndDate)
            {
                _fkRepositoryActivity.Add(activity);
                return new SuccessResult("Added.");
            }
            return new ErrorResult("Start date can't small end date.");
        }

        public IResult Delete(int id)
        {
            var activity = _fkRepositoryActivity.GetAll(x => x.Id == id);
            if (activity.Count > 0) {
                _fkRepositoryActivity.Delete(activity[0]);
                return new SuccessResult("Deleted.");
            }
            return new ErrorResult("Not Deleted");
           
        }

        public IDataResult<List<Activity>> GetAll()
        {
            var x = _fkRepositoryActivity.GetAll();
            return new SuccessDataResult<List<Activity>>(x,"All Activities Listed");
        }

        public IDataResult<List<Activity>> GetById(int id)
        {
            return new SuccessDataResult<List<Activity>>(_fkRepositoryActivity.GetAll(p => p.Id == id), "Activity Listed");
        }

        public IDataResult<List<Activity>> GetAfterTodayActivitys()
        {
            return new SuccessDataResult<List<Activity>>(_fkRepositoryActivity.GetAll(p => p.StartDate.Day>DateTime.Today.Day),"After Today Activities Listed");
        }

        public IDataResult<List<Activity>> GetBeforeTodayActivitys()
        {
            return new SuccessDataResult<List<Activity>>(_fkRepositoryActivity.GetAll(p => p.StartDate.Day < DateTime.Today.Day), "Before Today Activities Listed");
        }

        public IDataResult<List<Activity>> GetMonthlyActivitys()
        {
            return new SuccessDataResult<List<Activity>>(_fkRepositoryActivity.GetAll(p => p.StartDate.Month == DateTime.Today.Month), "Montly Activities Listed");
        }

        public IDataResult<List<Activity>> GetTodayActivitys()
        {
            return new SuccessDataResult<List<Activity>>(_fkRepositoryActivity.GetAll(p => p.StartDate.Day == DateTime.Today.Day), "Today Activities Listed");
        }

        private int GetWeekEnd(string day)
        {
            List<string> weeks = new() {"Monday", "Tuesday", "Wednesday", "Thursday","Friday", "Saturday", "Sunday" };
            var x = weeks.IndexOf(day);
            return x;
        }
        public IDataResult<List<Activity>> GetWeeklyActivitys()
        {
            var x = DateTime.Today;
            var day = GetWeekEnd(x.DayOfWeek.ToString());
            x = x.AddDays((day*(-1)));
            return new SuccessDataResult<List<Activity>>(_fkRepositoryActivity.GetAll(p => p.StartDate > x && p.StartDate < x.AddDays(7)), "Weekly Activities Listed");
        }

        public IResult Update(Activity activity)
        {
            _fkRepositoryActivity.Update(activity);
            return new SuccessResult("Update.");
        }
    }
}
