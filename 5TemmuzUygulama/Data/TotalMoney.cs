using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TemmuzUygulama.Data
{
    public class TotalMoney
    {
        public int Id { get; set; }

        public double Amount { get; set; }

        public Donem Donem { get; set; } = null!;

    }
}
