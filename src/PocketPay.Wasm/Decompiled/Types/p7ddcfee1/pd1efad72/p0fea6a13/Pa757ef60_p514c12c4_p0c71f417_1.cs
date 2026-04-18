namespace WillowMaze.Wasm.Decompiled;

public class Pa757ef60_p514c12c4_p0c71f417_1 : Pf31bbdd1
{
    private readonly p08d84bc6 $cacheBody;
    private readonly p1df8d4a4 $cacheRequest;
    private readonly pcc81e3f6 $source;
    private bool F37a454eb;
    private bool Fc9e2d349;

    public void Close()
    {
        // call: pcc81e3f6.close
        // call: p23e8a4b4.discard
        // call: p1df8d4a4.abort
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1.f37a454eb
        // field: java.util.concurrent.TimeUnit.MILLISECONDS
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1.$source
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1.$cacheRequest
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "sink"
        // call: p7e62bc34.copyTo
        // call: p08d84bc6.getBuffer
        // call: p1df8d4a4.abort
        // call: Intrinsics.checkNotNullParameter
        // call: pcc81e3f6.read
        // call: p08d84bc6.close
        // call: p08d84bc6.emitCompleteSegments
        // call: p7e62bc34.size
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1.f37a454eb
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1.$cacheRequest
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1.$cacheBody
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1.$source
        return 0;
    }

    public pc85a251c Timeout()
    {
        // call: pcc81e3f6.timeout
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p514c12c4$p0c71f417$1.$source
        return default!;
    }

}
