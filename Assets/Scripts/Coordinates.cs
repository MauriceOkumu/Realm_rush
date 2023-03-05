using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class Coordinates : MonoBehaviour
{
	
   TMP_Text label;
   Vector2Int coord = new Vector2Int();
   void Awake() {
	 label = GetComponent<TMP_Text>();
	 DisplayCoordinates();
   }
	void Update()
	{
		if(!Application.isPlaying) {
			DisplayCoordinates();
			UpdateName();
		}
	}
	void DisplayCoordinates () 
	{
		coord.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
		coord.y = Mathf.RoundToInt(transform.parent.position.z/ UnityEditor.EditorSnapSettings.move.z);
		label.text = coord.x.ToString()+ "," + coord.y.ToString();
	}
	
	void UpdateName() 
	{
		transform.parent.name = coord.ToString();
	}
}
