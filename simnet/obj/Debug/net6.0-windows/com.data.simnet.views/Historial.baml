   M S B A M L   `   `   `  ����A  =simnet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:simnet.com.data.simnet.viewssimnet.com.data.simnet.views  5   	   ,    &simnet.com.data.simnet.views.Historial   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:simnet.com.data.simnet.views     5   	     � Title$  win_toma��5   	   $
��1024��6   $	��768��6(    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5	      � .+�5
   
   �� $��Center=�6   $	��100��6-   $	��Top=�6:   $	��768��6R   $&�� /com.data.simnet.views/image.png��6^   �� 5   
   -   5         ��Name$! txt_Signos_oximetria_titulo��5      $
��Wrap=�69   $	��Top=�6M   $��69(�6e   $
��Bold"�6s   ���	#FF656565$	��556��6�   $��96��6�   $��	0,106,0,0q�6�   $��Center=�6�   $��Historial  Signos ��6�   �� 5   
   -   5         ��Name$ 	documento��5      $��
Documento:��6#   $
��Left=�68   $	��Top=�6S   $��24(�6k   $
��Bold"�6y   ���	#FF1F679F$��114,210,0,0q�6�   �� 5   
   -   5        $ nombre��5      $��Nombre:��6    $
��Left=�62   $��24(�6M   $
��Bold"�6[   ���	#FF1F679F$	��Top=�6�   $��114,257,0,0q�6�   $	��148��6�   �� 5   
   -   5         ��Name$ 
txt_nombre��5      $
��Left=�6'    �� TextWrapping$
 Wrap=�6B   $��20(�6V    J� Opacity$	 0.3Q�6d   ���	#FF656565$	��298��6�   $��336,0,0,727q�6�   $��40��6�   $��Bottom=�6�   �� 5   
   -   5        $ txt_documento��5      $
��Left=�6)   $��336,0,0,772q�6D   $
 Wrap=�6Y   $��Bottom=�6m   $��20(�6�   $	 0.3Q�6�   ���	#FF656565$��40��6�   $	��298��6�   ���	#FF0F43DE6�   �� 5   
   $
��Left=�6   $	��100��6+   $	��Top=�68   $	��500��6P   $+��%/com.data.simnet.views/Logoblanco.png��6\   �� 5   
   $
��Left=�6   $	��100��6+   $��
54,535,0,0q�68   $	��Top=�6L   $	��100��6d   $(��"/com.data.simnet.views/Presion.png��6p   �� 5   
   $
��Left=�6   $	��100��6+   $��
54,726,0,0q�68   $	��Top=�6L   $	��100��6d   $*��$/com.data.simnet.views/Oximetria.png��6p   �� 5   
   $
��Left=�6   $	��100��6+   $��
54,345,0,0q�68   $	��Top=�6L   $	��100��6d   $-��'/com.data.simnet.views/temperaturec.png��6p   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dta_grid_temp��5      $��199,345,153,562q�6O   ��6*   �� *TempDataList+6O     5   
   -   5        $	 dta_grid_presion��5      $��199,535,23,350q�6R   ��6-   �� *TempDataList+6R     5   
   -   5        $	 dta_grid_oxy��5      $��199,709,23,176q�6L   ��6)   �� *
OxyDataLis+6L   �� 5   
   -	   5        $��Regresar��5      $
��Left=�6$   $��450,894,0,0q�6?   $	��Top=�6T   $	��100��6l   $	��100��6y   
���������5      �� 5      
 �� ImageSource$2
 ,/com.data.simnet.views/left-arrow_892645.png��6   5      �� 5   
   -
   5         ��Name$ boton_salir��5      $�� ��6&   $
��Left=�61   $��591,894,0,0q�6L   $	��Top=�6a   $	��100��6y   $	��100��6�   
���������5      �� 5      $&
  /com.data.simnet.views/exit2.png��6   5       5"      5#      