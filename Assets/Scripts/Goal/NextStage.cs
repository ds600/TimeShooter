using UnityEngine.SceneManagement;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.CompareTag("GameController") )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
