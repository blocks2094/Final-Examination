using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonImageChange : MonoBehaviour
{
    public Button changeButton;                             // �����ϱ� ��ư
    public Button button;                                   // �����ϱ� ��ư
    public Image targetImage;                               // ���� �̹���
    public TextMeshProUGUI stressText;                      // ��Ʈ���� ��ġ�� ǥ���� Text ������Ʈ
    public Sprite[] images;                                 // �̹��� �迭
    public int stressThreshold = 5;                         // ��Ʈ���� ��
    public int stressValue = 100;                           // ��Ʈ���� ��ġ
    public int swordIndex = 0;
    public TextMeshProUGUI text;
    public TextMeshProUGUI probabilityText;                 // ��ȭ Ȯ���� ǥ���� Text ������Ʈ ����
    public TextMeshProUGUI titleText;                       // �̹��� ������ ǥ���� Text ������Ʈ
    private TextMeshProUGUI textTitle;

    private void Start()
    {
        UpdateProbabilityText();                            // �����ϱ� ��ư ������ �� Text ǥ�ø� �����ϴ� �Լ�
        button.onClick.AddListener(OnClick);                // �����ϱ� ��ư ������ �� �����ϴ� �Լ�
        changeButton.onClick.AddListener(ChangeImage);      // ��Ʈ���� ��ġ�� 100�̻� �̸� �ڵ����� ���� �����
        text.text = "��Ʈ����: " + stressValue.ToString();  // ��Ʈ���� ��ġ �� UI
    }
   
    private void UpdateProbabilityText()                    // ������ư ���� �Ŀ� ���� �̹��� �����ϴ� �Լ�
    {
        if (swordIndex == 1)                                // �̹��� �迭 2��°�� �Ǹ�
        {
            titleText.text = "            0�� ������";      // ���� ���� Text�� "0�� ������" ��� ǥ�õ�
            probabilityText.text = "��ȭ Ȯ��: 100%";       // ��ȭ Ȯ���� Text�� "��ȭ Ȯ��: 100%" ��� ǥ�õ�
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

    private void ChangeImage()                              // ��Ʈ���� ��ġ�� 100�̻� �̸� �ڵ����� ���� �����
    {
        if (stressValue < 100)
        {
            GetRandom();                                    // ��Ʈ���� ��ġ�� 100���� ������ �Լ� ����
            targetImage.sprite = images[swordIndex];        
            UpdateProbabilityText();                       
        }
        else
        {
            RestartGame();                                  // ���� �����
        }
    }
    private void RestartGame()                              // ���� ����� �Լ�             
    {
        // ������ �ٽ� �����ϴ� ������ �����մϴ�.
        stressValue = 0;
        swordIndex = 0;
        text.text = "��Ʈ����: " + stressValue.ToString();
        targetImage.sprite = images[swordIndex];
        UpdateProbabilityText();
        Debug.Log("���� �����");
    }

    public void GetRandom()                                 // �����ϱ� ��ư�� ������ ���� �̹����� ������ Ȯ�� ��ȭ
    {
        stressValue += swordIndex;

        int temp = Random.Range(0, 100);                    // 0���� 100 ���̿� �������� ���� ����

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
            swordIndex = 0;                           // �������� �� "������ ��������ϴ�" �̹����� �ٲ�� ��Ʈ���� ��ġ�� 5 ����
            stressValue += 5;
            Debug.Log("��ȭ ���� : " + swordIndex.ToString() + " ��");
        }

        text.text = "��Ʈ����: " + stressValue.ToString();
        UpdateProbabilityText();

    }

    private void OnClick()                             // �����ϱ� ��ư�� ������ �����ϴ� �Լ�
    {
        
        if (swordIndex == 1)                         
        {
            swordIndex = 1;
            Debug.Log("0�� ������ ����");
        }

        else if (swordIndex == 2)                      // �̹��� �迭�� 3��° �̹����� 2��° �̹����� �ٲ�� ��Ʈ���� ���� 4 ������
        {                                              
            swordIndex = 1;                            // �̹��� �迭 ��ȣ ����
            stressValue -= 4;                          // ��Ʈ���� ��ġ �� ����
            Debug.Log("1�� ���� ��ȹ�� ����");
        }

        else if (swordIndex == 3)
        {
            swordIndex = 1;
            stressValue -= 8;
            Debug.Log("2�� ���Ѽ� ����");
        }

        else if (swordIndex == 4)
        {
            swordIndex = 1;
            stressValue -= 12;
            Debug.Log("3�� ��ġ��ũ�� ����");
        }

        else if (swordIndex == 5)
        {
            swordIndex = 1;
            stressValue -= 16;
            Debug.Log("4�� ���� ����");
        }

        else if (swordIndex == 6)
        {
            swordIndex = 1;
            stressValue -= 20;
            Debug.Log("5�� �������� ����");
        }

        else if (swordIndex == 7)
        {
            swordIndex = 1;
            stressValue -= 24;
            Debug.Log("6�� ���� �Ա� ����");
        }

        else if (swordIndex == 8)
        {
            swordIndex = 1;
            stressValue -= 28;
            Debug.Log("7�� ���丮���� ����");
        }

        else if (swordIndex == 9)
        {
            swordIndex = 1;
            stressValue -= 32;
            Debug.Log("8�� ���̾������� ����");
        }

        else if (swordIndex == 10)
        {
            swordIndex = 1;
            stressValue -= 36;
            Debug.Log("9�� ü���� ����");
        }

        else if (swordIndex == 11)
        {
            swordIndex = 1;
            stressValue -= 40;
            Debug.Log("10�� ������ ����");
        }
        text.text = "��Ʈ����: " + stressValue.ToString();
        targetImage.sprite = images[swordIndex];
        UpdateProbabilityText();
        
    }

}
