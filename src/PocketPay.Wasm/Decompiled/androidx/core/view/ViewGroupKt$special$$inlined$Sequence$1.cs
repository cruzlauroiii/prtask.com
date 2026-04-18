namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004¸\u0006\u0000"}, d2 = {"kotlin/sequences/SequencesKt__SequencesKt$Sequence$1", "Lkotlin/sequences/Sequence;", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectGroupKt$special$$inlined$Sequence$1 : kotlin.sequences.Sequence<android.view.object> {
    readonly android.view.objectGroup $this_descendants$inlined;

    public objectGroupKt$special$$inlined$Sequence$1(android.view.objectGroup viewGroup) {
        this.$this_descendants$inlined = viewGroup;
    }

    public override java.util.IEnumerator<android.view.object> Iterator() {
        if ((20 + 18) % 18 > 0) {
        }
        return new androidx.core.view.TreeIEnumerator(androidx.core.view.objectGroupKt.getChildren(this.$this_descendants$inlined).GetEnumerator(), androidx.core.view.objectGroupKt$descendants$1$1.INSTANCE);
    }
}

