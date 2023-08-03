# Authenticator (MFA) App

This function effectively locks the file to your computer unless the secret key file is moved to another computer.

A "secret" (private key) of 16 characters using both numbers and uppercase characters is generated and stored in this directory: `%appdata%\sep\privateKeys`, in a .key file.

It is then provided in a QR code format for a mobile device to scan using an authenticator app, and the setup is confirmed to be working by the user submitting the current code from the app.

NOTE: The secret key file contains the name of the encrypted file.
