using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: two object are added, both with 1 priority. When one is dequed, the first one will leave the list.
    // Expected Result: [b (pri:1)]
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 1);
        Debug.WriteLine(priorityQueue);
        var a = priorityQueue.Dequeue();
        Debug.WriteLine(a);
        Debug.WriteLine(priorityQueue);
        if(a != "a"){
            Assert.Fail("Implement the test case and then remove this.");
        }
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}