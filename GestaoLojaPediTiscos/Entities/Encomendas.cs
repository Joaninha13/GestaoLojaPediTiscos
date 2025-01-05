using GestaoLojaPediTiscos.Data;

namespace GestaoLojaPediTiscos.Entities;

public class Encomendas{


    public int Id { get; set; }

    public string? ClienteId { get; set; }
    public ApplicationUser Cliente { get; set; }

    public DateTime DataEncomenda { get; set; }

    public string? Estado { get; set; } //Processamento, Confirmado, Rejeitado, Concluido

    public decimal? Total { get; set; }

}
