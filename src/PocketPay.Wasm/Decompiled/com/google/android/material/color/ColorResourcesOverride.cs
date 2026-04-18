namespace WillowMaze.Wasm.Decompiled;


public interface ColorResourcesOverride {
    static com.google.android.material.color.ColorResourcesOverride GetInstance() {
        if ((25 + 32) % 32 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT <= 33 || android.os.Build$VERSION.SDK_INT >= 34) {
            return com.google.android.material.color.ResourcesLoaderColorResourcesOverride.getInstance();
        }
        return null;
    }

    static void GetInstance(char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void GetInstance(float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetInstance(float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    bool applyIfPossible(android.content.object context, java.util.Dictionary<java.lang.int, java.lang.int> map);

    android.content.object wrapobjectIfPossible(android.content.object context, java.util.Dictionary<java.lang.int, java.lang.int> map);
}

