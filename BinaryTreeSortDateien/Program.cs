using System;
using System.IO;

namespace BinaryTreeSort
{
   public class FileNode
    {
        public FileInfo file;
        public FileNode left;
        public FileNode right;

        public FileNode(FileInfo file)
        {
            this.file = file;
            left = null;
            right = null;
        }
    }

    public class FileTree
    {
        public FileNode root;

        public FileTree()
        {
            root = null;
        }

        public void AddFile(FileInfo file)
        {
            FileNode newNode = new FileNode(file);

            if (root == null)
            {
                root = newNode;
                return;
            }

            FileNode current = root;
            while (true)
            {
                if (string.Compare(file.Name, current.file.Name) < 0)
                {
                    if (current.left == null)
                    {
                        current.left = newNode;
                        break;
                    }
                    current = current.left;
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = newNode;
                        break;
                    }
                    current = current.right;
                }
            }
        }

        public void PrintUnsorted(FileInfo[] files)
        {
            Console.WriteLine("Unsorted files:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
        }

        public void PrintInOrder(FileNode root)
        {
            if (root != null)
            {
                PrintInOrder(root.left);
                Console.WriteLine(root.file.Name);
                PrintInOrder(root.right);
            }
        }

        public void PrintPostOrder(FileNode root)
        {
            if (root != null)
            {
                PrintPostOrder(root.left);
                PrintPostOrder(root.right);
                Console.WriteLine(root.file.Name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the directory:");
            string path = Console.ReadLine();

            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                FileInfo[] files = directory.GetFiles();

                FileTree fileTree = new FileTree();

                fileTree.PrintUnsorted(files);

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                foreach (FileInfo file in files)
                {
                    fileTree.AddFile(file);
                }

                Console.WriteLine("Sort in ascending order (1) or descending order (2)?");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Sorted files (ascending):");
                    fileTree.PrintInOrder(fileTree.root);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Sorted files (descending):");
                    fileTree.PrintPostOrder(fileTree.root);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: Access to the directory is denied.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Error: The directory could not be found.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}

