# Simple Encryption Program (SEP)

###### This software is provided in an "As Is" state. ABSOLUTELY NO WARRANTY IS PROVIDED. [Learn More](https://github.com/JamieM0/sep/blob/main/NOTICE.md).

Just a simple solution for encrypting files (AES) with a basic password, and storing them locally.

### Features

* Encrypt entire files using a password that a key is then derived from.
* Decrypt these files by using the same password.
* Encrypt & Decrypt strings (super basic secret messages).
* Password Library (Stored in an automatically encrypted SQLite Database. Accessed theough "Save" and "Open" Password buttons).
* Automatic Takeover (Adds "SEP" button to Windows right-click context menu to encrypt/decrypt files).
* Secure with MFA (Authenticator) apps using a private key (secret).

### Potential Future Features

* Cryptotype/("Journals") (Name is WIP) - Allows dynamic typing and encryption on the fly, includes separate notebooks each containing as many pages as required - all encrypted with notebook password. (Similar to OneNote).

### [Full Feature List](https://github.com/users/JamieM0/projects/5)

## Download

Click the green "Code" button near the top of the webpage, and choose "Download ZIP", then extract the file by right-clicking and choosing "Extract".

## Running

Navigate to the sep\bin\debug, then open "sep.exe", and use the program.
