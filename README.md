# Shuffle
Thank you for your time exploring this app.
Shuffle is a Windows Console app which generates a list of 10000 numbers in random order. 
## Run
As requested there is no executable file included in this repository. Please start the app in Visual Studio.
## Algorithm - Fisher-Yates Shuffle
This app starts by generating a list ranging 1 to 100000. The list is sorted randomly by switching the ith number with a random number in sub-list ```list[0:i]```. ```i``` is the index from last element to the first one.
## Debug
This app contains two lines of debugging code. The first line checks if the length of the list. The second line checks if the values are unique.
## Output
Readable comma-separated list contents.