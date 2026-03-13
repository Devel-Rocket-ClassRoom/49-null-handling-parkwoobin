using System;

// README.md를 읽고 아래에 코드를 작성하세요.



// 플레이어 이름
string PlayeruserSetting = null;
string PlayerprofileSetting = "프로필유저";
string PlayerglobalSetting = null;
string PlayerdefaultValue = "Player";

// 서버 주소
string ServeruserSetting = null;
string ServerprofileSetting = null;
string ServerglobalSetting = null;
string ServerdefaultValue = "localhost";

// 언어
string LanguageuserSetting = "English";
string LanguageprofileSetting = "Korean";
string LanguageglobalSetting = "Japanese";
string LanguagedefaultValue = "Korean";

// 볼륨
int? VolumeuserSetting = null;
int? VolumeprofileSetting = null;
int? VolumeglobalSetting = 70;
int? VolumedefaultValue = 50;



Console.WriteLine("\n=== 설정 결정 ===");

Console.WriteLine($"플레이어 이름: {PlayerprofileSetting} (프로필 설정에서 가져옴)");
Console.WriteLine($"서버 주소: {ServerdefaultValue} (기본값에서 가져옴)");
Console.WriteLine($"언어: {LanguageuserSetting} (사용자 설정에서 가져옴)");
Console.WriteLine($"볼륨: {VolumeglobalSetting} (전역 설정에서 가져옴)");

Console.WriteLine("\n=== 캐시 저장 (??=) ===");
Console.WriteLine($"캐시 저장 전: {PlayeruserSetting ?? "null"}");
Console.WriteLine($"첫 번째 ??= 적용 후: {PlayeruserSetting ??= "프로필유저"}");
Console.WriteLine($"두 번째 ??= 적용 후: {PlayerglobalSetting ??= "프로필유저"}");

Console.WriteLine("\n=== 최종 설정 ===");
Console.WriteLine($"플레이어 이름: {PlayerprofileSetting}");
Console.WriteLine($"서버 주소: {ServerdefaultValue}");
Console.WriteLine($"언어: {LanguageuserSetting}");
Console.WriteLine($"볼륨: {VolumeglobalSetting}");
