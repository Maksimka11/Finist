   M S B A M L   `   `   `  ????C  ?AdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AdminApp.WindowsAdminApp.Windows  5   	   %    AdminApp.Windows.FavoriteWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:AdminApp.Windows     5   	   -   5          ? Title$  FavoriteWindow??5   	   $	??450??68   $	??800??6E   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      $??55 ?6   ?? 5      ?? 5      $??55 ?6    ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      .+?5   
   ?? $??Название??6   ?? 5   
   -   5         ??Name$ tbName??5      $??1??6"   ?? 5   
   $??1??6   $#??Банковский счет??6   ?? 5   
   -   5         ??Name$ 	cbAccount??5      $??1??6&   $??1??63    ?? DisplayMemberPath$
 Name??6C    ?? SelectedValuePath$ Id??6\   ?? 5   
   $??2??6   $??Транзакция??6   ?? 5   
   -   5        $ cbTransaction??5      $??1??6*   $??2??6:   $ Id??6G   $ Id??6^   ? 5   
   $??4??6   $??2??6    5      ?? 5      ?? 5      .+?5       ?? -   5         ??Name$ BtnOk??5       $??Сохранить??6$   68   ?? 5!      -   5        $ 	BtnCancel??5!      $??1??6(   $??Отмена??68   6I   5"      5#      5$      