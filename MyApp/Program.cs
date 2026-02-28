using Domain.Models;

Person persons = new();
persons.Greeet();
persons.Greeet();
Student person = new Student();
person.SetAge(21);
person.ShowAge();
person.Study();
persons.Greeet();
Teacher teacher = new();
teacher.Explain();