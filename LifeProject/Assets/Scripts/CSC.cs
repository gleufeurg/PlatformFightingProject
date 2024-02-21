using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CSC : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] AudioClip charaPickSound;
    GameObject border;

    private void Start()
    {
        AudioSource source = GetComponent<AudioSource>();
        border = transform.Find("Border").gameObject;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        border.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        border.SetActive(true);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        AudioSource.PlayClipAtPoint(charaPickSound, transform.position);
    }
}
