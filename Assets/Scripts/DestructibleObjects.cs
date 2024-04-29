using UnityEngine;

[CreateAssetMenu(fileName = "Destructible Objects", menuName = "ScriptableObjects/DestructibleObject")]
public class DestructibleObjects : ScriptableObject
{
    [field: SerializeField] public int maxXpDrop { get; private set; } = 250;
    [field: SerializeField] public int maxHealth { get; private set; } = 100;

}
