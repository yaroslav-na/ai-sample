using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void TestTwoSum1() {
        Solution solution = new Solution();
        int[] result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TestTwoSum2() {
        Solution solution = new Solution();
        int[] result = solution.TwoSum(new int[] { 3, 2, 4 }, 6);
        Assert.Equal(new int[] { 1, 2 }, result);
    }

    [Fact]
    public void TestTwoSum3() {
        Solution solution = new Solution();
        int[] result = solution.TwoSum(new int[] { 3, 3 }, 6);
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TestTwoSumNoSolution() {
        Solution solution = new Solution();
        Assert.Throws<ArgumentException>(() => solution.TwoSum(new int[] { 1, 2, 3 }, 7));
    }
}

// We recommend installing an extension to run csharp tests.