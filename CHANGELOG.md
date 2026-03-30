# SimpleArch Changelog

## Version Beta

### Repo
#### Changed

- Forked Retroarch
- Built Retroarch
- Updated README.md
- Added CHANGELOG.md

### Release
#### Changed

- Included Cores: snes9x, mgba, genesis_plus_gx and melonds


## Version 1.0.0

### Repo
#### Changed

- Updated file "retroarch.exe" branding to reflect SimpleArch 

#### Added

- Directory "assets" for GitHub images
- File "SimpleArch-Banner.png" inside of directory "assets"
- Directory "launcher" for SimpleArch.exe sourcecode
- Directory "Properties" inside of directory "launcher"
- File "Form1.cs" inside of directory "launcher"
- File "Form1.Designer.cs inside of directory "launcher"
- File "Form1.resx" inside of directory "launcher"
- File "Program.cs" inside of directory "launcher"
- File "retroarch.ico" inside of directory "launcher"
- File "SimpleArch.csproj" inside of directory "launcher"
- File "SimpleArch.sln" inside of directory "launcher"

### Release
#### Changed

- Renamed original **SimpleArch.exe** to **SimpleArch-core.exe** and **Simplearch-Launcher.exe** to **SimpleArch.exe** to make finding the correct exe more "Simple". Simplearch.exe is a launcher which launches Simplearch-core.exe after a user has selected their game path.

- Automatic Database and core info files download after game selection - This prevents an issue where games would not be seen in the playlist after importing content.

- XMB set as default launcher automatically after game selection

- Updated file "README.md" to reflect Version 1.0.0

- Updated Changelog entry: "Version Beta" to include repo and release classification

#### Added

- File D3DCompiler_47_cor3.dll (SimpleArch.exe dependency)
- File PenImc_cor3.dll (SimpleArch.exe dependency)
- File PresentationNative_cor3.dll (SimpleArch.exe dependency)
- File vcruntime140_cor3.dll (SimpleArch.exe dependency) 
- File wpfgfx_cor3.dll (SimpleArch.exe dependency)
- File SimpleArch.exe (Was Simplearch-Launcher.exe)
- Changelog entry: "Version 1.0.0" and "SimpleArch Changelog" title

#### Removed

- Removed Changelog entry: "Planned for Version 1.1.0"


## Planned for Version 1.1.0

- Further core support
- Setting name changes to make finding required settings more "Simple"





