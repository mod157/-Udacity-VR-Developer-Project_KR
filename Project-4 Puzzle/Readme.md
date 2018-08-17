
## Red Ball Puzzle
-------------------------------------------------------

### Project
We have created a 'red ball puzzle' for those who want to escape from the new puzzle.
I tend to pursue new things and I am adventurous.
So I decided to make things a bit harder and to think of bringing more joy to the eye, and I decided to move things.
'Red Ball Puzzle' is a target for kids who love puzzles.
The number of children who are experiencing VR is on the rise, and I wanted to develop a program that allows me to experience video and experience it by hand.

[KR]
새로운 퍼즐에서 벗어나고자 하는 사람들을 위해 'Red Ball Puzzle'을 만들게 되었습니다.
나는 개인적으로 누구나 하는 것을 원하지 않습니다. 새로운 것을 추구하는 경향이 강하며, 모험심이 강합니다.
그래서 조금 더 어렵고, 눈에 즐거움을 가져다 주는 방식이 무엇인지 생각하게 되었고, 오브젝트를 이동해보자는 결론을 얻게 되었습니다.
'Red Ball Puzzle'은 퍼즐을 좋아하는 어린이를 사용자 그룹으로 하고 있습니다.
VR을 체험하는 어린이들이 갈수록 늘고 있고, 영상 시청만이 아닌 직접 체험할 수 있는 프로그램으로 개발하고자 했습니다.


### Outcomes
It took five days to create a script to move the Orb in the old way. It should look good in the eyes of the user, and should not move to another location. At first, I moved my position differently from the position change part. I also had a lot of worries about how to change the five ball positions.
We remembered five locations, and decided to randomly reposition each other, so we showed the new results by inserting the changes into the provided script.
As a result, Orb has created a moving final product.

[KR]
기존 방식에서 Orb를 이동하려는 스크립트를 만들기 위해 5일에 시간이 걸렸습니다. 사용자의 눈에 이동하는 모습이 잘 보여야 하며, 다른 위치로 벗어나지 않아야 했습니다. 처음에는 Position 변경 부분에서 나의 뜻과는 다르게 이동하였습니다. 또, 5개의 공 위치를 서로 어떻게 바꾸게 할 것인가에 대해 고민이 많았습니다.
5개의 위치를 기억하고, 서로 랜덤하게 위치를 변경하자고 정했으며, 그럼으로 제공된 스크립트를 변경사항을 삽입하여 새로운 결과를 나타냈습니다.
결과적으로 Orb가 움직이는 최종 제품을 만들었습니다.


### Task
There is an Orb that starts to shine in random order. The Orb then moves to a different position in random order. Both of these behaviors are simple enough for children to understand but require concentration.
If the Orb moves in the order in which it is moved, it will move to the end point, or it will fail.
If unsuccessful, the Orb shines in random order and moves again.

[KR]
무작위 순서로 빛나기 시작하는 Orb가 있습니다. 그런 다음 Orb가 무작위 순서로 다른 위치로 이동합니다. 이 두가지 동작은 어린이들도 이해 할 수 있을 정도로 간단하지만, 집중도를 요구 합니다.
Orb가 이동한 위치를 빛나는 순서대로 입력하게 되면 성공하여 End 포인트로 이동, 아니면 실패합니다.
실패할 경우 무작위 순서로 Orb가 빛나고 다시 이동합니다.

---------------------------------------------
### IdeaNote
![IdeaImage](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/idea_2.jpg)
```
We set start point and play point end point and decided ball position.
From that time on, the color of the ball was red.

[KR]
start 포인트와 play포인트 End포인트를 정하고 공의 위치를 정했습니다.
이때부터 공의 색은 Red로 결졍했습니다.
```

![IdeaImage](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/idea_3.jpg)
```
start board, end board We have been thinking about the image and the game way.

[KR]
start board, end board 이미지와 게임 방식에 대해 구상했습니다.
```

![IdeaImage](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/idea_4.jpg)

```
We have planned how to move the Orb and changed the way we play.

[KR]
Orb를 어떻게 이동할지에 대해 계획하고 게임 방식에 대해 변경하였습니다.
```


### Testing
1. Click Start to go to Play Points.
1. One Orb lights up randomly and moves.
1. Go to end point when success.
1. If it fails, return to No. 2.

[KR]
1. Start를 클릭시 Play포인트로 이동합니다.
1. 랜덤으로 1개의 Orb가 빛이 나고 이동합니다.
1. 성공시 End포인트로 이동합니다.
1. 실패시 2번으로 돌아갑니다.

I encouraged my friend to test, and the results were:
| It is very easy to find one light source.
| The sound part of the game is too big.
| I do not know if it touches the button part.

Based on this, the two Gangwon were changed to random shining, and the sound was also adjusted.
We also added whether we recognized Button Highlight.

[KR]
친구에게 테스팅을 권했고, 결과는 다음과 같았습니다.
| 1개의 광원을 찾는 것은 매우 쉽다.
| 게임 소리 부분이 너무 크다
| 버튼 부분에 닿았는지 모르겠다.

이것을 바탕으로 2개의 강원이 무작위로 빛나는 것으로 변경하고, 소리 부분도 조절하였다.
또한, Button Highlight를 지정하여 인지하였는지를 추가하였다.


### Play Video
[![Video Label](http://img.youtube.com/vi/DIKSJo9kCx4/0.jpg)](https://youtu.be/DIKSJo9kCx4?t=0.5s)
[![Video Label](http://img.youtube.com/vi/bt5MRrPpx8E/0.jpg)](https://youtu.be/bt5MRrPpx8E?t=0.5s)

### ScreenShot
  * Start Point
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/ScreenShot_1.png)
  - Red Ball
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/ScreenShot_2.png)
  - Moving Red Ball
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/ScreenShot_3.png)
  - Finish
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/ScreenShot_4.png)
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/Mobile_1.jpg)
![스크린샷](https://github.com/mod157/Udacity_VRDeveloper-Project_KR/blob/master/Project-4%20Puzzle/Image/Mobile_2.jpg)


### Finish
I played this game with my nephew and solved the problem without difficulty. I can say that this project was a joy and a success. This project gave me a great experience. I think that making things to explain to others is harder than the existing development days. We also learned how to change and use existing sources to devise new ways.
It's playable, but there are still a few things you might want to add.
I want to make a puzzle that can be a multi-level puzzle, in harmony with the surrounding environment.

[KR]
조카에게 이 게임을 실행시켜주었고, 어려움 없이 문제를 해결 했습니다. 이 프로젝트는 즐거움을 주었기에 성공했다고 말할 수 있습니다. 이 프로젝트는 저에게 큰 경험을 주었습니다. 다른 사람에게 설명하기 위해 만드는 일이 기존의 개발일보다 더 힘들었다고 생각합니다. 또한, 새로운 방식을 고안하기 위해 기존의 소스를 변경하여 사용하는 방법도 알 수 있었습니다.
플레이 가능한 상태이지만, 아직 몇가지 추가사항을 원하는 바도 있습니다.
여러 단계가 가능한 퍼즐, 주변 환경과 조화를 이루는 퍼즐로 만들고 싶습니다.

Thanks you.


###### Linkedin : https://www.linkedin.com/in/sunjae-lee-0bb14616b/
###### github : https://github.com/mod157/Udacity_VRDeveloper-Project_KR/tree/master/Project-4/Puzzle
