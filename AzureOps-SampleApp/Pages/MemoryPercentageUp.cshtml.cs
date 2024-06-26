using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureOps_SampleApp.Pages
{
    public class MemoryPercentageUpModel : PageModel
    {
        private readonly ILogger<MemoryPercentageUpModel> _logger;

        public MemoryPercentageUpModel(ILogger<MemoryPercentageUpModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            // メモリ使用量を意図的に上げる
            var list = new List<string>();
            // ログに出力される
            _logger.LogInformation("メモリ使用率を意図的に上昇させます");
            while (true)
            {
                list.Add("あいうえおかきくけこさしすせそたちつてと");
            }
        }
    }
}