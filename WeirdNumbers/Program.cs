using System;

class Program {
  public static void Main (string[] args) {
		WeirdIntegers();
    WeirdFloats();
  }

  public static void WeirdFloats(){
    Console.WriteLine("\n\nNow let's look at floats...");
    bool weird = false;
    float bigFloat = 16000000;
    while (!weird){
      float biggerFloat = bigFloat + 1;
      Console.WriteLine($"{biggerFloat} is one bigger than {bigFloat}");
      if (biggerFloat == bigFloat){
        Console.WriteLine($"???????? {bigFloat} + 1 is {biggerFloat}. END THIS MADNESS!");
        Console.WriteLine($"(incidentally, bigFloat is 2 to the power {Math.Log2(bigFloat)})");
        return;
      }
      // if ( BitConverter.GetBytes(bigFloat)!= BitConverter.GetBytes(biggerFloat)){
      //   Console.WriteLine("Exept now apparently. END THIS MADNESS!");
      // }
      bigFloat += 500000;
    }
  }
	public static void WeirdIntegers(){

		int bigNum = 2147483645; //Pretty big for a 32-bit signed (2s complement) integer		

		Console.WriteLine ("\n\nStarting test 1 with int32 counting up...");
		for (int i = 0; i<10; i++){
			Console.Write($"{bigNum} .. ");
			bigNum = bigNum + 1;
		}

		Console.WriteLine ("\n\nStarting test 2 with int32 counting down...");
		int smallNum = -2147483646; //Pretty small for a 32-bit signed integer

		for (int i = 0; i<5; i++){
			Console.Write($"{smallNum} .. ");
			smallNum = smallNum - 1;

		}

		Console.WriteLine ("\n\nStarting test 3 with int64 (AKA long) counting up...");
		long bigNum2 = 9223372036854775807;//Pretty big for a 64-bit signed integer

		for (int i = 0; i<5; i++){
      Console.Write($"{bigNum2} .. ");
			bigNum2 = bigNum2 + 1;
		}

		Console.WriteLine ("\n\nStarting test 4 with uint counting up...");
		uint bigNum3 = 4294967291; //32-bit unsigned int

		for (int i = 0; i<10; i++){
			Console.Write($"{bigNum3} .. ");
			bigNum3 = bigNum3 + 1;
		}
	}
}

