﻿#pragma checksum "..\..\..\View\Main.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ACF2F74B5587497515D2A04FC218B6F2B332BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
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
using System.Windows.Shell;
using TeamProject;


namespace TeamProject {
    
    
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlacePracticeBT;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LongScriptPracitceBT;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GameBT;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingBT;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EndBT;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Idtxt;
        
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
            System.Uri resourceLocater = new System.Uri("/TeamProject;component/view/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Main.xaml"
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
            this.PlacePracticeBT = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\View\Main.xaml"
            this.PlacePracticeBT.Click += new System.Windows.RoutedEventHandler(this.PlacePracticeBT_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LongScriptPracitceBT = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\View\Main.xaml"
            this.LongScriptPracitceBT.Click += new System.Windows.RoutedEventHandler(this.LongScriptPracitceBT_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GameBT = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\..\View\Main.xaml"
            this.GameBT.Click += new System.Windows.RoutedEventHandler(this.GameBT_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SettingBT = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\View\Main.xaml"
            this.SettingBT.Click += new System.Windows.RoutedEventHandler(this.SettingBT_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EndBT = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\..\View\Main.xaml"
            this.EndBT.Click += new System.Windows.RoutedEventHandler(this.EndBT_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Idtxt = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

