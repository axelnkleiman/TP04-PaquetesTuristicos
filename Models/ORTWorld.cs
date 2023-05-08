class ORTWorld
{
    public static List<string> ListaDestinos{get;private set;} = new List<string>{"MIAMI", "TORONTO", "MISIONES", "DUBAI", "BEIJUNG", "TOKIO", "BRASILIA", "MEDELLIN", "CARACAS", "SUCRE"};
    public static List<string> ListaHoteles{get;private set;} = new List<string>{"BECHER", "REIFUT", "YUZE", "HUEVO", "IVO", "AXEL", "PARGA", "ZOBER", "MATA", "ZORRO"};
    public static List<string> ListaAereo{get; private set;} = new List<string>{"RIQUELME", "MARADONA", "PALERMO", "GUILLERMO", "BIANCHI", "TEVEZ", "BATTAGLIA", "IBARRA", "GATTI", "MOUZO"};
    public static List<string> ListaExcursiones{get; private set;} = new List<string>{"BOCA", "RIVER", "INDEPENDIENTE", "RACING", "SAN LORENZO", "ESTUDIANTES", "VELEZ", "NEWELLS", "ROSARIO", "ARGENTINOS"};
    public static Dictionary<string, Paquete> Paquetes{get; private set;}
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
