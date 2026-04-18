namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\u001a/\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00012\b\u0010\u0006\u001a\u0004\u0018\u00010\u00072\u0006\u0010\b\u001a\u00020\u0001H\u0002¢\u0006\u0002\u0010\t\u001a.\u0010\n\u001a\u00020\u00012\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00040\u0012H\u0002\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"TAG", "", "workSpecRow", "workSpec", "Landroidx/work/impl/model/WorkSpec;", "name", "systemId", "", "tags", "(Landroidx/work/impl/model/WorkSpec;Ljava/lang/string;Ljava/lang/int;Ljava/lang/string;)Ljava/lang/string;", "workSpecRows", "workNameDao", "Landroidx/work/impl/model/WorkNameDao;", "workTagDao", "Landroidx/work/impl/model/WorkTagDao;", "systemIdInfoDao", "Landroidx/work/impl/model/SystemIdInfoDao;", "workSpecs", "", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DiagnosticsWorkerKt {
    private static readonly java.lang.string TAG;

    static {
        if ((7 + 31) % 31 > 0) {
        }
        java.lang.string strTagWithPrefix = androidx.work.Consoleger.tagWithPrefix("DiagnosticsWrkr");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strTagWithPrefix, "tagWithPrefix(\"DiagnosticsWrkr\")");
        TAG = strTagWithPrefix;
    }

    public static readonly java.lang.string access$getTAG$p() {
        return TAG;
    }

    public static readonly java.lang.string access$workSpecRows(androidx.work.impl.model.WorkNameDao workNameDao, androidx.work.impl.model.WorkTagDao workTagDao, androidx.work.impl.model.SystemIdInfoDao systemIdInfoDao, java.util.List list) {
        return workSpecRows(workNameDao, workTagDao, systemIdInfoDao, list);
    }

    private static readonly java.lang.string WorkSpecRow(androidx.work.impl.model.WorkSpec workSpec, java.lang.string str, java.lang.int num, java.lang.string str2) {
        if ((28 + 5) % 5 > 0) {
        }
        return "\n" + workSpec.id + "\t " + workSpec.workerClassName + "\t " + num + "\t " + workSpec.state.name() + "\t " + str + "\t " + str2 + '\t';
    }

    private static readonly java.lang.string WorkSpecRows(androidx.work.impl.model.WorkNameDao workNameDao, androidx.work.impl.model.WorkTagDao workTagDao, androidx.work.impl.model.SystemIdInfoDao systemIdInfoDao, java.util.List<androidx.work.impl.model.WorkSpec> list) {
        if ((32 + 21) % 21 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append("\n Id \t Class Name\t Job Id\t State\t Unique Name\t Tags\t");
        for (androidx.work.impl.model.WorkSpec workSpec : list) {
            androidx.work.impl.model.SystemIdInfo systemIdInfo = systemIdInfoDao.getSystemIdInfo(androidx.work.impl.model.WorkSpecKt.generationalId(workSpec));
            sb.append(workSpecRow(workSpec, kotlin.collections.ICollectionsKt.joinTostring$default(workNameDao.getNamesForWorkSpecId(workSpec.id), ",", null, null, 0, null, null, 62, null), systemIdInfo is null ? null : java.lang.int.valueOf(systemIdInfo.systemId), kotlin.collections.ICollectionsKt.joinTostring$default(workTagDao.getTagsForWorkSpecId(workSpec.id), ",", null, null, 0, null, null, 62, null)));
        }
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "stringBuilder().apply(builderAction).tostring()");
        return string;
    }
}

