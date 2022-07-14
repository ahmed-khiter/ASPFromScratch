

using ExampleAspFromScratch;

var context = new ApplicationDbContext();

context.Users.Add(new User{
    Name = "Ahmed"
});