﻿#pragma checksum "C:\Users\EvaldoRC\Documents\Visual Studio 2010\Projects\AppChaves\AppChaves\principalPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D9F2A2F58BA033A8A0B032E94AC8C97F"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.18052
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Advertising.Mobile.UI;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AppChaves {
    
    
    public partial class principalPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Advertising.Mobile.UI.AdControl OChaves;
        
        internal System.Windows.Controls.ListBox lstVideos;
        
        internal System.Windows.Controls.ListBox lstFrases;
        
        internal System.Windows.Controls.MediaElement mediaElementFrases;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppChaves;component/principalPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.OChaves = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("OChaves")));
            this.lstVideos = ((System.Windows.Controls.ListBox)(this.FindName("lstVideos")));
            this.lstFrases = ((System.Windows.Controls.ListBox)(this.FindName("lstFrases")));
            this.mediaElementFrases = ((System.Windows.Controls.MediaElement)(this.FindName("mediaElementFrases")));
        }
    }
}
