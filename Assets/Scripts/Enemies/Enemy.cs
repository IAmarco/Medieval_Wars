using System;
using Characters;
using TMPro;
using Tools;
using UnityEngine;
using UnityEngine.UI;

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
         public Text DialogueText;

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
            //CharacterVisual characterVisual = Instantiate(HealthBar);


            CharacterVisual charEnemyVisual = Instantiate(charEnemy.prefab, positionCharacter);
            Instantiate(toolAttack.prefab, charEnemyVisual.attackPositon);
            Instantiate(toolDefense.prefab, charEnemyVisual.defense);
            DialogueText.text = "An ORC from the Mountain has appeared!!! (press SPACE) " ;
            
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DialogueText.text = "GRR....I've got an AXE! (Drog has been equiped with AXE, Press SPACE, reload F4) " ;
            }
        }
    } 
}

