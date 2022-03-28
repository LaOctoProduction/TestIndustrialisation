using LeGrandRestaurant.Db;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;

namespace LeGrandRestaurant.Test.Utilities
{
    internal class DatabaseCommandeRepository : IList<ICommande>
    {
        /// <inheritdoc />
        public IEnumerator<ICommande> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(ICommande item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Clear()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool Contains(ICommande item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void CopyTo(ICommande[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool Remove(ICommande item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public int Count { get; }

        /// <inheritdoc />
        public bool IsReadOnly { get; }

        /// <inheritdoc />
        public int IndexOf(ICommande item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Insert(int index, ICommande item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public ICommande this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
