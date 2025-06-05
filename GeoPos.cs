namespace Hermes;

public class GeoPos
{
	private decimal Lng;

	private decimal Lat;

	public decimal Latitude
	{
		get
		{
			return Lat;
		}
		set
		{
			Lat = value;
		}
	}

	public decimal Longitude
	{
		get
		{
			return Lng;
		}
		set
		{
			Lng = value;
		}
	}
}
