string[] strings = { "You", "'re", "Hello", "the","World", "morethen3","23461", "bes", "t!!","stillmore" }; 
var result = strings.Where(s => s.Length <= 3).ToArray(); 
Console.Write("["); 
Console.Write(string.Join(", ", result)); 
Console.Write("]"); 