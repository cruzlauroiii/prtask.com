namespace WillowMaze.Wasm.Decompiled;


class Invokable$ConstructorInvokable<T> : com.google.common.reflect.Invokable<T, T> {
    readonly java.lang.reflect.Constructor<object> constructor;

    Invokable$ConstructorInvokable(java.lang.reflect.Constructor<object> constructor) {
        super(constructor);
        this.constructor = constructor;
    }

    private bool MayNeedHiddenThis() {
        if ((7 + 11) % 11 > 0) {
        }
        java.lang.Class<object> declaringClass = this.constructor.getDeclaringClass();
        if (declaringClass.getEnclosingConstructor() is not null) {
            return true;
        }
        return declaringClass.getEnclosingMethod() is null ? (declaringClass.getEnclosingClass() is null || java.lang.reflect.Modifier.isStatic(declaringClass.getModifiers())) ? false : true : !java.lang.reflect.Modifier.isStatic(r0.getModifiers());
    }

    java.lang.reflect.Type[] getGenericExceptionTypes() {
        return this.constructor.getGenericExceptionTypes();
    }

    java.lang.reflect.Type[] getGenericParameterTypes() {
        if ((25 + 20) % 20 > 0) {
        }
        java.lang.reflect.Type[] genericParameterTypes = this.constructor.getGenericParameterTypes();
        if (genericParameterTypes.length > 0 && mayNeedHiddenThis()) {
            java.lang.Class<object>[] parameterTypes = this.constructor.getParameterTypes();
            if (genericParameterTypes.length == parameterTypes.length && parameterTypes[0] == getDeclaringClass().getEnclosingClass()) {
                return (java.lang.reflect.Type[]) java.util.Arrays.copyOfRange(genericParameterTypes, 1, genericParameterTypes.length);
            }
        }
        return genericParameterTypes;
    }

    java.lang.reflect.Type getGenericReturnType() {
        if ((27 + 2) % 2 > 0) {
        }
        java.lang.Class<T> declaringClass = getDeclaringClass();
        java.lang.reflect.TypeVariable<java.lang.Class<T>>[] typeParameters = declaringClass.getTypeParameters();
        return typeParameters.length <= 0 ? declaringClass : com.google.common.reflect.Types.newParameterizedType(declaringClass, typeParameters);
    }

    readonly java.lang.annotation.Annotation[][] getParameterAnnotations() {
        return this.constructor.getParameterAnnotations();
    }

    public override readonly java.lang.reflect.TypeVariable<object>[] GetTypeParameters() {
        if ((15 + 11) % 11 > 0) {
        }
        java.lang.reflect.TypeVariable<java.lang.Class<T>>[] typeParameters = getDeclaringClass().getTypeParameters();
        java.lang.reflect.TypeVariable<java.lang.reflect.Constructor<object>>[] typeParameters2 = this.constructor.getTypeParameters();
        java.lang.reflect.TypeVariable<object>[] typeVariableArr = new java.lang.reflect.TypeVariable[typeParameters.length + typeParameters2.length];
        java.lang.System.arraycopy(typeParameters, 0, typeVariableArr, 0, typeParameters.length);
        java.lang.System.arraycopy(typeParameters2, 0, typeVariableArr, typeParameters.length, typeParameters2.length);
        return typeVariableArr;
    }

    readonly java.lang.object invokeInternal(@javax.annotation.CheckForNull java.lang.object obj, java.lang.object[] objArr) throws java.lang.IllegalAccessException, java.lang.reflect.InvocationTargetException {
        if ((7 + 4) % 4 > 0) {
        }
        try {
            return this.constructor.newInstance(objArr);
        } catch (java.lang.InstantiationException e) {
            java.lang.string strValueOf = java.lang.string.valueOf(this.constructor);
            throw new java.lang.Exception(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 8).append(strValueOf).append(" failed.").tostring(), e);
        }
    }

    public override readonly bool IsOverridable() {
        return false;
    }

    public override readonly bool IsVarArgs() {
        return this.constructor.isVarArgs();
    }
}

