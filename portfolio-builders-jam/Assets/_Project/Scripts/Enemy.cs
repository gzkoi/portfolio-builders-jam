using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : Entity
{
    [Header("Enemy Exclusive Stats")]
    [SerializeField] public int contactDMG;
    [SerializeField] public int enemyScore;

    [Header("Enemy Animation")]
    [SerializeField] Animator animator;
    [SerializeField] public float visionRange,attackRange;
    state currentState;
    private NavMeshAgent navMeshAgent;
    private enum state{attack,chase,idle,dead};
    


    [Header("Attack")]
    [SerializeField] public int attackDMG;


    void Start()
    {
        //Initialize attacks
        currentState = state.idle;
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public override void onDeath()
    {
        //Send enemy score to the UI
    }



    void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.CompareTag("Player"))
        {
            Entity player = collision.gameObject.GetComponent<Entity>();
            player.takeDamage(contactDMG);
        }
    }
}
