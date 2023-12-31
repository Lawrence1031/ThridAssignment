# Curious Stories - 조성민

## Chapter 3-3 Unity 과제

### 개발 환경 및 에셋 정보
<details>

#### 개발 환경
### Unity 2022.3.2f1

<br/>

#### 사용한 에셋

##### Top-Dwon 2D RPG Assets Pack
https://assetstore.unity.com/packages/2d/pixelwitchery-239673

<br/>

#### 사용한 폰트
##### 쿠키런 폰트
##### https://www.cookierunfont.com/

<br/>

#### 개발 기간
##### 3일 (20231226 ~ 20231228)
20231229 추가 개선 예정

<br/>

</details>

### 게임 설명

<details>
  
<br/>

이번 게임은 미완성의 게임으로 최종 프로젝트에 들어가기 앞서서 기술적인 부분을 공부하기 위해 만든 게임이다.

게임의 기본적인 내용은 '잔혹동화'라는 키워드로 설명할 수 있을 것 같다.

우리가 익히 알고 있는 동화의 이야기를 따라가지만, 

플레이어의 선택에 따라서 결과가 우리가 아는 동화와 달라지는

인터렉터블한 책을 읽는 느낌을 주기위한 게임으로 만들었다.

동화책의 느낌을 살리기 위해 IntroScene에는 서고 느낌이 나게,

TitleScene에서는 책장에서 책을 뽑는 느낌이 나게, CollectionScene에서는 책에서 도감(사전)을 보는 느낌이 나게 만드려고 했다.

게임의 전반적인 진행은 2D 알만툴(쯔꾸르) 형식의 게임을 구현하려고 하였다.
  
</details>

### 과제 세부사항
<details>

#### 과제 개요
이번 과제는 자유 과제로 최종 프로젝트에 들어가기 전에 마지막 정비 과정이라고 생각되어

최대한 어깨에 힘을 빼고 최종 프로젝트에서 사용할만한 기술적 시도를 하는데 중점을 두었다.

<br/>

#### 요구사항

##### 필수요구사항

씬 전환하는 기능 구현

<br/>

##### 선택요구사항
1. 오브젝트 풀링
2. Instantiate로 오브젝트 생성
3. InputAction 사용
4. 스크립트로 버튼에 이벤트 추가
5. delegate 사용
6. raycast
7. generic을 이용한 싱글톤
8. FSM
9. Dictionary 활용
10. Queue, Stack 활용

<br/>
  
</details>

----

### 실제로 구현한 기능 소개

<details>
  
<br/>

이 게임을 만들면서 구현했던 기능들은

Button에 마우스를 호버 했을 때, 다양한 효과가 나타날 수 있게 (IPointerEnter, IPointerExit)을 사용한 것과

여러 Button들을 만들고 이 Button들에 각각의 기능들을 부여한 것과

플레이어의 이동을 GetAxis가 아니라 InputAction을 이용한 것,

UI의 기능들을 최대한 이용하여 다양한 해상도에서도 원하는 UI 구성으로 보일 수 있도록 한 것

Coroutine을 이용하여 글씨가 순서대로 나오며 책을 읽는 듯한 효과를 주는 것

</details>

#### 20231229 개선하려는 기능들

<details>

<br/>

원래는 04.Chapter_01 부분에 좀 더 구현하여 기본적인 게임의 진행까지(데모버전) 만드는 것이 목표였으나,

다양한 기술들을 공부하느랴고 이를 완수하지 못하고 기본적인 UI 틀과 Button들, 캐릭터와 이동 정도를 구현하였다.

오늘 추가로 raycast를 이용한 특정 물체와의 상호 작용, NPC를 추가하여 상호작용하여 대화하는 기능까지 구현하려고 한다.

</details>

#### 구현하지 못했지만 공부한 것들

<details>

<br/>

이번 게임을 작업하면서 구현하지는 못했지만 따로 공부했던 내용들은

Dictionary를 활용하는 것인데, 이는 알고리즘 문제를 풀면서 공부하게 된 것으로,

데이터를 저장하는 과정에서 "값"과 "데이터"의 쌍 데이터를 받은 경우에, 값을 가지고 데이터를 찾기 위해서 사용하였으며,

https://school.programmers.co.kr/learn/courses/30/lessons/150370

특히 위의 문제에서 대두되어 여러가지 예제를 보면서 공부하였다.

</details>

#### 이번 게임을 만들며 작업했던 기록들

<details>

<br/>

이번 게임을 기획하고 작업하면서 가장 중요하게 여겼던 것은,

어떤 게임을 만들지 아이디어를 내는 것과 UI를 구성하는 느낌을 어떻게 할 것인지 하는 등의 요소들로

아래의 사진들은 그 과정을 손으로 기록한 사진인데, 과제와는 관계가 적지만 잊혀지는 것이 아쉬워서 올리게 되었다.

![KakaoTalk_20231229_121704861](https://github.com/Lawrence1031/ThridAssignment/assets/144416099/2b3662ec-a0a4-4026-b69d-a28f7bdec04e)

![KakaoTalk_20231229_121704861_01](https://github.com/Lawrence1031/ThridAssignment/assets/144416099/d017a3b7-580d-4b16-ae24-be127890d689)

![KakaoTalk_20231229_121704861_02](https://github.com/Lawrence1031/ThridAssignment/assets/144416099/cbfedf52-bc5a-4d3f-b52f-f8d2c442dc1a)

![KakaoTalk_20231229_121704861_03](https://github.com/Lawrence1031/ThridAssignment/assets/144416099/e44f5d91-e65d-4bf5-b7ed-a09cf6006b98)
  
</details>

