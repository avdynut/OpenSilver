﻿#if WORKINPROGRESS

#if !MIGRATION
using Windows.Foundation;
#endif

#if MIGRATION
namespace System.Windows.Media.Animation
#else
namespace Windows.UI.Xaml.Media.Animation
#endif
{
    /// <summary>
    /// Defines an animation segment with its own target value and interpolation method
    /// for a <see cref="PointAnimationUsingKeyFrames"/>.
    /// </summary>
    public abstract class PointKeyFrame : DependencyObject, IKeyFrame
    {
        public static readonly DependencyProperty KeyTimeProperty =
            DependencyProperty.Register("KeyTime",
                                        typeof(KeyTime),
                                        typeof(PointKeyFrame),
                                        new PropertyMetadata(null));

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value",
                                        typeof(Point),
                                        typeof(PointKeyFrame),
                                        new PropertyMetadata(new Point()));

        /// <summary>
        /// Initializes a new instance of the <see cref="PointKeyFrame"/>
        /// class.
        /// </summary>
        protected PointKeyFrame()
        {

        }

        /// <summary>
        /// Gets or sets the time at which the key frame's target <see cref="PointKeyFrame.Value"/> 
        /// should be reached.
        /// </summary>
        /// <returns>
        /// The time at which the key frame's current value should be equal to its <see cref="PointKeyFrame.Value"/>
        /// property. The default is null.
        /// </returns>
        public KeyTime KeyTime
        {
            get { return (KeyTime)this.GetValue(KeyTimeProperty); }
            set { this.SetValue(KeyTimeProperty, value); }
        }

        /// <summary>
        /// Gets or sets the key frame's target value.
        /// </summary>
        /// <returns>
        /// The key frame's target value, which is the value of this key frame at its specified
        /// <see cref="PointKeyFrame.KeyTime"/>. The default is 0.
        /// </returns>
        public Point Value
        {
            get { return (Point)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        object IKeyFrame.Value
        {
            get { return this.Value; }
            set { this.Value = (Point)value; }
        }
    }
}

#endif
