   M S B A M L   `   `   `  ����B  >PvTests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PvTests.ViewsPvTests.Views  5   	   7 clr-namespace:PvTests.ViewModelsPvTests.ViewModels  5   	   #    PvTests.Views.EditProductView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PvTests.Views     5   	   6	viewmodel clr-namespace:PvTests.ViewModels     5   	     � Title$  EditProductView��5	   	   $	��450��6!   $	��800��6.    � 	Resources 5
      -   'PvTests.ViewModels.EditProductViewModel   editProductViewModel��%   &	          5   
   6)   5      .��5      �  � DataContext# [  6   .+�5   
   �� -   5        $��Regresar��5      $
��Left=�6$   $��	18,22,0,0q�6?   $	��Top=�6R   $��75��6j   6u   �� 5   
   $��Producto��6   $
��Left=�6#   $��	30,78,0,0q�6>   $	��Top=�6Q    J� RenderTransformOrigin$ 0.452,1.277&�6i   �� 5   
   $
��Left=�6   $��
122,82,0,0q�6.   $	��Top=�6B   $	��120��6Z   ��6f   �� *ProductStringList+ �� SelectedValue 6�   �� *ProductSelected+�� 5   
   $��Descripcion��6   $
��Left=�6&   $��
30,106,0,0q�6A   $	��Top=�6U   �� 5   
   $
��Left=�6   $��23��6-   $��122,109,0,0q�69    �� TextWrapping$
 Wrap=�6N   $	��Top=�6   $	��120��6�   ��6b   �� *Description+6�   �� 5   
   $��Price��6   $
��Left=�6    $��
30,134,0,0q�6;   $	��Top=�6O   �� 5   
   $
��Left=�6   $��23��6-   $��122,137,0,0q�69   $
 Wrap=�6N   $	��Top=�6y   $	��120��6�   ��6b   �� *Price+6�   �� 5   
   $��Departamento��6   $
��Left=�6'   $��
30,161,0,0q�6B   $	��Top=�6V   �� 5   
   $
��Left=�6   $��122,165,0,0q�6.   $	��Top=�6C   $	��120��6[   ��6g   �� *StringDepList+ 6�   �� *	StringDep+�� 5   
   $��Guardar��6   $
��Left=�6#   $��167,192,0,0q�6>   $	��Top=�6S   $��75��6k   ��6v   �� *EditProductCommand+5      5      