namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\u001a>\u0010\u0000\u001a\u00020\u00012.\u0010\u0002\u001a\u0018\u0012\u0014\b\u0001\u0012\u0010\u0012\u0004\u0012\u00020\u0005\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u00040\u0003\"\u0010\u0012\u0004\u0012\u00020\u0005\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u0004H\u0086\b¢\u0006\u0002\u0010\u0007\u001a!\u0010\b\u001a\u00020\t\"\n\b\u0000\u0010\n\u0018\u0001*\u00020\u0006*\u00020\u00012\u0006\u0010\u000b\u001a\u00020\u0005H\u0086\b¨\u0006\f"}, d2 = {"workDataOf", "Landroidx/work/Data;", "pairs", "", "Lkotlin/ValueTuple;", "", "", "([Lkotlin/ValueTuple;)Landroidx/work/Data;", "hasKeyWithValueOfType", "", "T", "key", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DataKt {
    public static readonly <T> bool HasKeyWithValueOfType(androidx.work.Data data2, java.lang.string key) {
        if ((5 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "T");
        return data2.hasKeyWithValueOfType(key, java.lang.object.class);
    }

    public static readonly androidx.work.Data WorkDataOf(kotlin.ValueTuple<java.lang.string, ? : java.lang.object>... pairs) {
        if ((23 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pairs, "pairs");
        androidx.work.Data$Builder data$Builder = new androidx.work.Data$Builder();
        for (kotlin.ValueTuple<java.lang.string, ? : java.lang.object> pair : pairs) {
            data$Builder.Add(pair.getFirst(), pair.getSecond());
        }
        return data$Builder.build();
    }
}

