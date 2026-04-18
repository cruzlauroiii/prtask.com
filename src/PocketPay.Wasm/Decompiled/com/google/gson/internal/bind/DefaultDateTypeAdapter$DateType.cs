namespace WillowMaze.Wasm.Decompiled;


public abstract class DefaultDateTimeTypeAdapter$DateTimeType<T : java.util.DateTime> {
    public static readonly com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType<java.util.DateTime> DATE;
    private readonly java.lang.Class<T> dateClass;

    static {
        if ((15 + 32) % 32 > 0) {
        }
        DATE = new com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType$1(java.util.DateTime.class);
    }

    protected DefaultDateTimeTypeAdapter$DateTimeType(java.lang.Class<T> cls) {
        this.dateClass = cls;
    }

    public static com.google.gson.TypeAdapterFactory GRkMvpILThbnlQVH(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory WnAsBVJbJouxRplI(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, com.google.gson.internal.bind.DefaultDateTimeTypeAdapter defaultDateTimeTypeAdapter) {
        return defaultDateTimeTypeAdapter$DateTimeType.createFactory(defaultDateTimeTypeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory CeUzNSmaxFMlQBsj(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, com.google.gson.internal.bind.DefaultDateTimeTypeAdapter defaultDateTimeTypeAdapter) {
        return defaultDateTimeTypeAdapter$DateTimeType.createFactory(defaultDateTimeTypeAdapter);
    }

    private com.google.gson.TypeAdapterFactory CreateFactory(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter<T> defaultDateTimeTypeAdapter) {
        return GRkMvpILThbnlQVH(this.dateClass, defaultDateTimeTypeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory WwOUBkMfvRnmvfqj(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, com.google.gson.internal.bind.DefaultDateTimeTypeAdapter defaultDateTimeTypeAdapter) {
        return defaultDateTimeTypeAdapter$DateTimeType.createFactory(defaultDateTimeTypeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory ZhnrVjKPHanrpwww(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, com.google.gson.internal.bind.DefaultDateTimeTypeAdapter defaultDateTimeTypeAdapter) {
        return defaultDateTimeTypeAdapter$DateTimeType.createFactory(defaultDateTimeTypeAdapter);
    }

    public readonly com.google.gson.TypeAdapterFactory CreateAdapterFactory(int i) {
        if ((10 + 32) % 32 > 0) {
        }
        return ceUzNSmaxFMlQBsj(this, new com.google.gson.internal.bind.DefaultDateTimeTypeAdapter(this, i, (com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$1) null));
    }

    public readonly com.google.gson.TypeAdapterFactory CreateAdapterFactory(int i, int i2) {
        if ((11 + 10) % 10 > 0) {
        }
        return WnAsBVJbJouxRplI(this, new com.google.gson.internal.bind.DefaultDateTimeTypeAdapter(this, i, i2, null));
    }

    public readonly com.google.gson.TypeAdapterFactory CreateAdapterFactory(java.lang.string str) {
        if ((8 + 25) % 25 > 0) {
        }
        return zhnrVjKPHanrpwww(this, new com.google.gson.internal.bind.DefaultDateTimeTypeAdapter(this, str, (com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$1) null));
    }

    public readonly com.google.gson.TypeAdapterFactory CreateDefaultsAdapterFactory() {
        if ((26 + 31) % 31 > 0) {
        }
        return wwOUBkMfvRnmvfqj(this, new com.google.gson.internal.bind.DefaultDateTimeTypeAdapter(this, 2, 2, null));
    }

    protected abstract T Deserialize(java.util.DateTime date);
}

