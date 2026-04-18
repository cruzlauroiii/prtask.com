namespace WillowMaze.Wasm.Decompiled;

public abstract class Peaeb30f9
{
    private p6d96efb7 F104e5b30;
    private p6d96efb7 F2610bb41;
    private long F32e339f9;
    private long F34ce64b5;
    private long F466dff0b;
    private readonly string F6e6c4fe8;
    private long F6f714f95;
    private readonly bool F7609a998;
    private p6d96efb7 F7f730f0d;
    private readonly bool F903085fa;
    private readonly bool F969cae63;
    private p6d96efb7 Fa78140c2;
    private p6d96efb7 Fa9d1cbf7;
    private readonly string Fb068931c;
    private readonly bool Fefc3db7e;

    public bool GetCancelable()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9.fefc3db7e
        return false;
    }

    public string GetName()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9.fb068931c
        return string.Empty;
    }

    public long GetNextExecuteNanoTime$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9.f32e339f9
        return 0;
    }

    public p6d96efb7 GetQueue$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9.fa9d1cbf7
        return default!;
    }

    public void InitQueue$okhttp(p6d96efb7 P0)
    {
        // str: "task is in multiple queues"
        // str: "queue"
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: IllegalStateException.<init>
        // field: p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9.fa9d1cbf7
        // type: IllegalStateException
    }

    public long RunOnce()
    {
        return 0;
    }

    public void SetNextExecuteNanoTime$okhttp(long P0)
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9.f32e339f9
    }

    public void SetQueue$okhttp(p6d96efb7 P0)
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9.fa9d1cbf7
    }

    public string ToString()
    {
        // field: p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9.fb068931c
        return string.Empty;
    }

}
