#pragma checksum "G:\Download SL3\Projects\chapter9\chapter9\Animation3D.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "88862EDEA16D2B963965F4E1881D3E11"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace chapter9 {
    
    
    public partial class Animation3D : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Media.Animation.Storyboard Rotate;
        
        internal System.Windows.Controls.Image image1;
        
        internal System.Windows.Media.PlaneProjection p1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/chapter9;component/Animation3D.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Rotate = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Rotate")));
            this.image1 = ((System.Windows.Controls.Image)(this.FindName("image1")));
            this.p1 = ((System.Windows.Media.PlaneProjection)(this.FindName("p1")));
        }
    }
}
