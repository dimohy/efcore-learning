using Microsoft.EntityFrameworkCore;

using TodoApp.DbContexts;

using var c = new TodoContext();

// 사용자 추가
/*
c.Users.Add(new()
{
    UserId = "dimohy",
    UserName = "디모이"
});

c.Users.Add(new()
{
    UserId = "test",
    UserName = "테스트"
});

c.SaveChanges();
*/

// 오늘 할일 추가
/*
c.Todos.Add(new()
{
    UserId = "dimohy",

    TodoDate = new DateOnly(2022, 6, 12),
    Memo = "`EF Core 6 배우기 - 3. DB 컨텍스트` 완료",
});

c.Todos.Add(new()
{
    UserId = "test",

    TodoDate = new DateOnly(2022, 6, 12),
    Memo = "삽입 테스트",
});

c.SaveChanges();
*/


//var dimohy = c.Users.Include(x => x.Todos).First(x => x.UserId == "dimohy");
//Console.WriteLine(dimohy);

//foreach (var todo in dimohy.Todos)
//{
//    Console.WriteLine(todo);
//}

//var todos = c.Todos.Where(x => x.UserId == "dimohy").Include(x => x.User);
//foreach (var todo in todos)
//{
//    Console.WriteLine(todo);
//}


var testTodo = c.Todos.First(x => x.UserId == "test");
testTodo.IsComplete = true;
testTodo.CompleteDate = DateOnly.FromDateTime(DateTime.Now);
c.SaveChanges();


//foreach (var user in c.Users)
//{
//    Console.WriteLine(user);
//}