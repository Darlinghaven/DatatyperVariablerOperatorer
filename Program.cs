// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the incredibly awesome quiz about Duke Darlinghaven! \n" +
    "The quiz will cosist of a question and 4 different option for answers. \n" +
    "To be able to answer the questions you will have to visit my webpage Darlinghaven.com. \n" +
    "Use 1, 2, 3, or 4 to select an answer. \n" +
    "The correct answers will be revealed after all questions have been answered. \n" +
    "Good luck!");

Console.WriteLine("");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();
Console.WriteLine("");

int correctAnswers = 0;
bool quizCompleted = false;

Console.WriteLine("Question 1: \n" +
    "Duke Darlinghaven has a bachelors degree in what field? \n" +
    "1) Software Engineering \n" +
    "2) English \n" +
    "3) Law \n" +
    "4) Econimics");
Console.WriteLine("");
string answerOne = Console.ReadLine();
int numberOne = Int32.Parse(answerOne);
if (numberOne == 3) correctAnswers++;
Console.WriteLine("answer " + numberOne + " selected.");
Console.WriteLine("");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();
Console.WriteLine("");

Console.WriteLine("Question 2: \n" +
    "Duke Darlinghaven has been working as an unskilled waiter for approximately how many years? \n" +
    "1) 1½ years \n" +
    "2) 2½ years \n" +
    "3) 3½ years \n" +
    "4) 4½ years");
Console.WriteLine("");
string answerTwo = Console.ReadLine();
int numberTwo = Int32.Parse(answerTwo);
if (numberTwo == 3) correctAnswers++;
Console.WriteLine("answer " + numberTwo + " selected.");
Console.WriteLine("");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();
Console.WriteLine("");

Console.WriteLine("Question 3: \n" +
    "Duke Darlinghaven has an ambition to develop what in the future? \n" +
    "1) Legal Tech \n" +
    "2) Fintech \n" +
    "3) Health Tech \n" +
    "4) Video games");
Console.WriteLine("");
string answerThree = Console.ReadLine();
int numberThree = Int32.Parse(answerThree);
if (numberThree == 1) correctAnswers++;
Console.WriteLine("answer " + numberThree + " selected.");
Console.WriteLine("");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();
Console.WriteLine("");

Console.WriteLine("Question 4: \n" +
    "What is the first letter in Duke Darlinghaven's name? \n" +
    "1) A \n" +
    "2) B \n" +
    "3) C \n" +
    "4) D");
Console.WriteLine("");
string answerFour = Console.ReadLine();
int numberFour = Int32.Parse(answerFour);
if (numberFour == 4) correctAnswers++;
Console.WriteLine("answer " + numberFour + " selected.");
Console.WriteLine("");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();
Console.WriteLine("");

quizCompleted = true;
double scorePercentage = (correctAnswers / 4.0) * 100;
Console.WriteLine("Quiz Completed: ");
Console.WriteLine("You answered " + correctAnswers + " out of 4 questions correctly.");
Console.WriteLine("Your score: " + scorePercentage + "%");

Console.WriteLine("I hope you enjoyed the quiz! Here are the correct answers: \n" +
    "Duke Darlinghaven has a LL.B which is a bachelors of Laws. He has been working as an unskilled waiter " +
    "for approximately 3½ years at the time of making the quiz. He hopes to develop Legal Tech in the future. " +
    "And finally D is the fist letter in his fist name.");

Console.ReadKey();