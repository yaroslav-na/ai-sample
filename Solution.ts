/**
 * Finds two numbers in the given array that add up to the target number.
 * 
 * @param nums - An array of numbers.
 * @param target - The target sum.
 * @returns An array containing the indices of the two numbers that add up to the target.
 * @throws Will throw an error if no two numbers add up to the target.
 */
function twoSum(nums: number[], target: number): number[] {
    const numToIndex: { [key: number]: number } = {};
    for (let i = 0; i < nums.length; i++) {
        const complement = target - nums[i];
        if (numToIndex.hasOwnProperty(complement)) {
            return [numToIndex[complement], i];
        }
        numToIndex[nums[i]] = i;
    }
    throw new Error("No two sum solution");
}

// Example usage:
console.log(twoSum([2, 7, 11, 15], 9));  // Output: [0, 1]
console.log(twoSum([3, 2, 4], 6));       // Output: [1, 2]
console.log(twoSum([3, 3], 6));          // Output: [0, 1]
console.log(twoSum([1, 5, 5, 2], 10));   // Output: [1, 2]
// add alternative solution
function twoSum(nums: number[], target: number): number[] {
    const numToIndex: { [key: number]: number } = {};
    for (let i = 0; i < nums.length; i++) {
        const complement = target - nums[i];
        if (numToIndex.hasOwnProperty(complement)) {
            return [numToIndex[complement], i];
        }
        numToIndex[nums[i]] = i;
    }
    throw new Error("No two sum solution");
}
