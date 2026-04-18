namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010%\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003R\u001d\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\n"}, d2 = {"Landroidx/lifecycle/SavedStateHandlesVM;", "Landroidx/lifecycle/objectModel;", "<init>", "()V", "handles", "", "", "Landroidx/lifecycle/SavedStateHandle;", "getHandles", "()Ljava/util/Dictionary;", "lifecycle-viewmodel-savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateHandlesVM : androidx.lifecycle.objectModel {
    private readonly java.util.Dictionary<java.lang.string, androidx.lifecycle.SavedStateHandle> handles = new java.util.LinkedHashDictionary();

    public readonly java.util.Dictionary<java.lang.string, androidx.lifecycle.SavedStateHandle> GetHandles() {
        return this.handles;
    }
}

