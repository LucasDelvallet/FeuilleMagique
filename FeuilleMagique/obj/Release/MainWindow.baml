   M S B A M L   `   `   `  ���� I  EFeuilleMagique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FeuilleMagiqueFeuilleMagique       WpfApplication1.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     .localclr-namespace:FeuilleMagique     -     � Title$  
MainWindow��$
��1000��$
��1300��.��� .+�� $��0,0,-199.4,0.4q�����  �� ImageSource$ images/bureau.jpg��� $	��700��$	��550��$��
-700,0,0,0q� � Cursor$	 Pen�� � ColumnDefinitions �� $
��193* ��� $
��357* ����� $ images/feuilleCarreau.gif��.+�   FeuilleMagique.MyGifImage  -     Name$ gifImageDroite��$
��Fill=�   	GifSource$ /images/AnimDroite.gif��   	AutoStart .  $��2��  -   $ gifImageGauche��$
��Fill=�$ /images/AnimGauche.gif�� .  $��2���� -    ��Name$ feuille��$
��Left=�$	��588�� �� TextWrapping$
 Wrap=�$	��Top=�$	��424��$��Freestyle Script)�$��17(�	 �� AcceptsReturn	 . $��
105,58,0,0q�
 �� 	IsEnabled
 .  J� RenderTransformOrigin$ 0.5,0.5&�$	 Pen��$��2����Z� ��Z� .���� -    ��Name$ pagesuivante��$
��Left=�$��50��$��307.2,651,0,-1q�$	��Top=�$��50��$!��images/pagecorneeDroite.png��$ -1.296,-0.196&�$��1���� -   $ pageprecedente��$
��Left=�$��50��$��
-1,648,0,0q�$	��Top=�$��50��$!��images/pagecorneeDroite.png��$ 0.5,0.5&�z�V� .~���  �� ScaleY$ 1Q� �� ScaleX$ -1Q���  �� AngleY$ 0Q� �� AngleX$ 0Q���  �� Angle$ 0Q�T� �� -   $ titre��$
��Left=�$��49��$��	112,5,0,0q�$
 Wrap=�$	��Top=�$	��422��$��Freestyle Script)�$��30(�$��2����Z� ��Z� �� -    ��Name$ numpage��$
��Left=�$��41��$
��Wrap=�$	��Top=�$��90��$��Freestyle Script)�$��25(�$��10,8,0,0q�� -	    �Name$ dossierGrid��
�������$
��Left=�$	��587��$��
105,59,0,0q�$	��Top=�$	��435��$	 Pen��$��2�� � RowDefinitions �� $	��80* ��� $	��80* ��� $	��80* ��� $	��80* � �� $	��80* ��� $	��80* ��� $	��80* ��� $	��80* ��� -
    ��Name$ ScrollPagesNaviguer��$��Hidden=�$��Visible=�$��118,626,63,2q�$y�Visible=�$��2��.���� -    ��Name$ pagesNaviguer��$
��Left=����	#FFDEDEDE$��68��$	��Top=�$��Visible=�$��Disabled=� �� CanHorizontallyScroll .  �� Orientation$ 
Horizontal=�$y�Hidden=�