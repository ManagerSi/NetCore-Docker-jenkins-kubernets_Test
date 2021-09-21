# NetCore-Docker-jenkins-kubernets_Test
Test for NetCore 


------------------------------------------------
api服务
------------------------------------------------
	启动api服务
	  进入目录src\Jerry.NetCoreDemo\Jerry.NetCoreDemo.WebApi\bin\Debug\net5.0
	  打开cmd
	  输入命令：dotnet Jerry.NetCoreDemo.WebApi.dll --urls=http://localhost:8889 --port=8889
	  多开几个cmd，分别输入一下命令（启动多个服务实例）
	  dotnet Jerry.NetCoreDemo.WebApi.dll --urls=http://localhost:8880 --port=8880
	  dotnet Jerry.NetCoreDemo.WebApi.dll --urls=http://localhost:8881 --port=8881
	  dotnet Jerry.NetCoreDemo.WebApi.dll --urls=http://localhost:8882 --port=8882

	测试
		http://localhost:5000/WeatherForecast
		http://localhost:8889/WeatherForecast
	
------------------------------------------------
nginx
------------------------------------------------
	启动nginx（监听80端口）
		Tools\nginx-1.17.9 
		打开 cmd-> start nginx.exe (确保80端口没被占用，否则报错：An attempt was made to access a socket in a way forbidden)
		调整配置文件：Tools\nginx-1.17.9\conf\nginx.conf
	  
		启动		start nginx.exe
		查看进程	tasklist /fi "imagename eq nginx.exe"
		结束		nginx -s stop
		重新载入：	nginx.exe -s reload

	测试API服务
		http://localhost:8080/WeatherForecast
