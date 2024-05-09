# YTU REDCap API Library for .NET
The REDCap Api Library for .NET provides the ability to interact with REDCap programmatically using various .NET languages(C#,F#,VB.NET);

- Repo-Status: Active
- Repo-Contents: Library
- Repo-Service-Name: YTU REDCap API Library for .NET
- Repo-Ownership-Rating: 2
- Repo-Quality-Rating: 5
- Repo-Next-Review-Due: 2025-05-09

__Prerequisites__
1.  Local redcap instance installed (visit https://project-redcap.org) if you need to download files(assuming you have access)
2.  Create a new project with "Demographics" for the template; this gives you a basic project to work with.
3.  Create an api token for yourself, replace that with the tokens you see on the "RedcapApiTests.cs" files, and others
4.  You'll may need to add a field type of "file_upload" so that you can test the file upload interface of the API
5.  Build the solution, then run the tests

__API METHODS SUPPORTED (Not all listed)__
* ExportLoggingAsync
* ExportDagsAsync
* ImportDagsAsync
* DeleteDagsAsync
* ExportArmsAsync
* ImportArmsAsync
* DeleteArmsAsync
* ExportEventAsync
* ImportEventAsync  
* ExportFileAsync
* ImportFileAsync
* DeleteFileAsync
* ExportMetaDataAsync
* ExportRecordsAsync
* ImportRecordsAsync
* ExportRedcapVersionAsync
* ExportUsersAsync

__Usage__:

1. dotnet restore
2. Add reference to the library in your project, or download from nuget into project
3. Add "using Redcap" namespace
4. Add "using Redcap.Models" for convenience
5. Replace the demo api token with your test project or you can import the data dictionary in \Docs
thats provided for convenience.
6. Feel free to contribute 

__Sample / Example__
```C# 

using System;
using Newtonsoft.Json;
using Redcap;
using Redcap.Models;

namespace RedcapApiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Redcap Api Demo Started!");
            // Use your own API Token here...
            var apiToken = "3D57A7FA57C8A43F6C8803A84BB3957B";
            var redcap_api = new RedcapApi("https://localhost/redcap/api/");

            Console.WriteLine("Exporting all records from project.");
            var result = redcap_api.ExportRecordsAsync(apiToken).Result;

            var data = JsonConvert.DeserializeObject(result);
            Console.WriteLine(data);
            Console.ReadLine();

        }
    }
}

```

__Install directly in Package Manager Console or Command Line Interface__
```C#
Package Manager

Install-Package RedcapAPI -Version 1.3.1

```

```C#
.NET CLI

dotnet add package RedcapAPI --version 1.3.1

 ```

```C#
Paket CLI

paket add RedcapAPI --version 1.3.1

```

__Example Project__

A console project has been included with the source code to get started. Some examples of method usage. You can use this to get started potentially.

__Test Project__

A project with associated test cases is included. Make sure to change the api token

# Please Cite Us
Publications resulting from the use of this software should cite the Wright Center's Clinical and Translational Science Award (CTSA) grant #UL1TR002649, National Center for Advancing Translational Sciences, NIH.

