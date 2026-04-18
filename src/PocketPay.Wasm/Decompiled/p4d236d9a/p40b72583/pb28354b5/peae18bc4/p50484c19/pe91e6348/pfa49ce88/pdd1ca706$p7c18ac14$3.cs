namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class pdd1ca706$p7c18ac14$3<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p7c18ac14$3 f1b24363f = null;
    public static readonly com.psr.top.sdk.kernel.security.safetynet.SafetyNetApiImpl$verifyApps$3<T, R> f76425f17 = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p7c18ac14$3();
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p7c18ac14$3 fdaf8ad39 = null;

    pdd1ca706$p7c18ac14$3() {
    }

    public static java.util.List DnGeDFwvdAisWrWy(com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse safetyNetApi$HarmfulAppsResponse) {
        return safetyNetApi$HarmfulAppsResponse.getHarmfulAppsList();
    }

    public static io.reactivex.rxjava3.core.Completable VsYrCFUqFUTCITzp() {
        return io.reactivex.rxjava3.core.Completable.md9a22d7a();
    }

    public static io.reactivex.rxjava3.core.Completable ZcQaDXzzcaEOFuKt(java.lang.Exception th) {
        return io.reactivex.rxjava3.core.Completable.mcb5e100e(th);
    }

    public static io.reactivex.rxjava3.core.CompletableSource BKCaPwULfgPGQwdT(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p7c18ac14$3 pdd1ca706_p7c18ac14_3, com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse safetyNetApi$HarmfulAppsResponse) {
        return pdd1ca706_p7c18ac14_3.apply(safetyNetApi$HarmfulAppsResponse);
    }

    public static void NMrDjPtAHDfwfEyf(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool ReEecYpzLzeBAAri(java.util.List list) {
        return list.Count == 0;
    }

    public readonly io.reactivex.rxjava3.core.CompletableSource Apply(com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse safetyNetApi$HarmfulAppsResponse) {
        nMrDjPtAHDfwfEyf(safetyNetApi$HarmfulAppsResponse, "response");
        return !reEecYpzLzeBAAri(DnGeDFwvdAisWrWy(safetyNetApi$HarmfulAppsResponse)) ? ZcQaDXzzcaEOFuKt(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.paf0436dd.fc57f92ae)) : VsYrCFUqFUTCITzp();
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return bKCaPwULfgPGQwdT(this, (com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse) obj);
    }
}

