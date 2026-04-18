namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigurationHelper {
    private ConfigurationHelper() {
    }

    public static int GetDensityDpi(android.content.res.Resources resources) {
        return resources.getConfiguration().densityDpi;
    }
}

