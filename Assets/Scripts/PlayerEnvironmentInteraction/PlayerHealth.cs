using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	
	public int maxHealth=100;
	private int currentHealth;
	public GameObject gameManager;
	private bool dead;
	
	void Start() {
		currentHealth = maxHealth;
		dead = false;
	}

	public void decreaseHealth(int amount) {
		currentHealth -= amount;
		if (currentHealth <= 0) {
			dead = true;
		}
	}

	public void increaseHealth(int amount) {
		currentHealth += amount;
	}

	public int getHealth() {
		return currentHealth;
	}

	public int getMaxHealth() {
		return maxHealth;
	}
}
