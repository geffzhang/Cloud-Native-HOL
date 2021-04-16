# Prerequisites for attendees

## What you should know

We assume familiarity with

1. ASP.NET server-side code development
1. Know how to pull down NuGet packages into a project
1. Basic usage of git source control

## Services you should have pre-configured

We will use some cloud-based services

1. You should have an active GitHub account
1. You must have an active Azure subscription with credits remaining (your Visual Studio Subscription provides some number of free Azure credits)

## The workstation you should bring

Minimum hardware required:

* CPU with _at least_ 4 virtual cores (2 cores with hyperthreading)
  * i7 with 8 virtual cores (4 cores with hyperthreading) is recommended
* 8gb RAM is the bare minimum required
  * 16 is recommended
* High speed HDD
  * SSD strongly recommended
* Ability to connect to wifi

**Before arriving at the event** you should make sure your laptop workstation has the following:

> ℹ Assuming PC, but if you have a Mac you should have [comparable tooling installed](https://github.com/rockfordlhotka/Cloud-Native-HOL/blob/master/docs/prerequisites-mac.md).
> ℹ If you are unable to configure your laptop as shown here, you _might_ be able to use an Azure VM into which you remote desktop from the venue. Here are instructions on [setting up an Azure VM](https://github.com/rockfordlhotka/Cloud-Native-HOL/blob/master/docs/create-azure-vm.md) for the labs.

1. Windows 10 2004 or later
1. Visual Studio 2019 16.9.4 or later
1. Install/activate the [HyperV feature](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v) in Windows
1. (recommended) [Windows Subsystem for Linux (WSL2)](https://docs.microsoft.com/en-us/windows/wsl/install-win10)
   1. The following assumes Ubuntu or Debian
   1. Inside WSL install `sudo apt install git`
   1. Inside WSL install the Azure CLI command (Use the instructions at: https://docs.microsoft.com/en-us/cli/azure/install-azure-cli-apt?view=azure-cli-latest)
   1. Inside WSL install the Kubernetes CLI commands (Use the instructions at: https://kubernetes.io/docs/tasks/tools/install-kubectl/#install-kubectl-on-linux)
   1. You may want to follow the instructions in this blog so [WSL can seamlessly interact with Docker Desktop](https://nickjanetakis.com/blog/setting-up-docker-for-windows-and-wsl-to-work-flawlessly)
1. Install [Chocolatey](https://chocolatey.org) on Windows
1. Using Chocolatey from an _admin_ command line (cmd or PowerShell)
   1. `choco install dotnetcore-sdk` (or install the latest [.NET Core SDK](https://dotnet.microsoft.com/download) manually)
   1. `choco install git`
   1. `choco install docker-desktop`
   1. `choco install kubernetes-cli`
   1. `choco install kubernetes-helm`
   1. `choco install azure-cli`
   1. `choco install vscode` (or install [Visual Studio Code](https://code.visualstudio.com/) manually)
1. Enable Kubernetes in Docker Desktop
   1. to-do
1. Pull large Docker base images
   1. `docker pull mcr.microsoft.com/dotnet/core/aspnet:5.0-buster-slim`
   1. `docker pull mcr.microsoft.com/dotnet/core/runtime:5.0-buster-slim`
   1. `docker pull mcr.microsoft.com/dotnet/core/sdk:5.0-buster`
1. Clone this repo to your workstation: `git clone https://github.com/rockfordlhotka/Cloud-Native-HOL.git`
   1. There may be some last-minute fixes to the code so we recommend waiting to clone the repository until a day or two prior to the HOL

⚠ **Arriving with a pre-configured workstation is imperative.**
