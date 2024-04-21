using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BattleState{START, PLAYER, ENEMYTURN, WON, LOST}
public class BattleSystem : MonoBehaviour
{
    public Text DialogueText;
    public BattleState state;
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        
    }
 
}
