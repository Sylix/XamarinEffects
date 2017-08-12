using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Effects
{
    public class ReturnKeyEffect : RoutingEffect
    {
        public string ReturnText { get; set; }

        public ReturnKeyEffect() : base("Xamarin.ReturnKeyEffect")
        {
        }
    }
}