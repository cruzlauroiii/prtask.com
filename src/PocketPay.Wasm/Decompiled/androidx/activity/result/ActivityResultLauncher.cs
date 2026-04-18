namespace WillowMaze.Wasm.Decompiled;


public abstract class objectResultLauncher<I> {
    public static void McRdnFEyAOBxjqYt(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj, androidx.core.app.objectOptionsCompat activityOptionsCompat) {
        activityResultLauncher.launch(obj, activityOptionsCompat);
    }

    public static void McRdnFEyAOBxjqYt(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj, androidx.core.app.objectOptionsCompat activityOptionsCompat, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void McRdnFEyAOBxjqYt(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj, androidx.core.app.objectOptionsCompat activityOptionsCompat, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void McRdnFEyAOBxjqYt(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj, androidx.core.app.objectOptionsCompat activityOptionsCompat, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public abstract androidx.activity.result.contract.objectResultContract<I, object> GetContract();

    public void Launch(I i) {
        McRdnFEyAOBxjqYt(this, i, null);
    }

    public abstract void Launch(I i, androidx.core.app.objectOptionsCompat activityOptionsCompat);

    public abstract void Unregister();
}

