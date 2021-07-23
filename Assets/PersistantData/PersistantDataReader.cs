using UnityEngine;

namespace PersistantData
{
    public class PersistantDataReader<T> : MonoBehaviour where T : new()
    {
        [SerializeField] private PersistantData<T> persistantData;

        public T Read()
        {
            return persistantData.content;
        }
    }
}