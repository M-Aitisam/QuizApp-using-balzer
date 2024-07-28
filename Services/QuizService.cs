using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using QuizApp.Models;



namespace QuizApp.Services
{
    public class QuizService
    {
        private readonly IWebHostEnvironment _env;

        public QuizService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var filePath = Path.Combine(_env.WebRootPath, "questions.json");
            using var stream = new StreamReader(filePath);
            var json = await stream.ReadToEndAsync();
            return JsonSerializer.Deserialize<List<Category>>(json);
        }

        public async Task SaveResponsesAsync(List<int> scores)
        {
            var filePath = Path.Combine(_env.WebRootPath, "responses.json");
            var json = JsonSerializer.Serialize(scores);
            await File.WriteAllTextAsync(filePath, json);
        }
    }
}
