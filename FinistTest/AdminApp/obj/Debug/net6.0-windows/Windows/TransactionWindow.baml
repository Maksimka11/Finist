   M S B A M L   `   `   `  ????C  ?AdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AdminApp.WindowsAdminApp.Windows  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   (    "AdminApp.Windows.TransactionWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:AdminApp.Windows     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          ? Title$  TransactionWindow??5
   	   $	??450??6:   $	??800??6G   .??5      ?  ? RowDefinitions 5   
   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      ?? 5      $??55 ?6    ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      .+?5   
   ?? $??Отправитель??6   ?? 5   
   -   5         ??Name$ cbSender??5      $??1??6%    ?? DisplayMemberPath$ Number??65    ?? SelectedValuePath$ Id??6P   ?? 5   
   $??1??6   $??Получатель??6   ?? 5   
   -   5        $ 
cbReceiver??5      $??1??6'   $??1??67   $ Number??6D   $ Id??6_   ?? 5   
   $??2??6   $??
Сумма??6   ?? 5   
   -   5         ??Name$ tbSum??5   W   $??1??6   $??2??6"   6W   ?? 5   
   $??3??6   $??Дата перевода??6   (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$ dpTransferDateTime??5    ]   $??3??6   $??1??6"   
 ?? Now	   SelectedDate#	 Z 62   6]   ? 5"   
   $??6??6   $??2??6    5#      ?? 5$      ?? 5%      .+?5'      ?? -   5        
 ??Name$
 BtnOk??5'      $??Сохранить??6$   68   ?? 5(      -   5        $
 	BtnCancel??5(      $??1??6(   $??Отмена??68   6I   5)      5*      5+      