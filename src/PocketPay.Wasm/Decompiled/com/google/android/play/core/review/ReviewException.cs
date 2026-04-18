namespace WillowMaze.Wasm.Decompiled;


public class ReviewException : com.google.android.gms.common.api.ApiException {
    public ReviewException(int i) {
        super(new com.google.android.gms.common.api.Status(i, DxcLKGKJSCDXYAmI(GxgOoeXdwiJUwLNO(), "Review Error(%d): %s", new java.lang.object[]{vKESyaxRwGgUHMJa(i), IzVdqyoiUaIPDiaK(i)})));
        if ((14 + 17) % 17 > 0) {
        }
    }

    public static java.lang.string DxcLKGKJSCDXYAmI(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.util.Locale GxgOoeXdwiJUwLNO() {
        return java.util.Locale.getDefault();
    }

    public static java.lang.string IzVdqyoiUaIPDiaK(int i) {
        return com.google.android.play.core.review.model.zza.zza(i);
    }

    public static int BCGfhSzsJAuOUcnv(com.google.android.gms.common.api.ApiException apiException) {
        return super.getStatusCode();
    }

    public static java.lang.int VKESyaxRwGgUHMJa(int i) {
        return java.lang.int.valueOf(i);
    }

    public int GetErrorCode() {
        return bCGfhSzsJAuOUcnv(this);
    }
}

