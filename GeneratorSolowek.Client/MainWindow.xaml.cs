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
using System.IO;
using System.ComponentModel;

namespace GeneratorSolowek.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IList<int[]> chosenScale;
        IList<string[]> fretboard;
        string[] previousLinesArray;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            Closing += MainWindow_Closing;
            for (int i = 1; i <= 24; i++)
            {
                cbMin.Items.Add(i);
                cbMax.Items.Add(i);
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            scaleLbl.Text = "D Dur";
            using (var c = new ChannelFactory<IFileGenerator>(""))
            {
                var fileGenerator = c.CreateChannel();
                chosenScale = fileGenerator.GetDMajorFrets();
            }
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            using (var c = new ChannelFactory<IFileGenerator>(""))
            {
                var fileGenerator = c.CreateChannel();
                File.Delete(fileGenerator.GetPath());
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

        private void generateBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var c = new ChannelFactory<IFileGenerator>(""))
            {
                var fileGenerator = c.CreateChannel();
                int min;
                int max;
                if (cbMin.SelectedItem != null)
                {
                    Int32.TryParse(cbMin.SelectedItem.ToString(), out min);
                    fileGenerator.SetMinFret(min);
                }

                if (cbMax.SelectedItem != null)
                {
                    Int32.TryParse(cbMax.SelectedItem.ToString(), out max);
                    fileGenerator.SetMaxFret(max);
                }

                if (fileGenerator.WrongFrets())
                {
                    MessageBox.Show("Niepoprawny zakres");
                    fileGenerator.SetMinFret(0);
                    fileGenerator.SetMaxFret(0);
                    return;
                }

                fileGenerator.SetNumberOfIterations(0);
                if(chosenScale != null)
                {
                    IList<Tuple<int,int>> pickedNotes = fileGenerator.PickNotes(chosenScale);
                    fretboard = fileGenerator.CreateEmptyTab();

                    fileGenerator.InsertPickedNotes(ref fretboard, pickedNotes, chosenScale);
                    fileGenerator.CreateFile(fretboard);

                    tabTextBox.Document.Blocks.Clear();
                    tabTextBox.AppendText(File.ReadAllText(fileGenerator.GetPath()));
                    //tabTextBox.ScrollToEnd();
                    tabTextBox.CaretPosition = tabTextBox.CaretPosition.DocumentEnd;
                }
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var c = new ChannelFactory<IFileGenerator>(""))
            {
                var fileGenerator = c.CreateChannel();
                if (File.Exists(fileGenerator.GetPath()))
                {
                    fileGenerator.IncrementNumberOfIterations();
                    string[] linesArray = fileGenerator.GetArrayFromFile();
                    previousLinesArray = linesArray;
                    IList<Tuple<int,int>> nextNotes = fileGenerator.PickNotes(chosenScale, linesArray);
                    fretboard = fileGenerator.CreateEmptyTab();

                    fileGenerator.InsertPickedNotes(ref fretboard, nextNotes, chosenScale);
                    fileGenerator.UpdateFile(linesArray, ref fretboard);
                    tabTextBox.Document.Blocks.Clear();
                    tabTextBox.AppendText(File.ReadAllText(fileGenerator.GetPath()));
                    //tabTextBox.ScrollToEnd();
                    tabTextBox.CaretPosition = tabTextBox.CaretPosition.DocumentEnd;
                }
            }
            tabTextBox.Document.PageWidth += 110;
        }
    }
}
