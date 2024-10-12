
//Створення класів Component
//Invoke - обов'язковий.


//Передача складеного об'єкту в компонент через Razor
//@await Component.InvokeAsync("Person", new {user = new User() { Name="Serhii", Age=22}})


//Передача складеного об'єкту в компонент через Tag-helper
//<vc:person user = "@(new User{Name = "Serhii", Age=22})"></vc:person>

//-----------------------------------------------------------------------
//public class TimerViewComponent
//{
//	public string Invoke()
//	{
//		return $"Current time: {DateTime.Now.ToString("hh:mm:ss")}"
//	}
//}

//-----------------------------------------------------------------------
//public class Timer : ViewComponent
//{
//	public string Invoke()
//	{
//		return $"Current time: {DateTime.Now.ToString("hh:mm:ss")}"
//	}
//}


//-----------------------------------------------------------------------
//[ViewComponent]
//public class Timer
//{
//	public string Invoke()
//	{
//		return $"Current time: {DateTime.Now.ToString("hh:mm:ss")}"
//	}
//}
//-----------------------------------------------------------------------

//public class TimerViewComponent : ViewComponent
//{
//	public string Invoke()
//	{
//		return $"Current time: {DateTime.Now.ToString("hh:mm:ss")}";
//	}
//}


//Виклик компонента у файлі представлення через Razor

//@await Component.InvokeAsync("Timer") 
//В дужках - назва компонента

//Виклик компонента у файлі представлення через Tag-helper
//Додаємо в _ViewImports : @addTagHelper *, Назва проєкту
//<vc:timer></vc:timer>


//-----------------------------------------------------------------------
//-----------------------------------------------------------------------
//-----------------------------------------------------------------------

//public class TimerViewComponent : ViewComponent
//{
//    public string Invoke(bool includeSeconds)
//    {
//        if (includeSeconds)
//        {
//            return $"Current time: {DateTime.Now.ToString("hh:mm:ss")}";
//        }
//        else
//        {
//            return $"Current time: {DateTime.Now.ToString("hh:mm")}";
//        }
//    }
//}
//Виклик компонента з параметрами через Tag-helper
//<vc:timer include-seconds="true"></vc:timer> 

//Виклик компонента з параметрами через Razor
//@await Component.InvokeAsync("Timer", new { includeSeconds = true })


//-----------------------------------------------------------------------
//-----------------------------------------------------------------------
//-----------------------------------------------------------------------


//Повернення результату через IViewComponentResult
//Якщо не успадкуємо клас ViewComponent, то не буде методів Content, Json, HttpContext, ViewBag и так далі


//-----------------------------------------------------------------------

//Повернення відповіді через Content
//public class TimerViewComponent : ViewComponent 
//{
//    public IViewComponentResult Invoke()
//    {
//            return Content($"Current time: {DateTime.Now.ToString("hh:mm:ss")}");
//    }
//}

//-----------------------------------------------------------------------

//Повернення відповіді у вигляді розмітки HTML 
//public class TimerViewComponent : ViewComponent
//{
//    public IViewComponentResult Invoke()
//    {
//        return new HtmlContentViewComponentResult(new HtmlString("<p>Hello from HtmlContentViewComponentResult</p>"));
//    }
//}

//-----------------------------------------------------------------------

//Повернення відповіді через інший ViewComponent
//Ще створюємо папку Shared->Components->Назва компоненту->Default.cshtml
//Назва .cshtml файлу можна змінити і, щоб правильно викликати, ми маємо викликати View("Назва представлення", _users"), тобто перегрузки


//public class UserListViewComponent : ViewComponent
//{
//    List<string> _users;
//    public UserListViewComponent()
//    {
//        _users = new List<string>()
//        {
//            "Tom", "Serhii", "Tim", "Kate"
//        };
//    }

//    public IViewComponentResult Invoke()
//    {
//        return View(users); 
//    }
//}

//public class TimerViewComponent : ViewComponent
//{
//    public IViewComponentResult Invoke()
//    {
//        return new HtmlContentViewComponentResult(new HtmlString("<p>Hello from HtmlContentViewComponentResult</p>"));
//    }
//}

//-----------------------------------------------------------------------
//-----------------------------------------------------------------------
//-----------------------------------------------------------------------


//Асинхроний компонент
//Робимо Files папку, в яку закидаємо .html файл
//Створюємо компонент 

//public class HeaderViewComponent : ViewComponent
//{
//	public async Task<IViewComponentResult> InvokeAsync()
//	{
//		string htmlContent = String.Empty;
//		using (StreamReader reader = new StreamReader("Files/header.html"))
//		{
//			htmlContent = await reader.ReadToEndAsync();
//		}
//		return new HtmlContentViewComponentResult(new HtmlString(htmlContent));
//	}
//}

//Викликаємо компонент 

//@await Component.InvokeAsync("Header")

//-----------------------------------------------------------------------
//-----------------------------------------------------------------------
//-----------------------------------------------------------------------

//Перевіряємо чи передана властивість number

//public class UserQueryListViewComponent : ViewComponent
//{
//	List<string> _users;
//	public UserQueryListViewComponent()
//	{
//		_users = new List<string>()
//			{
//				"Tom", "Serhii", "Tim", "Kate"
//			};
//	}
//	public IViewComponentResult Invoke()
//	{
//		int number = _users.Count;

//		if (Request.Query.ContainsKey("number"))
//		{
//			Int32.TryParse(Request.Query["number"].ToString(), out number);
//		}

//		ViewBag.Users = _users.Take(number);
//		ViewData["Header"] = $"Users count : {number}";
//		return View();
//	}
//}

//@await Component.InvokeAsync("UserQueryList")