using GestaoLojaPediTiscos.Data;

namespace GestaoLojaPediTiscos.Entities;

public class Encomendas{


    public int Id { get; set; }

    public int? ClienteId { get; set; }
    public ApplicationUser Cliente { get; set; }

    public DateTime DataEncomenda { get; set; }

    public string? Estado { get; set; } //Processamento, Cancelado, Concluido

    public decimal? Total { get; set; }

}
