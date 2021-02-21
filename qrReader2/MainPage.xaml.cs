using System;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace qrReader2
{
    public partial class qrReader2Page : ContentPage
    {
        public qrReader2Page()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            Navigation.PushAsync(scan);
            scan.OnScanResult += (result) =>
              {
                  Device.BeginInvokeOnMainThread(async () =>
                  {
                      await Navigation.PopAsync();
                      mycode.Text = result.Text;

                  });

              };
        }
    }

    }

