# Scripture Memorizer Project

Author: Karina Santos Felippe

---

## Problem Overview
People often try to memorize poems or passages of scripture. One of the challenges they encounter is that they want to hide the scripture while they are practicing, but they may not be able to recite the whole scripture from memory just yet.

To help solve this problem so that people can better memorize a scripture, write a program that displays the full scripture and then hides a few words at a time until the complete scripture is hidden.

## Program Specification

### Functional Requirements
Your program must do the following:

1. Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
2. Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
3. Clear the console screen and display the complete scripture, including the reference and the text.
4. Prompt the user to press the enter key or type quit.
5. If the user types quit, the program should end.
6. If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again.
7. The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
8. When all words in the scripture are hidden, the program should end.
9. When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)

### Design Requirements
In addition your program must:

1. Use the principles of Encapsulation, including proper use of classes, methods, public/private access modifiers, and follow good style throughout.
2. Contain at least 3 classes in addition to the Program class: one for the scripture itself, one for the reference (for example "John 3:16"), and to represent a word in the scripture.
3. Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").

### Simplifications
For the core requirements you do not need to worry about the following:

1. Saving your file as a .csv file requires you to handle commas and quotes in the content appropriately. At this point, you can ignore that and just choose a symbol for a separator that you think is unlikely to show up in the content (such as | or ~ or ~|~).
2. You do not need to store the date as an actual C# DateTime object in your class or in the file. You can simply store it as a string.

### Exceeding Requirements
For this project I added a class with constants to improve the way new scriptures can be added.
I have my program working with a library of scriptures rather than a single one. A scripture is randomly chosen and presented to the user.
The program ask for the user if wants to restart and a new scripture is randomly selected.
The Reference class has a list of verses and there are two constructors to allow the user add a single verse or a list of verses.
