//------------------------------------------------------------------------------
// <copyright company="Microsoft">
//   Copyright 2013 Microsoft
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

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
