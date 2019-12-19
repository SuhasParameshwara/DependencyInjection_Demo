using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using AutoMapper;
using log4net;

namespace ConsoleApp_DI
{
	class Program
	{
		static IContainer Container { get; set; }
		static void Main(string[] args)
		{
			Container = BuildContainer();
			var log = Container.Resolve<LogProvider>();
			log.GetCurrentClassLogger();
		}


		static IContainer BuildContainer()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<LogProvider>().As<ILogger>();
			return builder.Build();
		}
	}
}
