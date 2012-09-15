@ECHO OFF

IF EXIST bin RMDIR bin /S /Q
MKDIR bin

"%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe" /out:bin\Permutations.dll /target:library /recurse:src\code\*.cs /nologo

COPY lib\Machine.Specifications.0.5.8\lib\net40\Machine.Specifications.dll bin\ >> NUL
"%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe" /out:bin\Permutations.Specs.dll /target:library /reference:bin\Permutations.dll /reference:bin\Machine.Specifications.dll /recurse:src\specs\*.cs /nologo

@ECHO ON
