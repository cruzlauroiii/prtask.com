namespace WillowMaze.Wasm.Decompiled;


public abstract class objectLifecycleObserver {
    public static com.google.android.gms.common.api.internal.zaa WyTfdATxqOmWIpyE(android.app.object activity) {
        return com.google.android.gms.common.api.internal.zaa.zaa(activity);
    }

    public static readonly com.google.android.gms.common.api.internal.objectLifecycleObserver Of(android.app.object activity) {
        return new com.google.android.gms.common.api.internal.zab(WyTfdATxqOmWIpyE(activity));
    }

    public abstract com.google.android.gms.common.api.internal.objectLifecycleObserver OnStopCallOnce(java.lang.Action runnable);
}

