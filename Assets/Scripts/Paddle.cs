using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Configuration parameters

    [SerializeField] float minX = 1;
    [SerializeField] float maxX = 18f;

    [SerializeField] float screenWidthInUnits = 18f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition.x / Screen.width);

        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y); // In this line stay where you are.
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;
    }
}
