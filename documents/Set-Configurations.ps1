# What do I want to do?

# How will I Implement it?


#netsh http add urlacl url=http://+:80MyUri user=DOMAIN\user
$VerbosePreference = "Continue";
$ErrorActionPreference = "Stop";

$Domain = [Environment]::UserDomainName;
$User = [Environment]::UserName

$Command = "netsh http add urlacl url=http://+:8080/ user=$Domain\$User";
Write-Verbose -Message $Command;
Invoke-Expression -Command $Command;

$Command = "netsh http add urlacl url=http://+:8090/ user=$Domain\$User";
Write-Verbose -Message $Command;
Invoke-Expression -Command $Command;

control