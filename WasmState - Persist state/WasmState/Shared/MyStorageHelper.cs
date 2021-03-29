using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Text.Json;
using WasmState.Services;
namespace WasmState.Shared
{
    public class MyStorageHelper
    {
        private CounterStateService Model;
        private IJSRuntime js;

        public MyStorageHelper(IJSRuntime js, CounterStateService m)
        {
            this.Model = m;
            this.js = js;
        }

        public async void Save() {
            var data = JsonSerializer.Serialize(Model);
          await  js.InvokeAsync<object>("stateManager.save", nameof(CounterStateService), data);
        
        }

        public async void Load() {
            string data;
            data = await js.InvokeAsync<string>("stateManager.load", nameof(CounterStateService));

            if (!string.IsNullOrEmpty(data))
            {
                try
                {
                    var m = JsonSerializer.Deserialize<CounterStateService>(data);
                    if (m != null)
                    {
                        Model.CounterCount = m.CounterCount;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

        }

    }
}
