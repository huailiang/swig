<p align="center">
    <a href="https://huailiang.github.io/">
    	<img src="https://huailiang.github.io/img/avatar-Alex.jpg" width="320" height="300">
    </a>
</p>

本项目说明文档参考：https://huailiang.github.io/2018/03/01/combinecoding/


首先，Unity是基于Mono也就是.Net的运行环境的，所以它肯定支持C#；然后，Unity团队自行开发了一种Boo的语言；后面可能考虑到用户的接受程度的问题，又开发了类似JS的一种语言，但那绝对不是JS，勉强可以称之为UnityScript。这三种语言的代码最后都会被编译执行，而且可以互相访问。

在Unity游戏的开发当中，我们的游戏项目变得越来越复杂，以至于有些项目功能必须通过依赖库来进行实现。

比如，我们在手游开发中用到的GVoice、FMOD或者是其他的插件，都是通过调用Native dll（C/C++）来实现一些复杂的功能。《王者荣耀》核心代码libGameCore.so 也是用c++完成的。

那么我们应该如何使用C#来对C++进行调用呢。

了解C#的人都知道，C#是运行在CLR之上被托管的，而C++则并没有被托管。

目前.Net平台中托管环境调用非托管环境有三种方法：

- P/Invoke
- C++ Interop
- COM Interop

这三种方法当中，C++ Interop是针对托管C++使用的方法（说实话C++/CLI感觉没啥前途），COM Interop则是针对Window软件开发而采用的方式。所以我们只剩下一种解决方案：也就是PInvoke来进行托管环境与非托管环境的互操作。不过由于PInvoke本身内容也并不少，所以在这里我也就简单介绍一下其使用的方式，更详细的内容可以去查看官方文档，或者是下一个《精通.Net互操作》的pdf来阅读就可以了。

如何做到c# 能调用到c++代码呢，下面我们通过一个小的Demo展示。
