   M S B A M L   `   `   `  ����  WarehouseManager-    'WarehouseManager.Content.ListDevolucion   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.3.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  5      .��5	      �   � 	Resources  5
   
    �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$
 Left=�64   �� 5       � ��$	 Top=�62   �� 5       � ��$ 3,0,0,0q�6'   5      5      .+�5      �    
RootMargin#��[  6   5      � 5      .+�5   
   �   ContentMargin#��[ 6    � RowDefinitions 5      �� 5      �� 5       $
��Auto �6    .+�5"      �� $��Visible=�6   $��Visible=�6G   .��5#      �� $	��200��6!   .+�5%      �� $��
Devolucion��6$     Heading1#��[ 66   �� 5&      -   5         ��Name$ listDevolucion��5&   #   ��. $��1��6y   ��6;   ��  �� View 5'      �� 5(   "    �� AllowsColumnReorder . .P�5)   &   ��  �� Width$ 0��6c   	 �� DisplayMemberBinding	 65   �� *IdDevolucion+6c   �� 5*      $	 150��6   	 6   �� *
IdEmpleado+.��5+   "   �� -   5        .��5,   &   �� $	��100��61   
 �� Orientation$
 Vertical=�6=   .+�5-   *   �� $��0,5,0,0q�64   $��
IdEmpleado��6E    �� TextAlignment$ Center=�6W   �� 5.   *   -   5         ��Name$ txtIdEmpleadoBusqueda��5.   2   $��Normal"�6Q   6e   5/   '   50   #   51      �� 60   $	 150��6?   	 6K   �� *
IdArticulo+.��52   "   �� -   5        .��53   &   �� $	��100��61   $
 Vertical=�6=   .+�54   *   �� $��0,5,0,0q�64   $��
IdArticulo��6E   $ Center=�6W   �� 55   *   -   5        $ txtIdArticuloBusqueda��55   2   $��Normal"�6Q   6e   56   '   57   #   58      �� 60   $	 150��6?   	 6K   �� *
Cantidad+.��59   "   �� -   5        .��5:   &   �� $	��100��61   $
 Vertical=�6=   .+�5;   *   �� $��0,5,0,0q�64   $��Cantidad��6E   $ Center=�6U   �� 5<   *   -   5        $ txtCantidadBusqueda��5<   2   $��Normal"�6O   6c   5=   '   5>   #   5?      �� 60   $	 150��6?   	 6K   �� *Nota+.��5@   "   �� -   5        .��5A   &   �� $	��100��61   $
 Vertical=�6=   .+�5B   *   �� $��0,5,0,0q�64   $
��Nota��6E   $ Center=�6Q   �� 5C   *   -	   5        $ txtNotaBusqueda��5C   2   $��Normal"�6K   6_   5D   '   5E   #   5F      �� 60   $	 150��6?   	 6K   �� *Fecha+.��5G   "   �� -
   5        .��5H   &   �� $	��100��61   $
 Vertical=�6=   .+�5I   *   �� $��0,5,0,0q�64   $��Fecha��6E   $ Center=�6R   �� 5J   *   -   5        $ txtFechaBusqueda��5J   2   $��Normal"�6L   6`   5K   '   5L   #   5M      65   5P      5R      5S      � 5W        HeaderMargin#��[ 6   $��Right=�6:   $	��Top=�6V   5Y      � 5\      $��1��6     StatusMargin#��[ 6    .+�5]      �� ��6    Z� 7  1FirstFloor.ModernUI.Windows.Controls.ModernButton  5^      -   5          Name$ 	btnUpdate��5^   '   $��
actualizar��6:      IconData� ����C�:�����:����Z�0n�����	��M�<R�|�M���0P���р�C��р�����������yȢ���CȢ����Ȣ�4���`;���+��(;��+��]G�8�p4��:��C�:���C8�����8�̟�0��<o�D�[�$�LD�[�$M@r��v�|�M��C|�M�0��|�M��|�-4���<��4���}ф:Tn5ф:l't��Z�l'tр�C���Ƽ���������8+8���C8�$��0,0,5,0q�5d   ?   $��25��6Q   $��Right=�6u   $��Bottom=�6�   5e      5f      5g      5h      5i      