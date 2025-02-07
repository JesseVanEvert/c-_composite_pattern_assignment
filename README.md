# Composite design pattern
C# Composite Pattern Assignment

Objective:

Implement the Composite Pattern to model a file system where directories can contain files and other directories.
Problem Description:

You are tasked with creating a simplified file system that allows you to manage both Files and Directories. Both files and directories should be treated uniformly, meaning they should inherit from a common interface.

    A File represents a single file in the file system.
    A Directory can contain both Files and other Directories.

You will use the Composite Design Pattern to implement this structure. The composite pattern will allow you to work with both individual files and collections (directories) of files in a consistent way.
Requirements:

    Common Interface:
        Create a common interface or abstract class (e.g., IFileSystemComponent) for both File and Directory. This interface should define methods for:
            Displaying information (e.g., Display()).
            Adding a file or directory (only applicable for directories).
            Removing a file or directory (only applicable for directories).

    File Class:
        Create a class File that implements the IFileSystemComponent interface.
        The File class should:
            Store a file name.
            Implement the Display() method to show its name.
            Files should not support adding or removing other files (so leave those methods empty or throw exceptions).

    Directory Class:
        Create a class Directory that implements the IFileSystemComponent interface.
        The Directory class should:
            Store a collection of IFileSystemComponent objects (both files and directories).
            Implement methods to add, remove, and display its contents.
            Display its name and the names of the contained files and subdirectories in a structured way.

    Client Code:
        Write client code to test your composite structure:
            Create several files.
            Create directories and add files or other directories inside them.
            Display the directory structure using the Display() method.

Example Output:

The following output should be achievable by your implementation:

RootDirectory
  ├── File1.txt
  ├── File2.txt
  ├── SubDirectory1
  │     ├── File3.txt
  │     └── File4.txt
  └── SubDirectory2
        └── File5.txt

Guidelines:

    Make sure you encapsulate the component and composite structure properly.
    Aim for clean, modular code.
    Consider how to handle edge cases like adding the same file or directory twice, or trying to remove a non-existent file.

Bonus (Optional):

    Implement a method to calculate the total size of the files in the directory (assuming each file has a size).
    Add an option to display the depth of the directory structure (for example, each nested level could be indented more).

Deliverables:

    The complete C# code for the implementation.
    A text file containing the console output demonstrating your solution with different file system structures.

Good luck! This will help you grasp the use of the Composite Pattern in organizing complex, tree-like structures in a consistent way.
