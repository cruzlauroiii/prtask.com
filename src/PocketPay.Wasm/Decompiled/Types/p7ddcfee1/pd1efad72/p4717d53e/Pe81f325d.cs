namespace WillowMaze.Wasm.Decompiled;

public class Pe81f325d
{
    private readonly HashSet<object> F3ff84dcd;
    private readonly HashSet<object> F4985ef12;
    private readonly HashSet<object> Fca950794;
    private readonly HashSet<object> Fe60c60be;

    public void Connected(p9405c3af P0)
    {
        // str: "route"
        // call: Intrinsics.checkNotNullParameter
        // call: HashSet<object>.remove
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe81f325d.f4985ef12
    }

    public void Failed(p9405c3af P0)
    {
        // str: "failedRoute"
        // call: Intrinsics.checkNotNullParameter
        // call: HashSet<object>.add
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe81f325d.f4985ef12
    }

    public bool ShouldPostpone(p9405c3af P0)
    {
        // str: "route"
        // call: Intrinsics.checkNotNullParameter
        // call: HashSet<object>.contains
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe81f325d.f4985ef12
        return false;
    }

}
