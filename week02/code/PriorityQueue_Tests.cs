using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three values with different priorities and dequeue one.
    // Expected Result: The highest priority item ("High") is dequeued.
    // Defect(s) Found: Highest priority item at the end of the queue was skipped due to loop bug
    public void TestPriorityQueue_HighestPriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 3);
        pq.Enqueue("High", 5); // Highest priority item

        var dequeuedItem = pq.Dequeue();

        Assert.AreEqual("High", dequeuedItem);
    }

    [TestMethod]
    // Scenario:Enqueue two values with the same highest priority 
    // Expected Result: The first enqueued item is dequeued (FIFO behavior).
    // Defect(s) Found: Dequeue did not remove the item from the queue. Items were returned repeatedly.
    public void TestPriorityQueue_FIFOWithEqualPriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("First", 4);
        pq.Enqueue("Second", 4); // Same priority as "First"

        var result = pq.Dequeue();
        Assert.AreEqual("First", result);
    }
     [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty." is thrown.
    // Defect(s) Found: None.
    public void TestPriorityQueue_EmptyQueueThrows()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Expected exception was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}

