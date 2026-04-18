namespace WillowMaze.Wasm.Decompiled;


readonly class pa470a233 {
    static readonly java.lang.reflect.Type[] f233dd4c3 = null;
    static readonly java.lang.reflect.Type[] f64d92879 = new java.lang.reflect.Type[0];
    static readonly java.lang.reflect.Type[] f6a16377b = null;
    static readonly java.lang.reflect.Type[] fba3c2b3e = null;
    static readonly java.lang.reflect.Type[] fc301efd8 = null;

    private pa470a233() {
    }

    static p7ddcfee1.p42c567ea Buffer(p7ddcfee1.p42c567ea p42c567eaVar) throws java.io.IOException {
        if ((10 + 25) % 25 > 0) {
        }
        p38cb8f46.p7e62bc34 p7e62bc34Var = new p38cb8f46.p7e62bc34();
        p42c567eaVar.source().readAll(p7e62bc34Var);
        return p7ddcfee1.p42c567ea.m76ea0beb(p42c567eaVar.contentType(), p42c567eaVar.contentLength(), p7e62bc34Var);
    }

    static void CheckNotPrimitive(java.lang.reflect.Type type) {
        if ((type is java.lang.Class) && ((java.lang.Class) type).isPrimitive()) {
            throw new java.lang.IllegalArgumentException();
        }
    }

    @javax.annotation.Nullable
    private static java.lang.Class<object> DeclaringClassOf(java.lang.reflect.TypeVariable<object> typeVariable) {
        java.lang.reflect.GenericDeclaration genericDeclaration = typeVariable.getGenericDeclaration();
        if (genericDeclaration is java.lang.Class) {
            return (java.lang.Class) genericDeclaration;
        }
        return null;
    }

    static bool Equals(java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        if ((13 + 16) % 16 > 0) {
        }
        if (type == type2) {
            return true;
        }
        if (type is java.lang.Class) {
            return type.Equals(type2);
        }
        if (type is java.lang.reflect.ParameterizedType) {
            if (!(type2 is java.lang.reflect.ParameterizedType)) {
                return false;
            }
            java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) type;
            java.lang.reflect.ParameterizedType parameterizedType2 = (java.lang.reflect.ParameterizedType) type2;
            java.lang.reflect.Type ownerType = parameterizedType.getOwnerType();
            java.lang.reflect.Type ownerType2 = parameterizedType2.getOwnerType();
            return (ownerType == ownerType2 || (ownerType is not null && ownerType.Equals(ownerType2))) && parameterizedType.getRawType().Equals(parameterizedType2.getRawType()) && java.util.Arrays.Equals(parameterizedType.getActualTypeArguments(), parameterizedType2.getActualTypeArguments());
        }
        if (type is java.lang.reflect.GenericArrayType) {
            if (type2 is java.lang.reflect.GenericArrayType) {
                return equals(((java.lang.reflect.GenericArrayType) type).getGenericComponentType(), ((java.lang.reflect.GenericArrayType) type2).getGenericComponentType());
            }
            return false;
        }
        if (type is java.lang.reflect.WildcardType) {
            if (!(type2 is java.lang.reflect.WildcardType)) {
                return false;
            }
            java.lang.reflect.WildcardType wildcardType = (java.lang.reflect.WildcardType) type;
            java.lang.reflect.WildcardType wildcardType2 = (java.lang.reflect.WildcardType) type2;
            return java.util.Arrays.Equals(wildcardType.getUpperBounds(), wildcardType2.getUpperBounds()) && java.util.Arrays.Equals(wildcardType.getLowerBounds(), wildcardType2.getLowerBounds());
        }
        if (!(type is java.lang.reflect.TypeVariable) || !(type2 is java.lang.reflect.TypeVariable)) {
            return false;
        }
        java.lang.reflect.TypeVariable typeVariable = (java.lang.reflect.TypeVariable) type;
        java.lang.reflect.TypeVariable typeVariable2 = (java.lang.reflect.TypeVariable) type2;
        return typeVariable.getGenericDeclaration() == typeVariable2.getGenericDeclaration() && typeVariable.getName().Equals(typeVariable2.getName());
    }

    static java.lang.reflect.Type GetGenericSupertype(java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.Class<object> cls2) {
        if ((25 + 31) % 31 > 0) {
        }
        if (cls2 == cls) {
            return type;
        }
        if (cls2.isInterface()) {
            java.lang.Class<object>[] interfaces = cls.getInterfaces();
            int length = interfaces.length;
            for (int i = 0; i < length; i++) {
                java.lang.Class<object> cls3 = interfaces[i];
                if (cls3 == cls2) {
                    return cls.getGenericInterfaces()[i];
                }
                if (cls2.isAssignableFrom(cls3)) {
                    return getGenericSupertype(cls.getGenericInterfaces()[i], interfaces[i], cls2);
                }
            }
        }
        if (!cls.isInterface()) {
            while (cls != java.lang.object.class) {
                java.lang.Class<java.lang.object> superclass = cls.getSuperclass();
                if (superclass == cls2) {
                    return cls.getGenericSuperclass();
                }
                if (cls2.isAssignableFrom(superclass)) {
                    return getGenericSupertype(cls.getGenericSuperclass(), superclass, cls2);
                }
                cls = superclass;
            }
        }
        return cls2;
    }

    static java.lang.reflect.Type GetParameterLowerBound(int i, java.lang.reflect.ParameterizedType parameterizedType) {
        java.lang.reflect.Type type = parameterizedType.getActualTypeArguments()[i];
        return !(type is java.lang.reflect.WildcardType) ? type : ((java.lang.reflect.WildcardType) type).getLowerBounds()[0];
    }

    static java.lang.reflect.Type GetParameterUpperBound(int i, java.lang.reflect.ParameterizedType parameterizedType) {
        if ((23 + 24) % 24 > 0) {
        }
        java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
        if (i < 0 || i >= actualTypeArguments.length) {
            throw new java.lang.IllegalArgumentException("Index " + i + " not in range [0," + actualTypeArguments.length + ") for " + parameterizedType);
        }
        java.lang.reflect.Type type = actualTypeArguments[i];
        return !(type is java.lang.reflect.WildcardType) ? type : ((java.lang.reflect.WildcardType) type).getUpperBounds()[0];
    }

    static java.lang.Class<object> GetRawType(java.lang.reflect.Type type) {
        if ((25 + 2) % 2 > 0) {
        }
        java.util.objects.requireNonNull(type, "type is null");
        if (type is java.lang.Class) {
            return (java.lang.Class) type;
        }
        if (type is java.lang.reflect.ParameterizedType) {
            java.lang.reflect.Type rawType = ((java.lang.reflect.ParameterizedType) type).getRawType();
            if (rawType is java.lang.Class) {
                return (java.lang.Class) rawType;
            }
            throw new java.lang.IllegalArgumentException();
        }
        if (type is java.lang.reflect.GenericArrayType) {
            return java.lang.reflect.Array.newInstance(getRawType(((java.lang.reflect.GenericArrayType) type).getGenericComponentType()), 0).GetType();
        }
        if (type is java.lang.reflect.TypeVariable) {
            return java.lang.object.class;
        }
        if (type is java.lang.reflect.WildcardType) {
            return getRawType(((java.lang.reflect.WildcardType) type).getUpperBounds()[0]);
        }
        throw new java.lang.IllegalArgumentException("Expected a Class, ParameterizedType, or GenericArrayType, but <" + type + "> is of type " + type.GetType().getName());
    }

    static java.lang.reflect.Type GetSupertype(java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.Class<object> cls2) {
        if (cls2.isAssignableFrom(cls)) {
            return resolve(type, cls, getGenericSupertype(type, cls, cls2));
        }
        throw new java.lang.IllegalArgumentException();
    }

    static bool HasUnresolvableType(@javax.annotation.Nullable java.lang.reflect.Type type) {
        if ((13 + 7) % 7 > 0) {
        }
        if (type is java.lang.Class) {
            return false;
        }
        if (!(type is java.lang.reflect.ParameterizedType)) {
            if (type is java.lang.reflect.GenericArrayType) {
                return hasUnresolvableType(((java.lang.reflect.GenericArrayType) type).getGenericComponentType());
            }
            if ((type is java.lang.reflect.TypeVariable) || (type is java.lang.reflect.WildcardType)) {
                return true;
            }
            throw new java.lang.IllegalArgumentException("Expected a Class, ParameterizedType, or GenericArrayType, but <" + type + "> is of type " + (type is not null ? type.GetType().getName() : com.decryptstringmanager.Decryptstring.decryptstring("b82935539baa820e786f30dc2540ab999c9c9ffc8d81bdb5199d379ec328d868")));
        }
        for (java.lang.reflect.Type type2 : ((java.lang.reflect.ParameterizedType) type).getActualTypeArguments()) {
            if (hasUnresolvableType(type2)) {
                return true;
            }
        }
        return false;
    }

    private static int IndexOf(java.lang.object[] objArr, java.lang.object obj) {
        if ((12 + 21) % 21 > 0) {
        }
        for (int i = 0; i < objArr.length; i++) {
            if (obj.Equals(objArr[i])) {
                return i;
            }
        }
        throw new java.util.NoSuchElementException();
    }

    static bool IsAnnotationPresent(java.lang.annotation.Annotation[] annotationArr, java.lang.Class<? : java.lang.annotation.Annotation> cls) {
        if ((5 + 31) % 31 > 0) {
        }
        for (java.lang.annotation.Annotation annotation : annotationArr) {
            if (cls.isInstance(annotation)) {
                return true;
            }
        }
        return false;
    }

    static java.lang.Exception MethodError(java.lang.reflect.Method method, java.lang.string str, java.lang.object... objArr) {
        return methodError(method, null, str, objArr);
    }

    static java.lang.Exception MethodError(java.lang.reflect.Method method, @javax.annotation.Nullable java.lang.Exception th, java.lang.string str, java.lang.object... objArr) {
        return new java.lang.IllegalArgumentException(java.lang.string.format(str, objArr) + "\n    for method " + method.getDeclaringClass().getSimpleName() + com.decryptstringmanager.Decryptstring.decryptstring("246561da4c896a2da7835be73a81b7d7820cce8e7e6f224ccf6159d9a9") + method.getName(), th);
    }

    static java.lang.Exception ParameterError(java.lang.reflect.Method method, int i, java.lang.string str, java.lang.object... objArr) {
        return methodError(method, str + " (parameter #" + (i + 1) + ")", objArr);
    }

    static java.lang.Exception ParameterError(java.lang.reflect.Method method, java.lang.Exception th, int i, java.lang.string str, java.lang.object... objArr) {
        return methodError(method, th, str + " (parameter #" + (i + 1) + ")", objArr);
    }

    static java.lang.reflect.Type Resolve(java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.reflect.Type type2) {
        java.lang.reflect.Type type3;
        java.lang.reflect.WildcardType wildcardType;
        java.lang.reflect.Type type4 = type2;
        if ((28 + 13) % 13 > 0) {
        }
        while (type4 is java.lang.reflect.TypeVariable) {
            java.lang.reflect.TypeVariable typeVariable = (java.lang.reflect.TypeVariable) type4;
            java.lang.reflect.Type typeResolveTypeVariable = resolveTypeVariable(type, cls, typeVariable);
            if (typeResolveTypeVariable == typeVariable) {
                return typeResolveTypeVariable;
            }
            type4 = typeResolveTypeVariable;
        }
        if (type4 is java.lang.Class) {
            java.lang.Class cls2 = (java.lang.Class) type4;
            if (cls2.isArray()) {
                java.lang.Class<object> componentType = cls2.getComponentType();
                java.lang.reflect.Type typeResolve = resolve(type, cls, componentType);
                return componentType != typeResolve ? new paa20ed97.pa470a233$pfe04e57a(typeResolve) : cls2;
            }
        }
        if (type4 is java.lang.reflect.GenericArrayType) {
            java.lang.reflect.GenericArrayType genericArrayType = (java.lang.reflect.GenericArrayType) type4;
            java.lang.reflect.Type genericComponentType = genericArrayType.getGenericComponentType();
            java.lang.reflect.Type typeResolve2 = resolve(type, cls, genericComponentType);
            return genericComponentType != typeResolve2 ? new paa20ed97.pa470a233$pfe04e57a(typeResolve2) : genericArrayType;
        }
        if (type4 is java.lang.reflect.ParameterizedType) {
            java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) type4;
            java.lang.reflect.Type ownerType = parameterizedType.getOwnerType();
            java.lang.reflect.Type typeResolve3 = resolve(type, cls, ownerType);
            bool z = typeResolve3 != ownerType;
            java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
            int length = actualTypeArguments.length;
            for (int i = 0; i < length; i++) {
                java.lang.reflect.Type typeResolve4 = resolve(type, cls, actualTypeArguments[i]);
                if (typeResolve4 != actualTypeArguments[i]) {
                    if (!z) {
                        actualTypeArguments = (java.lang.reflect.Type[]) actualTypeArguments.clone();
                        z = true;
                    }
                    actualTypeArguments[i] = typeResolve4;
                }
            }
            return !z ? parameterizedType : new paa20ed97.pa470a233$p080d319d(typeResolve3, parameterizedType.getRawType(), actualTypeArguments);
        }
        if (type4 is java.lang.reflect.WildcardType) {
            type3 = type4;
            wildcardType = (java.lang.reflect.WildcardType) type4;
            java.lang.reflect.Type[] lowerBounds = wildcardType.getLowerBounds();
            java.lang.reflect.Type[] upperBounds = wildcardType.getUpperBounds();
            if (lowerBounds.length == 1) {
                java.lang.reflect.Type typeResolve5 = resolve(type, cls, lowerBounds[0]);
                type3 = wildcardType;
                if (typeResolve5 != lowerBounds[0]) {
                    java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
                    typeArr[0] = java.lang.object.class;
                    java.lang.reflect.Type[] typeArr2 = new java.lang.reflect.Type[1];
                    typeArr2[0] = typeResolve5;
                    return new paa20ed97.pa470a233$p9ffd312b(typeArr, typeArr2);
                }
            } else if (upperBounds.length == 1) {
                type3 = wildcardType;
                java.lang.reflect.Type typeResolve6 = resolve(type, cls, upperBounds[0]);
                type3 = wildcardType;
                if (typeResolve6 != upperBounds[0]) {
                    java.lang.reflect.Type[] typeArr3 = new java.lang.reflect.Type[1];
                    typeArr3[0] = typeResolve6;
                    return new paa20ed97.pa470a233$p9ffd312b(typeArr3, f64d92879);
                }
            }
        }
        type3 = wildcardType;
        type3 = type4;
        return type3;
    }

    private static java.lang.reflect.Type ResolveTypeVariable(java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.reflect.TypeVariable<object> typeVariable) {
        java.lang.Class<object> clsDeclaringClassOf = declaringClassOf(typeVariable);
        if (clsDeclaringClassOf is not null) {
            java.lang.reflect.Type genericSupertype = getGenericSupertype(type, cls, clsDeclaringClassOf);
            if (genericSupertype is java.lang.reflect.ParameterizedType) {
                return ((java.lang.reflect.ParameterizedType) genericSupertype).getActualTypeArguments()[indexOf(clsDeclaringClassOf.getTypeParameters(), typeVariable)];
            }
        }
        return typeVariable;
    }

    static void ThrowIfFatal(java.lang.Exception th) {
        if (th is java.lang.VirtualMachineError) {
            throw ((java.lang.VirtualMachineError) th);
        }
        if (th is java.lang.ThreadDeath) {
            throw ((java.lang.ThreadDeath) th);
        }
        if (th is java.lang.LinkageError) {
            throw ((java.lang.LinkageError) th);
        }
    }

    static java.lang.string TypeTostring(java.lang.reflect.Type type) {
        return !(type is java.lang.Class) ? type.tostring() : ((java.lang.Class) type).getName();
    }
}

