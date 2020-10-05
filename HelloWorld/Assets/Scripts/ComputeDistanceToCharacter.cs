using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputeDistanceToCharacter : MonoBehaviour
{
    public GameObject PlayerObject;

    private Animator targetAnimator;
    private float distanceFromPlayer;

    // Start is called before the first frame update
    private void Start()
    {
        targetAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateTargetAnimatorParams();
    }

    private void UpdateTargetAnimatorParams() {
        distanceFromPlayer = Vector3.Distance(transform.position, PlayerObject.transform.position);
        targetAnimator.SetFloat("DistanceFromPlayer", distanceFromPlayer);
        
        Debug.Log(distanceFromPlayer);
    }
}
