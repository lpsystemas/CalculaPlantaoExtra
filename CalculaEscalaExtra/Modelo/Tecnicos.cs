using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaEscalaExtra.Modelo
{
  public class Tecnicos : PessoaPlantao
  { 
    public Tecnicos()
    {
             
    }    

    public override int CalcularNecessidadeDePlantao(decimal qtdeProfissionalPlantao, int minProfissionalPlantao, decimal totalPacientes)
    {
      decimal totalPacientesporTecnico;
      int count = 0; 
  
      do
      {
        totalPacientesporTecnico = Math.Ceiling(totalPacientes / qtdeProfissionalPlantao);
        
        if(totalPacientesporTecnico > minProfissionalPlantao)
        {
          count++;
          qtdeProfissionalPlantao += 1;
        }        
      } while (totalPacientesporTecnico > minProfissionalPlantao);     

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
