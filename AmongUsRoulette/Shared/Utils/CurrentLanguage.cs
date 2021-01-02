using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AmongUsRoulette.Shared.Utils
{
    public class CurrentLanguage
    {
        
        private readonly IJSRuntime js;
        public string name { get; set; }
        public bool isDone { get; set; }

        private List<string> supportedLanguages;

        public CurrentLanguage(IJSRuntime _js)
        {
            supportedLanguages = new List<string>();
            js = _js;
            name = "en-US";
            isDone = false;
        }   

        public async Task SetLanguage()
        {          
            AddSuppotedLanguages();
            await GetLanguage();
        }

        private void AddSuppotedLanguages()
        {
            supportedLanguages.Add("pt-BR");
            supportedLanguages.Add("en-US");
        }

        private async Task  GetLanguage()
        {
            var lang = await js.InvokeAsync<string>("getLanguage");

            if (IslanguageSupported(lang))            
                name = lang;
            
            isDone = true;
        }

        private bool IslanguageSupported(string lang)
        {
            return supportedLanguages.Exists(l => l == lang);
        }


    }

}
