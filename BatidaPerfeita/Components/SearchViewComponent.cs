using BatidaPerfeita.Models.ViewModels;
using BatidaPerfeita.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BatidaPerfeita.Components
{
    public class SearchViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new SearchViewModel();
            return View(viewModel);
        }
    }
}
