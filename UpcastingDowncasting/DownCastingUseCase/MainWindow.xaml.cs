using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DownCastingUseCase
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      //The sender object inside click method shows limited option

      //sender.

      //In order to see all option from sender object a down casting is required.
      
      //down casting explicit cast
      //var button = (Button)sender;

      //down casting using as keyword
      var button = sender as Button;
      //button.
      if(button != null)
      {
        MessageBox.Show(button.ActualHeight.ToString());
      }
      MessageBox.Show("Hello Haj Mahdi..!!");
    }
  }
}
