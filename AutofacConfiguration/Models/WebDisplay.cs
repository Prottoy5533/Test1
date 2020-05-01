using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacConfiguration.Models
{
    public class WebDisplay : IDisplay
    {
        private Display _display;
        private readonly HttpResponse _response;
        public WebDisplay(HttpResponse response)
        {
            _display = new Display();
            _response = response;
        }
        public async void ShowNumber(string bignumber)
        {
            await _response.WriteAsync(bignumber + _display.GetStatus());
        }
    }
}
