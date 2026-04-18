namespace WillowMaze.Wasm.Decompiled;

public class Pab0cf104_p45a82579_1 : IEnumerator<object>, KMutableIterator
{
    private string F44b5fca0;
    private readonly IEnumerator<object> F4fb2774b;
    private string F68a292d2;
    private string F6964adb5;
    private bool F7385e778;
    private readonly IEnumerator<object> F7f662005;
    private bool F81e81a28;
    private string Fb6e5451e;
    private bool Fb9bb53e9;
    private readonly pab0cf104 This$0;

    public bool HasNext()
    {
        // call: CloseableKt.closeFinally
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: pa7af2095$pd4e2713d.getSource
        // call: p0af9afa4.m7f2db423
        // call: pcc81e3f6.readUtf8LineStrict
        // field: p7ddcfee1.pab0cf104$p45a82579$1.f7f662005
        // field: p7ddcfee1.pab0cf104$p45a82579$1.f44b5fca0
        // field: p7ddcfee1.pab0cf104$p45a82579$1.f7385e778
        return false;
    }

    public object Next()
    {
        // call: pab0cf104$p45a82579$1.next
        return default!;
    }

    public string Next()
    {
        // call: NoSuchElementException.<init>
        // call: pab0cf104$p45a82579$1.hasNext
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pab0cf104$p45a82579$1.f44b5fca0
        // field: p7ddcfee1.pab0cf104$p45a82579$1.f7385e778
        // type: NoSuchElementException
        return string.Empty;
    }

    public void Remove()
    {
        // str: "remove() before next()"
        // call: IEnumerator<object>.remove
        // call: object.toString
        // call: IllegalStateException.<init>
        // field: p7ddcfee1.pab0cf104$p45a82579$1.f7385e778
        // field: p7ddcfee1.pab0cf104$p45a82579$1.f7f662005
        // type: IllegalStateException
    }

}
