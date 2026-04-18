namespace WillowMaze.Wasm.Decompiled;

public class Pe5b7e9b6 : ViewModel
{
    private readonly pa36ef9b5 F0d3e163c;
    private readonly MutableLiveData F0f320b64;
    private readonly pa36ef9b5 F11621f4d;
    private readonly MutableLiveData F13d7b436;
    private readonly IAsyncEnumerable<object> F220d2235;
    private readonly MutableLiveData F25e5b5fc;
    private readonly p1b3a5bf0 F289ab51d;
    private readonly p1b3a5bf0 F2b2a1791;
    private readonly MutableLiveData F3fb33096;
    private readonly p1b3a5bf0 F416b9c52;
    private readonly IAsyncEnumerable<object> F4d0c0ce0;
    private readonly IAsyncEnumerable<object> F4e4d280a;
    private readonly p2f3c4196 F57ca0a7e;
    private readonly MutableLiveData F6344b0b1;
    private readonly MutableLiveData F6be04844;
    private readonly MutableLiveData F71853342;
    private readonly pa36ef9b5 F85cfc9fc;
    private readonly p7b0f778f F8dbbd723;
    private readonly p7b0f778f F94ca6fcb;
    private readonly MutableLiveData F9799a746;
    private readonly MutableLiveData Fa53c98d4;
    private readonly IAsyncEnumerable<object> Fa823887f;
    private readonly MutableLiveData Fad54619a;
    private readonly MutableLiveData Fb2d823c7;
    private readonly MutableLiveData Fc5dd1700;
    private readonly pa36ef9b5 Fcf305553;
    private readonly MutableLiveData Fd6344e68;
    private readonly MutableLiveData Fd8454346;
    private readonly MutableLiveData Fe05497cd;
    private readonly p2f3c4196 Fe639d08f;
    private readonly p7b0f778f Feeff33c5;
    private readonly MutableLiveData Ff33be5ff;
    private readonly MutableLiveData Ffb966114;
    private readonly IAsyncEnumerable<object> Ffec15c5e;

    private object M1a3befb2(ped663a3e P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: pe5b7e9b6$p1a3befb2$1.<init>
        // call: pa36ef9b5.getPaybackReceiptsBySellReceiptUuid
        // call: IllegalStateException.<init>
        // call: ResultKt.throwOnFailure
        // call: ped663a3e.getUuid
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: ped663a3e.m1c1e012b
        // call: pa36ef9b5.getPositionsForPaybackFromDb
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p1a3befb2$1.L$1
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p1a3befb2$1.fd304ba20
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p1a3befb2$1.L$0
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f0d3e163c
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p1a3befb2$1.fb4a88417
        // type: pe5b7e9b6$p1a3befb2$1
        // type: IllegalStateException
        return default!;
    }

    public static object M9667c227(pe5b7e9b6 P0, ped663a3e P1, object P2)
    {
        // call: pe5b7e9b6.m1a3befb2
        return default!;
    }

    public static MutableLiveData Ma0eee7db(pe5b7e9b6 P0)
    {
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.fd8454346
        return default!;
    }

    public static MutableLiveData Mca5e66c2(pe5b7e9b6 P0)
    {
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.fc5dd1700
        return default!;
    }

    public static pa36ef9b5 Md95a43c7(pe5b7e9b6 P0)
    {
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f0d3e163c
        return default!;
    }

    public static MutableLiveData Mff8ebad6(pe5b7e9b6 P0)
    {
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f3fb33096
        return default!;
    }

    public void CreatePaybackReceipt(ped663a3e P0)
    {
        // str: "receipt"
        // call: ViewModelKt.getViewModelScope
        // call: Intrinsics.checkNotNullParameter
        // call: pe5b7e9b6$p63023f38$1.<init>
        // call: BuildersKt.launch$default
        // type: pe5b7e9b6$p63023f38$1
    }

    public void CreatePaybackWithoutReceipt()
    {
        // call: pe5b7e9b6$p8e5747bd$1.<init>
        // call: ViewModelKt.getViewModelScope
        // call: BuildersKt.launch$default
        // type: pe5b7e9b6$p8e5747bd$1
    }

    public LiveData GetCreatePaybackReceiptStatus()
    {
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f3fb33096
        return default!;
    }

    public LiveData GetCreatePaybackWithoutReceiptStatus()
    {
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.fd8454346
        return default!;
    }

    public IAsyncEnumerable<object> GetPagedSellReceiptsFlow()
    {
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f220d2235
        return default!;
    }

    public LiveData GetReceiptOnClickLiveData()
    {
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.fc5dd1700
        return default!;
    }

    public bool IsTophRepeatedCancelInCurrentBatch(ped663a3e P0)
    {
        // str: "sellReceipt"
        // call: ICollection<object>.isEmpty
        // call: long.valueOf
        // call: ped663a3e.getPaybackReceipts
        // call: ped663a3e.getCreationDate
        // call: DateTime.getTime
        // call: p7b0f778f.isBatchClosed
        // call: ped663a3e.getPaymentType
        // call: Intrinsics.checkNotNullParameter
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f94ca6fcb
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9e1ca306
        return false;
    }

    public LiveData ObserveToolbarMenuVisibleStatus()
    {
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f0f320b64
        return default!;
    }

    public void OpenPaybackWithoutReceipt()
    {
        // call: p1b3a5bf0.openPaybackPositions
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f2b2a1791
    }

    public void OpenPreviousScreen()
    {
        // call: p1b3a5bf0.back
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f2b2a1791
    }

    public void OpenReceiptScreen()
    {
        // call: p1b3a5bf0.newChainWithReceipt
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f2b2a1791
    }

    public void Reload()
    {
        // call: MutableLiveData.setValue
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.fd6344e68
        // field: kotlin.Unit.INSTANCE
    }

    public void SellReceiptClickHandler(ped663a3e P0)
    {
        // str: "sellReceipt"
        // call: BuildersKt.launch$default
        // call: ViewModelKt.getViewModelScope
        // call: Intrinsics.checkNotNullParameter
        // call: pe5b7e9b6$p00505d71$1.<init>
        // type: pe5b7e9b6$p00505d71$1
    }

    public void ShowToolbarMenu()
    {
        // call: MutableLiveData.setValue
        // call: bool.valueOf
        // field: p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.f0f320b64
    }

}
