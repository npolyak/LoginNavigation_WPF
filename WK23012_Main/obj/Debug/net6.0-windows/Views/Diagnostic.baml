   M S B A M L   `   `   `  ����G  CWK23012_Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WK23012_Main.ViewModelsWK23012_Main.ViewModels  5      #    WK23012_Main.Views.Diagnostic   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:WK23012_Main.ViewModels     5      .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � .+�5      �� .+�5      �� -   5         ��Name$ txtBoxSearch��5         textBoxSearch#��[  60   5      5      �� 5   
   $��1��6     tabControlStyle#���  6"   .@�5      �� $��Input��6     tabItemsGeneral#���  6%   .��5      � .+�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      
�������$��0q�5       ��5      �� *	InputData+   ColumnHeaderStyle 5!      �� 5"       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$   .�5#   "   ��  �� Property � ��  color12 �� Value# [ 6?   �� 5$   "    � ��  plainTextColor4# [ 6?   �� 5%   "    � ��$ 	10,0,0,10q�6<   �� 5&   "    � ��$ 
Montserrat)�6?   �� 5'   "    � ��$ 12(�6=   5(         Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
ModuleName��6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *
ModuleName+6P     5,      $
	 Name��6J   
 61   �� *Name+6J     5-      $	 Address��6M   
 61   �� *	Address+6M     5.      $	 Status��6L   
 61   �� *Status+6L     5/      $	 Vendor��6L   
 61   �� *Vendor+6L   51      52      53      �� 56      $��Output��6   #���  6&   .��57      � .+�58        $ False��59      $ * 5:      
�������$��0q�5<      ��58      �� *	InputData+ 5=      �� 5>      "  6$   .�5?   "   ��  � ��# [ 6?   �� 5@   "    � ��# [ 6?   �� 5A   "    � ��$ 	10,0,0,10q�6<   �� 5B   "    � ��$ 
Montserrat)�6?   �� 5C   "    � ��$ 12(�6=   5D       5F        5G      $	 
ModuleName��6P   
 61   �� *
ModuleName+6P     5H      $
	 Name��6J   
 61   �� *Name+6J     5I      $	 Address��6M   
 61   �� *	Address+6M     5J      $	 Status��6L   
 61   �� *Status+6L     5K      $	 Vendor��6L   
 61   �� *Vendor+6L   5M      5N      5O      �� 5Q      $��Motor��6   #���  6%   .��5R      � .+�5S      �� $��Header2��6    $��Center=�6/   $��Center=�6J   5T      5U      5W      5X      5Y      