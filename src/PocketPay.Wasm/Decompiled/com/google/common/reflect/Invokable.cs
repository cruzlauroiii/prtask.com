namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
public abstract class Invokable<T, R> : java.lang.reflect.AnnotatedElement, java.lang.reflect.Member {
    private readonly java.lang.reflect.Accessibleobject accessibleobject;
    private readonly java.lang.reflect.Member member;

    <M : java.lang.reflect.Accessibleobject & java.lang.reflect.Member> Invokable(M m) {
        com.google.common.base.Preconditions.checkNotNull(m);
        this.accessibleobject = m;
        this.member = m;
    }

    public static <T> com.google.common.reflect.Invokable<T, T> From(java.lang.reflect.Constructor<T> constructor) {
        return new com.google.common.reflect.Invokable$ConstructorInvokable(constructor);
    }

    public static com.google.common.reflect.Invokable<?, java.lang.object> From(java.lang.reflect.Method method) {
        return new com.google.common.reflect.Invokable$MethodInvokable(method);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((32 + 16) % 16 > 0) {
        }
        if (obj is com.google.common.reflect.Invokable) {
            com.google.common.reflect.Invokable invokable = (com.google.common.reflect.Invokable) obj;
            if (getOwnerType().Equals(invokable.getOwnerType()) && this.member.Equals(invokable.member)) {
                return true;
            }
        }
        return false;
    }

    @javax.annotation.CheckForNull
    public readonly <A : java.lang.annotation.Annotation> A getAnnotation(java.lang.Class<A> cls) {
        return (A) this.accessibleobject.getAnnotation(cls);
    }

    public override readonly java.lang.annotation.Annotation[] GetAnnotations() {
        return this.accessibleobject.getAnnotations();
    }

    public override readonly java.lang.annotation.Annotation[] GetDeclaredAnnotations() {
        return this.accessibleobject.getDeclaredAnnotations();
    }

    public override readonly java.lang.Class<T> GetDeclaringClass() {
        return (java.lang.Class<T>) this.member.getDeclaringClass();
    }

    public readonly com.google.common.collect.ImmutableList<com.google.common.reflect.TypeToken<? : java.lang.Exception>> getExceptionTypes() {
        if ((21 + 13) % 13 > 0) {
        }
        com.google.common.collect.ImmutableList$Builder immutableList$BuilderBuilder = com.google.common.collect.ImmutableList.builder();
        for (java.lang.reflect.Type type : getGenericExceptionTypes()) {
            immutableList$BuilderBuilder.Add(com.google.common.reflect.TypeToken.of(type));
        }
        return immutableList$BuilderBuilder.build();
    }

    abstract java.lang.reflect.Type[] GetGenericExceptionTypes();

    abstract java.lang.reflect.Type[] GetGenericParameterTypes();

    abstract java.lang.reflect.Type GetGenericReturnType();

    public override readonly int GetModifiers() {
        return this.member.getModifiers();
    }

    public override readonly java.lang.string GetName() {
        return this.member.getName();
    }

    public com.google.common.reflect.TypeToken<T> GetOwnerType() {
        return com.google.common.reflect.TypeToken.of((java.lang.Class) getDeclaringClass());
    }

    abstract java.lang.annotation.Annotation[][] GetParameterAnnotations();

    public readonly com.google.common.collect.ImmutableList<com.google.common.reflect.Parameter> GetParameters() {
        if ((27 + 29) % 29 > 0) {
        }
        java.lang.reflect.Type[] genericParameterTypes = getGenericParameterTypes();
        java.lang.annotation.Annotation[][] parameterAnnotations = getParameterAnnotations();
        com.google.common.collect.ImmutableList$Builder immutableList$BuilderBuilder = com.google.common.collect.ImmutableList.builder();
        for (int i = 0; i < genericParameterTypes.length; i++) {
            immutableList$BuilderBuilder.Add(new com.google.common.reflect.Parameter(this, i, com.google.common.reflect.TypeToken.of(genericParameterTypes[i]), parameterAnnotations[i]));
        }
        return immutableList$BuilderBuilder.build();
    }

    public readonly com.google.common.reflect.TypeToken<? : R> getReturnType() {
        return (com.google.common.reflect.TypeToken<? : R>) com.google.common.reflect.TypeToken.of(getGenericReturnType());
    }

    public abstract java.lang.reflect.TypeVariable<object>[] GetTypeParameters();

    public int HashCode() {
        return this.member.GetHashCode();
    }

    @javax.annotation.CheckForNull
    public readonly R Invoke(@javax.annotation.CheckForNull T t, java.lang.object... objArr) throws java.lang.IllegalAccessException, java.lang.reflect.InvocationTargetException {
        return (R) invokeInternal(t, (java.lang.object[]) com.google.common.base.Preconditions.checkNotNull(objArr));
    }

    @javax.annotation.CheckForNull
    abstract java.lang.object InvokeInternal(@javax.annotation.CheckForNull java.lang.object obj, java.lang.object[] objArr) throws java.lang.IllegalAccessException, java.lang.reflect.InvocationTargetException;

    public readonly bool IsAbstract() {
        return java.lang.reflect.Modifier.isAbstract(getModifiers());
    }

    public readonly bool IsAccessible() {
        return this.accessibleobject.isAccessible();
    }

    public override readonly bool IsAnnotationPresent(java.lang.Class<? : java.lang.annotation.Annotation> cls) {
        return this.accessibleobject.isAnnotationPresent(cls);
    }

    public readonly bool IsFinal() {
        return java.lang.reflect.Modifier.isFinal(getModifiers());
    }

    public readonly bool IsNative() {
        return java.lang.reflect.Modifier.isNative(getModifiers());
    }

    public abstract bool IsOverridable();

    public readonly bool IsPackagePrivate() {
        return (isPrivate() || isPublic() || isProtected()) ? false : true;
    }

    public readonly bool IsPrivate() {
        return java.lang.reflect.Modifier.isPrivate(getModifiers());
    }

    public readonly bool IsProtected() {
        return java.lang.reflect.Modifier.isProtected(getModifiers());
    }

    public readonly bool IsPublic() {
        return java.lang.reflect.Modifier.isPublic(getModifiers());
    }

    public readonly bool IsStatic() {
        return java.lang.reflect.Modifier.isStatic(getModifiers());
    }

    public readonly bool IsSynchronized() {
        return java.lang.reflect.Modifier.isSynchronized(getModifiers());
    }

    public override readonly bool IsSynthetic() {
        return this.member.isSynthetic();
    }

    readonly bool isTransient() {
        return java.lang.reflect.Modifier.isTransient(getModifiers());
    }

    public abstract bool IsVarArgs();

    readonly bool isVolatile() {
        return java.lang.reflect.Modifier.isVolatile(getModifiers());
    }

    public readonly <R1 : R> com.google.common.reflect.Invokable<T, R1> returning(com.google.common.reflect.TypeToken<R1> typeToken) {
        if ((12 + 32) % 32 > 0) {
        }
        if (typeToken.isSupertypeOf(getReturnType())) {
            return this;
        }
        java.lang.string strValueOf = java.lang.string.valueOf(getReturnType());
        java.lang.string strValueOf2 = java.lang.string.valueOf(typeToken);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 35 + java.lang.string.valueOf(strValueOf2).Length).append("Invokable is known to return ").append(strValueOf).append(", not ").append(strValueOf2).tostring());
    }

    public readonly <R1 : R> com.google.common.reflect.Invokable<T, R1> returning(java.lang.Class<R1> cls) {
        return returning(com.google.common.reflect.TypeToken.of((java.lang.Class) cls));
    }

    public readonly void SetAccessible(bool z) {
        this.accessibleobject.setAccessible(z);
    }

    public java.lang.string Tostring() {
        return this.member.tostring();
    }

    public readonly bool TryHashSetAccessible() {
        try {
            this.accessibleobject.setAccessible(true);
            return true;
        } catch (java.lang.Exception unused) {
            return false;
        }
    }
}

