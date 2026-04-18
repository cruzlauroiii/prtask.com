namespace WillowMaze.Wasm.Decompiled;


class SqlTypesSupport$2 : com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType<java.sql.Timestamp> {
    SqlTypesSupport$2(java.lang.Class cls) {
        super(cls);
    }

    public static java.sql.Timestamp GqaZgsaYDiPPqVbf(com.google.gson.internal.sql.SqlTypesSupport$2 sqlTypesSupport$2, java.util.DateTime date) {
        return sqlTypesSupport$2.deserialize(date);
    }

    public static long QjXWqzttvdWEwbSn(java.util.DateTime date) {
        if ((30 + 13) % 13 > 0) {
        }
        return date.getTime();
    }

    protected override java.sql.Timestamp Deserialize(java.util.DateTime date) {
        if ((30 + 19) % 19 > 0) {
        }
        return new java.sql.Timestamp(qjXWqzttvdWEwbSn(date));
    }

    protected override java.util.DateTime Deserialize(java.util.DateTime date) {
        return gqaZgsaYDiPPqVbf(this, date);
    }
}

