﻿#pragma checksum "C:\Users\JP Dias\documents\visual studio 2012\Projects\TrigMeter\TrigMeter\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E4AD2C7977559CF3DFB57E4E7A2F90A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.32559
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace TrigMeter {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox C;
        
        internal System.Windows.Controls.TextBox B;
        
        internal System.Windows.Controls.TextBox A;
        
        internal System.Windows.Controls.TextBlock C1;
        
        internal System.Windows.Controls.TextBlock C2;
        
        internal System.Windows.Controls.Canvas Draw;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TrigMeter;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.C = ((System.Windows.Controls.TextBox)(this.FindName("C")));
            this.B = ((System.Windows.Controls.TextBox)(this.FindName("B")));
            this.A = ((System.Windows.Controls.TextBox)(this.FindName("A")));
            this.C1 = ((System.Windows.Controls.TextBlock)(this.FindName("C1")));
            this.C2 = ((System.Windows.Controls.TextBlock)(this.FindName("C2")));
            this.Draw = ((System.Windows.Controls.Canvas)(this.FindName("Draw")));
        }
    }
}

