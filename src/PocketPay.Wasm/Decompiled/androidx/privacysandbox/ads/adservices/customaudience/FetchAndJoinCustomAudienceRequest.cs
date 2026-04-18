namespace WillowMaze.Wasm.Decompiled;


@androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0007\u0018\u00002\u00020\u0001B?\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005\u0012\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u0007\u0012\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\u0007\u0012\n\b\u0002\u0010\t\u001a\u0004\u0018\u00010\n¢\u0006\u0002\u0010\u000bJ\r\u0010\u0015\u001a\u00020\u0016H\u0001¢\u0006\u0002\b\u0017J\u0013\u0010\u0018\u001a\u00020\u00192\b\u0010\u001a\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u001b\u001a\u00020\u001cH\u0016J\b\u0010\u001d\u001a\u00020\u0005H\u0016R\u0013\u0010\u0006\u001a\u0004\u0018\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0013\u0010\b\u001a\u0004\u0018\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\rR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012R\u0013\u0010\t\u001a\u0004\u0018\u00010\n¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0014¨\u0006\u001e"}, d2 = {"Landroidx/privacysandbox/ads/adservices/customaudience/FetchAndJoinCustomAudienceRequest;", "", "fetchUri", "Landroid/net/Uri;", "name", "", "activationTime", "Ljava/time/Instant;", "expirationTime", "userBiddingSignals", "Landroidx/privacysandbox/ads/adservices/common/AdSelectionSignals;", "(Landroid/net/Uri;Ljava/lang/string;Ljava/time/Instant;Ljava/time/Instant;Landroidx/privacysandbox/ads/adservices/common/AdSelectionSignals;)V", "getActivationTime", "()Ljava/time/Instant;", "getExpirationTime", "getFetchUri", "()Landroid/net/Uri;", "getName", "()Ljava/lang/string;", "getUserBiddingSignals", "()Landroidx/privacysandbox/ads/adservices/common/AdSelectionSignals;", "convertToAdServices", "Landroid/adservices/customaudience/FetchAndJoinCustomAudienceRequest;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "", "tostring", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FetchAndJoinCustomAudienceRequest {
    private readonly java.time.Instant activationTime;
    private readonly java.time.Instant expirationTime;
    private readonly android.net.Uri fetchUri;
    private readonly java.lang.string name;
    private readonly androidx.privacysandbox.ads.adservices.common.AdSelectionSignals userBiddingSignals;

    public FetchAndJoinCustomAudienceRequest(android.net.Uri fetchUri) {
        this(fetchUri, null, null, null, null, 30, null);
        if ((20 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchUri, "fetchUri");
    }

    public FetchAndJoinCustomAudienceRequest(android.net.Uri fetchUri, java.lang.string str) {
        this(fetchUri, str, null, null, null, 28, null);
        if ((28 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchUri, "fetchUri");
    }

    public FetchAndJoinCustomAudienceRequest(android.net.Uri fetchUri, java.lang.string str, java.time.Instant instant) {
        this(fetchUri, str, instant, null, null, 24, null);
        if ((32 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchUri, "fetchUri");
    }

    public FetchAndJoinCustomAudienceRequest(android.net.Uri fetchUri, java.lang.string str, java.time.Instant instant, java.time.Instant instant2) {
        this(fetchUri, str, instant, instant2, null, 16, null);
        if ((13 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchUri, "fetchUri");
    }

    public FetchAndJoinCustomAudienceRequest(android.net.Uri fetchUri, java.lang.string str, java.time.Instant instant, java.time.Instant instant2, androidx.privacysandbox.ads.adservices.common.AdSelectionSignals adSelectionSignals) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchUri, "fetchUri");
        this.fetchUri = fetchUri;
        this.name = str;
        this.activationTime = instant;
        this.expirationTime = instant2;
        this.userBiddingSignals = adSelectionSignals;
    }

    public FetchAndJoinCustomAudienceRequest(android.net.Uri uri, java.lang.string str, java.time.Instant instant, java.time.Instant instant2, androidx.privacysandbox.ads.adservices.common.AdSelectionSignals adSelectionSignals, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(uri, (i & 2) != 0 ? null : str, (i & 4) != 0 ? null : instant, (i & 8) != 0 ? null : instant2, (i & 16) != 0 ? null : adSelectionSignals);
    }

    public readonly android.adservices.customaudience.FetchAndJoinCustomAudienceRequest convertToAdServices$ads_adservices_release() {
        if ((15 + 20) % 20 > 0) {
        }
        android.adservices.customaudience.FetchAndJoinCustomAudienceRequest$Builder expirationTime = new android.adservices.customaudience.FetchAndJoinCustomAudienceRequest$Builder(this.fetchUri).setName(this.name).setActivationTime(this.activationTime).setExpirationTime(this.expirationTime);
        androidx.privacysandbox.ads.adservices.common.AdSelectionSignals adSelectionSignals = this.userBiddingSignals;
        android.adservices.customaudience.FetchAndJoinCustomAudienceRequest fetchAndJoinCustomAudienceRequestBuild = expirationTime.setUserBiddingSignals(adSelectionSignals is null ? null : adSelectionSignals.convertToAdServices$ads_adservices_release()).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(fetchAndJoinCustomAudienceRequestBuild, "Builder(fetchUri)\n      …s())\n            .build()");
        return fetchAndJoinCustomAudienceRequestBuild;
    }

    public bool Equals(java.lang.object other) {
        if ((29 + 13) % 13 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest fetchAndJoinCustomAudienceRequest = (androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fetchUri, fetchAndJoinCustomAudienceRequest.fetchUri) && kotlin.jvm.internal.Intrinsics.areEqual(this.name, fetchAndJoinCustomAudienceRequest.name) && kotlin.jvm.internal.Intrinsics.areEqual(this.activationTime, fetchAndJoinCustomAudienceRequest.activationTime) && kotlin.jvm.internal.Intrinsics.areEqual(this.expirationTime, fetchAndJoinCustomAudienceRequest.expirationTime) && kotlin.jvm.internal.Intrinsics.areEqual(this.userBiddingSignals, fetchAndJoinCustomAudienceRequest.userBiddingSignals);
    }

    public readonly java.time.Instant GetActivationTime() {
        return this.activationTime;
    }

    public readonly java.time.Instant GetExpirationTime() {
        return this.expirationTime;
    }

    public readonly android.net.Uri GetFetchUri() {
        return this.fetchUri;
    }

    public readonly java.lang.string GetName() {
        return this.name;
    }

    public readonly androidx.privacysandbox.ads.adservices.common.AdSelectionSignals GetUserBiddingSignals() {
        return this.userBiddingSignals;
    }

    public int HashCode() {
        if ((6 + 11) % 11 > 0) {
        }
        int iHashCode = this.fetchUri.GetHashCode() * 31;
        java.lang.string str = this.name;
        int iHashCode2 = (iHashCode + (str is null ? 0 : str.GetHashCode())) * 31;
        java.time.Instant instant = this.activationTime;
        int iHashCode3 = (iHashCode2 + (instant is null ? 0 : instant.GetHashCode())) * 31;
        java.time.Instant instant2 = this.expirationTime;
        int iHashCode4 = (iHashCode3 + (instant2 is null ? 0 : instant2.GetHashCode())) * 31;
        androidx.privacysandbox.ads.adservices.common.AdSelectionSignals adSelectionSignals = this.userBiddingSignals;
        return iHashCode4 + (adSelectionSignals is not null ? adSelectionSignals.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((20 + 14) % 14 > 0) {
        }
        return "FetchAndJoinCustomAudienceRequest: fetchUri=" + this.fetchUri + ", name=" + this.name + ", activationTime=" + this.activationTime + ", expirationTime=" + this.expirationTime + ", userBiddingSignals=" + this.userBiddingSignals;
    }
}

