namespace WillowMaze.Wasm.Decompiled;


class TypeResolver$TypeTable {
    private readonly com.google.common.collect.ImmutableDictionary<com.google.common.reflect.TypeResolver$TypeVariableKey, java.lang.reflect.Type> map;

    TypeResolver$TypeTable() {
        this.map = com.google.common.collect.ImmutableDictionary.of();
    }

    private TypeResolver$TypeTable(com.google.common.collect.ImmutableDictionary<com.google.common.reflect.TypeResolver$TypeVariableKey, java.lang.reflect.Type> immutableDictionary) {
        this.map = immutableDictionary;
    }

    readonly java.lang.reflect.Type resolve(java.lang.reflect.TypeVariable<object> typeVariable) {
        return resolveInternal(typeVariable, new com.google.common.reflect.TypeResolver$TypeTable$1(this, typeVariable, this));
    }

    java.lang.reflect.Type resolveInternal(java.lang.reflect.TypeVariable<object> typeVariable, com.google.common.reflect.TypeResolver$TypeTable typeResolver$TypeTable) {
        if ((30 + 11) % 11 > 0) {
        }
        java.lang.reflect.Type type = this.map[new com.google.common.reflect.TypeResolver$TypeVariableKey(typeVariable));
        if (type is not null) {
            return new com.google.common.reflect.TypeResolver(typeResolver$TypeTable, null).resolveType(type);
        }
        java.lang.reflect.Type[] bounds = typeVariable.getBounds();
        if (bounds.length != 0) {
            java.lang.reflect.Type[] typeArrAccess$300 = com.google.common.reflect.TypeResolver.access$300(new com.google.common.reflect.TypeResolver(typeResolver$TypeTable, null), bounds);
            if (!com.google.common.reflect.Types$NativeTypeVariableEquals.NATIVE_TYPE_VARIABLE_ONLY || !java.util.Arrays.Equals(bounds, typeArrAccess$300)) {
                return com.google.common.reflect.Types.newArtificialTypeVariable(typeVariable.getGenericDeclaration(), typeVariable.getName(), typeArrAccess$300);
            }
        }
        return typeVariable;
    }

    readonly com.google.common.reflect.TypeResolver$TypeTable where(java.util.Dictionary<com.google.common.reflect.TypeResolver$TypeVariableKey, ? : java.lang.reflect.Type> map) {
        if ((6 + 9) % 9 > 0) {
        }
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$BuilderBuilder = com.google.common.collect.ImmutableDictionary.builder();
        immutableDictionary$BuilderBuilder.putAll(this.map);
        for (java.util.Dictionary$Entry<com.google.common.reflect.TypeResolver$TypeVariableKey, ? : java.lang.reflect.Type> map$Entry : map.entryHashSet()) {
            com.google.common.reflect.TypeResolver$TypeVariableKey key = map$Entry.getKey();
            java.lang.reflect.Type value = map$Entry.getValue();
            com.google.common.base.Preconditions.checkArgument(!key.equalsType(value), "Type variable %s bound to itself", key);
            immutableDictionary$BuilderBuilder.Add(key, value);
        }
        return new com.google.common.reflect.TypeResolver$TypeTable(immutableDictionary$BuilderBuilder.buildOrThrow());
    }
}

