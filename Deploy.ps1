dotnet publish --self-contained -r win10-x64

cf push tn-nextgen-hello -b binary_buildpack -s windows2016 -c .\tn-nextgen-helloworld.exe -p .\bin\Debug\netcoreapp2.2\win10-x64\publish -i 2 -k 512M -m 512M
