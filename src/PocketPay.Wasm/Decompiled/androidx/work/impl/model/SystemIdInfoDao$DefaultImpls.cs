namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class SystemIdInfoDao$DefaultImpls {
    @java.lang.Deprecated
    public static androidx.work.impl.model.SystemIdInfo GetSystemIdInfo(androidx.work.impl.model.SystemIdInfoDao systemIdInfoDao, androidx.work.impl.model.WorkGenerationalId id) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        return androidx.work.impl.model.SystemIdInfoDao.access$getSystemIdInfo$jd(systemIdInfoDao, id);
    }

    @java.lang.Deprecated
    public static void RemoveSystemIdInfo(androidx.work.impl.model.SystemIdInfoDao systemIdInfoDao, androidx.work.impl.model.WorkGenerationalId id) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        androidx.work.impl.model.SystemIdInfoDao.access$removeSystemIdInfo$jd(systemIdInfoDao, id);
    }
}

