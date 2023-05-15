class ORTWorld
{
    public static List<string> ListaDestinos{get;private set;} = new List<string>{"MIAgiMI", "TORONTO", "MISIONES", "DUBAI", "BEIJING", "TOKIO", "BRASILIA", "MEDELLIN", "CARACAS", "SUCRE"};
    public static List<string> ListaHoteles{get;private set;} = new List<string>{"BECHER", "REIFUT", "YUZE", "HUEVO", "IVO", "AXEL", "PARGA", "ZOBER", "MATA", "ZORRO"};
    public static List<string> ListaAereo{get; private set;} = new List<string>{"emirates.png", "copa_air.jpg", "latam.png", "lufthansa.png", "air_china.png", "qatar.png", "aeromexico.jpeg", "aerolineas_argentinas.jpg", "british_airways.png", "american.png"};
    public static List<string> ListaExcursiones{get; private set;} = new List<string>{"BOCA", "RIVER", "INDEPENDIENTE", "RACING", "SAN LORENZO", "ESTUDIANTES", "VELEZ", "NEWELLS", "ROSARIO", "ARGENTINOS"};
    public static Dictionary<string, Paquete> Paquetes{get; private set;} = new Dictionary<string, Paquete>();
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool verificar;
        verificar = Paquetes.ContainsKey(destinoSeleccionado);
        if(verificar == false)
        {
            ListaDestinos.Add(destinoSeleccionado);
            Paquetes.Add(destinoSeleccionado, paquete);
        }
        return verificar;
    }
}
