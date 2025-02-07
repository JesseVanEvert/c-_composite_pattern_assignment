using FileSystemCompositePattern;

FileSystemCompositePattern.File file1 = new("file_1");
FileSystemCompositePattern.Directory rootDirectory = new("Root directory");
FileSystemCompositePattern.Directory subDirectory = new("Sub directory");
FileSystemCompositePattern.File file2 = new("file_2");

rootDirectory.Add(file1);
rootDirectory.Add(subDirectory);
subDirectory.Add(file2);

rootDirectory.Display();





