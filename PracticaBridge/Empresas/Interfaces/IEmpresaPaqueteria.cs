using PracticaBridge.Transportes.Interfaces;
using System.Collections.Generic;

namespace PracticaBridge.Empresas.Interfaces
{
    public interface IEmpresaPaqueteria
    {
        string Nombre { get; }
        List<IMedioTransporte> TransportesDisponibles { get; set; }

        void Informacion();
        void RecogerPedido();
        void EnviarPedido();
        void EntregarPedido();



    }
}
