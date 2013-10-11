﻿#pragma checksum "..\..\..\Content\Entradas.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "271DB318FABA9ED95C63AD01451DDB01"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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


namespace WarehouseManager.Content {
    
    
    /// <summary>
    /// Entradas
    /// </summary>
    public partial class Entradas : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Content\Entradas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarEntrada;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Content\Entradas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminarEntrada;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Content\Entradas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listEntradaArticulo;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Content\Entradas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreBusqueda;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Content\Entradas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcionBusqueda;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Content\Entradas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioBusqueda;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Content\Entradas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidadBusqueda;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Content\Entradas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTotal;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Content\Entradas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listPendienteArticulo;
        
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
            System.Uri resourceLocater = new System.Uri("/WarehouseManager;component/content/entradas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Content\Entradas.xaml"
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
            this.btnAgregarEntrada = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Content\Entradas.xaml"
            this.btnAgregarEntrada.Click += new System.Windows.RoutedEventHandler(this.btnAgregarEntrada_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnEliminarEntrada = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Content\Entradas.xaml"
            this.btnEliminarEntrada.Click += new System.Windows.RoutedEventHandler(this.btnEliminarEntrada_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listEntradaArticulo = ((System.Windows.Controls.ListView)(target));
            
            #line 25 "..\..\..\Content\Entradas.xaml"
            this.listEntradaArticulo.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listEntrada_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 32 "..\..\..\Content\Entradas.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headNombre);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtNombreBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\Content\Entradas.xaml"
            this.txtNombreBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 40 "..\..\..\Content\Entradas.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headDescripcion);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtDescripcionBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\Content\Entradas.xaml"
            this.txtDescripcionBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 48 "..\..\..\Content\Entradas.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headPrecio);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtPrecioBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\Content\Entradas.xaml"
            this.txtPrecioBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 56 "..\..\..\Content\Entradas.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headCantidad);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtCantidadBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\Content\Entradas.xaml"
            this.txtCantidadBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.listPendienteArticulo = ((System.Windows.Controls.ListView)(target));
            
            #line 80 "..\..\..\Content\Entradas.xaml"
            this.listPendienteArticulo.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listPendiente_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 94 "..\..\..\Content\Entradas.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headDescripcion);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
