namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class pdd1ca706$p7c18ac14$2<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 this$0;

    pdd1ca706$p7c18ac14$2(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var) {
        this.this$0 = pdd1ca706Var;
    }

    public static void FlnAlucLzLskSBgx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.SingleSource MtrjDnChLOcfygjc(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p7c18ac14$2 pdd1ca706_p7c18ac14_2, com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        return pdd1ca706_p7c18ac14_2.apply(safetyNetApi$VerifyAppsUserResponse);
    }

    public static bool TQJoDdgWFluboSbu(com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        return safetyNetApi$VerifyAppsUserResponse.isVerifyAppsEnabled();
    }

    public static io.reactivex.rxjava3.core.Single QnqhruCoykmUIstx(java.lang.Exception th) {
        return io.reactivex.rxjava3.core.Single.mcb5e100e(th);
    }

    public static void RtMzGvwVmPhgnpgm(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static io.reactivex.rxjava3.core.Single SOXBWrJJhYQZrxCz(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706.m0704853a(pdd1ca706Var);
    }

    public readonly io.reactivex.rxjava3.core.SingleSource<? : com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse> apply(com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        io.reactivex.rxjava3.core.Single singleQnqhruCoykmUIstx;
        FlnAlucLzLskSBgx(safetyNetApi$VerifyAppsUserResponse, "response");
        if (TQJoDdgWFluboSbu(safetyNetApi$VerifyAppsUserResponse)) {
            singleQnqhruCoykmUIstx = sOXBWrJJhYQZrxCz(this.this$0);
        } else {
            singleQnqhruCoykmUIstx = qnqhruCoykmUIstx(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.paf0436dd.fcbb62442));
            rtMzGvwVmPhgnpgm(singleQnqhruCoykmUIstx);
        }
        return singleQnqhruCoykmUIstx;
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return MtrjDnChLOcfygjc(this, (com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse) obj);
    }
}

