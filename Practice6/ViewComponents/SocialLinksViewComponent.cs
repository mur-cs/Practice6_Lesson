using Microsoft.AspNetCore.Mvc;

namespace Practice6.ViewComponents
{
	public class SocialLinksViewComponent : ViewComponent
	{
		List<SocialIcon> icons = new List<SocialIcon>();
		public SocialLinksViewComponent()
		{
			icons = SocialIcon.AppSocialIcons();
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var model = icons;
			return await Task.FromResult((IViewComponentResult)View("SocialLinks",model));
		}
	}
}
