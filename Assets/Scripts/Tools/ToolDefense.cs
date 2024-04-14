using UnityEngine;

namespace Tools
{
    [CreateAssetMenu(menuName = "Tool/Defense", fileName = "ToolDefense")]
    public class ToolDefense : Tools
    {
        [Header("Defense Points")]
        public float defensePoints;
    }
}