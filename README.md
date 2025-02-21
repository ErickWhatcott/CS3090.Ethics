README
---

>This project demonstrates how even with a perfect hashing algorithm, without any information even attempting to be retrieved about the password from the database, accounts can still get "hacked" into. This is by force checking many different passwords. 
>
>On platforms where the username is easy to determine (i.e. ones where it is the main form of friending others adn sharing your account), you just need to find a valid user, then brute force your way in.
>
>rockyou.txt is a publically avaliable list of 14 million common passwords, anyone can download it off of github or kaggle. This specific program shows off that principle by first retrieving user input (various passwords), then seeing how many of them are in the text file, displaying it to the user, along with how long it took to check.