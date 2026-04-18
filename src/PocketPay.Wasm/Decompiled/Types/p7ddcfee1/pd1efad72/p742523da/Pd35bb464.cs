namespace WillowMaze.Wasm.Decompiled;

public class Pd35bb464 : IDisposable
{
    private readonly Random F000143c3;
    private readonly p7e62bc34 F05a99951;
    private readonly bool F17329b5d;
    private bool F1bcf3dd7;
    private readonly bool F1f10c6f7;
    private readonly p7e62bc34 F212edb02;
    private readonly p7e62bc34 F28806b7a;
    private readonly bool F2e1c6e16;
    private readonly p7e62bc34 F3851f5cb;
    private readonly bool F3fd8d77d;
    private readonly Random F450c318c;
    private readonly bool F4e771c55;
    private readonly p7e62bc34 F527823e8;
    private readonly bool F52943984;
    private readonly bool F56048339;
    private readonly Random F5b7b2fac;
    private readonly p7e62bc34 F699c5db9;
    private readonly p7e62bc34$p43882412 F6f82ab73;
    private readonly p7e62bc34 F7541daf3;
    private readonly Random F7ddf32e1;
    private readonly bool F7e5345df;
    private readonly bool F9876e266;
    private bool F9ac759da;
    private readonly p7e62bc34$p43882412 F9c6286af;
    private pd8ff812a F9c7ce8dd;
    private readonly byte[] F9cd8211f;
    private readonly long Fa2bce941;
    private readonly p08d84bc6 Fa4e5e9d3;
    private readonly bool Fa7c104ce;
    private readonly bool Fbf391796;
    private readonly bool Fc5eac042;
    private readonly p7e62bc34 Fcb0ff2f1;
    private readonly bool Fce66cdd1;
    private pd8ff812a Fd3c49926;
    private readonly byte[] Fd68cce5e;
    private readonly byte[] Fd7bae999;
    private bool Fd9beb3df;
    private readonly p7e62bc34 Fe26ed4d2;
    private readonly p7e62bc34 Fe9bdd069;
    private readonly byte[] Ff45b3b5c;
    private readonly long Ff5e39946;
    private readonly p08d84bc6 Ff6e04117;

    private void WriteControlFrame(int P0, p58efa9e8 P1)
    {
        // str: "Payload size must be less than or equal to 125"
        // str: "closed"
        // call: IOException.<init>
        // call: p7e62bc34.writeByte
        // call: p58efa9e8.size
        // call: Intrinsics.checkNotNull
        // call: p08d84bc6.flush
        // call: p7e62bc34.write
        // call: pd775ff95.toggleMask
        // call: p7e62bc34.readAndWriteUnsafe
        // call: p7e62bc34.size
        // call: IllegalArgumentException.<init>
        // call: Random.nextBytes
        // call: p7e62bc34$p43882412.seek
        // call: p7e62bc34$p43882412.close
        // call: object.toString
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f28806b7a
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f9c6286af
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f1bcf3dd7
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f9876e266
        // field: p7ddcfee1.pd1efad72.p742523da.pd775ff95.f76425f17
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.ff45b3b5c
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f7ddf32e1
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.ff6e04117
        // type: IOException
        // type: IllegalArgumentException
    }

    public void Close()
    {
        // call: pd8ff812a.close
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.fd3c49926
    }

    public Random GetRandom()
    {
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f7ddf32e1
        return default!;
    }

    public p08d84bc6 GetSink()
    {
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.ff6e04117
        return default!;
    }

    public void WriteClose(int P0, p58efa9e8 P1)
    {
        // call: p7e62bc34.writeShort
        // call: pd775ff95.validateCloseCode
        // call: p7e62bc34.write
        // call: p7e62bc34.<init>
        // call: pd35bb464.writeControlFrame
        // call: p7e62bc34.readByteString
        // field: p38cb8f46.p58efa9e8.fba2b45bd
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f1bcf3dd7
        // field: p7ddcfee1.pd1efad72.p742523da.pd775ff95.f76425f17
        // type: p7e62bc34
    }

    public void WriteMessageFrame(int P0, p58efa9e8 P1)
    {
        // str: "data"
        // str: "closed"
        // call: p7e62bc34$p43882412.close
        // call: pd775ff95.toggleMask
        // call: Intrinsics.checkNotNullParameter
        // call: pd8ff812a.deflate
        // call: p58efa9e8.size
        // call: p7e62bc34.writeByte
        // call: p7e62bc34.write
        // call: Intrinsics.checkNotNull
        // call: p7e62bc34.writeShort
        // call: p7e62bc34.readAndWriteUnsafe
        // call: IOException.<init>
        // call: p7e62bc34.size
        // call: Random.nextBytes
        // call: p08d84bc6.emit
        // call: p7e62bc34$p43882412.seek
        // call: p7e62bc34.writeLong
        // call: pd8ff812a.<init>
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.fbf391796
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.ff45b3b5c
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.fd3c49926
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f28806b7a
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f9c6286af
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f3fd8d77d
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.ff6e04117
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f05a99951
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f9876e266
        // field: p7ddcfee1.pd1efad72.p742523da.pd775ff95.f76425f17
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.fa2bce941
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f1bcf3dd7
        // field: p7ddcfee1.pd1efad72.p742523da.pd35bb464.f7ddf32e1
        // type: pd8ff812a
        // type: IOException
    }

    public void WritePing(p58efa9e8 P0)
    {
        // str: "payload"
        // call: pd35bb464.writeControlFrame
        // call: Intrinsics.checkNotNullParameter
    }

    public void WritePong(p58efa9e8 P0)
    {
        // str: "payload"
        // call: Intrinsics.checkNotNullParameter
        // call: pd35bb464.writeControlFrame
    }

}
