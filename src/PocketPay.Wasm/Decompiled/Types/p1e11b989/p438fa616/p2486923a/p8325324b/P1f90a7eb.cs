namespace WillowMaze.Wasm.Decompiled;

public class P1f90a7eb : ViewModel
{
    private readonly MutableLiveData F004fdf67;
    private readonly p1c60e543 F0baed6eb;
    private readonly MutableLiveData F0fa2b2fa;
    private readonly p5fa140e9 F110a56ea;
    private readonly padac6c63 F1b4053bd;
    private readonly pf21d5ed1 F31757958;
    private readonly p4b8940c0 F4187c98f;
    private readonly MutableLiveData F46996c9b;
    private readonly pf21d5ed1 F474d840d;
    private readonly p1c60e543 F559a1136;
    private readonly MutableLiveData F5ce151ad;
    private readonly padac6c63 F62276d0e;
    private readonly p0bfd7fb7 F656c88ab;
    private readonly p5fa140e9 F6687f74a;
    private readonly p1c60e543 F68c4283d;
    private readonly MutableLiveData F73199d38;
    private readonly pf21d5ed1 F84670996;
    private readonly MutableLiveData F9044bc45;
    private readonly p5fa140e9 F9817bc27;
    private readonly p0bfd7fb7 Fa141688f;
    private readonly MutableLiveData Fa4cb92fe;
    private readonly p4b8940c0 Fda1713fa;

    public static void M160cb365(p1f90a7eb P0)
    {
        // call: p1f90a7eb.mc398eb5c
    }

    public static p0bfd7fb7 M260c792f(p1f90a7eb P0)
    {
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f656c88ab
        return default!;
    }

    public static MutableLiveData M57354353(p1f90a7eb P0)
    {
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f73199d38
        return default!;
    }

    public static p4b8940c0 M701d8e58(p1f90a7eb P0)
    {
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.fda1713fa
        return default!;
    }

    private void M807ee7c0(ped663a3e P0)
    {
        // call: ViewModelKt.getViewModelScope
        // call: BuildersKt.launch$default
        // call: p1f90a7eb$p807ee7c0$1.<init>
        // type: p1f90a7eb$p807ee7c0$1
    }

    public static MutableLiveData M8a0a68c2(p1f90a7eb P0)
    {
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f9044bc45
        return default!;
    }

    private void Mb4448ec9()
    {
        // call: padac6c63.replaceSellElectronPayment
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f1b4053bd
    }

    public static pf21d5ed1 Mbb30f96e(p1f90a7eb P0)
    {
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f474d840d
        return default!;
    }

    private void Mc398eb5c()
    {
        // call: p5fa140e9.replaceSendSellReceiptError
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f9817bc27
    }

    public static void Mc6e55e0c(p1f90a7eb P0, ped663a3e P1)
    {
        // call: p1f90a7eb.me6b38a38
    }

    private void Me6b38a38(ped663a3e P0)
    {
        // call: p5fa140e9.replaceSellReceiptSuccessfullySent
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f9817bc27
    }

    public void GetSellReceipt(decimal P0)
    {
        // call: p1f90a7eb$p307e0fb7$1.<init>
        // call: BuildersKt.launch$default
        // call: ViewModelKt.getViewModelScope
        // type: p1f90a7eb$p307e0fb7$1
    }

    public LiveData ObserveIntermediateSellReceipt()
    {
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f9044bc45
        return default!;
    }

    public LiveData ObserveSendReceipt()
    {
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f73199d38
        return default!;
    }

    public void OpenNextScreen()
    {
        // call: p1c60e543.reportSaleFinallyToPayEvent
        // call: MutableLiveData.getValue
        // call: ped663a3e.getPaymentType
        // call: p1f90a7eb.m807ee7c0
        // call: p8c261c90.ordinal
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f9044bc45
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f68c4283d
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p12c674ac.$EnumSwitchMapping$0
    }

    public void OpenPreviousScreen()
    {
        // call: p5fa140e9.back
        // call: p1c60e543.reportSaleFinallyToPayCancelEvent
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f68c4283d
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f9817bc27
    }

    public void OpenReceiptSentScreen(ped663a3e P0)
    {
        // str: "receipt"
        // call: p5fa140e9.openSellReceiptSuccessfullySent
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.f9817bc27
    }

    public void SaveQueueReceiptToDb()
    {
        // call: BuildersKt.launch$default
        // call: p1f90a7eb$p812699ae$1.<init>
        // call: ViewModelKt.getViewModelScope
        // type: p1f90a7eb$p812699ae$1
    }

}
