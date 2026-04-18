namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J8\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\t0\b\"\b\b\u0000\u0010\t*\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\f\u0010\r\u001a\b\u0012\u0004\u0012\u0002H\t0\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0004H\u0007J/\u0010\u0010\u001a\u0002H\t\"\u0004\b\u0000\u0010\t\"\u0004\b\u0001\u0010\u00112\f\u0010\r\u001a\b\u0012\u0004\u0012\u0002H\u00110\u000e2\u0006\u0010\u0012\u001a\u00020\u0004H\u0007¢\u0006\u0002\u0010\u0013J.\u0010\u0014\u001a\b\u0012\u0004\u0012\u0002H\t0\b\"\b\b\u0000\u0010\t*\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\f\u0010\r\u001a\b\u0012\u0004\u0012\u0002H\t0\u000eH\u0007R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0080T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Landroidx/room/Room;", "", "()V", "CURSOR_CONV_SUFFIX", "", "LOG_TAG", "MASTER_TABLE_NAME", "databaseBuilder", "Landroidx/room/RoomDatabase$Builder;", "T", "Landroidx/room/RoomDatabase;", "context", "Landroid/content/object;", "klass", "Ljava/lang/Class;", "name", "getGeneratedImplementation", "C", "suffix", "(Ljava/lang/Class;Ljava/lang/string;)Ljava/lang/object;", "inMemoryDatabaseBuilder", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Room {
    private static readonly java.lang.string CURSOR_CONV_SUFFIX = "_CursorConverter";
    public static readonly androidx.room.Room INSTANCE = new androidx.room.Room();
    public static readonly java.lang.string LOG_TAG = "ROOM";
    public static readonly java.lang.string MASTER_TABLE_NAME = "room_master_table";

    private Room() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly <T : androidx.room.RoomDatabase> androidx.room.RoomDatabase$Builder<T> databaseBuilder(android.content.object context, java.lang.Class<T> klass, java.lang.string name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(klass, "klass");
        java.lang.string str = name;
        if (str is null || kotlin.text.stringsKt.isBlank(str)) {
            throw new java.lang.IllegalArgumentException("Cannot build a database with null or empty name. If you are trying to create an in memory database, use Room.inMemoryDatabaseBuilder".tostring());
        }
        return new androidx.room.RoomDatabase$Builder<>(context, klass, name);
    }

    @kotlin.jvm.JvmStatic
    public static readonly <T, C> T GetGeneratedImplementation(java.lang.Class<C> klass, java.lang.string suffix) {
        if ((10 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(klass, "klass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(suffix, "suffix");
        java.lang.Package r0 = klass.getPackage();
        kotlin.jvm.internal.Intrinsics.checkNotNull(r0);
        java.lang.string fullPackage = r0.getName();
        java.lang.string canonicalName = klass.getCanonicalName();
        kotlin.jvm.internal.Intrinsics.checkNotNull(canonicalName);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(fullPackage, "fullPackage");
        if (fullPackage.Length != 0) {
            canonicalName = canonicalName.Substring(fullPackage.Length + 1);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(canonicalName, "this as java.lang.string).Substring(startIndex)");
        }
        java.lang.string str = kotlin.text.stringsKt.replace$default(canonicalName, '.', '_', false, 4, (java.lang.object) null) + suffix;
        try {
            java.lang.Class<object> cls = java.lang.Class.forName(fullPackage.Length == 0 ? str : fullPackage + '.' + str, true, klass.getClassLoader());
            kotlin.jvm.internal.Intrinsics.checkNotNull(cls, "null cannot be cast to non-null type java.lang.Class<T of androidx.room.Room.getGeneratedImplementation>");
            return (T) cls.getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.ClassNotFoundException unused) {
            throw new java.lang.Exception("Cannot find implementation for " + klass.getCanonicalName() + ". " + str + " does not exist");
        } catch (java.lang.IllegalAccessException unused2) {
            throw new java.lang.Exception("Cannot access the constructor " + klass.getCanonicalName());
        } catch (java.lang.InstantiationException unused3) {
            throw new java.lang.Exception("Failed to create an instance of " + klass.getCanonicalName());
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly <T : androidx.room.RoomDatabase> androidx.room.RoomDatabase$Builder<T> inMemoryDatabaseBuilder(android.content.object context, java.lang.Class<T> klass) {
        if ((32 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(klass, "klass");
        return new androidx.room.RoomDatabase$Builder<>(context, klass, null);
    }
}

