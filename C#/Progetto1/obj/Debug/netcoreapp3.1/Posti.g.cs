﻿#pragma checksum "..\..\..\Posti.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2A21866CEB6CCA13B470CD9C1C5873F114350AC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using Progetto1;
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


namespace Progetto1 {
    
    
    /// <summary>
    /// Posti
    /// </summary>
    public partial class Posti : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Posti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Posti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCognome;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Posti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEta;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Posti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Posti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image cestinoimg;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Posti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Progetto1;component/posti.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Posti.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtCognome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtEta = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn = ((System.Windows.Controls.Image)(target));
            
            #line 17 "..\..\..\Posti.xaml"
            this.btn.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cestinoimg = ((System.Windows.Controls.Image)(target));
            
            #line 18 "..\..\..\Posti.xaml"
            this.cestinoimg.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.cestinoimg_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnBack = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\..\Posti.xaml"
            this.btnBack.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnBack_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

