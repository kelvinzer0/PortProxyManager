# PortProxyManager

A simple Windows Forms application to manage `netsh` port proxy rules.

## Features

- **Add Port Proxy Rule:** Easily add a new `v4tov4` port proxy rule.
- **Delete Port Proxy Rule:** Delete an existing rule by its listen port.
- **List All Rules:** View all currently configured port proxy rules.
- **Auto Firewall Rule:** Automatically create a Windows Firewall rule to allow traffic on the listen port.
- **Input Validation:** Basic validation for IP addresses and port numbers.
- **Logging:** All executed commands are logged to `log.txt`.
- **Admin Privileges:** The application automatically requests to be run as an administrator.

## How to Use

1.  Download the latest release from the [Releases](https://github.com/YOUR_USERNAME/PortProxyManager/releases) page.
2.  Run the `PortProxyManager.exe` file.
3.  Fill in the "Listen Port", "Target Port", and "Target IP" fields.
4.  Use the buttons to manage your port proxy rules.

## Building from Source

To build the project from source, you will need the [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

1.  Clone the repository:
    ```sh
    git clone https://github.com/YOUR_USERNAME/PortProxyManager.git
    ```
2.  Navigate to the project directory:
    ```sh
    cd PortProxyManager
    ```
3.  Publish the application:
    ```sh
    dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
    ```
The executable will be located in `bin/Release/net8.0-windows/win-x64/publish/`.
