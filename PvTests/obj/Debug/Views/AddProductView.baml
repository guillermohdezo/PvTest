   M S B A M L   `   `   `  ����B  >PvTests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PvTests.ViewsPvTests.Views  5   	   7 clr-namespace:PvTests.ViewModelsPvTests.ViewModels  5   	   "    PvTests.Views.AddProductView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PvTests.Views     5   	   6	viewmodel clr-namespace:PvTests.ViewModels     5   	     � Title$  Agregar Producto��5	   	   $��203.634��6"   $��323.926��63    � 	Resources 5
      ,   &PvTests.ViewModels.AddProductViewModel   addProductViewModel��%   &	          5   
   6(   5      .��5      �  � DataContext# [  6   $��0,0,2,-2q�6>   .+�5   
   �� $��Departamento��6   $
��Left=�6'   $��24��6B   $��	26,24,0,0q�6N   $	��Top=�6a   $��93��6y   �� 5   
   $
��Left=�6   $��
119,24,0,0q�6.   $	��Top=�6B   $	��127��6Z   $��24��6f   ��6r   �� *StringDepList+ �� SelectedValue 6�   �� *	StringDep+�� 5   
   $��Descripcion��6   $
��Left=�6&   $��24��6A   $��	26,58,0,0q�6M   $	��Top=�6`   $��73��6x   �� 5   
   $
��Left=�6   $��24��6-   $��
119,58,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6~   $	��127��6�   ��6a   �� *Description+6�   �� 5   
   $��Precio��6   $
��Left=�6!   $��24��6<   $��	26,87,0,0q�6H   $	��Top=�6[   $��93��6s   �� 5   
   $
��Left=�6   $��24��6-   $��
119,87,0,0q�69   $
 Wrap=�6M   $	��Top=�6x   $	��127��6�   ��6a   �� *Price+6�   �� 5   
   $��Añadir��6   $
��Left=�6"   $��171,130,0,0q�6=   $	��Top=�6R   $��75��6j   ��6u   �� *AddProductCommand+�� 5   
   -   5        $��Regresar��5      $
��Left=�6$   $��
26,130,0,0q�6?   $	��Top=�6S   $��75��6k   6v   5      5      