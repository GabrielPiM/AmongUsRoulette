using AmongUsRoulette.Models;
using AmongUsRoulette.Shared.Utils;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AmongUsRoulette.Shared.Index
{
    partial class ScrollToMode
    {
        [Inject]
        private HttpClient Http { get; set; }
        [Inject]
        private CurrentLanguage Language { get; set; }

        private List<String> ModosNames;    

        protected override async Task OnInitializedAsync()
        {
            ModosNames = new List<String>();
            ModosNames = await Http.GetFromJsonAsync<List<string>>($"data/{Language.name}/modos_names.json");
       
        }
    }
}
