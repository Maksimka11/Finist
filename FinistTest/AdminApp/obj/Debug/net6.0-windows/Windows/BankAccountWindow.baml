   M S B A M L   `   `   `  ????C  ?AdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AdminApp.WindowsAdminApp.Windows  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   (    "AdminApp.Windows.BankAccountWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:AdminApp.Windows     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          ? Title$  BankAccountWindow??5	   	   $	??450??6:   $	??800??6G   .??5
      ?  ? RowDefinitions 5   
   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      ?? 5      $??55 ?6    ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      .+?5   
   ?? $??Название??6   ?? 5   
   -   5         ??Name$ tbName??5   1   $??1??6    ?? 	MaxLength$ 20??6"   61   ?? 5   
   $??1??6   $??Номер счета??6   ?? 5   
   -   5        $ tbNumber??5   i   $??1??6   $??1??6"   $ 20??6Z   6i   ?? 5   
   $??2??6   $??Фото??6   ?? 5   
   -   5        $ tbImage??5   ?   $??2??6   $??1??6   $	 100??6/   6?   ?? 5    
   $??3??6   $??Спецификация??6   ?? 5!   
   -   5        $ 
tbSpecific??5!   >   $??3??6   $??1??6   $ 30??6/   6>   ?? 5"   
   $??4??6   $??Дата открытия??6   (  "System.Windows.Controls.DatePicker  5#   
   -   5          Name$ dpOpeningDate??5#   ]   $??4??6   $??1??6"   
 ?? Now   SelectedDate# Z 62   6]   ?? 5$   
   $??5??6   $??Пользователь??6   ?? 5%   
   -   5         ??Name$ cbUser??5%      $??1??6#   $??5??63   	 ?? DisplayMemberPath$	 Login??6@   
 ?? SelectedValuePath$
 Id??6Z   ? 5&   
   $??7??6   $??2??6    5'      ?? 5(      ?? 5)      .+?5+      ?? -   5         ??Name$ BtnOk??5+      $??Сохранить??6$   68   ?? 5,      -	   5        $ 	BtnCancel??5,      $??1??6(   $??Отмена??68   6I   5-      5.      5/      