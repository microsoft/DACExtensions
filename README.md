# DACExtensions

##Project Description
DACExtensions contains API extensions and samples using the [DacFx API](https://msdn.microsoft.com/en-us/library/dn645454.aspx) to develop Data-Tier Applications.

These extensions and samples include an improved object model, deployment contributors and static code analysis rules that can be used with Visual Studio or directly with the DacFx public API.

##Background Information
SQL Server Data Tools is built into Visual Studio 2013. For other versions of visual studio you can download SQL Server Data Tools from the [Data Developer Center](https://msdn.microsoft.com/en-us/data/hh297027)

SQL Server Data Tools provides an integrated environment for database developers to carry out all of their database design work for any SQL Server Platform. 

DacFx is the core technology the SQL Server Data Tools leverages for incremental database deployments, modelling and validation of database schemas and other key functionality. DacFx provides a DacServices API that supports programmatic deployment of Dacpac files. 
DacFx has a number of public extensibility points that customers can implement. Some possible functionality includes:

* Programmatic examinations of database schemas (as represented in a Visual Studio database project, a Dacpac and even a target database when used during deployment) 
* Modification of the deployment plans used to incrementally deploy schema updates from a Dacpac to a database 
* Static Code Analysis rules provide build-time support for analyzing the database schema and warning users of potential issues. 

These samples are primarily intended to show users how to create their own extensions, test them and use them in deployment. They include solutions to real customer problems and can be used as-is if you have the same issue. Ideally you will take this project, extend it and create your own solutions.

##Prerequisites
An installation of SQL Server Data Tools or DacFx is required to run these samples. The sample projects include references to DLLs in a Visual Studio installation with the most recent release of SQL Server Data Tools.

* For Visual Studio 2013 the install directory will is "%ProgramFiles(x86)%\Microsoft Visual Studio 12.0\Common7\IDE\Extensions\Microsoft\SQLDB\DAC\120".
 * This is set as the current hint path in all sample projects 
* For Visual Studio 2012 the install directory is "%ProgramFiles(x86)%\Microsoft Visual Studio 11.0\Common7\IDE\Extensions\Microsoft\SQLDB\DAC\120".
 * The hint path in all sample projects must be updated if you want to target Visual Studio 2012 DLLs.
* For DacFx the install directory is "%ProgramFiles(x86)%\Microsoft Server Server \Common7\IDE\Extensions\Microsoft\SQLDB\DAC\120". 
 * The hint path in all sample projects must be updated if you want to target the DacFx DLLs.

This project uses Git for source code control. Visual Studio 2013 has Git support built in, and for Visual Studio 2012 please download the  Visual Studio Tools for Git plugin.

##Usage
The samples in this project are provided as-is. To run the samples, we recommend you download the source code and attach a debugger while running the sample console application and unit test code. 

The full tutorial explaining how to use the public APIs can be found [here][dacfxturorial].

##Samples Installation

These samples assume the latest SQL Server Data Tools updates for Visual Studio 2013 are installed. 
To develop using Visual Studio 2012 please modify the .csproj files to change 
"C:\Program Files (x86)\Microsoft Visual Studio 12.0" to "C:\Program Files (x86)\Microsoft Visual Studio 11.0", and ensure the latest version of SQL Server Data Tools is installed for Visual Studio 2012.

These samples are intended to work in tandem with the walkthroughs at
[http://msdn.microsoft.com/en-us/library/dn268597(v=vs.103).aspx][msdn] and with the standard 
SQL Server Data Tools help documentation. They show how to bootstrap an extensions library for Static 
Code Analysis rules and contributors and test them without installing anything into 
Visual Studio. 

If you wish to install any samples DLL into visual studio you need to sign the DLLs per 
the walkthrough instructions:

To sign and build the assembly

* On the Project menu, click <ProjectName> Properties .
* Click the Signing tab.
* Click Sign the assembly.
* In Choose a strong name key file , click <New>.
* In the Create Strong Name Key dialog box, in Key file name , type MyRefKey.
* (optional) You can specify a password for your strong name key file.
* Click OK.
* On the File menu, click Save All.
* On the Build menu, click Build Solution.


Then copy them to the extension installation directory:

* VS 2013: %ProgramFiles(x86)%\Microsoft Visual Studio 12.0\Common7\IDE\Extensions\Microsoft\SQLDB\DAC\120\Extensions
* VS 2012: %ProgramFiles(x86)%\Microsoft Visual Studio 11.0\Common7\IDE\Extensions\Microsoft\SQLDB\DAC\120\Extensions

##Code of Conduct
This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

[msdn]:http://msdn.microsoft.com/en-us/library/dn268597(v=vs.103).aspx
[dacfxturorial]:http://blogs.msdn.com/b/ssdt/archive/2013/12/23/dacfx-public-model-tutorial.aspx
