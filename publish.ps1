dotnet publish -c Release -r win10-x64
tools/windows-x64.warp-packer.exe --arch windows-x64 --input_dir tnsping/bin/Release/netcoreapp2.0/win10-x64/publish --exec tnsping.exe --output tnsping.exe