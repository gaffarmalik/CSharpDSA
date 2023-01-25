using System;
namespace AlgorithmsDataStructures.OOP
{
	public class DerivedClass: BaseClass
	{
		public int _ConstructorArg { get; set; }

		public DerivedClass(int arg = 0):base(arg)
		{
			_ConstructorArg = arg;
		}


		
	}
}

