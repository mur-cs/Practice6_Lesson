using Microsoft.AspNetCore.Mvc;
using Practice6.Models;
using System;

namespace Practice6.ViewComponents
{
    public class PersonViewComponent : ViewComponent
    {
        public string Invoke(User user)
        {
            return $"Name:{user.Name}  Age:{user.Age}";
        }
    }

    //Передача складеного об'єкту в компонент через Razor
    //@await Component.InvokeAsync("Person", new {user = new User() { Name="Serhii", Age=22}})


    //Передача складеного об'єкту в компонент через Tag-helper
    //<vc:person user = "@(new User{Name = "Serhii", Age=22})"></vc:person>


    //ViewComponentResult
    //
}
