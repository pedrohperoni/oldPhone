<br />
<p align="center">
    <img src="https://github.com/pedrohperoni/oldPhone/blob/main/keypad.png?raw=true" alt="Logo" width="80" height="80">
  <h3 align="center">OldPhonePad</h3>


The OldPhonePad function converts input from old physical phone keyboards into the corresponding characters. It allows the user to cycle through the same key until they find the letter they want to type. The function supports using * as a backspace, 0 as a space, and # to end the message and get the corresponding characters.

The input should be a string of digits, with spaces separating different keys and ending with a "#". For example

``
OldPhonePad("4433555 555666#") -> HELLO
``

The function was created in both JS and C#


## Features

* Ensures that the input will have a # at the end of the string, even if it has not been included.
* Checks for "*" which count as backspaces and removes the last compiled character.
* Adds a space when the 0 key is pressed.
* Allows the user to cycle through the letters by continuing to press the same button until they select the correct one (e.g., 2 -> A, 22 -> B, 222-> C, 2222 → A).
* The function will ignore invalid characters, only numeric and control characters are processed

 
