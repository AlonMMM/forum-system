﻿#pragma checksum "..\..\..\view\SubForumWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E4DB5832F33F001EDBCD056A37ADFBF0"
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
using forum_system.model.forum_components;


namespace forum_system.view {
    
    
    /// <summary>
    /// SubForumWindow
    /// </summary>
    public partial class SubForumWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\view\SubForumWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal forum_system.view.SubForumWindow UI;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\view\SubForumWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewGuides;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\view\SubForumWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewDiscussions;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\view\SubForumWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_topic;
        
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
            System.Uri resourceLocater = new System.Uri("/forum-system;component/view/subforumwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\view\SubForumWindow.xaml"
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
            this.UI = ((forum_system.view.SubForumWindow)(target));
            return;
            case 2:
            this.listViewGuides = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.listViewDiscussions = ((System.Windows.Controls.ListView)(target));
            
            #line 21 "..\..\..\view\SubForumWindow.xaml"
            this.listViewDiscussions.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listView_Discussions_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.add_topic = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\view\SubForumWindow.xaml"
            this.add_topic.Click += new System.Windows.RoutedEventHandler(this.add_topic_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

