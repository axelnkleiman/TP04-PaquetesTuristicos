public class Paquete
{
    public string Destino { get; set; }
    public string Hotel { get; set; }
    public string Aereo { get; set; }
    public string Excursion { get; set; }

    public Paquete(string destino, string hotel, string aereo, string excursion)
    {
        Destino = destino;
        Hotel = hotel;
        Aereo = aereo;
        Excursion = excursion;
    }
}
