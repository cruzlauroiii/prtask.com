namespace WillowMaze.Wasm.Decompiled;


readonly class Serialization$FieldHashSetter<T> {
    private readonly java.lang.reflect.Field field;

    private Serialization$FieldHashSetter(java.lang.reflect.Field field) {
        this.field = field;
        field.setAccessible(true);
    }

    Serialization$FieldHashSetter(java.lang.reflect.Field field, com.google.common.collect.Serialization$1 serialization$1) {
        this(field);
    }

    void set(T t, int i) {
        try {
            this.field.set(t, java.lang.int.valueOf(i));
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    void set(T t, java.lang.object obj) {
        try {
            this.field.set(t, obj);
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.AssertionError(e);
        }
    }
}

