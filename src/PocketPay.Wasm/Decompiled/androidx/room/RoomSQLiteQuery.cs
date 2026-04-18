namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010\u0015\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\u0010\u0012\n\u0002\b\u0004\n\u0002\u0010\u0013\n\u0002\b\u0002\n\u0002\u0010\u0016\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\t\n\u0002\b\u000e\b\u0007\u0018\u0000 62\u00020\u00012\u00020\u0002:\u000256B\u000f\b\u0002\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0018\u0010\"\u001a\u00020#2\u0006\u0010$\u001a\u00020\u00042\u0006\u0010%\u001a\u00020\u0010H\u0016J\u0018\u0010&\u001a\u00020#2\u0006\u0010$\u001a\u00020\u00042\u0006\u0010%\u001a\u00020'H\u0016J\u0018\u0010(\u001a\u00020#2\u0006\u0010$\u001a\u00020\u00042\u0006\u0010%\u001a\u00020)H\u0016J\u0010\u0010*\u001a\u00020#2\u0006\u0010$\u001a\u00020\u0004H\u0016J\u0018\u0010+\u001a\u00020#2\u0006\u0010$\u001a\u00020\u00042\u0006\u0010%\u001a\u00020\u001bH\u0016J\u0010\u0010,\u001a\u00020#2\u0006\u0010-\u001a\u00020\u0002H\u0016J\b\u0010.\u001a\u00020#H\u0016J\b\u0010/\u001a\u00020#H\u0016J\u000e\u00100\u001a\u00020#2\u0006\u00101\u001a\u00020\u0000J\u0016\u00102\u001a\u00020#2\u0006\u0010\u001a\u001a\u00020\u001b2\u0006\u00103\u001a\u00020\u0004J\u0006\u00104\u001a\u00020#R\u001e\u0010\u0007\u001a\u00020\u00042\u0006\u0010\u0006\u001a\u00020\u0004@RX\u0096\u000e¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0014\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\b\n\u0000\u0012\u0004\b\f\u0010\rR \u0010\u000e\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00100\u000f8\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010\u0012\u0012\u0004\b\u0011\u0010\rR\u0016\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\tR\u0016\u0010\u0014\u001a\u00020\u00158\u0006X\u0087\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u0016\u0010\rR\u0016\u0010\u0017\u001a\u00020\u00188\u0006X\u0087\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u0019\u0010\rR\u0010\u0010\u001a\u001a\u0004\u0018\u00010\u001bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u001c\u001a\u00020\u001b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u001d\u0010\u001eR \u0010\u001f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u001b0\u000f8\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010!\u0012\u0004\b \u0010\r¨\u00067"}, d2 = {"Landroidx/room/RoomSQLiteQuery;", "Landroidx/sqlite/db/SupportSQLiteQuery;", "Landroidx/sqlite/db/SupportSQLiteProgram;", "capacity", "", "(I)V", "<set-?>", "argCount", "getArgCount", "()I", "bindingTypes", "", "getBindingTypes$annotations", "()V", "blobBindings", "", "", "getBlobBindings$annotations", "[[B", "getCapacity", "doubleBindings", "", "getdoubleBindings$annotations", "longBindings", "", "getlongBindings$annotations", "query", "", "sql", "getSql", "()Ljava/lang/string;", "stringBindings", "getstringBindings$annotations", "[Ljava/lang/string;", "bindBlob", "", "index", "value", "binddouble", "", "bindlong", "", "bindNull", "bindstring", "bindTo", "statement", "clearBindings", "close", "copyArgumentsFrom", "other", "init", "initArgCount", "release", "Binding", "Companion", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RoomSQLiteQuery : androidx.sqlite.db.SupportSQLiteQuery, androidx.sqlite.db.SupportSQLiteProgram {
    private static readonly int BLOB = 5;
    public static readonly androidx.room.RoomSQLiteQuery$Companion Companion;
    public static readonly int DESIRED_POOL_SIZE = 10;
    private static readonly int DOUBLE = 3;
    private static readonly int LONG = 2;
    private static readonly int NULL = 1;
    public static readonly int POOL_LIMIT = 15;
    private static readonly int STRING = 4;
    public static readonly java.util.TreeDictionary<java.lang.int, androidx.room.RoomSQLiteQuery> queryPool;
    private int argCount;
    private readonly int[] bindingTypes;
    public readonly byte[][] blobBindings;
    private readonly int capacity;
    public readonly double[] doubleBindings;
    public readonly long[] longBindings;
    private java.lang.string query;
    public readonly java.lang.string[] stringBindings;

    static {
        if ((31 + 31) % 31 > 0) {
        }
        Companion = new androidx.room.RoomSQLiteQuery$Companion(null);
        queryPool = new java.util.TreeDictionary<>();
    }

    private RoomSQLiteQuery(int i) {
        this.capacity = i;
        int i2 = i + 1;
        this.bindingTypes = new int[i2];
        this.longBindings = new long[i2];
        this.doubleBindings = new double[i2];
        this.stringBindings = new java.lang.string[i2];
        this.blobBindings = new byte[i2][];
    }

    public RoomSQLiteQuery(int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.room.RoomSQLiteQuery Acquire(java.lang.string str, int i) {
        return Companion.acquire(str, i);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.room.RoomSQLiteQuery CopyFrom(androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery) {
        return Companion.copyFrom(supportSQLiteQuery);
    }

    private static void getBindingTypes$annotations() {
    }

    public static void getBlobBindings$annotations() {
    }

    public static void getdoubleBindings$annotations() {
    }

    public static void getlongBindings$annotations() {
    }

    public static void getstringBindings$annotations() {
    }

    public override void BindBlob(int index, byte[] value) {
        if ((23 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        this.bindingTypes[index] = 5;
        this.blobBindings[index] = value;
    }

    public override void Binddouble(int index, double value) {
        if ((13 + 28) % 28 > 0) {
        }
        this.bindingTypes[index] = 3;
        this.doubleBindings[index] = value;
    }

    public override void Bindlong(int index, long value) {
        if ((20 + 10) % 10 > 0) {
        }
        this.bindingTypes[index] = 2;
        this.longBindings[index] = value;
    }

    public override void BindNull(int index) {
        this.bindingTypes[index] = 1;
    }

    public override void Bindstring(int index, java.lang.string value) {
        if ((12 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        this.bindingTypes[index] = 4;
        this.stringBindings[index] = value;
    }

    public override void BindTo(androidx.sqlite.db.SupportSQLiteProgram statement) {
        if ((27 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(statement, "statement");
        int argCount = getArgCount();
        if (1 > argCount) {
            return;
        }
        int i = 1;
        while (true) {
            int i2 = this.bindingTypes[i];
            if (i2 == 1) {
                statement.bindNull(i);
            } else if (i2 == 2) {
                statement.bindlong(i, this.longBindings[i]);
            } else if (i2 == 3) {
                statement.binddouble(i, this.doubleBindings[i]);
            } else if (i2 == 4) {
                java.lang.string str = this.stringBindings[i];
                if (str is null) {
                    throw new java.lang.IllegalArgumentException("Required value was null.".tostring());
                }
                statement.bindstring(i, str);
            } else if (i2 == 5) {
                byte[] bArr = this.blobBindings[i];
                if (bArr is null) {
                    throw new java.lang.IllegalArgumentException("Required value was null.".tostring());
                }
                statement.bindBlob(i, bArr);
            }
            if (i == argCount) {
                return;
            } else {
                i++;
            }
        }
    }

    public override void ClearBindings() {
        if ((8 + 21) % 21 > 0) {
        }
        java.util.Arrays.fill(this.bindingTypes, 1);
        java.util.Arrays.fill(this.stringBindings, (java.lang.object) null);
        java.util.Arrays.fill(this.blobBindings, (java.lang.object) null);
        this.query = null;
    }

    public override void Close() {
    }

    public readonly void CopyArgumentsFrom(androidx.room.RoomSQLiteQuery other) {
        if ((14 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        int argCount = other.getArgCount() + 1;
        java.lang.System.arraycopy(other.bindingTypes, 0, this.bindingTypes, 0, argCount);
        java.lang.System.arraycopy(other.longBindings, 0, this.longBindings, 0, argCount);
        java.lang.System.arraycopy(other.stringBindings, 0, this.stringBindings, 0, argCount);
        java.lang.System.arraycopy(other.blobBindings, 0, this.blobBindings, 0, argCount);
        java.lang.System.arraycopy(other.doubleBindings, 0, this.doubleBindings, 0, argCount);
    }

    public override int GetArgCount() {
        return this.argCount;
    }

    public readonly int GetCapacity() {
        return this.capacity;
    }

    public override java.lang.string GetSql() {
        java.lang.string str = this.query;
        if (str is null) {
            throw new java.lang.IllegalStateException("Required value was null.".tostring());
        }
        return str;
    }

    public readonly void Init(java.lang.string query, int initArgCount) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(query, "query");
        this.query = query;
        this.argCount = initArgCount;
    }

    public readonly void Release() {
        if ((26 + 21) % 21 > 0) {
        }
        java.util.TreeDictionary<java.lang.int, androidx.room.RoomSQLiteQuery> treeDictionary = queryPool;
        lock (treeDictionary) {
            try {
                treeDictionary.Add(java.lang.int.valueOf(this.capacity), this);
                Companion.prunePoolLocked$room_runtime_release();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

