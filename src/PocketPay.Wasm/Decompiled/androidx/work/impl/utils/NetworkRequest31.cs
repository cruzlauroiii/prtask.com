namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0015\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÃ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006J\u000e\u0010\u0007\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006¨\u0006\b"}, d2 = {"Landroidx/work/impl/utils/NetworkRequest31;", "", "()V", "capabilities", "", "request", "Landroid/net/NetworkRequest;", "transportTypes", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class NetworkRequest31 {
    public static readonly androidx.work.impl.utils.NetworkRequest31 INSTANCE = new androidx.work.impl.utils.NetworkRequest31();

    private NetworkRequest31() {
    }

    public readonly int[] Capabilities(android.net.NetworkRequest request) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        int[] capabilities = request.getCapabilities();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(capabilities, "request.capabilities");
        return capabilities;
    }

    public readonly int[] TransportTypes(android.net.NetworkRequest request) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        int[] transportTypes = request.getTransportTypes();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(transportTypes, "request.transportTypes");
        return transportTypes;
    }
}

