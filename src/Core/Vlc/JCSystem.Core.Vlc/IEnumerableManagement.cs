using System.Collections.Generic;

namespace JCSystem.Core.Vlc
{
    public interface IEnumerableManagement<T>
    {
        int Count { get; }
        T Current { get; set; }
        IEnumerable<T> All { get; }
    }
}
