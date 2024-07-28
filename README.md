# Unity Flyweight Design Pattern

This repository demonstrates a simple forest generation system in Unity, utilizing the Flyweight design pattern to manage tree objects efficiently. The Flyweight pattern helps reduce memory usage by sharing common data between similar objects.

## Project Structure

1. **Forest.cs**: Manages the creation and placement of trees in the forest.
2. **ITree.cs**: Interface for tree objects.
3. **Tree.cs**: Concrete implementation of the `ITree` interface.
4. **TreeFactory.cs**: Factory class for creating and managing tree instances.

## Usage

### Forest.cs
- Initializes a `TreeFactory` to manage tree creation.
- Generates a forest with 100 trees at random positions and sizes.

### ITree.cs
- Defines the `Render` method for tree objects.

### Tree.cs
- Implements the `ITree` interface.
- Handles the rendering of tree objects, including their position and size.

### TreeFactory.cs
- Manages the creation and sharing of `Tree` objects.
- Ensures that only one instance of a tree model is created and reused.

