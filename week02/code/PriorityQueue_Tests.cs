using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    // [TestMethod]
    // // Scenario: 
    // // Expected Result: 
    // // Defect(s) Found: 
    // public void TestPriorityQueue_1()
    // {
    //     var priorityQueue = new PriorityQueue();
    //     Assert.Fail("Implement the test case and then remove this.");
    // }

    //Solution:
    [TestMethod]
    // Scenario: Add items with different priorities and remove one
    // Expected Result: Item with highest priority is returned
    // Defect(s) Found: Highest priority item was not always selected correctly.
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("High", 10);

        var result = pq.Dequeue();

        Assert.AreEqual("High", result);
    }

    // [TestMethod]
    // // Scenario: 
    // // Expected Result: 
    // // Defect(s) Found: 
    // public void TestPriorityQueue_2()
    // {
    //     var priorityQueue = new PriorityQueue();
    //     Assert.Fail("Implement the test case and then remove this.");
    // }

    //Solution:
    [TestMethod]
    // Scenario: Add multiple items with the same priority
    // Expected Result: First item added with highest priority is removed first
    // Defect(s) Found: FIFO order was violated when priorities were equal.
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("First", 5);
        pq.Enqueue("Second", 5);
        pq.Enqueue("Third", 5);

        var result = pq.Dequeue();

        Assert.AreEqual("First", result);
    }

    // Add more test cases as needed below.
    //Solution:
    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: None.
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    
}