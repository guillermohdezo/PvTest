   M S B A M L   `   `   `  ����B  >PvTests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PvTestsPvTests  5   	   7 clr-namespace:PvTests.ViewModelsPvTests.ViewModels  5   	       PvTests.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:PvTests     5   	   6	viewmodel clr-namespace:PvTests.ViewModels     5   	     � 
ResizeMode$  NoResize=�5	   	    � Title$ Inicio de Sesion��5
   	   $��150.986��6"   $��348.025��63    � 	Resources 5      '   !PvTests.ViewModels.LoginViewModel   loginViewModel��%   &	          5   
   6#   5      .��5      �  � DataContext# [  6   $��	0,0,2,-21q�69    J� RenderTransformOrigin$ 
0.488,0.47&�6L   .+�5   
   �� $��Nombre del usuario��6   $��Center=�6-   $��15,30,207,0q�6J   $	��Top=�6_   $	��116��6w   $��23��6�   �� 5   
   $
��Left=�6   $��23��6-   $��
131,30,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6{   $	��160��6�   ��6a   �� *
UserName+6�   �� 5   
   $��Entrar��6   $
��Left=�6"   $��
216,72,0,0q�6=   $	��Top=�6Q   $��75��6i   ��6t   �� *LoginCommand+5      5      