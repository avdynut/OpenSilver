﻿
/*===================================================================================
* 
*   Copyright (c) Userware/OpenSilver.net
*      
*   This file is part of the OpenSilver Runtime (https://opensilver.net), which is
*   licensed under the MIT license: https://opensource.org/licenses/MIT
*   
*   As stated in the MIT license, "the above copyright notice and this permission
*   notice shall be included in all copies or substantial portions of the Software."
*  
\*====================================================================================*/

using System.Diagnostics;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Media;
using CSHTML5.Internal;
using OpenSilver.Internal;

namespace System.Windows.Controls
{
    /// <summary>
    /// Defines an area within which you can explicitly position child objects, using
    /// coordinates that are relative to the Canvas area.
    /// </summary>
    /// <example>
    /// You can add a Canvas to the XAML as follows:
    /// <code lang="XAML" xml:space="preserve">
    /// <Canvas Width="100"
    ///         Height="100"
    ///         Background="Blue"
    ///         HorizontalAlignment="Left">
    ///         <!-- Children here. -->
    /// </Canvas>
    /// </code>
    /// Or in C#:
    /// <code lang="C#">
    /// Canvas myCanvas = new Canvas();
    /// myCanvas.Width = 100;
    /// myCanvas.Height = 100;
    /// myCanvas.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
    /// myCanvas.HorizontalAlignment=HorizontalAlignment.Left;
    /// </code>
    /// </example>
    public partial class Canvas : Panel
    {
        /// <summary>
        /// Identifies the Canvas.Left attached property.
        /// </summary>
        public static readonly DependencyProperty LeftProperty =
            DependencyProperty.RegisterAttached(
                "Left",
                typeof(double),
                typeof(UIElement),
                new FrameworkPropertyMetadata(0.0, OnPositioningChanged));

        /// <summary>
        /// Sets the value of the Canvas.Left XAML attached property for a target element.
        /// </summary>
        /// <param name="element">The object to which the property value is written.</param>
        /// <param name="value">The value to set.</param>
        public static void SetLeft(UIElement element, double value) => element.SetValue(LeftProperty, value);

        /// <summary>
        /// Gets the value of the Canvas.Left XAML attached property for the target element.
        /// </summary>
        /// <param name="element">The object from which the property value is read.</param>
        /// <returns>The Canvas.Left XAML attached property value of the specified object.</returns>
        public static double GetLeft(UIElement element) => (double)element.GetValue(LeftProperty);

        /// <summary>
        /// Identifies the Canvas.Top attached property.
        /// </summary>
        public static readonly DependencyProperty TopProperty =
            DependencyProperty.RegisterAttached(
                "Top",
                typeof(double),
                typeof(UIElement),
                new FrameworkPropertyMetadata(0d, OnPositioningChanged));

        /// <summary>
        /// Sets the value of the Canvas.Top XAML attached property for a target element.
        /// </summary>
        /// <param name="element">The object to which the property value is written.</param>
        /// <param name="value">The value to set.</param>
        public static void SetTop(UIElement element, double value) => element.SetValue(TopProperty, value);

        /// <summary>
        /// Gets the value of the Canvas.Top XAML attached property for the target element.
        /// </summary>
        /// <param name="element">The object from which the property value is read.</param>
        /// <returns>The Canvas.Top XAML attached property value of the specified object.</returns>
        public static double GetTop(UIElement element) => (double)element.GetValue(TopProperty);

        private static void OnPositioningChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement uie
                && VisualTreeHelper.GetParent(uie) is Canvas p)
            {
                p.InvalidateArrange();
            }
        }

        /// <summary>
        /// Identifies the Canvas.ZIndex attached property.
        /// </summary>
        public static readonly DependencyProperty ZIndexProperty =
            DependencyProperty.RegisterAttached(
                "ZIndex",
                typeof(int),
                typeof(UIElement),
                new PropertyMetadata(0)
                {
                    MethodToUpdateDom2 = static (d, oldValue, newValue) => ((UIElement)d).SetZIndex((int)newValue),
                });

        /// <summary>
        /// Sets the value of the Canvas.ZIndex XAML attached property for a target element.
        /// </summary>
        /// <param name="element">The object to which the property value is written.</param>
        /// <param name="value">The value to set.</param>
        public static void SetZIndex(UIElement element, int value) => element.SetValue(ZIndexProperty, value);

        /// <summary>
        /// Gets the value of the Canvas.ZIndex XAML attached property for the target element.
        /// </summary>
        /// <param name="element">The object from which the property value is read.</param>
        /// <returns>The Canvas.ZIndex XAML attached property value of the specified object.</returns>
        public static int GetZIndex(UIElement element) => (int)element.GetValue(ZIndexProperty);

        protected override Size MeasureOverride(Size availableSize)
        {
            var childConstraint = new Size(double.PositiveInfinity, double.PositiveInfinity);

            UIElement[] childrens = Children.ToArray();
            foreach (UIElement child in childrens)
            {
                child.Measure(childConstraint);
            }

            return new Size();
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            UIElement[] childrens = Children.ToArray();
            foreach (UIElement child in childrens)
            {
                double x = GetLeft(child).DefaultIfNaN(0);
                double y = GetTop(child).DefaultIfNaN(0);

                child.Arrange(new Rect(new Point(x, y), child.DesiredSize));
            }

            return finalSize;
        }

        internal override Rect? GetLayoutClip(Size layoutSlotSize)
        {
            if (ClipToBounds)
            {
                return new Rect(RenderSize);
            }
            else
            {
                return null;
            }
        }
    }
}
