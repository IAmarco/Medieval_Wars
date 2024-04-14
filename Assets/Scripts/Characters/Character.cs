using UnityEngine;

namespace Characters
{
    [CreateAssetMenu(fileName = "Character", menuName = "Character")]
    public class Character : ScriptableObject
    {
        [Header("Visual Elements")]
        public CharacterVisual prefab;
        public Sprite image;
    }
}