Console.WriteLine("Did you have particepated in the first written exam");
string firstexam = Console.ReadLine()!;
double totalpoints = 0;
double possiblepoints = 0;

if (firstexam == "yes"){
    Console.WriteLine("How many points did you get 0 - 20 ");
    int firstpoints = int.Parse(Console.ReadLine()!);
    totalpoints += firstpoints;
    possiblepoints += 20;
}
else {
    Console.WriteLine("It is a shame");
}
Console.WriteLine("Did you particepate in a sceond exam");
string sceondexam = Console.ReadLine()!;

if  ( sceondexam == "yes"){
    Console.WriteLine("How many points did you get in your second exam 0 - 20");
    int secondpoints = int.Parse(Console.ReadLine()!);
    totalpoints += secondpoints;
    possiblepoints += 20;
}
else{
    Console.WriteLine("What a shame");
    
}



Console.WriteLine("How many points did you get on your homework");
   int homework = int.Parse(Console.ReadLine()!);
    possiblepoints += 20;
    totalpoints += homework;

Console.WriteLine("Did you take a oral exams");
string oral = Console.ReadLine()!;
if (oral == "yes"){
    Console.WriteLine("How many points did you get on your oral exam");
    int oralpoints = int.Parse(Console.ReadLine()!);
    possiblepoints += 20;
    totalpoints += oralpoints;
}
else {
    Console.WriteLine("What a shame");

}


double grade = totalpoints/possiblepoints *100;

Console.WriteLine(grade);
if ( grade > 89){
    Console.WriteLine("You grade is 1");
}
else if (grade >= 76){
    Console.WriteLine("Your grade is 2");
}
else if (grade >= 63){
    Console.WriteLine("Your grade is 3");

}
else if (grade >= 50){
    Console.WriteLine("Your grade is a 4");
}
else if (grade <= 49){
    Console.WriteLine("Sry you didn´t pass");
}
double homeworkall = (totalpoints - homework + 20)/possiblepoints *100;
if (grade != homeworkall){
    Console.WriteLine("You could have gotten a better greade when you got full points on your homework");
}
else{
    Console.WriteLine("It doesn´t make a diffrenz");
}
