# CoInitializeSecurity

There seems to be a bug in .NET 6.0 runtime where a WinForm App cannot initialize CoInitializeSecurity properly because it always complain that must be run earilier.

`Security must be initialized before any interfaces are marshalled or unmarshalled. It cannot be changed once initialized.`

This repo demostrates the problem by creating 4 different binaries that target both .NET 5.0 and .NET 6.0 runtimes using ConsoleApp and WinFormsApp.

## Testing & Building
You can you just build.bat from the root directory or build manually using VS2002

## Results
 - `bin\net5.0-windows\ConsoleApp.exe` Works just Fine
 - `bin\net6.0-windows\ConsoleApp.exe` Works just Fine
 - `bin\net5.0-windows\WinFormsApp.exe` Works just Fine
 - `bin\net6.0-windows\WinFormsApp.exe` Does not work
