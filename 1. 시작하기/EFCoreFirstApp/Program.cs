using EFCoreFirstApp.DbContexts;
using EFCoreFirstApp.Entities;

using var c = new FirstAppContext();

// 갯수 조회
var count = c.LogHistories.Count();

// 목록 3개 추가
var lastSeq = 0;
for (var i = 0; i < 3; i++)
{
    var newinfo = new LogHistory($"{i + 1}번째 데이터");
    c.LogHistories.Add(newinfo);

    c.SaveChanges();    
    // 저장 후 식별번호 생성됨
    lastSeq = newinfo.Seq;
}

// 목록 조회
foreach (var info in c.LogHistories)
{
    Console.WriteLine($"{info.Seq} : {info.Detail}, {info.CreateTime}");
}

// 추가한 목록 중 마지막 항목 수정
var targetInfo = c.LogHistories.First(x => x.Seq == lastSeq);
targetInfo.Detail += "(수정함)";
c.SaveChanges();

Console.WriteLine();

// 다시 목록 조회
foreach (var info in c.LogHistories)
{
    Console.WriteLine($"{info.Seq} : {info.Detail}, {info.CreateTime}");
}

Console.WriteLine();

// 마지막 항목 삭제
c.LogHistories.Remove(targetInfo);
c.SaveChanges();

// 다시 목록 조회
foreach (var info in c.LogHistories)
{
    Console.WriteLine($"{info.Seq} : {info.Detail}, {info.CreateTime}");
}
