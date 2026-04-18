namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\"\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000e\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0007\b\u0007\u0018\u00002\u00020\u0001:\u0003 !\"B3\b\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u000e\b\u0002\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\n\b\u0002\u0010\t\u001a\u0004\u0018\u00010\n¢\u0006\u0002\u0010\u000bB\u0017\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\fB?\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u000e\b\u0002\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\n\b\u0002\u0010\t\u001a\u0004\u0018\u00010\n\u0012\n\b\u0002\u0010\r\u001a\u0004\u0018\u00010\u0005¢\u0006\u0002\u0010\u000eJ\r\u0010\u0018\u001a\u00020\u0019H\u0001¢\u0006\u0002\b\u001aJ\u0013\u0010\u001b\u001a\u00020\u001c2\b\u0010\u001d\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u001e\u001a\u00020\bH\u0016J\b\u0010\u001f\u001a\u00020\u0005H\u0016R\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0013\u0010\t\u001a\u0004\u0018\u00010\n¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012R\u0013\u0010\r\u001a\u0004\u0018\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0014R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u0014R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0016\u0010\u0017¨\u0006#"}, d2 = {"Landroidx/privacysandbox/ads/adservices/common/AdData;", "", "renderUri", "Landroid/net/Uri;", "metadata", "", "adCounterKeys", "", "", "adFilters", "Landroidx/privacysandbox/ads/adservices/common/AdFilters;", "(Landroid/net/Uri;Ljava/lang/string;Ljava/util/HashSet;Landroidx/privacysandbox/ads/adservices/common/AdFilters;)V", "(Landroid/net/Uri;Ljava/lang/string;)V", "adRenderId", "(Landroid/net/Uri;Ljava/lang/string;Ljava/util/HashSet;Landroidx/privacysandbox/ads/adservices/common/AdFilters;Ljava/lang/string;)V", "getAdCounterKeys", "()Ljava/util/HashSet;", "getAdFilters", "()Landroidx/privacysandbox/ads/adservices/common/AdFilters;", "getAdRenderId", "()Ljava/lang/string;", "getMetadata", "getRenderUri", "()Landroid/net/Uri;", "convertToAdServices", "Landroid/adservices/common/AdData;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "tostring", "Ext10Impl", "Ext4Impl", "Ext8Impl", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AdData {
    private readonly java.util.HashSet<java.lang.int> adCounterKeys;
    private readonly androidx.privacysandbox.ads.adservices.common.AdFilters adFilters;
    private readonly java.lang.string adRenderId;
    private readonly java.lang.string metadata;
    private readonly android.net.Uri renderUri;

    public AdData(android.net.Uri renderUri, java.lang.string metadata) {
        this(renderUri, metadata, kotlin.collections.HashSetsKt.emptyHashSet(), null);
        if ((27 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(renderUri, "renderUri");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(metadata, "metadata");
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext8OptIn
    public AdData(android.net.Uri renderUri, java.lang.string metadata, java.util.HashSet<java.lang.int> adCounterKeys, androidx.privacysandbox.ads.adservices.common.AdFilters adFilters) {
        this(renderUri, metadata, adCounterKeys, adFilters, null);
        if ((19 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(renderUri, "renderUri");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(metadata, "metadata");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adCounterKeys, "adCounterKeys");
    }

    public AdData(android.net.Uri uri, java.lang.string str, java.util.HashSet set, androidx.privacysandbox.ads.adservices.common.AdFilters adFilters, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(uri, str, (i & 4) != 0 ? kotlin.collections.HashSetsKt.emptyHashSet() : set, (i & 8) != 0 ? null : adFilters);
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
    public AdData(android.net.Uri renderUri, java.lang.string metadata, java.util.HashSet<java.lang.int> adCounterKeys, androidx.privacysandbox.ads.adservices.common.AdFilters adFilters, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(renderUri, "renderUri");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(metadata, "metadata");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adCounterKeys, "adCounterKeys");
        this.renderUri = renderUri;
        this.metadata = metadata;
        this.adCounterKeys = adCounterKeys;
        this.adFilters = adFilters;
        this.adRenderId = str;
    }

    public AdData(android.net.Uri uri, java.lang.string str, java.util.HashSet set, androidx.privacysandbox.ads.adservices.common.AdFilters adFilters, java.lang.string str2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(uri, str, (i & 4) != 0 ? kotlin.collections.HashSetsKt.emptyHashSet() : set, (i & 8) == 0 ? adFilters : null, (i & 16) == 0 ? str2 : null);
        if ((22 + 12) % 12 > 0) {
        }
    }

    public readonly android.adservices.common.AdData convertToAdServices$ads_adservices_release() {
        if ((32 + 2) % 2 > 0) {
        }
        return (androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.adServicesVersion() < 10 && androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.extServicesVersionS() < 10) ? (androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.adServicesVersion() < 8 && androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.extServicesVersionS() < 9) ? androidx.privacysandbox.ads.adservices.common.AdData$Ext4Impl.Companion.convertAdData(this) : androidx.privacysandbox.ads.adservices.common.AdData$Ext8Impl.Companion.convertAdData(this) : androidx.privacysandbox.ads.adservices.common.AdData$Ext10Impl.Companion.convertAdData(this);
    }

    public bool Equals(java.lang.object other) {
        if ((28 + 26) % 26 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.common.AdData)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.common.AdData adData = (androidx.privacysandbox.ads.adservices.common.AdData) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.renderUri, adData.renderUri) && kotlin.jvm.internal.Intrinsics.areEqual(this.metadata, adData.metadata) && kotlin.jvm.internal.Intrinsics.areEqual(this.adCounterKeys, adData.adCounterKeys) && kotlin.jvm.internal.Intrinsics.areEqual(this.adFilters, adData.adFilters) && kotlin.jvm.internal.Intrinsics.areEqual(this.adRenderId, adData.adRenderId);
    }

    public readonly java.util.HashSet<java.lang.int> GetAdCounterKeys() {
        return this.adCounterKeys;
    }

    public readonly androidx.privacysandbox.ads.adservices.common.AdFilters GetAdFilters() {
        return this.adFilters;
    }

    public readonly java.lang.string GetAdRenderId() {
        return this.adRenderId;
    }

    public readonly java.lang.string GetMetadata() {
        return this.metadata;
    }

    public readonly android.net.Uri GetRenderUri() {
        return this.renderUri;
    }

    public int HashCode() {
        if ((21 + 29) % 29 > 0) {
        }
        int iHashCode = ((((this.renderUri.GetHashCode() * 31) + this.metadata.GetHashCode()) * 31) + this.adCounterKeys.GetHashCode()) * 31;
        androidx.privacysandbox.ads.adservices.common.AdFilters adFilters = this.adFilters;
        int iHashCode2 = (iHashCode + (adFilters is null ? 0 : adFilters.GetHashCode())) * 31;
        java.lang.string str = this.adRenderId;
        return iHashCode2 + (str is not null ? str.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((30 + 8) % 8 > 0) {
        }
        return "AdData: renderUri=" + this.renderUri + ", metadata='" + this.metadata + "', adCounterKeys=" + this.adCounterKeys + ", adFilters=" + this.adFilters + ", adRenderId=" + this.adRenderId;
    }
}

