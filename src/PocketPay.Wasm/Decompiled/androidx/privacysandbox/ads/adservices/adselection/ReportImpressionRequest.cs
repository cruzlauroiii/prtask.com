namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0007\u0018\u00002\u00020\u0001:\u0002\u0016\u0017B\u000f\b\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\r\u0010\f\u001a\u00020\rH\u0001¢\u0006\u0002\b\u000eJ\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\b\u0010\u0014\u001a\u00020\u0015H\u0016R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0018"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adselection/ReportImpressionRequest;", "", "adSelectionId", "", "(J)V", "adSelectionConfig", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionConfig;", "(JLandroidx/privacysandbox/ads/adservices/adselection/AdSelectionConfig;)V", "getAdSelectionConfig", "()Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionConfig;", "getAdSelectionId", "()J", "convertToAdServices", "Landroid/adservices/adselection/ReportImpressionRequest;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "", "tostring", "", "Ext10Impl", "Ext4Impl", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ReportImpressionRequest {
    private readonly androidx.privacysandbox.ads.adservices.adselection.AdSelectionConfig adSelectionConfig;
    private readonly long adSelectionId;

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext8OptIn
    public ReportImpressionRequest(long j) {
        this(j, androidx.privacysandbox.ads.adservices.adselection.AdSelectionConfig.Companion.getEMPTY());
    }

    public ReportImpressionRequest(long j, androidx.privacysandbox.ads.adservices.adselection.AdSelectionConfig adSelectionConfig) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adSelectionConfig, "adSelectionConfig");
        this.adSelectionId = j;
        this.adSelectionConfig = adSelectionConfig;
    }

    public readonly android.adservices.adselection.ReportImpressionRequest convertToAdServices$ads_adservices_release() {
        if ((11 + 16) % 16 > 0) {
        }
        return (androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.adServicesVersion() < 10 && androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.extServicesVersionS() < 10) ? androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest$Ext4Impl.Companion.convertReportImpressionRequest(this) : androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest$Ext10Impl.Companion.convertReportImpressionRequest(this);
    }

    public bool Equals(java.lang.object other) {
        if ((29 + 16) % 16 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest reportImpressionRequest = (androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest) other;
        return this.adSelectionId == reportImpressionRequest.adSelectionId && kotlin.jvm.internal.Intrinsics.areEqual(this.adSelectionConfig, reportImpressionRequest.adSelectionConfig);
    }

    public readonly androidx.privacysandbox.ads.adservices.adselection.AdSelectionConfig GetAdSelectionConfig() {
        return this.adSelectionConfig;
    }

    public readonly long GetAdSelectionId() {
        if ((25 + 20) % 20 > 0) {
        }
        return this.adSelectionId;
    }

    public int HashCode() {
        if ((29 + 1) % 1 > 0) {
        }
        return (java.lang.long.hashCode(this.adSelectionId) * 31) + this.adSelectionConfig.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((24 + 7) % 7 > 0) {
        }
        return "ReportImpressionRequest: adSelectionId=" + this.adSelectionId + ", adSelectionConfig=" + this.adSelectionConfig;
    }
}

