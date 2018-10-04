# Swift를 사용한 TDD 예제

## TDD를 위한 프로젝트 생성

```bash
$ mkdir SwiftTDD
$ cd SwiftTDD
$ swift package init
$ swift package generate-xcodeproj
$ open SwiftTDD.xcodeproj
```

## 16장 드디어, 추상화

* ~~$5 + 10CHF = $10 (환율 2:1)~~
* ~~$5 + $5 = $10~~
* ~~$5 + $5에서 Money 반환하기~~
* ~~Bank.reduce(Money)~~
* ~~Money에 대한 통화 변환을 수행하는 Reduce~~
* ~~Reduce(Bank, String)~~
* ~~Sum.plus~~
* ~~Expression.times~~
* ~~$5 X 2 = $10~~
* ~~`amount`를 private로 만들기~~
* ~~Dollor 부작용?~~
* ~~equals()~~
* ~~5CHF X 2 = 10CHF~~
* ~~Dollar/Franc 중복~~
* ~~공용 equals~~
* ~~공용 times~~
* ~~Franc과 Dollar 비교하기~~
* ~~통화?~~
* ~~testFranceMultiplication 제거~~

