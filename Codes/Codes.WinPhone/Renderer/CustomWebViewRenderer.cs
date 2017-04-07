using Codes.CustomControl;
using Codes.WinPhone.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms.Platform.WinRT;
using Xamarin.Forms;
using System.Net;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace Codes.WinPhone.Renderer
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomWebView;
                Control.Source = new Uri(string.Format("ms-appx-web:///Assets/pdfjs/web/viewer.html?file={0}", string.Format("ms-appx-web:///Assets/Content/{0}", WebUtility.UrlEncode(customWebView.Uri))));
            }
        }
    }
}