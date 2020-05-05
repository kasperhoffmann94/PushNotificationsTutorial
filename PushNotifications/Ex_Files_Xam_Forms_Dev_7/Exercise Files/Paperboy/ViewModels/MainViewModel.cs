using Paperboy.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperboy.ViewModels
{
    public class MainViewModel : ObservableBase
    {
        public MainViewModel()
        {
            this.WorldNews = new ObservableCollection<News.NewsInformation>();
            this.TechnologyNews = new ObservableCollection<News.NewsInformation>();
            this.TrendingNews = new ObservableCollection<News.NewsInformation>();
            this.Favorites = new FavoritesCollection();

            this.CurrentUser = new UserInformation()
            {
                DisplayName = "Scott",
                BioContent = "Scott has been developing Microsoft Enterprise solutions for organizations around the world for the last 28 years, and is the Senior Architect & Developer behind Liquid Daffodil.",
                ProfileImageUrl = "https://wintellectnow.blob.core.windows.net/public/Scott_Peterson.jpg",
            };

        }

        private ObservableCollection<News.NewsInformation> _worldNews;
        public ObservableCollection<News.NewsInformation> WorldNews
        {
            get { return this._worldNews; }
            set { this.SetProperty(ref this._worldNews, value); }
        }

        private ObservableCollection<News.NewsInformation> _technologyNews;
        public ObservableCollection<News.NewsInformation> TechnologyNews
        {
            get { return this._technologyNews; }
            set { this.SetProperty(ref this._technologyNews, value); }
        }

        private ObservableCollection<News.NewsInformation> _trendingNews;
        public ObservableCollection<News.NewsInformation> TrendingNews
        {
            get { return this._trendingNews; }
            set { this.SetProperty(ref this._trendingNews, value); }
        }

        private FavoritesCollection _favorites;
        public FavoritesCollection Favorites
        {
            get { return this._favorites; }
            set { this.SetProperty(ref this._favorites, value); }
        }


        private UserInformation _currentUser;
        public UserInformation CurrentUser
        {
            get { return this._currentUser; }
            set { this.SetProperty(ref this._currentUser, value); }
        }

        private string _platformLabel;
        public string PlatformLabel
        {
            get { return this._platformLabel; }
            set { this.SetProperty(ref this._platformLabel, value); }
        }

        private string _extendedPlatformLabel;
        public string ExtendedPlatformLabel
        {
            get { return this._extendedPlatformLabel; }
            set { this.SetProperty(ref this._extendedPlatformLabel, value); }
        }

        private DeviceOrientations _currentOrientation;
        public DeviceOrientations CurrentOrientation
        {
            get { return this._currentOrientation; }
            set { this.SetProperty(ref this._currentOrientation, value); }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return this._isBusy; }
            set { this.SetProperty(ref this._isBusy, value); }
        }

        public async void RefreshNewsAsync()
        {
            this.IsBusy = true;

            await RefreshWorldNewsAsync();
            await RefreshTechnologyNewsAsync();
            await RefreshTrendingNewsAsync();
            
            this.IsBusy = false;
        }



        public async Task RefreshFavoritesAsync()
        {
            this.IsBusy = true;

            this.Favorites.Clear();

            var favorites = await FavoritesManager.DefaultManager.GetFavoritesAsync();

            foreach (var favorite in favorites)
            {
                this.Favorites.Add(favorite.AsFavorite("Technology"));
            }

            this.IsBusy = false;
        }


        public async Task RefreshWorldNewsAsync()
        {
            this.WorldNews.Clear();

            var news = await Helpers.NewsHelper.GetByCategoryAsync(News.NewsCategoryType.World);

            foreach (var item in news)
            {
                this.WorldNews.Add(item);
            }
        }

        public async Task RefreshTechnologyNewsAsync()
        {
            this.TechnologyNews.Clear();

            var news = await Helpers.NewsHelper.GetByCategoryAsync(News.NewsCategoryType.ScienceAndTechnology);

            foreach (var item in news)
            {
                this.TechnologyNews.Add(item);
            }
        }

        public async Task RefreshTrendingNewsAsync()
        {
            this.TrendingNews.Clear();

            var news = await Helpers.NewsHelper.GetTrendingAsync();

            foreach (var item in news)
            {
                this.TrendingNews.Add(item);
            }
        }

    }
}
