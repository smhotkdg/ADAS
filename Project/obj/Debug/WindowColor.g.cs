﻿#pragma checksum "..\..\WindowColor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2C3F0FE09661A0E1FEE961575E9716D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:2.0.50727.3625
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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


namespace Project {
    
    
    /// <summary>
    /// WindowColor
    /// </summary>
    public partial class WindowColor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\WindowColor.xaml"
        internal System.Windows.Controls.Label fontcolor;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindowColor.xaml"
        internal System.Windows.Controls.Label FontGreen;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WindowColor.xaml"
        internal System.Windows.Controls.Label FontOrange;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WindowColor.xaml"
        internal System.Windows.Controls.Label FontBlack;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\WindowColor.xaml"
        internal System.Windows.Controls.Label FontViolet;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WindowColor.xaml"
        internal System.Windows.Shapes.Rectangle MyRectangleStrokeOnLeft;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\WindowColor.xaml"
        internal System.Windows.Shapes.Path MyPathleStrokeOnLeft;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\WindowColor.xaml"
        internal System.Windows.Shapes.Rectangle MyRectangleStrokeOnRight;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\WindowColor.xaml"
        internal System.Windows.Shapes.Path MyPathleStrokeOnRight;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project;component/windowcolor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowColor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\WindowColor.xaml"
            ((Project.WindowColor)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fontcolor = ((System.Windows.Controls.Label)(target));
            
            #line 14 "..\..\WindowColor.xaml"
            this.fontcolor.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.fontcolor_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FontGreen = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.FontOrange = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.FontBlack = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.FontViolet = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            
            #line 19 "..\..\WindowColor.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MyRectangleStrokeOnLeft = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.MyPathleStrokeOnLeft = ((System.Windows.Shapes.Path)(target));
            return;
            case 10:
            
            #line 37 "..\..\WindowColor.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 11:
            this.MyRectangleStrokeOnRight = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 12:
            this.MyPathleStrokeOnRight = ((System.Windows.Shapes.Path)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}