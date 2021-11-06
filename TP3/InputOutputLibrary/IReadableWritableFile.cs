using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace InputOutputLibrary
{
    public interface IReadableWritableFile<T>
    {
        public void Export(string path, T entity);
        public void Import(string path, out T entity);
    }
}
