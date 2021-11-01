using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaEscalaExtra.Modelo
{
  public class Enfermeira : PessoaPlantao
  {    
    public Enfermeira()
    {
      
    }

    public override int CalcularNecessidadeDePlantao(decimal qtde, int minProfissionalPlantao, decimal totalPacientes)
    {
      
      int count = 0;      

      if (qtde < minProfissionalPlantao)
      {
        do
        {          
          count++;
          qtde += count;
        } while (qtde < minProfissionalPlantao);
      }

      return count;
    }

    public override string RetornaMensagemAposCalculo(int totalProfissionalExtra, int minProfissional)
    {
      if (totalProfissionalExtra > 0)
        return Properties.Resources.MessageNessesitaExtra;
      else
        return Properties.Resources.MessageNaoNessesitaExtra;
    }
  }
}
