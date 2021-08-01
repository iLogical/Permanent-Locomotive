using PersistantData;
using UnityEngine;

namespace Player
{
    public class Player: MonoBehaviour
    {
        [SerializeField] private PersistantStore persistantStore;

        public Player()
        {
        }
    }
}