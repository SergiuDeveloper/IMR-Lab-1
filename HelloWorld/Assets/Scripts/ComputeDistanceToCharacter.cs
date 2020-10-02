using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputeDistanceToCharacter : MonoBehaviour
{
    public GameObject PlayerObject;

    private Animator cactusAnimator;
    private float distanceFromPlayer;

    // Start is called before the first frame update
    private void Start()
    {
        cactusAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateCactusAnimatorParams();
    }

    private void UpdateCactusAnimatorParams() {
        distanceFromPlayer = Vector3.Distance(transform.position, PlayerObject.transform.position);
        cactusAnimator.SetFloat("DistanceFromPlayer", distanceFromPlayer);
    }
}
