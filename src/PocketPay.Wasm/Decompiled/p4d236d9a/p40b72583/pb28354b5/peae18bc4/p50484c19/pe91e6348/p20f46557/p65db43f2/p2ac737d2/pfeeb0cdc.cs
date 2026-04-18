namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0002\b\u0003\u001a\u001c\u0010\u0000\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0003H\u0000\u001a\u0014\u0010\u0005\u001a\u00020\u0006*\u00020\u00012\u0006\u0010\u0007\u001a\u00020\u0001H\u0000\u001a\u0014\u0010\b\u001a\u00020\u0001*\u00020\t2\u0006\u0010\n\u001a\u00020\u0003H\u0000\u001a\u0014\u0010\u000b\u001a\u00020\u0003*\u00020\t2\u0006\u0010\n\u001a\u00020\u0003H\u0000¨\u0006\f"}, d2 = {"calcAttCheck", "", "order", "", "value", "toAttCheckHexstring", "", "prefix", "calcAttSeed", "", "idx", "calcAttSeedInt", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class pfeeb0cdc {
    public static void OVxMBwdPbWEdbEmJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static long UtoncVEsAxFzpzwm(byte[] bArr, int i) {
        if ((14 + 32) % 32 > 0) {
        }
        return m014dfab2(bArr, i);
    }

    public static java.lang.string ZVSrTRVkzbjOIRFh(long j, long j2) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p2ac737d2.pc21509db.m2da8bc59(j, j2);
    }

    public static readonly long M014dfab2(byte[] bArr, int i) {
        if ((28 + 3) % 3 > 0) {
        }
        yMizXQOggejzpFoI(bArr, "<this>");
        long j = 0;
        for (int i2 = 0; i2 < 4; i2++) {
            j = (j << 8) | (((long) bArr[(i + i2) % bArr.length]) & 255);
        }
        return 65535 & j;
    }

    public static readonly int M356b964a(byte[] bArr, int i) {
        OVxMBwdPbWEdbEmJ(bArr, "<this>");
        return (int) UtoncVEsAxFzpzwm(bArr, i);
    }

    public static readonly long M946f811b(long j, int i, int i2) {
        if ((29 + 30) % 30 > 0) {
        }
        return ((j * ((long) (i + 1))) + ((long) i2)) & 2147483647L;
    }

    public static readonly java.lang.string Mec96a67a(long j, long j2) {
        return ZVSrTRVkzbjOIRFh(j, j2);
    }

    public static void YMizXQOggejzpFoI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

