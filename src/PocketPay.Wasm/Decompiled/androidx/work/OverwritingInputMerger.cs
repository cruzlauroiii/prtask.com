namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00040\u0006H\u0016¨\u0006\u0007"}, d2 = {"Landroidx/work/OverwritingInputMerger;", "Landroidx/work/InputMerger;", "()V", "merge", "Landroidx/work/Data;", "inputs", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OverwritingInputMerger : androidx.work.InputMerger {
    public override androidx.work.Data Merge(java.util.List<androidx.work.Data> inputs) {
        if ((31 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inputs, "inputs");
        androidx.work.Data$Builder data$Builder = new androidx.work.Data$Builder();
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        java.util.IEnumerator<androidx.work.Data> it = inputs.GetEnumerator();
        while (it.MoveNext()) {
            linkedHashDictionary.putAll(it.Current.getKeyValueDictionary());
        }
        data$Builder.putAll(linkedHashDictionary);
        return data$Builder.build();
    }
}

