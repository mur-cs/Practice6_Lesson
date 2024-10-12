using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Practice6.Models;
using System.ComponentModel;

namespace Practice6.ViewComponents
{


    public class TimerViewComponent : ViewComponent
    {
        public string Invoke(bool includeSeconds)
        {
            if (includeSeconds)
            {
                return $"Current time: {DateTime.Now.ToString("hh:mm:ss")}";
            }
            else
            {
                return $"Current time: {DateTime.Now.ToString("hh:mm")}";
            }
        }
    }

}
