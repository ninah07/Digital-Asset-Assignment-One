using System;

public class Program
{
	public static void Main()
	{
		bool exit = false;
		while (exit == false)	
		{
			Console.Clear();
			Console.WriteLine("***************************************************************************************************");
			Console.WriteLine("*                                                                                                 *");
			Console.WriteLine("*                                    Welcome to Game Alley!                                       *");
			Console.WriteLine("*                                                                                                 *");
			Console.WriteLine("*    Please select an option below:                                                               *");	
			Console.WriteLine("*    ➪ Press S to play Scissors, Paper, Rock                                                     *");
			Console.WriteLine("*    ➪ Press N to play Naughts and Crosses                                                       *");
			Console.WriteLine("*    ➪ Press E to Exit                                                                           *");
			Console.WriteLine("*                                                                                                 *");			  
			Console.WriteLine("***************************************************************************************************");

			
			string input = Console.ReadLine();
			if (input.ToUpper() == "E")
			{
				Console.Clear();
				Console.WriteLine("👾 Exiting Game Alley... Goodbye!");
				exit = true;
			}
			else if (input.ToUpper() == "N")
			{
				OX();
			}
			else if (input.ToUpper() == "S")
			{
				RPS(); 
			}
			
		}
		
	}
	
	// START OF RPS
	public static void RPS()
	{
		bool playLoop = true;
		int playerPoints;
		int player2Points;
		string player2name = "Nina";
		string[] weapon = {"Scissors", "Paper", "Rock"};	
		while (playLoop)
		{	
			playerPoints = 0;
			player2Points = 0;
			Console.Clear();
			Console.WriteLine("Welcome to Scissors, Paper, Rock! Best of three.");
			Console.WriteLine("");
			Console.WriteLine("Player you are versing today is " + player2name);
			Console.WriteLine("Please select the number correlating to the weapon you would like to use:");
			
			Console.WriteLine("➪ 0. " + weapon[0]);
			Console.WriteLine("➪ 1. " + weapon[1]);
			Console.WriteLine("➪ 2. " + weapon[2]);
			
			for(int i = 0; i < 3; i++){
			string playerChoice = Console.ReadLine();
			if (playerChoice != "0" && playerChoice != "1" && playerChoice != "2")
			{
				Console.WriteLine("Invalid choice. Please try again.");
				i=i-1;
			}
			else 
			{
				Random randomChoice = new Random();
				int player2Choice = randomChoice.Next(0, 3);
				switch (player2Choice)
				{
					case 1:
					if (playerChoice == "0")
					{
						Console.WriteLine ("You have chosen Scissors.");
						Console.WriteLine(player2name + " has chosen Scissors.");
					  	Console.WriteLine("Tied Round!"); 
					}
					else if (playerChoice == "1")
					{
						Console.WriteLine("You have chosen Paper.");
					 	Console.WriteLine(player2name + " has chosen Scissors.");
					  	Console.WriteLine(player2name + " wins this round!");
						 player2Points++;
					}
					else if (playerChoice == "2")
					{
						Console.WriteLine("You have chosen Rock.");
					   	Console.WriteLine(player2name + " has chosen Scissors.");
						Console.WriteLine("You win this round!");
					   	playerPoints++;
					}
					break;
					
				case 2:
					if (playerChoice == "0")
					{
						Console.WriteLine ("You have chosen Scissors.");
					 	Console.WriteLine(player2name + " has chosen Paper.");
					  	Console.WriteLine("You win this round!"); 
						playerPoints++;}
					else if (playerChoice == "1")
					{
						Console.WriteLine("You have chosen Paper.");
					 	Console.WriteLine(player2name + " has chosen Paper.");
					  	Console.WriteLine("Tied round!");}
					else if (playerChoice == "2")
					{
						Console.WriteLine("You have chosen Rock.");
					  	Console.WriteLine(player2name + " has chosen Paper.");
						Console.WriteLine(player2name + " wins this round!");
					   	player2Points++;
					}	
					break;
					
				case 3:
					if (playerChoice == "0")
					{
						Console.WriteLine ("You have chosen Scissors.");
					 	Console.WriteLine(player2name + " has chosen Rock.");
					  	Console.WriteLine(player2name + " wins this round!"); 
						player2Points++;}
					else if (playerChoice == "1")
					{
						Console.WriteLine("You have chosen Paper.");
					 	Console.WriteLine(player2name + " has chosen Rock.");
					  	Console.WriteLine("You win this round!");
					 	playerPoints++;
					}
					else if (playerChoice == "2")
					{
						Console.WriteLine("You have chosen Rock.");
					   	Console.WriteLine(player2name + " has chosen Rock.");
						Console.WriteLine("Tied round!");
					}
					break;
			}
		}
	}
	Console.WriteLine("");		
	Console.WriteLine("Match completed! Final scores: \nYou - " + playerPoints);
	Console.WriteLine(player2name + " - " + player2Points);
	Console.WriteLine("");	
	Console.WriteLine("Do you wish to play again?");
	Console.WriteLine("Enter Y to play again, anything else to exit.");
	string answer = Console.ReadLine();
	if (answer.ToUpper() == "Y")
	{
		playLoop = true;
	}
	else 
	{
		playLoop = false;
		Console.WriteLine("Thanks for playing! Returning to main menu now..."); 
		Main();		
	}
	}
	
	}	// END OF RPS
	
	//START OF OX
	public static void OX()
	{
		bool playLoop = true; 
		char Player1 = 'O';
		char Player2 = 'X';
		bool foundWinner = false;
		int pos;
		int pos2;
		bool isValid = false; 
		bool draw = false;
		string Winner = "";
		char[] ArrBoard = {'1', '2', '3','4', '5', '6','7', '8', '9'}; 

		while (playLoop)
		{
			foundWinner = false;
			isValid = false;
			draw = false;
			Winner = "";
			ArrBoard[0] = '1'; 
			ArrBoard[1] = '2'; 
			ArrBoard[2] = '3'; 
			ArrBoard[3] = '4'; 
			ArrBoard[4] = '5'; 
			ArrBoard[5] = '6'; 			
			ArrBoard[6] = '7'; 
			ArrBoard[7] = '8'; 
			ArrBoard[8] = '9'; 
					    
			
			Console.Clear();			
			Console.WriteLine("Welcome to Naughts and Crosses! Obtain three in a row.");
			
			for (int i = 0 ; i < 10; i++)
			{
				isValid = false;
				Console.Clear();
				Console.WriteLine("          |        |        ");
				Console.WriteLine("     {0}    |   {1}    |   {2}  ", ArrBoard[0], ArrBoard[1], ArrBoard[2]);
				Console.WriteLine("          |        |        ");
				Console.WriteLine("  ________ _______ ________\n");
				Console.WriteLine("          |        |         ");
				Console.WriteLine("     {0}    |   {1}    |   {2}   ", ArrBoard[3], ArrBoard[4], ArrBoard[5]);
				Console.WriteLine("          |        |       ");
				Console.WriteLine("  ________ _______ ________\n");
				Console.WriteLine("          |        |       ");
				Console.WriteLine("     {0}    |   {1}    |   {2}   ", ArrBoard[6], ArrBoard[7], ArrBoard[8]);
				Console.WriteLine("          |        |         ");
				
				if (foundWinner == true || draw == true)
				{
					goto endGame;
				}	
			
				if (i%2 == 0) 
				{
					Console.WriteLine("Player 1, please select your position on the board.");
					while (!isValid)
					{
						Console.WriteLine("Enter an integer value only.");
						string input = Console.ReadLine();

						if (!int.TryParse(input, out pos))
						{
							Console.WriteLine("The input {0}' is not an integer.", input);
						}
						else if (pos < 1 || pos > 9)
						{
							Console.WriteLine("Please enter the number between 1 to 9");
						}
						else if (ArrBoard[pos - 1] == Player1 || ArrBoard[pos - 1] == Player2)
						{
							Console.WriteLine("Player 1, the position is already taken! Please try again.");
						}		
						else 
						{
							isValid = true; 
							ArrBoard[pos - 1] = Player1;
						}
					}
				}	
				
				else 
				{
					Console.WriteLine("Player 2, please select your position on the board.");
					while (!isValid)
					{
						Console.WriteLine("Enter the integer value only.");
						string input = Console.ReadLine();

						if (!int.TryParse(input, out pos2))
						{
							Console.WriteLine("The input {0}' is not an integer.", input);
						}
						else if (pos2 < 1 || pos2 > 9)
						{
							Console.WriteLine("Please enter the number between 1 to 9");
						}
						else if (ArrBoard[pos2 - 1] == Player1 || ArrBoard[pos2 - 1] == Player2)
						{
							Console.WriteLine("Player 2, the position is already taken! Please try again.");
						}		
						else 
						{
							isValid = true; 
							ArrBoard[pos2 - 1] = Player2;
						}
					}
				}	
				
    		// after 4 turns, there could be a winner 
				if (i >= 4)
				{
					 //check horizontal win 		
					if ((ArrBoard[0] == Player1) && (ArrBoard[1] == Player1) && (ArrBoard[2] == Player1)
						|| (ArrBoard[3] == Player1) && (ArrBoard[4] == Player1) && (ArrBoard[5] == Player1)
						|| (ArrBoard[6] == Player1) && (ArrBoard[7] == Player1) && (ArrBoard[8] == Player1))
					{
						foundWinner = true;
						Winner = "Player1";
					}

					else if ((ArrBoard[0] == Player2) && (ArrBoard[1] == Player2) && (ArrBoard[2] == Player2)
						|| (ArrBoard[3] == Player2) && (ArrBoard[4] == Player2) && (ArrBoard[5] == Player2)
						|| (ArrBoard[6] == Player2) && (ArrBoard[7] == Player2) && (ArrBoard[8] == Player2))
					{
						foundWinner = true;
						Winner = "Player2";
					}

					//check vertical win
					else if ((ArrBoard[0] == Player1) && (ArrBoard[3] == Player1) && (ArrBoard[6] == Player1)
						|| (ArrBoard[1] == Player1) && (ArrBoard[4] == Player1) && (ArrBoard[7] == Player1)
						|| (ArrBoard[2] == Player1) && (ArrBoard[5] == Player1) && (ArrBoard[8] == Player1))
					{
						foundWinner = true;
						Winner = "Player1";
					}					
					else if ((ArrBoard[0] == Player2) && (ArrBoard[3] == Player2) && (ArrBoard[6] == Player2)
						|| (ArrBoard[1] == Player2) && (ArrBoard[4] == Player2) && (ArrBoard[7] == Player2)
						|| (ArrBoard[2] == Player2) && (ArrBoard[5] == Player2) && (ArrBoard[8] == Player2))
					{
						foundWinner = true;
						Winner = "Player2";
					}

					//check diagonal win
					else if ((ArrBoard[0] == Player1) && (ArrBoard[4] == Player1) && (ArrBoard[8] == Player1)
						|| (ArrBoard[2] == Player1) && (ArrBoard[4] == Player1) && (ArrBoard[6] == Player1))
					{
						foundWinner = true;
						Winner = "Player1";
					}

					else if ((ArrBoard[0] == Player2) && (ArrBoard[4] == Player2) && (ArrBoard[8] == Player2)
						|| (ArrBoard[2] == Player2) && (ArrBoard[4] == Player2) && (ArrBoard[6] == Player2))
					{
						foundWinner = true;
						Winner = "Player2";
					}
				}

				if (i == 8) 
				{ 
					draw = true;
					Winner = "No one";
				}	
			} // move on to next i
			
			
		endGame: 
			if (Winner == "Player1")
			{
				Console.WriteLine("CONGRATULATIONS! Player 1 Wins!");
			}
			else  if (Winner == "Player2")
			{
				Console.WriteLine("CONGRATULATIONS! Player 2 Wins!");
			}	
			else  if (Winner == "No one")
			{
				Console.WriteLine("Sorry, it is a draw!");
			}		

			Console.WriteLine("Do you wish to play again?");
			Console.WriteLine("Enter Y to play again, anything else to exit.");
			string answer = Console.ReadLine();
			if (answer.ToUpper() == "Y")
			{
				playLoop = true;
			}
			else 
			{
				playLoop = false;
				Console.WriteLine("Thanks for playing! Returning to main menu now..."); 
				Main();
			}
	
		}// end while playLoop
		
	}// end XO game
	
} //end program
