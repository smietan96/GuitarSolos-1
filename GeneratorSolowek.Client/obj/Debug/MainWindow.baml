   M S B A M L   `   `   `  ����R  NGeneratorSolowek.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:GeneratorSolowek.ClientGeneratorSolowek.Client  5   	   (    "GeneratorSolowek.Client.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:GeneratorSolowek.Client     5   	   $��16(�5        � Title$  Generator Solówek��5   	   $	��350��6#   $	��800��60   $��Segoe UI Light)�6<   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��Skale��61   $��26(�6>   $��0,0,0,10q�6L   �� 5!   
   -   5         ��Name$ 	dMajorBtn��5!   .   $��1��6   $��2��6!   $��D DUR��5"      $	��100��6!   $��0,0,0,10q�6-   6?   �� 5#   
   -   5        $ 	cMajorBtn��5#   .   $��1��6   $��3��6!   $��C DUR��5$      $	��100��6!   $��0,0,0,10q�6-   6?   �� 5%   
   -   5        $ 	aBluesBtn��5%   .   $��1��6   $��4��6!   $��A BLUES��5&      $	��100��6#   $��0,0,0,10q�6/   6A   �� 5(   
   $��1��6   $��5��6$   $��Wybrana skala:��61   $��0,0,10,0q�6G   �� 5)   
   -   5         ��Name$ scaleLbl��5*      $��2��5)      $��5��6$   $��3��61   $��0,0,10,0q�5*   &   �� 5,   
   $��1��6   $��7��6$   $��Próg minimalny��61   $��	0,0,10,10q�6G   �� 5-   
   $��1��6   $��8��6$   $��Próg maksymalny��61   $��	0,0,10,10q�6H   �� 5/   
   -   5         ��Name$ cbMin��5/      $��2��6"   $��7��62   $��0,0,0,10q�6?   �� 50   
   -   5        $ cbMax��50      $��2��6"   $��8��62   $��0,0,0,10q�6?   �� 52   
   -   5        $ clearBtnMin��52   .   $��3��6   $��7��6!   $��	Wyczyść��53      $	��100��6#   $��
10,0,10,10q�6/   6C   �� 54   
   -   5        $ clearBtnMax��54   .   $��3��6   $��8��6!   $��	Wyczyść��55      $	��100��6#   $��
10,0,10,10q�6/   6C   �� 57   
   -	   5         ��Name$ 
tabTextBox��57   3   $��4��6   $��2��6&   $��3��6G   $��Lucida Console)�58      $��14(�62    �� 
LineHeight$ 2��6@   $ �� HorizontalScrollBarVisibility$
 Auto=�59      . �5:      /� 	 /� 	PageWidth$
	 1000��6   .T�5;      J� 5<      5=      �� 5?   
   $��4��6   $��7��6#   $��2��60   $��0,0,0,10q�6A   ��5@      �� 5A      $��Operacje��6   $��12(�6,   .��5C      �  5D      �� 5E      $��* �6'   �� 5F      $��* �6'    5H      �� 5I      $��* �6$   .+�5K      �� -
   5        $ generateBtn��5L      $��0��5K      $��0��6)   $��GENERUJ��66   $��5q�5L   .   69   �� 5M      -   5        $ nextBtn��5N      $��1��5M      $��0��6)   $��NASTĘPNE 4��66   $��5q�5N   *   65   5O      5P      5Q      5R      