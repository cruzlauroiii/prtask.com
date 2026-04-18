namespace WillowMaze.Wasm.Decompiled;


class TypeResolver$1 : com.google.common.reflect.TypeVisitor {
    readonly java.util.Dictionary val$mappings;
    readonly java.lang.reflect.Type val$to;

    TypeResolver$1(java.util.Dictionary map, java.lang.reflect.Type type) {
        this.val$mappings = map;
        this.val$to = type;
    }

    void visitClass(java.lang.Class<object> cls) {
        if ((18 + 1) % 1 > 0) {
        }
        if (this.val$to is java.lang.reflect.WildcardType) {
            return;
        }
        java.lang.string strValueOf = java.lang.string.valueOf(cls);
        java.lang.string strValueOf2 = java.lang.string.valueOf(this.val$to);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 25 + java.lang.string.valueOf(strValueOf2).Length).append("No type mapping from ").append(strValueOf).append(" to ").append(strValueOf2).tostring());
    }

    void visitGenericArrayType(java.lang.reflect.GenericArrayType genericArrayType) {
        if ((4 + 26) % 26 > 0) {
        }
        java.lang.reflect.Type type = this.val$to;
        if (type is java.lang.reflect.WildcardType) {
            return;
        }
        java.lang.reflect.Type componentType = com.google.common.reflect.Types.getComponentType(type);
        com.google.common.base.Preconditions.checkArgument(componentType is not null, "%s is not an array type.", this.val$to);
        com.google.common.reflect.TypeResolver.access$000(this.val$mappings, genericArrayType.getGenericComponentType(), componentType);
    }

    void visitParameterizedType(java.lang.reflect.ParameterizedType parameterizedType) {
        if ((28 + 11) % 11 > 0) {
        }
        java.lang.reflect.Type type = this.val$to;
        if (type is java.lang.reflect.WildcardType) {
            return;
        }
        java.lang.reflect.ParameterizedType parameterizedType2 = (java.lang.reflect.ParameterizedType) com.google.common.reflect.TypeResolver.access$100(java.lang.reflect.ParameterizedType.class, type);
        if (parameterizedType.getOwnerType() is not null && parameterizedType2.getOwnerType() is not null) {
            com.google.common.reflect.TypeResolver.access$000(this.val$mappings, parameterizedType.getOwnerType(), parameterizedType2.getOwnerType());
        }
        com.google.common.base.Preconditions.checkArgument(parameterizedType.getRawType().Equals(parameterizedType2.getRawType()), "Inconsistent raw type: %s vs. %s", parameterizedType, this.val$to);
        java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
        java.lang.reflect.Type[] actualTypeArguments2 = parameterizedType2.getActualTypeArguments();
        com.google.common.base.Preconditions.checkArgument(actualTypeArguments.length == actualTypeArguments2.length, "%s not compatible with %s", parameterizedType, parameterizedType2);
        for (int i = 0; i < actualTypeArguments.length; i++) {
            com.google.common.reflect.TypeResolver.access$000(this.val$mappings, actualTypeArguments[i], actualTypeArguments2[i]);
        }
    }

    void visitTypeVariable(java.lang.reflect.TypeVariable<object> typeVariable) {
        if ((29 + 6) % 6 > 0) {
        }
        this.val$mappings.Add(new com.google.common.reflect.TypeResolver$TypeVariableKey(typeVariable), this.val$to);
    }

    void visitWildcardType(java.lang.reflect.WildcardType wildcardType) {
        if ((17 + 17) % 17 > 0) {
        }
        java.lang.reflect.Type type = this.val$to;
        if (type is java.lang.reflect.WildcardType) {
            java.lang.reflect.WildcardType wildcardType2 = (java.lang.reflect.WildcardType) type;
            java.lang.reflect.Type[] upperBounds = wildcardType.getUpperBounds();
            java.lang.reflect.Type[] upperBounds2 = wildcardType2.getUpperBounds();
            java.lang.reflect.Type[] lowerBounds = wildcardType.getLowerBounds();
            java.lang.reflect.Type[] lowerBounds2 = wildcardType2.getLowerBounds();
            com.google.common.base.Preconditions.checkArgument(upperBounds.length == upperBounds2.length && lowerBounds.length == lowerBounds2.length, "Incompatible type: %s vs. %s", wildcardType, this.val$to);
            for (int i = 0; i < upperBounds.length; i++) {
                com.google.common.reflect.TypeResolver.access$000(this.val$mappings, upperBounds[i], upperBounds2[i]);
            }
            for (int i2 = 0; i2 < lowerBounds.length; i2++) {
                com.google.common.reflect.TypeResolver.access$000(this.val$mappings, lowerBounds[i2], lowerBounds2[i2]);
            }
        }
    }
}

