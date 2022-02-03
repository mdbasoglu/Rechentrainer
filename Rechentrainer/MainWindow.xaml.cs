using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Quiz;

namespace Rechentrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Multiplikationsquiz quiz = new Multiplikationsquiz();
        Stopwatch stoppuhr = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();
            lblFrage.Content = quiz.Frage;
        }

        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            Multiplikationsquiz quiz = new Multiplikationsquiz();
            lblFrage.Content = quiz.Frage;

            txtAntwort.Text = "";
            lblBewertung.Content = "";
            lblZeit.Content = "";
            stoppuhr.Start();
        }

        private void btnPruefen_Click(object sender, RoutedEventArgs e)
        {
            Multiplikationsquiz quiz = new Multiplikationsquiz();

            int eingabe = Convert.ToInt32(txtAntwort.Text);

            if (eingabe == quiz.Antwort)
            {
                lblBewertung.Content = "Das Ergebnis ist richtig.";
            }
            else
            {
                lblBewertung.Content = $"Das Ergebnis ist nicht richtig.\nRichtiges Ergebnis {quiz.Antwort}";
            }

            stoppuhr.Stop();
            lblZeit.Content = $"{stoppuhr.ElapsedMilliseconds/1000.0} s";
            stoppuhr.Reset();
        }
    }
}
