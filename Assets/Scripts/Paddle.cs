using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Configuration parameters

    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 18f;

    [SerializeField] float screenWidthInUnits = 18f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.mousePosition.x / Screen.width);

        //float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y); // In this line stay where you are.
        paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
        transform.position = paddlePos;
    }

    private float GetXPos()
    {
        if (FindObjectOfType<GameStatus>().IsAutoPlayEnabled()) // If autoplay enabled return x position instantly.
        {
            return FindObjectOfType<Ball>().transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }

}
