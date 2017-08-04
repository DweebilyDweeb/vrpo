using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_ThrowingWep : Projectile
{
    private Animator anim;
    private GameObject player;
    private AudioSource audio;
    bool playedSound = false;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(player.transform);
	}

    public void Init(Vector3 vel)
    {
        //GetComponent<Rigidbody>().AddForce(vel);
        Rigidbody projectile = GetComponent<Rigidbody>();
        if (projectile.velocity.magnitude < 10.0f)
            projectile.velocity = vel;
    }

    public override void Update()
    {
        base.Update();
        float distFromPlayer = new Vector3(player.transform.position.x - transform.position.x, 0, player.transform.position.z - transform.position.z).magnitude;
        if(distFromPlayer < 10.0f && !playedSound)
        {
            playedSound = true;
            audio.PlayOneShot(Resources.Load<AudioClip>("Sounds/Sword/sword-air-cut"));
        }
    }
	
	private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(-10);
                Destroy(gameObject);
                break;
            case "Boat":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(-10);
                Destroy(gameObject);
                break;
            case "Terrain":
                SetDaggerIdle();
                Destroy(gameObject, 1.0f);
                break;
            case "Water":
                // Spawn particle effects
                transform.position += new Vector3(0, -3, 0);
                Destroy(gameObject, 1.0f);
                break;
        }
    }

    private void SetDaggerIdle()
    {
        anim.SetTrigger("Idle");
        GetComponent<Rigidbody>().freezeRotation = false;
    }
}
