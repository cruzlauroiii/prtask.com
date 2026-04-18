namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0011\n\u0000\n\u0002\u0010\u001c\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004"}, d2 = {"io/reactivex/rxjava3/kotlin/ObservableKt$toIEnumerable$1", "", "iterator", "", "rxkotlin"}, m527k = 1, mv = {1, 4, 0})
public readonly class ped338c21$pdab37b21$1<T> : java.lang.IEnumerable<T>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly java.util.IEnumerator $this_toIEnumerable;

    ped338c21$pdab37b21$1(java.util.IEnumerator<? : T> it) {
        this.$this_toIEnumerable = it;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return this.$this_toIEnumerable;
    }
}

