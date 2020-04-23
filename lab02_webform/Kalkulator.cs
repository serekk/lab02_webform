using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab02_webform
{
    public class Kalkulator
    {
        public int a;
        public int b;
        public string op;

        public Kalkulator()
        {
        }

        public Kalkulator(int a, int b, string op)
        {
            this.a = a;
            this.b = b;
            this.op = op ?? throw new ArgumentNullException(nameof(op));
        }
    }
}