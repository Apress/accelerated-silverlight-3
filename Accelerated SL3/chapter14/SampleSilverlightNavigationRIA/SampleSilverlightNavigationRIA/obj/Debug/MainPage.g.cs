#pragma checksum "C:\book\examples\SampleSilverlightNavigationRIA\SampleSilverlightNavigationRIA\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9EB7206897264504A1E8FFFED0926FC3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
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


namespace SampleSilverlightNavigationRIA {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button InstallOOBButton;
        
        internal System.Windows.Controls.TextBlock NWStatus;
        
        internal System.Windows.Controls.TextBlock AppMode;
        
        internal System.Windows.Controls.Frame Frame;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SampleSilverlightNavigationRIA;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.InstallOOBButton = ((System.Windows.Controls.Button)(this.FindName("InstallOOBButton")));
            this.NWStatus = ((System.Windows.Controls.TextBlock)(this.FindName("NWStatus")));
            this.AppMode = ((System.Windows.Controls.TextBlock)(this.FindName("AppMode")));
            this.Frame = ((System.Windows.Controls.Frame)(this.FindName("Frame")));
        }
    }
}
