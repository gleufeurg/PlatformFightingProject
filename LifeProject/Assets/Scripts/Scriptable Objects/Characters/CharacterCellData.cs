using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class CharacterCellData : ScriptableObject
{
    public string characterName;
    public Sprite characterSprite;
    [Range(1,10)] public float zoom = 1;
}
