﻿#pragma checksum "..\..\..\..\..\..\SanmarkSolutions\MerchantSharpApp\View\StakeHolders\AddBank.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9F3878FDD07A467DBBE731849C73FED4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CustomControls.SanmarkSolutions.WPFCustomControls.MSTextBox;
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


namespace MerchantSharp.SanmarkSolutions.MerchantSharpApp.View.StakeHolders {
    
    
    /// <summary>
    /// AddBank
    /// </summary>
    public partial class AddBank : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\..\SanmarkSolutions\MerchantSharpApp\View\StakeHolders\AddBank.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CustomControls.SanmarkSolutions.WPFCustomControls.MSTextBox.MSTextBox textBox_name;
        
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
            System.Uri resourceLocater = new System.Uri("/MerchantSharp;component/sanmarksolutions/merchantsharpapp/view/stakeholders/addb" +
                    "ank.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\SanmarkSolutions\MerchantSharpApp\View\StakeHolders\AddBank.xaml"
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
            
            #line 5 "..\..\..\..\..\..\SanmarkSolutions\MerchantSharpApp\View\StakeHolders\AddBank.xaml"
            ((MerchantSharp.SanmarkSolutions.MerchantSharpApp.View.StakeHolders.AddBank)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 5 "..\..\..\..\..\..\SanmarkSolutions\MerchantSharpApp\View\StakeHolders\AddBank.xaml"
            ((MerchantSharp.SanmarkSolutions.MerchantSharpApp.View.StakeHolders.AddBank)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.Window_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBox_name = ((CustomControls.SanmarkSolutions.WPFCustomControls.MSTextBox.MSTextBox)(target));
            return;
            case 3:
            
            #line 17 "..\..\..\..\..\..\SanmarkSolutions\MerchantSharpApp\View\StakeHolders\AddBank.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

