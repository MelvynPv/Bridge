using PracticaBridge.Transportes.Interfaces;

namespace PracticaBridge.Transportes
{
    public abstract class Transporte : IMedioTransporte
    {
        public abstract string Nombre { get; }
    }
}
