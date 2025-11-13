# USB-Stealer (Only Chinese Version)

---

## 中文文档 | Chinese Documentation

### 项目介绍
一款能够在U盘插入电脑时，自动静默复制U盘目录结构及指定格式文件到预设文件夹的工具。

开发背景：帮朋友开发的，朋友的老师答应会在期末给同学所有课程的PPT，但估计PPT里面存在有关期末考试试题的内容，到期末了也没给，于是就出现了这个小程序。为了兼容教室的Win7老电脑，用的很老的.Net framework版本。

### 核心功能
- 实时监测U盘插入：当U盘接入电脑时，自动触发检测与复制流程
- 目录结构保留：完整复制U盘内的文件夹层级关系，确保备份内容组织结构与原U盘一致
- 指定格式筛选：支持自定义需要复制的文件格式（如.docx、.jpg、.mp4等），避免无效文件占用空间
- 静默后台运行：整个复制过程在后台完成，无弹窗干扰，不影响正常电脑使用
- 预设备份路径：可自定义备份文件的保存目录，支持设置多个备选路径

### 使用说明
- 运行Stealer/bin/Release下的可执行程序即可

### 注意事项
- 首次使用需授予工具文件系统访问权限，部分系统可能需要以管理员身份运行
- 复制速度取决于U盘读写速度、文件大小及数量，大文件复制可能需要较长时间
- 若U盘已加密或存在权限限制，可能导致部分文件复制失败，日志中会标注异常文件
- 建议定期清理备份目录，避免重复备份导致的存储空间占用过大
- 目前支持Windows系统，macOS/Linux版本待开发

### 免责声明
本工具仅用于合法的文件备份场景，使用者应确保对所复制的U盘内容拥有合法访问权。因违规使用（如复制他人隐私文件、侵权内容等）导致的任何法律责任，由使用者自行承担，开发者不承担相关责任。

---

## English Documentation

### Project Description
A tool that automatically and silently copies the directory structure and specified format files of a USB drive to a pre-set folder when the USB drive is inserted into a computer.

Development Background: In scenarios where regular backup of USB drive contents (such as work files, photo materials) is required, manual copying is not only cumbersome but also prone to omissions or forgetfulness. This tool automatically monitors USB insertion events and completes the copying of specified content in the background, improving backup efficiency and avoiding manual operation errors.

### Core Features
- Real-time USB insertion monitoring: Automatically triggers detection and copying process when a USB drive is connected to the computer
- Directory structure retention: Completely replicates the folder hierarchy in the USB drive, ensuring the backup content structure is consistent with the original
- Specified format filtering: Supports customizing file formats to be copied (e.g., .docx, .jpg, .mp4), avoiding invalid files from occupying space
- Silent background operation: The entire copying process runs in the background without pop-up interruptions, not affecting normal computer use
- Preset backup path: Allows customizing the save directory for backup files, supporting multiple alternative paths

### Usage Instructions
- Run stealer.exe in release directory (Stealer/bin/Release).

### Notes
- First-time use requires granting the tool file system access permissions; some systems may require running as administrator
- Copy speed depends on USB read/write speed, file size and quantity; large file copying may take longer
- If the USB drive is encrypted or has permission restrictions, some files may fail to copy, and abnormal files will be marked in the logs
- It is recommended to regularly clean up the backup directory to avoid excessive storage space occupation due to repeated backups
- Currently supports Windows system; macOS/Linux versions are under development

### Disclaimer
This tool is only for legal file backup scenarios, and users should ensure they have legal access rights to the copied USB drive contents. Any legal liability caused by illegal use (such as copying others' private files, infringing content, etc.) shall be borne by the user, and the developer shall not be held responsible.
