# 使用说明

## 1. 数据准备

### 1.1. 栅格数据

　　程序所需栅格数据为GlobalLand30（[主页](http://www.globallandcover.com/)）数据集2000、2010、2020这3年的数据全球地表覆盖产品。为了方便操作和处理，数据已经过标准化处理，并录入WGS84的空间范围。配套的栅格数据不能更换，并需要放置在程序相同路径下的data\img中，如下所示：

```
.
├── 02ShpMosaic.exe
├── data
│   └── img
|       └── r2000
|       └── r2010
|       └── r2020
```

### 1.2. 矢量数据

　　程序所需的矢量数据为面状的Shapefile文件。矢量数据可任意替换，但为提高运算效率，需要进行提前处理，满足以下几点要求： 

- 矢量包含Code_new字段，该字段类型为整型，且每个Feature的字段值不能重复（重复将导致结果数据互相覆盖）；
- 需要将矢量文件重命名为country.shp；
- 需要一份空间参考为WGS84的数据，用于进行所需栅格的空间查询，放置在data\shp\4326路径下；
- 需要一份空间参考为目标所需投影（坐标系的单位应为m，例如示例使用的World_Cylindrical_Equal_Area投影）的数据，用于进行最终结果的投影和裁剪，放置在data\shp\dst路径下。

　　矢量数据路径如下所示：

```
.
├── 02ShpMosaic.exe
├── data
│   └── shp
|       └── 4326
|           └── country.shp
|       └── dst
|           └── country.shp
```

## 2. 环境准备

### 2.1. 系统环境

　　程序只能在64位Windows操作系统下运行，并需提前安装Microsoft Visual C++ 2015-2019 Redistrubutable (x64)（[下载](https://aka.ms/vs/16/release/VC_redist.x64.exe)）和.NET Framework 4.8 Runtime（[下载](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-web-installer)）。

### 2.2. 环境变量

　　程序使用PROJ库（[主页](https://proj.org/)）进行重投影，目前使用的版本为6.3.2，需要配置PROJ_LIB环境变量，指向proj库所在路径。目前默认的proj库的路径为data\proj。

### 2.3. Shapefile注册

　　程序需要注册一份空间参考为WGS84的shapefile用于空间查询。由于程序目前不支持相对路径注册，首次使用程序前，应进行一次注册。

　　运行01RegistShp.exe进行注册，选择WGS84的矢量坐在路径，点击注册按钮进行注册。系统提示注册成功后，完成注册，程序可正常使用。

![registshp](doc\registshp.png)

## 3. 运行程序

　　完成上述数据准备和环境准备后，可以运行02ShpMosaic.exe进行影像镶嵌。选择所需的年份和输出路径，等待运行结束即可。

![shpmosaic](doc\shpmosaic.png)

