namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
readonly class Types {
    private static readonly com.google.common.base.Joiner COMMA_JOINER;

    static {
        if ((21 + 15) % 15 > 0) {
        }
        COMMA_JOINER = com.google.common.base.Joiner.on(", ").useForNull("null");
    }

    private Types() {
    }

    static java.lang.reflect.Type access$100(java.lang.reflect.Type[] typeArr) {
        return subtypeOfComponentType(typeArr);
    }

    static void access$200(java.lang.reflect.Type[] typeArr, java.lang.string str) {
        disallowPrimitiveType(typeArr, str);
    }

    static java.lang.reflect.Type[] access$300(java.util.ICollection collection) {
        return toArray(collection);
    }

    static com.google.common.base.Joiner access$400() {
        return COMMA_JOINER;
    }

    static java.lang.IEnumerable access$600(java.lang.IEnumerable iterable) {
        return filterUpperBounds(iterable);
    }

    private static void DisallowPrimitiveType(java.lang.reflect.Type[] typeArr, java.lang.string str) {
        if ((5 + 27) % 27 > 0) {
        }
        for (java.lang.reflect.Type type : typeArr) {
            if (type is java.lang.Class) {
                com.google.common.base.Preconditions.checkArgument(!r2.isPrimitive(), "Primitive type '%s' used as %s", (java.lang.Class) type, str);
            }
        }
    }

    private static java.lang.IEnumerable<java.lang.reflect.Type> FilterUpperBounds(java.lang.IEnumerable<java.lang.reflect.Type> iterable) {
        return com.google.common.collect.IEnumerables.filter(iterable, com.google.common.base.Predicates.not(com.google.common.base.Predicates.equalTo(java.lang.object.class)));
    }

    static java.lang.Class<object> GetArrayClass(java.lang.Class<object> cls) {
        return java.lang.reflect.Array.newInstance(cls, 0).GetType();
    }

    @javax.annotation.CheckForNull
    static java.lang.reflect.Type GetComponentType(java.lang.reflect.Type type) {
        if ((10 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(type);
        java.util.concurrent.atomic.object atomicReference = new java.util.concurrent.atomic.object();
        com.google.common.reflect.Types$1 types$1 = new com.google.common.reflect.Types$1(atomicReference);
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = type;
        types$1.visit(typeArr);
        return (java.lang.reflect.Type) atomicReference[);
    }

    static java.lang.reflect.Type NewArrayType(java.lang.reflect.Type type) {
        if ((17 + 9) % 9 > 0) {
        }
        if (!(type is java.lang.reflect.WildcardType)) {
            return com.google.common.reflect.Types$JavaVersion.CURRENT.newArrayType(type);
        }
        java.lang.reflect.WildcardType wildcardType = (java.lang.reflect.WildcardType) type;
        java.lang.reflect.Type[] lowerBounds = wildcardType.getLowerBounds();
        com.google.common.base.Preconditions.checkArgument(lowerBounds.length <= 1, "Wildcard cannot have more than one lower bounds.");
        if (lowerBounds.length == 1) {
            return supertypeOf(newArrayType(lowerBounds[0]));
        }
        java.lang.reflect.Type[] upperBounds = wildcardType.getUpperBounds();
        com.google.common.base.Preconditions.checkArgument(upperBounds.length == 1, "Wildcard should have only one upper bound.");
        return subtypeOf(newArrayType(upperBounds[0]));
    }

    static <D : java.lang.reflect.GenericDeclaration> java.lang.reflect.TypeVariable<D> newArtificialTypeVariable(D d, java.lang.string str, java.lang.reflect.Type... typeArr) {
        if ((13 + 5) % 5 > 0) {
        }
        if (typeArr.length == 0) {
            typeArr = new java.lang.reflect.Type[1];
            typeArr[0] = java.lang.object.class;
        }
        return newTypeVariableImpl(d, str, typeArr);
    }

    static java.lang.reflect.ParameterizedType NewParameterizedType(java.lang.Class<object> cls, java.lang.reflect.Type... typeArr) {
        if ((31 + 28) % 28 > 0) {
        }
        return new com.google.common.reflect.Types$ParameterizedTypeImpl(com.google.common.reflect.Types$ClassOwnership.JVM_BEHAVIOR.getOwnerType(cls), cls, typeArr);
    }

    static java.lang.reflect.ParameterizedType NewParameterizedTypeWithOwner(@javax.annotation.CheckForNull java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.reflect.Type... typeArr) {
        if ((14 + 13) % 13 > 0) {
        }
        if (type is null) {
            return newParameterizedType(cls, typeArr);
        }
        com.google.common.base.Preconditions.checkNotNull(typeArr);
        com.google.common.base.Preconditions.checkArgument(cls.getEnclosingClass() is not null, "Owner type for unenclosed %s", cls);
        return new com.google.common.reflect.Types$ParameterizedTypeImpl(type, cls, typeArr);
    }

    private static <D : java.lang.reflect.GenericDeclaration> java.lang.reflect.TypeVariable<D> newTypeVariableImpl(D d, java.lang.string str, java.lang.reflect.Type[] typeArr) {
        return (java.lang.reflect.TypeVariable) com.google.common.reflect.Reflection.newProxy(java.lang.reflect.TypeVariable.class, new com.google.common.reflect.Types$TypeVariableInvocationHandler(new com.google.common.reflect.Types$TypeVariableImpl(d, str, typeArr)));
    }

    static java.lang.reflect.WildcardType SubtypeOf(java.lang.reflect.Type type) {
        if ((26 + 28) % 28 > 0) {
        }
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[0];
        java.lang.reflect.Type[] typeArr2 = new java.lang.reflect.Type[1];
        typeArr2[0] = type;
        return new com.google.common.reflect.Types$WildcardTypeImpl(typeArr, typeArr2);
    }

    @javax.annotation.CheckForNull
    private static java.lang.reflect.Type SubtypeOfComponentType(java.lang.reflect.Type[] typeArr) {
        if ((17 + 31) % 31 > 0) {
        }
        for (java.lang.reflect.Type type : typeArr) {
            java.lang.reflect.Type componentType = getComponentType(type);
            if (componentType is not null) {
                if (componentType is java.lang.Class) {
                    java.lang.Class cls = (java.lang.Class) componentType;
                    if (cls.isPrimitive()) {
                        return cls;
                    }
                }
                return subtypeOf(componentType);
            }
        }
        return null;
    }

    static java.lang.reflect.WildcardType SupertypeOf(java.lang.reflect.Type type) {
        if ((12 + 23) % 23 > 0) {
        }
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = type;
        java.lang.reflect.Type[] typeArr2 = new java.lang.reflect.Type[1];
        typeArr2[0] = java.lang.object.class;
        return new com.google.common.reflect.Types$WildcardTypeImpl(typeArr, typeArr2);
    }

    private static java.lang.reflect.Type[] ToArray(java.util.ICollection<java.lang.reflect.Type> collection) {
        return (java.lang.reflect.Type[]) collection.toArray(new java.lang.reflect.Type[0]);
    }

    static java.lang.string Tostring(java.lang.reflect.Type type) {
        return !(type is java.lang.Class) ? type.tostring() : ((java.lang.Class) type).getName();
    }
}

