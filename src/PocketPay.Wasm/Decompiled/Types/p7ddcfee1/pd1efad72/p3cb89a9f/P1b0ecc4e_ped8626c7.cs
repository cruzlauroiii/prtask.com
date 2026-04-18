namespace WillowMaze.Wasm.Decompiled;

public class P1b0ecc4e_ped8626c7 : Pf31bbdd1
{
    private int F0261c4a3;
    private int F0355aecc;
    private int F0b1f7074;
    private int F2cb8abd2;
    private int F2f0bd86c;
    private int F2fa47f7c;
    private readonly pcc81e3f6 F36cd38f4;
    private readonly pcc81e3f6 F382445d7;
    private int F3d2afde8;
    private int F435de071;
    private int F44590c3b;
    private int F4e5868d6;
    private int F80463261;
    private int F811882fe;
    private int F95025aae;
    private int Fb70cdb87;
    private int Fb85a778f;
    private readonly pcc81e3f6 Fb8a6eddf;
    private readonly pcc81e3f6 Fc6b0e8c1;
    private int Fc75cb34f;

    private void ReadContinuationHeader()
    {
        // str: "TYPE_CONTINUATION streamId changed"
        // str: " != TYPE_CONTINUATION"
        // call: IOException.<init>
        // call: StringBuilder.toString
        // call: Logger.isLoggable
        // call: p1b0ecc4e$p910eef8c.getLogger
        // call: StringBuilder.<init>
        // call: pb354a53a.frameLog
        // call: pcc81e3f6.readByte
        // call: p23e8a4b4.and
        // call: p23e8a4b4.readMedium
        // call: StringBuilder.append
        // call: pcc81e3f6.readInt
        // call: Logger.fine
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.f76425f17
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f910eef8c
        // field: java.util.logging.Level.FINE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f4e5868d6
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f44590c3b
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f2fa47f7c
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f811882fe
        // type: StringBuilder
        // type: IOException
    }

    public void Close()
    {
    }

    public int GetFlags()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f4e5868d6
        return 0;
    }

    public int GetLeft()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f811882fe
        return 0;
    }

    public int GetLength()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f2fa47f7c
        return 0;
    }

    public int GetPadding()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.fb70cdb87
        return 0;
    }

    public int GetStreamId()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f44590c3b
        return 0;
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "sink"
        // call: Math.min
        // call: Intrinsics.checkNotNullParameter
        // call: pcc81e3f6.skip
        // call: p1b0ecc4e$ped8626c7.readContinuationHeader
        // call: pcc81e3f6.read
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f4e5868d6
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.fb70cdb87
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f811882fe
        return 0;
    }

    public void SetFlags(int P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f4e5868d6
    }

    public void SetLeft(int P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f811882fe
    }

    public void SetLength(int P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f2fa47f7c
    }

    public void SetPadding(int P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.fb70cdb87
    }

    public void SetStreamId(int P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f44590c3b
    }

    public pc85a251c Timeout()
    {
        // call: pcc81e3f6.timeout
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$ped8626c7.f36cd38f4
        return default!;
    }

}
