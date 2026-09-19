using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CualquierNombre
{
    public class Reserva
    {
        private const decimal TasaItbis = 0.18m;
        private const decimal TasaServicio = 0.10m;
        private const decimal TasaDescuento = 0.10m;
        private const decimal NochesParaDescuento = 7;
        private const decimal RecargoTemporadaAlta = 0.25m;
        public string Huesped { get; set; } = "";
        public int Noches { get; set; }
        public decimal tarifaPorNoche { get; set; }
        public bool EsTemporadaAlta { get; set; }
        public decimal SubTotal => EsTemporadaAlta 
            ? Noches * tarifaPorNoche * (1 + RecargoTemporadaAlta) 
            : Noches * tarifaPorNoche;
        public decimal Descuento =>
            Noches >= NochesParaDescuento ? SubTotal * TasaDescuento : 0m;
        public decimal BaseImponible => SubTotal - Descuento;
        public decimal Itbis => BaseImponible * TasaItbis;
        public decimal Servicio => BaseImponible * TasaServicio;
        public decimal Total => BaseImponible + Itbis + Servicio;

    }
}
