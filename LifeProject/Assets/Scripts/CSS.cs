using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CSS : MonoBehaviour
{
    public List<CharacterCellData> characters = new List<CharacterCellData>();
   
    [SerializeField] GameObject charCellPrefab;

    private void Start()
    {
        foreach (CharacterCellData character in characters)
        {
            SpawnCharacterCell(character);
        }
    }

    /// <summary>
    /// Create a new character cell inside the character selection screen
    /// Set the infos and done
    /// </summary>
    /// <param name="character cell spawn"></param>
    private void SpawnCharacterCell(CharacterCellData character)
    {
        GameObject charCell = Instantiate(charCellPrefab, transform);

        Image charArt = charCell.transform.Find("CharacterArt").GetComponent<Image>();
        TextMeshProUGUI charName = charCell.transform.Find("NameRect").GetComponentInChildren<TextMeshProUGUI>();

        charArt.sprite = character.characterSprite;
        charName.text = character.characterName;

        //Place the artwork correctly
        Vector2 pixelSize = new Vector2(charArt.sprite.texture.width, charArt.sprite.texture.height);
        Vector2 pixelPivot = charArt.sprite.pivot;
        Vector2 uiPivot = new Vector2(pixelPivot.x / pixelSize.x, pixelPivot.y / pixelSize.y);

        charArt.GetComponent<RectTransform>().pivot = uiPivot;

        //Zoom effect
        charArt.GetComponent<RectTransform>().sizeDelta *= character.zoom;
    }
}
