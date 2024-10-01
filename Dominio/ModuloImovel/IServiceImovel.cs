using Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloCorretor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloImovel
{
	public interface IServiceImovel
	{
		void CriarImovel(Imovel imovel);
		List<Imovel> TragaTodosImoveis();
		void SalvarImovel(Imovel imovel);
		Corretor TragaImovelPorId(int id);
		void Remover(int id);

	}
}
