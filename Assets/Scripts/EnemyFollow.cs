using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public GameObject myTarget;

    public NavMeshAgent myAgent;

    public int range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(this.transform.position, myTarget.transform.position);
        if (dist < range)
        {
            myAgent.destination = myTarget.transform.position;
        }
    }
}
