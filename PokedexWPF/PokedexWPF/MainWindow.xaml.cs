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
using System.IO;
using PokeDexApp;

namespace PokedexWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PokedexLogin s;

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PlayButton(object sender, RoutedEventArgs e)
        {
            PlayWindow PlayWindow = new PlayWindow();
            PlayWindow.Show();
        }

        private void OnOffButton(object sender, RoutedEventArgs e)
        {

        }

        private void OnOffImage_Click(object sender, RoutedEventArgs e)
        {
            if (s.On == true)
            {
                MusicPlayer.Source = new Uri(@"C:\Users\mitch\Source\Repos\Pokedex\Songs");
                MusicPlayer.Play();
            }
        }
    }
}
