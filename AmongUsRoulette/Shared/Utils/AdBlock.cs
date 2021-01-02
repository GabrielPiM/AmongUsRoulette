using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Net.Http;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using System.Text.Encodings.Web;

namespace AmongUsRoulette.Shared.Utils
{
    public class AdBlock
    {     
     
        public HttpClient http { get; set; }
        public bool isOn { get; set; }
        public bool isDone { get; set; }

        public AdBlock( HttpClient _http)
        {
            http = _http;
            isOn = false;
        }

        public async Task CheckAdBlock()
        {
            string url = "https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js";
            HttpRequestMessage x = new HttpRequestMessage(HttpMethod.Get,url);
            x.SetBrowserRequestMode(BrowserRequestMode.NoCors);
    
            var response = await http.SendAsync(x);
            if (!response.IsSuccessStatusCode)
            {
                isOn = true;
            }
            isDone = true;
        }
    }
}
