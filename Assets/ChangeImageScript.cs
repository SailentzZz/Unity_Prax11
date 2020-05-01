using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageScript : MonoBehaviour
{

	public GameObject gameObjectPanel;
	public GameObject gameObjectImage;
	public Sprite newSprite;

	public void Close()
	{
		gameObjectPanel.SetActive(false);
	}

	public void ChangeImage()
	{
		gameObjectImage.GetComponent<Image>().sprite = newSprite;
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
