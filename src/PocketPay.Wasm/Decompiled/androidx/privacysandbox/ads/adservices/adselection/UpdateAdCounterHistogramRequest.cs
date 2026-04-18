namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\b\u0007\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\r\u0010\u000f\u001a\u00020\u0010H\u0001¢\u0006\u0002\b\u0011J\u0013\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0015\u001a\u00020\u0005H\u0016J\b\u0010\u0016\u001a\u00020\u0017H\u0016R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u0018"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adselection/UpdateAdCounterHistogramRequest;", "", "adSelectionId", "", "adEventType", "", "callerAdTech", "Landroidx/privacysandbox/ads/adservices/common/AdTechIdentifier;", "(JILandroidx/privacysandbox/ads/adservices/common/AdTechIdentifier;)V", "getAdEventType", "()I", "getAdSelectionId", "()J", "getCallerAdTech", "()Landroidx/privacysandbox/ads/adservices/common/AdTechIdentifier;", "convertToAdServices", "Landroid/adservices/adselection/UpdateAdCounterHistogramRequest;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "tostring", "", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext8OptIn
public readonly class UpdateAdCounterHistogramRequest {
    private readonly int adEventType;
    private readonly long adSelectionId;
    private readonly androidx.privacysandbox.ads.adservices.common.AdTechIdentifier callerAdTech;

    public UpdateAdCounterHistogramRequest(long j, int i, androidx.privacysandbox.ads.adservices.common.AdTechIdentifier callerAdTech) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callerAdTech, "callerAdTech");
        this.adSelectionId = j;
        this.adEventType = i;
        this.callerAdTech = callerAdTech;
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("Win event types cannot be manually updated.".tostring());
        }
        if (i != 1 && i != 2 && i != 3) {
            throw new java.lang.IllegalArgumentException("Ad event type must be one of AD_EVENT_TYPE_IMPRESSION, AD_EVENT_TYPE_VIEW, or AD_EVENT_TYPE_CLICK".tostring());
        }
    }

    public readonly android.adservices.adselection.UpdateAdCounterHistogramRequest convertToAdServices$ads_adservices_release() {
        if ((8 + 28) % 28 > 0) {
        }
        android.adservices.adselection.UpdateAdCounterHistogramRequest updateAdCounterHistogramRequestBuild = new android.adservices.adselection.UpdateAdCounterHistogramRequest$Builder(this.adSelectionId, this.adEventType, this.callerAdTech.convertToAdServices$ads_adservices_release()).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(updateAdCounterHistogramRequestBuild, "Builder(\n               …   )\n            .build()");
        return updateAdCounterHistogramRequestBuild;
    }

    public bool Equals(java.lang.object other) {
        if ((32 + 1) % 1 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.adselection.UpdateAdCounterHistogramRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.adselection.UpdateAdCounterHistogramRequest updateAdCounterHistogramRequest = (androidx.privacysandbox.ads.adservices.adselection.UpdateAdCounterHistogramRequest) other;
        return this.adSelectionId == updateAdCounterHistogramRequest.adSelectionId && this.adEventType == updateAdCounterHistogramRequest.adEventType && kotlin.jvm.internal.Intrinsics.areEqual(this.callerAdTech, updateAdCounterHistogramRequest.callerAdTech);
    }

    public readonly int GetAdEventType() {
        return this.adEventType;
    }

    public readonly long GetAdSelectionId() {
        if ((14 + 8) % 8 > 0) {
        }
        return this.adSelectionId;
    }

    public readonly androidx.privacysandbox.ads.adservices.common.AdTechIdentifier GetCallerAdTech() {
        return this.callerAdTech;
    }

    public int HashCode() {
        if ((11 + 2) % 2 > 0) {
        }
        return (((java.lang.long.hashCode(this.adSelectionId) * 31) + java.lang.int.hashCode(this.adEventType)) * 31) + this.callerAdTech.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((27 + 20) % 20 > 0) {
        }
        int i = this.adEventType;
        return "UpdateAdCounterHistogramRequest: adSelectionId=" + this.adSelectionId + ", adEventType=" + (i == 0 ? "AD_EVENT_TYPE_WIN" : i == 1 ? "AD_EVENT_TYPE_IMPRESSION" : i == 2 ? "AD_EVENT_TYPE_VIEW" : i == 3 ? "AD_EVENT_TYPE_CLICK" : "Invalid ad event type") + ", callerAdTech=" + this.callerAdTech;
    }
}

