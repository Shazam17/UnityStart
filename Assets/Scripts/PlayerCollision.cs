using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript ps;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            ps.enabled = false;
            FindObjectOfType<GameScript>().EngGame();
        }
    }

    // Update is called once per frame
    void Update()
    {
                
    }
}
