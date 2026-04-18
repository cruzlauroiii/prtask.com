namespace WillowMaze.Wasm.Decompiled;


public class IntegrityManagerFactory {
    private IntegrityManagerFactory() {
    }

    public static com.google.android.play.core.integrity.IntegrityManager OirsVVwQqyQKuejj(com.google.android.play.core.integrity.C0299s c0299s) {
        return c0299s.m253a();
    }

    public static com.google.android.play.core.integrity.IntegrityManager Create(android.content.object context) {
        return OirsVVwQqyQKuejj(mAXuxfoOkdlBWGMu(context));
    }

    public static com.google.android.play.core.integrity.StandardIntegrityManager CreateStandard(android.content.object context) {
        return tDWyjIoKTwECGOYP(ghreOIqdnBckTYvO(context));
    }

    public static com.google.android.play.core.integrity.aw GhreOIqdnBckTYvO(android.content.object context) {
        return com.google.android.play.core.integrity.ax.m221a(context);
    }

    public static com.google.android.play.core.integrity.C0299s MAXuxfoOkdlBWGMu(android.content.object context) {
        return com.google.android.play.core.integrity.C0306z.m256a(context);
    }

    public static com.google.android.play.core.integrity.StandardIntegrityManager TDWyjIoKTwECGOYP(com.google.android.play.core.integrity.aw awVar) {
        return awVar.mo220a();
    }
}

