using Xamarin.Forms.Maps;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace mapsIntegration.ViewModels
{
    public class mapsIntegrationViewModel : BaseViewModel
    {

        #region Buttons
        public Command SateliteCommand { get; }
        public Command RuaCommand { get; }
        public Command HibridoCommand { get; }
        #endregion

        #region Variables
        private MapType _type;
        public MapType Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }
        #endregion

        public mapsIntegrationViewModel()
        {
            SateliteCommand = new Command(ExecuteSateliteCommand);
            RuaCommand = new Command(ExecuteRuaCommand);
            HibridoCommand = new Command(ExecuteHibridoCommand);
            Type = MapType.Street;

            //double lat = -23.5329467;
            //double longi = -46.53525352;
            //var pin = new Pin();
            //pin.Address = "abc";
            //pin.Label = "Test Pin 1";
            //pin.Type = PinType.SavedPin;
            //pin.Position = new Position(lat, longi);

            //map.Pins.Add(pin);
            //map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(lat, longi), Distance.FromKilometers(1)));
        }

        private void ExecuteHibridoCommand(object obj)
        {
            Type = MapType.Hybrid;
        }

        private void ExecuteRuaCommand(object obj)
        {
            Type = MapType.Street;
        }

        private void ExecuteSateliteCommand(object obj)
        {
            Type = MapType.Satellite;
        }
    }
}
