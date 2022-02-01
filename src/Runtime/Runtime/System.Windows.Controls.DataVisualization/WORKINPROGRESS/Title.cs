#if MIGRATION
namespace System.Windows.Controls.DataVisualization
{
    /// <summary>
    /// Represents the title of a data visualization control.
    /// </summary>
    /// https://github.com/microsoftarchive/SilverlightToolkit/blob/master/Release/Silverlight5/Source/Controls.DataVisualization.Toolkit/Title/Title.cs
    [OpenSilver.NotImplemented]
    public partial class Title : ContentControl
    {
#if !SILVERLIGHT
        /// <summary>
        /// Initializes the static members of the Title class.
        /// </summary>
        static Title()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Title), new FrameworkPropertyMetadata(typeof(Title)));
        }

#endif
        /// <summary>
        /// Initializes a new instance of the Title class.
        /// </summary>
        public Title()
        {
#if SILVERLIGHT
            DefaultStyleKey = typeof(Title);
#endif
        }
    }
}
#endif
