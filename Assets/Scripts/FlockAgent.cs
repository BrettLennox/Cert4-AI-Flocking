using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class FlockAgent : MonoBehaviour
{
    #region Variables
    Flock agentFlock;

    private Collider2D _agentCollider;
    #endregion
    #region Properties
    public Collider2D AgentCollider { get => _agentCollider; }
    #endregion

    // Start is called before the first frame update
    void Start() => _agentCollider = GetComponent<Collider2D>();

    public void Initialise(Flock flock)
    {
        agentFlock = flock;
    }

    public void Move(Vector2 velocity)
    {
        transform.up = velocity.normalized; //rotate the ai
        transform.position += (Vector3)velocity * Time.deltaTime;
    }
}
