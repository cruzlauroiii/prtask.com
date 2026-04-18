namespace WillowMaze.Wasm.Decompiled;

public class P1bfa3bf2 : ViewModel
{
    private readonly pc556a05a F1c85cf2e;
    private readonly pc556a05a F23f558f1;
    private readonly p27fba7dc F68c4283d;
    private readonly p27fba7dc F853627ee;
    private readonly pc556a05a F8c85933c;
    private readonly pc556a05a Fcbf079a8;
    private readonly p27fba7dc Fce200595;
    private readonly p27fba7dc Fd0b31fad;
    private readonly p27fba7dc Feb4d6116;
    private readonly pc556a05a Ff3395cd5;

    public void OpenPreviousScreen()
    {
        // call: pc556a05a.back
        // field: p1e11b989.p9acb4454.p2486923a.pb2c97ae4.p1bfa3bf2.ff3395cd5
    }

    public void ReportOnDateStartClickEvent()
    {
        // call: p27fba7dc.reportFiltersPeriodEvent
        // field: p1e11b989.p9acb4454.p2486923a.pb2c97ae4.p1bfa3bf2.f68c4283d
    }

    public void ReportOnPaymentTypeClickEvent(p8c261c90 P0)
    {
        // str: "paymentType"
        // call: p27fba7dc.reportFiltersTopEvent
        // call: Intrinsics.checkNotNullParameter
        // call: p27fba7dc.reportFiltersCombopayEvent
        // call: p8c261c90.ordinal
        // call: p27fba7dc.reportFiltersCashEvent
        // field: p1e11b989.p9acb4454.p2486923a.pb2c97ae4.p1bfa3bf2$p12c674ac.$EnumSwitchMapping$0
        // field: p1e11b989.p9acb4454.p2486923a.pb2c97ae4.p1bfa3bf2.f68c4283d
    }

    public void ReportOperationTypeClickEvent(p5a409c20 P0)
    {
        // str: "operationType"
        // call: p27fba7dc.reportFiltersSellEvent
        // call: p27fba7dc.reportFiltersPaybackEvent
        // call: p5a409c20.ordinal
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.p9acb4454.p2486923a.pb2c97ae4.p1bfa3bf2$p12c674ac.$EnumSwitchMapping$1
        // field: p1e11b989.p9acb4454.p2486923a.pb2c97ae4.p1bfa3bf2.f68c4283d
    }

    public void UpdateFilter(pc77da2af P0)
    {
        // str: "filter"
        // call: pc556a05a.sendResult
        // call: pc556a05a.getReceiptStatusesFilterKey
        // call: p1bfa3bf2.openPreviousScreen
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.p9acb4454.p2486923a.pb2c97ae4.p1bfa3bf2.ff3395cd5
    }

}
