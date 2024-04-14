﻿using System;
using Characters;
using Tools;
using UnityEngine;

namespace Playable
{
    public class Player : MonoBehaviour
    {
        [Header("Data")]
        [SerializeField] private Character character;
        [SerializeField] private ToolAttack toolAttack;
        [SerializeField] private ToolDefense toolDefense;
        [SerializeField] private ToolPotion toolPotion;
        
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
            CharacterVisual characterVisual = Instantiate(character.prefab, positionCharacter);
            Instantiate(toolAttack.prefab, characterVisual.attackPositon);
            Instantiate(toolDefense.prefab, characterVisual.defense);
        }
    }                
}