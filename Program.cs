using System.Text.Json;

JsonSerializerOptions options = new() { IncludeFields = true };

var testTuple = ("test", "test1", 1324, false);
var serializedTuple = JsonSerializer.Serialize(testTuple, options);
Console.WriteLine(serializedTuple);

var testTuple2 = (NamedItem1: "test", NamedItemTwo: "test1", TheIntegersName: 1324, ThisBoolHasAFirstNameIts: false);
var serializedTuple2 = JsonSerializer.Serialize(new { testTuple2.NamedItem1, testTuple2.NamedItemTwo, testTuple2.TheIntegersName, testTuple2.ThisBoolHasAFirstNameIts }, options);
Console.WriteLine(serializedTuple2);