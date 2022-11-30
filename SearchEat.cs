using System;
using System.Collections;
public class SearchEat : State
{
	public override void Enter()
	{
		base.Enter();
		Console.WriteLine(" Змея вошла в состояние поиска еды ");
	}

	public override void Exit()
	{
		base.Exit();
		Console.WriteLine(" Змея вышла из состояния поиска еды ");
	}

	public override void Update()
	{
		base.Update();
		Console.WriteLine(" Змея ищет еду ");
	}
}