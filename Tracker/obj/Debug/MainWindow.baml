   M S B A M L   `   `   `  ����B  >Tracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TrackerTracker  5   	       Tracker.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Tracker     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��380��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ 	#FF808080��6'    � Offset$	 0.0Q�69   � 5      $ 	#FF000000��6'   $ 1Q�69   5      5      �� 5      $��Center=�6   .+�5      �� $��Account Manager��6   $��Light"�5       $��	helvetica)�5!      $��22(�5"      
�������$��Center=�5$      $��
114,0,92,0q�69   $	��174��6M   5%      �� 5'      $��1��6   .+�5(      ��  �� Orientation$ 
Horizontal=�6   .+�5)      �� -   5        $��Username��5,      $��	Helvetica)�5)      $��Light"�5*      $��Username��5+      $��20(�5-      $��Center=�5.      
�������
������ $��0q�51      $	��235��52      $
��Left=�53      	 J� Opacity$		 0.5Q�54      $��25��55      $��63,0,0,0q�56      58      �� 59      $	��250��6   $��2��5:      
�������$		 0.5Q�5<      �� 5?      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5@      G� -   5        
 G�Name$

 pass��5C   "   $��	Helvetica)�5@   "   $��Light"�5A       G� Password$ Password��5B      $��20(�5D      $��Center=�5E      
�������
������ $��0q�5H      $	��235��5I      $
��Left=�5J      $		 0.5Q�5K      $��25��5L      $��63,0,0,0q�5M       J� 	AllowDrop . $
��Auto=�6A    G� 	MaxLength$ 11��6s   * G� #IsInactiveSelectionHighlightEnabled . 6�   5O      �� 5P      $	��250��6   $��2��5Q      
�������$		 0.5Q�5S      �� 5U      $ 
Horizontal=�6   $��0,50,0,0q�5V      .+�5W      �� -   5        $	��100��5W      $��40��5X      $��LOGIN��5Y      $��
140,0,60,0q�5Z      5[      5\      �� 5^      $ 
Horizontal=�6   $��0,50,0,0q�5_      �� 5a      -   5        $��21��5a      $��21��5b      $��X��5c      $��100,-745,-250,100q�5d      5e      5g      5h      5i      5j      