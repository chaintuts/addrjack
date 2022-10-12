## General
____________

### Author
* Josh McIntyre

### Website
* jmcintyre.net

### Overview
* AddrJack is an educational demo of a Bitcoin address-swapping malware

## Development
________________

### Git Workflow
* master for releases (merge development)
* development for bugfixes and new features

### Building
* make build
Build the utility
* make clean
Clean the build directory

### Features
* Detect Bitcoin addresses in the Windows copy-paste buffer
* Replace the address with the "attacker's" address

### Requirements
* Requires the .NET framework
* Requires Python for the alternative Python version

### Platforms
* Windows
* Mac OSX

## Usage
____________

### CLI Usage
* Run `addrjack.exe` - this will launch a background process with the demo malware
* Run `python3 addrjack.py` for the Python version
* Copy a Bitcoin address
* Paste the address back, and note that it has been swapped with the attacker address
