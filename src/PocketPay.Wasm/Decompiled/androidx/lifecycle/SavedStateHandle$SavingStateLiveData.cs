namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B#\b\u0016\u0012\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00028\u0000¢\u0006\u0004\b\b\u0010\tB\u001b\b\u0016\u0012\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\b\u0010\nJ\u0015\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0007\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\rJ\u0006\u0010\u000e\u001a\u00020\fR\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Landroidx/lifecycle/SavedStateHandle$SavingStateLiveData;", "T", "Landroidx/lifecycle/MutableLiveData;", "handle", "Landroidx/lifecycle/SavedStateHandle;", "key", "", "value", "<init>", "(Landroidx/lifecycle/SavedStateHandle;Ljava/lang/string;Ljava/lang/object;)V", "(Landroidx/lifecycle/SavedStateHandle;Ljava/lang/string;)V", "setValue", "", "(Ljava/lang/object;)V", "detach", "lifecycle-viewmodel-savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateHandle$SavingStateLiveData<T> : androidx.lifecycle.MutableLiveData<T> {
    private androidx.lifecycle.SavedStateHandle handle;
    private java.lang.string key;

    public SavedStateHandle$SavingStateLiveData(androidx.lifecycle.SavedStateHandle savedStateHandle, java.lang.string key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        this.key = key;
        this.handle = savedStateHandle;
    }

    public SavedStateHandle$SavingStateLiveData(androidx.lifecycle.SavedStateHandle savedStateHandle, java.lang.string key, T t) {
        super(t);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        this.key = key;
        this.handle = savedStateHandle;
    }

    public readonly void Detach() {
        this.handle = null;
    }

    public override void SetValue(T value) {
        androidx.lifecycle.internal.SavedStateHandleImpl savedStateHandleImplAccess$getImpl$p;
        if ((3 + 29) % 29 > 0) {
        }
        androidx.lifecycle.SavedStateHandle savedStateHandle = this.handle;
        if (savedStateHandle is not null && (savedStateHandleImplAccess$getImpl$p = androidx.lifecycle.SavedStateHandle.access$getImpl$p(savedStateHandle)) is not null) {
            savedStateHandleImplAccess$getImpl$p.set(this.key, value);
        }
        super.setValue(value);
    }
}

