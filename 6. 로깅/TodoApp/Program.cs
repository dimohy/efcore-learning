using Microsoft.EntityFrameworkCore;

using TodoApp.DbContexts;
using TodoApp.Entities;

using var c = new TodoContext();

/* 추가 {{{
var newUser = new UserInfo
{
    UserId = "test",
    UserName = "test"
};

c.Users.Add(newUser);

Console.WriteLine(c.Entry(newUser).State);

var result = c.SaveChanges();
Console.WriteLine(result);

Console.WriteLine(c.Entry(newUser).State);
}}} */



/* 변경 {{{
var testUser = c.Users.Find("test")!;
Console.WriteLine(testUser);

Console.WriteLine(c.Entry(testUser).State);

testUser.UserName = "테스트";

Console.WriteLine(c.Entry(testUser).State);

var result = c.SaveChanges();
Console.WriteLine(result);

Console.WriteLine(c.Entry(testUser).State);

testUser = c.Users.Find("test")!;
Console.WriteLine(testUser);
*/


/* 삭제 {{{
var testUser = c.Users.Find("test")!;

Console.WriteLine(c.Entry(testUser).State);

c.Users.Remove(testUser);

Console.WriteLine(c.Entry(testUser).State);

var result = c.SaveChanges();
Console.WriteLine(result);

Console.WriteLine(c.Entry(testUser).State);

testUser = c.Users.Find("test")!;
Console.WriteLine(testUser);
}}} */


/* 탐색 속성 추적 확인 {{{
var testUser = c.Users.Include(x => x.Todos).First(x => x.UserId == "test");
var newTodo = new TodoInfo
{
    //UserId = "test",
    TodoDate = DateOnly.FromDateTime(DateTime.Now),
    IsComplete = false,
    IsDel = false,
    Memo = "탐색 속성 변경 추적 확인",
    Tags = new TodoTagInfo[] { new() { TagId = "dev", Descption = "개발" }, new() { TagId = "test", Descption = "테스트" } }
};

testUser.Todos.Add(newTodo);

var result = c.SaveChanges();
Console.WriteLine(result);
}}} */

var testUser =  c.Users
                .Include(user => user.Todos)
                    .ThenInclude(todo => todo.Tags)
                .First(x => x.UserId == "test");

foreach (var testTodos in testUser.Todos)
{
    Console.WriteLine(testTodos.Memo);
    foreach (var tag in testTodos.Tags)
        Console.WriteLine($"Tags : {tag.TagId} - {tag.Descption}");
}
