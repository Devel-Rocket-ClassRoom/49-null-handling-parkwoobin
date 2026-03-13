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


// TODO: ### 2-3. 메서드 호출에 사용