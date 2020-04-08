using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace ReportViewerCreateDocument {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void ThemedWindow_Loaded(object sender, RoutedEventArgs e) {
      var things = new List<Thing> { 
        new Thing{Name="Rubber chicken"}, 
        new Thing{Name="Pulley"}
      };
      var report = new XtraReport1();
      report.DataSource = things;
      previewer.DocumentSource = report;
      //report.CreateDocument(true);
    }
  }

  public class Thing {
    public string Name { get; set; }
  }
}
