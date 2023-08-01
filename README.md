# 水位动态监控系统

水位动态监控系统是一个开源项目，利用物理设备（例如水位传感器）监测实际环境的水位，并根据接收到的数据在Unity环境中动态地调整游戏对象的高度。

## 项目特性

1. 使用ESP8266开发板，通过水位传感器读取环境水位。
2. 通过UDP协议将水位数据传送至Unity应用程序。
3. Unity应用程序接收水位数据并动态调整游戏对象的高度。
4. 利用卡尔曼滤波进行数据平滑处理，更加逼真地模拟真实环境水位变化。

## 如何使用

克隆或下载本项目，然后按照以下步骤进行操作：

1. 将ESP8266代码上传到ESP8266开发板。
2. 在Unity3D中打开项目。
3. 打开 "Waterline" 场景。
4. 在Unity3D中运行项目。
5. 调整场景和物理设备以观察游戏对象高度的变化。

## 贡献

如果您发现错误或有改进的建议，请创建一个问题或提交一个拉取请求。

# Water Level Dynamic Monitoring System

The Water Level Dynamic Monitoring System is an open-source project that measures the water level in the actual environment with a physical device, such as a water level sensor, and dynamically adjusts the height of the game object in the Unity environment based on the received data.

## Features

1. Uses ESP8266 development board, reads environmental water levels using a water level sensor.
2. Transmits the water level data to a Unity application via the UDP protocol.
3. The Unity application receives water level data and dynamically adjusts the height of the game object.
4. Uses Kalman filtering for smooth data handling, simulating realistic water level changes more convincingly.

## How to Use

Clone or download this project and then follow these steps:

1. Upload the ESP8266 code to the ESP8266 board.
2. Open the project in Unity3D.
3. Open the "Waterline" scene.
4. Run the project in Unity3D.
5. Adjust the scene and physical device to observe the height changes of the game object.

## Contribution

If you find a bug or have a suggestion for improvement, please create an issue or submit a pull request.