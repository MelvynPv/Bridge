using PracticaBridge.Empresas.Interfaces;
using PracticaBridge.Transportes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaBridge.Empresas
{
    public abstract class EmpresaPaqueteria : IEmpresaPaqueteria
    {
        public abstract string Nombre { get; }
        public List<IMedioTransporte> TransportesDisponibles { get; set; }

        public void EntregarPedido()
        {
            Console.WriteLine("Se entrego el envió por la empresa " + Nombre);
        }

        public void EnviarPedido()
        {
            Console.WriteLine("Se Envió el envió por la empresa " + Nombre);
        }

        public void Informacion()
        {
            Console.WriteLine(Nombre +" puede usar los medios de transporte siguiente: " + string.Join(',', TransportesDisponibles.Select(x => x.Nombre)));
        }

        public void RecogerPedido()
        {
            Console.WriteLine("Se Recogió el envió por la empresa " + Nombre);
        }
    }
}
