﻿#pragma checksum "..\..\WindowPosition.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "44A7B78E1D2863BBDF5B0DE24EA7F458"
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
    /// WindowPosition
    /// </summary>
    public partial class WindowPosition : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\WindowPosition.xaml"
        internal System.Windows.Controls.Label viewposition;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\WindowPosition.xaml"
        internal System.Windows.Controls.Label viewup;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\WindowPosition.xaml"
        internal System.Windows.Controls.Label viewdown;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\WindowPosition.xaml"
        internal System.Windows.Controls.Label viewleft;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WindowPosition.xaml"
        internal System.Windows.Controls.Label viewright;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/windowposition.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowPosition.xaml"
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
            
            #line 4 "..\..\WindowPosition.xaml"
            ((Project.WindowPosition)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.viewposition = ((System.Windows.Controls.Label)(target));
            
            #line 17 "..\..\WindowPosition.xaml"
            this.viewposition.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.viewup = ((System.Windows.Controls.Label)(target));
            
            #line 18 "..\..\WindowPosition.xaml"
            this.viewup.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.viewup_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.viewdown = ((System.Windows.Controls.Label)(target));
            
            #line 19 "..\..\WindowPosition.xaml"
            this.viewdown.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.viewdown_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.viewleft = ((System.Windows.Controls.Label)(target));
            
            #line 20 "..\..\WindowPosition.xaml"
            this.viewleft.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.viewleft_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.viewright = ((System.Windows.Controls.Label)(target));
            
            #line 21 "..\..\WindowPosition.xaml"
            this.viewright.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.viewright_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
