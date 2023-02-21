#Questions & Answers 
 
#Overview 
This document is to give the Questions and Answers for the Malhow binary. At the end, there are hints available if you cannot complete this on your own.  

 
#Questions and Answers 

Basic Information  
##Question: What is the product name of the app/Product?
Answer: MalHow Malware Analysis Training binary


More Basic Information  
Question: What is the File Version? 
Answer: 1.3.3.7



Console Output  
Question: What char string does it output when ran?
Answer: 50m3th1n@Ph1$hy 


Strings Output  
Question: When you run strings, there is a little easter egg at the bottom. What movie is this from?
Answer: Monty Python and the Holy Grail



 
Domain Resolution
Question: What domain does this resolve to? (there are more than one – this is the one it’s resolving the URL to the IP). 
Answer: xKCD.com

 
  
Digital Signature
Question: Who is the author of the Digital Signature (AKA Who was the digital certificate issued to)?
Answer: Dispareo Security




 
 
Hash
Question: What is the MD5 Hash Value? 
Answer: DEF6D65A2DFCC0EA5ECE393A54B12F9B

Question: What is the VT flag for this? (Hint: Check Community)
Answer: flag{Congrats, you found me!}


 



Updates/Domain Connectivity
Question: What domain does this reach out to for updates? 
Answer: Medicinaldevices.com

Question: When connecting to the website, there are 3 “custom” headers. What is the 3rd header and value?
Answer: If-You-Are-Using-Your-Own-IP: You just gave the malware authors your IP address in their web logs. That's bad mmk
 



Files Ran out of a Non-normal Directory 
Question: What is the name of the file ran from the non-normal directory? 
Answer: C:\{user}\temp\calc.exe 




Process Creation Summary
Question: This executable spawns 4 different process. What are they?
Answer: C:\Windows\System32\Conhost.exe
Answer: C:\Windows\System32\fsutil.exe
Answer: C:\Program Files\Google\Chrome\Application\chrome.exe
Answer: C:\Users\Flare\AppData\Local\Temp\calc.exe 
(C:\Users\{user}\AppData\Local\Temp\calc.exe)


Process Creation Detail #1
Question: Examine the second process (in chronological order). What is the command line argument?
Answer: "C:\Windows\System32\fsutil.exe" behavior query SymlinkEvaluation


Process Creation Detail #2a
Question: Examine the third process (in chronological order). What is the command line argument?
Answer: "C:\Program Files\Google\Chrome\Application\chrome.exe" https://youtu.be/wCsO56kWwTc?t=13


Process Creation Detail #2b
Question: Examine the answer from Process Creatoin Detail 2a (the third process command line argument). What does this argument do?
Answer: Navigates via chrome to the URL https://youtu.be/wCsO56kWwTc?t=13


Process Creation Detail #3
Question: Examine the fourth process (in chronological order). What is the command line argument?
Answer: "C:\Users\Flare\AppData\Local\Temp\calc.exe" ("C:\Users\{user}\AppData\Local\Temp\calc.exe")
