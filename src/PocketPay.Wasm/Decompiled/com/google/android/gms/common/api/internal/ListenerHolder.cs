namespace WillowMaze.Wasm.Decompiled;


public readonly class ListenerHolder<L> {
    private readonly java.util.concurrent.Executor zaa;
    private java.lang.object zab;
    private com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey zac;

    ListenerHolder(android.os.Looper looper, L l, java.lang.string str) {
        this.zaa = new com.google.android.gms.common.util.concurrent.HandlerExecutor(looper);
        this.zab = KLSpIPsDeozeRpga(l, "Listener must not be null");
        this.zac = new com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey(l, DzzQnaYzfMHLJQuF(str));
    }

    ListenerHolder(java.util.concurrent.Executor executor, L l, java.lang.string str) {
        this.zaa = (java.util.concurrent.Executor) OkteNnRujPXVymqI(executor, "Executor must not be null");
        this.zab = wzeOKikJmjYLpzdw(l, "Listener must not be null");
        this.zac = new com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey(l, ZmqLHfVqUVkdhrWm(str));
    }

    public static void ALyAiACIzQQdeHlA(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static void AyvWwSUhZMHXBvKz(com.google.android.gms.common.api.internal.ListenerHolder$Notifier listenerHolder$Notifier) {
        listenerHolder$Notifier.onNotifyListenerFailed();
    }

    public static java.lang.string DzzQnaYzfMHLJQuF(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.object KLSpIPsDeozeRpga(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object OkteNnRujPXVymqI(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void PgUWbkYGzRBCOseN(com.google.android.gms.common.api.internal.ListenerHolder$Notifier listenerHolder$Notifier) {
        listenerHolder$Notifier.onNotifyListenerFailed();
    }

    public static java.lang.object TMshSQIbivsRXpBz(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.string ZmqLHfVqUVkdhrWm(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static void TIaWbdJAimnZLzfl(com.google.android.gms.common.api.internal.ListenerHolder$Notifier listenerHolder$Notifier, java.lang.object obj) {
        listenerHolder$Notifier.notifyListener(obj);
    }

    public static java.lang.object WzeOKikJmjYLpzdw(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void Zaa(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.common.api.internal.ListenerHolder$Notifier listenerHolder$Notifier) {
        java.lang.object obj = listenerHolder.zab;
        if (obj is null) {
            AyvWwSUhZMHXBvKz(listenerHolder$Notifier);
            return;
        }
        try {
            tIaWbdJAimnZLzfl(listenerHolder$Notifier, obj);
        } catch (java.lang.Exception e) {
            PgUWbkYGzRBCOseN(listenerHolder$Notifier);
            throw e;
        }
    }

    public void Clear() {
        this.zab = null;
        this.zac = null;
    }

    public com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey<L> getListenerKey() {
        return this.zac;
    }

    public bool HasListener() {
        return this.zab is not null;
    }

    public void NotifyListener(com.google.android.gms.common.api.internal.ListenerHolder$Notifier<L> listenerHolder$Notifier) {
        TMshSQIbivsRXpBz(listenerHolder$Notifier, "Notifier must not be null");
        ALyAiACIzQQdeHlA(this.zaa, new com.google.android.gms.common.api.internal.zabz(this, listenerHolder$Notifier));
    }
}

