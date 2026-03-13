using System;

// README.md를 읽고 코드를 작성하세요.




int number = 0;
string text = "";
string nothing = null;
Console.WriteLine($"{number}");
Console.WriteLine($"{text}");
Console.WriteLine($"{nothing}");


string name = null;
Console.WriteLine(name == null);

int? nullableInt = null;
double? nullableDouble = null;
bool? nullableBool = null;
Nullable<int> anotherNullableInt = null;
Nullable<double> anotherNullableDouble = null;

Console.WriteLine(nullableInt);
Console.WriteLine(nullableDouble);
Console.WriteLine(nullableBool);


int? score = null;
Console.WriteLine(score.HasValue);
score = 95;
Console.WriteLine(score.HasValue);
Console.WriteLine(score);

int? empty = null;

Console.WriteLine(empty.HasValue == true ? empty.Value : "값이 없습니다.");

int? level = null;
int defaultLevel = level.GetValueOrDefault();
Console.WriteLine($"기본값 사용: {defaultLevel}");

int customLevel = level.GetValueOrDefault(1);
Console.WriteLine($"커스텀 기본값: {customLevel}");

level = 50;
Console.WriteLine($"값이 있을 때: {level.GetValueOrDefault()}");

int number1 = 42;
int? nullable = number1;

int back = (int)nullable;
Console.WriteLine($"nullable: {nullable}");
Console.WriteLine($"back: {back}");


string message = null;
Console.WriteLine(message ?? "기본 메시지");
message = "안녕하세요";
Console.WriteLine(message ?? "기본 메시지");

string input = null;
string output;
if (input == null)
{
    output = "기본값";
}
else
{
    output = input;
}

Console.WriteLine($"if문의 결과: {output}");

output = input ?? "기본값";
Console.WriteLine($"?? 연산자의 결과: {output}");

int? score1 = null;
int defaultScore = score1 ?? -1;
Console.WriteLine($"점수: {defaultScore}");

int? health = null;
int actualhealth = health ?? default(int);
Console.WriteLine($"체력: {actualhealth}");

string first = null, second = null, third = "세 번째 값";
Console.WriteLine(first ?? second ?? third);