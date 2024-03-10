public static class Priority {
    public static void Test() {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add items with different priorities and dequeue the highest priority item.
        // Expected Result: Dequeued item should have the highest priority.
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Task 1", 3);
        priorityQueue.Enqueue("Task 2", 1);
        priorityQueue.Enqueue("Task 3", 2);
        Console.WriteLine(priorityQueue); // Expected output: [Task 1 (Pri:3), Task 2 (Pri:1), Task 3 (Pri:2)]
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected output: Task 1
        Console.WriteLine(priorityQueue); // Expected output: [Task 2 (Pri:1), Task 3 (Pri:2)]

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Add items with the same priority and dequeue them.
        // Expected Result: Items should be dequeued following FIFO order.
        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("Task 4", 2);
        priorityQueue.Enqueue("Task 5", 2);
        Console.WriteLine(priorityQueue); // Expected output: [Task 2 (Pri:1), Task 3 (Pri:2), Task 4 (Pri:2), Task 5 (Pri:2)]
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected output: Task 2
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected output: Task 3
        Console.WriteLine(priorityQueue); // Expected output: [Task 4 (Pri:2), Task 5 (Pri:2)]

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}
