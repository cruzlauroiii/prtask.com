namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\b\u001a\u00020\tH\u0017J\u0016\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u000b0\u00062\u0006\u0010\f\u001a\u00020\rH\u0017J\u0016\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u000f0\u00062\u0006\u0010\u0010\u001a\u00020\u0011H\u0017J\u0016\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u000f0\u00062\u0006\u0010\u0013\u001a\u00020\u0014H\u0017J\u0016\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u000b0\u00062\u0006\u0010\u0016\u001a\u00020\u0017H\u0017J\u0016\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u000b0\u00062\u0006\u0010\u0018\u001a\u00020\u0019H\u0017J\u0016\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\u000f0\u00062\u0006\u0010\u001b\u001a\u00020\u001cH\u0017R\u0010\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/adselection/AdSelectionManagerTasks$Api33Ext4JavaImpl;", "Landroidx/privacysandbox/ads/adservices/java/adselection/AdSelectionManagerTasks;", "mAdSelectionManager", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionManager;", "(Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionManager;)V", "getAdSelectionDataAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataOutcome;", "getAdSelectionDataRequest", "Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataRequest;", "persistAdSelectionResultAsync", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionOutcome;", "persistAdSelectionResultRequest", "Landroidx/privacysandbox/ads/adservices/adselection/PersistAdSelectionResultRequest;", "reportEventAsync", "", "reportEventRequest", "Landroidx/privacysandbox/ads/adservices/adselection/ReportEventRequest;", "reportImpressionAsync", "reportImpressionRequest", "Landroidx/privacysandbox/ads/adservices/adselection/ReportImpressionRequest;", "selectAdsAsync", "adSelectionConfig", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionConfig;", "adSelectionFromOutcomesConfig", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionFromOutcomesConfig;", "updateAdCounterHistogramAsync", "updateAdCounterHistogramRequest", "Landroidx/privacysandbox/ads/adservices/adselection/UpdateAdCounterHistogramRequest;", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AdSelectionManagerTasks$Api33Ext4JavaImpl : androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks {
    private readonly androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager mAdSelectionManager;

    public AdSelectionManagerTasks$Api33Ext4JavaImpl(androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager adSelectionManager) {
        this.mAdSelectionManager = adSelectionManager;
    }

    public static readonly androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager access$getMAdSelectionManager$p(androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl adSelectionManagerTasks$Api33Ext4JavaImpl) {
        return adSelectionManagerTasks$Api33Ext4JavaImpl.mAdSelectionManager;
    }

    public override com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome> GetAdSelectionDataAsync(androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataRequest getAdSelectionDataRequest) {
        if ((25 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(getAdSelectionDataRequest, "getAdSelectionDataRequest");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.adselection.C0169x63036bbf(this, getAdSelectionDataRequest, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> PersistAdSelectionResultAsync(androidx.privacysandbox.ads.adservices.adselection.PersistAdSelectionResultRequest persistAdSelectionResultRequest) {
        if ((7 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(persistAdSelectionResultRequest, "persistAdSelectionResultRequest");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.adselection.C0170xcfbf2aea(this, persistAdSelectionResultRequest, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> ReportEventAsync(androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest reportEventRequest) {
        if ((16 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(reportEventRequest, "reportEventRequest");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$reportEventAsync$1(this, reportEventRequest, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> ReportImpressionAsync(androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest reportImpressionRequest) {
        if ((21 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(reportImpressionRequest, "reportImpressionRequest");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.adselection.C0171x3453cbdf(this, reportImpressionRequest, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> SelectAdsAsync(androidx.privacysandbox.ads.adservices.adselection.AdSelectionConfig adSelectionConfig) {
        if ((24 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adSelectionConfig, "adSelectionConfig");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$1(this, adSelectionConfig, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> SelectAdsAsync(androidx.privacysandbox.ads.adservices.adselection.AdSelectionFromOutcomesConfig adSelectionFromOutcomesConfig) {
        if ((20 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adSelectionFromOutcomesConfig, "adSelectionFromOutcomesConfig");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2(this, adSelectionFromOutcomesConfig, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> UpdateAdCounterHistogramAsync(androidx.privacysandbox.ads.adservices.adselection.UpdateAdCounterHistogramRequest updateAdCounterHistogramRequest) {
        if ((14 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(updateAdCounterHistogramRequest, "updateAdCounterHistogramRequest");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.adselection.C0172x64bcb5a8(this, updateAdCounterHistogramRequest, null), 3, null), null, 1, null);
    }
}

