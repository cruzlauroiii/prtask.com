namespace WillowMaze.Wasm.Decompiled;

public class P884f7d43 : ViewModel
{
    private readonly p646043aa F35cd9df7;
    private readonly pf64c4fd2 F3a88892a;
    private readonly pf64c4fd2 F67cae719;
    private readonly p646043aa F68c4283d;
    private readonly p646043aa F747d8699;
    private readonly p6e2fd5a9 F853b9071;
    private readonly pf64c4fd2 Fb0d5ba5f;
    private readonly p646043aa Fb51bc4c5;
    private readonly pf64c4fd2 Fc9635bea;
    private readonly p646043aa Fcacfdf7d;
    private readonly p6e2fd5a9 Ff3395cd5;

    private void M4d38cf37(pd7778d0c P0)
    {
        // call: string.valueOf
        // call: p646043aa.reportSetFilterEvent
        // call: pd7778d0c.getDateEnd
        // call: pd7778d0c.getType
        // call: pd7778d0c.getDateStart
        // field: pa912a94d.p2486923a.pb2c97ae4.p884f7d43.f68c4283d
    }

    public pd7778d0c GetFilter()
    {
        // call: pf64c4fd2.getFilter
        // field: pa912a94d.p2486923a.pb2c97ae4.p884f7d43.fc9635bea
        return default!;
    }

    public void OpenPreviousScreen()
    {
        // call: p6e2fd5a9.back
        // field: pa912a94d.p2486923a.pb2c97ae4.p884f7d43.ff3395cd5
    }

    public void ReportOnExitCLickEvent()
    {
        // call: p646043aa.reportPeriodExitEvent
        // field: pa912a94d.p2486923a.pb2c97ae4.p884f7d43.f68c4283d
    }

    public void ResetFilter()
    {
        // call: pf64c4fd2.resetFilter
        // call: p646043aa.reportPeriodSkipEvent
        // field: pa912a94d.p2486923a.pb2c97ae4.p884f7d43.fc9635bea
        // field: pa912a94d.p2486923a.pb2c97ae4.p884f7d43.f68c4283d
    }

    public void UpdateFilter(pd7778d0c P0)
    {
        // str: "filter"
        // call: p646043aa.reportPeriodApplyEvent
        // call: pf64c4fd2.updateFilter
        // call: pd7778d0c.getDateStart
        // call: pd7778d0c.getDateEnd
        // call: p884f7d43.openPreviousScreen
        // call: p884f7d43.resetFilter
        // call: p884f7d43.m4d38cf37
        // call: Intrinsics.checkNotNullParameter
        // field: pa912a94d.p2486923a.pb2c97ae4.p884f7d43.f68c4283d
        // field: pa912a94d.p2486923a.pb2c97ae4.p884f7d43.fc9635bea
    }

}
