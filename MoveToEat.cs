using System;
using System.Collections;
public class MoveToEat : State
{
	public override void Enter()
	{
		base.Enter();
		Console.WriteLine(" Змея вошла в состояние двигаться к еде ");
	}

	public override void Exit()
	{
		base.Exit();
		Console.WriteLine(" Змея вышла из состояния двигаться к еде ");
	}

	public override void Update()
	{
		base.Update();
		Console.WriteLine(" Змея двигается к еде ");
	}
}