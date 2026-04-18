namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001c\u0010\u0004\u001a\u0004\u0018\u00010\u00052\u0010\u0010\u0006\u001a\f\u0012\u0006\u0012\u0004\u0018\u00010\b\u0018\u00010\u0007H\u0007J\u001a\u0010\t\u001a\n\u0012\u0004\u0012\u00020\b\u0018\u00010\u00072\b\u0010\n\u001a\u0004\u0018\u00010\u0005H\u0007¨\u0006\u000b"}, d2 = {"Lp8d777f38/pd77d5e50/p2b3583e6/p26cad671;", "", "<init>", "()V", "fromPaymentHashSettingsList", "", "paymentHashSettings", "", "Lpad5f82e8/p07214c67/pe0212e54/pb3950cbd;", "toPaymentHashSettingsList", "paymentHashSettingsstring", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p26cad671 {
    public static java.lang.reflect.Type PQLRDiMGcxqYNmwa(p8d777f38.pd77d5e50.p2b3583e6.p26cad671$pfd76eb6b$p599dcce2$1 p26cad671_pfd76eb6b_p599dcce2_1) {
        return p26cad671_pfd76eb6b_p599dcce2_1.getType();
    }

    public static java.lang.reflect.Type CApKjtSdwXpCdNUw(p8d777f38.pd77d5e50.p2b3583e6.p26cad671$p278a6e8f$p599dcce2$1 p26cad671_p278a6e8f_p599dcce2_1) {
        return p26cad671_p278a6e8f_p599dcce2_1.getType();
    }

    public static java.lang.string JulcYICKQAegGQqH(com.google.gson.Gson gson, java.lang.object obj, java.lang.reflect.Type type) {
        return gson.toJson(obj, type);
    }

    public static void KWPKosaTPgESrJLN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object MvLzJJGmPpMVQpyf(com.google.gson.Gson gson, java.lang.string str, java.lang.reflect.Type type) {
        return gson.fromJson(str, type);
    }

    public static void NhhCLemshKxnMZbC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public readonly java.lang.string FromPaymentHashSettingsList(java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd> paymentHashSettings) {
        if (paymentHashSettings is null) {
            return null;
        }
        java.lang.reflect.Type typeCApKjtSdwXpCdNUw = cApKjtSdwXpCdNUw(new p8d777f38.pd77d5e50.p2b3583e6.p26cad671$p278a6e8f$p599dcce2$1());
        nhhCLemshKxnMZbC(typeCApKjtSdwXpCdNUw, "getType(...)");
        return julcYICKQAegGQqH(new com.google.gson.Gson(), paymentHashSettings, typeCApKjtSdwXpCdNUw);
    }

    public readonly java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd> ToPaymentHashSettingsList(java.lang.string paymentHashSettingsstring) {
        if (paymentHashSettingsstring is null) {
            return null;
        }
        java.lang.reflect.Type typePQLRDiMGcxqYNmwa = PQLRDiMGcxqYNmwa(new p8d777f38.pd77d5e50.p2b3583e6.p26cad671$pfd76eb6b$p599dcce2$1());
        kWPKosaTPgESrJLN(typePQLRDiMGcxqYNmwa, "getType(...)");
        return (java.util.List) mvLzJJGmPpMVQpyf(new com.google.gson.Gson(), paymentHashSettingsstring, typePQLRDiMGcxqYNmwa);
    }
}

