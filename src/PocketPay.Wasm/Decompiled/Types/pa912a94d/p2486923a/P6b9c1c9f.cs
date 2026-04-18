namespace WillowMaze.Wasm.Decompiled;

public class P6b9c1c9f : ViewModel
{
    private readonly p0fc7c052 F11e84844;
    private readonly pc556a05a F2591b4bc;
    private readonly p646043aa F285f078b;
    private readonly pf64c4fd2 F2be46997;
    private readonly p646043aa F35009488;
    private readonly p646043aa F523ab0e4;
    private readonly p646043aa F68c4283d;
    private readonly pc556a05a F8662a5f8;
    private readonly p6e2fd5a9 F983b1778;
    private readonly MutableLiveData F98e4df53;
    private readonly p646043aa Fb1aea4e2;
    private readonly p6e2fd5a9 Fb35f2dac;
    private readonly pf64c4fd2 Fc9635bea;
    private readonly p3f4efdf7 Fda90a71c;
    private readonly p3f4efdf7 Fe0cc09ed;
    private readonly p0fc7c052 Fe4af3042;
    private readonly pc556a05a Ff029f84a;
    private readonly p3f4efdf7 Ff032a270;
    private readonly p6e2fd5a9 Ff3395cd5;
    private readonly p3f4efdf7 Ffb885243;
    private readonly MutableLiveData Ffc2c7a56;

    private void M1df13c6e()
    {
        // call: pf64c4fd2.resetFilter
        // field: pa912a94d.p2486923a.p6b9c1c9f.fc9635bea
    }

    private void M4d38cf37(pd7778d0c P0)
    {
        // call: pd7778d0c.getDateEnd
        // call: pd7778d0c.getDateStart
        // call: p646043aa.reportSetFilterEvent
        // call: pd7778d0c.getType
        // call: string.valueOf
        // field: pa912a94d.p2486923a.p6b9c1c9f.f68c4283d
    }

    public static pf64c4fd2 M9dce1ee0(p6b9c1c9f P0)
    {
        // field: pa912a94d.p2486923a.p6b9c1c9f.fc9635bea
        return default!;
    }

    public static p3f4efdf7 Maa7198cc(p6b9c1c9f P0)
    {
        // field: pa912a94d.p2486923a.p6b9c1c9f.ffb885243
        return default!;
    }

    public static MutableLiveData Md00c9606(p6b9c1c9f P0)
    {
        // field: pa912a94d.p2486923a.p6b9c1c9f.f98e4df53
        return default!;
    }

    public bool AvailableStatisticsFilter()
    {
        // call: pf64c4fd2.getFilter
        // call: pd7778d0c.getType
        // field: pa912a94d.p2486923a.p6b9c1c9f.fc9635bea
        return false;
    }

    public pd7778d0c GetFilter()
    {
        // call: pf64c4fd2.getFilter
        // field: pa912a94d.p2486923a.p6b9c1c9f.fc9635bea
        return default!;
    }

    public List<object> GetFilterDurationTypes()
    {
        // call: CollectionsKt.mutableListOf
        // field: pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pa859c1d6.f87109620
        // field: pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pa859c1d6.f02854858
        // field: pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pa859c1d6.f03219b11
        return default!;
    }

    public LiveData GetStatisticsInfoLiveData()
    {
        // field: pa912a94d.p2486923a.p6b9c1c9f.f98e4df53
        return default!;
    }

    public bool IsNotFiscalReceiptsInfoReadFirstTime()
    {
        // call: p54060cd2.isNotFiscalReceiptsInfoReadFirstTime
        // call: p0fc7c052.getStatisticBoardingSettings
        // field: pa912a94d.p2486923a.p6b9c1c9f.fe4af3042
        return false;
    }

    public void LoadStatisticsInfo()
    {
        // call: BuildersKt.launch$default
        // call: p6b9c1c9f$p674f82b2$1.<init>
        // call: ViewModelKt.getViewModelScope
        // type: p6b9c1c9f$p674f82b2$1
    }

    public void OpenFilterScreen()
    {
        // call: p6e2fd5a9.openFilter
        // call: p646043aa.reportPeriodEvent
        // field: pa912a94d.p2486923a.p6b9c1c9f.ff3395cd5
        // field: pa912a94d.p2486923a.p6b9c1c9f.f68c4283d
    }

    public void OpenPreviousScreen()
    {
        // call: p6e2fd5a9.back
        // field: pa912a94d.p2486923a.p6b9c1c9f.ff3395cd5
    }

    public void OpenReceiptStatusesScreen()
    {
        // call: pc556a05a.openReceiptStatuses
        // field: pa912a94d.p2486923a.p6b9c1c9f.ff029f84a
    }

    public void ReadNotFiscalReceiptsInfo()
    {
        // call: p0fc7c052.notFiscalReceiptsRead
        // field: pa912a94d.p2486923a.p6b9c1c9f.fe4af3042
    }

    public void ReportToReceiptClickEvent()
    {
        // call: p646043aa.reportToCheckEvent
        // field: pa912a94d.p2486923a.p6b9c1c9f.f68c4283d
    }

    public void UpdateFilter(pd7778d0c P0)
    {
        // str: "filter"
        // call: p646043aa.report7DayEvent
        // call: pa859c1d6.ordinal
        // call: pd7778d0c.getDateStart
        // call: p6b9c1c9f.m4d38cf37
        // call: pd7778d0c.getDateEnd
        // call: p6b9c1c9f.m1df13c6e
        // call: p646043aa.reportTodayEvent
        // call: pf64c4fd2.updateFilter
        // call: pd7778d0c.getType
        // call: p646043aa.reportYesterdayEvent
        // call: Intrinsics.checkNotNullParameter
        // field: pa912a94d.p2486923a.p6b9c1c9f.f68c4283d
        // field: pa912a94d.p2486923a.p6b9c1c9f$p12c674ac.$EnumSwitchMapping$0
        // field: pa912a94d.p2486923a.p6b9c1c9f.fc9635bea
    }

}
