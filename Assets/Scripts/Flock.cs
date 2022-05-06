using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour
{
    #region Variables
    public FlockAgent agent;
    public List<FlockAgent> agents;

    [Range(1f, 100f)]
    public int startingCount = 250;
    public float agentDensity = 0.08f;

    [Range(1f, 100f)]
    public float driveFactor = 10f;
    [Range(1f, 100f)]
    public float maxSeed = 5f;
    [Range(1f, 10f)]
    public float neighbourRadius = 1.5f;
    [Range(0f, 1f)]
    public float avoidanceRadiusMultiplier;

    float _squareMaxSpeed;
    float _squareNeighbourRadius;
    float _squareAvoidanceRadius;
    #endregion
}
