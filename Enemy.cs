using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public Transform player;
	private Rigidbody2D rb;
	private Vector2 movement;
	public float moveSpeed = 5f;
	private bool inrange = false;
	[SerializeField] private float atackDamage = 10f;
	public int health = 1;
	void Start()
	{
		rb = this.GetComponent<Rigidbody2D>();
	}
	void Update()
	{
			Vector3 direction = player.position - transform.position;
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			direction.Normalize();
			movement = direction;
	}
	private void FixedUpdate()
	{
		moveCharactar(movement);
	}
	void moveCharactar(Vector2 direction)
	{
		rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.gameObject.tag == "Bullet")
		{
			Destroy(gameObject);
		}
	}
    private void OnCollisionStay2D(Collision2D other)
	{
		if (other.gameObject.name == "Player")
        {
			inrange = true;
		}
		if (other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponent<playerhealth>().UpdateHealth(-atackDamage);
		}
	}
    private void OnCollisionExit2D(Collision2D collision)
    {
		if (collision.gameObject.name == "Player")
		{
			inrange = false;
		}
	}
	public void TakeDamage(int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}
	void Die()
	{
		Destroy(gameObject);
	}
}	