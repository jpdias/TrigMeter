﻿#pragma checksum "C:\Users\JP Dias\Documents\Visual Studio 2012\Projects\TrigMeter\TrigMeter\Solve.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CA641CE3CD321B0232A6BB265187A547"
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
    
    
    public partial class Solve : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox A;
        
        internal System.Windows.Controls.TextBox B;
        
        internal System.Windows.Controls.TextBox C;
        
        internal System.Windows.Controls.TextBlock R1;
        
        internal System.Windows.Controls.TextBlock R2;
        
        internal System.Windows.Controls.Button Clr;
        
        internal System.Windows.Controls.Button calc;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TrigMeter;component/Solve.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.A = ((System.Windows.Controls.TextBox)(this.FindName("A")));
            this.B = ((System.Windows.Controls.TextBox)(this.FindName("B")));
            this.C = ((System.Windows.Controls.TextBox)(this.FindName("C")));
            this.R1 = ((System.Windows.Controls.TextBlock)(this.FindName("R1")));
            this.R2 = ((System.Windows.Controls.TextBlock)(this.FindName("R2")));
            this.Clr = ((System.Windows.Controls.Button)(this.FindName("Clr")));
            this.calc = ((System.Windows.Controls.Button)(this.FindName("calc")));
        }
    }
}
