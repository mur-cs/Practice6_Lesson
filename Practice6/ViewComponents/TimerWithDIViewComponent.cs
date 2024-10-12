using Microsoft.AspNetCore.Mvc;
using Practice6.Models;

namespace Practice6.ViewComponents
{
    public class TimerWithDIViewComponent : ViewComponent
    {
        private readonly ITimeService _timeService;
        public TimerWithDIViewComponent(ITimeService service)
        {
            _timeService = service;
        }
        public string Invoke()
        {
            return $"Current time: {_timeService.GetTime()}";
        }
    }
}
