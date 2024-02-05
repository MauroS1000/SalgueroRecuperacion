using Newtonsoft.Json;
using SalgueroRecuperacion.Model;
using SalgueroRecuperacion.ViewModels;

namespace SalgueroRecuperacion;

public partial class MainPage : ContentPage
{
    private readonly RazasPerrosViewModel _viewModel;
    private readonly HttpClient _httpClient;
    public MainPage()
    {
        InitializeComponent();
        _viewModel = new RazasPerrosViewModel();
        BindingContext = _viewModel;
    
    }

    private async void OnMostrarSiguienteImagenClicked(object sender, EventArgs e)
    {
        
        var randomImageApiResponse = await _viewModel.GetRandomImagen();
        var Raza = await _viewModel.GetListaRaza();

        if (randomImageApiResponse.Status == "success")
        {
            ImagenPerro.Source = randomImageApiResponse.Message;
            ImagenPerro.Source = randomImageApiResponse.Message;
        }
        else
        {
        }

        /*async Task<DogImagesApiResponse> GetRandomImagen()
        {
            var response = await _httpClient.GetStringAsync(string.Format("https://dog.ceo/api/breeds/{0}/random", RazaEntry.Text));
            return JsonConvert.DeserializeObject<DogImagesApiResponse>(response);
        }*/
    }
}




