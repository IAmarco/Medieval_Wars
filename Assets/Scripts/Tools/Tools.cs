using UnityEngine;

namespace Tools
{
    public abstract class Tools : ScriptableObject
    {
        [Header("Visual Elements")]
        public ToolVisual prefab;
        public Sprite image;
        public string toolName;
    }
}