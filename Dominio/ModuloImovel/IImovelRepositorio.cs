using Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloCorretor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloImovel
{
	public interface IImovelRepositorio
	{
		void CriarImovel(Imovel imovel);
		List<Imovel> TragaTodosImoveis();
		void SalvarCorretor(Imovel imovel);
		Imovel TragaImovelPorId(int? id);
		void Remover(int id);
		bool ImovelPorTipo(string tipo, int ImovelId);
		bool ImovelPorValor(string? valor, int ImovelId);
		bool ImovelPorDono(string dono, int ImovelId);
	}
}
