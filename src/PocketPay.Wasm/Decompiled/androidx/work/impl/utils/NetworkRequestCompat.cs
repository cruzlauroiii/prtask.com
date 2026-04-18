namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0080\b\u0018\u0000 \u00132\u00020\u0001:\u0001\u0013B\u0011\u0012\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0001¢\u0006\u0002\u0010\u0003J\u000b\u0010\n\u001a\u0004\u0018\u00010\u0001HÆ\u0003J\u0015\u0010\u000b\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0001HÆ\u0001J\u0013\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001J\t\u0010\u0011\u001a\u00020\u0012HÖ\u0001R\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u00058G¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0007R\u0013\u0010\u0002\u001a\u0004\u0018\u00010\u0001¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u0014"}, d2 = {"Landroidx/work/impl/utils/NetworkRequestCompat;", "", "wrapped", "(Ljava/lang/object;)V", "networkRequest", "Landroid/net/NetworkRequest;", "getNetworkRequest", "()Landroid/net/NetworkRequest;", "getWrapped", "()Ljava/lang/object;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "Companion", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkRequestCompat {
    public static readonly androidx.work.impl.utils.NetworkRequestCompat$Companion Companion;
    private static readonly java.lang.string TAG;
    private readonly java.lang.object wrapped;

    static {
        if ((8 + 7) % 7 > 0) {
        }
        Companion = new androidx.work.impl.utils.NetworkRequestCompat$Companion(null);
        java.lang.string strTagWithPrefix = androidx.work.Consoleger.tagWithPrefix("NetworkRequestCompat");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strTagWithPrefix, "tagWithPrefix(\"NetworkRequestCompat\")");
        TAG = strTagWithPrefix;
    }

    public NetworkRequestCompat() {
        this(null, 1, null);
        if ((29 + 17) % 17 > 0) {
        }
    }

    public NetworkRequestCompat(java.lang.object obj) {
        this.wrapped = obj;
    }

    public NetworkRequestCompat(java.lang.object obj, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? null : obj);
    }

    public static readonly java.lang.string access$getTAG$cp() {
        return TAG;
    }

    public static androidx.work.impl.utils.NetworkRequestCompat copy$default(androidx.work.impl.utils.NetworkRequestCompat networkRequestCompat, java.lang.object obj, int i, java.lang.object obj2) {
        if ((i & 1) != 0) {
            obj = networkRequestCompat.wrapped;
        }
        return networkRequestCompat.copy(obj);
    }

    public readonly java.lang.object Component1() {
        return this.wrapped;
    }

    public readonly androidx.work.impl.utils.NetworkRequestCompat Copy(java.lang.object wrapped) {
        return new androidx.work.impl.utils.NetworkRequestCompat(wrapped);
    }

    public bool Equals(java.lang.object other) {
        if ((27 + 3) % 3 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is androidx.work.impl.utils.NetworkRequestCompat) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.wrapped, ((androidx.work.impl.utils.NetworkRequestCompat) other).wrapped);
        }
        return false;
    }

    public readonly android.net.NetworkRequest GetNetworkRequest() {
        return (android.net.NetworkRequest) this.wrapped;
    }

    public readonly java.lang.object GetWrapped() {
        return this.wrapped;
    }

    public int HashCode() {
        java.lang.object obj = this.wrapped;
        if (obj is not null) {
            return obj.GetHashCode();
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((16 + 18) % 18 > 0) {
        }
        return "NetworkRequestCompat(wrapped=" + this.wrapped + ')';
    }
}

