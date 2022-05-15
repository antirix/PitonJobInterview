using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Piton.Business.Abstract;
using Piton.Entities.EF;
using Piton.Infrastructure.Repositories;

namespace Piton.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        IActivityService _activityService;
        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpPost("Add")]
        public IActionResult Add(Activity activity)
        {
            var result = _activityService.Add(activity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(int id)
        {
            var result = _activityService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Activity activity)
        {
            var result = _activityService.Update(activity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _activityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _activityService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetAfterTodayActivitys")]
        public IActionResult GetAfterTodayActivitys()
        {
            var result = _activityService.GetAfterTodayActivitys();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetBeforeTodayActivitys")]
        public IActionResult GetBeforeTodayActivitys()
        {
            var result = _activityService.GetBeforeTodayActivitys();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("GetMonthlyActivitys")]
        public IActionResult GetMonthlyActivitys()
        {
            var result = _activityService.GetMonthlyActivitys();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetTodayActivitys")]
        public IActionResult GetTodayActivitys()
        {
            var result = _activityService.GetTodayActivitys();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetWeeklyActivitys")]
        public IActionResult GetWeeklyActivitys()
        {
            var result = _activityService.GetWeeklyActivitys();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
