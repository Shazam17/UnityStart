using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    bool ended = false;
    public float delay = 3f;
    // Start is called before the first frame update
    public void EngGame()
    {
        if(!ended)
        {
            ended = true;
            Invoke("Restart" , delay);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void CompleteLevel()
    {
        Debug.Log("Won");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
