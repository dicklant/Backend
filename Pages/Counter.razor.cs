using Microsoft.AspNetCore.Components;

namespace Backend.Pages;

public class CounterBase : ComponentBase
{
    protected int currentCount = 0;
    protected string computeResult = "";

    protected void IncrementCount()
    {
        currentCount++;
    }

    protected void ComputeData()
    {
        computeResult = "Début";

        for (int i = 0; i < 600; i++)
        {
            Thread.Sleep(10);
        }

        computeResult = "Fin";

    }
}