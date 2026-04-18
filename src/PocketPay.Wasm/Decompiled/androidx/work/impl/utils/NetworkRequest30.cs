namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bÁ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u0005\u001a\u00020\u0006¨\u0006\u0007"}, d2 = {"Landroidx/work/impl/utils/NetworkRequest30;", "", "()V", "getNetworkSpecifier", "Landroid/net/NetworkSpecifier;", "request", "Landroid/net/NetworkRequest;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkRequest30 {
    public static readonly androidx.work.impl.utils.NetworkRequest30 INSTANCE = new androidx.work.impl.utils.NetworkRequest30();

    private NetworkRequest30() {
    }

    public readonly android.net.NetworkSpecifier GetNetworkSpecifier(android.net.NetworkRequest request) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return request.getNetworkSpecifier();
    }
}

