[ET论坛](https://et-framework.cn)  
[ET框架](https://github.com/egametang/ET)  6.0版本Matser  接入了Ilruntime 最新版本（该版本已解决多DLL泛型匹配错误等一系列问题）

基本保留了原本6.0的文件结构

# 待完成:
  
   很多地方的代码为了省事  看起来很丑  
   生成proto 需要修改  ResponseTypeAttribute 需要修改参数为string (偷懒了 没测试 不修改的情况下会不会有问题  看烟雨的修改了 所以 为了省事也修改一下)  
   生成配置  需要修改  需要去掉 ProtoAfterDeserialization 特性   


参考 
[et-6-with-ilruntime](https://www.lfzxb.top/et-6-with-ilruntime/) 烟雨接入的ILruntime   
[et-6-with-ilruntime 2](https://github.com/InMyBload/et6.0-ilruntime) InMyBload接入的ILruntime   