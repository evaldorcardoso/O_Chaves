using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace AppChaves
{
    public class clsTemporadas
    {
        public string source { get; set; }
        public string nome { get; set; }
        public string numVideos { get; set; }
        public string cor { get; set; }

        public clsTemporadas(string sourceTemp, string nomeTemp, string numVideosTemp, string corTemp)
        {
            this.source = sourceTemp;
            this.nome = nomeTemp;
            this.numVideos = numVideosTemp;
            this.cor = corTemp;
        }

        public clsTemporadas()
        {

        }
    }
}
