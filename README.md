<p align="center">
  <img src="Assets/logo.png" width="176"><br>
  <b>An utility to convert Unified Update Platform file sets into Windows Media files</b><br>
  <a href="./src">Source Code</a> |
  <a href="./docs">Documentation</a> |
  <a href="./thirdparty">Third party libraries</a> |
  <a href="https://github.com/gus33000/UUPMediaCreator/releases">Downloads</a>
  <br><br>
  <img src="https://github.com/gus33000/UUPMediaCreator/actions/workflows/ci.yml/badge.svg">
</p>

## Readme

UUP Media Creator is a set of tools designed to help you scan, fetch updates from Microsoft own Unified Update Platform (UUP), and allow you to create medium out of it when an appropriate tool does not exist in the wild.

Right now the tooling includes:

- UUPDownload: Allows you to scan, fetch and download updates from UUP (Windows Desktop, Windows 10X, Windows Holographic, Windows Server, Windows Mobile, Windows IoT etc...)
- UUPMediaConverter: Allows you to convert a downloaded UUP update for Windows Desktop into an usable ISO image to use in last decade DVD reader or simply mounted.

## Credits and Acknowledgements

- Rafael Rivera (@WithinRafael - https://github.com/riverar) for being a strong supporter of this project and a few contributions
- Lucas (@thebookisclosed - https://github.com/thebookisclosed) for a lot of important contributions to this project including the AppX code for Nickel and beyond

## Supported features by OS

| Feature                                                                                  | Windows  | Linux (3) | macOS    |
|------------------------------------------------------------------------------------------|----------|-----------|----------|
| Downloading files from UUP (UUPDownload)                                                 | ✅       | ✅       | ✅       |
| Replaying past downloads from UUP (UUPDownload)                                          | ✅       | ✅       | ✅       |
| Decrypting ESRP payloads from UUP (UUPDownload)                                          | ✅       | ✅       | ✅       |
| Verifying downloaded payloads from UUP (UUPDownload)                                     | ✅       | ✅       | ✅       |
| Sample available builds from UUP (get-builds argument) (UUPDownload)                     | ✅       | ✅       | ✅       |
| Converting Desktop UUP files to an ISO for one base edition (UUPMediaConverter)          | ✅       | ✅       | ✅       |
| Does not require administrative privileges for base edition ISO images                   | ✅       | ✅       | ✅       |
| CLI available                                                                            | ✅       | ✅       | ✅       |
| ARM64 Support (aka works on @sinclairinat0r device (TM))                                 | ✅       | ✅       | ✅       |
| GUI available                                                                            | ❌       | ❌       | ❌       |
| Converting Desktop UUP files to an ISO for all possible editions (UUPMediaConverter)     | ✅       | ❌       | ❌       |
| ISO Preinstallation Environment close to original (UUPMediaConverter)                    | ✅       | ❌       | ❌       |
| ISO built by CDImage Mastering Utility with UDF and boot sector (UUPMediaConverter)      | ✅       | ❌       | ❌       |
| ISO built by mkisofs with UDF and boot sector (UUPMediaConverter)                        | ❌       | ✅   (1) | ✅   (2) |
| Update file integration (UUPMediaConverter)                                              | ❌       | ❌       | ❌       |
| Building Hololens, Mobile, 10X, IoT images                                               | ❌       | ❌       | ❌       |
| UUPDownload ease of use (getting there...)                                               | ❌       | ❌       | ❌       |

(1): requires ```apt-get install genisoimage```

(2): requires ```brew install cdrtools```

(3): requires ```apt-get install libfuse2```


## Usage

UUPDownload might be a little too complicated to use for some people. For reference purposes, here's a current set of parameters you can try as of ```2024-07-11```:

| Primary Commands          | Effect   |
|---------------------------|--------------------------------------------------------------------------------------------------------------------------|
| request-download          | (default) Request a download from zero using a number of different request parameters.                                   |
| replay-download           | Replay a download from zero using a .uupmcreplay file.                                                                   |
| get-builds                | Get builds in all rings matching the request type                                                                        |
| help                      | Display more information on a specific command.                                                                          |
| version                   | Display version information.                                                                                             |


| Channel                   | Command |
|---------------------------|--------------------------------------------------------------------------------------------------------------------------|
| Retail (Desktop)          | -s Professional -v 10.0.22631.1 -r Retail -b Retail -c vb_release -t [your architecture]                                 |
| Retail (IoT Core)         | -s IoTUAP -v 10.0.17763.1 -r Retail -b Retail -c rs5_release -t [your architecture]                                      |
| Retail (Mobile)           | -s MobileCore -v 10.0.15254.1 -r Retail -b Retail -c feature2 -t [your architecture]                                     |
| Retail (Team)             | -s PPIPro -v 10.0.22631.1 -r Retail -b Retail -c vb_release -t [your architecture]                                       |
| Retail (Server)           | -s DatacenterServer -v 10.0.22631.1 -r Retail -b Retail -c ni_release -t [your architecture]                             |
| Release Preview (Desktop) | -s Professional -v 10.0.19043.1 -r External -b ReleasePreview -c vb_release -t [your architecture]                       |
| Release Preview (HCI)     | -s AzureStackHCIServerCore -v 10.0.26100.1 -r External -b ReleasePreview -c ge_release -t amd64 [your architecture]      |
| Beta (Desktop)            | -s Professional -v 10.0.22635.3566 -r External -b Beta -c ni_release -t [your architecture]                              |
| Beta (Team)               | -s PPIPro -v 10.0.22635.3566 -r External -b Beta -c ni_release -t [your architecture]                                    |
| Dev (Desktop)             | -s Professional -v 10.0.26120.961 -r External -b Dev -c ge_release -t [your architecture]                                |
| Dev (Team)                | -s PPIPro -v 10.0.26120.961 -r External -b Dev -c ge_release -t [your architecture]                                      |
| Canary (Desktop)          | -s Professional -v 10.0.26252.5000 -r External -b canarychannel -c ge_prerelease -t [your architecture]                  |
| Client (All)              | -s 4 -v 10.0.26100.1 -r external -c ge_release_svc_oem  -l en-us -t [your architecture]                                  |
| Server (All)              | -s 408 -v 10.0.26100.1 -r external -c ge_release_svc_oem  -l en-us-t [your architecture]                                 |

**TIP 1:** You can append ```-e [Edition to download]``` to get the files needed only for a specific edition
**TIP 1.1:** You dont even need edition names, use product numbers if you know them.

**TIP 2:** You can append ```-l [Language to download]``` to get the files needed only for a specific language

**TIP 3:** Possible architectures:   amd64, arm64, x86, unknown, wcemipsv2, axp, sh3, sh3dsp, sh4, sh5, arm, thumb,
                                     woa, am33, powerpc, powerpcfp, ia64, mips16, mipsfpu, mipsfpu16, ebc, m32r

**TIP 4:** See 'editions.txt' for a full list of currently known SKUs, as well as experimental options.


### Important

The ```-v``` is __not__ used to specify which version of Windows you want to download! The parameters used by UUPDownload above are used to tell Windows Update **which** version of Windows you are currently running. Therefore, the ```-v``` parameter is used to tell Windows Update your current version of Windows. You will never get versions lower than the value specified in ```-v``` and some requests may also never get you the version specified in ```-v``` but only newer. If, however, you want to download a very specific version using ```-v``` __then__ you must use the ```-y``` option to tell Windows Update you only want this version.

## Contributing

You are free to contribute to this project, in fact we would welcome any form of help. But please keep in mind the following points if you do:

- Please try to maintain your PR with a reasonable set of commits
- Please try to not change functionality not concerned by your PR
- Avoid changing the entire app, if you feel like this is needed, please file an issue so we can discuss about it between contributors.

## Bugs

This project, as with anything in Computer Science, is not bug free. If you find anything wrong, please file an issue in the issue tracker. Please include the tool version, as well as the Operating System you are running on your computer, and any other applicable details helpful to reproduce the issue.
