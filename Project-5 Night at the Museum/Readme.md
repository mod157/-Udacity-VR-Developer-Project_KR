
## Night at the Museum
-------------------------------------------------------

### Project
I wanted to use Udacity and have time to introduce Korea.
The 'Night at the Museum' project provided me with this time.
I have included in this project an introduction to Korea where I am born and living.
I want to give you an opportunity to experience history, food, language and 360 degree video.


[KR]
Udacity를 이용하며, Korea에 대해 소개할 수 있는 시간이 있었으면 했다.
'Night at the Museum' 프로젝트는 나에게 이런 시간을 제공 했다.
이 프로젝트에서 내가 태어나 살고 있는 Korea에 대해 소개하는 내용을 담고 있다.
역사, 음식, 언어에 대한 내용과 360도 Video를 체험할 수 있는 기회를 제공하고자 한다.



### Target
**'Night at the Museum' is aimed at new mobile users,
This project is especially for people who are curious about Korea.**

 * **The game should be simple and easy to understand.**
 * **Provides a variety of techniques**
 * **Provides various information**


[KR]
'Night at the Museum'은 새로움을 좋아하는 모바일 사용자를 타겟으로 하고 있으며,
대한민국에 대해 궁금한 사람들이 특히 좋아할 프로젝트입니다.

  * **게임은 단순하고 이해하기 쉬어야 한다.**
  * **다양한 방법의 기술을 제공한다.**
  * **여러 내용의 정보를 제공한다.**


### Outcomes
I had a lot of trouble to put in various contents, and I was worried about which part to add and how to be a better way.
Based on many of the things I learned earlier, I have organized the Waypoint, UI, and I wanted to show a lot about the basic culture and foods that I could show.
In addition, we showed 360 degree view which can be felt using VR, so that we can see the street scenery of Korea.
By the way, Night at the Museum was filled with Korea.

[KR]
다양한 컨텐츠를 넣기 위해 많은 고민을 하였고, 어느 부분을 더 추가해야 할지, 어떻게 하면 더 나은 방식이 될지 고민이 많았습니다.
앞서 배웠던 많은 내용들을 토대로 Waypoint, UI를 구성하였고, 보여 주고 싶은게 많았지만, 소개할 수 있는 기본적인 문화와 음식들에 대해 보여주기로 했습니다.
또한, VR을 이용하여 느낄수 있는 360도 영상을 이용하여 대한민국의 거리 풍경을 볼 수 있게 나타냈습니다.
그렇고 Night at the Museum은 Korea로 가득 차게 되었습니다.


### Task
There is a board introducing Night at the Museum. You can move on to the next step by striking down on the button. You can change the location using WayPoint. Enter, Exit, and Click Event of the prototype displayed in the museum will give you the desired results.

_**Enter: Show introduction**_

_**Click: Show introduction video**_

When the introduction video of Korea is finished, we enter the museum to see more details.

The museum is divided into four sessions, each with its own language, food, history and street scenery.
As before, you get the desired result through the circular Event

[KR]
Night at the Museum을 소개하는 보드가 있습니다. 아래 버튼을 응시함으로써 다음 단계로 넘어 갈 수 있습니다. WayPoint를 이용하여 위치를 변경할 수 있습니다. 박물관에 전시된 원형을 Enter, Exit, Click Event를 통해 원하는 결과를 얻을 수 있습니다.

_**Enter : 소개 글 보여줌**_
_**Click : 소개 영상 보여줌**_

대한민국 소개 영상이 종료 되면, 자세한 내용을 볼 수 있도록 박물관 안으로 진입합니다.

박물관 안에는 4개의 세션으로 구별되어 있으며, 각 언어, 음식, 역사, 거리풍경을 볼 수 있습니다.
앞과 마찬가지로 원형의 Event를 통해 원하는 결과를 얻을 수 있습니다.

---------------------------------------------
### IdeaNote
![IdeaImage](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-5%20NightattheMuseum/Image/idea_1.jpg)
```
I set the start point and the play point end point and set the position of each session.
I implemented the overall logic of the game.

[KR]
start 포인트와 play포인트 End포인트를 정하고 각각 세션의 위치를 정했다.
게임 전반적인 Logic을 구현하였다.
```

![IdeaImage](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-5%20NightattheMuseum/Image/idea_2.jpg)
```
Introduction of session and method of executing image and design design were carried out.

[KR]
세션의 소개와 영상을 실행하는 방법과 디자인 설계를 진행했다.
```

![IdeaImage](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-5%20NightattheMuseum/Image/idea_3.jpg)

```
I have specified the entire design design and the Item position.

[KR]
전체 디자인 설계와 Item 위치를 지정했다.
```


### Testing
1. Read the Board's article and take the Go! Korea button.
1. Go to StartPoint and use Waypoint to change position.
1. Enter and click the circle to view the description and video.
1. Go inside the museum.
2. Watch the video by staring at the same circle.

[KR]
1. Board의 글을 읽고 Go!Korea 버튼을 응시합니다.
1. StartPoint로 이동하여 Waypoint를 이용하여 위치를 변경합니다.
1. 원형을 Enter, Click을 이용하여 설명과 영상을 시청합니다.
1. 박물관 안으로 이동합니다.
2. 동일하게 원형을 응시하여 영상을 시청합니다.


I encouraged my friend to test, and the results were

**_Sounds strange_**

**_No exit button._**

Discovers that audio problems are caused by video sync problems
Provide the exit button separately.

[KR]
친구에게 테스팅을 권했고, 결과는 다음과 같았습니다.

> **_사운드가 이상하게 들린다._**

> **_종료버튼이 없다._**

동영상의 싱크 문제로 오디오에서 문제가 발생한다는 것을 발견, 영상과 오디오를 분리하여 실행
종료 버튼을 따로 제공함.


### Scenario
1. Read the Board's article and take the Go! Korea button.
1. Go to StartPoint and use Waypoint to change position.
1. Enter and click the circle to view the description and video.
1. Go inside the museum.
2. Watch the video by staring at the same circle.


[KR]
1. Board의 글을 읽고 Go!Korea 버튼을 응시합니다.
1. StartPoint로 이동하여 Waypoint를 이용하여 위치를 변경합니다.
1. 원형을 Enter, Click을 이용하여 설명과 영상을 시청합니다.
1. 박물관 안으로 이동합니다.
2. 동일하게 원형을 응시하여 영상을 시청합니다.


### Demo Play Video
[![Video Label](http://img.youtube.com/vi/YB5haoZhG3E/0.jpg)](https://youtu.be/YB5haoZhG3E?t=0.5s)

### ScreenShot
  * Start Point
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/ScreenShot1.png)
  - Red Ball
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/ScreenShot2.png)
  - Moving Red Ball
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/ScreenShot3.png)
  - Finish
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/ScreenShot4.png)
  -
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/ScreenShot5.png)


### Finish
This is what I have prepared. There is more to it than that, but there is no experience as good as coming in person! I hope to come and experience a lot. What I have shown is a short story. I wanted to know a lot about you.

I am proud of my country.

Thanks you.
[KR]
아쉽게도 여기까지가 내가 준비한 내용이다. 더 많은 내용이 있지만, 직접와서 보는 것 만큼 좋은 경험은 없으니까! 여러분들이 직접 찾아와 다양한 경험을 했으면 좋겠습니다. 내가 보여준건 단편일 뿐입니다. 여러분들이 많이 알아봐 주었으면 했습니다.

나는 우리나라가 자랑스럽습니다.

감사합니다.



###### Linkedin : https://www.linkedin.com/in/sunjae-lee-0bb14616b/
###### github : https://github.com/mod157/Udacity_VRDeveloper-Project_KR/tree/master/Project-5/20NightattheMuseum
