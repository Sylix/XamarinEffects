using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomizingXamarinForms.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(iOSReturnKeyEffect), "ReturnKeyEffect")]
namespace CustomizingXamarinForms.iOS
{
    public class iOSReturnKeyEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var effect = (App1.Effects.ReturnKeyEffect)Element.Effects.FirstOrDefault(e => e is App1.Effects.ReturnKeyEffect);
                if (effect != null)
                {
                    if (effect.ReturnText == "Done")
                        (Control as UITextField).ReturnKeyType = UIReturnKeyType.Done;
                    if (effect.ReturnText == "Next")
                        (Control as UITextField).ReturnKeyType = UIReturnKeyType.Next;
                }
            }
            catch
            {
                Console.WriteLine("Algum erro com iOSReturnKeyEffect" );
            }
        }

        protected override void OnDetached()
        {
        }
    }
}