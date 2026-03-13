using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.


string name = null;
name ??= "이름 없음";
Console.WriteLine($"{name}");
name ??= "새 이름";
Console.WriteLine($"{name}");


string playerName = null;
if (playerName == null)
{
    playerName = "플레이어";
}
Console.WriteLine($"{playerName}");

List<string> _items = null;
_items ??= new List<string>();
_items.Add("검");
_items.Add("방패");
Console.WriteLine($"아이템 수: {_items.Count}");
foreach (var item in _items)
{
    Console.WriteLine($"- {item}");
}

string message = null;
int? length = message?.Length;
Console.WriteLine($"길이: {length}");

message = "안녕하세요";
length = message?.Length;
Console.WriteLine($"길이: {length}");

string text = null;

int? textLength = text?.Length;

if (text == null)
{
    Console.WriteLine("텍스트가 없습니다.");
}

string name2 = null;
Console.WriteLine($"결과: {name2?.ToUpper()}");
name2 = "hello";
Console.WriteLine($"결과: {name2?.ToUpper()}");

List<string> items = null;
Console.WriteLine($"아이템 수: {items?.Count}");
items = new List<string>() { "사과", "바나나" };
int? itemCount = items?.Count;
Console.WriteLine($"아이템 수: {itemCount}");

string text1 = null;
Console.WriteLine($"첫 글자: {text1?[0]}");
char? firstChar = text1?[0];
text1 = "Hello";
Console.WriteLine($"첫 글자: {text1?[0]}");

string message2 = null;
Console.WriteLine($"길이: {message2?.Length ?? 0}");
message2 = "Hello";
Console.WriteLine($"길이: {message2?.Length ?? 0}");

List<string> names = null;

Console.WriteLine($"이름 수: {names?.Count ?? 0}");
names = new List<string>() { "Kim", "Lee", "Park" };
Console.WriteLine($"이름 수: {names?.Count ?? 0}");

string playerName1 = null;
int? playerLevel = null;
List<string> inventory = null;

Console.WriteLine($"플레이어 이름: {playerName1 ?? "Unknown"}");
Console.WriteLine($"레벨: {playerLevel ?? 1}");
Console.WriteLine($"인벤토리 아이템: {inventory?.Count ?? 0}개");