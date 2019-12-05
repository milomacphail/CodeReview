public class Dice // container(main function)
{
	public int sides;
	public int value; 
	public Random rand;
	
	public Dice(int sides) 
	{
		this.sides = 20; 
		this.value = 1; 

	}
	
	public int Roll(Random rand) 
	{
		return rand.Next(1, this.sides + 1); 
	}
}

public class HitOrMiss
{
	public bool Compare(int x, int y)
	{
		if(x + y >= 20)
		{
			return true;
		}
		return false;
	}
}

public class Program
{	
	public static void Main()
	{
		var newDice = new Dice(20);
		var rand = new Random();
		var compare = new HitOrMiss();
		
    var hitDice = newDice.Roll(rand);
		var modifier = newDice.Roll(rand);
		var hitOrMiss = compare.Compare(hitDice, modifier);
		
		Console.WriteLine("hit: " + hitDice);
		Console.WriteLine("modify: " + modifier);
		Console.WriteLine(hitDice + modifier);
		Console.WriteLine("critical hit? " + hitOrMiss);
	}
}
