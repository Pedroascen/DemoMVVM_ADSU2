   M S B A M L   `   `   `  ����E  ADemoMVVM01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DemoMVVM01.ViewModelsDemoMVVM01.ViewModels  5   	   !    DemoMVVM01.Views.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9	viewmodel#clr-namespace:DemoMVVM01.ViewModels     5   	     � Title$  Agregar Usuarios��5   	   $	��400��6"   $	��600��6/    � 
ResizeMode$ CanMinimize=�6;    � WindowStartupLocation$ CenterScreen=�6T    � 	Resources 5	      2   ,DemoMVVM01.ViewModels.IntermediarioViewModel   IntermediarioViewModel��%   &	          5
   
   6+   5      .��5      �  � DataContext 6   ��  �� Source# [  ��5   
   �� 5       �� ImageSource$  /Views/resourse/fondo2.jpg��6    �� Opacity$	 0.8Q�6B    � ColumnDefinitions 5   
   �� 5      $��181.949 �6   �� 5      $��98.051 �6   �� 5      	 � RowDefinitions	 5   
   �� 5      $��80 �6   �� 5      �� 5      $��50 �6   .+�5   
   �� $��0��6   $��Center=�6    $��Trebuchet MS)�6;   $
��Bold"�5   	   $��20(�6   
�������$��32,0,0,0q�6<   $��2��6N   .��6b   Listado de usuarios:5       �� 5"   
   $��1��6   $��0��6   $��35��6.   
 �� Padding$
 5q�6:   ���#4E87D4$	��Top=�6[   $��2��6s   ._�5#      �� $��Trebuchet MS)�6   $
��Bold"�6.   $��14(�6@   $��Center=�6N   
�������.��6|   Tabla de Datos:6�   5$      �� 5%   
   $��1��64   $��0��6A   $	��280��6Q   $��0,35,0,0q�6]   $
��Left=�6o   $��2��6�   ��6   �� *
Usuarios+ �� View 5&      �� 5'      .P�5(      �� $
�� Id ��6%    �� Width$
 auto��6W    �� DisplayMemberBinding 63   �� *ID+6W   �� 5)      $�� Nombre ��6%   $
 auto��6_    67   �� *Nombre+6_   �� 5*      $��
 Apellido ��6%   $
 auto��6c    69   �� *
Apellido+6c   �� 5+      $�� Hora ��6%   $
 auto��6[    65   �� *Hora+6[   5,      5.      �� 51   
   $��1��6   $��2��6   $��35��6.   $
 5q�6:   ���#4E87D4$	��Top=�6[   ._�52      �� $��Trebuchet MS)�6   $
��Bold"�6.   $��14(�6@   $��Center=�6O   
�������.��6}   
Fomulario:6�   53      � 54   
   $��1��6   $��2��6   
�������$	��219��6?   $	��Top=�6L   $��0,35,0,0q�6d   $��Center=�6v   $	��320��6�   .+�56      �� $��25��6   $��54,47,190,147q�6    $��Nombre:��67   �� 57      -   5         ��Name$ INombreText��57      $��20��6+   $	��130��67   $��130,51,60,148q�6C   �� 58      $��25��6   $��54,82,190,112q�6    $��	Apellido:��67   �� 59      -   5        $ IApellidoText��59      $��20��6-   $	��130��69   $��130,83,60,116q�6E   �� 5:      -   5        $��30��5:      $��69,121,55,68q�6!   $��Agregar Usuario��67   ��6f   �� *UsuarioCommand+5<      5=      5>      