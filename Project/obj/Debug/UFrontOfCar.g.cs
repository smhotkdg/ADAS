﻿#pragma checksum "..\..\UFrontOfCar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "53CAB7C2693E515406853EBF9516AF8D"
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
    /// UFrontOfCar
    /// </summary>
    public partial class UFrontOfCar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\UFrontOfCar.xaml"
        internal System.Windows.Controls.Label MyFontOfCar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UFrontOfCar.xaml"
        internal System.Windows.Controls.Label t1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UFrontOfCar.xaml"
        internal System.Windows.Controls.Label MyFontOfCarSpeed;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UFrontOfCar.xaml"
        internal System.Windows.Controls.Label t2;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/ufrontofcar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UFrontOfCar.xaml"
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
            
            #line 4 "..\..\UFrontOfCar.xaml"
            ((Project.UFrontOfCar)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MyFontOfCar = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.t1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.MyFontOfCarSpeed = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.t2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}