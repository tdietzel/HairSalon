namespace HairSalon.Models
{
  public class Client
  {
    public Stylist Stylist { get; set; }
    public int StylistId { get; set; }
    public int ClientId { get; set; }
    public string Name { get; set; }
  }
}