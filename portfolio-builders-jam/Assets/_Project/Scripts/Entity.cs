using UnityEngine;

public class Entity : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] public int health;
    [SerializeField] public int speed;

    [Header("Animation")]
    [SerializeField] public AnimationClip deathAnimation;    
    [HideInInspector] public bool dead;
    
    public int getHealth(){
        return health;
    }

    public bool isDead()
    {
        return dead;
    }

    public virtual void onDeath()
    {
        
    }

    public virtual void attack()
    {
        
    }

    public void takeDamage(int damage){
        health -= damage;
        if (health < 0)
        {
            dead = true;
            health = 0;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
