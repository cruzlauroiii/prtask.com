namespace WillowMaze.Wasm.Decompiled;

public class P6c7261ea : P1eb558b5
{
    private readonly System.Security.Cryptography.Aes F08406a6e;
    private bool F349e6863;
    private readonly int F373e7ef2;
    private readonly int F480d1b61;
    private readonly p08d84bc6 F4c81a9a3;
    private bool F51152a4e;
    private readonly p08d84bc6 Fa56217df;
    private readonly p08d84bc6 Fb8fd3540;
    private readonly p08d84bc6 Fbc36bc54;
    private readonly System.Security.Cryptography.Aes Fe9568526;
    private readonly p08d84bc6 Ff6e04117;

    private int M3ac34083(p7e62bc34 P0, long P1)
    {
        // str: "cipher.update(source.readByteArray(remaining))"
        // call: System.Security.Cryptography.Aes.update
        // call: p7e62bc34.setSize$okio
        // call: p7e62bc34.writableSegment$okio
        // call: p7e62bc34.size
        // call: System.Security.Cryptography.Aes.getOutputSize
        // call: p4b77e2a9.pop
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p7e62bc34.readByteArray
        // call: p08d84bc6.write
        // call: Math.min
        // call: p08d84bc6.emitCompleteSegments
        // call: p08d84bc6.getBuffer
        // call: Intrinsics.checkNotNull
        // call: p2700aee4.mf914097e
        // field: p38cb8f46.p6c7261ea.f08406a6e
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p6c7261ea.ff6e04117
        // field: p38cb8f46.p6c7261ea.f480d1b61
        // field: p38cb8f46.p7e62bc34.f96e89a29
        return 0;
    }

    private Exception Mebb5524b()
    {
        // str: "cipher.doFinal()"
        // call: p4b77e2a9.pop
        // call: System.Security.Cryptography.Aes.doFinal
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p08d84bc6.write
        // call: p2700aee4.mf914097e
        // call: p08d84bc6.getBuffer
        // call: p7e62bc34.writableSegment$okio
        // call: p7e62bc34.size
        // call: p7e62bc34.setSize$okio
        // call: System.Security.Cryptography.Aes.getOutputSize
        // field: p38cb8f46.p6c7261ea.f08406a6e
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p6c7261ea.ff6e04117
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p7e62bc34.f96e89a29
        return default!;
    }

    public void Close()
    {
        // call: p6c7261ea.mebb5524b
        // call: p08d84bc6.close
        // field: p38cb8f46.p6c7261ea.f349e6863
        // field: p38cb8f46.p6c7261ea.ff6e04117
    }

    public void Flush()
    {
        // call: p08d84bc6.flush
        // field: p38cb8f46.p6c7261ea.ff6e04117
    }

    public System.Security.Cryptography.Aes GetCipher()
    {
        // field: p38cb8f46.p6c7261ea.f08406a6e
        return default!;
    }

    public pc85a251c Timeout()
    {
        // call: p08d84bc6.timeout
        // field: p38cb8f46.p6c7261ea.ff6e04117
        return default!;
    }

    public void Write(p7e62bc34 P0, long P1)
    {
        // str: "source"
        // str: "closed"
        // call: Intrinsics.checkNotNullParameter
        // call: object.toString
        // call: p6c7261ea.m3ac34083
        // call: p2ff17a65.m799a7e61
        // call: p7e62bc34.size
        // call: IllegalStateException.<init>
        // field: p38cb8f46.p6c7261ea.f349e6863
        // type: IllegalStateException
    }

}
