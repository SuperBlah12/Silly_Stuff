/* Die Roller
 * Generates random numbers.
 * requirements
 * Create a do loop that asks the user if they want to roll the dice (yes or no) until the user says no.
 * • At the beginning of the loop ask the user how many sides the dice has (either 4, 6, 8, 10, 12, or 20).
 * • Use the rand() function and output the statement "You rolled a " and then a random number that can be found on the type
 * of dice they chose.  So a 6 sided dice can give the number 1 through 6.
 * • Use a switch statement to check the user input for the sides of dice.  There should be 6 case statements (1 for each
 * type of dice).
 * • Just before the program exits print out an exit statement.
 */

#include <iostream>
#include <cstdlib>
#include <ctime>
#include <string>

using namespace std;

int main(){
    int input;
    srand(static_cast<unsigned int>(time(0))); //seed random number
    int die;
    string cont = "y";
    do{
        int randNum = rand(); //generate random number
        cout << "How many sides?\n4, 6, 8, 10, 12, or 20?\nYour selection: ";
        cin >> input;
        switch(input)//die selector based off input
        {
         case 4:
            die = (randNum%4) +1; //get a number between 1 and 4
            break;
         case 6:
            die = (randNum%6) +1; //get a number between 1 and 6
            break;
         case 8:
            die = (randNum%8) +1; //get a number between 1 and 8
            break;
         case 10:
            die = (randNum%10) +1; //get a number between 1 and 10
            break;
         case 12:
            die = (randNum%12) +1; //get a number between 1 and 12
            break;
         case 20:
            die = (randNum%20) +1; //get a number between 1 and 20
            break;
         default://you dun goofed, don't have that many sides.
            cout << "That's not an option. You get a d6.\n";
            die = (randNum%6) +1; //get a number between 1 and 6
            break;
        }
        cout << "You rolled a " << die << endl;
        cout << "Continue? Y or N: ";
        cin >> cont; //the exit key
    }while(cont == "y" || cont == "Y");
    cout << "\nThank you for playing!" << endl;
    return 0;
}
