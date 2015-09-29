using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmcDataCollection
{
    public class Containers<T> where T : struct
    {
        #region Private Fields

        private readonly List<Container<T>> _containers;
        private readonly int _matrixCountInContainers;
        private readonly int _positionCountInMatrix;
        private Dictionary<int, int> _matrix3DSizeCatche;

        #endregion

        #region Constructors

        public Containers(int matrixCountInContainers, int positionCountInMatrix)
        {
            _matrixCountInContainers = matrixCountInContainers;
            _positionCountInMatrix = positionCountInMatrix;
            _containers = new List<Container<T>>();
            _matrix3DSizeCatche = new Dictionary<int, int>();
        }

        #endregion

        public void AddContainer()
        {
            var container = new Container<T>(_positionCountInMatrix, _matrixCountInContainers);
            container.CreatedMatrix3D += this.ResolveSizeFor3DMatrix;
            _containers.Add(container);
        }

        public Container<T> this[int index]
        {
            get { return _containers[index]; }
        }

        private int ResolveSizeFor3DMatrix(object sender, int e, int count)
        {
            if (!_matrix3DSizeCatche.ContainsKey(e))
            {
                _matrix3DSizeCatche[e] = count;              
            }
            return _matrix3DSizeCatche[e];
        }
    }
}
