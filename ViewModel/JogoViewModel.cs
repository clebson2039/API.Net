using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.ViewModel
{
    public class JogoViewModel
    {
        public Guid Id {get; set;}
        public Guid Nome {get; set;}
        public Guid Produtora {get; set;}
        public Guid preco {get; set;}
    }
}