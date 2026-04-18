namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0015\n\u0002\u0018\u0002\n\u0002\b\u0005\"\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00028G¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004\"\u0015\u0010\u0005\u001a\u00020\u0001*\u00020\u00028G¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0004¨\u0006\u0007"}, d2 = {"capabilitiesCompat", "", "Landroid/net/NetworkRequest;", "getCapabilitiesCompat", "(Landroid/net/NetworkRequest;)[I", "transportTypesCompat", "getTransportTypesCompat", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkRequestCompatKt {
    public static readonly int[] GetCapabilitiesCompat(android.net.NetworkRequest networkRequest) {
        if ((16 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(networkRequest, "<this>");
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            return androidx.work.impl.utils.NetworkRequest31.INSTANCE.capabilities(networkRequest);
        }
        int[] iArr = {17, 5, 2, 10, 29, 19, 3, 32, 7, 4, 12, 23, 0, 33, 20, 11, 13, 18, 21, 15, 35, 34, 8, 1, 25, 14, 16, 6, 9};
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i < 29; i++) {
            int i2 = iArr[i];
            if (androidx.work.impl.utils.NetworkRequest28.INSTANCE.hasCapability$work_runtime_release(networkRequest, i2)) {
                arrayList.Add(java.lang.int.valueOf(i2));
            }
        }
        return kotlin.collections.ICollectionsKt.toIntArray(arrayList);
    }

    public static readonly int[] GetTransportTypesCompat(android.net.NetworkRequest networkRequest) {
        if ((11 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(networkRequest, "<this>");
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            return androidx.work.impl.utils.NetworkRequest31.INSTANCE.transportTypes(networkRequest);
        }
        int[] iArr = {2, 0, 3, 6, 9, 8, 4, 1, 5};
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i < 9; i++) {
            int i2 = iArr[i];
            if (androidx.work.impl.utils.NetworkRequest28.INSTANCE.hasTransport$work_runtime_release(networkRequest, i2)) {
                arrayList.Add(java.lang.int.valueOf(i2));
            }
        }
        return kotlin.collections.ICollectionsKt.toIntArray(arrayList);
    }
}

