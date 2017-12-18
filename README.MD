# Ketshash
Script for detecting suspicious privileged NTLM connecions, in particular Pass-The-Hash attack, based on event viewer logs.

The tool was published as part of the "Pass-The-Hash detection" research - more details on "Pass-The-Hash detection" are in [TODO]the blog post: https://www.cyberark.com/

# Requirements
- Privileges to get event viewer logs from remote machines
- Privileges to retrive information about the user and the machine from Active Directory
- Computers synchronized with the same time, otherwise it can affect the results
- Minimum PowerShell 2.0  

# Overview
Ketshash is a tool for detecting suspicious privileged NTLM connections.
The tool queries given computers to be monitored, computers that connected to the given computers and also Active Directory (AD) to get information about these computers.

# Usage
### Basic Usage
-	Open PowerShell and run:
	- `Import-Module .\Ketshash.ps1`
	- `Invoke-DetectPTH <arguments>`

### Ketshash Runner
-	Double click on KetshashRunner.exe, change settings if you need and press Run
        ![alt text](https://raw.githubusercontent.com/cyberark/ketshash/master/Media/KetshashRunnerGif.gif?token=ALcWEPkXJpNK_dv8CYnGkg0Za2oODfZAks5aQO5ewA%3D%3D)
## Invoke-DetectPTH
##### Parameters:
* __TargetComputers__ - Array of target computers to detect for NTLM connections.  
* __TargetComputersFile__ - Path to file with list of target computers to detect for NTLM connections.
* __StartTime__ - Time when the detection starts. The defualt is from the time this function starts.  The default is the current time.
* __UseKerberosCheck__ - Checks for TGT\TGS logons on the DCs on the organization. 
The default is to search for legitimate logon on the source machine. 
Anyway, with or without this switch there is still a query for event ID 4648 on the source machine.
* __UseNewCredentialsCheck__ - Checks for logon events with logon type 9 (like Mimikatz). 
This is optional, the default algoritm already covers it. 
It is exist just to show another option to detect suspicious NTLM connections.
On Windows versions below Windows 10 and Server 2016, "Microsoft-Windows-LSA/Operational" should be enabled in event viewer.
On Windows 10 and Server 2016, enabling "kerenl object audity" will provide more accurate information such as writing to LSASS.
* __LogFile__ - Log file path to save the results.
* __MaxHoursOfLegitLogonPriorToNTLMEvent__ - How much hours to look backwards and search for legitimate logon from the time of the NTLM event. The default is 2 hours backwards. 


##### Example:
`Invoke-DetectPTH -TargetComputers "ComputerName" -StartTime ([datetime]"2017-12-14 12:50:00 PM") -LogFile "C:\tmp\log.txt" -UseKerberosCheck -UseNewCredentialsCheck`

![alt text](https://raw.githubusercontent.com/cyberark/ketshash/master/Media/KetshashScreenshot.PNG?token=ALcWEG05x1Vo_c5Ac6mLwzHnYlDzp41Qks5aQO5NwA%3D%3D)


# References:
For more comments and questions, you can contact Eviatar Gerzi (@g3rzi) and CyberArk Labs.
