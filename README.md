# LeetCode Solutions in C# .NET

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Status](https://img.shields.io/badge/status-active-brightgreen)
![Version](https://img.shields.io/badge/version-1.0.0-orange)

A comprehensive collection of LeetCode problem solutions implemented in C# .NET 8.0, organized by difficulty level and featuring comprehensive unit tests. This repository serves as both a reference and a learning resource for algorithm practice and interview preparation.

## 🎯 Project Goals

- **Keep GitHub Active**: Regular commits and contributions
- **Learn & Practice**: Improve problem-solving and C# skills
- **Document Solutions**: Clear explanations and complexity analysis
- **Quality Code**: Clean, well-tested, and documented solutions

## 📁 Project Structure

```
LeetCodeSolutions/
├── LeetCodeSolutions.Core/           # Main solution library
│   ├── Common/                       # Shared interfaces and enums
│   │   ├── ISolution.cs             # Base interface for all solutions
│   │   └── Difficulty.cs            # Difficulty enumeration
│   ├── Easy/                        # Easy difficulty solutions
│   ├── Medium/                      # Medium difficulty solutions
│   └── Hard/                        # Hard difficulty solutions
├── LeetCodeSolutions.Tests/         # Unit tests
│   ├── Easy/                        # Tests for easy solutions
│   ├── Medium/                      # Tests for medium solutions
│   └── Hard/                        # Tests for hard solutions
├── Scripts/                         # Automation scripts
└── README.md                        # This file
```

## 🚀 Getting Started

This repository is designed for learning and practicing LeetCode problems. You can either contribute to this repository or create your own version to track your progress.

### Option 1: Contribute to This Repository

1. Fork the repository by clicking the "Fork" button at the top-right corner of this page.
2. Clone your forked repository:
   ```bash
   git clone https://github.com/<your-username>/LeetcodeGit.git
   cd LeetcodeGit
   ```
3. Make your changes and submit a pull request.

### Option 2: Create Your Own Repository

1. Download the repository as a ZIP file:
   - Click the green "Code" button and select "Download ZIP".
   - Extract the ZIP file to your desired location.
2. Initialize a new Git repository:
   ```bash
   git init
   git remote add origin https://github.com/<your-username>/YourRepoName.git
   git add .
   git commit -m "Initial commit"
   git push -u origin main
   ```
3. Start solving problems and tracking your progress in your own repository.

### Additional Resources

- Visit the [Wiki](https://github.com/nvas222/LeetcodeGit/wiki) for:
  - Learning tutorials
  - Contribution guidelines
  - Instructions for downloading and using version v1.0.0 as your own repository.

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Git](https://git-scm.com/)
- IDE: [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Clone and Setup

```bash
git clone https://github.com/nvas222/LeetcodeGit.git
cd LeetcodeGit
dotnet restore
```

### Building the Project

```bash
# Build the entire solution
dotnet build

# Build specific project
dotnet build LeetCodeSolutions.Core
```

### Running Tests

```bash
# Run all tests
dotnet test

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"

# Run specific test file
dotnet test --filter "ClassName=TwoSumTests"
```

## 📊 Progress Tracking

### Easy Problems (1 solved)
- [x] **#1** - [Two Sum](LeetCodeSolutions.Core/Easy/TwoSum.cs) - Hash Map - `O(n)` time, `O(n)` space

### Medium Problems (0 solved)
- [ ] Coming soon...

### Hard Problems (0 solved)
- [ ] Coming soon...

### Statistics
- **Total Solved**: 1
- **Easy**: 1/1963 (0.05%)
- **Medium**: 0/1569 (0%)
- **Hard**: 0/665 (0%)
### Adding a New Solution

1. **Create the solution class** in the appropriate difficulty folder:
   ```csharp
   // LeetCodeSolutions.Core/Easy/NewProblem.cs
   using LeetCodeSolutions.Core.Common;
   
   namespace LeetCodeSolutions.Core.Easy;
   
   public class NewProblem : ISolution
   {
       public int ProblemNumber => 123;
       public string Title => "Problem Title";
       public Difficulty Difficulty => Difficulty.Easy;
       public string Description => "Brief solution approach";
       public string TimeComplexity => "O(n)";
       public string SpaceComplexity => "O(1)";
       
       public ReturnType SolutionMethod(InputType input)
       {
           // Implementation here
       }
   }
   ```

2. **Create comprehensive tests**:
   ```csharp
   // LeetCodeSolutions.Tests/Easy/NewProblemTests.cs
   using LeetCodeSolutions.Core.Easy;
   
   namespace LeetCodeSolutions.Tests.Easy;
   
   public class NewProblemTests
   {
       private readonly NewProblem _solution = new();
       
       [Theory]
       [InlineData(/* test cases */)]
       public void SolutionMethod_ValidInput_ReturnsExpected(/* parameters */)
       {
           // Test implementation
       }
   }
   ```

3. **Update progress tracking** in this README
4. **Commit your changes** with descriptive message

### Code Quality Standards

- **Clean Code**: Follow C# naming conventions and best practices
- **Documentation**: XML comments for all public members
- **Testing**: Comprehensive unit tests with edge cases
- **Performance**: Include time and space complexity analysis
- **Consistency**: Use the `ISolution` interface for all problems

## 🔧 Automation Scripts

The `Scripts/` folder contains PowerShell scripts to automate common tasks:

- `New-Solution.ps1` - Generate boilerplate for new solutions
- `Update-Progress.ps1` - Update README progress statistics
- `Run-AllTests.ps1` - Execute comprehensive test suite

Usage:
```powershell
# Generate new solution template
.\Scripts\New-Solution.ps1 -ProblemNumber 42 -Title "Trapping Rain Water" -Difficulty Hard
```

## 🎨 Solution Template

Each solution follows this structure:

```csharp
/// <summary>
/// LeetCode Problem #X: Problem Title
/// Problem description...
/// </summary>
public class ProblemName : ISolution
{
    // Metadata properties (required by ISolution)
    public int ProblemNumber => X;
    public string Title => "Problem Title";
    public Difficulty Difficulty => Difficulty.Easy;
    public string Description => "Algorithm approach";
    public string TimeComplexity => "O(n)";
    public string SpaceComplexity => "O(1)";

    /// <summary>
    /// Main solution method with clear documentation.
    /// </summary>
    public ReturnType SolutionMethod(InputType parameter)
    {
        // Clean, efficient implementation
        // with comments explaining key steps
    }
    
    // Additional helper methods if needed (private)
}
```

## 📈 Learning Goals

- **Algorithm Patterns**: Two pointers, sliding window, dynamic programming, etc.
- **Data Structures**: Arrays, hash maps, trees, graphs, heaps
- **Optimization**: Time and space complexity improvements
- **Testing**: Writing comprehensive unit tests
- **Documentation**: Clear explanations of approach and complexity

## 🎓 Learning Tutorials

### How to Use This Repository for Learning

1. **Step-by-Step Problem Solving**:
   - Each solution includes detailed comments explaining the thought process
   - Solutions are structured to show problem decomposition and approach selection
   - Follow the commit history to see how solutions evolve

2. **Learn by Example**:
   - Study the solution patterns for common algorithm techniques
   - Compare different approaches for the same problem (when available)
   - Understand tradeoffs between time and space complexity

3. **Weekly Learning Path**:
   - **Week 1**: Array and String problems (e.g., Two Sum)
   - **Week 2**: Hash Maps and Sets
   - **Week 3**: Linked Lists and Stacks
   - **Week 4**: Trees and Graphs
   - **Week 5**: Dynamic Programming basics

### Tutorial Sessions

Check the [Discussions](https://github.com/nvas222/LeetcodeGit/discussions) tab for:
- Weekly problem walkthroughs
- Interview preparation tips
- Algorithm pattern explanations
- Video tutorials (coming soon)

## 🤝 Contributing

This is a personal learning repository, but feel free to:
- Suggest improvements or optimizations
- Report bugs or issues
- Share alternative solution approaches
- Add your own solution approaches to existing problems

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🔗 Resources

- [LeetCode](https://leetcode.com/) - Original problem source
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [xUnit Testing](https://xunit.net/)
- [Algorithm Complexity Cheat Sheet](https://www.bigocheatsheet.com/)
- [Grokking Algorithms](https://www.manning.com/books/grokking-algorithms) - Recommended book

## 📺 Setting Up GitHub Pages (Coming Soon)

This repository will soon include a GitHub Pages site with:
- Interactive algorithm visualizations
- Step-by-step solution walkthroughs
- Flashcards for algorithm patterns
- Interview preparation checklists

---

**Happy Coding and Learning!** 🚀

*Last Updated: October 7, 2025*
*Version: 1.0.0*