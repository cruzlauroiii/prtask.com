namespace WillowMaze.Wasm.Decompiled;

public class P3d6bb966 : IDisposable
{
    private readonly bool F02f10a83;
    private readonly bool F09e047bc;
    private bool F0f84bb1e;
    private readonly p7e62bc34 F184ad3ff;
    private bool F1b970d23;
    private readonly bool F1c6a81d6;
    private readonly p3d6bb966$pa3496286 F25b972a4;
    private readonly byte[] F26ba5b2d;
    private readonly p7e62bc34$p43882412 F2f0daf5a;
    private long F2f33d6c2;
    private p5d87a5f5 F310b7e67;
    private readonly bool F33a9907b;
    private readonly p7e62bc34 F3440c731;
    private bool F349e6863;
    private readonly pcc81e3f6 F36cd38f4;
    private readonly bool F3942de1b;
    private readonly bool F3fd8d77d;
    private bool F455b1843;
    private bool F51fdb159;
    private long F56ee629b;
    private readonly bool F5f0dd2b3;
    private bool F5f966c73;
    private readonly p3d6bb966$pa3496286 F60c5e459;
    private bool F668dc451;
    private int F674017e6;
    private readonly p3d6bb966$pa3496286 F6bdc7db0;
    private bool F6e3a50ed;
    private bool F73bc9d34;
    private bool F74c0b86a;
    private p5d87a5f5 F7b6646c9;
    private bool F8511e30e;
    private int F882c467d;
    private readonly p7e62bc34 F900513b2;
    private readonly bool F9876e266;
    private readonly p7e62bc34$p43882412 F9c6286af;
    private p5d87a5f5 Fa2e56976;
    private readonly byte[] Fa9db0dd1;
    private readonly p7e62bc34$p43882412 Fb4a143d6;
    private readonly p7e62bc34 Fbcbcabd1;
    private readonly bool Fbf391796;
    private bool Fc1d53f5a;
    private bool Fc65a63f0;
    private bool Fc898983c;
    private int Fca8e5675;
    private readonly pcc81e3f6 Fcd2a44e7;
    private long Fcf8dbcaf;
    private long Fd27cf49a;
    private bool Fd3ab0833;
    private readonly bool Fd423f6db;
    private readonly bool Fd8b6dcef;
    private readonly p3d6bb966$pa3496286 Fd983bad5;
    private readonly p7e62bc34$p43882412 Fdefb31bd;
    private bool Fe1ced7d3;
    private bool Fe88329b8;
    private bool Fec825f06;
    private bool Fecefcfdc;
    private readonly p7e62bc34 Ff041d40c;
    private readonly p7e62bc34 Ff3c7e837;
    private readonly byte[] Ff45b3b5c;

    private void ReadControlFrame()
    {
        // str: "Malformed close payload length of 1."
        // str: "Unknown control opcode: "
        // str: ""
        // call: pd775ff95.toggleMask
        // call: p7e62bc34$p43882412.close
        // call: ProtocolException.<init>
        // call: p7e62bc34.readByteString
        // call: p3d6bb966$pa3496286.onReadPong
        // call: p23e8a4b4.toHexString
        // call: Intrinsics.checkNotNull
        // call: p7e62bc34.size
        // call: p3d6bb966$pa3496286.onReadClose
        // call: Intrinsics.stringPlus
        // call: p7e62bc34.readUtf8
        // call: p7e62bc34.readAndWriteUnsafe
        // call: p7e62bc34.readShort
        // call: p7e62bc34$p43882412.seek
        // call: p3d6bb966$pa3496286.onReadPing
        // call: pd775ff95.closeCodeExceptionMessage
        // call: pcc81e3f6.readFully
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f882c467d
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f184ad3ff
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p742523da.pd775ff95.f76425f17
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f25b972a4
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.ff45b3b5c
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f9876e266
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f9c6286af
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f349e6863
        // field: android.os.Build$VERSION.SDK_INT
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f56ee629b
        // type: ProtocolException
    }

    private void ReadHeader()
    {
        // str: "Control frame must be less than 125B."
        // str: "Client-sent frames must be masked."
        // str: "Frame length 0x"
        // str: "Control frames must be final."
        // str: "closed"
        // str: " > 0x7FFFFFFFFFFFFFFF"
        // str: "Unexpected rsv1 flag"
        // str: "Unexpected rsv2 flag"
        // str: "Server-sent frames must not be masked."
        // str: "Unexpected rsv3 flag"
        // call: StringBuilder.append
        // call: ProtocolException.<init>
        // call: pcc81e3f6.readFully
        // call: pc85a251c.clearTimeout
        // call: pcc81e3f6.readByte
        // call: p23e8a4b4.and
        // call: p23e8a4b4.toHexString
        // call: pcc81e3f6.readShort
        // call: StringBuilder.<init>
        // call: pc85a251c.timeout
        // call: StringBuilder.toString
        // call: pcc81e3f6.timeout
        // call: Intrinsics.checkNotNull
        // call: pcc81e3f6.readLong
        // call: pc85a251c.timeoutNanos
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.fc898983c
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f73bc9d34
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f51fdb159
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f56ee629b
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f36cd38f4
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.fbf391796
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f349e6863
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f9876e266
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.ff45b3b5c
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f882c467d
        // type: ProtocolException
        // type: StringBuilder
        // type: IOException
    }

    private void ReadMessage()
    {
        // str: "Expected continuation opcode. Got: "
        // str: "closed"
        // call: ProtocolException.<init>
        // call: pcc81e3f6.readFully
        // call: Intrinsics.checkNotNull
        // call: p23e8a4b4.toHexString
        // call: p7e62bc34.readAndWriteUnsafe
        // call: p7e62bc34.size
        // call: Intrinsics.stringPlus
        // call: pd775ff95.toggleMask
        // call: p7e62bc34$p43882412.close
        // call: p3d6bb966.readUntilNonControlFrame
        // call: p7e62bc34$p43882412.seek
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p742523da.pd775ff95.f76425f17
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.ff45b3b5c
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f882c467d
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.ff3c7e837
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f56ee629b
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f9c6286af
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f349e6863
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.fc898983c
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f9876e266
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f36cd38f4
        // type: IOException
        // type: ProtocolException
    }

    private void ReadMessageFrame()
    {
        // str: "Unknown opcode: "
        // call: Intrinsics.stringPlus
        // call: p3d6bb966$pa3496286.onReadMessage
        // call: p5d87a5f5.<init>
        // call: p5d87a5f5.inflate
        // call: ProtocolException.<init>
        // call: p7e62bc34.readUtf8
        // call: p23e8a4b4.toHexString
        // call: p3d6bb966.readMessage
        // call: p7e62bc34.readByteString
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f3fd8d77d
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.ff3c7e837
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f25b972a4
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f882c467d
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f310b7e67
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f51fdb159
        // type: p5d87a5f5
        // type: ProtocolException
    }

    private void ReadUntilNonControlFrame()
    {
        // call: p3d6bb966.readControlFrame
        // call: p3d6bb966.readHeader
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f349e6863
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f73bc9d34
    }

    public void Close()
    {
        // call: p5d87a5f5.close
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f310b7e67
    }

    public pcc81e3f6 GetSource()
    {
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f36cd38f4
        return default!;
    }

    public void ProcessNextFrame()
    {
        // call: p3d6bb966.readControlFrame
        // call: p3d6bb966.readMessageFrame
        // call: p3d6bb966.readHeader
        // field: p7ddcfee1.pd1efad72.p742523da.p3d6bb966.f73bc9d34
    }

}
