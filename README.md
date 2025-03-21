# README

## Project Structure

The project consists of the following parts:

- **pp_lab1**: The main project logic and solution.
- **pp_lab1_tests**: The unit tests project.
- **pp_lab1_forms**: The graphical user interface (GUI) version of the project.

## How to Build the Projects using .NET CLI

To build each part of the project using the .NET CLI, follow the steps below:

### 1. Building `pp_lab1` (Main Logic)

To build the main project, run the following commands in the terminal:

1. Open a terminal or command prompt.
2. Navigate to the directory where the `pp_lab1` project is located:

   ```bash
   cd path/to/pp_lab1
   ```
   
3. Run the following command to build the project:

  ```bash
  dotnet build
  ```

4. This command will restore the project dependencies (if not already restored) and build the project.

### 2. Building 'pp_lab1_tests'

To build and run the unit tests, follow these steps:

1. Navigate to the directory where the pp_lab1_tests project is located:

  ```bash
  cd path/to/pp_lab1_tests
  ```

2. Run the following command to restore the dependencies, build the project and to run tests:

  ```bash
  dotnet build && dotnet test
  ```

## Code explained

### 3. Problem.cs

Primary solution to the problem has been written inside the Solve() method that runs as follows:

  ```C#
  public List<BackpackItem> Solve(int backpackCapacity)
  {
      int weightSum = 0;
      for (int i = 0; i < AvaiableItems.Count; i++)
      {
          weightSum += AvaiableItems[i].Weight;
          if (weightSum >= backpackCapacity)
          {
              weightSum -= AvaiableItems[i].Weight;
              continue;
          }
  
          BackpackItems.Add(AvaiableItems[i]);
      }
  
      return BackpackItems;
  }
  ```

For the solution to work the sorting must be performed first. It happens inside the constructor of the Problem class:

```C#
public Problem(
    int rngSeed,
    int generateItemsCount = 10_000_000
    )
{
    _random = new Random(rngSeed);

    ItemsCount = generateItemsCount;
    AvaiableItems = Enumerable.Range(1, generateItemsCount)
        .Select(x => new BackpackItem(_random.Next(10) + 1, _random.Next(10) + 1))
        .ToList();

    AvaiableItems.Sort();
}
```
