# sparta_town
# 프로젝트 소개
유니티를 이용해 게더를 모방하는 프로젝트입니다.

타일맵을 사용하여 배경을 만들고 각종 UI를 제작합니다.

# 개발 기간
2023.09.4 ~ 2023.09.07

# 게임 하는 방법

구현 목록
-
필수 요구 사항
- 캐릭터만들기
- 캐릭터 이동
  - Unity 게임개발 입문 1주차 강의를 참고하여 만들었습니다. ([CharacterController](https://github.com/kkh9700/sparta_town/blob/main/Assets/Scripts/Controller/CharacterController.cs), [PlayerInputController](https://github.com/kkh9700/sparta_town/blob/main/Assets/Scripts/Controller/PlayerInputController.cs), [CharacterMovement](https://github.com/kkh9700/sparta_town/blob/main/Assets/Scripts/Entities/CharacterMovement.cs))
- 방 만들기
  - 타일맵을 사용하여 방을 만들었습니다.
![캡처](https://github.com/kkh9700/sparta_town/assets/77197725/6c94c4ca-f680-4370-b996-1b988877d020)
- 카메라 따라가기
  - 자동으로 플레이어의 위치에 카메라가 따라가게 만들었습니다.([CameraController](https://github.com/kkh9700/sparta_town/blob/main/Assets/Scripts/Controller/CameraController.cs))

선택 요구 사항
- 캐릭터 애니메이션 추가
<br>
![CharacterAnimation](https://github.com/kkh9700/sparta_town/blob/main/Assets/Images/Git/CharacterAnimation.gif)
- 이름 입력 시스템
<br>
![NameSystem](https://github.com/kkh9700/sparta_town/blob/main/Assets/Images/Git/NameSystem.gif)
- 캐릭터 선택 시스템

- 참석 인원 UI
  - UI는 만들었는데 참석인원을 가져오는 기능을 구현하지 못해서 UI만 동작한다.
  
- 인게임 캐릭터 선택

- 인게임 이름 바꾸기

- 시간 표시
  - [TimeUtil](https://github.com/kkh9700/sparta_town/blob/main/Assets/Scripts/Utils/TimeUtil.cs)을 사용해서 현재시간을 구하는 메소드를 만들고 GameManager에서 Update가 실행될 때 마다 현재시간을 갱신해서 표시하였다.
  - https://github.com/kkh9700/sparta_town/blob/2050fa56596fe26abd1b6abbc4d3660a9d3456cf/Assets/Scripts/Manager/GameManager.cs#L25-L28
  
  
