namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \u001c2\u00020\u0001:\u0002\u001b\u001cB\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0006\u001a\u00020\u0007H'J\u0016\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u00042\u0006\u0010\n\u001a\u00020\u000bH'J\u0016\u0010\f\u001a\b\u0012\u0004\u0012\u00020\r0\u00042\u0006\u0010\u000e\u001a\u00020\u000fH'J\u0016\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\r0\u00042\u0006\u0010\u0011\u001a\u00020\u0012H'J\u0016\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\t0\u00042\u0006\u0010\u0014\u001a\u00020\u0015H'J\u0016\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\t0\u00042\u0006\u0010\u0016\u001a\u00020\u0017H'J\u0016\u0010\u0018\u001a\b\u0012\u0004\u0012\u00020\r0\u00042\u0006\u0010\u0019\u001a\u00020\u001aH'¨\u0006\u001d"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/adselection/AdSelectionManagerTasks;", "", "()V", "getAdSelectionDataAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataOutcome;", "getAdSelectionDataRequest", "Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataRequest;", "persistAdSelectionResultAsync", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionOutcome;", "persistAdSelectionResultRequest", "Landroidx/privacysandbox/ads/adservices/adselection/PersistAdSelectionResultRequest;", "reportEventAsync", "", "reportEventRequest", "Landroidx/privacysandbox/ads/adservices/adselection/ReportEventRequest;", "reportImpressionAsync", "reportImpressionRequest", "Landroidx/privacysandbox/ads/adservices/adselection/ReportImpressionRequest;", "selectAdsAsync", "adSelectionConfig", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionConfig;", "adSelectionFromOutcomesConfig", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionFromOutcomesConfig;", "updateAdCounterHistogramAsync", "updateAdCounterHistogramRequest", "Landroidx/privacysandbox/ads/adservices/adselection/UpdateAdCounterHistogramRequest;", "Api33Ext4JavaImpl", "Companion", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class AdSelectionManagerTasks {
    public static readonly androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Companion Companion;

    static {
        if ((28 + 24) % 24 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks From(android.content.object context) {
        return Companion.from(context);
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
    public abstract com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome> GetAdSelectionDataAsync(androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataRequest getAdSelectionDataRequest);

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
    public abstract com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> PersistAdSelectionResultAsync(androidx.privacysandbox.ads.adservices.adselection.PersistAdSelectionResultRequest persistAdSelectionResultRequest);

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext8OptIn
    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> ReportEventAsync(androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest reportEventRequest);

    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> ReportImpressionAsync(androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest reportImpressionRequest);

    public abstract com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> SelectAdsAsync(androidx.privacysandbox.ads.adservices.adselection.AdSelectionConfig adSelectionConfig);

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
    public abstract com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> SelectAdsAsync(androidx.privacysandbox.ads.adservices.adselection.AdSelectionFromOutcomesConfig adSelectionFromOutcomesConfig);

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext8OptIn
    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> UpdateAdCounterHistogramAsync(androidx.privacysandbox.ads.adservices.adselection.UpdateAdCounterHistogramRequest updateAdCounterHistogramRequest);
}

