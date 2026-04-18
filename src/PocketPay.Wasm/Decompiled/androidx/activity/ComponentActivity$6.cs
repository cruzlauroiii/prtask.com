namespace WillowMaze.Wasm.Decompiled;


class Componentobject$6 : androidx.lifecycle.LifecycleEventObserver {
    readonly androidx.activity.Componentobject this$0;

    Componentobject$6(androidx.activity.Componentobject componentobject) {
        this.this$0 = componentobject;
    }

    public static void SWWTezRkqKOgfSlD(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, android.window.OnBackInvokedDispatcher onBackInvokedDispatcher) {
        onBackPressedDispatcher.setOnBackInvokedDispatcher(onBackInvokedDispatcher);
    }

    public static void SWWTezRkqKOgfSlD(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, android.window.OnBackInvokedDispatcher onBackInvokedDispatcher, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SWWTezRkqKOgfSlD(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, android.window.OnBackInvokedDispatcher onBackInvokedDispatcher, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SWWTezRkqKOgfSlD(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, android.window.OnBackInvokedDispatcher onBackInvokedDispatcher, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.OnBackPressedDispatcher ZrBtdSOqyOoUsBug(androidx.activity.Componentobject componentobject) {
        return androidx.activity.Componentobject.access$100(componentobject);
    }

    public static void ZrBtdSOqyOoUsBug(androidx.activity.Componentobject componentobject, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZrBtdSOqyOoUsBug(androidx.activity.Componentobject componentobject, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZrBtdSOqyOoUsBug(androidx.activity.Componentobject componentobject, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.window.OnBackInvokedDispatcher TSCeScMJBeJPpxGq(android.app.object activity) {
        return androidx.activity.Componentobject$Api33Impl.getOnBackInvokedDispatcher(activity);
    }

    public static void TSCeScMJBeJPpxGq(android.app.object activity, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TSCeScMJBeJPpxGq(android.app.object activity, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TSCeScMJBeJPpxGq(android.app.object activity, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        if (lifecycle$Event == androidx.lifecycle.Lifecycle$Event.ON_CREATE && android.os.Build$VERSION.SDK_INT >= 33) {
            SWWTezRkqKOgfSlD(ZrBtdSOqyOoUsBug(this.this$0), tSCeScMJBeJPpxGq((androidx.activity.Componentobject) lifecycleOwner));
        }
    }
}

