using System;
using System.Collections.Generic;
using UnityEngine;

namespace PersistantData
{
    [CreateAssetMenu(fileName = "Store", menuName = "Data/PersistantStore")]
    public class PersistantStore : ScriptableObject
    {
        private readonly Dictionary<Type, object> _store;

        public PersistantStore()
        {
            _store = new Dictionary<Type, object>();
        }

        public void AddOrUpdate<T>(T value) where T : new()
        {
            _store[typeof(T)] = value;
        }

        public T Get<T>() where T : new()
        {
            return (T) _store[typeof(T)];
        }
    }
}