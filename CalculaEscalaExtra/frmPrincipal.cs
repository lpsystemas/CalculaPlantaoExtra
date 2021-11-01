using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculaEscalaExtra.Modelo;
using static CalculaEscalaExtra.Modelo.Enumerado.Enumerados;

namespace CalculaEscalaExtra
{
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      SetaValoresComoZero();
      LimpaMenssagem();

      txtQtdTecnicos.Enabled = false;
      txtfolgasTec.Enabled = false;
      txtfaltaAtestadoTec.Enabled = false;
      txtMinTecnicos.Enabled = false;       
    }

    private void btnCalcularExtra_Click(object sender, EventArgs e)
    {
      int totalEnfTecExtra;

      if (rbEnfermeiras.Checked == true)
      {
        Enfermeira enf = new Enfermeira();
        totalEnfTecExtra = enf.CalcularNecessidadeDePlantao(Convert.ToInt32(txtQtdEnfermeiras.Text),
                                                            Convert.ToInt32(txtMinEnfermeira.Text),
                                                            Convert.ToInt32(txtQtdPacientes.Text));

        AlteraCorDaMensagem(totalEnfTecExtra);

        lblMensagem.Text = enf.RetornaMensagemAposCalculo(totalEnfTecExtra, Convert.ToInt32(txtMinEnfermeira.Text));
        txtTotalExtraEnf.Text = Convert.ToString(totalEnfTecExtra);
      }
      else 
      {
        Tecnicos tec = new Tecnicos();
        totalEnfTecExtra = tec.CalcularNecessidadeDePlantao(Convert.ToInt32(txtQtdTecnicos.Text),
                                                            Convert.ToInt32(txtMinTecnicos.Text),
                                                            Convert.ToInt32(txtQtdPacientes.Text));

        AlteraCorDaMensagem(totalEnfTecExtra);  

        lblMensagem.Text = tec.RetornaMensagemAposCalculo(totalEnfTecExtra, Convert.ToInt32(txtMinTecnicos.Text));
        txtTotalExtraTec.Text = Convert.ToString(totalEnfTecExtra);
      }      
    }

    private void rbTecnicas_CheckedChanged(object sender, EventArgs e)
    {
      if(rbTecnicas.Checked == true) 
      {
        txtQtdEnfermeiras.Enabled = false;
        txtfolgasEnf.Enabled = false;
        txtfaltaAtestadoEnf.Enabled = false;
        txtMinEnfermeira.Enabled = false;

        txtQtdTecnicos.Enabled = true;
        txtfolgasTec.Enabled = true;
        txtfaltaAtestadoTec.Enabled = true;
        txtMinTecnicos.Enabled = true;

        SetaValoresComoZero();
        LimpaMenssagem();
      }
    }

    private void rbEnfermeiras_CheckedChanged(object sender, EventArgs e)
    {
      if (rbEnfermeiras.Checked == true)
      {
        txtQtdTecnicos.Enabled = false;
        txtfolgasTec.Enabled = false;
        txtfaltaAtestadoTec.Enabled = false;
        txtMinTecnicos.Enabled = false;

        txtQtdEnfermeiras.Enabled = true;
        txtfolgasEnf.Enabled = true;
        txtfaltaAtestadoEnf.Enabled = true;
        txtMinEnfermeira.Enabled = true;

        SetaValoresComoZero();
        LimpaMenssagem();
      }
    }

    #region Funções Auxiliares

    public void SetaValoresComoZero()
    {
      txtQtdEnfermeiras.Text = "0";
      txtQtdTecnicos.Text = "0";
      txtQtdPacientes.Text = "0";
      txtfaltaAtestadoEnf.Text = "0";
      txtfolgasEnf.Text = "0";
      txtfaltaAtestadoTec.Text = "0";
      txtfolgasTec.Text = "0";
      txtTotalExtraEnf.Text = "0";
      txtTotalExtraTec.Text = "0";
    }

    public void LimpaMenssagem()
    {
      lblMensagem.Text = string.Empty;
    }

    public void AlteraCorDaMensagem(int total)
    {
      if (total > 0)
      {
        lblMensagem.ForeColor = Color.Red;
        txtTotalExtraEnf.ForeColor = Color.Red;
      }
      else
      {
        lblMensagem.ForeColor = Color.Black;
        txtTotalExtraEnf.ForeColor = Color.Black;
      }
    }
    #endregion

    private void btnImprimir_Click(object sender, EventArgs e)
    {
      string profissional =  rbEnfermeiras.Checked == true ? 
                             Enum.GetName(typeof(TipoProfissional), TipoProfissional.Enfermeiro) : 
                             Enum.GetName(typeof(TipoProfissional), TipoProfissional.Técnico);

      DateTime dataDoDia = DateTime.Now;

      string qtdePacientes = txtQtdPacientes.Text;
      string qtdeFuncionarios = rbEnfermeiras.Checked == true ? 
                                txtQtdEnfermeiras.Text : 
                                txtQtdTecnicos.Text;

      string faltaAtestado = rbEnfermeiras.Checked == true ? 
                             txtfaltaAtestadoEnf.Text : 
                             txtfaltaAtestadoTec.Text;
      
      string folgas = rbEnfermeiras.Checked == true ? 
                      txtfolgasEnf.Text : 
                      txtfolgasTec.Text;

      string totalExtra = rbEnfermeiras.Checked == true ? 
                          txtTotalExtraEnf.Text : 
                          txtTotalExtraTec.Text;

      string textoCalculo = lblMensagem.Text;

      frmRelatorioPlantoes frmRelatorio = new frmRelatorioPlantoes(profissional, dataDoDia, qtdePacientes, qtdeFuncionarios, faltaAtestado, folgas, 
                                                                   totalExtra, textoCalculo);
      frmRelatorio.ShowDialog();
    }
  }
}
