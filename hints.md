#Hints 

Basic Information
Hint: sigcheck.exe

More Basic Information
Hint: sigcheck.exe

Strings
Hint: run the program using command line, or run strings against it
 
Strings Output
Hint: strings command (Windows poershell has a -Tail option, which works like the “tail” command in Unix).

Domain Resolution
Hint: Fake-Net
 
Digital Signature
Hint: certutil
 
Hash
Hint: Lots of ways to solve this – Flare has a “hash” function when you right click
 
Updates
Hint: 
 
Files Ran out of a Non-normal Directory 
Hint: ProcMon or Regshot
 
Files Ran out of a Non-normal Directory 
Hint1: T1036 
Hint2: Looks like a lot of files from c:\windows\system32\ were executed 
Hint3: Is there a binary from C:\windows\system32 that was executed somewhere else? 
Hint4: Don’t always trust the name of the file to be accurate 
 
Process Creation Questions 
Hint: ProcMon
