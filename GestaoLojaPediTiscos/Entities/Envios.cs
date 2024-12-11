namespace GestaoLojaPediTiscos.Entities;

public class Envios{

    public int Id { get; set; }
    public int EncomendaId { get; set; }
    public Encomendas Encomenda { get; set; }
    public DateTime DataEnvio { get; set; }

    public string? Estado { get; set; } //Enviado, Processamento, Entregue



}
