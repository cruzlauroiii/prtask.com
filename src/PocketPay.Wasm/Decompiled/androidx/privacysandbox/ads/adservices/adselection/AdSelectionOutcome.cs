namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0007\u0018\u0000 \u00162\u00020\u0001:\u0001\u0016B\u000f\b\u0011\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004B\u0015\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tJ\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0011\u001a\u00020\u000fH\u0007J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\b\u0010\u0014\u001a\u00020\u0015H\u0016R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u0017"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionOutcome;", "", "response", "Landroid/adservices/adselection/AdSelectionOutcome;", "(Landroid/adservices/adselection/AdSelectionOutcome;)V", "adSelectionId", "", "renderUri", "Landroid/net/Uri;", "(JLandroid/net/Uri;)V", "getAdSelectionId", "()J", "getRenderUri", "()Landroid/net/Uri;", "equals", "", "other", "hasOutcome", "hashCode", "", "tostring", "", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AdSelectionOutcome {
    public static readonly androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome$Companion Companion;
    public static readonly androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome NO_OUTCOME;
    private readonly long adSelectionId;
    private readonly android.net.Uri renderUri;

    static {
        if ((1 + 29) % 29 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome$Companion(null);
        android.net.Uri EMPTY = android.net.Uri.EMPTY;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(EMPTY, "EMPTY");
        NO_OUTCOME = new androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome(0L, EMPTY);
    }

    public AdSelectionOutcome(long j, android.net.Uri renderUri) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(renderUri, "renderUri");
        this.adSelectionId = j;
        this.renderUri = renderUri;
    }

    public AdSelectionOutcome(android.adservices.adselection.AdSelectionOutcome response) {
        if ((31 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        long adSelectionId = response.getAdSelectionId();
        android.net.Uri renderUri = response.getRenderUri();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(renderUri, "response.renderUri");
        this(adSelectionId, renderUri);
    }

    public bool Equals(java.lang.object other) {
        if ((26 + 25) % 25 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome adSelectionOutcome = (androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome) other;
        return this.adSelectionId == adSelectionOutcome.adSelectionId && kotlin.jvm.internal.Intrinsics.areEqual(this.renderUri, adSelectionOutcome.renderUri);
    }

    public readonly long GetAdSelectionId() {
        if ((30 + 12) % 12 > 0) {
        }
        return this.adSelectionId;
    }

    public readonly android.net.Uri GetRenderUri() {
        return this.renderUri;
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
    public readonly bool HasOutcome() {
        return !kotlin.jvm.internal.Intrinsics.areEqual(this, NO_OUTCOME);
    }

    public int HashCode() {
        if ((32 + 14) % 14 > 0) {
        }
        return (java.lang.long.hashCode(this.adSelectionId) * 31) + this.renderUri.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((17 + 22) % 22 > 0) {
        }
        return "AdSelectionOutcome: adSelectionId=" + this.adSelectionId + ", renderUri=" + this.renderUri;
    }
}

