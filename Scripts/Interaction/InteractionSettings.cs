//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class InteractionSettings : MonoBehaviour
{
    public static InteractionSettings instance;

    [Tooltip("Item is drop when colliding at this force")]
    public float collisionVelocityDropThreshold = 5f;
    
    [Tooltip("If item has been displaced from crosshair, it will snap back with this speed")]
    public float displacementSnapBackSpeed = 2000f;
    
    [Tooltip("If item has been displaced from crosshair, it will snap back, and then gradually decrease in velocity until this threshold.")]
    public float slowDownThreshold = 0.1f;
    
    [Tooltip("The speed will subsequently be divided by this value")]
    public float slowdownCoefficient = 5f;
    
    [Tooltip("Item will snap back upon reaching this distance from crosshair")]
    public float snapBackDistance = 0.3f;
    
    [Tooltip("Item will be dropped upon having been displaced this much from crosshair")]
    public float displacementDropDistance = 0.8f;

    private void Awake()
    {
        instance = this;
    }
}
