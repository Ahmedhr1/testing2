using System;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

int myrandom;
int enemyrand;
int points = 0;
int ep = 0;

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any key to roll youre dice");
    Console.ReadLine();
    myrandom = random.Next(1, 7);
    Console.WriteLine(" You rolled a " + myrandom);

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(10);

    enemyrand = random.Next(1, 7);
    Console.WriteLine(" Enemy rolled a " + enemyrand);

    if(myrandom > enemyrand)
    {


        Console.WriteLine("You win");
        points++;

    }
    else if ( enemyrand > myrandom)
    {

        Console.WriteLine("Enemy win");
        ep++;


    }
    else
    {

        Console.WriteLine("Draw");



    }



}

if (points > ep)
{



    Console.WriteLine("Ahmed won the game");


}
else if ( ep > points)
{


    Console.WriteLine("You lose the game");



}
else
{

    Console.WriteLine("its a draw");


}