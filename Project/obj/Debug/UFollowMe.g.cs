﻿#pragma checksum "..\..\UFollowMe.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EEE305F79DBC08407FED238F43FFCB08"
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
    /// UFollowMe
    /// </summary>
    public partial class UFollowMe : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\UFollowMe.xaml"
        internal System.Windows.Controls.MediaElement mymedia;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\UFollowMe.xaml"
        internal System.Windows.Controls.Image myimage;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UFollowMe.xaml"
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UFollowMe.xaml"
        internal System.Windows.Controls.TextBox djtextbox;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/ufollowme.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UFollowMe.xaml"
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
            
            #line 5 "..\..\UFollowMe.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mymedia = ((System.Windows.Controls.MediaElement)(target));
            
            #line 12 "..\..\UFollowMe.xaml"
            this.mymedia.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.mymedia_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.myimage = ((System.Windows.Controls.Image)(target));
            
            #line 13 "..\..\UFollowMe.xaml"
            this.myimage.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.myimage_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.djtextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
