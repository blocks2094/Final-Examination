using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public string targetScene;                      // 이동할 대상 씬의 이름
    public Button button;                           // 클릭할 버튼

    private void Start()
    {
        button.onClick.AddListener(ChangeScene);    // 버튼 클릭 이벤트에 ChangeScene 함수 연결
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);        // 대상 씬으로 전환
    }
}
