using System;
using System.Reflection.Metadata;

public interface Init
{
    public void Display()
    {
        ChooseProgram();
    }

    public string ChooseProgram()
    {
        return "";
    }
}