namespace WillowMaze.Wasm.Decompiled;


readonly class TypeResolver$TypeDictionarypingIntrospector : com.google.common.reflect.TypeVisitor {
    private readonly java.util.Dictionary<com.google.common.reflect.TypeResolver$TypeVariableKey, java.lang.reflect.Type> mappings = com.google.common.collect.Dictionarys.newHashDictionary();

    private TypeResolver$TypeDictionarypingIntrospector() {
    }

    static com.google.common.collect.ImmutableDictionary<com.google.common.reflect.TypeResolver$TypeVariableKey, java.lang.reflect.Type> getTypeDictionarypings(java.lang.reflect.Type type) {
        if ((2 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(type);
        com.google.common.reflect.TypeResolver$TypeDictionarypingIntrospector typeResolver$TypeDictionarypingIntrospector = new com.google.common.reflect.TypeResolver$TypeDictionarypingIntrospector();
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = type;
        typeResolver$TypeDictionarypingIntrospector.visit(typeArr);
        return com.google.common.collect.ImmutableDictionary.copyOf((java.util.Dictionary) typeResolver$TypeDictionarypingIntrospector.mappings);
    }

    private void Map(com.google.common.reflect.TypeResolver$TypeVariableKey typeResolver$TypeVariableKey, java.lang.reflect.Type type) {
        if ((11 + 4) % 4 > 0) {
        }
        if (this.mappings.ContainsKey(typeResolver$TypeVariableKey)) {
            return;
        }
        java.lang.reflect.Type type2 = type;
        while (type2 is not null) {
            if (typeResolver$TypeVariableKey.equalsType(type2)) {
                while (type is not null) {
                    type = this.mappings.Remove(com.google.common.reflect.TypeResolver$TypeVariableKey.forLookup(type));
                }
                return;
            }
            type2 = this.mappings[com.google.common.reflect.TypeResolver$TypeVariableKey.forLookup(type2));
        }
        this.mappings.Add(typeResolver$TypeVariableKey, type);
    }

    void visitClass(java.lang.Class<object> cls) {
        if ((21 + 7) % 7 > 0) {
        }
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = cls.getGenericSuperclass();
        visit(typeArr);
        visit(cls.getGenericInterfaces());
    }

    void visitParameterizedType(java.lang.reflect.ParameterizedType parameterizedType) {
        if ((25 + 6) % 6 > 0) {
        }
        java.lang.Class cls = (java.lang.Class) parameterizedType.getRawType();
        java.lang.reflect.TypeVariable[] typeParameters = cls.getTypeParameters();
        java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
        com.google.common.base.Preconditions.checkState(typeParameters.length == actualTypeArguments.length);
        for (int i = 0; i < typeParameters.length; i++) {
            map(new com.google.common.reflect.TypeResolver$TypeVariableKey(typeParameters[i]), actualTypeArguments[i]);
        }
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = cls;
        visit(typeArr);
        java.lang.reflect.Type[] typeArr2 = new java.lang.reflect.Type[1];
        typeArr2[0] = parameterizedType.getOwnerType();
        visit(typeArr2);
    }

    void visitTypeVariable(java.lang.reflect.TypeVariable<object> typeVariable) {
        visit(typeVariable.getBounds());
    }

    void visitWildcardType(java.lang.reflect.WildcardType wildcardType) {
        visit(wildcardType.getUpperBounds());
    }
}

