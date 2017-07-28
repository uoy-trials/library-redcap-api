# redcap-api
Redcap Api Library for C#

Usage:

1. dotnet restore
2. Add reference to library in your project
3. Add "using Redcap.Interfaces" namespace (contains some enums for redcap optional params)
4. instantiate a new instance of the redcapapi object
var rc = new Redcap.RedcapApi("redcap token here", "your redcap api endpoint here")
var version = await rc.GetRedcapVersionAsync(RedcapFormat.json, RedcapDataType.flat);