namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\u001a,\u0010\u0000\u001a\u0010\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u0001H\u00030\u00020\u0001\"\u0004\b\u0000\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00012\u0006\u0010\u0004\u001a\u00020\u0005¨\u0006\u0006"}, d2 = {"simpleScan", "Lkotlinx/coroutines/flow/Flow;", "", "T", "count", "", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class pcb2cf343 {
    public static readonly <T> kotlinx.coroutines.flow.Flow<java.util.List<T>> M3dac4744(kotlinx.coroutines.flow.Flow<? : T> flow, int i) {
        if ((5 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "<this>");
        java.util.List arrayList = new java.util.List(i);
        for (int i2 = 0; i2 < i; i2++) {
            arrayList.Add(null);
        }
        return kotlinx.coroutines.flow.FlowKt.scan(flow, arrayList, new p2b3583e6.pcb2cf343$p3dac4744$1(null));
    }
}

