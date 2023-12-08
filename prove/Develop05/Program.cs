using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        GoalRecord goal = new GoalRecord();
    
    
        int _num = 0;
        while(_num !=6){

            Console.Write($"You have {goal.TotalMath()} points.\n");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal"); 
            Console.WriteLine("2. List Goals"); 
            Console.WriteLine("3. Save Goals"); 
            Console.WriteLine("4. Load Goals"); 
            Console.WriteLine("5. Record Event"); 
            Console.WriteLine("6. Quit"); 
            Console.Write("Select a choice from the menu: ");   
            
        string answer = Console.ReadLine();
        _num = int.Parse(answer);

            switch (_num){
                case 1:
                    int _number = 0;
                    while(_number !=4){
                        Console.WriteLine("The type goals are: ");
                        Console.WriteLine("1. Simple Goal"); 
                        Console.WriteLine("2. Eternal Goal"); 
                        Console.WriteLine("3. Checklist Goals");  
                        Console.WriteLine("4. Quit to main menu"); 
                        Console.Write("Which type of goal would you like to create?: ");
                        string ans = Console.ReadLine();
                        _number = int.Parse(ans);

                    Console.Clear();
                    switch (_number){
                        case 1:
                            SimpleGoal gSimple = new SimpleGoal();
                            gSimple.NewGoal();
                            goal.addGoal(gSimple);
                        break;
                            
                        case 2:
                            EternalGoal gEternal = new EternalGoal();
                            gEternal.NewGoal();
                            goal.addGoal(gEternal);
                        break;

                        case 3: 
                           ChecklistGoal gChecklist = new ChecklistGoal();
                           gChecklist.NewGoal();
                           goal.addGoal(gChecklist);
                        break;

                        case 4:
                            
                        break;
                        }
                    }
                break;

                case 2:
                
                    goal.ListGoals();
                break;

                case 3:
                    goal.SaveGoals();        
                break;

                case 4:
                    goal.LoadGoals();
                break;

                case 5:
                    goal.RecordEvents();
                break;

                case 6:
                    Environment.Exit(0);
                    Console.WriteLine("Bye");
                break;

            }
        }
    }

}