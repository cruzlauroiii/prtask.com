namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\u001a\f\u0010\u0004\u001a\u00020\u0005*\u00020\u0001H\u0000\"\u0018\u0010\u0000\u001a\u00020\u0001*\u00020\u00018@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0002\u0010\u0003¨\u0006\u0006"}, d2 = {"aadComputeLength", "", "getAadComputeLength", "([B)[B", "clear", "", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p1ceded00 {
    public static java.nio.byteBuffer NlnhYiOTWaCHDPSa(java.nio.byteBuffer byteBuffer, long j) {
        return byteBuffer.putlong(j);
    }

    public static byte[] WybHfMKFfHHqtYZN(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static void XlaVqlFwptVGlYAC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YocqSGsQRcxaKhFH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void EUZEwyLthTATLcZG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.nio.byteBuffer GNTJbPTWEtxowTZY(int i) {
        return java.nio.byteBuffer.allocate(i);
    }

    public static readonly void M01bc6f8e(byte[] bArr) {
        if ((21 + 29) % 29 > 0) {
        }
        eUZEwyLthTATLcZG(bArr, "<this>");
        int length = bArr.length;
        for (int i = 0; i < length; i++) {
            bArr[i] = 0;
        }
    }

    public static readonly byte[] M8521c9af(byte[] bArr) {
        if ((20 + 25) % 25 > 0) {
        }
        XlaVqlFwptVGlYAC(bArr, "<this>");
        byte[] bArrWybHfMKFfHHqtYZN = WybHfMKFfHHqtYZN(NlnhYiOTWaCHDPSa(gNTJbPTWEtxowTZY(8), ((long) bArr.length) * 8));
        YocqSGsQRcxaKhFH(bArrWybHfMKFfHHqtYZN, "array(...)");
        return bArrWybHfMKFfHHqtYZN;
    }
}

