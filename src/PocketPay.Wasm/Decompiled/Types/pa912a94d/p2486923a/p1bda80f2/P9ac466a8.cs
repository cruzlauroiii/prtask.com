namespace WillowMaze.Wasm.Decompiled;

public class P9ac466a8 : Pa1802ad3
{
    public string GetCurrentText()
    {
        // str: "getString(...)"
        // str: "null cannot be cast to non-null type domain.entities.boarding.StatisticBoarding"
        // call: p9ac466a8.getResources
        // call: p9ac466a8.getCurrentPage
        // call: Intrinsics.checkNotNullExpressionValue
        // call: NoWhenBranchMatchedException.<init>
        // call: p9ac466a8.getBoardingList
        // call: Resources.getString
        // call: DecryptString.decryptString
        // call: pd7154549.getType
        // call: Intrinsics.checkNotNull
        // call: List<object>.get
        // call: pffae59b2.ordinal
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$string.statistics_boarding_not_fiscal_subtitle
        // field: pa912a94d.p2486923a.p1bda80f2.p9ac466a8$p12c674ac.$EnumSwitchMapping$0
        // type: NoWhenBranchMatchedException
        return string.Empty;
    }

    public string GetCurrentTitle()
    {
        // str: "getString(...)"
        // str: "null cannot be cast to non-null type domain.entities.boarding.StatisticBoarding"
        // call: DecryptString.decryptString
        // call: Resources.getString
        // call: List<object>.get
        // call: p9ac466a8.getBoardingList
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pd7154549.getType
        // call: p9ac466a8.getResources
        // call: NoWhenBranchMatchedException.<init>
        // call: pffae59b2.ordinal
        // call: Intrinsics.checkNotNull
        // call: p9ac466a8.getCurrentPage
        // field: pa912a94d.p2486923a.p1bda80f2.p9ac466a8$p12c674ac.$EnumSwitchMapping$0
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$string.statistics_boarding_not_fiscal_title
        // type: NoWhenBranchMatchedException
        return string.Empty;
    }

    public void InitBoarding(List<object> P0, p44573bc3 P1)
    {
        // str: "boardingListener"
        // str: "launcherBoardingList"
        // call: p9ac466a8.updateBoarding
        // call: p9ac466a8.setBoardingListener
        // call: Intrinsics.checkNotNullParameter
        // call: p9ac466a8.setBoardingList
    }

}
