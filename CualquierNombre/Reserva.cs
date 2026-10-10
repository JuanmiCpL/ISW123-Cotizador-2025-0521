namespace CotizadorVillaCoral;

public class Reserva
{
    private const decimal TasaItbis = 0.18m;
    private const decimal TasaServicio = 0.10m;
    private const decimal TasaDescuento = 0.10m;
    private const decimal RecargoTemporadaAlta = 0.25m;
    private const int NochesParaDescuento = 7;
    private const decimal RecargoFinSemana = 0.15m;

    public string Huesped { get; set; } = "";
    public int Noches { get; set; }
    public decimal TarifaPorNoche { get; set; }
    public bool EsTemporadaAlta { get; set; }
    public bool EsFinDeSemana { get; set; }

    public decimal Subtotal => EsTemporadaAlta
    ? Noches * TarifaPorNoche * (1 + RecargoTemporadaAlta + (EsFinDeSemana ? RecargoFinSemana : 0m))
    : Noches * TarifaPorNoche * (1 + (EsFinDeSemana ? RecargoFinSemana : 0m));

    public decimal Descuento =>
        Noches >= NochesParaDescuento ? Subtotal * TasaDescuento : 0m;

    public decimal BaseImponible => Subtotal - Descuento;
    public decimal Itbis => BaseImponible * TasaItbis;
    public decimal Servicio => BaseImponible * TasaServicio;
    public decimal Total => BaseImponible + Itbis + Servicio;
}