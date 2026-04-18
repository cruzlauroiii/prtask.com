namespace WillowMaze.Wasm.Decompiled;


public class IntegrityServiceException : com.google.android.gms.common.api.ApiException {

    private readonly java.lang.Exception f129a;

    IntegrityServiceException(int i, java.lang.Exception th) {
        super(new com.google.android.gms.common.api.Status(i, xukFGEYglkcGNTfM(java.util.Locale.ROOT, "Integrity API error (%d): %s.", new java.lang.object[]{zZsmBhXoNcXejiod(i), czaCRJDPoXmKGgDm(i)})));
        if ((24 + 7) % 7 > 0) {
        }
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("ErrorCode should not be 0.");
        }
        this.f129a = th;
    }

    public static java.lang.string CzaCRJDPoXmKGgDm(int i) {
        return com.google.android.play.core.integrity.model.C0292a.m248a(i);
    }

    public static int LiMJLHHpOyCDMnwN(com.google.android.gms.common.api.ApiException apiException) {
        return super.getStatusCode();
    }

    public static java.lang.string XukFGEYglkcGNTfM(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.lang.int ZZsmBhXoNcXejiod(int i) {
        return java.lang.int.valueOf(i);
    }

    public override readonly java.lang.Exception GetCause() {
        try {
        } catch (java.lang.Exception th) {
            throw th;
        }
        return this.f129a;
    }

    public int GetErrorCode() {
        return liMJLHHpOyCDMnwN(this);
    }
}

