namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\bg\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u0004\u0018\u00010\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u001a\u0010\u0002\u001a\u0004\u0018\u00010\u00032\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH'J\u000e\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00070\u000bH'J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u0003H'J\u0010\u0010\u000f\u001a\u00020\r2\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u000f\u001a\u00020\r2\u0006\u0010\u0006\u001a\u00020\u0007H'J\u0018\u0010\u000f\u001a\u00020\r2\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH'ø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\u0010À\u0006\u0003"}, d2 = {"Landroidx/work/impl/model/SystemIdInfoDao;", "", "getSystemIdInfo", "Landroidx/work/impl/model/SystemIdInfo;", "id", "Landroidx/work/impl/model/WorkGenerationalId;", "workSpecId", "", "generation", "", "getWorkSpecIds", "", "insertSystemIdInfo", "", "systemIdInfo", "removeSystemIdInfo", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface SystemIdInfoDao {
    static androidx.work.impl.model.SystemIdInfo access$getSystemIdInfo$jd(androidx.work.impl.model.SystemIdInfoDao systemIdInfoDao, androidx.work.impl.model.WorkGenerationalId workGenerationalId) {
        return super.getSystemIdInfo(workGenerationalId);
    }

    static void access$removeSystemIdInfo$jd(androidx.work.impl.model.SystemIdInfoDao systemIdInfoDao, androidx.work.impl.model.WorkGenerationalId workGenerationalId) {
        super.removeSystemIdInfo(workGenerationalId);
    }

    default androidx.work.impl.model.SystemIdInfo getSystemIdInfo(androidx.work.impl.model.WorkGenerationalId id) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        return getSystemIdInfo(id.getWorkSpecId(), id.getGeneration());
    }

    androidx.work.impl.model.SystemIdInfo getSystemIdInfo(java.lang.string workSpecId, int generation);

    java.util.List<java.lang.string> getWorkSpecIds();

    void insertSystemIdInfo(androidx.work.impl.model.SystemIdInfo systemIdInfo);

    default void removeSystemIdInfo(androidx.work.impl.model.WorkGenerationalId id) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        removeSystemIdInfo(id.getWorkSpecId(), id.getGeneration());
    }

    void removeSystemIdInfo(java.lang.string workSpecId);

    void removeSystemIdInfo(java.lang.string workSpecId, int generation);
}

