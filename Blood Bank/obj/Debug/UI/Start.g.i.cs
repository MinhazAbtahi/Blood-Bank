﻿#pragma checksum "..\..\..\UI\Start.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E4384CAE02CFAAA7CDF26327E7CA2401"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Blood_Bank.UI;
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


namespace Blood_Bank.UI {
    
    
    /// <summary>
    /// Start
    /// </summary>
    public partial class Start : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\UI\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid StartRoot;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\UI\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignInButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\UI\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signUpButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UI\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Blood Bank;component/ui/start.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\Start.xaml"
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
            this.StartRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SignInButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\UI\Start.xaml"
            this.SignInButton.Click += new System.Windows.RoutedEventHandler(this.SignInButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.signUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\UI\Start.xaml"
            this.signUpButton.Click += new System.Windows.RoutedEventHandler(this.signUpButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.groupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

