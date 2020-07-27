using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Client
{
    public class SingletonService
    {
        public int Valor { get; set; }
    }
    public class TransientService
    {
        public int Valor { get; set; }
    }
}
