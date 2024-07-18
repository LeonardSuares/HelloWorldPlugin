# HelloWorldPlugin

This project is about a "Hello World" plugin written in C#.

## Overview

The `HelloWorldPlugin` project demonstrates the basics of creating a plugin with an action. The action prints "Hello World" to the console.

## Project Structure

- `Program.cs`: The entry point of the application, where the plugin is initialized and the action is executed.
- `HelloWorldPlugin.cs`: Contains the `HelloWorldPlugin` class with the `RunAction` method.

## How to Run

1. **Clone the Repository**:
    ```bash
    git clone <repository-url>
    cd HelloWorldPlugin
    ```

2. **Open the Project**:
    - Open the `HelloWorldPlugin` project in Visual Studio.

3. **Build the Project**:
    - Select `Build > Build Solution` from the menu or press `Ctrl+Shift+B`.

4. **Run the Project**:
    - Select `Debug > Start Debugging` or press `F5`.
    - You should see "Hello World" printed in the console window.

## Code Explanation

### Program.cs

```csharp
using System;

namespace HelloWorldPlugin
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldPlugin plugin = new HelloWorldPlugin();
            plugin.RunAction();
        }
    }
}
