using Microsoft.AspNetCore.Components;

namespace Backend.Pages;

public class CycleVieBase : ComponentBase {

    protected bool isLoading {get; private set;} 

    public CycleVieBase() {
        System.Console.WriteLine("Constructeur...");
    }

    protected override void OnInitialized() {
        System.Console.WriteLine("start OnInitialized...");
        isLoading = true;
        System.Console.WriteLine("début chargement des données");
        _ = Task.Delay(4000).ContinueWith( async _ => { isLoading=false; await InvokeAsync(StateHasChanged); });
        System.Console.WriteLine("fin chargement des données");
        System.Console.WriteLine("end OnInitialized...");        
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        if(firstRender)
           System.Console.WriteLine("OnAfterRender first call");
        else
            System.Console.WriteLine("OnAfterRender not first call");
    }
}