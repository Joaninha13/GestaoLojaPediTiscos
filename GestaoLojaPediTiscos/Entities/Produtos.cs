using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoLojaPediTiscos.Entities;

public class Produtos{

    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }

    public int? Stock { get; set; }

    public bool? Disponivel { get; set; }

    public int? SubCategoriaId { get; set; }
    public SubCategorias SubCategoria { get; set; }

    public int? ModoDispId { get; set; }
    public ModoDispo ModoDispo { get; set; }

    public int? PromocaoId { get; set; }
    public Promocoes Promocoes { get; set; }


    public string? UrlImagem { get; set; }
    public byte[]? Imagem { get; set; }

    [NotMapped]
    public IFormFile? ImageFile { get; set; }


}
