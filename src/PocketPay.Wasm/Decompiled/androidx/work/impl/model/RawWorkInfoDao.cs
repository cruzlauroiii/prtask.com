namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bg\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\u0006\u0010\u0005\u001a\u00020\u0006H'J\u001c\u0010\u0007\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\u00030\b2\u0006\u0010\u0005\u001a\u00020\u0006H'J\u001c\u0010\t\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\u00030\n2\u0006\u0010\u0005\u001a\u00020\u0006H'ø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\u000bÀ\u0006\u0001"}, d2 = {"Landroidx/work/impl/model/RawWorkInfoDao;", "", "getWorkInfoPojos", "", "Landroidx/work/impl/model/WorkSpec$WorkInfoPojo;", "query", "Landroidx/sqlite/db/SupportSQLiteQuery;", "getWorkInfoPojosFlow", "Lkotlinx/coroutines/flow/Flow;", "getWorkInfoPojosLiveData", "Landroidx/lifecycle/LiveData;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface RawWorkInfoDao {
    java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> getWorkInfoPojos(androidx.sqlite.db.SupportSQLiteQuery query);

    kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkInfoPojosFlow(androidx.sqlite.db.SupportSQLiteQuery query);

    androidx.lifecycle.LiveData<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkInfoPojosLiveData(androidx.sqlite.db.SupportSQLiteQuery query);
}

