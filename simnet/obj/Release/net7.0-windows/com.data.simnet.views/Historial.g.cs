﻿#pragma checksum "..\..\..\..\com.data.simnet.views\Historial.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56DD372F1B2F200F436E5DCFB5F89EDA34F86666"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using simnet.com.data.simnet.views;


namespace simnet.com.data.simnet.views {
    
    
    /// <summary>
    /// Historial
    /// </summary>
    public partial class Historial : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\com.data.simnet.views\Historial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_Signos_oximetria_titulo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\com.data.simnet.views\Historial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label documento;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\com.data.simnet.views\Historial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nombre;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\com.data.simnet.views\Historial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_nombre;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\com.data.simnet.views\Historial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_documento;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\com.data.simnet.views\Historial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dta_grid_temp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\com.data.simnet.views\Historial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dta_grid_presion;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\com.data.simnet.views\Historial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dta_grid_oxy;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\com.data.simnet.views\Historial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button boton_salir;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.20.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/simnet;component/com.data.simnet.views/historial.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\com.data.simnet.views\Historial.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.20.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txt_Signos_oximetria_titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.documento = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.nombre = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txt_nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_documento = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dta_grid_temp = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.dta_grid_presion = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.dta_grid_oxy = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            
            #line 23 "..\..\..\..\com.data.simnet.views\Historial.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.boton_salir = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\com.data.simnet.views\Historial.xaml"
            this.boton_salir.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Salir);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

