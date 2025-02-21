README
---

**This should not be used for any uses other than educational and demonstrational purposes. Do not use this to hack into any server, webpage, or anything of the sorts. That would be considered a DoS, is against the law, in addition to being prevented by account locks, request limits, and 2FA.**

This project demonstrates how even with a perfect hashing algorithm, without any information even attempting to be retrieved about the password from the database, accounts can still get "hacked" into. This is by force checking many different passwords. 

On platforms where the username is easy to determine (i.e. ones where it is the main form of friending others adn sharing your account), you just need to find a valid user, then brute force your way in.

rockyou.txt is a publically avaliable list of 14 million common passwords, anyone can download it off of github or kaggle. This specific program shows off that principle by first retrieving user input (various passwords), then seeing how many of them are in the text file, displaying it to the user, along with how long it took to check.

To use, run: 
`dotnet run`, 
insert all the passwords you would like to check, and voila! It will tell you how many are contained within the set!

>NOTE:
>
>THIS PROCESS CAN BE QUITE MEMORY INTENSIVE, AS IT HASHES ALL 14 MILLION PASSWORDS.
>
>On my device it finishes in under a second, but for slower and older machines, expect longer delays, and possibly some RAM issues.