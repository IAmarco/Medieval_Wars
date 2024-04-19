using Characters;
using Tools;
using UnityEngine;

namespace Enemies
{
    public class Enemy : MonoBehaviour
    {
        [Header("Data")]
        [SerializeField] private CharEnemy charEnemy ;
        [SerializeField] private ToolAttack toolAttack;
        [SerializeField] private ToolDefense toolDefense;
        [SerializeField] private ToolPotion toolPotion;
        [SerializeField] private int hp ;
        [SerializeField] private int hpmax ;
        [SerializeField] private CharacterVisual HealthBar;

        [Header("Requirements")]
        [SerializeField] private Transform positionCharacter;
        
        public float AttackPoints
        {
            get
            {
                float potionMultiply = 1f;
                if (toolPotion is ToolPotionSpeed potion)
                {
                    potionMultiply = potion.speedPoints;
                }
                return toolAttack.attackPoints * potionMultiply;
            }
        }
        public float Defense => toolDefense.defensePoints;
        
        private void Start()
        {
            CharacterVisual characterVisual = Instantiate(HealthBar);


            CharacterVisual charEnemyVisual = Instantiate(charEnemy.prefab, positionCharacter);
            Instantiate(toolAttack.prefab, charEnemyVisual.attackPositon);
            Instantiate(toolDefense.prefab, charEnemyVisual.defense);
        }
    } 
}

