# SafeMailLink

Prevents spambots from harvesting email addresses from your webpages.

This package dynamically encodes all the _mailto:_ links found on your rendered webpages at runtime.

Any _mailto:_ links with pre-populated parameters for subject and body fields are also encoded. Email addresses used as text for the email hyperlink are protected as well.

## Download

To get a copy of SafeMailLink you have the following options:

* Download the source and run the `build.cmd` (which runs an MSBuild against `build.proj`)
* Install using NuGet: [`PM> Install-Package SafeMailLink`](https://nuget.org/packages/SafeMailLink/)
* or if you use Umbraco CMS, then try the [SafeMailLink for Umbraco](http://our.umbraco.org/projects/website-utilities/safe-mail-link) package

## Historical links

* The homepage of the original developer - [Marco Bellinaso](http://marcobellinaso.com/)
* [WayBack Machine archive of the original .Net2TheMax article](http://web.archive.org/web/20090818133549/http://www.dotnet2themax.com/ShowContent.aspx?ID=35efbee1-d8cd-4720-9eb2-83fc9a4033bb)
* [ASP.NET Control Gallery page for original SafeMailLink](http://www.asp.net/community/control-gallery/Item.aspx?i=829)

## License
Copyright &copy; 2004 Marco Bellinaso<br/>
Copyright &copy; 2011 Lee Kelleher<br/>

This project is licensed under [MIT](http://opensource.org/licenses/mit-license/).

Please see [LICENSE](LICENSE.txt) for further details.
