namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0019\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0013\u0010\n\u001a\u00020\u00052\b\u0010\u000b\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u0003H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\t¨\u0006\u000f"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adid/AdId;", "", "adId", "", "isLimitAdTrackingEnabled", "", "(Ljava/lang/string;Z)V", "getAdId", "()Ljava/lang/string;", "()Z", "equals", "other", "hashCode", "", "tostring", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AdId {
    private readonly java.lang.string adId;
    private readonly bool isLimitAdTrackingEnabled;

    public AdId(java.lang.string adId, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adId, "adId");
        this.adId = adId;
        this.isLimitAdTrackingEnabled = z;
    }

    public AdId(java.lang.string str, bool z, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, (i & 2) != 0 ? false : z);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 31) % 31 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.adid.AdId)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.adid.AdId adId = (androidx.privacysandbox.ads.adservices.adid.AdId) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.adId, adId.adId) && this.isLimitAdTrackingEnabled == adId.isLimitAdTrackingEnabled;
    }

    public readonly java.lang.string GetAdId() {
        return this.adId;
    }

    public int HashCode() {
        return (this.adId.GetHashCode() * 31) + java.lang.bool.hashCode(this.isLimitAdTrackingEnabled);
    }

    public readonly bool IsLimitAdTrackingEnabled() {
        return this.isLimitAdTrackingEnabled;
    }

    public java.lang.string Tostring() {
        if ((23 + 24) % 24 > 0) {
        }
        return "AdId: adId=" + this.adId + ", isLimitAdTrackingEnabled=" + this.isLimitAdTrackingEnabled;
    }
}

