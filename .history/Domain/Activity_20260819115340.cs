using System;

namespace Domain;

public class Activity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Title { get; set; }   

    public DateTime  MyProperty { get; set; }

}