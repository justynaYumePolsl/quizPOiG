   M S B A M L   `   `   `  ����?  ;Quiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Quiz.View	Quiz.View  5          Quiz.View.QuestionView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Quiz.View     5        � 	Resources  5	       �� 
TargetType �� Property �� Value��%z   '	�       �� 5
   
   " 	�6   .�5      ��  � ��$ 15q�6'   �� 5       � ��$ Center=�62   5      5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��4* �6   .+�5   
   � $��0��6   $��0��6   .+�5      ]� .+�5      �� $��5q�6    �� TextAlignment$ Center=�5      $��20(�61   $	��600��6?   $��50��6K   $��Center=�6Z   $��Center=�6u   ���	#FFC5C5C5
����������	#FF1F1F1F��5   &   �� *
Question+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" >�5   E   5      5      � 5   
   $��1��6   $��20q�6   .+�5!      �� 	 �� Orientation$	 Vertical=�6   $��1��60   $��Center=�6=   $��Center=�5"      .+�5#      �� $	 
Horizontal=�6   $��10q�66   .+�5$      	� -   5        
 	�Name$
 answer0��5$   6    	� 	GroupName$ answers��6"   
 � Tag$ 0��6`   �� 5%      -   5         ��Name$ textBox0��5&      $	��500��61   $��15(�6=   $��Center=�6K   $��10q�6f   ���	#FFC5C5C5
����������	#FF1F1F1F��5%      �� *
Answers[0]+ �� $ FindAncestor=�" >�5'   2   5(      �� 5+      $	 
Horizontal=�6   $��10q�66   .+�5,      	� -   5        $
 answer1��5,   6   $ answers��6"   $ 1��6`   �� 5-      -   5        $ textBox1��5.      $	��500��61   $��15(�6=   $��Center=�6K   $��10q�6f   ���	#FFC5C5C5
����������	#FF1F1F1F��5-      �� *
Answers[1]+ �� $ FindAncestor=�" >�5/   2   50      �� 52      $	 
Horizontal=�6   $��10q�66   .+�53      	� -   5        $
 answer2��53   6   $ answers��6"   $ 2��6`   �� 54      -   5        $ textBox2��55      $	��500��60   $��15(�6<   $��Center=�6J   $��10q�6e   ���	#FFC5C5C5
����������	#FF1F1F1F��54      �� *
Answers[2]+ �� $ FindAncestor=�" >�56   2   57      �� 59      $	 
Horizontal=�6   $��10q�66   .+�5:      	� -   5        $
 answer3��5:   6   $ answers��6"   $ 3��6`   �� 5;      -   5        $ textBox3��5<      $	��500��60   $��15(�6<   $��Center=�6J   $��10q�6e   ���	#FFC5C5C5
����������	#FF1F1F1F��5;      �� *
Answers[3]+ �� $ FindAncestor=�" >�5=   2   5>      5?      5@      5A      5B      