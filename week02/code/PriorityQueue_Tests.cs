using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities
    // Expected Result: Dequeue returns items in order of highest to lowest priority
    // Defect(s) Found: Previously, Dequeue did not correctly select the highest priority
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue()); // Highest priority
        Assert.AreEqual("C", priorityQueue.Dequeue()); // Next highest
        Assert.AreEqual("A", priorityQueue.Dequeue()); // Last remaining
    }

    [TestMethod]
    // Scenario: Enqueue three items, two with same highest priority
    // Expected Result: Dequeue removes the first enqueued item among ties first (FIFO)
    // Defect(s) Found: Previously, FIFO not respected for items with same priority
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("X", 5);
        priorityQueue.Enqueue("Y", 5); // Same priority as X
        priorityQueue.Enqueue("Z", 3);

        Assert.AreEqual("X", priorityQueue.Dequeue()); // FIFO among same priority
        Assert.AreEqual("Y", priorityQueue.Dequeue()); // Next same priority
        Assert.AreEqual("Z", priorityQueue.Dequeue()); // Remaining
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue
    // Expected Result: InvalidOperationException is thrown with correct message
    // Defect(s) Found: Previously, no exception handling for empty queue
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    [TestMethod]
    // Scenario: Enqueue items with zero and negative priorities
    // Expected Result: Dequeue returns items in correct order based on priority
    // Defect(s) Found: Negative and zero priorities were not handled correctly
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", -1);
        priorityQueue.Enqueue("Zero", 0);
        priorityQueue.Enqueue("High", 2);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Zero", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }
}