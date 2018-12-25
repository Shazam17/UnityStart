using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    
    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
       
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameScript>().EngGame();
        }

    }
}
