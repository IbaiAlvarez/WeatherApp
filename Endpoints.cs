namespace WeatherApp
{
    public class Endpoints
    {
        public static string GetGeoApofiEndpoint(string hiriIzena)
        {
            return $"https://api.geoapify.com/v1/geocode/search?text={hiriIzena}&format=json&apiKey={Config.GeApifyKey}";
            //return $"https://api.geoapify.com/v1/geocode/search?text=Bilbao&format=json&apiKey=YOUR_API_KEY\r\n";
        }

        public static string GetWeatherEndPoint(float lat, float lon)
        {
            return $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,weathercode,windspeed_10m,winddirection_10m&hourly=temperature_2m&daily=weathercode,apparent_temperature_max,apparent_temperature_min&timezone=Europe%2FBerlin";
        }
    }
}
