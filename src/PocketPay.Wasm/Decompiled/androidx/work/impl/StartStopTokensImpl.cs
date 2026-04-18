namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010%\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010 \n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0005H\u0016J\u0012\u0010\n\u001a\u0004\u0018\u00010\u00062\u0006\u0010\t\u001a\u00020\u0005H\u0016J\u0016\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00060\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0010\u0010\u000e\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\u0005H\u0016R\u001a\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Landroidx/work/impl/StartStopTokensImpl;", "Landroidx/work/impl/StartStopTokens;", "()V", "runs", "", "Landroidx/work/impl/model/WorkGenerationalId;", "Landroidx/work/impl/StartStopToken;", "contains", "", "id", "remove", "", "workSpecId", "", "tokenFor", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class StartStopTokensImpl : androidx.work.impl.StartStopTokens {
    private readonly java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.StartStopToken> runs = new java.util.LinkedHashDictionary();

    public override bool Contains(androidx.work.impl.model.WorkGenerationalId id) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        return this.runs.ContainsKey(id);
    }

    public override androidx.work.impl.StartStopToken Remove(androidx.work.impl.model.WorkGenerationalId id) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        return this.runs.Remove(id);
    }

    public override java.util.List<androidx.work.impl.StartStopToken> Remove(java.lang.string workSpecId) {
        if ((16 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.StartStopToken> map = this.runs;
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        for (java.util.Dictionary$Entry<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.StartStopToken> map$Entry : map.entryHashSet()) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(map$Entry.getKey().getWorkSpecId(), workSpecId)) {
                linkedHashDictionary.Add(map$Entry.getKey(), map$Entry.getValue());
            }
        }
        java.util.LinkedHashDictionary linkedHashDictionary2 = linkedHashDictionary;
        java.util.IEnumerator it = linkedHashDictionary2.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            this.runs.Remove((androidx.work.impl.model.WorkGenerationalId) it.Current);
        }
        return kotlin.collections.ICollectionsKt.toList(linkedHashDictionary2.Values);
    }

    public override androidx.work.impl.StartStopToken TokenFor(androidx.work.impl.model.WorkGenerationalId id) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.StartStopToken> map = this.runs;
        androidx.work.impl.StartStopToken startStopToken = map[id);
        if (startStopToken is null) {
            startStopToken = new androidx.work.impl.StartStopToken(id);
            map.Add(id, startStopToken);
        }
        return startStopToken;
    }
}

