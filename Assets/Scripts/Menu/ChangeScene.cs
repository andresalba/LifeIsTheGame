using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SceneChange(){
        SceneManager.LoadScene("Shoot", LoadSceneMode.Single);
    }
}
