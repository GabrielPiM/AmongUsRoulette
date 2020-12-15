using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AmongUsRoulette.Models;
using AmongUsRoulette.Models.IndexInfos;
using AmongUsRoulette.Shared.Utils;
using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;

namespace AmongUsRoulette.Pages
{
    partial class Index
    {
        [Inject]
        private  HttpClient Http { get; set; }
        [Inject]
        private CurrentLanguage Language { get; set; }



        private bool isRoletaActive;
        private List<Modo> Modos;
        private IndexInfos Infos;
        string ButtonStyle;
        string GetId(int i) => "header-" + i;
        string GetHref(int i) => "#" + GetId(i);

     
        /* Carrega os dados de acordo com a linguagem do navegador. */
        protected override async Task OnInitializedAsync()
        {
            Modos = new List<Modo>();
            Modos = await Http.GetFromJsonAsync<List<Modo>>($"data/{Language.name}/modos.json");

            Infos = new IndexInfos();
            Infos = await Http.GetFromJsonAsync<IndexInfos>($"data/{Language.name}/index_infos.json");

   
        }

      
        /* Gira a roleta e desativa o botao até ela retornar a posição inicial.*/
        private async void Girar()
        {
            isRoletaActive = true;
            setBotao(isRoletaActive);
            await Task.Delay(6000);
            isRoletaActive = false;
            await Task.Delay(1000);
            setBotao(isRoletaActive);
            this.StateHasChanged();
        }

        /* Ativa/Desativar o botão de girar a roleta. */
      
        private void setBotao(bool isOn)
        {
            if (isOn)
            {
                ButtonStyle = StyleBuilder.Empty()
          .AddStyle("pointer-events", "none", when: true)
          .Build();
            }

            else
            {
                ButtonStyle = StyleBuilder.Empty()
          .Build();
            }
        }
    }
}
