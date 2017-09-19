Tools 1
Ryan Medeiros
250724506

This unity project is my submission for the Tools 1 assignment.

Code files: ConeController.cs, and ConeControllerEditor.cs

Github repository: <https://github.com/Acetechite/Tools1>

Major benefits:
1. I put the scale adjusters on sliders with upper and lower bounds. I know i'll want to 
quickly make many different sizes of spaceships but I never want them to have negative size 
or be too big. Im also not worried about the exact value, just their relative size and the 
slider achieves this where the default Vector3 control doesn't.

2. A spaceship's XP is directly linked to its health and damage, I dont want people to change 
experience directly, but when they change health and damage i want them to notice the update in 
XP. Using custom editor i was able provide the health and damage adjusters with a live updating 
label that displayed the XP as read only.

3. I was able to do general cleaning up of the editor, i used the custom editor to take in bold 
font styles for title areas and changed the indenting to group common traits together. This let 
me group all the scale sliders under one "Size" header. This organization is better for me than 
the default editor was.