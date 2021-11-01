
namespace CalculaEscalaExtra
{
  partial class frmRelatorioPlantoes
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.reportViewerPlantaoExtra = new Microsoft.Reporting.WinForms.ReportViewer();
      this.SuspendLayout();
      // 
      // reportViewerPlantaoExtra
      // 
      this.reportViewerPlantaoExtra.Dock = System.Windows.Forms.DockStyle.Fill;
      this.reportViewerPlantaoExtra.DocumentMapWidth = 36;
      this.reportViewerPlantaoExtra.LocalReport.ReportEmbeddedResource = "CalculaEscalaExtra.RelatorioPlantaoExtra.rdlc";
      this.reportViewerPlantaoExtra.Location = new System.Drawing.Point(0, 0);
      this.reportViewerPlantaoExtra.Name = "reportViewerPlantaoExtra";
      this.reportViewerPlantaoExtra.ServerReport.BearerToken = null;
      this.reportViewerPlantaoExtra.Size = new System.Drawing.Size(800, 450);
      this.reportViewerPlantaoExtra.TabIndex = 0;
      // 
      // frmRelatorioPlantoes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.reportViewerPlantaoExtra);
      this.Name = "frmRelatorioPlantoes";
      this.Text = "Relatório Plantões Extras";
      this.Load += new System.EventHandler(this.relatorioPlantoes_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewerPlantaoExtra;
  }
}