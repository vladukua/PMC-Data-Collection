using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PmcDataCollection
{
    public class Position1D<T> : IEnumerable<Point1D<T>> where T : struct
    {
        #region Private Fields

        private readonly List<Point1D<T>> _points;

        #endregion

        public Position1D()
        {
            _points = new List<Point1D<T>>();
        }

        public void AddPoint(Point1D<T> point)
        {
            _points.Add(point);
        }

        public void AddRange(IEnumerable<Point1D<T>> points)
        {
            _points.AddRange(points);
        }

        public Point1D<T> this[int i]
        {
            get { return _points[i]; }
        }

        public int Count
        {
            get { return _points.Count; }
        }

        public bool Empty
        {
            get { return _points.Count == 0; }
        }

        #region IEnumerable Members

        public IEnumerator<Point1D<T>> GetEnumerator()
        {
            return _points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _points.GetEnumerator();
        }

        #endregion
    }

    public class Position2D<T> : IEnumerable<Point2D<T>> where T : struct
    {
        #region Private Fields

        private readonly List<Point2D<T>> _points;

        #endregion

        public Position2D()
        {
            _points = new List<Point2D<T>>();
        }

        public void AddPoint(Point2D<T> point)
        {
            _points.Add(point);
        }

        public void AddRange(IEnumerable<Point2D<T>> points)
        {
            _points.AddRange(points);
        }

        public Point2D<T> this[int i]
        {
            get { return _points[i]; }
        }

        public int Count
        {
            get { return _points.Count; }
        }

        public bool Empty
        {
            get { return _points.Count == 0; }
        }

        #region IEnumerable Members

        public IEnumerator<Point2D<T>> GetEnumerator()
        {
            return _points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _points.GetEnumerator();
        }

        #endregion
    }

    public class Position3D<T> : IEnumerable<Point3D<T>> where T : struct
    {
        #region Private Fields

        private readonly List<Point3D<T>> _points;

        #endregion

        public Position3D(int pointCount)
        {
            _points = new List<Point3D<T>>(pointCount);
        }

        public void AddPoint(Point3D<T> point)
        {
            if (_points.Count + 1 > _points.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            _points.Add(point);
        }

        public void AddRange(IEnumerable<Point3D<T>> points)
        {
            if (_points.Count + points.Count() > _points.Capacity)
            {
                throw new IndexOutOfRangeException();
            }

            _points.AddRange(points);
        }

        public Point3D<T> this[int i]
        {
            get { return _points[i]; }
        }

        public int Count
        {
            get { return _points.Count; }
        }

        public bool Empty
        {
            get { return _points.Count == 0; }
        }

        #region IEnumerable Members

        public IEnumerator<Point3D<T>> GetEnumerator()
        {
            return _points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _points.GetEnumerator();
        }

        #endregion
    }
}