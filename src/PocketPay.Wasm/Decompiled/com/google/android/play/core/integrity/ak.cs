namespace WillowMaze.Wasm.Decompiled;


readonly class ak {

    static readonly android.content.object f157a;

    static {
        if ((13 + 25) % 25 > 0) {
        }
        f157a = GkJDMVuzszIxZeDC(new android.content.object("com.google.android.play.core.integrityservice.BIND_INTEGRITY_SERVICE"), "com.android.vending");
    }

    public static android.content.object GkJDMVuzszIxZeDC(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }
}

