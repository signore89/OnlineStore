using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OnlineStoreDouble.Models;

namespace ClientApp
{
    internal class HttpWorker
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        public HttpWorker(string baseUrl)
        {
            _baseUrl = baseUrl;
            _httpClient = new HttpClient();
        }

        public async Task<List<ProductCategory>> GetAllCategoryProductAsync(string endpoint)
        {
            var url = $"{_baseUrl}/{endpoint}";
            var response = await _httpClient.GetAsync(url);
            var responseStream = response.Content.ReadAsStreamAsync().Result;
            var responseData = JsonSerializer.DeserializeAsync<List<ProductCategory>>(responseStream).Result;
            return responseData;
        }

        public async Task<bool> CategoryProducPostAsync(string endpoint, ProductCategory data)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}/{endpoint}", data);
            return response.IsSuccessStatusCode;
        }









        
    }
}
