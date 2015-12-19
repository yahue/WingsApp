using Foundation;
using WingsAW.iOS;
using System;
using UIKit;
using Xamarin.Forms;


[assembly: Dependency(typeof(PhoneDialer))]
namespace WingsAW.iOS
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}
