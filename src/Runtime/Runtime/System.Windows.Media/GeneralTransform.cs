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

namespace System.Windows.Media
{
    /// <summary>
    /// Provides generalized transformation support for objects, such as points and rectangles.
    /// </summary>
    public abstract class GeneralTransform : DependencyObject
    {
        /// <summary>
        /// Transforms the specified point and returns the result.
        /// </summary>
        /// <param name="point">
        /// The point to transform.
        /// </param>
        /// <returns>
        /// The result of transforming point.
        /// </returns>
        public Point TransformPoint(Point point) => Transform(point);

        /// <summary>
        /// Transforms the specified point and returns the result.
        /// </summary>
        /// <param name="point">
        /// The point to transform.
        /// </param>
        /// <returns>
        /// The result of transforming point.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The transform did not succeed.
        /// </exception>
        public Point Transform(Point point)
        {
            if (!TryTransform(point, out Point transformedPoint))
            {
                throw new InvalidOperationException("The transform is not defined for the point.");
            }

            return transformedPoint;
        }

        /// <summary>
        /// When overridden in a derived class, attempts to transform the specified point
        /// and returns a value that indicates whether the transformation was successful.
        /// </summary>
        /// <param name="inPoint">
        /// The point to transform.
        /// </param>
        /// <param name="outPoint">
        /// The result of transforming inPoint.
        /// </param>
        /// <returns>
        /// true if inPoint was transformed; otherwise, false.
        /// </returns>
        public abstract bool TryTransform(Point inPoint, out Point outPoint);

        /// <summary>
        /// When overridden in a derived class, transforms the specified bounding box and
        /// returns an axis-aligned bounding box that is exactly large enough to contain it.
        /// </summary>
        /// <param name="rect">
        /// The bounding box to transform.
        /// </param>
        /// <returns>
        /// The smallest axis-aligned bounding box possible that contains the transformed rect.
        /// </returns>
        public abstract Rect TransformBounds(Rect rect);

        /// <summary>
        /// Gets the inverse transformation of this <see cref="GeneralTransform"/>, if possible.
        /// </summary>
        /// <returns>
        /// An inverse of this instance, if possible; otherwise null.
        /// </returns>
        public abstract GeneralTransform Inverse { get; }
    }
}
