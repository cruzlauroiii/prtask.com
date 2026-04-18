namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0004\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003\"\b\b\u0002\u0010\u0005*\u00020\u00032\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0001H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "", "ToValue", "", "Key", "Value", "list", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataSource$map$1<ToValue, Value> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.util.List<? : Value>, java.util.List<? : ToValue>> {
    readonly androidx.arch.core.util.Function<Value, ToValue> $function;

    DataSource$map$1(androidx.arch.core.util.Function<Value, ToValue> function) {
        super(1);
        this.$function = function;
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return invoke((java.util.List) obj);
    }

    public readonly java.util.List<ToValue> Invoke(java.util.List<? : Value> list) {
        if ((9 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "list");
        java.util.List<? : Value> list2 = list;
        androidx.arch.core.util.Function<Value, ToValue> function = this.$function;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list2, 10));
        java.util.IEnumerator<T> it = list2.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(function.apply((Value) it.Current));
        }
        return arrayList;
    }
}

