// See https://aka.ms/new-console-template for more information

using MyFirstConsoleApp;

SubStringExamples  subStringExamples = new SubStringExamples();

Console.WriteLine(subStringExamples.SubStringNumber("Examples"));
Console.WriteLine(subStringExamples.SubStringWithLegth("Examples"));
Console.WriteLine(subStringExamples.SubStringNumberTryCatch("Examples"));
Console.WriteLine(subStringExamples.SubStringWithIndex("Exampl,es"));
Console.WriteLine(subStringExamples.SubStringWithIndexes("Examples"));

Console.WriteLine();
ParseIntExamples parseIntExamples = new ParseIntExamples();

Console.WriteLine(parseIntExamples.ParseInt("675"));
Console.WriteLine(parseIntExamples.ParseIntTryCatch("5765e"));
Console.WriteLine(parseIntExamples.Parseint32TryCatch("5675675"));
Console.WriteLine(parseIntExamples.ConvertInt("6575"));
Console.WriteLine(parseIntExamples.ParseNumberStyle("$687"));
Console.WriteLine(parseIntExamples.ParseNumberStyle("(687)"));

Console.WriteLine();
SplitStringExamples splitStringExamples = new SplitStringExamples();

DisplayArray(splitStringExamples.SplitText("THIS IS"));
DisplayArray(splitStringExamples.SplitCount("435435 FDF DS FFDDS"));
DisplayArray(splitStringExamples.SplitMultipleCharcters("This,is text[for]programming&mate"));





StringInterpulation StringInterpulation = new StringInterpulation();
Console.WriteLine(StringInterpulation.UsingAdd("first", "second")); 
Console.WriteLine(StringInterpulation.UsingStringFormat("first", "second")); 
Console.WriteLine(StringInterpulation.UsingStringInterpulation("first", "second")); 
Console.WriteLine(StringInterpulation.StringInterpulationObjects("first")); 
Console.WriteLine(StringInterpulation.StringInterpulationNewline("first", "second")); 

void DisplayArray(string[] array)
{
   for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
    Console.WriteLine();
}