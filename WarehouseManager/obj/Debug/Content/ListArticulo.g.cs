﻿#pragma checksum "..\..\..\Content\ListArticulo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1128B9DF1BDEEA2E4CAF31A44D2E24A4"
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
    /// ListArticulo
    /// </summary>
    public partial class ListArticulo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Content\ListArticulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrllView;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Content\ListArticulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listArticulo;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Content\ListArticulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreBusqueda;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Content\ListArticulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcionBusqueda;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Content\ListArticulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioBusqueda;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Content\ListArticulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidadBusqueda;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Content\ListArticulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUnidadBusqueda;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Content\ListArticulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FirstFloor.ModernUI.Windows.Controls.ModernButton btnReport;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Content\ListArticulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FirstFloor.ModernUI.Windows.Controls.ModernButton btnUpdate;
        
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
            System.Uri resourceLocater = new System.Uri("/WarehouseManager;component/content/listarticulo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Content\ListArticulo.xaml"
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
            
            #line 25 "..\..\..\Content\ListArticulo.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.Grid_MouseWheel_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scrllView = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 3:
            this.listArticulo = ((System.Windows.Controls.ListView)(target));
            
            #line 38 "..\..\..\Content\ListArticulo.xaml"
            this.listArticulo.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listArticulo_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\Content\ListArticulo.xaml"
            this.listArticulo.KeyUp += new System.Windows.Input.KeyEventHandler(this.listArticulo_KeyUp);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\Content\ListArticulo.xaml"
            this.listArticulo.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.listArticulo_MouseWheel);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 43 "..\..\..\Content\ListArticulo.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headNombre);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtNombreBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\Content\ListArticulo.xaml"
            this.txtNombreBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 51 "..\..\..\Content\ListArticulo.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headDescripcion);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtDescripcionBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\Content\ListArticulo.xaml"
            this.txtDescripcionBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 59 "..\..\..\Content\ListArticulo.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headPrecio);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtPrecioBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\..\Content\ListArticulo.xaml"
            this.txtPrecioBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 67 "..\..\..\Content\ListArticulo.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headCantidad);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtCantidadBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\Content\ListArticulo.xaml"
            this.txtCantidadBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 75 "..\..\..\Content\ListArticulo.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headUnidad);
            
            #line default
            #line hidden
            return;
            case 13:
            this.txtUnidadBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\..\Content\ListArticulo.xaml"
            this.txtUnidadBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btnReport = ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target));
            
            #line 105 "..\..\..\Content\ListArticulo.xaml"
            this.btnReport.Click += new System.Windows.RoutedEventHandler(this.btnReport_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btnUpdate = ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target));
            
            #line 113 "..\..\..\Content\ListArticulo.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

