using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using MyToolkit.Multimedia;
using MyToolkit;

namespace AppChaves
{
    public partial class principalPage : PhoneApplicationPage
    {
        public principalPage()
        {
            InitializeComponent();
            carregaTemporadas();
            carregaFrases();
        }

        private void carregaTemporadas()
        {
            clsTemporadas objTemporadas = new clsTemporadas();
            List<clsTemporadas> listaDeTemporadas = new List<clsTemporadas>();
            listaDeTemporadas.Add(new clsTemporadas("Images/1.png","1ª Temporada","26 episódios","LightBlue"));
            listaDeTemporadas.Add(new clsTemporadas("Images/2.png", "2ª Temporada", "26 episódios", "Orange"));
            listaDeTemporadas.Add(new clsTemporadas("Images/3.png", "3ª Temporada", "26 episódios", "Red"));
            listaDeTemporadas.Add(new clsTemporadas("Images/4.png", "4ª Temporada", "22 episódios + 1 Especial", "LightBlue"));
            listaDeTemporadas.Add(new clsTemporadas("Images/5.png", "5ª Temporada", "13 episódios", "LightBlue"));
            lstVideos.ItemsSource = listaDeTemporadas;
        }

        private void carregaFrases()
        {
            clsFrases objFrases = new clsFrases();
            List<clsFrases> listaDeFrases = new List<clsFrases>();
            listaDeFrases.Add(new clsFrases("1", "Cale-se, cale-se..", "Images/quico.png", "Blue"));
            listaDeFrases.Add(new clsFrases("2", "Você não vai com a minha cara?", "Images/quico.png", "Blue"));
            listaDeFrases.Add(new clsFrases("3", "Isso isso isso", "Images/chaves.png", "Blue"));
            listaDeFrases.Add(new clsFrases("4", "Olha ele hein", "Images/nhonho2.png", "Green"));
            listaDeFrases.Add(new clsFrases("5", "Que coisa, não?", "Images/quico.png", "Blue"));
            listaDeFrases.Add(new clsFrases("6", "Tá tá tá tá...", "Images/girafales.png", "Red"));
            listaDeFrases.Add(new clsFrases("7", "Tinha que ser o Chaves..", "Images/barriga.png", "Green"));
            listaDeFrases.Add(new clsFrases("8", "Vamos tesouro, não se misture...", "Images/florinda2.png", "Blue"));
            listaDeFrases.Add(new clsFrases("9", "Ninguém tem paciência comigo", "Images/chaves.png", "Blue"));
            lstFrases.ItemsSource = listaDeFrases;
        }

        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string temporada = (string)((Grid)sender).Tag.ToString();
            string destino = "/Page1.xaml?temporada="+temporada;
            this.NavigationService.Navigate(new Uri(destino, UriKind.Relative));
        }

        private void Grid_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            YouTube.Play("kBi_uyZvlYo", true, YouTubeQuality.Quality480P, x =>
            {
                if (x != null)
                    MessageBox.Show(x.Message);
            });
        }
		
		private void playFrase(string id)
		{
			switch (id)
			{
				case "1":
				{
                    mediaElementFrases.Source = (new Uri("sounds/cale-secale-sevcmedeixalouco.wav",UriKind.Relative));
                    mediaElementFrases.Play();
                    
				}break;
                case "2":
                    {
                        mediaElementFrases.Source = (new Uri("sounds/vcnaovaicomaminhacara.wav",UriKind.Relative));
                        mediaElementFrases.Play();
                    } break;
                case "3":
                    {
                        mediaElementFrases.Source = (new Uri("sounds/issoissoisso.wav",UriKind.Relative));
                        mediaElementFrases.Play();
                    } break;
                case "4":
                    {
                        mediaElementFrases.Source = (new Uri("sounds/olhaelehein.wav",UriKind.Relative));
                        mediaElementFrases.Play();
                    } break;
                case "5":
                    {
                        mediaElementFrases.Source = (new Uri("sounds/quecoisanao.wav",UriKind.Relative));
                        mediaElementFrases.Play();
                    } break;
                case "6":
                    {
                        mediaElementFrases.Source = (new Uri("sounds/tatatata.wav",UriKind.Relative));
                        mediaElementFrases.Play();
                    } break;
                case "7":
                    {
                        mediaElementFrases.Source = (new Uri("sounds/tinhaqserochaves.wav",UriKind.Relative));
                        mediaElementFrases.Play();
                    } break;
                case "8":
                    {
                        mediaElementFrases.Source = (new Uri("sounds/vamostesouronaosemisture.wav",UriKind.Relative));
                        mediaElementFrases.Play();
                    } break;
                case "9":
                    {
                        mediaElementFrases.Source = (new Uri("sounds/ningeumtempacienciacomigo.wav", UriKind.Relative));
                        mediaElementFrases.Play();
                    } break;
				
				default:
					break;
			}
		}

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
			string id = (string)((Image)sender).Tag.ToString();
        	// TODO: Add event handler implementation here.
			playFrase(id);
        }

        //ao apertar a tecla voltar
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Sair do aplicativo?", "Sair", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    while (NavigationService.CanGoBack)
                    {
                        NavigationService.RemoveBackEntry();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
                base.OnBackKeyPress(e);
            }
            catch (Exception)
            {
            }

        }
    }
}