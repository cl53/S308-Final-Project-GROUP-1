﻿#pragma checksum "..\..\RoomPreview.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "60EF554EFFC4E33513735F3D8F3685B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Group01;
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


namespace Group01 {
    
    
    /// <summary>
    /// RoomPreview
    /// </summary>
    public partial class RoomPreview : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\RoomPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Group01.RoomPreview winRoomPreview;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\RoomPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturnToMainWindow;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\RoomPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSystemTitle;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\RoomPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgRooms;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\RoomPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxRoomType;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RoomPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRoomType;
        
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
            System.Uri resourceLocater = new System.Uri("/Group01;component/roompreview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RoomPreview.xaml"
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
            this.winRoomPreview = ((Group01.RoomPreview)(target));
            return;
            case 2:
            this.btnReturnToMainWindow = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\RoomPreview.xaml"
            this.btnReturnToMainWindow.Click += new System.Windows.RoutedEventHandler(this.btnReturnToMainWindow_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblSystemTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.imgRooms = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.cbxRoomType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\RoomPreview.xaml"
            this.cbxRoomType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbxRoomType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblRoomType = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

