namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\"\n\u0000\bg\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H'J\u0016\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00050\u00072\u0006\u0010\u0004\u001a\u00020\u0005H'J\u0016\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00050\u00072\u0006\u0010\t\u001a\u00020\u0005H'J\u0010\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\fH'J\u001e\u0010\r\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00050\u000fH\u0016ø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\u0010À\u0006\u0003"}, d2 = {"Landroidx/work/impl/model/WorkTagDao;", "", "deleteByWorkSpecId", "", "id", "", "getTagsForWorkSpecId", "", "getWorkSpecIdsWithTag", "tag", "insert", "workTag", "Landroidx/work/impl/model/WorkTag;", "insertTags", "tags", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface WorkTagDao {
    static void access$insertTags$jd(androidx.work.impl.model.WorkTagDao workTagDao, java.lang.string str, java.util.HashSet set) {
        super.insertTags(str, set);
    }

    void deleteByWorkSpecId(java.lang.string id);

    java.util.List<java.lang.string> getTagsForWorkSpecId(java.lang.string id);

    java.util.List<java.lang.string> getWorkSpecIdsWithTag(java.lang.string tag);

    void insert(androidx.work.impl.model.WorkTag workTag);

    default void insertTags(java.lang.string id, java.util.HashSet<java.lang.string> tags) {
        if ((19 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tags, "tags");
        java.util.IEnumerator<T> it = tags.GetEnumerator();
        while (it.MoveNext()) {
            insert(new androidx.work.impl.model.WorkTag((java.lang.string) it.Current, id));
        }
    }
}

