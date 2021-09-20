using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.ImputModel
{
    public class JogoImputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErroMessage = "O nome do jogo deve conter entre 3 e 100 caracteres")]
        public string Nome {get; set;}
        [Required]
        [StringLength(100, MinimumLength = 3, ErroMessage = "O nome da produtora deve conter entre 3 e 100 caracteres")]
        public string Produtora {get; set;}
        [Required]
        [Range(1, 100, ErroMessage = "O preco deve ser de no mínimo 1 real e no máximo 1000reais")]
        public double preco {get; set;}
    }
}