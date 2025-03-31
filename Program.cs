using System;

List<string> task = new List<string>();

void main()
{
    bool runProgram = true;
    do
    {
        Console.WriteLine("New task app in C# by MechaSaur\n");
        Console.WriteLine("1. Add Task\n" +
            "2. Delete Task\n" +
            "3. Check Task\n" +
            "4. Exit'\n" +
            "Input: ");
        string userAnswer = Console.ReadLine();
        while (string.IsNullOrEmpty(userAnswer))
        {
            Console.WriteLine("Your answer can not be empty'\n");
            userAnswer = Console.ReadLine();
        }

        int userNumber = Convert.ToInt32(userAnswer);
        switch(userNumber)
        {
            case 1:
                AddTask();
                break;
            case 2:
                DeleteTask();
                break;
            case 3:
                CheckTask();
                break;
            case 4:
                runProgram = false;
                break;
        }
    }
    while (runProgram);
}
main();
void AddTask()
{
    bool moreTask = true;
    while (moreTask)
    {
        Console.WriteLine("Enter your task: \n");
        string taskName = Console.ReadLine();
        while (string.IsNullOrEmpty(taskName))
        {
            Console.WriteLine("Task can not be empty\n");
            taskName = Console.ReadLine();
        }
        Console.WriteLine("Do you want to add more task? Y/N\n");
        string answer = Console.ReadLine();
        while (string.IsNullOrEmpty(answer))
        {
            Console.WriteLine("Answer can not be empty\n");
            answer = Console.ReadLine();
        }
        if (answer.ToLower().Trim() == "y")
        {
            moreTask = true;
        }
        else
        {
            moreTask = false;
        }
        task.Add(taskName);
    }
}
void CheckTask()
{
    foreach (string task in task)
    {
        Console.WriteLine($"Task Name: {task}");
    }
}

void DeleteTask()
{
    Console.WriteLine("Enter the name of the task that you want to remove\n");
    string taskToDelete = Console.ReadLine();
    while (string.IsNullOrEmpty(taskToDelete))
    {
        Console.WriteLine("You must enter a task name\n");
        taskToDelete = Console.ReadLine();
    }
    if(!task.Contains(taskToDelete))
    {
        Console.WriteLine("That task does not exist in your to-do-list\n");
    }
    else
    {
        task.Remove(taskToDelete); 
    }
}





