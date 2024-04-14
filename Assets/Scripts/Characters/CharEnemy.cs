using UnityEngine;

namespace Characters
{
    [CreateAssetMenu(fileName = "CharEnemy", menuName = "CharEnemy")]
    public class CharEnemy : ScriptableObject
    {
        [Header("Visual Elements")]
        public CharacterVisual prefab;
        public Sprite image;
    }
}
