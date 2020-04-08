namespace ReportViewerCreateDocument {
  partial class XtraReport1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // TopMargin
      // 
      this.TopMargin.Name = "TopMargin";
      // 
      // BottomMargin
      // 
      this.BottomMargin.Name = "BottomMargin";
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
      this.Detail.HeightF = 43.64285F;
      this.Detail.Name = "Detail";
      // 
      // ReportHeader
      // 
      this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
      this.ReportHeader.Name = "ReportHeader";
      // 
      // xrLabel1
      // 
      this.xrLabel1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(22.61905F, 21.83333F);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
      this.xrLabel1.SizeF = new System.Drawing.SizeF(442.8571F, 68.16668F);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "Test Report";
      // 
      // xrLabel2
      // 
      this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(22.61905F, 20.64285F);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
      this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
      this.xrLabel2.Text = "Name: [Name]";
      // 
      // XtraReport1
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader});
      this.Font = new System.Drawing.Font("Arial", 9.75F);
      this.Version = "20.1";
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
  }
}
