   M S B A M L   `   `   `  ����  WarehouseManager+    %WarehouseManager.Content.SingleSalida   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.3.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  5      .��5	      �    ContentRoot#��[  6     � ColumnDefinitions  5
   
   �� 5      $
��0.5* �6   �� 5      $��6 �6   �� 5      $
��1.5* �6   .+�5   
   �� .��5      �� $	��200��6   .+�5      �� $	��200��6   $��0,0,0,20q�6,   $
��Left=�6>   $	��400��6Y   .+�5      �� $��Salida��6      Heading2#��[ 6.   �� 5      $��Nota:��6    �� 5      -   5         ��Name$ txtNota��5      ��6/   �� *Nota+�� 5      $��Fecha:��6    (  "System.Windows.Controls.DatePicker  5      -   5          Name$ txtFecha��5   !      Text 63   �� *Fecha+5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ 
btnGuardar��5      $	��100��61   $��guardar��6@   6R   �� 5      -   5        $ btnActualizar��5      $	��100��64   $��
actualizar��6C   $y�	Collapsed=�6t   5      5       5!      �� 5#   
   $��1��6   �� 5$   
   $��Visible=�6   $��Visible=�6?   $��2 ��6e     
SplitRight#��[ 6v   .��5%      �� $	��200��6   .+�5'      �� $��Empleado��6     Heading1#��[ 6,   �� 5(      -   5         ��Name$ listEmpleado��5(      ��. $��1��6o   ��61   ��  �� View 5)      �� 5*       �� AllowsColumnReorder . .P�5+      �� 	 �� Width$	 0��6Y   
 �� DisplayMemberBinding
 6-   �� *
IdEmpleado+6Y   �� 5,      $		 150��6-   
 69   �� *
NoEmpleado+.��5-   "   �� -   5        .��5.   &   �� $	��100��61   $ Vertical=�6=   .+�5/   *   �� $��0,5,0,0q�64   $��
NoEmpleado��6E    �� TextAlignment$ Center=�6W   �� 50   *   -   5        $ txtNoEmpleadoBusqueda��50   2   $��Normal"�6Q   6e   51   '   52   #   53      �� 54      $		 150��6-   
 69   �� *Nombre+.��55   "   �� -   5        .��56   &   �� $	��100��61   $ Vertical=�6=   .+�57   *   �� $��0,5,0,0q�64   $��Nombre��6E   $ Center=�6S   �� 58   *   -	   5        $ txtNombreBusqueda��58   2   $��Normal"�6M   6a   59   '   5:   #   5;      �� 5<      $		 150��6-   
 69   �� *ApellidoPaterno+.��5=   "   �� -
   5        .��5>   &   �� $	��100��61   $ Vertical=�6=   .+�5?   *   �� $��0,5,0,0q�64   $��ApellidoPaterno��6E   $ Center=�6\   �� 5@   *   -   5        $  txtApellidoPaternoBusqueda��5@   2   $��Normal"�6V   6j   5A   '   5B   #   5C      �� 5D      $		 150��6-   
 69   �� *ApellidoMaterno+.��5E   "   �� -   5        .��5F   &   �� $	��100��61   $ Vertical=�6=   .+�5G   *   �� $��0,5,0,0q�64   $��ApellidoMaterno��6E   $ Center=�6\   �� 5H   *   -   5        $  txtApellidoMaternoBusqueda��5H   2   $��Normal"�6V   6j   5I   '   5J   #   5K      �� 5L      $		 150��6-   
 69   �� *Departamento+.��5M   "   �� -   5        .��5N   &   �� $	��100��61   $ Vertical=�6=   .+�5O   *   �� $��0,5,0,0q�64   $��Departamento��6E   $ Center=�6Y   �� 5P   *   -   5        $ txtDepartamentoBusqueda��5P   2   $��Normal"�6S   6g   5Q   '   5R   #   5S      5T      5W      5Y      5Z      5[      5]      