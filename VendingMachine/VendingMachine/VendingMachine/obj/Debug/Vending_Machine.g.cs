﻿#pragma checksum "..\..\Vending_Machine.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8AFD4AFCA29A5ABDE00822B42FB6A1AEE74558CA479FF5D976F91D844980F4E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using VendingMachine;


namespace VendingMachine {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Vending_Machine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lviewdrinks;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Vending_Machine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butmenu;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Vending_Machine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button m1;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Vending_Machine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button m2;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\Vending_Machine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button m5;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Vending_Machine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button m10;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Vending_Machine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b1;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\Vending_Machine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VendingMachine;component/vending_machine.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Vending_Machine.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lviewdrinks = ((System.Windows.Controls.ListView)(target));
            
            #line 15 "..\..\Vending_Machine.xaml"
            this.lviewdrinks.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lViewDrinks_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.butmenu = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\Vending_Machine.xaml"
            this.butmenu.Click += new System.Windows.RoutedEventHandler(this.butmenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.m1 = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\Vending_Machine.xaml"
            this.m1.Click += new System.Windows.RoutedEventHandler(this.m1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.m2 = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\Vending_Machine.xaml"
            this.m2.Click += new System.Windows.RoutedEventHandler(this.m2_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.m5 = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\Vending_Machine.xaml"
            this.m5.Click += new System.Windows.RoutedEventHandler(this.m5_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.m10 = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\Vending_Machine.xaml"
            this.m10.Click += new System.Windows.RoutedEventHandler(this.m10_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.b1 = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\Vending_Machine.xaml"
            this.b1.Click += new System.Windows.RoutedEventHandler(this.b1_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tb1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
