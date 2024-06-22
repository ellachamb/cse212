public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue Bob (6), Suzy (2), Jim (10) and Dequeue highest priority
        // Expected Result: Jim
        Console.WriteLine("Test 1");
        var players = new PriorityQueue();
        players.Enqueue("Bob", 6);
        players.Enqueue("Suzy", 2);
        players.Enqueue("Jim", 10);
        var result = players.Dequeue();
        Console.WriteLine(result);
        // Defect(s) Found: 
        // Bob is incorrectly dequeued first
        Console.WriteLine("---------");

        // Test 2
        // Scenario: Empty Queue
        // Expected Result: Error message
        Console.WriteLine("Test 2");
        var players2 = new PriorityQueue();
        var result2 = players2.Dequeue();
        Console.WriteLine(result2);

        // Defect(s) Found: 
        // No defects found

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Enqueue Bob (10), Suzy (10), Jim (10) and Dequeue highest priority using FIFO
        // Expected Result: Bob
        Console.WriteLine("Test 3");
        var players3 = new PriorityQueue();
        players3.Enqueue("Bob", 10);
        players3.Enqueue("Suzy", 10);
        players3.Enqueue("Jim", 10);
        var result3 = players3.Dequeue();
        Console.WriteLine(result3);

        // Defect(s) Found: 
        // Bob is incorrectly dequeued first

        Console.WriteLine("---------");

    }
}