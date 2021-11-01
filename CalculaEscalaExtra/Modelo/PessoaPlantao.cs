using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaEscalaExtra.Modelo
{
  public abstract class PessoaPlantao
  {
    public int Quantidade { get; set; }
    public int FaltaAtestado { get; set; }
    public int Folgas { get; set; }
    public int Tipo { get; set; }

    public abstract int CalcularNecessidadeDePlantao(decimal qtde, int minProfissionalPlantao, decimal totalPacientes);
    public abstract string RetornaMensagemAposCalculo(int totalProfissionalExtra, int minProfissional);
  }  
}
