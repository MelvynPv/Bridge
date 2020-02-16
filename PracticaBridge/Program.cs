using ExamenPatrones.MediosTrasporte;
using PracticaBridge.Empresas;
using PracticaBridge.Empresas.Interfaces;
using PracticaBridge.Transportes.Interfaces;
using System;
using System.Collections.Generic;

namespace PracticaBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Barco barco = new Barco();
            Avion avion = new Avion();
            Tren tren = new Tren();

            DHL dhl = new DHL()
            {
                TransportesDisponibles = new List<IMedioTransporte>() { avion, barco }
            };

            Fedex fedex = new Fedex() 
            {
                TransportesDisponibles = new List<IMedioTransporte>() { barco }
            };

            Estafeta estafeta = new Estafeta() 
            {
                TransportesDisponibles = new List<IMedioTransporte>() { tren }
            };

            List<IEmpresaPaqueteria> empresaPaqueterias = new List<IEmpresaPaqueteria>() { 
                dhl,
                fedex,
                estafeta
            };

            foreach (IEmpresaPaqueteria empresa in empresaPaqueterias)
            {
                empresa.Informacion();
            }
        }
    }
}