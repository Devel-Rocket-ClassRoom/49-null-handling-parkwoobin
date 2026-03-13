using System;
using System.Threading;

// README.md를 읽고 아래에 코드를 작성하세요.





int?[] scores = { 3, null, 7, null, 5 };
int totalScore = 0;
int count = 0;

Console.WriteLine("=== 경기 상태 ===");
for (int i = 0; i < scores.Length; i++)
{
    if (scores[i] == null)
    {
        Console.WriteLine($"경기 {i + 1}: 미진행");
    }
    else
    {
        Console.WriteLine($"경기 {i + 1}: 점수 {scores[i]} (진행 완료)");
    }
}

Console.WriteLine("=== 전체 점수 (미진행 = -1) ===");
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"경기 {i + 1}: 점수 {scores[i] ?? -1}");
    totalScore += scores[i] ?? 0;
    if (scores[i] != null)
    {
        count++;
    }
}
Console.WriteLine("=== 통계 ===");
Console.WriteLine($"진행된 경기 수: {count}");
Console.WriteLine($"총점: {totalScore}");
Console.WriteLine($"평균: {(totalScore / (double)count):F1}");