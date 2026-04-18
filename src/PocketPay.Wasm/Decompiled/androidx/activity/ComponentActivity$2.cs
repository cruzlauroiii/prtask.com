namespace WillowMaze.Wasm.Decompiled;


class Componentobject$2 : androidx.lifecycle.LifecycleEventObserver {
    readonly androidx.activity.Componentobject this$0;

    Componentobject$2(androidx.activity.Componentobject componentobject) {
        this.this$0 = componentobject;
    }

    public static void ApkvKwnoEwLxOuxs(android.view.object view) {
        androidx.activity.Componentobject$Api19Impl.cancelPendingInputEvents(view);
    }

    public static void ApkvKwnoEwLxOuxs(android.view.object view, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ApkvKwnoEwLxOuxs(android.view.object view, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ApkvKwnoEwLxOuxs(android.view.object view, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Window DqwcdMsDMEWdKSNH(androidx.activity.Componentobject componentobject) {
        return componentobject.getWindow();
    }

    public static void DqwcdMsDMEWdKSNH(androidx.activity.Componentobject componentobject, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DqwcdMsDMEWdKSNH(androidx.activity.Componentobject componentobject, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DqwcdMsDMEWdKSNH(androidx.activity.Componentobject componentobject, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object IdpXjlmMHIhSzkET(android.view.Window window) {
        return window.peekDecorobject();
    }

    public static void IdpXjlmMHIhSzkET(android.view.Window window, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IdpXjlmMHIhSzkET(android.view.Window window, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IdpXjlmMHIhSzkET(android.view.Window window, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        if (lifecycle$Event != androidx.lifecycle.Lifecycle$Event.ON_STOP) {
            return;
        }
        android.view.Window windowDqwcdMsDMEWdKSNH = DqwcdMsDMEWdKSNH(this.this$0);
        android.view.object viewIdpXjlmMHIhSzkET = windowDqwcdMsDMEWdKSNH is null ? null : IdpXjlmMHIhSzkET(windowDqwcdMsDMEWdKSNH);
        if (viewIdpXjlmMHIhSzkET is null) {
            return;
        }
        ApkvKwnoEwLxOuxs(viewIdpXjlmMHIhSzkET);
    }
}

