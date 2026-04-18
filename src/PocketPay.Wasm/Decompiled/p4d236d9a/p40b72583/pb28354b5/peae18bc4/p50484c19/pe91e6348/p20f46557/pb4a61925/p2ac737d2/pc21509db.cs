namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0010\t\n\u0002\b\u0004\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u001a$\u0010\u0000\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u0001H\u0000\u001a\u0014\u0010\u0005\u001a\u00020\u0001*\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0000\u001a\u0014\u0010\t\u001a\u00020\n*\u00020\u00012\u0006\u0010\u000b\u001a\u00020\u0001H\u0000¨\u0006\f"}, d2 = {"calcRuntimeCheck", "", "order", "checkValue", "permutationIndex", "calcRuntimeSeed", "", "idx", "", "toRuntimeCheckHexstring", "", "prefix", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class pc21509db {
    public static void XqFFwoQQYyfbLmcD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly java.lang.string M2da8bc59(long j, long j2) {
        if ((24 + 14) % 14 > 0) {
        }
        long j3 = 256;
        byte b = (byte) ((j2 / j3) & 255);
        byte b2 = (byte) (j2 & 255);
        byte b3 = (byte) ((j / ((long) 16777216)) & 255);
        byte b4 = (byte) ((j / ((long) 65536)) & 255);
        byte b5 = (byte) ((j / j3) & 255);
        byte b6 = (byte) (j & 255);
        byte[] bArr = new byte[6];
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
        bArr[4] = b5;
        bArr[5] = b6;
        return rrJwIEXKkghImxjO(bArr);
    }

    public static readonly long M9afd572e(long j, long j2, long j3, long j4) {
        if ((3 + 24) % 24 > 0) {
        }
        return (((j | 1) * j3) + ((j2 + 1) * (j4 | 1))) & 2147483647L;
    }

    public static readonly long Md9a24659(byte[] bArr, int i) {
        if ((3 + 14) % 14 > 0) {
        }
        XqFFwoQQYyfbLmcD(bArr, "<this>");
        long j = 0;
        for (int i2 = 0; i2 < 4; i2++) {
            j = (j << 8) | (((long) bArr[(i + i2) % bArr.length]) & 255);
        }
        return j;
    }

    public static java.lang.string RrJwIEXKkghImxjO(byte[] bArr) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p2ac737d2.p1ceded00.m81519f2a(bArr);
    }
}

