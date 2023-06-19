using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonImageChange : MonoBehaviour
{
    public Button changeButton; // 이미지 변경 버튼
    public Image targetImage; // 변경할 이미지를 표시할 Image 컴포넌트
    public TextMeshProUGUI stressText; // 스트레스 수치를 표시할 Text 컴포넌트
    public Sprite[] images; // 이미지 배열
    public int stressThreshold = 5; // 스트레스 임계값
    public int stressValue = 100; // 스트레스 수치
    public int swordIndex = 0;
    public TextMeshProUGUI text;
    public TextMeshProUGUI probabilityText; // 강화 확률을 표시할 Text 컴포넌트 변수
    public TextMeshProUGUI titleText; // 이미지 제목을 표시할 Text 컴포넌트
    private TextMeshProUGUI textTitle;


    private void Start()
    {
        changeButton.onClick.AddListener(ChangeImage);
        text.text = "스트레스: " + stressValue.ToString();
        UpdateProbabilityText(); // 초기 강화 확률을 표시
    }

    private void UpdateProbabilityText()
    {
        if (swordIndex == 0)
        {
           
        }

        else if (swordIndex == 1)
        {
            titleText.text = "            0강 빈폴더";
            probabilityText.text = "강화 확률: 100%";
        }

        else if (swordIndex == 2)
        {
            titleText.text = "        1강 게임 기획서";
            probabilityText.text = "강화 확률: 95%";
        }

        else if (swordIndex == 3)
        {
            titleText.text = "            2강 제한서";
            probabilityText.text = "강화 확률: 90%";
        }

        else if (swordIndex == 4)
        {
            titleText.text = "         3강 런치스크린";
            probabilityText.text = "강화 확률: 85%";
        }

        else if (swordIndex == 5)
        {
            titleText.text = "              4강 권총";
            probabilityText.text = "강화 확률: 80%";
        }

        else if (swordIndex == 6)
        {
            titleText.text = "       5강 C# 변형 예제";
            probabilityText.text = "강화 확률: 75%";
        }

        else if (swordIndex == 7)
        {
            titleText.text = "          6강 가게 입구";
            probabilityText.text = "강화 확률: 70%";
        }

        else if (swordIndex == 8)
        {
            titleText.text = "         7강 스토리보드";
            probabilityText.text = "강화 확률: 65%";
        }

        else if (swordIndex == 9)
        {
            titleText.text = "       8강 와이어 프레임";
            probabilityText.text = "강화 확률: 60%";
        }

        else if (swordIndex == 10)
        {
            titleText.text = "            9강 체스판";
            probabilityText.text = "강화 확률: 55%";
        }

        else if (swordIndex == 11)
        {
            titleText.text = "        10강 3D 자전거";
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
        // 게임을 다시 시작하는 로직을 구현합니다.
        stressValue = 0;
        swordIndex = 0;
        text.text = "스트레스: " + stressValue.ToString();
        targetImage.sprite = images[swordIndex];
        UpdateProbabilityText();
        Debug.Log("게임 재시작");
    }

    public void GetRandom()
    {
        stressValue += swordIndex;

        int temp = Random.Range(0, 100);

        if (swordIndex == 0 && temp >= 0)     
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 100%)");
        }

        else if (swordIndex == 1 && temp >= 0)      // 0강에서 1강으로
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 95%)");
        }

        else if (swordIndex == 2 && temp >= 5)      // 1강에서 2강으로
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 95%)");
        }

        else if (swordIndex == 3 && temp >= 10)      // 2강에서 3강으로
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 90%)");
        }

        else if (swordIndex == 4 && temp >= 15)      // 3강에서 4강으로
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 85%)");
        }

        else if (swordIndex == 5 && temp >= 20)      // 4강에서 5강으로
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 80%)");
        }

        else if (swordIndex == 6 && temp >= 25)      // 5강에서 6강으로
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 75%)");
        }

        else if (swordIndex == 7 && temp >= 30)      // 6강에서 7강으로
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 70%)");
        }

        else if (swordIndex == 8 && temp >= 35)      // 7강에서 8강으로
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 65%)");
        }

        else if (swordIndex == 9 && temp >= 40)      // 8강에서 9강으로
        {
            swordIndex += 1;

            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 60%)");
        }

        else if (swordIndex == 10 && temp >= 45)      // 9강에서 10강
        {
            swordIndex += 1;
            Debug.Log("강화 성공 : " + swordIndex.ToString() + " 강" + " (확률: 55%)");
        }



        else
        {
            swordIndex = 0;
            Debug.Log("강화 실패 : " + swordIndex.ToString() + " 강");
        }
                 
        text.text = "스트레스: " + stressValue.ToString();
        UpdateProbabilityText(); // 강화 확률을 업데이트하여 표시

    }
}
