using LeGrandRestaurant.Db;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace LeGrandRestaurant.Test.Utilities
{
    internal class DatabaseCommandeRepository : IList<ICommande>
    {
        private CommandeManager context;

        public DatabaseCommandeRepository()
        {
            context = new CommandeManager();
            context.Clear();
        }

        /// <inheritdoc />
        public IEnumerator<ICommande> GetEnumerator()
        {
            return context.Get().GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(ICommande item)
        {
            context.Create(item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            context.Clear();
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
