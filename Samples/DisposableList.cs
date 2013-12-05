using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public.Dac.Samples
{
    /// <summary>
    /// Utility class for tracking and disposing of objects that implement IDisposable.
    /// </summary>
    public sealed class DisposableList : List<IDisposable>, IDisposable
    {
        /// <summary>
        /// Disposes of all elements of list.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Internal implementation of Dispose logic.
        /// </summary>
        private void Dispose(bool isDisposing)
        {
            foreach (IDisposable disposable in this)
            {
                disposable.Dispose();
            }
        }

        /// <summary>
        /// Add an item to the list.
        /// </summary>
        public T Add<T>(T item) where T : IDisposable
        {
            base.Add(item);

            return item;
        }
    }
}
