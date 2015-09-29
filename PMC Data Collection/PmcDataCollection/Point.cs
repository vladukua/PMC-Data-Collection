namespace PmcDataCollection
{
    public class Point1D<T> where T : struct
    {
        #region Private Fields

        private readonly T _x;

        #endregion

        #region Public Constructors

        public Point1D(T x)
        {
            this._x = x;
        }

        public Point1D(Point1D<T> point)
        {
            this._x = point.X;
        }

        #endregion

        #region Public Properties

        public T X { get { return _x; } }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return string.Format("X = {0}", X);
        }

        #endregion
    }

    public class Point2D<T> where T : struct
    {
        #region Private Fields

        private readonly T _x;
        private readonly T _y;

        #endregion

        #region Public Constructors

        public Point2D(T x, T y)
        {
            this._x = x;
            this._y = y;
        }

        public Point2D(Point2D<T> point)
        {
            this._x = point.X;
            this._y = point.Y;
        }

        #endregion

        #region Public Properties

        public T X
        {
            get { return _x; }
        }

        public T Y
        {
            get { return _y; }
        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return string.Format("X = {0}   Y = {1}", X, Y);
        }

        #endregion
    }

    public class Point3D<T> where T : struct
    {
        #region Private Fields

        private readonly T _x;
        private readonly T _y;
        private readonly T _z;

        #endregion

        #region Public Constructors

        public Point3D(T x, T y, T z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public Point3D(Point3D<T> point)
        {
            this._x = point.X;
            this._y = point.Y;
            this._z = point.Z;
        }

        #endregion

        #region Public Properties

        public T X
        {
            get { return _x; }
        }

        public T Y
        {
            get { return _y; }
        }

        public T Z
        {
            get { return _z; }
        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return string.Format("X = {0}   Y = {1}   Z = {2}", X, Y, Z);
        }

        #endregion
    }
}
