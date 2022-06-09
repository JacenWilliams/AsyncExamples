using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AsyncUIExample
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly HttpClient client;
        private string url = "https://zoo-animal-api.herokuapp.com/animals/rand";
        private Animal? _animal;
        private int _count;

        public MainViewModel()
        {
            client = new HttpClient();
            GetAnimalCommand = new RelayCommand(GetRandomAnimal);
            IncrementCountCommand = new RelayCommand(IncrementCount);
        }

        public ICommand GetAnimalCommand { get; }
        public ICommand IncrementCountCommand { get; }

        public Animal? Animal
        {
            get => _animal;
            set => SetProperty(ref _animal, value);
        }

        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }

        public void IncrementCount()
        {
            Count++;
        }

        public void GetRandomAnimal()
        {
            Animal = null;
            var collection = new ObservableCollection<Animal>();

            Task.Run(GetAnimal)
                .ContinueWith(task =>
            {
                Animal = task.Result;
                collection.Add(Animal);
            });
        }

        public Animal GetAnimal()
        {
            Thread.Sleep(3000);
            return client.GetFromJson<Animal>(url);
        }

        public async Task GetRandomAnimalAsync()
        {
            Animal = null;
            await Task.Delay(3000); // artificial delay
            Animal = await client.GetFromJsonAsync<Animal>(url);
        }
    }
}
