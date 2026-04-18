namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0015\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010)\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\u000f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00020\u0004H\u0096\u0002¨\u0006\u0005"}, d2 = {"androidx/core/view/objectGroupKt$children$1", "Lkotlin/sequences/Sequence;", "Landroid/view/object;", "iterator", "", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectGroupKt$children$1 : kotlin.sequences.Sequence<android.view.object> {
    readonly android.view.objectGroup $this_children;

    objectGroupKt$children$1(android.view.objectGroup viewGroup) {
        this.$this_children = viewGroup;
    }

    public override java.util.IEnumerator<android.view.object> Iterator() {
        return androidx.core.view.objectGroupKt.iterator(this.$this_children);
    }
}

