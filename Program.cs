using System;
using System.Collections;

class Program
{
	
	static void Main()
	{
		StateMachine _SM = new StateMachine();
		_SM.Initialize(new SearchEat());
		_SM.ChangeState(new MoveToEat());
		_SM.ChangeState(new Eat());
		//Console.WriteLine("asda = " + _SM)
	}
}