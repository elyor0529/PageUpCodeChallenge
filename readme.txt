Page Up Code Challenge
At PageUp, we love elegant code. Building quality solutions using good design patterns and
principles is our passion. (And we would like to see your code!) This exercise will help us to assess
your level of expertise as a developer and give us the ability to see where you fit best in our teams.
Please follow the indication below and let us know if you have any questions.

Guidelines
Please write code in C# and/or JavaScript.
When writing your code, keep the following points in mind:





Your code should be production ready
Your code should be understandable and maintainable by other developers
Your code should be robust and handle error situations
Your code should be bug free, compile and work

Source code must be submitted in ZIP format (no binaries)
Please make sure you do not keep your solution in a public repository on GitHub or similar, as it
exposes your solution to plagiarism.
Exercise
Write a program that receives four integer inputs to indicate the weight and size of a parcel for
postage, and returns the cost of delivery.
The user inputs are:
1.
2.
3.
4.

Weight (kg)
Height (cm)
Width (cm)
Depth (cm)

The rules for calculating the cost of delivery in order of priority:
Priority
1 (Highest)

Rule
Reject

Condition
If the weight exceeds 50kg

2
Heavy Parcel
If the weight exceeds 10kg
3
Small Parcel
If the volume is less than 1500
4
Medium Parcel If the volume is less than 2500
5
Large Parcel
(Lowest)
Note: Volume is calculated by Height x Width x Depth.

Cost
N/A
$15 x Weight (kg)
$0.05 x Volume
$0.04 x Volume
$0.03 x Volume

Note: The rule matched with the highest priority should be used to calculate the cost of delivery.
Examples
1.

Enter Weight in kg: 10
Enter Height in cm: 20
Enter Width in cm: 5
Enter Depth: 20

Category: Medium Parcel
Cost: $80
2.

Enter Weight in kg: 22
Enter Height in cm: 5
Enter Width in cm: 5
Enter Depth: 5
Category: Heavy Parcel
Cost: $330

3.

Enter Weight in kg: 2
Enter Height in cm: 3
Enter Width in cm: 10
Enter Depth: 12
Category: Small Parcel
Cost: $18

4.

Enter Weight in kg: 110
Enter Height in cm: 20
Enter Width in cm: 55
Enter Depth: 120
Category: Rejected

Cost: N/A

