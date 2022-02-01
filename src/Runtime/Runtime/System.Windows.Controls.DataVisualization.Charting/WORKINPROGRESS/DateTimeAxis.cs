#if MIGRATION
namespace System.Windows.Controls.DataVisualization.Charting
{
    [OpenSilver.NotImplemented]
    public class DateTimeAxis : RangeAxis
    {
        #region public double? Interval
        /// <summary>
        /// Gets or sets the axis interval.
        /// </summary>
        //[TypeConverter(typeof(NullableConverter<double>))]
        [OpenSilver.NotImplemented]
        public double? Interval
        {
            get { return (double?)GetValue(IntervalProperty); }
            set { SetValue(IntervalProperty, value); }
        }

        /// <summary>
        /// Identifies the Interval dependency property.
        /// </summary>
        public static readonly DependencyProperty IntervalProperty =
            DependencyProperty.Register(
                "Interval",
                typeof(double?),
                typeof(DateTimeAxis),
                new PropertyMetadata(null, OnIntervalPropertyChanged));

        /// <summary>
        /// IntervalProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxis2 that changed its Interval.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnIntervalPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxis source = (DateTimeAxis)d;
            source.OnIntervalPropertyChanged();
        }

        /// <summary>
        /// IntervalProperty property changed handler.
        /// </summary>
        private void OnIntervalPropertyChanged()
        {
            //Invalidate();
        }
        #endregion public double? Interval

        #region public DateTimeIntervalType IntervalType
        /// <summary>
        /// Gets or sets the interval to use for the axis.
        /// </summary>
        [OpenSilver.NotImplemented]
        public DateTimeIntervalType IntervalType
        {
            get { return (DateTimeIntervalType)GetValue(IntervalTypeProperty); }
            set { SetValue(IntervalTypeProperty, value); }
        }

        /// <summary>
        /// Identifies the InternalIntervalType dependency property.
        /// </summary>
        public static readonly DependencyProperty IntervalTypeProperty =
            DependencyProperty.Register(
                "IntervalType",
                typeof(DateTimeIntervalType),
                typeof(DateTimeAxis),
                new PropertyMetadata(DateTimeIntervalType.Auto, OnIntervalTypePropertyChanged));

        /// <summary>
        /// IntervalTypeProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxis that changed its InternalIntervalType.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnIntervalTypePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxis source = (DateTimeAxis)d;
            DateTimeIntervalType newValue = (DateTimeIntervalType)e.NewValue;
            source.OnIntervalTypePropertyChanged(newValue);
        }

        /// <summary>
        /// IntervalTypeProperty property changed handler.
        /// </summary>
        /// <param name="newValue">New value.</param>
        private void OnIntervalTypePropertyChanged(DateTimeIntervalType newValue)
        {
            //this.ActualIntervalType = newValue;
            //Invalidate();
        }
        #endregion public DateTimeIntervalType IntervalType

        #region public DateTime? Maximum
        /// <summary>
        /// Gets or sets the maximum value plotted on the axis.
        /// </summary>
        //[TypeConverter(typeof(NullableConverter<DateTime>))]
        [OpenSilver.NotImplemented]
        public DateTime? Maximum
        {
            get { return (DateTime?)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        /// <summary>
        /// Identifies the Maximum dependency property.
        /// </summary>
        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(
                "Maximum",
                typeof(DateTime?),
                typeof(DateTimeAxis),
                new PropertyMetadata(null, OnMaximumPropertyChanged));

        /// <summary>
        /// MaximumProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxis2 that changed its Maximum.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnMaximumPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxis source = (DateTimeAxis)d;
            DateTime? newValue = (DateTime?)e.NewValue;
            source.OnMaximumPropertyChanged(newValue);
        }

        /// <summary>
        /// MaximumProperty property changed handler.
        /// </summary>
        /// <param name="newValue">New value.</param>
        private void OnMaximumPropertyChanged(DateTime? newValue)
        {
            //this.ProtectedMaximum = newValue;
        }
        #endregion public DateTime? Maximum

        #region public DateTime? Minimum
        /// <summary>
        /// Gets or sets the minimum value to plot on the axis.
        /// </summary>
        //[TypeConverter(typeof(NullableConverter<DateTime>))]
        [OpenSilver.NotImplemented]
        public DateTime? Minimum
        {
            get { return (DateTime?)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        /// <summary>
        /// Identifies the Minimum dependency property.
        /// </summary>
        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register(
                "Minimum",
                typeof(DateTime?),
                typeof(DateTimeAxis),
                new PropertyMetadata(null, OnMinimumPropertyChanged));

        /// <summary>
        /// MinimumProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxis2 that changed its Minimum.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnMinimumPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxis source = (DateTimeAxis)d;
            DateTime? newValue = (DateTime?)e.NewValue;
            source.OnMinimumPropertyChanged(newValue);
        }

        /// <summary>
        /// MinimumProperty property changed handler.
        /// </summary>
        /// <param name="newValue">New value.</param>
        private void OnMinimumPropertyChanged(DateTime? newValue)
        {
            //this.ProtectedMinimum = newValue;
        }
        #endregion public DateTime? Minimum
    }
}
#endif
