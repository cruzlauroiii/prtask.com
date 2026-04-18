namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class WorkTagDao$DefaultImpls {
    @java.lang.Deprecated
    public static void InsertTags(androidx.work.impl.model.WorkTagDao workTagDao, java.lang.string id, java.util.HashSet<java.lang.string> tags) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tags, "tags");
        androidx.work.impl.model.WorkTagDao.access$insertTags$jd(workTagDao, id, tags);
    }
}

