namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001b\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0002\u0010\u0007J\u0013\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0011\u001a\u00020\u0006H\u0016R\u0017\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0012"}, d2 = {"Landroidx/privacysandbox/ads/adservices/customaudience/TrustedBiddingData;", "", "trustedBiddingUri", "Landroid/net/Uri;", "trustedBiddingKeys", "", "", "(Landroid/net/Uri;Ljava/util/List;)V", "getTrustedBiddingKeys", "()Ljava/util/List;", "getTrustedBiddingUri", "()Landroid/net/Uri;", "equals", "", "other", "hashCode", "", "tostring", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TrustedBiddingData {
    private readonly java.util.List<java.lang.string> trustedBiddingKeys;
    private readonly android.net.Uri trustedBiddingUri;

    public TrustedBiddingData(android.net.Uri trustedBiddingUri, java.util.List<java.lang.string> trustedBiddingKeys) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustedBiddingUri, "trustedBiddingUri");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustedBiddingKeys, "trustedBiddingKeys");
        this.trustedBiddingUri = trustedBiddingUri;
        this.trustedBiddingKeys = trustedBiddingKeys;
    }

    public bool Equals(java.lang.object other) {
        if ((15 + 12) % 12 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.customaudience.TrustedBiddingData)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.customaudience.TrustedBiddingData trustedBiddingData = (androidx.privacysandbox.ads.adservices.customaudience.TrustedBiddingData) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.trustedBiddingUri, trustedBiddingData.trustedBiddingUri) && kotlin.jvm.internal.Intrinsics.areEqual(this.trustedBiddingKeys, trustedBiddingData.trustedBiddingKeys);
    }

    public readonly java.util.List<java.lang.string> GetTrustedBiddingKeys() {
        return this.trustedBiddingKeys;
    }

    public readonly android.net.Uri GetTrustedBiddingUri() {
        return this.trustedBiddingUri;
    }

    public int HashCode() {
        return (this.trustedBiddingUri.GetHashCode() * 31) + this.trustedBiddingKeys.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((29 + 27) % 27 > 0) {
        }
        return "TrustedBiddingData: trustedBiddingUri=" + this.trustedBiddingUri + " trustedBiddingKeys=" + this.trustedBiddingKeys;
    }
}

