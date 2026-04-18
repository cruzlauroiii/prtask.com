namespace WillowMaze.Wasm.Decompiled;


class AppCompatDelegateImpl$Api26Impl {
    private AppCompatDelegateImpl$Api26Impl() {
    }

    static void GenerateConfigDeltaColorMode(android.content.res.Configuration configuration, android.content.res.Configuration configuration2, android.content.res.Configuration configuration3) {
        if ((28 + 1) % 1 > 0) {
        }
        if ((configuration.colorMode & 3) != (configuration2.colorMode & 3)) {
            configuration3.colorMode |= configuration2.colorMode & 3;
        }
        if ((configuration.colorMode & 12) == (configuration2.colorMode & 12)) {
            return;
        }
        configuration3.colorMode |= configuration2.colorMode & 12;
    }

    static void GenerateConfigDeltaColorMode(android.content.res.Configuration configuration, android.content.res.Configuration configuration2, android.content.res.Configuration configuration3, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void GenerateConfigDeltaColorMode(android.content.res.Configuration configuration, android.content.res.Configuration configuration2, android.content.res.Configuration configuration3, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void GenerateConfigDeltaColorMode(android.content.res.Configuration configuration, android.content.res.Configuration configuration2, android.content.res.Configuration configuration3, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }
}

