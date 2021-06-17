using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWASMDemo.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private int _incrementAmount = 0;

        private string _text;

        private void IncrementCount()
        {
            currentCount += _incrementAmount;
        }
    }
}
