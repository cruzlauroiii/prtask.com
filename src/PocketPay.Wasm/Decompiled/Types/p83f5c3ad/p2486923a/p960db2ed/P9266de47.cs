namespace WillowMaze.Wasm.Decompiled;

public class P9266de47 : ViewModel
{
    private List<object> F030c55df;
    private readonly p93d31ced F0951a129;
    private readonly p93d31ced F221581da;
    private readonly object F39f42742;
    private readonly object F49c1e523;
    private List<object> F55263249;
    private readonly p1ceed351 F62520fad;
    private List<object> F70f9982b;
    private readonly p1ceed351 F755d30cc;
    private List<object> F765c9416;
    private readonly object F7adccf34;
    private readonly p1ceed351 F907c2d4c;
    private readonly p93d31ced F95911f3b;
    private readonly object F9ba231f4;
    private readonly p1ceed351 Fbc7fa196;
    private readonly object Fc785c22d;
    private readonly p93d31ced Fd13d7002;
    private readonly object Fda806bd8;
    private readonly p1ceed351 Fe048a3cb;
    private readonly object Ff9392f95;
    private readonly p93d31ced Fffc8d8d0;

    public void GetAllRegions()
    {
        // call: object.setValue
        // call: p93d31ced.getRegions
        // field: p83f5c3ad.p2486923a.p960db2ed.p9266de47.f95911f3b
        // field: p83f5c3ad.p2486923a.p960db2ed.p9266de47.ff9392f95
        // field: p83f5c3ad.p2486923a.p960db2ed.p9266de47.f030c55df
    }

    public object GetRegionsState()
    {
        // field: p83f5c3ad.p2486923a.p960db2ed.p9266de47.fc785c22d
        return default!;
    }

    public void HandleSelectedRegion(pf447ac85 P0)
    {
        // str: "region"
        // str: "8794800ce8afe7c698652b4309081a164493035eb347c8f828fcbb46fd70eca0a8dc9c3aa70f0946dafc523117"
        // call: DecryptString.decryptString
        // call: p1ceed351.sendResult
        // call: Intrinsics.checkNotNullParameter
        // call: p1ceed351.back
        // field: p83f5c3ad.p2486923a.p960db2ed.p9266de47.f62520fad
    }

    public void OnFilterRegions(string P0)
    {
        // str: "text"
        // call: List<object>.<init>
        // call: object.setValue
        // call: IEnumerable<object>.iterator
        // call: ICollection<object>.add
        // call: StringsKt.contains
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.next
        // call: pf447ac85.getName
        // call: IEnumerator<object>.hasNext
        // field: p83f5c3ad.p2486923a.p960db2ed.p9266de47.f030c55df
        // field: p83f5c3ad.p2486923a.p960db2ed.p9266de47.ff9392f95
        // type: List<object>
    }

    public void OpenPreviousScreen()
    {
        // call: p1ceed351.back
        // field: p83f5c3ad.p2486923a.p960db2ed.p9266de47.f62520fad
    }

}
