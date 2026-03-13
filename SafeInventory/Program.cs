using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.


List<string> player1Items = null;
List<string> player2Items = new List<string>();
List<string> player3Items = new List<string> { "검", "방패", "포션" };

string GetFirstItem(List<string> items) => items?.Count > 0 ? items?[0] ?? "없음" : "없음";
string GetLastItem(List<string> items) => items?.Count > 0 ? items?[^1] ?? "없음" : "없음";


Console.WriteLine($"=== 플레이어 1 (인벤토리 없음) ===");
Console.WriteLine($"아이템 수: {player1Items?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {GetFirstItem(player1Items)}");
Console.WriteLine($"마지막 아이템: {GetLastItem(player1Items)}");

Console.WriteLine($"\n=== 플레이어 2 (빈 인벤토리) ===");
Console.WriteLine($"아이템 수: {player2Items?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {GetFirstItem(player2Items)}");
Console.WriteLine($"마지막 아이템: {GetLastItem(player2Items)}");

Console.WriteLine($"\n=== 플레이어 3 (아이템 보유) ===");
Console.WriteLine($"아이템 수: {player3Items?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {GetFirstItem(player3Items)}");
Console.WriteLine($"마지막 아이템: {GetLastItem(player3Items)}");