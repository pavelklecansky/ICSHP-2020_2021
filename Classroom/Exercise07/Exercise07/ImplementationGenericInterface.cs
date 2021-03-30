using System;

namespace Exercise07
{
    public class ImplementationGenericInterface<T> : IComparable where T : IEquatable<int>
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}