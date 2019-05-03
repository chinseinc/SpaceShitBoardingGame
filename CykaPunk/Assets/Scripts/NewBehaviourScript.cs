using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D RB;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // Use Time.deltaTime to scale for frames
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        RB.AddForce(movement * speed, ForceMode2D.Force);
        //RB.AddForce(movement * speed, ForceMode2D.Impulse);
    }
}
