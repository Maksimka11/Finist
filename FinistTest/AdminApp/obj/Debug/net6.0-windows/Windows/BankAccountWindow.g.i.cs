﻿#pragma checksum "..\..\..\..\Windows\BankAccountWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20BDFA8D6D48B9B4DE371FC138623931093604BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AdminApp.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AdminApp.Windows {
    
    
    /// <summary>
    /// BankAccountWindow
    /// </summary>
    public partial class BankAccountWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Windows\BankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\BankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNumber;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\BankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbImage;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\BankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSpecific;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Windows\BankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpOpeningDate;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Windows\BankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbUser;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Windows\BankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOk;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\BankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AdminApp;component/windows/bankaccountwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\BankAccountWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Windows\BankAccountWindow.xaml"
            ((AdminApp.Windows.BankAccountWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\..\Windows\BankAccountWindow.xaml"
            this.tbNumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Number_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbImage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbSpecific = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dpOpeningDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.cbUser = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.BtnOk = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Windows\BankAccountWindow.xaml"
            this.BtnOk.Click += new System.Windows.RoutedEventHandler(this.BtnOk_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Windows\BankAccountWindow.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
