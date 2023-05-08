class ORTWorld
{
    public List<string> ListaDestinos{get;private set;}
    public List<string> ListaHoteles{get;private set;}
    public List<string> ListaAereo{get; private set;}
    public List<string> ListaExcursiones{get; private set;}
    public Dictionary<string, Paquete> Paquetes{get; private set;}
    public bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool verificar;
        verificar = Paquetes.ContainsKey(destinoSeleccionado);
        return verificar;
    }
}
