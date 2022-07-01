// 지연 로드를 이용해 관계(탐색) 속성 접근 확인

using LazyLoadingSample.DbContexts;

using var c = new Context();

/*
// 사용자 및 부서 삽입 {{{
var newUser = new User
{
    UserId = "test",
    UserName = "테스트",
    Depts = new List<Dept> { new() { DeptId = "test_grp", DeptName = "테스트 부서" } }
};

c.Users.Add(newUser);
c.SaveChanges();
// }}}
*/


var user = c.Users.Find("test");
if (user is null)
    return;

Console.WriteLine($"User : {user.UserName}({user.UserId})");
Console.WriteLine($"User Dept : {user.Depts.First().DeptName}");
