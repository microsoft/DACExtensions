These samples assume the latest SSDT updates for Visual Studio 2013 are installed. To develop using Visual Studio 2012 please modify the .csproj files to change "C:\Program Files (x86)\Microsoft Visual Studio 12.0" to ">C:\Program Files (x86)\Microsoft Visual Studio 11.0", and ensure the latest SSDT is installed for Visual Studio 2012.

These samples are intended to work in tandem with the walkthroughs (http://msdn.microsoft.com/en-us/library/dn268597(v=vs.103).aspx) and standard SSDT help documentation. They show how to bootstrap an extensions library for Static Code Analysis rules and contributors and test them without installing anything into Visual Studio. 

If you wish to install any samples DLL into visual studio you need to sign the DLLs per the walkthrough instructions:

To sign and build the assembly
- On the Project menu, click <ProjectName> Properties .
- Click the Signing tab.
- Click Sign the assembly.
- In Choose a strong name key file , click <New> .
- In the Create Strong Name Key dialog box, in Key file name , type MyRefKey .
- (optional) You can specify a password for your strong name key file.
- Click OK .
- On the File menu, click Save All .
- On the Build menu, click Build Solution .

Then copy them to the extension installation directory <Visual Studio Install Dir>\Common7\IDE\Extensions\Microsoft\SQLDB\DAC\120\Extensions.