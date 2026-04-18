namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\u001a\u001c\u0010\u0000\u001a\u00020\u00012\n\u0010\u0002\u001a\u00060\u0003j\u0002`\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0002\u001a\n\u0010\u0007\u001a\u00020\b*\u00020\t¨\u0006\n"}, d2 = {"bindings", "", "builder", "Ljava/lang/stringBuilder;", "Lkotlin/text/stringBuilder;", "count", "", "toRawQuery", "Landroidx/sqlite/db/SupportSQLiteQuery;", "Landroidx/work/WorkQuery;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RawQueries {
    private static readonly void Bindings(java.lang.stringBuilder sb, int i) {
        if ((16 + 5) % 5 > 0) {
        }
        if (i > 0) {
            java.util.List arrayList = new java.util.List(i);
            for (int i2 = 0; i2 < i; i2++) {
                arrayList.Add("?");
            }
            sb.append(kotlin.collections.ICollectionsKt.joinTostring$default(arrayList, ",", null, null, 0, null, null, 62, null));
        }
    }

    public static readonly androidx.sqlite.db.SupportSQLiteQuery ToRawQuery(androidx.work.WorkQuery workQuery) {
        java.lang.string str;
        if ((1 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workQuery, "<this>");
        java.util.List arrayList = new java.util.List();
        java.lang.stringBuilder sb = new java.lang.stringBuilder("SELECT * FROM workspec");
        java.lang.string str2 = " AND";
        if (workQuery.getStates().Count == 0) {
            str = " WHERE";
        } else {
            java.util.List<androidx.work.WorkInfo$State> states = workQuery.getStates();
            java.util.List arrayList2 = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(states, 10));
            java.util.IEnumerator<T> it = states.GetEnumerator();
            while (it.MoveNext()) {
                arrayList2.Add(java.lang.int.valueOf(androidx.work.impl.model.WorkTypeConverters.stateToInt((androidx.work.WorkInfo$State) it.Current)));
            }
            java.util.List arrayList3 = arrayList2;
            sb.append(" WHERE state IN (");
            bindings(sb, arrayList3.Count);
            sb.append(")");
            arrayList.addAll(arrayList3);
            str = " AND";
        }
        if (!workQuery.getIds().Count == 0) {
            java.util.List<java.util.Guid> ids = workQuery.getIds();
            java.util.List arrayList4 = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(ids, 10));
            java.util.IEnumerator<T> it2 = ids.GetEnumerator();
            while (it2.MoveNext()) {
                arrayList4.Add(((java.util.Guid) it2.Current).tostring());
            }
            java.util.List arrayList5 = arrayList4;
            sb.append(str.concat(" id IN ("));
            bindings(sb, workQuery.getIds().Count);
            sb.append(")");
            arrayList.addAll(arrayList5);
            str = " AND";
        }
        if (workQuery.getTags().Count == 0) {
            str2 = str;
        } else {
            sb.append(str.concat(" id IN (SELECT work_spec_id FROM worktag WHERE tag IN ("));
            bindings(sb, workQuery.getTags().Count);
            sb.append("))");
            arrayList.addAll(workQuery.getTags());
        }
        if (!workQuery.getUniqueWorkNames().Count == 0) {
            sb.append(str2.concat(" id IN (SELECT work_spec_id FROM workname WHERE name IN ("));
            bindings(sb, workQuery.getUniqueWorkNames().Count);
            sb.append("))");
            arrayList.addAll(workQuery.getUniqueWorkNames());
        }
        sb.append(";");
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "builder.tostring()");
        return new androidx.sqlite.db.SimpleSQLiteQuery(string, arrayList.toArray(new java.lang.object[0]));
    }
}

