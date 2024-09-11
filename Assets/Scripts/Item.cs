using UnityEngine;

namespace DefaultNamespace
{
    public class Item : MonoBehaviour, IInfiniteItem
    {
        public int Id;
        public int ID => Id;
    }

    public interface IInfiniteItem  
    {
        int ID { get; }
    }
}