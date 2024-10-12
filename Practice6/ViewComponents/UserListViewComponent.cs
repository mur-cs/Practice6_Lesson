using Microsoft.AspNetCore.Mvc;

namespace Practice6.ViewComponents
{
    public class UserListViewComponent : ViewComponent
    {
        List<string> _users;
        public UserListViewComponent()
        {
            _users = new List<string>()
            {
                "Tom", "Serhii", "Tim", "Kate"
            };
        }

        public IViewComponentResult Invoke()
        {
            return View(_users);
        }
    }
}
