using Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloImovel;
using System.Drawing;

namespace Academia.Programador.Bk.Gestao.Imobiliaria.Web.Models;

public class ImovelViewModel
{
	
	public string Endereco { get; set; } = null!;

	public int Tipo { get; set; }

	public decimal Area { get; set; }

	public decimal Valor { get; set; }

	public string? Descricao { get; set; }

	public string? Fotos { get; set; }

}

public static class ImovelViewModelExtension
{
	public static ImovelViewModel ImovelToImovelViewModel(this Imovel imovel )
	{
		//Mapeamento
		return new ImovelViewModel()
		{
			Endereco = imovel.Endereco,
			Tipo = imovel.Tipo,
			Area = imovel.Area,
			Valor = imovel.Valor,
			Descricao = imovel.Descricao,
			Fotos = imovel.Fotos
		};
	}

	public static List<ImovelViewModel> ToImovelViewModel(this List<Imovel> imoveis)
	{
		var imoveisViewModel = new List<ImovelViewModel>();

		return imoveisViewModel;
	}

}