﻿#pragma checksum "..\..\..\Content\ListDevolucion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1A813C36CE547E0F6FC5B5BE0A4D0C62"
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
    /// ListDevolucion
    /// </summary>
    public partial class ListDevolucion : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Content\ListDevolucion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listDevolucion;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Content\ListDevolucion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdEmpleadoBusqueda;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Content\ListDevolucion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdArticuloBusqueda;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Content\ListDevolucion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidadBusqueda;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Content\ListDevolucion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNotaBusqueda;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Content\ListDevolucion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFechaBusqueda;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Content\ListDevolucion.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WarehouseManager;component/content/listdevolucion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Content\ListDevolucion.xaml"
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
            this.listDevolucion = ((System.Windows.Controls.ListView)(target));
            
            #line 38 "..\..\..\Content\ListDevolucion.xaml"
            this.listDevolucion.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listDevolucion_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 43 "..\..\..\Content\ListDevolucion.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headIdEmpleado);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtIdEmpleadoBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\Content\ListDevolucion.xaml"
            this.txtIdEmpleadoBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 50 "..\..\..\Content\ListDevolucion.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headIdArticulo);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtIdArticuloBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\Content\ListDevolucion.xaml"
            this.txtIdArticuloBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 57 "..\..\..\Content\ListDevolucion.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headCantidad);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtCantidadBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\..\Content\ListDevolucion.xaml"
            this.txtCantidadBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 64 "..\..\..\Content\ListDevolucion.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headNota);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtNotaBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\Content\ListDevolucion.xaml"
            this.txtNotaBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 71 "..\..\..\Content\ListDevolucion.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headFecha);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtFechaBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\Content\ListDevolucion.xaml"
            this.txtFechaBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnUpdate = ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target));
            
            #line 100 "..\..\..\Content\ListDevolucion.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
