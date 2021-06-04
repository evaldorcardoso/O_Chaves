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
    public class clsFrases
    {
        public string id { get; set; }
        public string frase { get; set; }
        public string source { get; set; }
        public string cor { get; set; }

        public clsFrases(string idFra, string fraseFra, string sourceFra, string corFra)
        {
            this.id=idFra;
            this.frase=fraseFra;
            this.source=sourceFra;
            this.cor=corFra;
        }

        public clsFrases()
        {

        }
    }
}
