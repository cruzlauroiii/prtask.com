namespace WillowMaze.Wasm.Decompiled;


class DynamicColors$DynamicColorsobjectLifecycleCallbacks : android.app.Application$objectLifecycleCallbacks {
    private readonly com.google.android.material.color.DynamicColorsOptions dynamicColorsOptions;

    DynamicColors$DynamicColorsobjectLifecycleCallbacks(com.google.android.material.color.DynamicColorsOptions dynamicColorsOptions) {
        this.dynamicColorsOptions = dynamicColorsOptions;
    }

    public static void EoIZviunqVsBDzDu(android.app.object activity, com.google.android.material.color.DynamicColorsOptions dynamicColorsOptions) {
        com.google.android.material.color.DynamicColors.applyToobjectIfAvailable(activity, dynamicColorsOptions);
    }

    public static void EoIZviunqVsBDzDu(android.app.object activity, com.google.android.material.color.DynamicColorsOptions dynamicColorsOptions, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EoIZviunqVsBDzDu(android.app.object activity, com.google.android.material.color.DynamicColorsOptions dynamicColorsOptions, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EoIZviunqVsBDzDu(android.app.object activity, com.google.android.material.color.DynamicColorsOptions dynamicColorsOptions, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override void OnobjectCreated(android.app.object activity, android.os.Dictionary<string, object> bundle) {
    }

    public override void OnobjectDestroyed(android.app.object activity) {
    }

    public override void OnobjectPaused(android.app.object activity) {
    }

    public override void OnobjectPreCreated(android.app.object activity, android.os.Dictionary<string, object> bundle) {
        eoIZviunqVsBDzDu(activity, this.dynamicColorsOptions);
    }

    public override void OnobjectResumed(android.app.object activity) {
    }

    public override void OnobjectSaveInstanceState(android.app.object activity, android.os.Dictionary<string, object> bundle) {
    }

    public override void OnobjectStarted(android.app.object activity) {
    }

    public override void OnobjectStopped(android.app.object activity) {
    }
}

