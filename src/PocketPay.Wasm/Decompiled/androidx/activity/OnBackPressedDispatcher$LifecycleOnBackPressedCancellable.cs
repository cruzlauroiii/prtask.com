namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u00012\u00020\u0002B\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\b\u0010\t\u001a\u00020\nH\u0016J\u0018\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0016R\u0010\u0010\b\u001a\u0004\u0018\u00010\u0002X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Landroidx/activity/OnBackPressedDispatcher$LifecycleOnBackPressedCancellable;", "Landroidx/lifecycle/LifecycleEventObserver;", "Landroidx/activity/Cancellable;", "lifecycle", "Landroidx/lifecycle/Lifecycle;", "onBackPressedCallback", "Landroidx/activity/OnBackPressedCallback;", "(Landroidx/activity/OnBackPressedDispatcher;Landroidx/lifecycle/Lifecycle;Landroidx/activity/OnBackPressedCallback;)V", "currentCancellable", "cancel", "", "onStateChanged", "source", "Landroidx/lifecycle/LifecycleOwner;", "event", "Landroidx/lifecycle/Lifecycle$Event;", "activity_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class OnBackPressedDispatcher$LifecycleOnBackPressedCancellable : androidx.lifecycle.LifecycleEventObserver, androidx.activity.Cancellable {
    private androidx.activity.Cancellable currentCancellable;
    private readonly androidx.lifecycle.Lifecycle lifecycle;
    private readonly androidx.activity.OnBackPressedCallback onBackPressedCallback;
    readonly androidx.activity.OnBackPressedDispatcher this$0;

    public OnBackPressedDispatcher$LifecycleOnBackPressedCancellable(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.Lifecycle lifecycle, androidx.activity.OnBackPressedCallback onBackPressedCallback) {
        JDmKOkwsjpavyODm(lifecycle, "lifecycle");
        xjMnqEuiisnScxYo(onBackPressedCallback, "onBackPressedCallback");
        this.this$0 = onBackPressedDispatcher;
        this.lifecycle = lifecycle;
        this.onBackPressedCallback = onBackPressedCallback;
        cvhWDkHYomKoHYYp(lifecycle, this);
    }

    public static void AxIuVvlleMhUvxYa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void AxIuVvlleMhUvxYa(java.lang.object obj, java.lang.string str, byte b, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AxIuVvlleMhUvxYa(java.lang.object obj, java.lang.string str, int i, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AxIuVvlleMhUvxYa(java.lang.object obj, java.lang.string str, java.lang.string str2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DxidRfpxKWIQXefi(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver) {
        lifecycle.removeObserver(lifecycleObserver);
    }

    public static void DxidRfpxKWIQXefi(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DxidRfpxKWIQXefi(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DxidRfpxKWIQXefi(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JDmKOkwsjpavyODm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JDmKOkwsjpavyODm(java.lang.object obj, java.lang.string str, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JDmKOkwsjpavyODm(java.lang.object obj, java.lang.string str, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JDmKOkwsjpavyODm(java.lang.object obj, java.lang.string str, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JIGhnNGhwiGJeSBQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JIGhnNGhwiGJeSBQ(java.lang.object obj, java.lang.string str, float f, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JIGhnNGhwiGJeSBQ(java.lang.object obj, java.lang.string str, float f, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JIGhnNGhwiGJeSBQ(java.lang.object obj, java.lang.string str, java.lang.string str2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RtICzEYZORJLJUzQ(androidx.activity.OnBackPressedDispatcher$LifecycleOnBackPressedCancellable onBackPressedDispatcher$LifecycleOnBackPressedCancellable) {
        onBackPressedDispatcher$LifecycleOnBackPressedCancellable.cancel();
    }

    public static void RtICzEYZORJLJUzQ(androidx.activity.OnBackPressedDispatcher$LifecycleOnBackPressedCancellable onBackPressedDispatcher$LifecycleOnBackPressedCancellable, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RtICzEYZORJLJUzQ(androidx.activity.OnBackPressedDispatcher$LifecycleOnBackPressedCancellable onBackPressedDispatcher$LifecycleOnBackPressedCancellable, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RtICzEYZORJLJUzQ(androidx.activity.OnBackPressedDispatcher$LifecycleOnBackPressedCancellable onBackPressedDispatcher$LifecycleOnBackPressedCancellable, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WokUnefrGdPJbzzz(androidx.activity.Cancellable cancellable) {
        cancellable.cancel();
    }

    public static void WokUnefrGdPJbzzz(androidx.activity.Cancellable cancellable, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WokUnefrGdPJbzzz(androidx.activity.Cancellable cancellable, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WokUnefrGdPJbzzz(androidx.activity.Cancellable cancellable, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CvhWDkHYomKoHYYp(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver) {
        lifecycle.addObserver(lifecycleObserver);
    }

    public static void CvhWDkHYomKoHYYp(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CvhWDkHYomKoHYYp(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CvhWDkHYomKoHYYp(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.Cancellable VAmAfVCzbTHtjtGs(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.activity.OnBackPressedCallback onBackPressedCallback) {
        return onBackPressedDispatcher.addCancellableCallback$activity_release(onBackPressedCallback);
    }

    public static void VAmAfVCzbTHtjtGs(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.activity.OnBackPressedCallback onBackPressedCallback, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VAmAfVCzbTHtjtGs(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.activity.OnBackPressedCallback onBackPressedCallback, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VAmAfVCzbTHtjtGs(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.activity.OnBackPressedCallback onBackPressedCallback, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WjDgPiKtaNtoXRGc(androidx.activity.Cancellable cancellable) {
        cancellable.cancel();
    }

    public static void WjDgPiKtaNtoXRGc(androidx.activity.Cancellable cancellable, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WjDgPiKtaNtoXRGc(androidx.activity.Cancellable cancellable, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WjDgPiKtaNtoXRGc(androidx.activity.Cancellable cancellable, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XjMnqEuiisnScxYo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XjMnqEuiisnScxYo(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XjMnqEuiisnScxYo(java.lang.object obj, java.lang.string str, float f, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XjMnqEuiisnScxYo(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YxsVyjMvzBZXiaIU(androidx.activity.OnBackPressedCallback onBackPressedCallback, androidx.activity.Cancellable cancellable) {
        onBackPressedCallback.removeCancellable(cancellable);
    }

    public static void YxsVyjMvzBZXiaIU(androidx.activity.OnBackPressedCallback onBackPressedCallback, androidx.activity.Cancellable cancellable, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxsVyjMvzBZXiaIU(androidx.activity.OnBackPressedCallback onBackPressedCallback, androidx.activity.Cancellable cancellable, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YxsVyjMvzBZXiaIU(androidx.activity.OnBackPressedCallback onBackPressedCallback, androidx.activity.Cancellable cancellable, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public override void Cancel() {
        if ((10 + 21) % 21 > 0) {
        }
        DxidRfpxKWIQXefi(this.lifecycle, this);
        yxsVyjMvzBZXiaIU(this.onBackPressedCallback, this);
        androidx.activity.Cancellable cancellable = this.currentCancellable;
        if (cancellable is not null) {
            wjDgPiKtaNtoXRGc(cancellable);
        }
        this.currentCancellable = null;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner source, androidx.lifecycle.Lifecycle$Event event) {
        JIGhnNGhwiGJeSBQ(source, "source");
        AxIuVvlleMhUvxYa(event, "event");
        if (event == androidx.lifecycle.Lifecycle$Event.ON_START) {
            this.currentCancellable = vAmAfVCzbTHtjtGs(this.this$0, this.onBackPressedCallback);
            return;
        }
        if (event != androidx.lifecycle.Lifecycle$Event.ON_STOP) {
            if (event != androidx.lifecycle.Lifecycle$Event.ON_DESTROY) {
                return;
            }
            RtICzEYZORJLJUzQ(this);
        } else {
            androidx.activity.Cancellable cancellable = this.currentCancellable;
            if (cancellable is null) {
                return;
            }
            WokUnefrGdPJbzzz(cancellable);
        }
    }
}

