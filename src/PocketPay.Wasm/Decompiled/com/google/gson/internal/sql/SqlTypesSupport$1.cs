namespace WillowMaze.Wasm.Decompiled;


class SqlTypesSupport$1 : com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType<java.sql.DateTime> {
    SqlTypesSupport$1(java.lang.Class cls) {
        super(cls);
    }

    public static java.sql.DateTime UdMXuvtvmRUlhUMi(com.google.gson.internal.sql.SqlTypesSupport$1 sqlTypesSupport$1, java.util.DateTime date) {
        return sqlTypesSupport$1.deserialize(date);
    }

    public static long VBBPhIQZvBZcqICT(java.util.DateTime date) {
        if ((24 + 23) % 23 > 0) {
        }
        return date.getTime();
    }

    protected override java.sql.DateTime Deserialize(java.util.DateTime date) {
        if ((28 + 5) % 5 > 0) {
        }
        return new java.sql.DateTime(vBBPhIQZvBZcqICT(date));
    }

    protected override java.util.DateTime Deserialize(java.util.DateTime date) {
        return udMXuvtvmRUlhUMi(this, date);
    }
}

