namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class pdd1ca706$p7c18ac14$1<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 this$0;

    pdd1ca706$p7c18ac14$1(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var) {
        this.this$0 = pdd1ca706Var;
    }

    public static bool AJfeiCkSRnKuszYx(com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        return safetyNetApi$VerifyAppsUserResponse.isVerifyAppsEnabled();
    }

    public static io.reactivex.rxjava3.core.Single AIJadxRFEeriJaSy(java.lang.object obj) {
        return io.reactivex.rxjava3.core.Single.m8134b840(obj);
    }

    public static void GiubyRAYkxLRuWaA(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static io.reactivex.rxjava3.core.SingleSource IolnKdppGkXTSLCZ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p7c18ac14$1 pdd1ca706_p7c18ac14_1, com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        return pdd1ca706_p7c18ac14_1.apply(safetyNetApi$VerifyAppsUserResponse);
    }

    public static io.reactivex.rxjava3.core.Single TFZSeIVXfZyqEtPu(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706.m9c294318(pdd1ca706Var);
    }

    public static void VkoEEBnTXIJimuIy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly io.reactivex.rxjava3.core.SingleSource<? : com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse> apply(com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        io.reactivex.rxjava3.core.Single singleTFZSeIVXfZyqEtPu;
        vkoEEBnTXIJimuIy(safetyNetApi$VerifyAppsUserResponse, "response");
        if (AJfeiCkSRnKuszYx(safetyNetApi$VerifyAppsUserResponse)) {
            singleTFZSeIVXfZyqEtPu = aIJadxRFEeriJaSy(safetyNetApi$VerifyAppsUserResponse);
            giubyRAYkxLRuWaA(singleTFZSeIVXfZyqEtPu);
        } else {
            singleTFZSeIVXfZyqEtPu = tFZSeIVXfZyqEtPu(this.this$0);
        }
        return singleTFZSeIVXfZyqEtPu;
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return iolnKdppGkXTSLCZ(this, (com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse) obj);
    }
}

