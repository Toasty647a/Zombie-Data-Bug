using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zombie_Data_Bug.Pages {
    public class IndexModel : PageModel {

        [BindProperty]
        public List<string> Strings { get; set; } = ["first", "second", "third"];

        public void OnPostRemoveSecond() => Strings.Remove("second");
    }
}
