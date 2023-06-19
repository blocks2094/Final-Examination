using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonImageChange : MonoBehaviour
{
    public Button changeButton; // �̹��� ���� ��ư
    public Image targetImage; // ������ �̹����� ǥ���� Image ������Ʈ
    public TextMeshProUGUI stressText; // ��Ʈ���� ��ġ�� ǥ���� Text ������Ʈ
    public Sprite[] images; // �̹��� �迭
    public int stressThreshold = 5; // ��Ʈ���� �Ӱ谪
    public int stressValue = 100; // ��Ʈ���� ��ġ
    public int swordIndex = 0;
    public TextMeshProUGUI text;
    public TextMeshProUGUI probabilityText; // ��ȭ Ȯ���� ǥ���� Text ������Ʈ ����
    public TextMeshProUGUI titleText; // �̹��� ������ ǥ���� Text ������Ʈ
    private TextMeshProUGUI textTitle;


    private void Start()
    {
        changeButton.onClick.AddListener(ChangeImage);
        text.text = "��Ʈ����: " + stressValue.ToString();
        UpdateProbabilityText(); // �ʱ� ��ȭ Ȯ���� ǥ��
    }

    private void UpdateProbabilityText()
    {
        if (swordIndex == 0)
        {
           
        }

        else if (swordIndex == 1)
        {
            titleText.text = "            0�� ������";
            probabilityText.text = "��ȭ Ȯ��: 100%";
        }

        else if (swordIndex == 2)
        {
            titleText.text = "        1�� ���� ��ȹ��";
            probabilityText.text = "��ȭ Ȯ��: 95%";
        }

        else if (swordIndex == 3)
        {
            titleText.text = "            2�� ���Ѽ�";
            probabilityText.text = "��ȭ Ȯ��: 90%";
        }

        else if (swordIndex == 4)
        {
            titleText.text = "         3�� ��ġ��ũ��";
            probabilityText.text = "��ȭ Ȯ��: 85%";
        }

        else if (swordIndex == 5)
        {
            titleText.text = "              4�� ����";
            probabilityText.text = "��ȭ Ȯ��: 80%";
        }

        else if (swordIndex == 6)
        {
            titleText.text = "       5�� C# ���� ����";
            probabilityText.text = "��ȭ Ȯ��: 75%";
        }

        else if (swordIndex == 7)
        {
            titleText.text = "          6�� ���� �Ա�";
            probabilityText.text = "��ȭ Ȯ��: 70%";
        }

        else if (swordIndex == 8)
        {
            titleText.text = "         7�� ���丮����";
            probabilityText.text = "��ȭ Ȯ��: 65%";
        }

        else if (swordIndex == 9)
        {
            titleText.text = "       8�� ���̾� ������";
            probabilityText.text = "��ȭ Ȯ��: 60%";
        }

        else if (swordIndex == 10)
        {
            titleText.text = "            9�� ü����";
            probabilityText.text = "��ȭ Ȯ��: 55%";
        }

        else if (swordIndex == 11)
        {
            titleText.text = "        10�� 3D ������";
            probabilityText.text = "";
        }
    }

    private void ChangeImage()
    {
        if (stressValue < 100)
        {
            GetRandom();
            targetImage.sprite = images[swordIndex];
            UpdateProbabilityText();
        }
        else
        {
            RestartGame();
        }
    }
    private void RestartGame()
    {
        // ������ �ٽ� �����ϴ� ������ �����մϴ�.
        stressValue = 0;
        swordIndex = 0;
        text.text = "��Ʈ����: " + stressValue.ToString();
        targetImage.sprite = images[swordIndex];
        UpdateProbabilityText();
        Debug.Log("���� �����");
    }

    public void GetRandom()
    {
        stressValue += swordIndex;

        int temp = Random.Range(0, 100);

        if (swordIndex == 0 && temp >= 0)     
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 100%)");
        }

        else if (swordIndex == 1 && temp >= 0)      // 0������ 1������
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 95%)");
        }

        else if (swordIndex == 2 && temp >= 5)      // 1������ 2������
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 95%)");
        }

        else if (swordIndex == 3 && temp >= 10)      // 2������ 3������
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 90%)");
        }

        else if (swordIndex == 4 && temp >= 15)      // 3������ 4������
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 85%)");
        }

        else if (swordIndex == 5 && temp >= 20)      // 4������ 5������
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 80%)");
        }

        else if (swordIndex == 6 && temp >= 25)      // 5������ 6������
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 75%)");
        }

        else if (swordIndex == 7 && temp >= 30)      // 6������ 7������
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 70%)");
        }

        else if (swordIndex == 8 && temp >= 35)      // 7������ 8������
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 65%)");
        }

        else if (swordIndex == 9 && temp >= 40)      // 8������ 9������
        {
            swordIndex += 1;

            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 60%)");
        }

        else if (swordIndex == 10 && temp >= 45)      // 9������ 10��
        {
            swordIndex += 1;
            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��" + " (Ȯ��: 55%)");
        }



        else
        {
            swordIndex = 0;
            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��");
        }
                 
        text.text = "��Ʈ����: " + stressValue.ToString();
        UpdateProbabilityText(); // ��ȭ Ȯ���� ������Ʈ�Ͽ� ǥ��

    }
}
