﻿#pragma checksum "..\..\..\WPF\Postal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47A1AEA7DBFFEF3C805ACF699267B8A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Ejer3Git {
    
    
    /// <summary>
    /// Postal
    /// </summary>
    public partial class Postal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasTop;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelNoel;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridBottom;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button animacionButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confiButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridCenter;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas primerArbol;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas segundoArbol;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\..\WPF\Postal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas tercerArbol;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Ejer3Git;component/wpf/postal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WPF\Postal.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\WPF\Postal.xaml"
            ((Ejer3Git.Postal)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.canvasTop = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.labelNoel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.gridBottom = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.animacionButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\WPF\Postal.xaml"
            this.animacionButton.Click += new System.Windows.RoutedEventHandler(this.animacionButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.confiButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\WPF\Postal.xaml"
            this.confiButton.Click += new System.Windows.RoutedEventHandler(this.confiButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\WPF\Postal.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.okButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.gridCenter = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.primerArbol = ((System.Windows.Controls.Canvas)(target));
            return;
            case 10:
            this.segundoArbol = ((System.Windows.Controls.Canvas)(target));
            return;
            case 11:
            this.tercerArbol = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

