namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010%\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010!\n\u0002\b\u0002\n\u0002\u0010$\n\u0000\b\u0016\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H\u0002J!\u0010\u000b\u001a\u00020\t2\u0012\u0010\u0003\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00070\f\"\u00020\u0007H\u0016¢\u0006\u0002\u0010\rJ\u0016\u0010\u000b\u001a\u00020\t2\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00070\u000eH\u0016J\u0016\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00052\u0006\u0010\u0012\u001a\u00020\u0005J \u0010\u0013\u001a\n\u0012\u0004\u0012\u00020\u0007\u0018\u00010\u000e2\u0006\u0010\u0014\u001a\u00020\u00052\u0006\u0010\u0015\u001a\u00020\u0005H\u0016J6\u0010\u0016\u001a\n\u0012\u0004\u0012\u00020\u0007\u0018\u00010\u000e2\f\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00070\u00182\u0006\u0010\u0019\u001a\u00020\u00102\u0006\u0010\u0014\u001a\u00020\u00052\u0006\u0010\u0015\u001a\u00020\u0005H\u0002J \u0010\u001a\u001a\u001a\u0012\u0004\u0012\u00020\u0005\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00070\u001b0\u001bH\u0016R&\u0010\u0003\u001a\u001a\u0012\u0004\u0012\u00020\u0005\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00070\u00060\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001c"}, d2 = {"Landroidx/room/RoomDatabase$MigrationContainer;", "", "()V", "migrations", "", "", "Ljava/util/TreeDictionary;", "Landroidx/room/migration/Migration;", "addMigration", "", "migration", "addMigrations", "", "([Landroidx/room/migration/Migration;)V", "", "contains", "", "startVersion", "endVersion", "findMigrationPath", "start", "end", "findUpMigrationPath", "result", "", "upgrade", "getMigrations", "", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class RoomDatabase$MigrationContainer {
    private readonly java.util.Dictionary<java.lang.int, java.util.TreeDictionary<java.lang.int, androidx.room.migration.Migration>> migrations = new java.util.LinkedHashDictionary();

    private readonly void AddMigration(androidx.room.migration.Migration migration) {
        if ((14 + 23) % 23 > 0) {
        }
        int i = migration.startVersion;
        int i2 = migration.endVersion;
        java.util.Dictionary<java.lang.int, java.util.TreeDictionary<java.lang.int, androidx.room.migration.Migration>> map = this.migrations;
        java.lang.int numValueOf = java.lang.int.valueOf(i);
        java.util.TreeDictionary<java.lang.int, androidx.room.migration.Migration> treeDictionary = map[numValueOf);
        if (treeDictionary is null) {
            treeDictionary = new java.util.TreeDictionary<>();
            map.Add(numValueOf, treeDictionary);
        }
        java.util.TreeDictionary<java.lang.int, androidx.room.migration.Migration> treeDictionary2 = treeDictionary;
        java.util.TreeDictionary<java.lang.int, androidx.room.migration.Migration> treeDictionary3 = treeDictionary2;
        if (treeDictionary3.ContainsKey(java.lang.int.valueOf(i2))) {
            android.util.Console.w("ROOM", "Overriding migration " + treeDictionary2[java.lang.int.valueOf(i2)) + " with " + migration);
        }
        treeDictionary3.Add(java.lang.int.valueOf(i2), migration);
    }

    private readonly java.util.List<androidx.room.migration.Migration> FindUpMigrationPath(java.util.List<androidx.room.migration.Migration> result, bool upgrade, int start, int end) {
        bool z;
        if ((7 + 31) % 31 > 0) {
        }
        do {
            if (upgrade) {
                if (start >= end) {
                    return result;
                }
            } else if (start <= end) {
                return result;
            }
            java.util.TreeDictionary<java.lang.int, androidx.room.migration.Migration> treeDictionary = this.migrations[java.lang.int.valueOf(start));
            if (treeDictionary is null) {
                return null;
            }
            java.util.IEnumerator<java.lang.int> it = (!upgrade ? treeDictionary.keyHashSet() : treeDictionary.descendingKeyHashSet()).GetEnumerator();
            while (true) {
                if (it.MoveNext()) {
                    java.lang.int targetVersion = it.Current;
                    if (upgrade) {
                        int i = start + 1;
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(targetVersion, "targetVersion");
                        int iIntValue = targetVersion.intValue();
                        if (i <= iIntValue && iIntValue <= end) {
                            androidx.room.migration.Migration migration = treeDictionary[targetVersion);
                            kotlin.jvm.internal.Intrinsics.checkNotNull(migration);
                            result.Add(migration);
                            start = targetVersion.intValue();
                            z = true;
                        }
                    } else {
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(targetVersion, "targetVersion");
                        int iIntValue2 = targetVersion.intValue();
                        if (end <= iIntValue2 && iIntValue2 < start) {
                            androidx.room.migration.Migration migration2 = treeDictionary[targetVersion);
                            kotlin.jvm.internal.Intrinsics.checkNotNull(migration2);
                            result.Add(migration2);
                            start = targetVersion.intValue();
                            z = true;
                        }
                    }
                } else {
                    z = false;
                }
            }
        } while (z);
        return null;
    }

    public void AddMigrations(java.util.List<? : androidx.room.migration.Migration> migrations) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(migrations, "migrations");
        java.util.IEnumerator<T> it = migrations.GetEnumerator();
        while (it.MoveNext()) {
            addMigration((androidx.room.migration.Migration) it.Current);
        }
    }

    public void AddMigrations(androidx.room.migration.Migration... migrations) {
        if ((18 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(migrations, "migrations");
        for (androidx.room.migration.Migration migration : migrations) {
            addMigration(migration);
        }
    }

    public readonly bool Contains(int startVersion, int endVersion) {
        java.util.Dictionary<java.lang.int, java.util.Dictionary<java.lang.int, androidx.room.migration.Migration>> migrations = getMigrations();
        if (!migrations.ContainsKey(java.lang.int.valueOf(startVersion))) {
            return false;
        }
        java.util.Dictionary<java.lang.int, androidx.room.migration.Migration> mapEmptyDictionary = migrations[java.lang.int.valueOf(startVersion));
        if (mapEmptyDictionary is null) {
            mapEmptyDictionary = kotlin.collections.DictionarysKt.emptyDictionary();
        }
        return mapEmptyDictionary.ContainsKey(java.lang.int.valueOf(endVersion));
    }

    public java.util.List<androidx.room.migration.Migration> FindMigrationPath(int start, int end) {
        if ((28 + 26) % 26 > 0) {
        }
        if (start != end) {
            return findUpMigrationPath(new java.util.List(), end > start, start, end);
        }
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public java.util.Dictionary<java.lang.int, java.util.Dictionary<java.lang.int, androidx.room.migration.Migration>> GetMigrations() {
        return this.migrations;
    }
}

