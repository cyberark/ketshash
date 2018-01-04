# Ketshash
A little tool for detecting suspicious privileged NTLM connections, in particular Pass-The-Hash attack, based on event viewer logs.

The tool was published as part of the "Pass-The-Hash detection" research - more details on "Pass-The-Hash detection" are in the blog post: https://www.cyberark.com/threat-research-blog/detecting-pass-the-hash-with-windows-event-viewer

# Requirements
Account with the following privileges:
- Access to remote machines' security event logs
- ActiveDirectory read permissions (standard domain account)
- Computers synchronized with the same time, otherwise it can affect the results
- Minimum PowerShell 2.0  

# Overview
Ketshash is a tool for detecting suspicious privileged NTLM connections, based on the following information:
- Security event logs on the monitored machines (Login events)
- Authentication events from Active Directory

# Usage
There are two options: 
### Basic Usage
-	Open PowerShell and run:
	- `Import-Module .\Ketshash.ps1` or copy & paste Ketshash.ps1 content to PowerShell session
	- `Invoke-DetectPTH <arguments>`

### Ketshash Runner
-	Make sure Ketshash.ps1 is in the same directory of KetshashRunner.exe
-	Double click on KetshashRunner.exe, change settings if you need and press Run

![alt text](https://raw.githubusercontent.com/cyberark/ketshash/master/Media/KetshashRunnerGif.gif?token=ALcWEPkXJpNK_dv8CYnGkg0Za2oODfZAks5aQO5ewA%3D%3D)
	
## Invoke-DetectPTH
##### Parameters:
* __TargetComputers__ - Array of target computers to detect for NTLM connections.  
* __TargetComputersFile__ - Path to file with list of target computers to detect for NTLM connections.
* __StartTime__ - Time when the detection starts. The default is the current time.
* __UseKerberosCheck__ - Checks for TGT\TGS logons on the DCs on the organization. 
The default is to search for legitimate logon on the source machine. 
Anyway, with or without this switch there is still a query for event ID 4648 on the source machine.
* __UseNewCredentialsCheck__ - Checks for logon events with logon type 9 (like Mimikatz). 
This is optional, the default algorithm already covers it. 
It exists just to show another option to detect suspicious NTLM connections.
On the Windows versions 10 and Server 2016, "Microsoft-Windows-LSA/Operational" should be enabled in event viewer.
On Windows 10 and Server 2016, enabling "kernel object auditing" will provide more accurate information such as writing to LSASS.
* __LogFile__ - Log file path to save the results.
* __MaxHoursOfLegitLogonPriorToNTLMEvent__ - How many hours to look backwards and search for legitimate logon from the time of the NTLM event. The default is 2 hours backwards. 


##### Example (recommended):
`Invoke-DetectPTH -TargetComputers "MARS-7" -LogFile "C:\tmp\log.txt"`
![alt text](https://raw.githubusercontent.com/cyberark/ketshash/master/Media/KetshashScreenshot2.PNG?token=ALcWEKLGgMtw2Io8afFyo7gm8d8ysSXXks5aQ8ITwA%3D%3D)


##### Example:
`Invoke-DetectPTH -TargetComputers "ComputerName" -StartTime ([datetime]"2017-12-14 12:50:00 PM") -LogFile "C:\tmp\log.txt" -UseKerberosCheck -UseNewCredentialsCheck`

![alt text](https://raw.githubusercontent.com/cyberark/ketshash/master/Media/KetshashScreenshot.PNG?token=ALcWEG05x1Vo_c5Ac6mLwzHnYlDzp41Qks5aQO5NwA%3D%3D)

 
## Debugging
Because it uses threads, it is not possible to debug the script block of the main function.
A workaround can be by using Invoke-Command before the Detect-PTHMultithreaded:  
`Invoke-Command -ScriptBlock $detectPTHScriptBlock -ArgumentList $TargetComputers, $startTime, $LogFile, $UseKerberosCheck, $UseNewCredentialsCheck, $MaxHoursOfLegitLogonPriorToNTLMEvent`

Detect only one target computer:
`Invoke-DetectPTH -TargetComputers "<computer_name>" ...`

Change the `$TargetComputer` to be `[string]` instead of `[array]`.
This way it is possible to use breakpoints inside the script block of the main function.

# References
For more comments and questions, you can contact Eviatar Gerzi (@g3rzi) and CyberArk Labs.
