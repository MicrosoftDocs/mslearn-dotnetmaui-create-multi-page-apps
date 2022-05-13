namespace Astronomy
{
    public class LatLongService : ILatLongService
    {
        public async Task<(double Latitude, double Longitude)> GetLatLong()
        {
            var latLoc = 0.0;
            var longLoc = 0.0;

            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            if (status == PermissionStatus.Granted)
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromSeconds(10));
                var location = await Geolocation.GetLocationAsync(request);
                latLoc = location.Latitude;
                longLoc = location.Longitude;
            }
            return (latLoc, longLoc);
        }
    }
}