   M S B A M L   `   `   `  ????C  ?AdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AdminApp.PagesAdminApp.Pages  5          AdminApp.Pages.UsersPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:AdminApp.Pages     5      -   5          N? Title$  	UsersPage??5	      .??5
      ?  ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??55 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgUsers??5         CanUserAddRows$ False??6$      
IsReadOnly$
 True??6;      AutoGenerateColumns$ False??6M      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6M   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   ?? 
 ?? Path$
 Id?6M     5      $ 
Логин??6%   $ 2* 6S   	 64   ?? $
 Login?6S     5      $ Пароль??6%   $ 2* 6W   	 65   ?? $
 Password?6W     5      $ 
Почта??6%   $ 3* 6S   	 64   ?? $
 Email?6S   5      ? 5   
   $??1??6    ? ColumnDefinitions 5      ?? 5      ?? 5      ?? 5      .+?5      ?? -   5         ??Name$ BtnAdd??5      $??Добавить??6%   68   ?? 5      -   5        $ BtnEdit??5      $??Изменить??6&   $??1??69   6I   ?? 5       -   5        $ BtnDel??5       $??Удалить??6%   $??2??67   6G   5!      5"      5#      