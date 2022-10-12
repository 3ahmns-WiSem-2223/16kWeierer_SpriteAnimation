using UnityEngine;

public class SpriteAnim : MonoBehaviour
{
    [SerializeField] private Sprite[] idle;

	private void Start()
	{
		Debug.Log("Anzahl Elemente: " + idle.Length);
	}
}
