namespace ApiTeste
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        //Teste Travado

        public string? Summary { get; set; }

        public bool? Enabled { get; set; }

        public string family { get; set; }
    }
}
