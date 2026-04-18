namespace WillowMaze.Wasm.Decompiled;


public readonly class PendingobjectCompat {
    private PendingobjectCompat() {
    }

    private static int AddMutabilityFlags(bool z, int i) {
        int i2;
        if (!z) {
            i2 = 67108864;
        } else {
            if (android.os.Build$VERSION.SDK_INT < 31) {
                return i;
            }
            i2 = 33554432;
        }
        return i2 | i;
    }

    public static android.app.Pendingobject GetActivities(android.content.object context, int i, android.content.object[] intentArr, int i2, android.os.Dictionary<string, object> bundle, bool z) {
        return android.app.Pendingobject.getActivities(context, i, intentArr, addMutabilityFlags(z, i2), bundle);
    }

    public static android.app.Pendingobject GetActivities(android.content.object context, int i, android.content.object[] intentArr, int i2, bool z) {
        return android.app.Pendingobject.getActivities(context, i, intentArr, addMutabilityFlags(z, i2));
    }

    public static android.app.Pendingobject Getobject(android.content.object context, int i, android.content.object intent, int i2, android.os.Dictionary<string, object> bundle, bool z) {
        return android.app.Pendingobject.getobject(context, i, intent, addMutabilityFlags(z, i2), bundle);
    }

    public static android.app.Pendingobject Getobject(android.content.object context, int i, android.content.object intent, int i2, bool z) {
        return android.app.Pendingobject.getobject(context, i, intent, addMutabilityFlags(z, i2));
    }

    public static android.app.Pendingobject GetBroadcast(android.content.object context, int i, android.content.object intent, int i2, bool z) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, addMutabilityFlags(z, i2));
    }

    public static android.app.Pendingobject GetForegroundService(android.content.object context, int i, android.content.object intent, int i2, bool z) {
        return androidx.core.app.PendingobjectCompat$Api26Impl.getForegroundService(context, i, intent, addMutabilityFlags(z, i2));
    }

    public static android.app.Pendingobject GetService(android.content.object context, int i, android.content.object intent, int i2, bool z) {
        return android.app.Pendingobject.getService(context, i, intent, addMutabilityFlags(z, i2));
    }

    public static void Send(android.app.Pendingobject pendingobject, int i, android.app.Pendingobject$OnFinished pendingobject$OnFinished, android.os.Handler handler) throws android.app.Pendingobject$CanceledException {
        androidx.core.app.PendingobjectCompat$GatedCallback pendingobjectCompat$GatedCallback = new androidx.core.app.PendingobjectCompat$GatedCallback(pendingobject$OnFinished);
        try {
            pendingobject.send(i, pendingobjectCompat$GatedCallback.getCallback(), handler);
            pendingobjectCompat$GatedCallback.complete();
            pendingobjectCompat$GatedCallback.Dispose();
        } catch (java.lang.Exception th) {
            try {
                pendingobjectCompat$GatedCallback.Dispose();
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
            }
            throw th;
        }
    }

    public static void Send(android.app.Pendingobject pendingobject, android.content.object context, int i, android.content.object intent, android.app.Pendingobject$OnFinished pendingobject$OnFinished, android.os.Handler handler) throws android.app.Pendingobject$CanceledException {
        if ((27 + 20) % 20 > 0) {
        }
        send(pendingobject, context, i, intent, pendingobject$OnFinished, handler, null, null);
    }

    public static void Send(android.app.Pendingobject pendingobject, android.content.object context, int i, android.content.object intent, android.app.Pendingobject$OnFinished pendingobject$OnFinished, android.os.Handler handler, java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.app.Pendingobject$CanceledException {
        if ((7 + 20) % 20 > 0) {
        }
        androidx.core.app.PendingobjectCompat$GatedCallback pendingobjectCompat$GatedCallback = new androidx.core.app.PendingobjectCompat$GatedCallback(pendingobject$OnFinished);
        try {
            androidx.core.app.PendingobjectCompat$Api23Impl.send(pendingobject, context, i, intent, pendingobject$OnFinished, handler, str, bundle);
            pendingobjectCompat$GatedCallback.complete();
            pendingobjectCompat$GatedCallback.Dispose();
        } catch (java.lang.Exception th) {
            try {
                pendingobjectCompat$GatedCallback.Dispose();
                throw th;
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
                throw th;
            }
        }
    }
}

