# ai-sample

# Функція twoSum

Знаходить два числа в заданому масиві, які в сумі дають цільове число.

## Параметри

- `nums` - Масив чисел.
- `target` - Цільова сума.

## Повертає

Масив, що містить індекси двох чисел, які в сумі дають цільове число.

## Викидає

Помилку, якщо жодні два числа не дають цільову суму.

## Приклад використання

```typescript
console.log(twoSum([2, 7, 11, 15], 9));  // Виведе: [0, 1]
console.log(twoSum([3, 2, 4], 6));       // Виведе: [1, 2]
console.log(twoSum([3, 3], 6));          // Виведе: [0, 1]