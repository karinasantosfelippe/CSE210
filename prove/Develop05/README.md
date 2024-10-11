# Mindfulness Program

Author: Karina Santos Felippe

---

## Problem Overview
We live in a fast-paced world full of stress and anxiety. We could each benefit from taking time for mindfulness activities where we can reflect and unwind.

Most people would agree that we should take more time to be mindful, but relatively few of us do. Think to yourself for a moment about some reasons that you think keep people from doing this. Could a program or an app help with any of these reasons?

Some of the problems you considered may have included:
- We forget
- We get busy
- We think it will take too long, so we don't start
- We don't know where to begin. We know we should reflect on something but don't know what to start with.

While it may not resolve all of the issues that keep people from taking more time for reflection, a great program could help people by providing structure and prompts to guide them through various exercises.

## Solution Idea
Consider an app that provides three different kinds of mindfulness opportunities. It could give some guidance and structure to users in the following activities:

- Breathing Activity - Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.
- Reflection Activity - Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.
- Listing Activity - Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.
The application could additional help the user keep track of the time or frequency they spend in these activities and give them gentle prompts and reminders.

## Program Specification
Write a program that provides the three activities described above. It should help them work through these activities in stages using basic forms of delay (animation or countdown).

### Functional Requirements
Your program must do the following:

1. Have a menu system to allow the user to choose an activity.
2. Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
3. Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
4. Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
5. The interface for the program should remain generally true to the one shown in the video demo.
6. Provide activities for reflection, breathing, and enumeration, as described below:

#### Breathing Activity
1. The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
2. The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
3. After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
4. After each message, the program should pause for several seconds and show a countdown.
5. It should continue until it has reached the number of seconds the user specified for the duration.
6. The activity should conclude with the standard finishing message for all activities.


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
The Scripture class has a method to show all the words of an scripture to satisfy the random selection in the AppConstants class.