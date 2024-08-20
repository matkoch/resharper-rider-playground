using System.Collections.Concurrent;

namespace RSRD242;

class EqualityAnalysis
{
    class SuspiciousEquality
    {
        void M()
        {
            var cache = new Dictionary<Payload, ProcessingResult>();
        }

        record Payload(
            string Header,
            int[] Bytes);

        record ProcessingResult;
    }

    class InefficientRuntime1
    {
        void M()
        {
            var labels = new Dictionary<MyPoint, string>(); // warn
        }

        struct MyPoint
        {
            public int X, Y;

            // по Equals/GetHashCode overrides
        }
    }

    class InefficientRuntime2
    {
        void M()
        {
            var id = 0;

            var idToData = new ConcurrentDictionary<int, Data>();

            // ConcurrentDictionary<TKey, TValue>.AddOrUpdate implementation
            // actually checks TValue for being equal on update:
            idToData.AddOrUpdate(
                key: id,
                // compute what to add
                addValueFactory: static id => default,
                // do the update
                updateValueFactory: static (id, data) => data);
        }

        struct Data
        {
            // no Equals/GetHashCode overrides
        }
    }

    class InefficientRuntime3
    {
        void M<T>([DefaultEqualityUsage] T obj)
        {
            var data = new Data();
            M(data);
        }

        struct Data;
    }
}
