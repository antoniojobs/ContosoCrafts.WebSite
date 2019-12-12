
@echo off
set /p projetonome="DIGA O NOME DO PROJETO: "
set /p template="DIGA O TIPO DE PROJETO EXEMPLOS -> MVC, WEB, console, classlib, wpf, wpflib, wpfcustomcontrollib, wpfusercontrollib, winforms, winformslib, worker, mstest, nunit, nunit-test, xunit, RAZORCOMPONENT, page, viewimports, viewstart, blazorserver,webapp, angular, react, reactredux, webapi, grpc, , gitignore, globaljson, nugetconfig, tool-manifest, webconfig, sln, proto: "
echo O NOME do projeto e/ %projetonome% . e o TEMPLATE e/ %template%
dotnet new %template% -n %projetonome%
pause