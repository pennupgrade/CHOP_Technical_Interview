# CHOP Technical Interview
For the technical portion of the CHOP position interview, you will be asked to fork this repository, set up your own Unity project from scratch (gitignore and all), the open a pull request before the 3/18 meeting @ 4pm. THIS WILL TAKE A NON-TRVIAL AMOUNT OF TIME, SO DON'T TRY TO DO THIS RIGHT BEFORE THE MEETING.

References:

https://docs.github.com/en/get-started/quickstart/fork-a-repo
https://github.com/github/gitignore/blob/main/Unity.gitignore
https://docs.unity3d.com/Manual/UIElements.html
https://forum.unity.com/threads/file-i-o-via-unity.35193/
https://www.instructables.com/How-to-BuildExport-Your-Game-in-Unity-to-Windows/
https://docs.unity3d.com/ScriptReference/Object.DontDestroyOnLoad.html
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-InputField.html

## Key Concepts:
### Unity
-I/O in C# 
-Screenspace UI Components 
  -Buttons
  -Textviews
  -Scrollviews
-Building to an Executable
-DontDestroyOnLoad
### GitHub
-Forking
-Using GitIgnores
-Opening Pull Requests

## Overview:
Basically you're gonna implement a rough terms and condition dialogue prompt in Unity, then build it to an executable. You will demo your working application during the first part of your non-technical interview on your own machine to keep operating system conflict issues to a minimum.

Specifications:
Scenes:
- WaiverScene
   Contains:
      Text Input Component - asks for user name; sets the player name value in DontDestroyOnLoad.
      Scroll View Component - reads in the text from disclosure.txt and displays it in a scroll view
      Accept Button Component - launches the AcceptanceScene
      Reject Button Component - Display a textbox that says "Sorry you can't do that"
- AcceptanceScene
    Contains:
      Textbox - This should read something along the lines of "[Play name], you have accepted the terms and conditions."
Global:
  DontDestroyOnLoad
      Player Class - has a getter and setting for a Name field

Questions should be DMed to Edward on Discord.
