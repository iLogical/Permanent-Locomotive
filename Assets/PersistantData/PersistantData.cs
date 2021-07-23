using UnityEngine;

namespace PersistantData
{
    public abstract class PersistantData<T> : ScriptableObject where T : new()
    {
        public T content;

        protected PersistantData(T content)
        {
            this.content = content;
        }
    }
}