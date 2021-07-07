# Culture Information

This will loop over all cultures in .NET (including neutral cultures such as "es" and "en" which have no country component and the [invariant](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.invariantculture?view=net-5.0) culture). It will display name information and the current date in the yyyy/MM/dd format. Here "/" is the [custom format specifier](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings?redirectedfrom=MSDN#dateSeparator) and is replaced with the date separator defined in the culture.

This tool can be updated to display other information and is a useful aid in determining possible impact to date and numeric string values in an application.

Note that this is setting the [CurrentCulture](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.currentculture?view=net-5.0), not the [CurrentUICulture](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.currentuiculture?view=net-5.0). The CurrentUICulture is used in conjunction with resource files to change displayed labels, etc.

# Usage

This application requires [.NET 5 Core](https://dotnet.microsoft.com/download/dotnet/5.0) to be installed.  

You can either open and run the Solution in your IDE of choice (e.g. Rider, Visual Studio, etc) or use the command line to run it.  If using the command you can run it via:

```bash
dotnet run --project Corgibytes.CultureInformation\Corgibytes.CultureInformation.csproj
```

It will product output like:

```bash
C:\Repos\CultureInformation>dotnet run --project Corgibytes.CultureInformation\Corgibytes.CultureInformation.csproj
Code: , EnglishName: Invariant Language (Invariant Country), Native Name: Invariant Language (Invariant Country)
Current Date in yyyy/MM/dd format: 2021/06/30

Code: aa, EnglishName: Afar, Native Name: aa
Current Date in yyyy/MM/dd format: 2021-06-30

Code: aa-DJ, EnglishName: Afar (Djibouti), Native Name: aa (DJ)
Current Date in yyyy/MM/dd format: 2021-06-30

Code: aa-ER, EnglishName: Afar (Eritrea), Native Name: aa (ER)
Current Date in yyyy/MM/dd format: 2021-06-30

...
```

# Contributing
Let us know what other culture information you would like to see by opening [issue](https://github.com/corgibytes/CultureInformation/issues) or [pull request](https://github.com/corgibytes/CultureInformation/pulls).  You can also use the above to ask questions, report a bug, or make suggestion/enhancement.