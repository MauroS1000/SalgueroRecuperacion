using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SalgueroRecuperacion.Model.DogApiResponse;
using SalgueroRecuperacion.Model;
using SalgueroRecuperacion.ViewModels;

namespace SalgueroRecuperacion.ViewModels
{
    public class RazasPerrosViewModel
    {
        private readonly HttpClient _httpClient;
        //string aux = RazaEntry.text;
        public RazasPerrosViewModel()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Model.DogApiResponse> GetImages()
        {
            var response = await _httpClient.GetStringAsync("https://dog.ceo/api/breed/hound/images");
            return JsonConvert.DeserializeObject<DogApiResponse>(response);
        }

        public async Task<BreedListApiResponse> GetListaRaza()
        {
            var response = await _httpClient.GetStringAsync("https://dog.ceo/api/breeds/list/all");
            return JsonConvert.DeserializeObject<BreedListApiResponse>(response);
        }

       public async Task<DogImagesApiResponse> GetRandomImagen()
        {
            
            var response = await _httpClient.GetStringAsync("https://dog.ceo/api/breeds/image/random");
            return JsonConvert.DeserializeObject<DogImagesApiResponse>(response);
        }
    }
}
