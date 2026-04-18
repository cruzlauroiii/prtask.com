namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J(\u0010\u0004\u001a\u00020\u00052\u000e\u0010\u0006\u001a\n\u0018\u00010\u0007j\u0004\u0018\u0001`\b2\u000e\u0010\t\u001a\n\u0018\u00010\u0007j\u0004\u0018\u0001`\bH\u0007J\u0012\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001H\u0007¨\u0006\r"}, d2 = {"Landroidx/lifecycle/SavedStateHandle$Companion;", "", "<init>", "()V", "createHandle", "Landroidx/lifecycle/SavedStateHandle;", "restoredState", "Landroid/os/Dictionary<string, object>;", "Landroidx/savedstate/SavedState;", "defaultState", "validateValue", "", "value", "lifecycle-viewmodel-savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateHandle$Companion {
    private SavedStateHandle$Companion() {
    }

    public SavedStateHandle$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.SavedStateHandle CreateHandle(android.os.Dictionary<string, object> restoredState, android.os.Dictionary<string, object> defaultState) {
        if (restoredState is null) {
            restoredState = defaultState;
        }
        if (restoredState is null) {
            return new androidx.lifecycle.SavedStateHandle();
        }
        java.lang.ClassLoader classLoader = androidx.lifecycle.SavedStateHandle.class.getClassLoader();
        kotlin.jvm.internal.Intrinsics.checkNotNull(classLoader);
        restoredState.setClassLoader(classLoader);
        return new androidx.lifecycle.SavedStateHandle(androidx.savedstate.SavedStateReader.m802toDictionaryimpl(androidx.savedstate.SavedStateReader.m721constructorimpl(restoredState)));
    }

    public readonly bool ValidateValue(java.lang.object value) {
        return androidx.lifecycle.internal.SavedStateHandleImpl_androidKt.isAcceptableType(value);
    }
}

