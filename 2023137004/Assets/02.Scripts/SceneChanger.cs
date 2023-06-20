using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public string targetScene;                      // �̵��� ��� ���� �̸�
    public Button button;                           // Ŭ���� ��ư

    private void Start()
    {
        button.onClick.AddListener(ChangeScene);    // ��ư Ŭ�� �̺�Ʈ�� ChangeScene �Լ� ����
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);        // ��� ������ ��ȯ
    }
}
