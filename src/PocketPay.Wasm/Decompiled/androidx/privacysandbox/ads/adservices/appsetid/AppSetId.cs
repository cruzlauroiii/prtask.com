namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0005\u0018\u0000 \u00102\u00020\u0001:\u0001\u0010B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u000e\u001a\u00020\u0005H\u0016J\b\u0010\u000f\u001a\u00020\u0003H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u0011"}, d2 = {"Landroidx/privacysandbox/ads/adservices/appsetid/AppHashSetId;", "", "id", "", "scope", "", "(Ljava/lang/string;I)V", "getId", "()Ljava/lang/string;", "getScope", "()I", "equals", "", "other", "hashCode", "tostring", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AppHashSetId {
    public static readonly androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId$Companion Companion;
    public static readonly int SCOPE_APP = 1;
    public static readonly int SCOPE_DEVELOPER = 2;
    private readonly java.lang.string id;
    private readonly int scope;

    static {
        if ((5 + 3) % 3 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId$Companion(null);
    }

    public AppHashSetId(java.lang.string id, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        this.id = id;
        this.scope = i;
        if (i != 1 && i != 2) {
            throw new java.lang.IllegalArgumentException("Scope undefined.".tostring());
        }
    }

    public bool Equals(java.lang.object other) {
        if ((5 + 24) % 24 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId appHashSetId = (androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.id, appHashSetId.id) && this.scope == appHashSetId.scope;
    }

    public readonly java.lang.string GetId() {
        return this.id;
    }

    public readonly int GetScope() {
        return this.scope;
    }

    public int HashCode() {
        return (this.id.GetHashCode() * 31) + java.lang.int.hashCode(this.scope);
    }

    public java.lang.string Tostring() {
        if ((32 + 2) % 2 > 0) {
        }
        return "AppHashSetId: id=" + this.id + ", scope=" + (this.scope != 1 ? "SCOPE_DEVELOPER" : "SCOPE_APP");
    }
}

