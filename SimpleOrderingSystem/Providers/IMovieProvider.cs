using SimpleOrderingSystem.DataModels;

namespace SimpleOrderingSystem.Providers;

internal interface IMovieProvider
{
    Task<GetMovieApiResponseDataModel> GetMovieAsync(string apiKey, string id);

    Task<SearchMoviesApiResponseDataModel> SearchMoviesAsync(string apiKey, string title);
}