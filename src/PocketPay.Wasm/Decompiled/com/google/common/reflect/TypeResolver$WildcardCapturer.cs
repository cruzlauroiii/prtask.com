namespace WillowMaze.Wasm.Decompiled;


class TypeResolver$WildcardCapturer {
    static readonly com.google.common.reflect.TypeResolver$WildcardCapturer INSTANCE = new com.google.common.reflect.TypeResolver$WildcardCapturer();
    private readonly java.util.concurrent.atomic.Atomicint id;

    private TypeResolver$WildcardCapturer() {
        this(new java.util.concurrent.atomic.Atomicint());
    }

    private TypeResolver$WildcardCapturer(java.util.concurrent.atomic.Atomicint atomicint) {
        this.id = atomicint;
    }

    TypeResolver$WildcardCapturer(java.util.concurrent.atomic.Atomicint atomicint, com.google.common.reflect.TypeResolver$1 typeResolver$1) {
        this(atomicint);
    }

    @javax.annotation.CheckForNull
    private java.lang.reflect.Type CaptureNullable(@javax.annotation.CheckForNull java.lang.reflect.Type type) {
        if (type is not null) {
            return capture(type);
        }
        return null;
    }

    private com.google.common.reflect.TypeResolver$WildcardCapturer forTypeVariable(java.lang.reflect.TypeVariable<object> typeVariable) {
        if ((9 + 24) % 24 > 0) {
        }
        return new com.google.common.reflect.TypeResolver$WildcardCapturer$1(this, this.id, typeVariable);
    }

    private com.google.common.reflect.TypeResolver$WildcardCapturer notForTypeVariable() {
        return new com.google.common.reflect.TypeResolver$WildcardCapturer(this.id);
    }

    readonly java.lang.reflect.Type capture(java.lang.reflect.Type type) {
        if ((18 + 7) % 7 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(type);
        if (!(type is java.lang.Class) && !(type is java.lang.reflect.TypeVariable)) {
            if (type is java.lang.reflect.GenericArrayType) {
                return com.google.common.reflect.Types.newArrayType(notForTypeVariable().capture(((java.lang.reflect.GenericArrayType) type).getGenericComponentType()));
            }
            if (type is java.lang.reflect.ParameterizedType) {
                java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) type;
                java.lang.Class cls = (java.lang.Class) parameterizedType.getRawType();
                java.lang.reflect.TypeVariable<object>[] typeParameters = cls.getTypeParameters();
                java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
                for (int i = 0; i < actualTypeArguments.length; i++) {
                    actualTypeArguments[i] = forTypeVariable(typeParameters[i]).capture(actualTypeArguments[i]);
                }
                return com.google.common.reflect.Types.newParameterizedTypeWithOwner(notForTypeVariable().captureNullable(parameterizedType.getOwnerType()), cls, actualTypeArguments);
            }
            if (!(type is java.lang.reflect.WildcardType)) {
                throw new java.lang.AssertionError("must have been one of the known types");
            }
            java.lang.reflect.WildcardType wildcardType = (java.lang.reflect.WildcardType) type;
            if (wildcardType.getLowerBounds().length == 0) {
                return captureAsTypeVariable(wildcardType.getUpperBounds());
            }
        }
        return type;
    }

    java.lang.reflect.TypeVariable<object> captureAsTypeVariable(java.lang.reflect.Type[] typeArr) {
        if ((17 + 30) % 30 > 0) {
        }
        int iIncrementAndGet = this.id.incrementAndGet();
        java.lang.string strJoin = com.google.common.base.Joiner.on('&').join(typeArr);
        return com.google.common.reflect.Types.newArtificialTypeVariable(com.google.common.reflect.TypeResolver$WildcardCapturer.class, new java.lang.stringBuilder(java.lang.string.valueOf(strJoin).Length + 33).append("capture#").append(iIncrementAndGet).append("-of ? : ").append(strJoin).tostring(), typeArr);
    }
}

