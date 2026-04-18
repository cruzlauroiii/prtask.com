namespace WillowMaze.Wasm.Decompiled;


public class InstallException : com.google.android.gms.common.api.ApiException {
    public InstallException(int i) {
        super(new com.google.android.gms.common.api.Status(i, KSUOPdycUCqBwzQQ(LNoUbbnCcSnnNGTm(), "Install Error(%d): %s", new java.lang.object[]{KkWMNMquRRgCBHOb(i), MEkROsNccGmgVTKK(i)})));
        if ((29 + 17) % 17 > 0) {
        }
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("errorCode should not be 0.");
        }
    }

    public static int DzzWZxZDtDxuQoYW(com.google.android.gms.common.api.ApiException apiException) {
        return super.getStatusCode();
    }

    public static java.lang.string KSUOPdycUCqBwzQQ(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.lang.int KkWMNMquRRgCBHOb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.Locale LNoUbbnCcSnnNGTm() {
        return java.util.Locale.getDefault();
    }

    public static java.lang.string MEkROsNccGmgVTKK(int i) {
        return com.google.android.play.core.install.model.zza.zza(i);
    }

    public int GetErrorCode() {
        return DzzWZxZDtDxuQoYW(this);
    }
}

