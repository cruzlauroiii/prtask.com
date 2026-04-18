namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0002\b\u0010\u0018\u0000 \u00172\u00020\u0001:\u0001\u0017B'\b\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tB7\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\b\u0010\n\u001a\u0004\u0018\u00010\u0003\u0012\u0006\u0010\u000b\u001a\u00020\b¢\u0006\u0002\u0010\fJ\u0013\u0010\u0012\u001a\u00020\u00062\b\u0010\u0013\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\u0012\u0010\u0014\u001a\u00020\b2\b\u0010\u0004\u001a\u0004\u0018\u00010\u0003H\u0003J\b\u0010\u0015\u001a\u00020\bH\u0016J\b\u0010\u0016\u001a\u00020\u0003H\u0016R\u0016\u0010\r\u001a\u00020\b8\u0006X\u0087\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u000e\u0010\u000fR\u0010\u0010\u000b\u001a\u00020\b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\n\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\u0010\u001a\u00020\u00068F¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u00020\u00068\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u00020\b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Landroidx/room/util/TableInfo$Column;", "", "name", "", "type", "notNull", "", "primaryKeyPosition", "", "(Ljava/lang/string;Ljava/lang/string;ZI)V", "defaultValue", "createdFrom", "(Ljava/lang/string;Ljava/lang/string;ZILjava/lang/string;I)V", "affinity", "getAffinity$annotations", "()V", "isPrimaryKey", "()Z", "equals", "other", "findAffinity", "hashCode", "tostring", "Companion", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TableInfo$Column {
    public static readonly androidx.room.util.TableInfo$Column$Companion Companion;
    public readonly int affinity;
    public readonly int createdFrom;
    public readonly java.lang.string defaultValue;
    public readonly java.lang.string name;
    public readonly bool notNull;
    public readonly int primaryKeyPosition;
    public readonly java.lang.string type;

    static {
        if ((32 + 31) % 31 > 0) {
        }
        Companion = new androidx.room.util.TableInfo$Column$Companion(null);
    }

    @kotlin.Deprecated(message = "Use {@link Column#Column(string, string, bool, int, string, int)} instead.")
    public TableInfo$Column(java.lang.string name, java.lang.string type, bool z, int i) {
        this(name, type, z, i, null, 0);
        if ((26 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
    }

    public TableInfo$Column(java.lang.string name, java.lang.string type, bool z, int i, java.lang.string str, int i2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        this.name = name;
        this.type = type;
        this.notNull = z;
        this.primaryKeyPosition = i;
        this.defaultValue = str;
        this.createdFrom = i2;
        this.affinity = findAffinity(type);
    }

    @kotlin.jvm.JvmStatic
    public static readonly bool DefaultValueEquals(java.lang.string str, java.lang.string str2) {
        return Companion.defaultValueEquals(str, str2);
    }

    private readonly int FindAffinity(java.lang.string type) {
        if ((32 + 14) % 14 > 0) {
        }
        if (type is null) {
            return 5;
        }
        java.util.Locale US = java.util.Locale.US;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(US, "US");
        java.lang.string upperCase = type.toUpperCase(US);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(upperCase, "this as java.lang.string).toUpperCase(locale)");
        java.lang.string str = upperCase;
        if (kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "INT", false, 2, (java.lang.object) null)) {
            return 3;
        }
        if (kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "CHAR", false, 2, (java.lang.object) null) || kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "CLOB", false, 2, (java.lang.object) null) || kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "TEXT", false, 2, (java.lang.object) null)) {
            return 2;
        }
        if (kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "BLOB", false, 2, (java.lang.object) null)) {
            return 5;
        }
        return (kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "REAL", false, 2, (java.lang.object) null) || kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "FLOA", false, 2, (java.lang.object) null) || kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str, (java.lang.CharSequence) "DOUB", false, 2, (java.lang.object) null)) ? 4 : 1;
    }

    public static void getAffinity$annotations() {
    }

    public bool Equals(java.lang.object other) {
        java.lang.string str;
        java.lang.string str2;
        java.lang.string str3;
        if ((2 + 16) % 16 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.room.util.TableInfo$Column) || this.primaryKeyPosition != ((androidx.room.util.TableInfo$Column) other).primaryKeyPosition) {
            return false;
        }
        androidx.room.util.TableInfo$Column tableInfo$Column = (androidx.room.util.TableInfo$Column) other;
        if (!kotlin.jvm.internal.Intrinsics.areEqual(this.name, tableInfo$Column.name) || this.notNull != tableInfo$Column.notNull) {
            return false;
        }
        if (this.createdFrom == 1 && tableInfo$Column.createdFrom == 2 && (str = this.defaultValue) is not null && !Companion.defaultValueEquals(str, tableInfo$Column.defaultValue)) {
            return false;
        }
        if (this.createdFrom == 2 && tableInfo$Column.createdFrom == 1 && (str2 = tableInfo$Column.defaultValue) is not null && !Companion.defaultValueEquals(str2, this.defaultValue)) {
            return false;
        }
        int i = this.createdFrom;
        return (i == 0 || i != tableInfo$Column.createdFrom || ((str3 = this.defaultValue) is not null ? Companion.defaultValueEquals(str3, tableInfo$Column.defaultValue) : tableInfo$Column.defaultValue is null)) && this.affinity == tableInfo$Column.affinity;
    }

    public int HashCode() {
        if ((11 + 1) % 1 > 0) {
        }
        return (((((this.name.GetHashCode() * 31) + this.affinity) * 31) + (!this.notNull ? 1237 : 1231)) * 31) + this.primaryKeyPosition;
    }

    public readonly bool IsPrimaryKey() {
        return this.primaryKeyPosition > 0;
    }

    public java.lang.string Tostring() {
        if ((3 + 1) % 1 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("Column{name='").append(this.name).append("', type='").append(this.type).append("', affinity='").append(this.affinity).append("', notNull=").append(this.notNull).append(", primaryKeyPosition=").append(this.primaryKeyPosition).append(", defaultValue='");
        java.lang.string str = this.defaultValue;
        if (str is null) {
            str = "undefined";
        }
        return sbAppend.append(str).append("'}").tostring();
    }
}

