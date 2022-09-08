// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
WorkWithIntegers();

void WorkWithIntegers()
{
    int year = 18;
    int sisyear = 6;
    int totalyears = year + sisyear;
    Console.WriteLine($"If I add my sister's years and mine the total is {totalyears}");


    // subtraction
    totalyears = sisyear - year;
    Console.WriteLine($"If I substract my sister's years and mine the total is {totalyears}");

    // multiplication
    totalyears = year * sisyear;
    Console.WriteLine($"If I multiply my sister's years and mine the total is {totalyears}");
    // division
    totalyears = year / sisyear;
    Console.WriteLine($"If I divide my sister's years and mine the total is {totalyears}");
}
// WorkWithIntegers();
OrderPrecedence();


{
    int me = 18;
    int dad = 40;
    int total = me + dad;
    Console.WriteLine($"If I add my dad's years and mine the total is {total}");


    // subtraction
    total = dad - me;
    Console.WriteLine($"If I substract my dad's years and mine the total is {total}");

    // multiplication
    total = me * dad;
    Console.WriteLine($"If I multiply my dad's years and mine the total is {total}");

    // division
    total = me / dad;
    Console.WriteLine($"If I divide my dad's years and mine the total is {total}");
}

void OrderPrecedence()
{
    int me = 18;
    int dad = 40;
    int mom = 39;
    int d = me + dad * mom;
   Console.WriteLine($"If I multiply my dad's years and my mom's years, and then add mine the total is {d}");

    d = (me + dad) * mom;
   Console.WriteLine($"If I add my dad's years and my mom's years, and multiply mine the total is {d}");

    d = (me + dad) - 6 * mom + (12 * 4) / 3 + 12;
    Console.WriteLine($"If I add my dad's years and mine, substract the multiplication of 6 and my mom's years, and add the division of the 12*4 and 3+12 the total is {d}");

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}



int strawberries = 7;
int grapes = 4;
int friends = 3;
int share = (strawberries + grapes) / friends;
int got = (strawberries + grapes) % friends;
Console.WriteLine($"I dived 7 strawberries and 4 grapes with 2 friends I gave them more, so they got {share}");  /*quotient*/
Console.WriteLine($"and I got {got}"); //remainder



int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

double cupcake = 10;
double muffin = 40;
double people = 25;
double bread = (cupcake + muffin) / people;
Console.WriteLine("My mom buy cupcakes and muffins for a party.");
Console.WriteLine($"If she add them and divided with the people that are comings each of them will eat {bread}");

double comedy = 15;
double terror = 25;
double g = 8;
double students = (comedy + terror) / g;
Console.WriteLine($"There are some ticket for a Comedy or a Terror movie, there is a limit if we add the tickets and divided do each of the students can go with a partner, only {students} students can get doble tickets.");

double max1 = double.MaxValue;
double min1 = double.MinValue;
Console.WriteLine($"The range of double is {min1} to {max1}");

double third = 1.0 / 3.0;
Console.WriteLine($"If I divide my $1.00 into 3 friends, each of them will get ${third}.");

//Challenge #1
WorkWithDoubles();
void WorkWithDoubles()
{
double first = 14.0 / 5.0;
Console.WriteLine(first);
double second = 70098774.0 / 867.0;
Console.WriteLine(second);
double fourth = 1234567890 / 1234;
Console.WriteLine(fourth);
double fifth = -76543 / 3245;
Console.WriteLine(fifth);}
//End of challege #1

decimal min2 = decimal.MinValue;
decimal max2 = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

double Decimal1 = 1.0;
double Decimal2 = 3.0;
Console.WriteLine(Decimal1 / Decimal2 );

decimal Decimal3 = 1.0M;
decimal Decimal4 = 3.0M;
Console.WriteLine(Decimal3 / Decimal4);

//Challenge #2
double rad = 2.5;
double Solution = (rad * rad) * Math.PI;
Console.WriteLine($"The area of the circle is {Solution}");
//End of challege #2