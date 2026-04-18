namespace WillowMaze.Wasm.Decompiled;

public class P5d577fe6 : P58efa9e8
{
    private readonly byte[][] F1f982d98;
    private readonly byte[][] F58a5f6ab;
    private readonly int[] F5f8f22b8;
    private readonly int[] F77ccaee1;
    private readonly int[] Fdb6c1e58;
    private readonly byte[][] Ff1b9fbe7;

    private p58efa9e8 M4604aa1a()
    {
        // call: p58efa9e8.<init>
        // call: p5d577fe6.toByteArray
        // type: p58efa9e8
        return default!;
    }

    private object M5103e46a()
    {
        // str: "null cannot be cast to non-null type java.lang.Object"
        // call: Intrinsics.checkNotNull
        // call: p5d577fe6.m4604aa1a
        return default!;
    }

    public byte[] AsByteBuffer()
    {
        // str: "wrap(toByteArray()).asReadOnlyBuffer()"
        // call: p5d577fe6.toByteArray
        // call: byte[].asReadOnlyBuffer
        // call: byte[].wrap
        // call: Intrinsics.checkNotNullExpressionValue
        return default!;
    }

    public string Base64()
    {
        // call: p5d577fe6.m4604aa1a
        // call: p58efa9e8.base64
        return string.Empty;
    }

    public string Base64Url()
    {
        // call: p5d577fe6.m4604aa1a
        // call: p58efa9e8.base64Url
        return string.Empty;
    }

    public void CopyInto(int P0, byte[] P1, int P2, int P3)
    {
        // str: "target"
        // call: Intrinsics.checkNotNullParameter
        // call: p2ff17a65.m799a7e61
        // call: p5d577fe6.getDirectory$okio
        // call: p5d577fe6.getSegments$okio
        // call: Math.min
        // call: ArraysKt.copyInto
        // call: p5d577fe6.size
        // call: p2ff17a65.mfdd32b90
    }

    public p58efa9e8 Digest$okio(string P0)
    {
        // str: "digestBytes"
        // str: "algorithm"
        // call: System.Security.Cryptography.HashAlgorithm.digest
        // call: System.Security.Cryptography.HashAlgorithm.update
        // call: Intrinsics.checkNotNullParameter
        // call: p5d577fe6.getDirectory$okio
        // call: p58efa9e8.<init>
        // call: System.Security.Cryptography.HashAlgorithm.getInstance
        // call: p5d577fe6.getSegments$okio
        // call: Intrinsics.checkNotNullExpressionValue
        // type: p58efa9e8
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: p5d577fe6.size
        // call: p58efa9e8.size
        // call: p5d577fe6.rangeEquals
        return false;
    }

    public int[] GetDirectory$okio()
    {
        // field: p38cb8f46.p5d577fe6.f5f8f22b8
        return default!;
    }

    public byte[][] GetSegments$okio()
    {
        // field: p38cb8f46.p5d577fe6.f1f982d98
        return default!;
    }

    public int GetSize$okio()
    {
        // call: p5d577fe6.getDirectory$okio
        // call: p5d577fe6.getSegments$okio
        return 0;
    }

    public int HashCode()
    {
        // call: p5d577fe6.getHashCode$okio
        // call: p5d577fe6.setHashCode$okio
        // call: p5d577fe6.getDirectory$okio
        // call: p5d577fe6.getSegments$okio
        return 0;
    }

    public string Hex()
    {
        // call: p58efa9e8.hex
        // call: p5d577fe6.m4604aa1a
        return string.Empty;
    }

    public p58efa9e8 Hmac$okio(string P0, p58efa9e8 P1)
    {
        // str: "mac.doFinal()"
        // str: "algorithm"
        // str: "key"
        // call: Intrinsics.checkNotNullParameter
        // call: System.Security.Cryptography.HMAC.getInstance
        // call: p58efa9e8.toByteArray
        // call: byte[].<init>
        // call: System.Security.Cryptography.HMAC.init
        // call: p5d577fe6.getSegments$okio
        // call: p5d577fe6.getDirectory$okio
        // call: System.Security.Cryptography.HMAC.update
        // call: System.Security.Cryptography.HMAC.doFinal
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p58efa9e8.<init>
        // call: IllegalArgumentException.<init>
        // type: byte[]
        // type: p58efa9e8
        // type: IllegalArgumentException
        return default!;
    }

    public int IndexOf(byte[] P0, int P1)
    {
        // str: "other"
        // call: p58efa9e8.indexOf
        // call: p5d577fe6.m4604aa1a
        // call: Intrinsics.checkNotNullParameter
        return 0;
    }

    public byte[] InternalArray$okio()
    {
        // call: p5d577fe6.toByteArray
        return default!;
    }

    public byte InternalGet$okio(int P0)
    {
        // call: p5d577fe6.getSegments$okio
        // call: p5d577fe6.getDirectory$okio
        // call: p2ff17a65.mfdd32b90
        // call: p2ff17a65.m799a7e61
        return 0;
    }

    public int LastIndexOf(byte[] P0, int P1)
    {
        // str: "other"
        // call: p58efa9e8.lastIndexOf
        // call: p5d577fe6.m4604aa1a
        // call: Intrinsics.checkNotNullParameter
        return 0;
    }

    public bool RangeEquals(int P0, p58efa9e8 P1, int P2, int P3)
    {
        // str: "other"
        // call: Intrinsics.checkNotNullParameter
        // call: p5d577fe6.getSegments$okio
        // call: p5d577fe6.getDirectory$okio
        // call: p58efa9e8.rangeEquals
        // call: p5d577fe6.size
        // call: p2ff17a65.mfdd32b90
        // call: Math.min
        return false;
    }

    public bool RangeEquals(int P0, byte[] P1, int P2, int P3)
    {
        // str: "other"
        // call: p5d577fe6.getDirectory$okio
        // call: Math.min
        // call: Intrinsics.checkNotNullParameter
        // call: p2ff17a65.mfdd32b90
        // call: p5d577fe6.size
        // call: p5d577fe6.getSegments$okio
        // call: p2ff17a65.m38f24446
        return false;
    }

    public string String(System.Text.Encoding P0)
    {
        // str: "charset"
        // call: p58efa9e8.string
        // call: Intrinsics.checkNotNullParameter
        // call: p5d577fe6.m4604aa1a
        return string.Empty;
    }

    public p58efa9e8 Substring(int P0, int P1)
    {
        // str: "beginIndex="
        // str: " < beginIndex="
        // str: "endIndex="
        // str: " > length("
        // str: " < 0"
        // call: p5d577fe6.getDirectory$okio
        // call: p2ff17a65.mfdd32b90
        // call: object.toString
        // call: StringBuilder.append
        // call: p5d577fe6.size
        // call: ArraysKt.copyOfRange
        // call: p2ff17a65.mdff9fa2d
        // call: Math.min
        // call: p5d577fe6.getSegments$okio
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: p5d577fe6.<init>
        // field: p38cb8f46.p58efa9e8.fba2b45bd
        // type: StringBuilder
        // type: p5d577fe6
        // type: IllegalArgumentException
        return default!;
    }

    public p58efa9e8 ToAsciiLowercase()
    {
        // call: p5d577fe6.m4604aa1a
        // call: p58efa9e8.toAsciiLowercase
        return default!;
    }

    public p58efa9e8 ToAsciiUppercase()
    {
        // call: p58efa9e8.toAsciiUppercase
        // call: p5d577fe6.m4604aa1a
        return default!;
    }

    public byte[] ToByteArray()
    {
        // call: p5d577fe6.size
        // call: p5d577fe6.getDirectory$okio
        // call: p5d577fe6.getSegments$okio
        // call: ArraysKt.copyInto
        return default!;
    }

    public string ToString()
    {
        // call: p58efa9e8.toString
        // call: p5d577fe6.m4604aa1a
        return string.Empty;
    }

    public void Write(Stream P0)
    {
        // str: "out"
        // call: Intrinsics.checkNotNullParameter
        // call: p5d577fe6.getSegments$okio
        // call: p5d577fe6.getDirectory$okio
        // call: Stream.write
    }

    public void Write$okio(p7e62bc34 P0, int P1, int P2)
    {
        // str: "buffer"
        // call: Math.min
        // call: p5d577fe6.getSegments$okio
        // call: p7e62bc34.setSize$okio
        // call: p5d577fe6.getDirectory$okio
        // call: Intrinsics.checkNotNullParameter
        // call: p4b77e2a9.push
        // call: p2ff17a65.mfdd32b90
        // call: p7e62bc34.size
        // call: p4b77e2a9.<init>
        // call: Intrinsics.checkNotNull
        // field: p38cb8f46.p4b77e2a9.ffcb08b16
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // field: p38cb8f46.p4b77e2a9.fd0cab90d
        // type: p4b77e2a9
    }

}
