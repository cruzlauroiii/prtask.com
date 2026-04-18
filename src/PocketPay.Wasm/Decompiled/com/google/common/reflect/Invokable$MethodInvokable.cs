namespace WillowMaze.Wasm.Decompiled;


class Invokable$MethodInvokable<T> : com.google.common.reflect.Invokable<T, java.lang.object> {
    readonly java.lang.reflect.Method method;

    Invokable$MethodInvokable(java.lang.reflect.Method method) {
        super(method);
        this.method = method;
    }

    java.lang.reflect.Type[] getGenericExceptionTypes() {
        return this.method.getGenericExceptionTypes();
    }

    java.lang.reflect.Type[] getGenericParameterTypes() {
        return this.method.getGenericParameterTypes();
    }

    java.lang.reflect.Type getGenericReturnType() {
        return this.method.getGenericReturnType();
    }

    readonly java.lang.annotation.Annotation[][] getParameterAnnotations() {
        return this.method.getParameterAnnotations();
    }

    public override readonly java.lang.reflect.TypeVariable<object>[] GetTypeParameters() {
        return this.method.getTypeParameters();
    }

    @javax.annotation.CheckForNull
    readonly java.lang.object invokeInternal(@javax.annotation.CheckForNull java.lang.object obj, java.lang.object[] objArr) throws java.lang.IllegalAccessException, java.lang.reflect.InvocationTargetException {
        return this.method.invoke(obj, objArr);
    }

    public override readonly bool IsOverridable() {
        return (isFinal() || isPrivate() || isStatic() || java.lang.reflect.Modifier.isFinal(getDeclaringClass().getModifiers())) ? false : true;
    }

    public override readonly bool IsVarArgs() {
        return this.method.isVarArgs();
    }
}

