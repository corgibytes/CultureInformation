# CultureInformation

This will loop over all cultures (including neutral cultures such as "es" and "en" which have no country component and the invariant country). It will display name information and the current date in the yyyy/MM/dd format. Here "/" is replaced with the date separator defined in the culture.

This tool can be updated to display other information and is a useful aid in determining possible impact to date and numeric string values in an application.

Note that this is setting the CurrentCulture, not the CurrentUICulture. The CurrentUICulture is used in conjunction with resource files to change displayed labels, etc.