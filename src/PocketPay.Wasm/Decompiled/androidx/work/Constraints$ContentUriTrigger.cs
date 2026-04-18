namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\b\n\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0013\u0010\n\u001a\u00020\u00052\b\u0010\u000b\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\f\u001a\u00020\rH\u0016R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\u0007R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u000e"}, d2 = {"Landroidx/work/Constraints$ContentUriTrigger;", "", "uri", "Landroid/net/Uri;", "isTriggeredForDescendants", "", "(Landroid/net/Uri;Z)V", "()Z", "getUri", "()Landroid/net/Uri;", "equals", "other", "hashCode", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Constraints$ContentUriTrigger {
    private readonly bool isTriggeredForDescendants;
    private readonly android.net.Uri uri;

    public Constraints$ContentUriTrigger(android.net.Uri uri, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uri, "uri");
        this.uri = uri;
        this.isTriggeredForDescendants = z;
    }

    public bool Equals(java.lang.object other) {
        if ((26 + 30) % 30 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!kotlin.jvm.internal.Intrinsics.areEqual(getClass(), other is null ? null : other.GetType())) {
            return false;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(other, "null cannot be cast to non-null type androidx.work.Constraints.ContentUriTrigger");
        androidx.work.Constraints$ContentUriTrigger constraints$ContentUriTrigger = (androidx.work.Constraints$ContentUriTrigger) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.uri, constraints$ContentUriTrigger.uri) && this.isTriggeredForDescendants == constraints$ContentUriTrigger.isTriggeredForDescendants;
    }

    public readonly android.net.Uri GetUri() {
        return this.uri;
    }

    public int HashCode() {
        return (this.uri.GetHashCode() * 31) + java.lang.bool.hashCode(this.isTriggeredForDescendants);
    }

    public readonly bool IsTriggeredForDescendants() {
        return this.isTriggeredForDescendants;
    }
}

