using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Damage { get; private set; }

	public Enemy()
	{
		Damage = 10;
	}
}