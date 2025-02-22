﻿namespace TestCases.JsonArrayBindingForIEnumerableProps;

public class Request
{
    public double[] Doubles { get; set; }
    public IEnumerable<int> Ints { get; set; }
    public List<Guid> Guids { get; set; }
    public ICollection<DateTime> Dates { get; set; }
}

public class Response : Request
{
}
