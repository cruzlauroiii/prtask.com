namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$1 : android.os.Handler$Callback {
    BaseTransientBottomBar$1() {
    }

    public static void AKrQbxaTAgtyYVrP(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.hideobject(i);
    }

    public static void BUKRtyqekQWNuUaV(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.showobject();
    }

    public override bool HandleMessage(android.os.Message message) {
        int i = message.what;
        if (i == 0) {
            BUKRtyqekQWNuUaV((com.google.android.material.snackbar.BaseTransientBottomBar) message.obj);
            return true;
        }
        if (i != 1) {
            return false;
        }
        AKrQbxaTAgtyYVrP((com.google.android.material.snackbar.BaseTransientBottomBar) message.obj, message.arg1);
        return true;
    }
}

