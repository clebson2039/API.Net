using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Services
{
    public interface IJogoService
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<List<JogoViewModel>> Obter(Guid id);
        Task<List<JogoViewModel>> Inserir(JogoImputModel jogo);
        Task Atualizar(Guid id, JogoImputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}