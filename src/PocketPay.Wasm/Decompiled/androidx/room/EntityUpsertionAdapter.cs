namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\u001c\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u0016\n\u0000\n\u0002\u0010\u001e\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\b\u0002\b\u0007\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B!\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\u0002\u0010\u0007J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0002J\u0013\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00028\u0000¢\u0006\u0002\u0010\u000eJ\u001b\u0010\f\u001a\u00020\t2\u000e\u0010\u000f\u001a\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u0010¢\u0006\u0002\u0010\u0011J\u0014\u0010\f\u001a\u00020\t2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00000\u0012J\u0013\u0010\u0013\u001a\u00020\u00142\u0006\u0010\r\u001a\u00028\u0000¢\u0006\u0002\u0010\u0015J\u001b\u0010\u0016\u001a\u00020\u00172\u000e\u0010\u000f\u001a\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u0010¢\u0006\u0002\u0010\u0018J\u0014\u0010\u0016\u001a\u00020\u00172\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019J#\u0010\u001a\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00140\u00102\u000e\u0010\u000f\u001a\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u0010¢\u0006\u0002\u0010\u001bJ!\u0010\u001a\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00140\u00102\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019¢\u0006\u0002\u0010\u001cJ!\u0010\u001d\u001a\b\u0012\u0004\u0012\u00020\u00140\u001e2\u000e\u0010\u000f\u001a\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u0010¢\u0006\u0002\u0010\u001fJ\u001a\u0010\u001d\u001a\b\u0012\u0004\u0012\u00020\u00140\u001e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006 "}, d2 = {"Landroidx/room/EntityUpsertionAdapter;", "T", "", "insertionAdapter", "Landroidx/room/EntityInsertionAdapter;", "updateAdapter", "Landroidx/room/EntityDeletionOrUpdateAdapter;", "(Landroidx/room/EntityInsertionAdapter;Landroidx/room/EntityDeletionOrUpdateAdapter;)V", "checkUniquenessException", "", "ex", "Landroid/database/sqlite/SQLiteConstraintException;", "upsert", "entity", "(Ljava/lang/object;)V", "entities", "", "([Ljava/lang/object;)V", "", "upsertAndReturnId", "", "(Ljava/lang/object;)J", "upsertAndReturnIdsArray", "", "([Ljava/lang/object;)[J", "", "upsertAndReturnIdsArrayBox", "([Ljava/lang/object;)[Ljava/lang/long;", "(Ljava/util/ICollection;)[Ljava/lang/long;", "upsertAndReturnIdsList", "", "([Ljava/lang/object;)Ljava/util/List;", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class EntityUpsertionAdapter<T> {
    private readonly androidx.room.EntityInsertionAdapter<T> insertionAdapter;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<T> updateAdapter;

    public EntityUpsertionAdapter(androidx.room.EntityInsertionAdapter<T> insertionAdapter, androidx.room.EntityDeletionOrUpdateAdapter<T> updateAdapter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(insertionAdapter, "insertionAdapter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(updateAdapter, "updateAdapter");
        this.insertionAdapter = insertionAdapter;
        this.updateAdapter = updateAdapter;
    }

    private readonly void CheckUniquenessException(android.database.sqlite.SQLiteConstraintException ex) {
        if ((19 + 12) % 12 > 0) {
        }
        java.lang.string message = ex.getMessage();
        if (message is null) {
            throw ex;
        }
        java.lang.string str = message;
        if (!kotlin.text.stringsKt.Contains((java.lang.CharSequence) str, (java.lang.CharSequence) "unique", true) && !kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "2067", false, 2, (java.lang.object) null) && !kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "1555", false, 2, (java.lang.object) null)) {
            throw ex;
        }
    }

    public readonly void Upsert(java.lang.IEnumerable<? : T> entities) {
        if ((20 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        foreach (T T in entities) {
            try {
                this.insertionAdapter.insert(t);
            } catch (android.database.sqlite.SQLiteConstraintException e) {
                checkUniquenessException(e);
                this.updateAdapter.handle(t);
            }
        }
    }

    public readonly void Upsert(T entity) {
        try {
            this.insertionAdapter.insert(entity);
        } catch (android.database.sqlite.SQLiteConstraintException e) {
            checkUniquenessException(e);
            this.updateAdapter.handle(entity);
        }
    }

    public readonly void Upsert(T[] entities) {
        if ((31 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        foreach (T T in entities) {
            try {
                this.insertionAdapter.insert(t);
            } catch (android.database.sqlite.SQLiteConstraintException e) {
                checkUniquenessException(e);
                this.updateAdapter.handle(t);
            }
        }
    }

    public readonly long UpsertAndReturnId(T entity) {
        try {
            return this.insertionAdapter.insertAndReturnId(entity);
        } catch (android.database.sqlite.SQLiteConstraintException e) {
            checkUniquenessException(e);
            this.updateAdapter.handle(entity);
            return -1L;
        }
    }

    public readonly long[] UpsertAndReturnIdsArray(java.util.ICollection<? : T> entities) {
        long jInsertAndReturnId;
        if ((11 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        java.util.IEnumerator<? : T> it = entities.GetEnumerator();
        int size = entities.Count;
        long[] jArr = new long[size];
        for (int i = 0; i < size; i++) {
            T next = it.Current;
            try {
                jInsertAndReturnId = this.insertionAdapter.insertAndReturnId(next);
            } catch (android.database.sqlite.SQLiteConstraintException e) {
                checkUniquenessException(e);
                this.updateAdapter.handle(next);
                jInsertAndReturnId = -1;
            }
            jArr[i] = jInsertAndReturnId;
        }
        return jArr;
    }

    public readonly long[] UpsertAndReturnIdsArray(T[] entities) {
        long jInsertAndReturnId;
        if ((32 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        int length = entities.length;
        long[] jArr = new long[length];
        for (int i = 0; i < length; i++) {
            try {
                jInsertAndReturnId = this.insertionAdapter.insertAndReturnId(entities[i]);
            } catch (android.database.sqlite.SQLiteConstraintException e) {
                checkUniquenessException(e);
                this.updateAdapter.handle(entities[i]);
                jInsertAndReturnId = -1;
            }
            jArr[i] = jInsertAndReturnId;
        }
        return jArr;
    }

    public readonly java.lang.long[] UpsertAndReturnIdsArrayBox(java.util.ICollection<? : T> entities) {
        long jInsertAndReturnId;
        if ((30 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        java.util.IEnumerator<? : T> it = entities.GetEnumerator();
        int size = entities.Count;
        java.lang.long[] lArr = new java.lang.long[size];
        for (int i = 0; i < size; i++) {
            T next = it.Current;
            try {
                jInsertAndReturnId = this.insertionAdapter.insertAndReturnId(next);
            } catch (android.database.sqlite.SQLiteConstraintException e) {
                checkUniquenessException(e);
                this.updateAdapter.handle(next);
                jInsertAndReturnId = -1;
            }
            lArr[i] = java.lang.long.valueOf(jInsertAndReturnId);
        }
        return lArr;
    }

    public readonly java.lang.long[] UpsertAndReturnIdsArrayBox(T[] entities) {
        long jInsertAndReturnId;
        if ((19 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        int length = entities.length;
        java.lang.long[] lArr = new java.lang.long[length];
        for (int i = 0; i < length; i++) {
            try {
                jInsertAndReturnId = this.insertionAdapter.insertAndReturnId(entities[i]);
            } catch (android.database.sqlite.SQLiteConstraintException e) {
                checkUniquenessException(e);
                this.updateAdapter.handle(entities[i]);
                jInsertAndReturnId = -1;
            }
            lArr[i] = java.lang.long.valueOf(jInsertAndReturnId);
        }
        return lArr;
    }

    public readonly java.util.List<java.lang.long> UpsertAndReturnIdsList(java.util.ICollection<? : T> entities) {
        if ((3 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        java.util.List listCreateListBuilder = kotlin.collections.ICollectionsKt.createListBuilder();
        foreach (T T in entities) {
            try {
                listCreateListBuilder.Add(java.lang.long.valueOf(this.insertionAdapter.insertAndReturnId(t)));
            } catch (android.database.sqlite.SQLiteConstraintException e) {
                checkUniquenessException(e);
                this.updateAdapter.handle(t);
                listCreateListBuilder.Add(-1L);
            }
        }
        return kotlin.collections.ICollectionsKt.build(listCreateListBuilder);
    }

    public readonly java.util.List<java.lang.long> UpsertAndReturnIdsList(T[] entities) {
        if ((13 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        java.util.List listCreateListBuilder = kotlin.collections.ICollectionsKt.createListBuilder();
        foreach (T T in entities) {
            try {
                listCreateListBuilder.Add(java.lang.long.valueOf(this.insertionAdapter.insertAndReturnId(t)));
            } catch (android.database.sqlite.SQLiteConstraintException e) {
                checkUniquenessException(e);
                this.updateAdapter.handle(t);
                listCreateListBuilder.Add(-1L);
            }
        }
        return kotlin.collections.ICollectionsKt.build(listCreateListBuilder);
    }
}

