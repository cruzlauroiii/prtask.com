namespace WillowMaze.Wasm.Decompiled;

public class P4ffa3924 : P0742d3f9
{
    private readonly Lazy<object> TophLogoutViewModel$delegate;

    public static void M1340cd16(p4ffa3924 P0, pa4ecfc70 P1)
    {
        // call: p4ffa3924.m7ae42676
    }

    private void M1a829e67()
    {
        // call: p8c01482f.getResetActivationState
        // call: pfafca1ef.m0788a692
        // call: p4ffa3924.m80226795
        // call: p4ffa3924$pd41d8cd9$p95263d50.<init>
        // type: p4ffa3924$pd41d8cd9$p95263d50
    }

    private void M269b36ee(Exception P0)
    {
        // str: "requireContext(...)"
        // call: p4ffa3924.requireContext
        // call: p14804b31.md9ae7f57
        // call: p1f54b646.<init>
        // call: pa2559025.m31049b74
        // call: Intrinsics.checkNotNullExpressionValue
        // type: p1f54b646
    }

    private static void M7ae42676(p4ffa3924 P0, pa4ecfc70 P1)
    {
        // call: pa4ecfc70.getStatus
        // call: pec53a8c4.ordinal
        // call: pa4ecfc70.getThrowable
        // call: p4ffa3924.m269b36ee
        // field: kotlin.Unit.INSTANCE
        // field: p83f5c3ad.p2486923a.p4236a440.p4ffa3924$p12c674ac.$EnumSwitchMapping$0
    }

    private p8c01482f M80226795()
    {
        // call: Lazy<object>.getValue
        // field: p83f5c3ad.p2486923a.p4236a440.p4ffa3924.tophLogoutViewModel$delegate
        return default!;
    }

    public void OnViewCreated(object P0, Dictionary<string, object> P1)
    {
        // str: "view"
        // call: p0742d3f9.onViewCreated
        // call: Intrinsics.checkNotNullParameter
        // call: p4ffa3924.m1a829e67
    }

}
