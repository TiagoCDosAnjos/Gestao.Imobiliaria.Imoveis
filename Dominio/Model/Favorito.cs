﻿using Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloCliente;
using Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloImovel;

namespace Academia.Programador.Bk.Gestao.Imobiliaria.Web;

public partial class Favorito
{
    public int FavoritoId { get; set; }

    public int ClienteId { get; set; }

    public int ImovelId { get; set; }

    public DateOnly DataAdicionado { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual Imovel Imovel { get; set; } = null!;
}
