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
* Requires the .NET framework (not great for malware, haha!)

### Platforms
* Windows

## Usage
____________

### CLI Usage
* Run `addrjack.exe` - this will launch a background process with the demo malware
* Copy a Bitcoin address
* Paste the address back, and note that it has been swapped with the attacker address
