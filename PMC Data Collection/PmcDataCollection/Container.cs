using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PmcDataCollection
{
    public class Container<T> where T : struct
    {
        #region Private Fields

        private readonly List<Matrix1D<T>> _container1D;
        private readonly List<Matrix2D<T>> _container2D;
        private readonly List<Matrix3D<T>> _container3D;
        private readonly int _countPositionInMatrix;
        private readonly int _countMatrixInContainer;

        #endregion

        #region Constructors

        public Container(int countPositionInMatrix, int countMatrixInContainer)
        {
            _countPositionInMatrix = countPositionInMatrix;
            _countMatrixInContainer = countMatrixInContainer;
            _container1D = new List<Matrix1D<T>>(_countMatrixInContainer);
            _container2D = new List<Matrix2D<T>>(_countMatrixInContainer);
            _container3D = new List<Matrix3D<T>>(_countMatrixInContainer);
        }

        #endregion

        public event Func<object, int, int, int>  CreatedMatrix3D;

        public void Create1DMatrix()
        {
            if (_container1D.Count + _container2D.Count + _container3D.Count + 1
                > _container1D.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            _container1D.Add(new Matrix1D<T>(_countPositionInMatrix));
        }

        public void Create2DMatrix()
        {
            if (_container1D.Count + _container2D.Count + _container3D.Count + 1
                > _container1D.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            _container2D.Add(new Matrix2D<T>(_countPositionInMatrix));
        }

        public void Create3DMatrix()
        {
            if (_container1D.Count + _container2D.Count + _container3D.Count + 1
                > _container1D.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            var matrix = new Matrix3D<T>(_countPositionInMatrix);
            var index = _container3D.Count;
            matrix.Position3DChanged += (cnt) =>
            {
                if (CreatedMatrix3D != null)
                {
                    return CreatedMatrix3D.Invoke(matrix, index, cnt);
                }
                return cnt;
            };
            _container3D.Add(matrix);
        }

        public Matrix1D<T> GetMatrix1D(int index)
        {
            return _container1D[index];
        }

        public Matrix2D<T> GetMatrix2D(int index)
        {
            return _container2D[index];
        }

        public Matrix3D<T> GetMatrix3D(int index)
        {
            return _container3D[index];
        }
    }
}
