using UnityEngine;

namespace PersistantData
{
    public class PersistantDataWriter<T> : MonoBehaviour where T : new()
    {
        [SerializeField] private PersistantData<T> persistantData;

        public void Write(T data)
        {
            persistantData.content = data;
        }
    }
}