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
using System.ServiceModel;
using GeneratorSolowek.Contracts;

namespace GeneratorSolowek.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IList<int[]> chosenScale;

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i <= 24; i++)
            {
                cbMin.Items.Add(i);
                cbMax.Items.Add(i);
            }
        }

        private void dMajorBtn_Click(object sender, RoutedEventArgs e)
        {
            scaleLbl.Text = "D Dur";
            using (var c = new ChannelFactory<IFileGenerator>(""))
            {
                var fileGenerator = c.CreateChannel();
                chosenScale = fileGenerator.GetDMajorFrets();
            }
        }

        private void cMajorBtn_Click(object sender, RoutedEventArgs e)
        {
            scaleLbl.Text = "C Dur";
            using (var c = new ChannelFactory<IFileGenerator>(""))
            {
                var fileGenerator = c.CreateChannel();
                chosenScale = fileGenerator.GetCMajorFrets();
            }
        }

        private void aBluesBtn_Click(object sender, RoutedEventArgs e)
        {
            scaleLbl.Text = "A Blues";
            using (var c = new ChannelFactory<IFileGenerator>(""))
            {
                var fileGenerator = c.CreateChannel();
                chosenScale = fileGenerator.GetABluesFrets();
            }
        }

        private void clearBtnMin_Click(object sender, RoutedEventArgs e)
        {
            if (cbMin.SelectedItem != null)
            {
                cbMin.SelectedItem = null;
            }
        }

        private void clearBtnMax_Click(object sender, RoutedEventArgs e)
        {
            if (cbMax.SelectedItem != null)
            {
                cbMax.SelectedItem = null;
            }
        }
    }
}
