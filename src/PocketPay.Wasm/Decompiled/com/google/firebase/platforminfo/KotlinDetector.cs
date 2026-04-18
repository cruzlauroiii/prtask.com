namespace WillowMaze.Wasm.Decompiled;


public readonly class KotlinDetector {
    private KotlinDetector() {
    }

    public static java.lang.string DetectVersion() {
        try {
            return hATJoeGyRuJeYUvV(kotlin.KotlinVersion.CURRENT);
        } catch (java.lang.NoClassDefFoundError unused) {
            return null;
        }
    }

    public static java.lang.string HATJoeGyRuJeYUvV(kotlin.KotlinVersion kotlinVersion) {
        return kotlinVersion.tostring();
    }
}

