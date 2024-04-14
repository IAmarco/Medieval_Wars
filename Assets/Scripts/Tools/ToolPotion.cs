using UnityEngine;

namespace Tools
{
    [CreateAssetMenu(menuName = "Tool/Potion", fileName = "ToolPotion")]
    public class ToolPotion : Tools
    {
        
    }

    public class ToolPotionHealth : ToolPotion
    {
        public float healthPoints;
    }

    public class ToolPotionSpeed : ToolPotion
    {
        public float speedPoints;
    }
}