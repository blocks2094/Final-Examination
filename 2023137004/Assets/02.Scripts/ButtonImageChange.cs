using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonImageChange : MonoBehaviour
{
    public Button changeButton;                             // 과제하기 버튼
    public Button button;                                   // 제출하기 버튼
    public Image targetImage;                               // 과제 이미지
    public TextMeshProUGUI stressText;                      // 스트레스 수치를 표시할 Text 컴포넌트
    public Sprite[] images;                                 // 이미지 배열
    public int stressThreshold = 5;                         // 스트레스 값
    public int stressValue = 100;                           // 스트레스 수치
    public int swordIndex = 0;
    public TextMeshProUGUI text;
    public TextMeshProUGUI probabilityText;                 // 강화 확률을 표시할 Text 컴포넌트 변수
    public TextMeshProUGUI titleText;                       // 이미지 제목을 표시할 Text 컴포넌트
    private TextMeshProUGUI textTitle;

    private void Start()
    {
        UpdateProbabilityText();                            // 과제하기 버튼 눌렸을 때 Text 표시를 실행하는 함수
        button.onClick.AddListener(OnClick);                // 제출하기 버튼 눌렸을 때 실행하는 함수
        changeButton.onClick.AddListener(ChangeImage);      // 스트레스 수치가 100이상 이면 자동으로 게임 재시작
        text.text = "스트레스: " + stressValue.ToString();  // 스트레스 수치 값 UI
    }
   
    private void UpdateProbabilityText()                    // 과제버튼 누른 후에 과제 이미지 변경하는 함수
    {
        if (swordIndex == 1)                                // 이미지 배열 2번째가 되면
        {
            titleText.text = "            0강 빈폴더";      // 과제 제목에 Text에 "0강 빈폴더" 라고 표시됨
            probabilityText.text = "강화 확률: 100%";       // 강화 확률에 Text에 "강화 확률: 100%" 라고 표시됨
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

    private void ChangeImage()                              // 스트레스 수치가 100이상 이면 자동으로 게임 재시작
    {
        if (stressValue < 100)
        {
            GetRandom();                                    // 스트레스 수치가 100보다 작으면 함수 살행
            targetImage.sprite = images[swordIndex];        
            UpdateProbabilityText();                       
        }
        else
        {
            RestartGame();                                  // 게임 재시작
        }
    }
    private void RestartGame()                              // 게임 재시작 함수             
    {
        // 게임을 다시 시작하는 로직을 구현합니다.
        stressValue = 0;
        swordIndex = 0;
        text.text = "스트레스: " + stressValue.ToString();
        targetImage.sprite = images[swordIndex];
        UpdateProbabilityText();
        Debug.Log("게임 재시작");
    }

    public void GetRandom()                                 // 과제하기 버튼을 누르면 과제 이미지가 일정한 확률 변화
    {
        stressValue += swordIndex;

        int temp = Random.Range(0, 100);                    // 0부터 100 사이에 랜덤으로 숫자 선택

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
            swordIndex = 0;                           // 실패했을 때 "파일이 사라졌습니다" 이미지로 바뀌고 스트레스 수치가 5 증가
            stressValue += 5;
            Debug.Log("강화 실패 : " + swordIndex.ToString() + " 강");
        }

        text.text = "스트레스: " + stressValue.ToString();
        UpdateProbabilityText();

    }

    private void OnClick()                             // 제출하기 버튼을 누르면 실행하는 함수
    {
        
        if (swordIndex == 1)                         
        {
            swordIndex = 1;
            Debug.Log("0강 빈폴더 제출");
        }

        else if (swordIndex == 2)                      // 이미지 배열에 3번째 이미지가 2번째 이미지로 바뀌고 스트레스 값이 4 감소함
        {                                              
            swordIndex = 1;                            // 이미지 배열 번호 조정
            stressValue -= 4;                          // 스트레스 수치 값 조정
            Debug.Log("1강 게임 기획서 제출");
        }

        else if (swordIndex == 3)
        {
            swordIndex = 1;
            stressValue -= 8;
            Debug.Log("2강 제한서 제출");
        }

        else if (swordIndex == 4)
        {
            swordIndex = 1;
            stressValue -= 12;
            Debug.Log("3강 런치스크린 제출");
        }

        else if (swordIndex == 5)
        {
            swordIndex = 1;
            stressValue -= 16;
            Debug.Log("4강 권총 제출");
        }

        else if (swordIndex == 6)
        {
            swordIndex = 1;
            stressValue -= 20;
            Debug.Log("5강 변형예제 제출");
        }

        else if (swordIndex == 7)
        {
            swordIndex = 1;
            stressValue -= 24;
            Debug.Log("6강 가게 입구 제출");
        }

        else if (swordIndex == 8)
        {
            swordIndex = 1;
            stressValue -= 28;
            Debug.Log("7강 스토리보드 제출");
        }

        else if (swordIndex == 9)
        {
            swordIndex = 1;
            stressValue -= 32;
            Debug.Log("8강 와이어프레임 제출");
        }

        else if (swordIndex == 10)
        {
            swordIndex = 1;
            stressValue -= 36;
            Debug.Log("9강 체스판 제출");
        }

        else if (swordIndex == 11)
        {
            swordIndex = 1;
            stressValue -= 40;
            Debug.Log("10강 자전거 제출");
        }
        text.text = "스트레스: " + stressValue.ToString();
        targetImage.sprite = images[swordIndex];
        UpdateProbabilityText();
        
    }

}
