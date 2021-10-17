using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class BradAgent : Agent
{
    [SerializeField]
    private Transform targetTransform;

    public override void OnEpisodeBegin()
    {
        transform.localPosition = Vector3.zero;
        targetTransform.localPosition = new Vector3(Random.Range(-3.5f, 3.5f), 0, Random.Range(-3.5f, 3.5f));
        //targetTransform = GameObject.FindGameObjectWithTag("Goal").transform;
    }    

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(targetTransform.localPosition);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX = actions.ContinuousActions[0];
        float moveZ = actions.ContinuousActions[1];

        float moveSpeed = 1f;
        transform.localPosition += new Vector3(moveX, 0, moveZ) * Time.deltaTime * moveSpeed;
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal")
        {
            SetReward(+1f);
            //targetTransform = GameObject.FindGameObjectWithTag("Goal").transform;
            EndEpisode();
        }
        if (other.tag == "Wall")
        {
            SetReward(-1f);
            EndEpisode();
        }
    }
}