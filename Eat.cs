using System;
using System.Collections;
public class Eat : State
{
	public override void Enter()
	{
		base.Enter();
		Console.WriteLine(" Змея вошла в состояние кушать ");
	}

	public override void Exit()
	{
		base.Exit();
		Console.WriteLine(" Змея вышла из состояния кушать ");
	}

	public override void Update()
	{
		base.Update();
		Console.WriteLine(" Змея кушает ");
	}
}