# 🐧 Linux Fundamentals with WSL2

## 📖 Overview

This repository contains my Linux learning journey using **Windows Subsystem for Linux 2 (WSL2)** with **Ubuntu**.

As part of my training, I practiced Linux fundamentals including:

- File and Directory Management
- User and Permission Management
- Process Monitoring
- Networking Commands
- Package Management
- Remote Access
- Service Management
- Archive and Compression Utilities

The hands-on practice was performed on **Ubuntu running on WSL2**.

---

# 🛠 Environment Setup

## Windows Subsystem for Linux (WSL2)

### Install WSL2

```powershell
wsl --install
```

### Install Ubuntu

```powershell
wsl --install -d Ubuntu
```

### Verify Installation

```bash
wsl --status
```

### Check Ubuntu Version

```bash
lsb_release -a
```

---

# 📂 Linux Commands Practiced

## 1. File & Directory Management

| Command | Purpose |
|----------|----------|
| pwd | Display current directory |
| ls | List files and folders |
| cd | Change directory |
| mkdir | Create directory |
| rmdir | Remove empty directory |
| rm | Remove files/directories |
| touch | Create empty file |
| cp | Copy files/directories |
| mv | Move or rename files |

---

## 2. File Viewing & Searching

| Command | Purpose |
|----------|----------|
| cat | Display file content |
| less | View file page by page |
| head | View first lines of file |
| tail | View last lines of file |
| grep | Search text patterns |
| find | Search files and directories |

---

## 3. Process Management

| Command | Purpose |
|----------|----------|
| ps | View running processes |
| top | Real-time process monitoring |
| kill | Terminate a process |

---

## 4. File Permissions & Ownership

| Command | Purpose |
|----------|----------|
| chmod | Modify file permissions |
| chown | Change ownership |

### Permission Types

```text
r = Read
w = Write
x = Execute
```

Example:

```bash
chmod 755 file.txt
```

---

## 5. Archive & Compression

| Command | Purpose |
|----------|----------|
| tar | Create and extract archives |
| unzip | Extract ZIP archives |

Example:

```bash
tar -cvf backup.tar folder/
tar -xvf backup.tar
```

---

## 6. Disk & Memory Monitoring

| Command | Purpose |
|----------|----------|
| free | View memory usage |
| df | View disk space |
| du | View directory size |

---

## 7. Networking Commands

| Command | Purpose |
|----------|----------|
| ping | Test connectivity |
| ifconfig | Display network information |
| ip | Manage network interfaces |
| route | View routing table |
| netstat | View active network connections |
| iptables | Configure firewall rules |

---

## 8. Remote Access & File Transfer

| Command | Purpose |
|----------|----------|
| ssh | Secure remote login |
| scp | Secure file transfer |
| curl | Transfer data using URLs |
| wget | Download files from internet |

Examples:

```bash
ssh user@server-ip
```

```bash
scp file.txt user@server-ip:/home/user
```

---

## 9. Package Management

### Ubuntu / Debian

```bash
sudo apt update
sudo apt upgrade
```

### Red Hat / CentOS

```bash
sudo yum install package-name
```

---

## 10. Service Management

| Command | Purpose |
|----------|----------|
| systemctl | Manage services |
| journalctl | View system logs |

Examples:

```bash
sudo systemctl status nginx
```

```bash
journalctl -n 20
```

---

## 11. System Information

| Command | Purpose |
|----------|----------|
| hostname | Display system hostname |
| uname | Display kernel information |
| date | Display current date and time |
| whoami | Display current user |

Examples:

```bash
hostname
uname -a
date
whoami
```

---

## 12. User Management

| Command | Purpose |
|----------|----------|
| sudo | Execute command as administrator |
| su | Switch user |
| adduser | Create user |
| passwd | Change password |
| usermod | Modify user properties |

Examples:

```bash
sudo adduser developer
```

```bash
sudo passwd developer
```

```bash
sudo usermod -aG sudo developer
```

---

## 13. Utility Commands

| Command | Purpose |
|----------|----------|
| echo | Print text or variables |

Example:

```bash
echo "Hello Linux"
```

---

# 🎯 Key Concepts Learned

- Linux File System Navigation
- File and Directory Operations
- Linux Permissions Model
- Ownership and Access Control
- Process Monitoring and Management
- Networking Fundamentals
- Remote Server Access using SSH
- Secure File Transfer using SCP
- Package Installation and Updates
- System Services Management
- Log Monitoring
- User Administration
- Archive and Compression Techniques

---

# 🚀 Outcome

Through hands-on practice in Ubuntu on WSL2, I gained practical experience with essential Linux commands used by:

- Software Developers
- .NET Full Stack Developers
- Cloud Engineers

This learning serves as a strong foundation for working with Linux-based development and cloud environments.

---

## 👨‍💻 Author

**Amarnath Kolla**

Passionate about Cloud Computing, Linux and Backend Development.
