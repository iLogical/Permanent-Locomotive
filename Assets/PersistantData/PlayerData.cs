using UnityEngine;

namespace PersistantData
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/PlayerData")]
    public class PlayerData : PersistantData<PlayerData.Content>
    {
        public PlayerData(Content content) : base(content)
        {
        }

        public class Content
        {
            public string Field1 { get; set; }
        }
    }
}