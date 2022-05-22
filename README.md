# SoftUniFundamentalsWork
Here I will be posting my SoftUni course works
------------------------------------------------------
My first folders are revision from my basics course in SoftUni:<br/>
 - Last exercise from the initial revision was with the help of the debugger and the troubleshooting integrated in Microsoft Visual Studio 2019. My task was to use the debugger and find the bugs that are causing the program to not functioning properly<br/>
 - Here is the code I had to work with and where I found the 4 bugs that were causing the program to not work properly:![initialCode](https://user-images.githubusercontent.com/102831846/169688670-9a8df9d6-38dd-4b65-9f4e-2cf078443634.png)
   - the first two bugs were the date formats being written wrong 
   - the third bug was the AddDays where it just increases the days but doesn't save them so we had to add extra days that equals to the already increased number so it saves the variable
   - the fourth and final bug was where instead of "&&" for the holiday days (Saturday / Sunday) it had to be "||" so when there is 1 of the following days it saves the day as holiday instead of rejecting it, because it can't be Saturday and Sunday at the same time.
 - I found the bugs and this is the fixed code:
![debugger](https://user-images.githubusercontent.com/102831846/169687915-a26ca3b6-d74a-4864-9097-66e56e78a806.png)
 - What this piece of code does is - user enters 2 dates (1 as starting date, 1 as end date) and the program generates the holidays (saturdays and sundays) that are in this period of time.![consoleResult](https://user-images.githubusercontent.com/102831846/169688269-39daeb45-73bd-4eac-871f-3642b4863475.png)
