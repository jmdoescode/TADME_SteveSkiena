# TADME_SteveSkiena

This is a C# .Net project which I have created to journal my way through the book "The Algorithm Design Manual" by Steve Skiena. 
The structure is as follows...

All projects are prefixed with the chapter.
For each chapter there are 
- Answers
- Pictures
- Practices
- Console Application with chapter prefix, two underscores, and the chapter name (so that in the solution it will be the top project) (ie: Ch06__WeightedGraphs)

**Practices**

The Practices project holds folders for Algorithms, Data Structures, and Questions. 
- All Algorithm files will be prefixed with "AL" and the number in which it was created.
- All Data Structure files will be prefixed with "DS" and the number in which it was created.
- All Questions will be prefixed with "Q" and the number in which it was created.

These were created this way so that I can quickly practice any algorithm, data structure, or question that I have created and have an answer to. This way I can focus on the heart of the problem while I have already created a way in which to test if the solution for the practice is correct. These files can also hold Hints in the comments so it will be easier to work on a problem without looking at the answer right away if you are stuck. If the file has no coding aspect then there will be no practice file.

**Answers**

The Answers project holds the answers for everything in the Practices project. 

- Along with the prefixes for the Practices project, all files in the Answers project will be prefixed with "A" to denote an answer file.

To make things simpler, some answers will have collapsible and expandable areas for the answers if there is no coding involved. Hiding the answer is all that is needed for practice.

**Pictures**

These are supplemental pictures to some of the files that are created. They are prefixed with chapter, chapter number, and either data structure, algorithm, or question to signify what the picture is supplementing.

**Console Application**

The console application with the chapter prefix is the project you will select to run to debug code. 
The program file will have using statements for the classes in the answers. To test practice problems, simply delete the A prefix that denotes that the class being used is an answer so that it will point to the practice class.

For example:
- using AQ10 = AQ_10_EvaluateDAG;

Change to
- using AQ10 = Q_10_EvaluateDAG;
 
