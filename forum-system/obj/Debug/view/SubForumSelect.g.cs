﻿#pragma checksum "..\..\..\view\SubForumSelect.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BBFC68D34879684688BC793B5C6A41E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using forum_system.view;


namespace forum_system.view {
    
    
    /// <summary>
    /// SubForumWindow
    /// </summary>
    public partial class SubForumWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\view\SubForumSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock header;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\view\SubForumSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sub_forum_options;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\view\SubForumSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button choose_sub_forum;
        
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
            System.Uri resourceLocater = new System.Uri("/forum-system;component/view/subforumselect.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\view\SubForumSelect.xaml"
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
            this.header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.sub_forum_options = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\view\SubForumSelect.xaml"
            this.sub_forum_options.Loaded += new System.Windows.RoutedEventHandler(this.subForumLoaded);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\view\SubForumSelect.xaml"
            this.sub_forum_options.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.choose_sub_forum = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\view\SubForumSelect.xaml"
            this.choose_sub_forum.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

