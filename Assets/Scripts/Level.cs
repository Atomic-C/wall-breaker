using UnityEngine;

public class Level : MonoBehaviour
{

    [SerializeField] int breakableBlocks; // Serialized for debugging purposes

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
}
