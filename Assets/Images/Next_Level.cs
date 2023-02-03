using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Next_Level : MonoBehaviour {

    public string LevelToLoad;

    void LoadMenu () {
        SceneManager.LoadScene("MainMenu");
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("EnterNext");
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("EnterNext2");
            LoadLevel();
        }
    }
}