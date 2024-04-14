using UnityEngine;

namespace Tools
{
    [CreateAssetMenu(menuName = "Tool/Attack", fileName = "ToolAttack")]
    public class ToolAttack : Tools
    {
        [Header("Attack Points")]
        public float attackPoints;
    }
}