   M S B A M L   `   `   `  ����E  ABlood Bank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Blood_Bank.UIBlood_Bank.UI  5   	       Blood_Bank.UI.UserInfo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Blood_Bank.UI     5   	   .��5	      � -   5          �Name$  userInfoRoot��5	      
�������.+�5
   
   �� -   5         ��Name$ groupBox��5
      $��Blood Donor Information��6%   $
��Left=�6F   $��
10,187,0,0q�6a   $	��Top=�6u   $	��768��6�   $	��383��6�   $��14(�6�   $
��Bold"�6�   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ userDataGrid��5      
�������$
��Left=�6E      AutoGenerateColumns .  $��7,10,0,0q�6|   $	��Top=�6�   $	��740��6�   $	��339��6�   $��13(�6�   $��Normal"�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        firstNameCol��,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��5   �      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�      CanUserResize .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *	FIRSTNAME+	   ClipboardContentBinding	 6]   Z� 6�     5      -   5        lastNameCol��$ 	Last Name��5   ~   $	 100 6�    .   6>   �� *
LASTNAME+	 6[   Z� 6�     5      -   5        bloodGroupCol��$ Blood Group��5   �   $ 90 6�    .  
   
FontWeight$

 Bold"�6�    6@   �� *BLOOD_GROUP+	 6`   Z� 6�     5      -   5        emailCol��$ Email��5   x   $	 120 6�    .   6;   �� *EMAIL+	 6U   Z� 6�     5      -   5        contactNoCol��$ 
Contact No��5   �   $	 120 6�    .   6?   �� *
CONTACT_NO+	 6^   Z� 6�     5      -	   5        
addressCol��$ Address��5   |   $ * 6�    .   6=   �� *	ADDRESS+	 6Y   Z� 6�   5      5      o� 5   
   -
   5         o�Name$ menuTray��5      
�������$
��Left=�69   $��27��6T   $	��Top=�6`   $	��800��6x   .@�5      m� -   5         m�Name$ fileMenuItem��5      
�������$
��File��6E   $��28��6S   $��14(�6_   .@�5      m� -   5        $ donorListSubMenuItem��5      
������� � ToolTip$ Loads Blood Donor List.��6Q   $��
Donor List��6s   6�   m� 5      -   5        $ logoutSubMenuItem��5      
�������$��Log Out��6N   6_   m� 5      -   5        $ exitSubMenuItem��5      
�������$
��Exit��6L   6Z   5      m� 5      -   5        $ userMenuItem��5      
�������$
��User��6E   $��28��6S   $��14(�6_   .@�5      m� -   5        $ profileSubMenuItem��5      
�������$��Profile��6O   6`   5      m� 5      -   5        $ aboutMenuItem��5      
�������$��28��6F   $��About��6R   $��14(�6a   .@�5       m� -   5        $ aboutSubMenuItem��5       
�������$��About...��6M   6_   5!      5"      �� 5$   
   -   5         ��Name$ emailTextBox��5$      $
��Left=�6(   $��26��6C   $��502,114,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��164��6�   $��14(�6�   �� 5%   
   -   5         ��Name$ searchByEmailButton��5%      
�������$��Search��6F   $
��Left=�6W   $��671,114,0,0q�6r   $	��Top=�6�   $��90��6�   $��14(�6�   $��25��6�   $ Search by Email.��6�   �� 5&   
   -   5         ��Name$ bloodGroupComboBox��5&      
�������$
��Left=�6G   $��502,145,0,0q�6b   $	��Top=�6w   $	��120��6�   $��25��6�   $��14(�6�   .@�5'      �� $	��AB+��6   �� 5(      $��A+��6   �� 5)      $��B+��6   �� 5*      $��O+��6   �� 5+      $��O-��6   �� 5,      $��B-��6   �� 5-      $��A-��6   �� 5.      $	��AB-��6   5/      �� 51   
   -   5        $ searchByBGButton��51      
�������$��Search��6C   $
��Left=�6T   $��671,145,0,0q�6o   $	��Top=�6�   $��90��6�   $��14(�6�   $��25��6�   $ Search by Blood Group.��6�   �� 52   
   -   5         ��Name$ label_Copy2��52      $��Blood Group:��6%   $
��Left=�6<   $��401,142,0,0q�6W   $	��Top=�6l   $��14(�6�   $��25��6�   �� 53   
   -   5        $ Email_��53      $��Email:��6    $
��Left=�61   $��401,112,0,0q�6L   $	��Top=�6a   $��14(�6y   $��25��6�   �� 54   
   -   5        $ navigationGroupBox��54      $��Search Blood Donor��6/   $
��Left=�6K   $��
385,83,0,0q�6f   $	��Top=�6z   $	��393��6�   $	��104��6�   $��14(�6�   $
��Bold"�6�   `� 55   
   $
��Left=�6   $��40��61   $��0,27,0,0q�6=   $	��Top=�6O   $	��800��6g   .�56      c� -   5         c�Name$ toolBar1��56      $
��Left=�6(   $��40��6C   $	��Top=�6O   $	��178��6g   .@�57      �� -   5        $ donorListButton��57      $��40��62   $��40��6>   $��0,0,0,-5q�6I   $ Refresh Blood Donor List.��6y   .��58      �� $0��*/Blood Bank;component/Resources/reload.png��6   $��35��6P   $��35��6\   59      �� 5:      -   5        $ profileButton��5:      $��40��60   $��40��6;   $��0,0,0,-5q�6G   $ User Profile��6u   .��5;      �� $1��+/Blood Bank;component/Resources/profile.png��6   $��35��6Q   $��35��6\   5<      �� 5=      -   5        $ logoutButton��5=      $��40��6/   $��40��6:   $��0,0,0,-5q�6F   $ Log Out��6s   .��5>      �� $0��*/Blood Bank;component/Resources/logout.png��6   $��35��6P   $��35��6[   5?      5@      5A      5B      5C      