namespace WillowMaze.Wasm.Decompiled;

public class Pbc387122 : Pa1802ad3
{
    public string GetCurrentText()
    {
        // str: "null cannot be cast to non-null type domain.entities.boarding.LauncherBoarding"
        // str: "getString(...)"
        // call: List<object>.get
        // call: pbc387122.getCurrentPage
        // call: p88f170e1.getType
        // call: Resources.getString
        // call: Intrinsics.checkNotNull
        // call: pbc387122.getResources
        // call: pbc387122.getBoardingList
        // call: pfbabbcb4.ordinal
        // call: NoWhenBranchMatchedException.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: DecryptString.decryptString
        // field: pf3e08b51.p2486923a.p1bda80f2.pbc387122$p12c674ac.$EnumSwitchMapping$0
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.launcher_boarding_lk_text
        // type: NoWhenBranchMatchedException
        return string.Empty;
    }

    public string GetCurrentTitle()
    {
        // str: "getString(...)"
        // str: "null cannot be cast to non-null type domain.entities.boarding.LauncherBoarding"
        // call: p88f170e1.getType
        // call: Intrinsics.checkNotNull
        // call: Resources.getString
        // call: pbc387122.getBoardingList
        // call: pbc387122.getCurrentPage
        // call: pfbabbcb4.ordinal
        // call: Intrinsics.checkNotNullExpressionValue
        // call: NoWhenBranchMatchedException.<init>
        // call: pbc387122.getResources
        // call: DecryptString.decryptString
        // call: List<object>.get
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.launcher_boarding_lk_title
        // field: pf3e08b51.p2486923a.p1bda80f2.pbc387122$p12c674ac.$EnumSwitchMapping$0
        // type: NoWhenBranchMatchedException
        return string.Empty;
    }

    public void InitBoarding(List<object> P0, p44573bc3 P1)
    {
        // str: "boardingListener"
        // str: "launcherBoardingList"
        // call: pbc387122.updateBoarding
        // call: pbc387122.setBoardingListener
        // call: Intrinsics.checkNotNullParameter
        // call: pbc387122.setBoardingList
    }

}
