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


#if WORKINPROGRESS

using System;

#if MIGRATION
namespace System.Windows.Controls
#else
namespace Windows.UI.Xaml.Controls
#endif
{
    public partial class DataGridColumn
    {
        /// <summary>
        /// Gets or sets a property name, or a period-delimited hierarchy of property names, that indicates the member to sort by.
        /// </summary>
        /// <returns>
        /// The path to the data-item member to sort by.
        /// </returns>
        public string SortMemberPath { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the user can change the column display position by dragging the column header.
        /// </summary>
        /// <returns>
        /// true if the user can drag the column header to a new position; otherwise, false.
        /// The default is the current <see cref="P:System.Windows.Controls.DataGrid.CanUserReorderColumns" /> property value.
        /// </returns>
        public bool CanUserReorder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the user can adjust the column width using the mouse.
        /// </summary>
        /// <returns>
        /// true if the user can resize the column; false if the user cannot resize the column.
        /// The default is the current <see cref="P:System.Windows.Controls.DataGrid.CanUserResizeColumns" /> property value.
        /// </returns>
        public bool CanUserResize
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the user can sort the column by clicking the column header.
        /// </summary>
        /// <returns>
        /// true if the user can sort the column; false if the user cannot sort the column.
        /// The default is the current <see cref="P:System.Windows.Controls.DataGrid.CanUserSortColumns" /> property value.
        /// </returns>
        public bool CanUserSort
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the minimum column width in pixels.
        /// </summary>
        /// <returns>
        /// The minimum column width in pixels, or 0 if the value is not set. The default is 0.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// When setting this property, the specified value is less than 0.-or-The specified value is
        /// greater than the <see cref="P:System.Windows.Controls.DataGridColumn.MaxWidth" />.
        /// -or-The specified value is greater than the <see cref="P:System.Windows.Controls.DataGrid.MaxColumnWidth" />
        /// and the <see cref="P:System.Windows.Controls.DataGridColumn.MaxWidth" /> is not set.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// The specified value is <see cref="F:System.Double.NaN" />.
        /// -or-The specified value is <see cref="F:System.Double.PositiveInfinity" />.
        /// </exception>
        public double MinWidth
        {
            get; set;
        }

        public double ActualWidth
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the maximum column width in pixels.
        /// </summary>
        /// <returns>
        /// The maximum column width in pixels. The default is <see cref="F:System.Double.PositiveInfinity" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// When setting this property, the specified value is less than 0.
        /// -or-The specified value is less than the <see cref="P:System.Windows.Controls.DataGridColumn.MinWidth" />.
        /// -or-The specified value is less than the <see cref="P:System.Windows.Controls.DataGrid.MinColumnWidth" />
        /// and the <see cref="P:System.Windows.Controls.DataGridColumn.MinWidth" /> is not set.
        /// </exception>
        public double MaxWidth
        {
            get; set;
        }
    }
}
#endif