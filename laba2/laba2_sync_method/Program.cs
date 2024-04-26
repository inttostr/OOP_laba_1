using System;
using System.IO;
using System.Net.Http;
using System.Diagnostics;
using System.Threading;
class Program1
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

        // Запрос вакансий по компании "МГТУ СТАНКИН"
        HttpResponseMessage response = client.GetAsync("https://api.hh.ru/vacancies?employer_id=3094855").Result;
        string json = response.Content.ReadAsStringAsync().Result;
        File.WriteAllText("vacancies_mgtu_stankin_sync.json", json); // Сохраняем ответ в файл
        Console.WriteLine("Ответ от API hh.ru по запросу 'МГТУ СТАНКИН' сохранен в файл vacancies_mgtu_stankin_sync.json");
Thread.Sleep(5000);
stopwatch.Stop();
        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        //("Общее время работы: " + DateTime.Now.TimeOfDay);
    }
}