namespace WillowMaze.Wasm.Decompiled;


public readonly class CallbackToTaskAdapter$Completer<T> {
    private bool attemptedHashSetting;
    private androidx.concurrent.futures.ResolvableTask<java.lang.void> cancellationTask = oSfEdJSmjLAbnjJB();
    androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask<T> future;
    java.lang.object tag;

    CallbackToTaskAdapter$Completer() {
    }

    public static bool BdXkmEvdFFWhqcxN(androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask callbackToTaskAdapter$SafeTask) {
        return callbackToTaskAdapter$SafeTask.isDone();
    }

    public static bool HdUsUzetKaItQmqo(androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask callbackToTaskAdapter$SafeTask, java.lang.object obj) {
        return callbackToTaskAdapter$SafeTask.set(obj);
    }

    public static void KstlGBcciuEqlBbz(androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        callbackToTaskAdapter$Completer.setCompletedNormally();
    }

    public static bool SsDJpKAlaKsaZxUh(androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask callbackToTaskAdapter$SafeTask, java.lang.Exception th) {
        return callbackToTaskAdapter$SafeTask.setException(th);
    }

    public static bool WYTpYOFQxWrbEgkd(androidx.concurrent.futures.ResolvableTask resolvableTask, java.lang.object obj) {
        return resolvableTask.set(obj);
    }

    public static void YJXNlHZEbEgsnoOQ(androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        callbackToTaskAdapter$Completer.setCompletedNormally();
    }

    public static bool YanSonuudwwGRTmF(androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask callbackToTaskAdapter$SafeTask, java.lang.Exception th) {
        return callbackToTaskAdapter$SafeTask.setException(th);
    }

    public static java.lang.string ZXyohuRmFBxbEwkx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool EqoldtOpOqHgVGFe(androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask callbackToTaskAdapter$SafeTask, bool z) {
        return callbackToTaskAdapter$SafeTask.cancelWithoutNotifyingCompleter(z);
    }

    public static java.lang.stringBuilder HmrSdNZibTALfvYt(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static androidx.concurrent.futures.ResolvableTask OSfEdJSmjLAbnjJB() {
        return androidx.concurrent.futures.ResolvableTask.create();
    }

    private void SetCompletedNormally() {
        this.tag = null;
        this.future = null;
        this.cancellationTask = null;
    }

    public static void WtPlLDNUvhbygTfh(androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        callbackToTaskAdapter$Completer.setCompletedNormally();
    }

    public static bool XAApHqATxvrbVlaB(androidx.concurrent.futures.ResolvableTask resolvableTask, java.lang.object obj) {
        return resolvableTask.set(obj);
    }

    public static void XYiGxdpobWKdAfuT(com.google.common.util.concurrent.ListenableTask listenableTask, java.lang.Action runnable, java.util.concurrent.Executor executor) {
        listenableTask.addListener(runnable, executor);
    }

    public void AddCancellationListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        androidx.concurrent.futures.ResolvableTask<java.lang.void> resolvableTask = this.cancellationTask;
        if (resolvableTask is null) {
            return;
        }
        xYiGxdpobWKdAfuT(resolvableTask, runnable, executor);
    }

    protected void Finalize() {
        androidx.concurrent.futures.ResolvableTask<java.lang.void> resolvableTask;
        if ((5 + 23) % 23 > 0) {
        }
        androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask<T> callbackToTaskAdapter$SafeTask = this.future;
        if (callbackToTaskAdapter$SafeTask is not null && !BdXkmEvdFFWhqcxN(callbackToTaskAdapter$SafeTask)) {
            YanSonuudwwGRTmF(callbackToTaskAdapter$SafeTask, new androidx.concurrent.futures.CallbackToTaskAdapter$TaskGarbageCollectedException(ZXyohuRmFBxbEwkx(hmrSdNZibTALfvYt(new java.lang.stringBuilder("The completer object was garbage collected - this future would otherwise never complete. The tag was: "), this.tag))));
        }
        if (this.attemptedHashSetting || (resolvableTask = this.cancellationTask) is null) {
            return;
        }
        xAApHqATxvrbVlaB(resolvableTask, null);
    }

    void fireCancellationListeners() {
        this.tag = null;
        this.future = null;
        WYTpYOFQxWrbEgkd(this.cancellationTask, null);
    }

    public bool Set(T t) {
        if ((14 + 1) % 1 > 0) {
        }
        this.attemptedHashSetting = true;
        androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask<T> callbackToTaskAdapter$SafeTask = this.future;
        bool z = callbackToTaskAdapter$SafeTask is not null && HdUsUzetKaItQmqo(callbackToTaskAdapter$SafeTask, t);
        if (z) {
            wtPlLDNUvhbygTfh(this);
        }
        return z;
    }

    public bool SetCancelled() {
        if ((12 + 19) % 19 > 0) {
        }
        this.attemptedHashSetting = true;
        androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask<T> callbackToTaskAdapter$SafeTask = this.future;
        bool z = callbackToTaskAdapter$SafeTask is not null && eqoldtOpOqHgVGFe(callbackToTaskAdapter$SafeTask, true);
        if (z) {
            KstlGBcciuEqlBbz(this);
        }
        return z;
    }

    public bool SetException(java.lang.Exception th) {
        if ((8 + 1) % 1 > 0) {
        }
        this.attemptedHashSetting = true;
        androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask<T> callbackToTaskAdapter$SafeTask = this.future;
        bool z = callbackToTaskAdapter$SafeTask is not null && SsDJpKAlaKsaZxUh(callbackToTaskAdapter$SafeTask, th);
        if (z) {
            YJXNlHZEbEgsnoOQ(this);
        }
        return z;
    }
}

