using Xamarin.Forms; using Xamarin.Forms.Maps; using mapsIntegration.ViewModels;  namespace mapsIntegration.Views {     public partial class mapsIntegrationPage : ContentPage     {         public mapsIntegrationPage()         {
            double lat = -23.5329467;
            double longi = -46.53525352;

            InitializeComponent();             BindingContext = new mapsIntegrationViewModel();

            var pin = new Pin();
            pin.Address = "abc";
            pin.Label = "Test Pin 1";
            pin.Type = PinType.SavedPin;
            pin.Position = new Position(lat, longi);

            var pin2 = new Pin();
            pin2.Address = "def";
            pin2.Label = "Test Pin 2";
            pin2.Type = PinType.SavedPin;
            pin2.Position = new Position(-23.53546484, -46.52555466);

            var pin3 = new Pin();
            pin3.Address = "ghi";
            pin3.Label = "Test Pin 3";
            pin3.Type = PinType.SavedPin;
            pin3.Position = new Position(-23.53215979, -46.53023243);

            MyMap.Pins.Add(pin);
            MyMap.Pins.Add(pin2);
            MyMap.Pins.Add(pin3);

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(lat, longi), Distance.FromKilometers(1)));
        }     } }  