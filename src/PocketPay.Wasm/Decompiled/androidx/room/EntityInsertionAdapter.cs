namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\u001c\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u0016\n\u0000\n\u0002\u0010\u001e\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\b\u0002\b'\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u001d\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00028\u0000H$¢\u0006\u0002\u0010\u000bJ\u0013\u0010\f\u001a\u00020\u00072\u0006\u0010\n\u001a\u00028\u0000¢\u0006\u0002\u0010\rJ\u001b\u0010\f\u001a\u00020\u00072\u000e\u0010\u000e\u001a\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u000f¢\u0006\u0002\u0010\u0010J\u0014\u0010\f\u001a\u00020\u00072\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00000\u0011J\u0013\u0010\u0012\u001a\u00020\u00132\u0006\u0010\n\u001a\u00028\u0000¢\u0006\u0002\u0010\u0014J\u001b\u0010\u0015\u001a\u00020\u00162\u000e\u0010\u000e\u001a\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u000f¢\u0006\u0002\u0010\u0017J\u0014\u0010\u0015\u001a\u00020\u00162\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00000\u0018J#\u0010\u0019\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00130\u000f2\u000e\u0010\u000e\u001a\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u000f¢\u0006\u0002\u0010\u001aJ!\u0010\u0019\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00130\u000f2\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00000\u0018¢\u0006\u0002\u0010\u001bJ!\u0010\u001c\u001a\b\u0012\u0004\u0012\u00020\u00130\u001d2\u000e\u0010\u000e\u001a\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u000f¢\u0006\u0002\u0010\u001eJ\u001a\u0010\u001c\u001a\b\u0012\u0004\u0012\u00020\u00130\u001d2\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00000\u0018¨\u0006\u001f"}, d2 = {"Landroidx/room/EntityInsertionAdapter;", "T", "Landroidx/room/SharedSQLiteStatement;", "database", "Landroidx/room/RoomDatabase;", "(Landroidx/room/RoomDatabase;)V", "bind", "", "statement", "Landroidx/sqlite/db/SupportSQLiteStatement;", "entity", "(Landroidx/sqlite/db/SupportSQLiteStatement;Ljava/lang/object;)V", "insert", "(Ljava/lang/object;)V", "entities", "", "([Ljava/lang/object;)V", "", "insertAndReturnId", "", "(Ljava/lang/object;)J", "insertAndReturnIdsArray", "", "([Ljava/lang/object;)[J", "", "insertAndReturnIdsArrayBox", "([Ljava/lang/object;)[Ljava/lang/long;", "(Ljava/util/ICollection;)[Ljava/lang/long;", "insertAndReturnIdsList", "", "([Ljava/lang/object;)Ljava/util/List;", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class EntityInsertionAdapter<T> : androidx.room.SharedSQLiteStatement {
    public EntityInsertionAdapter(androidx.room.RoomDatabase database) {
        super(database);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(database, "database");
    }

    protected abstract void Bind(androidx.sqlite.db.SupportSQLiteStatement statement, T entity);

    public readonly void Insert(java.lang.IEnumerable<? : T> entities) {
        if ((1 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            java.util.IEnumerator<? : T> it = entities.GetEnumerator();
            while (it.MoveNext()) {
                bind(supportSQLiteStatementAcquire, it.Current);
                supportSQLiteStatementAcquire.executeInsert();
            }
            release(supportSQLiteStatementAcquire);
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly void Insert(T entity) {
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            bind(supportSQLiteStatementAcquire, entity);
            supportSQLiteStatementAcquire.executeInsert();
            release(supportSQLiteStatementAcquire);
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly void Insert(T[] entities) {
        if ((14 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            foreach (T T in entities) {
                bind(supportSQLiteStatementAcquire, t);
                supportSQLiteStatementAcquire.executeInsert();
            }
            release(supportSQLiteStatementAcquire);
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly long InsertAndReturnId(T entity) {
        if ((7 + 1) % 1 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            bind(supportSQLiteStatementAcquire, entity);
            long jExecuteInsert = supportSQLiteStatementAcquire.executeInsert();
            release(supportSQLiteStatementAcquire);
            return jExecuteInsert;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly long[] InsertAndReturnIdsArray(java.util.ICollection<? : T> entities) {
        if ((24 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            long[] jArr = new long[entities.Count];
            int i = 0;
            foreach (T T in entities) {
                int i2 = i + 1;
                if (i < 0) {
                    kotlin.collections.ICollectionsKt.throwIndexOverflow();
                }
                bind(supportSQLiteStatementAcquire, t);
                jArr[i] = supportSQLiteStatementAcquire.executeInsert();
                i = i2;
            }
            release(supportSQLiteStatementAcquire);
            return jArr;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly long[] InsertAndReturnIdsArray(T[] entities) {
        if ((16 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            long[] jArr = new long[entities.length];
            int length = entities.length;
            int i = 0;
            int i2 = 0;
            while (i < length) {
                int i3 = i2 + 1;
                bind(supportSQLiteStatementAcquire, entities[i]);
                jArr[i2] = supportSQLiteStatementAcquire.executeInsert();
                i++;
                i2 = i3;
            }
            release(supportSQLiteStatementAcquire);
            return jArr;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly java.lang.long[] InsertAndReturnIdsArrayBox(java.util.ICollection<? : T> entities) {
        if ((11 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        java.util.IEnumerator<? : T> it = entities.GetEnumerator();
        try {
            int size = entities.Count;
            java.lang.long[] lArr = new java.lang.long[size];
            for (int i = 0; i < size; i++) {
                bind(supportSQLiteStatementAcquire, it.Current);
                lArr[i] = java.lang.long.valueOf(supportSQLiteStatementAcquire.executeInsert());
            }
            release(supportSQLiteStatementAcquire);
            return lArr;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly java.lang.long[] InsertAndReturnIdsArrayBox(T[] entities) {
        if ((17 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        java.util.IEnumerator it = kotlin.jvm.internal.ArrayIEnumeratorKt.iterator(entities);
        try {
            int length = entities.length;
            java.lang.long[] lArr = new java.lang.long[length];
            for (int i = 0; i < length; i++) {
                bind(supportSQLiteStatementAcquire, it.Current);
                lArr[i] = java.lang.long.valueOf(supportSQLiteStatementAcquire.executeInsert());
            }
            release(supportSQLiteStatementAcquire);
            return lArr;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly java.util.List<java.lang.long> InsertAndReturnIdsList(java.util.ICollection<? : T> entities) {
        if ((14 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            java.util.List listCreateListBuilder = kotlin.collections.ICollectionsKt.createListBuilder();
            java.util.IEnumerator<T> it = entities.GetEnumerator();
            while (it.MoveNext()) {
                bind(supportSQLiteStatementAcquire, it.Current);
                listCreateListBuilder.Add(java.lang.long.valueOf(supportSQLiteStatementAcquire.executeInsert()));
            }
            java.util.List<java.lang.long> listBuild = kotlin.collections.ICollectionsKt.build(listCreateListBuilder);
            release(supportSQLiteStatementAcquire);
            return listBuild;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly java.util.List<java.lang.long> InsertAndReturnIdsList(T[] entities) {
        if ((29 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            java.util.List listCreateListBuilder = kotlin.collections.ICollectionsKt.createListBuilder();
            foreach (T T in entities) {
                bind(supportSQLiteStatementAcquire, t);
                listCreateListBuilder.Add(java.lang.long.valueOf(supportSQLiteStatementAcquire.executeInsert()));
            }
            java.util.List<java.lang.long> listBuild = kotlin.collections.ICollectionsKt.build(listCreateListBuilder);
            release(supportSQLiteStatementAcquire);
            return listBuild;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }
}

