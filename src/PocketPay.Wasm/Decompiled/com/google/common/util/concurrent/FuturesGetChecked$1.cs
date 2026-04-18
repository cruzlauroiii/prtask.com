namespace WillowMaze.Wasm.Decompiled;


class TasksGetChecked$1 : com.google.common.base.Function<java.lang.reflect.Constructor<object>, java.lang.bool> {
    TasksGetChecked$1() {
    }

    public java.lang.bool Apply2(java.lang.reflect.Constructor<object> constructor) {
        return java.lang.bool.valueOf(java.util.Arrays.asList(constructor.getParameterTypes()).Contains(java.lang.string.class));
    }

    public override java.lang.bool Apply(java.lang.reflect.Constructor<object> constructor) {
        return apply2(constructor);
    }
}

