namespace WillowMaze.Wasm.Decompiled;

public class Pf86eb069 : ViewModel
{
    private readonly MutableLiveData F03ebecb5;
    private readonly p542529df F1dd78f9b;
    private readonly MutableLiveData F21c84766;
    private readonly p2e423cc6 F32414d01;
    private readonly p2e423cc6 F4734ade7;
    private readonly p2e423cc6 F4f91323d;
    private bool F724dae47;
    private readonly MutableLiveData F9861cee4;
    private readonly pd027b535 Fb3f20355;
    private bool Fcd49a5f3;
    private readonly pd027b535 Fe6209f69;
    private bool Feb80977a;
    private readonly p542529df Ffa019ae8;
    private readonly p2e423cc6 Ffdbb02df;

    public static p2e423cc6 M5fb81a65(pf86eb069 P0)
    {
        // field: p1e11b989.paad653ca.p2486923a.pf86eb069.f4734ade7
        return default!;
    }

    public static p542529df Mdfe9ad70(pf86eb069 P0)
    {
        // field: p1e11b989.paad653ca.p2486923a.pf86eb069.f1dd78f9b
        return default!;
    }

    public static Task Mf8eed35c(pf86eb069 P0, string P1, string P2, int P3, object P4)
    {
        // str: ""
        // call: pf86eb069.backPreviousScreenWithResult
        return Task.CompletedTask;
    }

    public Task BackPreviousScreenWithResult(string P0, string P1)
    {
        // str: "oldNote"
        // call: ViewModelKt.getViewModelScope
        // call: pf86eb069$pb9b0ba23$1.<init>
        // call: BuildersKt.launch$default
        // call: Intrinsics.checkNotNullParameter
        // type: pf86eb069$pb9b0ba23$1
        return Task.CompletedTask;
    }

    public bool GetEditable()
    {
        // field: p1e11b989.paad653ca.p2486923a.pf86eb069.feb80977a
        return false;
    }

    public void HideHint()
    {
        // call: pf86eb069.showHint
        // call: pd027b535.setShowNoteReceiptHint
        // field: p1e11b989.paad653ca.p2486923a.pf86eb069.fb3f20355
    }

    public LiveData ObserveAvailabilityBtn()
    {
        // field: p1e11b989.paad653ca.p2486923a.pf86eb069.f03ebecb5
        return default!;
    }

    public void OpenPreviousScreen()
    {
        // call: p542529df.back
        // field: p1e11b989.paad653ca.p2486923a.pf86eb069.f1dd78f9b
    }

    public void SetEditable(bool P0)
    {
        // call: MutableLiveData.setValue
        // call: bool.valueOf
        // field: p1e11b989.paad653ca.p2486923a.pf86eb069.feb80977a
        // field: p1e11b989.paad653ca.p2486923a.pf86eb069.f03ebecb5
    }

    public bool ShowHint()
    {
        // call: pd027b535.isShowNoteReceiptHint
        // field: p1e11b989.paad653ca.p2486923a.pf86eb069.fb3f20355
        return false;
    }

}
