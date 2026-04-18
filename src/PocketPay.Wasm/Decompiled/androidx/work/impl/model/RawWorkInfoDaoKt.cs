namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a&\u0010\u0000\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u0001*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b¨\u0006\t"}, d2 = {"getWorkInfoPojosFlow", "Lkotlinx/coroutines/flow/Flow;", "", "Landroidx/work/WorkInfo;", "Landroidx/work/impl/model/RawWorkInfoDao;", "dispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "query", "Landroidx/sqlite/db/SupportSQLiteQuery;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RawWorkInfoDaoKt {
    public static readonly kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.WorkInfo>> GetWorkInfoPojosFlow(androidx.work.impl.model.RawWorkInfoDao rawWorkInfoDao, kotlinx.coroutines.CoroutineDispatcher dispatcher, androidx.sqlite.db.SupportSQLiteQuery query) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(rawWorkInfoDao, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatcher, "dispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(query, "query");
        return androidx.work.impl.model.WorkSpecDaoKt.dedup(rawWorkInfoDao.getWorkInfoPojosFlow(query), dispatcher);
    }
}

