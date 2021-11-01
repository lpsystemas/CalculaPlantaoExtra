using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaEscalaExtra
{
  public partial class frmRelatorioPlantoes : Form
  {
    public frmRelatorioPlantoes(string profissional, DateTime dataDia, string qtdePacientes,
                                string qtdeFunc, string faltaAtestado, string folgas, 
                                string totalExtra, string textoTotal)
    {
      InitializeComponent();

      reportViewerPlantaoExtra.LocalReport.DataSources.Clear();
      reportViewerPlantaoExtra.LocalReport.ReportEmbeddedResource = "CalculaEscalaExtra.RelatorioPlantaoExtra.rdlc";

      ReportParameterCollection parametros = new ReportParameterCollection();

      parametros.Add(new ReportParameter("Profissional", profissional));
      parametros.Add(new ReportParameter("DataDoDia", Convert.ToString(dataDia)));      
      parametros.Add(new ReportParameter("QtdePacientes", qtdePacientes));
      parametros.Add(new ReportParameter("QtdeFunc", qtdeFunc));
      parametros.Add(new ReportParameter("FaltasAtestados", faltaAtestado));
      parametros.Add(new ReportParameter("Folgas", folgas));
      parametros.Add(new ReportParameter("TotalExtra", totalExtra));
      parametros.Add(new ReportParameter("TextoCalculo", textoTotal));

      reportViewerPlantaoExtra.LocalReport.SetParameters(parametros);
      reportViewerPlantaoExtra.LocalReport.Refresh();
      reportViewerPlantaoExtra.RefreshReport();
    }

    private void relatorioPlantoes_Load(object sender, EventArgs e)
    {
      this.reportViewerPlantaoExtra.RefreshReport();
    }
  }
}
