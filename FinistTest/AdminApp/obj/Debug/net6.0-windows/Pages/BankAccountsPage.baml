   M S B A M L   `   `   `  ????C  ?AdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AdminApp.PagesAdminApp.Pages  5      %    AdminApp.Pages.BankAccountsPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:AdminApp.Pages     5      -   5          N? Title$  MainPage??5	      .??5
      ?  ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??55 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgAccounts??5         CanUserAddRows$ False??6'    ?? SelectedValuePath$ Id??6>      
IsReadOnly$
 True??6U      AutoGenerateColumns$ False??6g      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6M   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   ??  ?? Path$ Id?6M     5      $ Имя??6%   $	 2* 6P   
 62   ?? $
 Name?6P     5      $ Спецификация??6%   $	 3* 6]   
 6;   ?? $ Specific?6]     5      $ 
Номер??6%   $	 3* 6T   
 64   ?? $ Number?6T     5      $ Фото??6%   $	 2* 6R   
 63   ?? $ Image?6R     5      $ Дата открытия??6%   $	 3* 6a   
 6<   ?? $ OpeningDate?6a     5      $ Пользователь??6%   $	 3* 6Y   
 6;   ?? $
 User?6Y   5      ? 5   
   $??1??6    ? ColumnDefinitions 5      ?? 5      ?? 5      ?? 5      .+?5!      ?? -   5         ??Name$ btnAdd??5!      $??Добавить??6%   68   ?? 5"      -   5        $ btnEdit??5"      $??Изменить??6&   $??1??69   6I   ?? 5#      -   5        $ btnDel??5#      $??Удалить??6%   $??2??67   6G   5$      5%      5&      