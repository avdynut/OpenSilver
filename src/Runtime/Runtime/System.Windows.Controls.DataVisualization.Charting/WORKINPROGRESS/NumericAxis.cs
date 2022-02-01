#if MIGRATION
namespace System.Windows.Controls.DataVisualization.Charting
{
    [OpenSilver.NotImplemented]
    public abstract class NumericAxis : RangeAxis
    {
        #region public double? Maximum
        /// <summary>
        /// Gets or sets the maximum value plotted on the axis.
        /// </summary>
        //[TypeConverter(typeof(NullableConverter<double>))]
        [OpenSilver.NotImplemented]
        public double? Maximum
        {
            get { return (double?)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        /// <summary>
        /// Identifies the Maximum dependency property.
        /// </summary>
        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(
                "Maximum",
                typeof(double?),
                typeof(NumericAxis),
                new PropertyMetadata(null, OnMaximumPropertyChanged));

        /// <summary>
        /// MaximumProperty property changed handler.
        /// </summary>
        /// <param name="d">NumericAxis that changed its Maximum.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnMaximumPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            NumericAxis source = (NumericAxis)d;
            double? newValue = (double?)e.NewValue;
            source.OnMaximumPropertyChanged(newValue);
        }

        /// <summary>
        /// MaximumProperty property changed handler.
        /// </summary>
        /// <param name="newValue">New value.</param>
        protected virtual void OnMaximumPropertyChanged(double? newValue)
        {
            //this.ProtectedMaximum = newValue;
        }
        #endregion public double? Maximum

        #region public double? Minimum
        /// <summary>
        /// Gets or sets the minimum value to plot on the axis.
        /// </summary>
        //[TypeConverter(typeof(NullableConverter<double>))]
        [OpenSilver.NotImplemented]
        public double? Minimum
        {
            get { return (double?)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        /// <summary>
        /// Identifies the Minimum dependency property.
        /// </summary>
        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register(
                "Minimum",
                typeof(double?),
                typeof(NumericAxis),
                new PropertyMetadata(null, OnMinimumPropertyChanged));

        /// <summary>
        /// MinimumProperty property changed handler.
        /// </summary>
        /// <param name="d">NumericAxis that changed its Minimum.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnMinimumPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            NumericAxis source = (NumericAxis)d;
            double? newValue = (double?)e.NewValue;
            source.OnMinimumPropertyChanged(newValue);
        }

        /// <summary>
        /// MinimumProperty property changed handler.
        /// </summary>
        /// <param name="newValue">New value.</param>
        protected virtual void OnMinimumPropertyChanged(double? newValue)
        {
            //this.ProtectedMinimum = newValue;
        }
        #endregion public double? Minimum
    }
}
#endif
