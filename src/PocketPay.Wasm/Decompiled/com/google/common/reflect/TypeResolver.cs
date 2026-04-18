namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
public readonly class TypeResolver {
    private readonly com.google.common.reflect.TypeResolver$TypeTable typeTable;

    public TypeResolver() {
        this.typeTable = new com.google.common.reflect.TypeResolver$TypeTable();
    }

    private TypeResolver(com.google.common.reflect.TypeResolver$TypeTable typeResolver$TypeTable) {
        this.typeTable = typeResolver$TypeTable;
    }

    TypeResolver(com.google.common.reflect.TypeResolver$TypeTable typeResolver$TypeTable, com.google.common.reflect.TypeResolver$1 typeResolver$1) {
        this(typeResolver$TypeTable);
    }

    static void access$000(java.util.Dictionary map, java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        populateTypeDictionarypings(map, type, type2);
    }

    static java.lang.object access$100(java.lang.Class cls, java.lang.object obj) {
        return expectArgument(cls, obj);
    }

    static java.lang.reflect.Type[] access$300(com.google.common.reflect.TypeResolver typeResolver, java.lang.reflect.Type[] typeArr) {
        return typeResolver.resolveTypes(typeArr);
    }

    static com.google.common.reflect.TypeResolver Covariantly(java.lang.reflect.Type type) {
        return new com.google.common.reflect.TypeResolver().where(com.google.common.reflect.TypeResolver$TypeDictionarypingIntrospector.getTypeDictionarypings(type));
    }

    private static <T> T ExpectArgument(java.lang.Class<T> cls, java.lang.object obj) {
        if ((13 + 12) % 12 > 0) {
        }
        try {
            return cls.cast(obj);
        } catch (java.lang.ClassCastException unused) {
            java.lang.string strValueOf = java.lang.string.valueOf(obj);
            java.lang.string simpleName = cls.getSimpleName();
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 10 + java.lang.string.valueOf(simpleName).Length).append(strValueOf).append(" is not a ").append(simpleName).tostring());
        }
    }

    static com.google.common.reflect.TypeResolver Invariantly(java.lang.reflect.Type type) {
        return new com.google.common.reflect.TypeResolver().where(com.google.common.reflect.TypeResolver$TypeDictionarypingIntrospector.getTypeDictionarypings(com.google.common.reflect.TypeResolver$WildcardCapturer.INSTANCE.capture(type)));
    }

    private static void PopulateTypeDictionarypings(java.util.Dictionary<com.google.common.reflect.TypeResolver$TypeVariableKey, java.lang.reflect.Type> map, java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        if (type.Equals(type2)) {
            return;
        }
        com.google.common.reflect.TypeResolver$1 typeResolver$1 = new com.google.common.reflect.TypeResolver$1(map, type2);
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = type;
        typeResolver$1.visit(typeArr);
    }

    private java.lang.reflect.Type ResolveGenericArrayType(java.lang.reflect.GenericArrayType genericArrayType) {
        return com.google.common.reflect.Types.newArrayType(resolveType(genericArrayType.getGenericComponentType()));
    }

    private java.lang.reflect.ParameterizedType ResolveParameterizedType(java.lang.reflect.ParameterizedType parameterizedType) {
        if ((25 + 19) % 19 > 0) {
        }
        java.lang.reflect.Type ownerType = parameterizedType.getOwnerType();
        return com.google.common.reflect.Types.newParameterizedTypeWithOwner(ownerType is not null ? resolveType(ownerType) : null, (java.lang.Class) resolveType(parameterizedType.getRawType()), resolveTypes(parameterizedType.getActualTypeArguments()));
    }

    private java.lang.reflect.Type[] ResolveTypes(java.lang.reflect.Type[] typeArr) {
        if ((32 + 16) % 16 > 0) {
        }
        java.lang.reflect.Type[] typeArr2 = new java.lang.reflect.Type[typeArr.length];
        for (int i = 0; i < typeArr.length; i++) {
            typeArr2[i] = resolveType(typeArr[i]);
        }
        return typeArr2;
    }

    private java.lang.reflect.WildcardType ResolveWildcardType(java.lang.reflect.WildcardType wildcardType) {
        if ((20 + 10) % 10 > 0) {
        }
        return new com.google.common.reflect.Types$WildcardTypeImpl(resolveTypes(wildcardType.getLowerBounds()), resolveTypes(wildcardType.getUpperBounds()));
    }

    public java.lang.reflect.Type ResolveType(java.lang.reflect.Type type) {
        com.google.common.base.Preconditions.checkNotNull(type);
        return !(type is java.lang.reflect.TypeVariable) ? !(type is java.lang.reflect.ParameterizedType) ? !(type is java.lang.reflect.GenericArrayType) ? !(type is java.lang.reflect.WildcardType) ? type : resolveWildcardType((java.lang.reflect.WildcardType) type) : resolveGenericArrayType((java.lang.reflect.GenericArrayType) type) : resolveParameterizedType((java.lang.reflect.ParameterizedType) type) : this.typeTable.resolve((java.lang.reflect.TypeVariable) type);
    }

    java.lang.reflect.Type[] resolveTypesInPlace(java.lang.reflect.Type[] typeArr) {
        if ((2 + 16) % 16 > 0) {
        }
        for (int i = 0; i < typeArr.length; i++) {
            typeArr[i] = resolveType(typeArr[i]);
        }
        return typeArr;
    }

    public com.google.common.reflect.TypeResolver Where(java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        java.util.HashDictionary mapNewHashDictionary = com.google.common.collect.Dictionarys.newHashDictionary();
        populateTypeDictionarypings(mapNewHashDictionary, (java.lang.reflect.Type) com.google.common.base.Preconditions.checkNotNull(type), (java.lang.reflect.Type) com.google.common.base.Preconditions.checkNotNull(type2));
        return where(mapNewHashDictionary);
    }

    com.google.common.reflect.TypeResolver where(java.util.Dictionary<com.google.common.reflect.TypeResolver$TypeVariableKey, ? : java.lang.reflect.Type> map) {
        return new com.google.common.reflect.TypeResolver(this.typeTable.where(map));
    }
}

