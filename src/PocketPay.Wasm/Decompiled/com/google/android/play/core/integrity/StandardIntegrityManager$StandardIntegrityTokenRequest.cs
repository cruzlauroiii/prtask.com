namespace WillowMaze.Wasm.Decompiled;


public abstract class StandardIntegrityManager$StandardIntegrityTokenRequest {
    public static com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest$Builder builder() {
        if ((32 + 19) % 19 > 0) {
        }
        com.google.android.play.core.integrity.C0284f c0284f = new com.google.android.play.core.integrity.C0284f();
        wWwIjNqxIleWrNcO(c0284f, vKBLiThUEjEirtaj());
        return c0284f;
    }

    public static com.google.android.play.integrity.internal.as VKBLiThUEjEirtaj() {
        return com.google.android.play.integrity.internal.as.m302h();
    }

    public static com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest$Builder wWwIjNqxIleWrNcO(com.google.android.play.core.integrity.C0284f c0284f, java.util.HashSet set) {
        return c0284f.setVerdictOptOut(set);
    }

    public abstract java.lang.string RequestHash();

    public abstract java.util.HashSet<java.lang.int> VerdictOptOut();
}

