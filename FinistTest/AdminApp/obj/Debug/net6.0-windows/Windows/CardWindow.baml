   M S B A M L   `   `   `  ????C  ?AdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AdminApp.WindowsAdminApp.Windows  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   !    AdminApp.Windows.CardWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:AdminApp.Windows     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          ? Title$  
CardWindow??5	   	   $	??500??63   $	??800??6@   .??5
      ?  ? RowDefinitions 5   
   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      ?? 5      $??55 ?6    ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      .+?5   
   ?? $??Номер карты??6   ?? 5   
   -   5         ??Name$ tbNumber??5   ]   $??1??6    ?? 	MaxLength$ 16??6"   6]   ?? 5   
   $??1??6   $	??CVV??6   ?? 5   
   -   5        $ tbCVV??5   i   $??1??6   $??1??6   $ 3??6/   6i   ?? 5   
   $??2??6   $??Дата выпуска??6   (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$ dpReleaseDate??5    ]   $??2??6   $??1??6"   
 ?? Now   SelectedDate# Z 62   6]   ?? 5!   
   $??3??6   $??Фото??6   ?? 5"   
   -   5        $ tbImage??5"   ?   $??3??6   $??1??6   $	 100??6/   6?   ?? 5#   
   $??4??6   $??Баланс??6   ?? 5$   
   -   5        $ 	tbBalance??5$   m   $??4??6   $??1??6   $	 100??6/   6m   ?? 5%   
   $??5??6   $#??Банковский счет??6   ?? 5&   
   -   5         ??Name$ 	cbAccount??5&      $??1??6&   $??5??66   	 ?? DisplayMemberPath$
	 Name??6C   
 ?? SelectedValuePath$
 Id??6\   ?? 5'   
   $??6??6   $??Тип карты??6   ?? 5(   
   -   5        $ 
cbCardType??5(      $??1??6'   $??6??67   .@?5)      ?? .??6   Дебетовая6&   ?? 5*      .??6   Кредитная6&   5+      ? 5,      $??8??6   $??2??6     5-      ?? 5.      ?? 5/      .+?51      ?? -	   5         ??Name$ BtnOk??51      $??Сохранить??6$   68   ?? 52      -
   5        $ 	BtnCancel??52      $??1??6(   $??Отмена??68   6I   53      54      55      