using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmcDataCollection
{
    public class Matrix1D<T> : IEnumerable<Position1D<T>> where T : struct
    {
        #region Private Fields

        private readonly List<Position1D<T>> _matrix;

        #endregion

        #region Public Constructors

        public Matrix1D(int count)
        {
            _matrix = new List<Position1D<T>>(count);
        }

        #endregion

        #region Public Methods

        public void AddPosition(Position1D<T> position)
        {
            if (_matrix.Count + 1 > _matrix.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            _matrix.Add(position);
        }

        public void CreatePosition()
        {
            if (_matrix.Count + 1 > _matrix.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            _matrix.Add(new Position1D<T>());
        }

        #endregion

        #region Public Properties

        public Position1D<T> this[int i]
        {
            get { return _matrix[i]; }
        }

        public int Count
        {
            get { return _matrix.Count; }

        }

        public bool Empty
        {
            get { return _matrix.Count == 0; }
        }

        #endregion

        #region IEnumerable Members

        public IEnumerator<Position1D<T>> GetEnumerator()
        {
            return _matrix.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _matrix.GetEnumerator();
        }

        #endregion
    }

    public class Matrix2D<T> : IEnumerable<Position2D<T>> where T : struct
    {
        #region Private Fields

        private readonly List<Position2D<T>> _matrix;

        #endregion

        #region Public Constructors

        public Matrix2D(int count)
        {
            _matrix = new List<Position2D<T>>(count);
        }

        #endregion

        #region Public Methods

        public void AddPosition(Position2D<T> position)
        {
            if (_matrix.Count + 1 > _matrix.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            _matrix.Add(position);
        }

        public void CreatePosition()
        {
            if (_matrix.Count + 1 > _matrix.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            _matrix.Add(new Position2D<T>());
        }

        #endregion

        #region Public Properties

        public Position2D<T> this[int i]
        {
            get { return _matrix[i]; }
        }

        public int Count
        {
            get { return _matrix.Count; }

        }

        public bool Empty
        {
            get { return _matrix.Count == 0; }
        }

        #endregion

        #region IEnumerable Members

        public IEnumerator<Position2D<T>> GetEnumerator()
        {
            return _matrix.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _matrix.GetEnumerator();
        }

        #endregion
    }

    public class Matrix3D<T> : IEnumerable<Position3D<T>> where T : struct
    {
        #region Private Fields

        private readonly List<Position3D<T>> _matrix;
        private int? _pointInPositionCount;

        #endregion

        #region Public Constructors

        public event Func<int, int> Position3DChanged;  

        public Matrix3D(int count)
        {
            _matrix = new List<Position3D<T>>(count);
        }

        #endregion

        #region Public Methods

        public void CreatePosition(int count = 100)
        {
            if (_matrix.Count + 1 > _matrix.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            if (_pointInPositionCount == null)
            {
                if (Position3DChanged != null)
                {
                    _pointInPositionCount = Position3DChanged(count);
                }
            }
            _matrix.Add(new Position3D<T>(_pointInPositionCount.Value));
        }

        #endregion

        #region Public Properties

        public Position3D<T> this[int i]
        {
            get { return _matrix[i]; }
        }

        public int Count
        {
            get { return _matrix.Count; }

        }

        public bool Empty
        {
            get { return _matrix.Count == 0; }
        }

        #endregion

        #region IEnumerable Members

        public IEnumerator<Position3D<T>> GetEnumerator()
        {
            return _matrix.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _matrix.GetEnumerator();
        }

        #endregion
    }
}
