﻿#pragma checksum "..\..\Stylo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1C954034CC178881FBC003356493A9AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using FeuilleMagique;
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


namespace FeuilleMagique {
    
    
    /// <summary>
    /// Stylo
    /// </summary>
    public partial class Stylo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Stylo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDossier;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Stylo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPageSuivante;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Stylo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPagePrecedente;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Stylo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Stylo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NouvellePage;
        
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
            System.Uri resourceLocater = new System.Uri("/FeuilleMagique;component/stylo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Stylo.xaml"
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
            this.buttonDossier = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Stylo.xaml"
            this.buttonDossier.Click += new System.Windows.RoutedEventHandler(this.buttonDossier_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonPageSuivante = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Stylo.xaml"
            this.buttonPageSuivante.Click += new System.Windows.RoutedEventHandler(this.buttonPageSuivante_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonPagePrecedente = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Stylo.xaml"
            this.buttonPagePrecedente.Click += new System.Windows.RoutedEventHandler(this.buttonPagePrecedente_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.NouvellePage = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Stylo.xaml"
            this.NouvellePage.Click += new System.Windows.RoutedEventHandler(this.NouvellePage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

