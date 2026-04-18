namespace WillowMaze.Wasm.Decompiled;

public class Pdf1013f4 : Pf31bbdd1
{
    private readonly System.Security.Cryptography.Aes F08406a6e;
    private readonly System.Security.Cryptography.Aes F109bac46;
    private readonly pcc81e3f6 F1fb7f99f;
    private readonly p7e62bc34 F21a1d54a;
    private readonly pcc81e3f6 F27431e05;
    private bool F2a1585a8;
    private bool F349e6863;
    private readonly pcc81e3f6 F36cd38f4;
    private readonly p7e62bc34 F3c5999ef;
    private readonly int F480d1b61;
    private bool F5617acab;
    private bool F7bbcf342;
    private readonly p7e62bc34 F7f2db423;
    private readonly pcc81e3f6 F8190882a;
    private bool F81dfdfcd;
    private readonly System.Security.Cryptography.Aes F98b0e1d5;
    private readonly p7e62bc34 Fa9be2e35;
    private bool Fb71cd918;
    private readonly System.Security.Cryptography.Aes Fb7f3a0ee;
    private readonly System.Security.Cryptography.Aes Fd63a33bd;
    private readonly p7e62bc34 Fe6280560;
    private readonly int Ff92a283f;

    private void M3ac34083()
    {
        // str: "cipher.doFinal(source.readByteArray())"
        // call: System.Security.Cryptography.Aes.doFinal
        // call: pcc81e3f6.skip
        // call: pcc81e3f6.readByteArray
        // call: System.Security.Cryptography.Aes.getOutputSize
        // call: p7e62bc34.setSize$okio
        // call: p4b77e2a9.pop
        // call: p7e62bc34.writableSegment$okio
        // call: p2700aee4.mf914097e
        // call: p7e62bc34.write
        // call: System.Security.Cryptography.Aes.update
        // call: pcc81e3f6.getBuffer
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Intrinsics.checkNotNull
        // call: p7e62bc34.size
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.pdf1013f4.f7f2db423
        // field: p38cb8f46.pdf1013f4.f2a1585a8
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.pdf1013f4.f08406a6e
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // field: p38cb8f46.pdf1013f4.f36cd38f4
        // field: p38cb8f46.pdf1013f4.f480d1b61
        // field: p38cb8f46.p4b77e2a9.f8d777f38
    }

    private void Mb4479040()
    {
        // call: pcc81e3f6.exhausted
        // call: pdf1013f4.mebb5524b
        // call: pdf1013f4.m3ac34083
        // call: p7e62bc34.size
        // field: p38cb8f46.pdf1013f4.f2a1585a8
        // field: p38cb8f46.pdf1013f4.f7f2db423
        // field: p38cb8f46.pdf1013f4.f36cd38f4
    }

    private void Mebb5524b()
    {
        // call: p2700aee4.mf914097e
        // call: p7e62bc34.size
        // call: p7e62bc34.setSize$okio
        // call: System.Security.Cryptography.Aes.getOutputSize
        // call: p7e62bc34.writableSegment$okio
        // call: System.Security.Cryptography.Aes.doFinal
        // call: p4b77e2a9.pop
        // field: p38cb8f46.pdf1013f4.f08406a6e
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.pdf1013f4.f7f2db423
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p7e62bc34.f96e89a29
    }

    public void Close()
    {
        // call: pcc81e3f6.close
        // field: p38cb8f46.pdf1013f4.f349e6863
        // field: p38cb8f46.pdf1013f4.f36cd38f4
    }

    public System.Security.Cryptography.Aes GetCipher()
    {
        // field: p38cb8f46.pdf1013f4.f08406a6e
        return default!;
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "closed"
        // str: "byteCount < 0: "
        // str: "sink"
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: p7e62bc34.read
        // call: IllegalStateException.<init>
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.toString
        // call: pdf1013f4.mb4479040
        // call: StringBuilder.append
        // field: p38cb8f46.pdf1013f4.f7f2db423
        // field: p38cb8f46.pdf1013f4.f349e6863
        // type: IllegalStateException
        // type: StringBuilder
        // type: IllegalArgumentException
        return 0;
    }

    public pc85a251c Timeout()
    {
        // call: pcc81e3f6.timeout
        // field: p38cb8f46.pdf1013f4.f36cd38f4
        return default!;
    }

}
