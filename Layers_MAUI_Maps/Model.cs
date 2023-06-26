namespace Layers_MAUI_Maps
{
	public class Model
	{
		public double Value { get; set; }
		public string Country { get; set; }
		public double Population { get; set; }
		public double DensityCount { get; set; }
		public string DensityLevel { get; set; }
		public Color Color { get; set; }
		public Model(double value, string country, double population, double densityCount, string densityLevel, Color color)
		{
			Value = value;
			Country = country;
			Population = population;
			DensityCount = densityCount;
			DensityLevel = densityLevel;
			Color = color;
		}
	}
}
