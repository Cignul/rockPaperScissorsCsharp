using System;
using System.Collections.Generic;
//using day_1.Models;
namespace roshamboC
{
  class Program

  {
    static void Main(string[] args)
    {
      string rock = "rock";
      string paper = "paper";
      string scissors = "scissors";

      Console.WriteLine("Would you like to throw rock paper or scissors??");
      string userSelection = Console.ReadLine();
      Random rnd = new Random();
      int compRndNum = rnd.Next(1, 4);
      System.Console.WriteLine(compRndNum);

      string compChoice = " ";

      if (compRndNum == 1)
      {
        compChoice = rock;
        Console.WriteLine(compChoice);
      }
      if (compRndNum == 2)
      {
        compChoice = paper;
        Console.WriteLine(compChoice);
      }
      if (compRndNum == 3)
      {
        compChoice = scissors;
        //Console.WriteLine(compChoice);
      }

      if (userSelection == rock && compChoice == rock)
      {
        Console.WriteLine("Tie Game");
      }
      if (userSelection == paper && compChoice == rock)
      {
        Console.WriteLine("You Win, goodjob");
      }
      if (userSelection == scissors && compChoice == rock)
      {
        Console.WriteLine("You Lost, computer probably cheated");
      }
      if (userSelection == rock && compChoice == paper)
      {
        Console.WriteLine("You Lost, computer probably cheated");
      }
      if (userSelection == paper && compChoice == paper)
      {
        Console.WriteLine("Tie game, like kissing your sister");
      }
      if (userSelection == scissors && compChoice == paper)
      {
        Console.WriteLine("Victory!!!");
      }
      if (userSelection == scissors && compChoice == scissors)
      {
        Console.WriteLine("Tie game, whomp");
      }
      if (userSelection == paper && compChoice == scissors)
      {
        Console.WriteLine("You lost, probably hax");
      }
      if (userSelection == rock && compChoice == scissors)
      {
        Console.WriteLine("You won, you majestic fox");
      }

    }
  }
}







