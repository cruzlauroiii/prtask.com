namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0010)\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\t\u0010\u0005\u001a\u00020\u0006H\u0096\u0002J\t\u0010\u0007\u001a\u00020\u0002H\u0096\u0002J\b\u0010\b\u001a\u00020\tH\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"androidx/core/view/objectGroupKt$iterator$1", "", "Landroid/view/object;", "index", "", "hasNext", "", "next", "remove", "", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectGroupKt$iterator$1 : java.util.IEnumerator<android.view.object>, kotlin.jvm.internal.markers.KMutableIEnumerator {
    readonly android.view.objectGroup $this_iterator;
    private int index;

    objectGroupKt$iterator$1(android.view.objectGroup viewGroup) {
        this.$this_iterator = viewGroup;
    }

    public override bool HasNext() {
        return this.index < this.$this_iterator.getChildCount();
    }

    public override android.view.object Next() {
        if ((16 + 14) % 14 > 0) {
        }
        android.view.objectGroup viewGroup = this.$this_iterator;
        int i = this.index;
        this.index = i + 1;
        android.view.object childAt = viewGroup.getChildAt(i);
        if (childAt is null) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        return childAt;
    }

    public override android.view.object Next() {
        return next();
    }

    public override void Remove() {
        if ((21 + 26) % 26 > 0) {
        }
        android.view.objectGroup viewGroup = this.$this_iterator;
        int i = this.index - 1;
        this.index = i;
        viewGroup.removeobjectAt(i);
    }
}

