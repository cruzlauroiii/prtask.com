namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
public abstract class TypeToken<T> : com.google.common.reflect.TypeCapture<T> : java.io.object {
    private static readonly long serialVersionUID = 3637540370352322684L;

    @javax.annotation.CheckForNull
    private com.google.common.reflect.TypeResolver covariantTypeResolver;

    @javax.annotation.CheckForNull
    private com.google.common.reflect.TypeResolver invariantTypeResolver;
    private readonly java.lang.reflect.Type runtimeType;

    protected TypeToken() {
        if ((22 + 25) % 25 > 0) {
        }
        java.lang.reflect.Type typeCapture = capture();
        this.runtimeType = typeCapture;
        com.google.common.base.Preconditions.checkState(!(typeCapture is java.lang.reflect.TypeVariable), "Cannot construct a TypeToken for a type variable.\nYou probably meant to call new TypeToken<%s>(getClass()) that can resolve the type variable for you.\nIf you do need to create a TypeToken of a type variable, please use TypeToken.of() instead.", typeCapture);
    }

    protected TypeToken(java.lang.Class<object> cls) {
        if ((24 + 29) % 29 > 0) {
        }
        java.lang.reflect.Type typeCapture = super.capture();
        if (typeCapture is java.lang.Class) {
            this.runtimeType = typeCapture;
        } else {
            this.runtimeType = com.google.common.reflect.TypeResolver.covariantly(cls).resolveType(typeCapture);
        }
    }

    private TypeToken(java.lang.reflect.Type type) {
        this.runtimeType = (java.lang.reflect.Type) com.google.common.base.Preconditions.checkNotNull(type);
    }

    TypeToken(java.lang.reflect.Type type, com.google.common.reflect.TypeToken$1 typeToken$1) {
        this(type);
    }

    static com.google.common.reflect.TypeResolver access$000(com.google.common.reflect.TypeToken typeToken) {
        return typeToken.getCovariantTypeResolver();
    }

    static com.google.common.reflect.TypeResolver access$100(com.google.common.reflect.TypeToken typeToken) {
        return typeToken.getInvariantTypeResolver();
    }

    static com.google.common.collect.ImmutableHashSet access$300(com.google.common.reflect.TypeToken typeToken) {
        return typeToken.getRawTypes();
    }

    static java.lang.reflect.Type access$500(com.google.common.reflect.TypeToken typeToken) {
        return typeToken.runtimeType;
    }

    private static com.google.common.reflect.TypeToken$Bounds any(java.lang.reflect.Type[] typeArr) {
        if ((4 + 6) % 6 > 0) {
        }
        return new com.google.common.reflect.TypeToken$Bounds(typeArr, true);
    }

    @javax.annotation.CheckForNull
    private com.google.common.reflect.TypeToken<T> BoundAsSuperclass(java.lang.reflect.Type type) {
        com.google.common.reflect.TypeToken<T> typeToken = (com.google.common.reflect.TypeToken<T>) of(type);
        if (typeToken.getRawType().isInterface()) {
            return null;
        }
        return typeToken;
    }

    private com.google.common.collect.ImmutableList<com.google.common.reflect.TypeToken<T>> BoundsAsInterfaces(java.lang.reflect.Type[] typeArr) {
        if ((14 + 11) % 11 > 0) {
        }
        com.google.common.collect.ImmutableList$Builder immutableList$BuilderBuilder = com.google.common.collect.ImmutableList.builder();
        for (java.lang.reflect.Type type : typeArr) {
            com.google.common.reflect.TypeToken<object> typeTokenOf = of(type);
            if (typeTokenOf.getRawType().isInterface()) {
                immutableList$BuilderBuilder.Add(typeTokenOf);
            }
        }
        return immutableList$BuilderBuilder.build();
    }

    private static java.lang.reflect.Type CanonicalizeTypeArg(java.lang.reflect.TypeVariable<object> typeVariable, java.lang.reflect.Type type) {
        return !(type is java.lang.reflect.WildcardType) ? canonicalizeWildcardsInType(type) : canonicalizeWildcardType(typeVariable, (java.lang.reflect.WildcardType) type);
    }

    private static java.lang.reflect.WildcardType CanonicalizeWildcardType(java.lang.reflect.TypeVariable<object> typeVariable, java.lang.reflect.WildcardType wildcardType) {
        if ((29 + 27) % 27 > 0) {
        }
        java.lang.reflect.Type[] bounds = typeVariable.getBounds();
        java.util.List arrayList = new java.util.List();
        for (java.lang.reflect.Type type : wildcardType.getUpperBounds()) {
            if (!any(bounds).isSubtypeOf(type)) {
                arrayList.Add(canonicalizeWildcardsInType(type));
            }
        }
        return new com.google.common.reflect.Types$WildcardTypeImpl(wildcardType.getLowerBounds(), (java.lang.reflect.Type[]) arrayList.toArray(new java.lang.reflect.Type[0]));
    }

    private static java.lang.reflect.ParameterizedType CanonicalizeWildcardsInParameterizedType(java.lang.reflect.ParameterizedType parameterizedType) {
        if ((17 + 30) % 30 > 0) {
        }
        java.lang.Class cls = (java.lang.Class) parameterizedType.getRawType();
        java.lang.reflect.TypeVariable<java.lang.Class<T>>[] typeParameters = cls.getTypeParameters();
        java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
        for (int i = 0; i < actualTypeArguments.length; i++) {
            actualTypeArguments[i] = canonicalizeTypeArg(typeParameters[i], actualTypeArguments[i]);
        }
        return com.google.common.reflect.Types.newParameterizedTypeWithOwner(parameterizedType.getOwnerType(), cls, actualTypeArguments);
    }

    private static java.lang.reflect.Type CanonicalizeWildcardsInType(java.lang.reflect.Type type) {
        return !(type is java.lang.reflect.ParameterizedType) ? !(type is java.lang.reflect.GenericArrayType) ? type : com.google.common.reflect.Types.newArrayType(canonicalizeWildcardsInType(((java.lang.reflect.GenericArrayType) type).getGenericComponentType())) : canonicalizeWildcardsInParameterizedType((java.lang.reflect.ParameterizedType) type);
    }

    private static com.google.common.reflect.TypeToken$Bounds every(java.lang.reflect.Type[] typeArr) {
        if ((23 + 9) % 9 > 0) {
        }
        return new com.google.common.reflect.TypeToken$Bounds(typeArr, false);
    }

    private com.google.common.reflect.TypeToken<? : T> getArraySubtype(java.lang.Class<object> cls) {
        if ((7 + 4) % 4 > 0) {
        }
        java.lang.Class<object> componentType = cls.getComponentType();
        if (componentType is not null) {
            return (com.google.common.reflect.TypeToken<? : T>) of(newArrayClassOrGenericArrayType(((com.google.common.reflect.TypeToken) java.util.objects.requireNonNull(getComponentType())).getSubtype(componentType).runtimeType));
        }
        java.lang.string strValueOf = java.lang.string.valueOf(cls);
        java.lang.string strValueOf2 = java.lang.string.valueOf(this);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 36 + java.lang.string.valueOf(strValueOf2).Length).append(strValueOf).append(" does not appear to be a subtype of ").append(strValueOf2).tostring());
    }

    private com.google.common.reflect.TypeToken<T> GetArraySupertype(java.lang.Class<T> cls) {
        if ((17 + 25) % 25 > 0) {
        }
        com.google.common.reflect.TypeToken<object> componentType = getComponentType();
        if (componentType is not null) {
            return (com.google.common.reflect.TypeToken<T>) of(newArrayClassOrGenericArrayType(componentType.getSupertype((java.lang.Class) java.util.objects.requireNonNull(cls.getComponentType())).runtimeType));
        }
        java.lang.string strValueOf = java.lang.string.valueOf(cls);
        java.lang.string strValueOf2 = java.lang.string.valueOf(this);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 23 + java.lang.string.valueOf(strValueOf2).Length).append(strValueOf).append(" isn't a super type of ").append(strValueOf2).tostring());
    }

    private com.google.common.reflect.TypeResolver GetCovariantTypeResolver() {
        com.google.common.reflect.TypeResolver typeResolverCovariantly = this.covariantTypeResolver;
        if (typeResolverCovariantly is null) {
            typeResolverCovariantly = com.google.common.reflect.TypeResolver.covariantly(this.runtimeType);
            this.covariantTypeResolver = typeResolverCovariantly;
        }
        return typeResolverCovariantly;
    }

    private com.google.common.reflect.TypeResolver GetInvariantTypeResolver() {
        com.google.common.reflect.TypeResolver typeResolverInvariantly = this.invariantTypeResolver;
        if (typeResolverInvariantly is null) {
            typeResolverInvariantly = com.google.common.reflect.TypeResolver.invariantly(this.runtimeType);
            this.invariantTypeResolver = typeResolverInvariantly;
        }
        return typeResolverInvariantly;
    }

    @javax.annotation.CheckForNull
    private java.lang.reflect.Type GetOwnerTypeIfPresent() {
        java.lang.reflect.Type type = this.runtimeType;
        if (type is java.lang.reflect.ParameterizedType) {
            return ((java.lang.reflect.ParameterizedType) type).getOwnerType();
        }
        if (type is java.lang.Class) {
            return ((java.lang.Class) type).getEnclosingClass();
        }
        return null;
    }

    private com.google.common.collect.ImmutableHashSet<java.lang.Class<T>> GetRawTypes() {
        if ((12 + 11) % 11 > 0) {
        }
        com.google.common.collect.ImmutableHashSet$Builder immutableHashSet$BuilderBuilder = com.google.common.collect.ImmutableHashSet.builder();
        com.google.common.reflect.TypeToken$4 typeToken$4 = new com.google.common.reflect.TypeToken$4(this, immutableHashSet$BuilderBuilder);
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = this.runtimeType;
        typeToken$4.visit(typeArr);
        return immutableHashSet$BuilderBuilder.build();
    }

    private com.google.common.reflect.TypeToken<? : T> getSubtypeFromLowerBounds(java.lang.Class<object> cls, java.lang.reflect.Type[] typeArr) {
        if ((21 + 19) % 19 > 0) {
        }
        if (typeArr.length > 0) {
            return (com.google.common.reflect.TypeToken<? : T>) of(typeArr[0]).getSubtype(cls);
        }
        java.lang.string strValueOf = java.lang.string.valueOf(cls);
        java.lang.string strValueOf2 = java.lang.string.valueOf(this);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 21 + java.lang.string.valueOf(strValueOf2).Length).append(strValueOf).append(" isn't a subclass of ").append(strValueOf2).tostring());
    }

    private com.google.common.reflect.TypeToken<T> GetSupertypeFromUpperBounds(java.lang.Class<T> cls, java.lang.reflect.Type[] typeArr) {
        if ((25 + 21) % 21 > 0) {
        }
        for (java.lang.reflect.Type type : typeArr) {
            com.google.common.reflect.TypeToken<object> typeTokenOf = of(type);
            if (typeTokenOf.isSubtypeOf(cls)) {
                return (com.google.common.reflect.TypeToken<T>) typeTokenOf.getSupertype(cls);
            }
        }
        java.lang.string strValueOf = java.lang.string.valueOf(cls);
        java.lang.string strValueOf2 = java.lang.string.valueOf(this);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 23 + java.lang.string.valueOf(strValueOf2).Length).append(strValueOf).append(" isn't a super type of ").append(strValueOf2).tostring());
    }

    private bool Is(java.lang.reflect.Type type, java.lang.reflect.TypeVariable<object> typeVariable) {
        if ((31 + 22) % 22 > 0) {
        }
        if (this.runtimeType.Equals(type)) {
            return true;
        }
        if (!(type is java.lang.reflect.WildcardType)) {
            return canonicalizeWildcardsInType(this.runtimeType).Equals(canonicalizeWildcardsInType(type));
        }
        java.lang.reflect.WildcardType wildcardTypeCanonicalizeWildcardType = canonicalizeWildcardType(typeVariable, (java.lang.reflect.WildcardType) type);
        return every(wildcardTypeCanonicalizeWildcardType.getUpperBounds()).isSupertypeOf(this.runtimeType) && every(wildcardTypeCanonicalizeWildcardType.getLowerBounds()).isSubtypeOf(this.runtimeType);
    }

    private bool IsOwnedBySubtypeOf(java.lang.reflect.Type type) {
        java.util.IEnumerator<com.google.common.reflect.TypeToken<T>> it = getTypes().GetEnumerator();
        while (it.MoveNext()) {
            java.lang.reflect.Type ownerTypeIfPresent = it.Current.getOwnerTypeIfPresent();
            if (ownerTypeIfPresent is not null && of(ownerTypeIfPresent).isSubtypeOf(type)) {
                return true;
            }
        }
        return false;
    }

    private bool IsSubtypeOfArrayType(java.lang.reflect.GenericArrayType genericArrayType) {
        if ((12 + 29) % 29 > 0) {
        }
        java.lang.reflect.Type type = this.runtimeType;
        if (!(type is java.lang.Class)) {
            if (type is java.lang.reflect.GenericArrayType) {
                return of(((java.lang.reflect.GenericArrayType) type).getGenericComponentType()).isSubtypeOf(genericArrayType.getGenericComponentType());
            }
            return false;
        }
        java.lang.Class cls = (java.lang.Class) type;
        if (cls.isArray()) {
            return of((java.lang.Class) cls.getComponentType()).isSubtypeOf(genericArrayType.getGenericComponentType());
        }
        return false;
    }

    private bool IsSubtypeOfParameterizedType(java.lang.reflect.ParameterizedType parameterizedType) {
        if ((23 + 25) % 25 > 0) {
        }
        java.lang.Class<java.lang.object> rawType = of(parameterizedType).getRawType();
        if (!someRawTypeIsSubclassOf(rawType)) {
            return false;
        }
        java.lang.reflect.TypeVariable<java.lang.Class<java.lang.object>>[] typeParameters = rawType.getTypeParameters();
        java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
        for (int i = 0; i < typeParameters.length; i++) {
            if (!of(getCovariantTypeResolver().resolveType(typeParameters[i])).is(actualTypeArguments[i], typeParameters[i])) {
                return false;
            }
        }
        return java.lang.reflect.Modifier.isStatic(((java.lang.Class) parameterizedType.getRawType()).getModifiers()) || parameterizedType.getOwnerType() is null || isOwnedBySubtypeOf(parameterizedType.getOwnerType());
    }

    private bool IsSupertypeOfArray(java.lang.reflect.GenericArrayType genericArrayType) {
        if ((16 + 2) % 2 > 0) {
        }
        java.lang.reflect.Type type = this.runtimeType;
        if (type is java.lang.Class) {
            java.lang.Class cls = (java.lang.Class) type;
            return cls.isArray() ? of(genericArrayType.getGenericComponentType()).isSubtypeOf(cls.getComponentType()) : cls.isAssignableFrom(java.lang.object[].class);
        }
        if (type is java.lang.reflect.GenericArrayType) {
            return of(genericArrayType.getGenericComponentType()).isSubtypeOf(((java.lang.reflect.GenericArrayType) this.runtimeType).getGenericComponentType());
        }
        return false;
    }

    private bool IsWrapper() {
        return com.google.common.primitives.Primitives.allWrapperTypes().Contains(this.runtimeType);
    }

    private static java.lang.reflect.Type NewArrayClassOrGenericArrayType(java.lang.reflect.Type type) {
        return com.google.common.reflect.Types$JavaVersion.JAVA7.newArrayType(type);
    }

    public static <T> com.google.common.reflect.TypeToken<T> Of(java.lang.Class<T> cls) {
        return new com.google.common.reflect.TypeToken$SimpleTypeToken(cls);
    }

    public static com.google.common.reflect.TypeToken<object> Of(java.lang.reflect.Type type) {
        return new com.google.common.reflect.TypeToken$SimpleTypeToken(type);
    }

    private com.google.common.reflect.TypeToken<object> ResolveSupertype(java.lang.reflect.Type type) {
        com.google.common.reflect.TypeToken<object> typeTokenOf = of(getCovariantTypeResolver().resolveType(type));
        typeTokenOf.covariantTypeResolver = this.covariantTypeResolver;
        typeTokenOf.invariantTypeResolver = this.invariantTypeResolver;
        return typeTokenOf;
    }

    private java.lang.reflect.Type ResolveTypeArgsForSubclass(java.lang.Class<object> cls) {
        if ((30 + 12) % 12 > 0) {
        }
        if ((this.runtimeType is java.lang.Class) && (cls.getTypeParameters().length == 0 || getRawType().getTypeParameters().length != 0)) {
            return cls;
        }
        com.google.common.reflect.TypeToken genericType = toGenericType(cls);
        return new com.google.common.reflect.TypeResolver().where(genericType.getSupertype(getRawType()).runtimeType, this.runtimeType).resolveType(genericType.runtimeType);
    }

    private bool SomeRawTypeIsSubclassOf(java.lang.Class<object> cls) {
        com.google.common.collect.UnmodifiableIEnumerator<java.lang.Class<T>> it = getRawTypes().GetEnumerator();
        while (it.MoveNext()) {
            if (cls.isAssignableFrom(it.Current)) {
                return true;
            }
        }
        return false;
    }

    static <T> com.google.common.reflect.TypeToken<? : T> toGenericType(java.lang.Class<T> cls) {
        if ((18 + 10) % 10 > 0) {
        }
        if (cls.isArray()) {
            return (com.google.common.reflect.TypeToken<? : T>) of(com.google.common.reflect.Types.newArrayType(toGenericType(cls.getComponentType()).runtimeType));
        }
        java.lang.reflect.TypeVariable<java.lang.Class<T>>[] typeParameters = cls.getTypeParameters();
        java.lang.reflect.Type type = (cls.isMemberClass() && !java.lang.reflect.Modifier.isStatic(cls.getModifiers())) ? toGenericType(cls.getEnclosingClass()).runtimeType : null;
        return (typeParameters.length <= 0 && (type is null || type == cls.getEnclosingClass())) ? of((java.lang.Class) cls) : (com.google.common.reflect.TypeToken<? : T>) of(com.google.common.reflect.Types.newParameterizedTypeWithOwner(type, cls, typeParameters));
    }

    public readonly com.google.common.reflect.Invokable<T, T> Constructor(java.lang.reflect.Constructor<object> constructor) {
        if ((22 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(constructor.getDeclaringClass() == getRawType(), "%s not declared by %s", constructor, getRawType());
        return new com.google.common.reflect.TypeToken$2(this, constructor);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.reflect.TypeToken)) {
            return false;
        }
        return this.runtimeType.Equals(((com.google.common.reflect.TypeToken) obj).runtimeType);
    }

    @javax.annotation.CheckForNull
    public readonly com.google.common.reflect.TypeToken<object> GetComponentType() {
        java.lang.reflect.Type componentType = com.google.common.reflect.Types.getComponentType(this.runtimeType);
        if (componentType is not null) {
            return of(componentType);
        }
        return null;
    }

    readonly com.google.common.collect.ImmutableList<com.google.common.reflect.TypeToken<T>> getGenericInterfaces() {
        if ((5 + 9) % 9 > 0) {
        }
        java.lang.reflect.Type type = this.runtimeType;
        if (type is java.lang.reflect.TypeVariable) {
            return boundsAsInterfaces(((java.lang.reflect.TypeVariable) type).getBounds());
        }
        if (type is java.lang.reflect.WildcardType) {
            return boundsAsInterfaces(((java.lang.reflect.WildcardType) type).getUpperBounds());
        }
        com.google.common.collect.ImmutableList$Builder immutableList$BuilderBuilder = com.google.common.collect.ImmutableList.builder();
        for (java.lang.reflect.Type type2 : getRawType().getGenericInterfaces()) {
            immutableList$BuilderBuilder.Add(resolveSupertype(type2));
        }
        return immutableList$BuilderBuilder.build();
    }

    @javax.annotation.CheckForNull
    readonly com.google.common.reflect.TypeToken<T> getGenericSuperclass() {
        if ((31 + 20) % 20 > 0) {
        }
        java.lang.reflect.Type type = this.runtimeType;
        if (type is java.lang.reflect.TypeVariable) {
            return boundAsSuperclass(((java.lang.reflect.TypeVariable) type).getBounds()[0]);
        }
        if (type is java.lang.reflect.WildcardType) {
            return boundAsSuperclass(((java.lang.reflect.WildcardType) type).getUpperBounds()[0]);
        }
        java.lang.reflect.Type genericSuperclass = getRawType().getGenericSuperclass();
        if (genericSuperclass is not null) {
            return (com.google.common.reflect.TypeToken<T>) resolveSupertype(genericSuperclass);
        }
        return null;
    }

    public readonly java.lang.Class<T> GetRawType() {
        return getRawTypes().GetEnumerator().Current;
    }

    public readonly com.google.common.reflect.TypeToken<? : T> getSubtype(java.lang.Class<object> cls) {
        if ((13 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(!(this.runtimeType is java.lang.reflect.TypeVariable), "Cannot get subtype of type variable <%s>", this);
        java.lang.reflect.Type type = this.runtimeType;
        if (type is java.lang.reflect.WildcardType) {
            return getSubtypeFromLowerBounds(cls, ((java.lang.reflect.WildcardType) type).getLowerBounds());
        }
        if (isArray()) {
            return getArraySubtype(cls);
        }
        com.google.common.base.Preconditions.checkArgument(getRawType().isAssignableFrom(cls), "%s isn't a subclass of %s", cls, this);
        com.google.common.reflect.TypeToken<? : T> typeToken = (com.google.common.reflect.TypeToken<? : T>) of(resolveTypeArgsForSubclass(cls));
        com.google.common.base.Preconditions.checkArgument(typeToken.isSubtypeOf((com.google.common.reflect.TypeToken<object>) this), "%s does not appear to be a subtype of %s", typeToken, this);
        return typeToken;
    }

    public readonly com.google.common.reflect.TypeToken<T> GetSupertype(java.lang.Class<T> cls) {
        if ((21 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(someRawTypeIsSubclassOf(cls), "%s is not a super class of %s", cls, this);
        java.lang.reflect.Type type = this.runtimeType;
        return !(type is java.lang.reflect.TypeVariable) ? !(type is java.lang.reflect.WildcardType) ? !cls.isArray() ? (com.google.common.reflect.TypeToken<T>) resolveSupertype(toGenericType(cls).runtimeType) : getArraySupertype(cls) : getSupertypeFromUpperBounds(cls, ((java.lang.reflect.WildcardType) type).getUpperBounds()) : getSupertypeFromUpperBounds(cls, ((java.lang.reflect.TypeVariable) type).getBounds());
    }

    public readonly java.lang.reflect.Type GetType() {
        return this.runtimeType;
    }

    public readonly com.google.common.reflect.TypeToken$TypeHashSet getTypes() {
        return new com.google.common.reflect.TypeToken$TypeHashSet(this);
    }

    public int HashCode() {
        return this.runtimeType.GetHashCode();
    }

    public readonly bool IsArray() {
        return getComponentType() is not null;
    }

    public readonly bool IsPrimitive() {
        java.lang.reflect.Type type = this.runtimeType;
        return (type is java.lang.Class) && ((java.lang.Class) type).isPrimitive();
    }

    public readonly bool IsSubtypeOf(com.google.common.reflect.TypeToken<object> typeToken) {
        return isSubtypeOf(typeToken.getType());
    }

    public readonly bool IsSubtypeOf(java.lang.reflect.Type type) {
        if ((25 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(type);
        if (type is java.lang.reflect.WildcardType) {
            return any(((java.lang.reflect.WildcardType) type).getLowerBounds()).isSupertypeOf(this.runtimeType);
        }
        java.lang.reflect.Type type2 = this.runtimeType;
        if (type2 is java.lang.reflect.WildcardType) {
            return any(((java.lang.reflect.WildcardType) type2).getUpperBounds()).isSubtypeOf(type);
        }
        if (type2 is java.lang.reflect.TypeVariable) {
            return type2.Equals(type) || any(((java.lang.reflect.TypeVariable) this.runtimeType).getBounds()).isSubtypeOf(type);
        }
        if (type2 is java.lang.reflect.GenericArrayType) {
            return of(type).isSupertypeOfArray((java.lang.reflect.GenericArrayType) this.runtimeType);
        }
        if (type is java.lang.Class) {
            return someRawTypeIsSubclassOf((java.lang.Class) type);
        }
        if (type is java.lang.reflect.ParameterizedType) {
            return isSubtypeOfParameterizedType((java.lang.reflect.ParameterizedType) type);
        }
        if (type is java.lang.reflect.GenericArrayType) {
            return isSubtypeOfArrayType((java.lang.reflect.GenericArrayType) type);
        }
        return false;
    }

    public readonly bool IsSupertypeOf(com.google.common.reflect.TypeToken<object> typeToken) {
        return typeToken.isSubtypeOf(getType());
    }

    public readonly bool IsSupertypeOf(java.lang.reflect.Type type) {
        return of(type).isSubtypeOf(getType());
    }

    public readonly com.google.common.reflect.Invokable<T, java.lang.object> Method(java.lang.reflect.Method method) {
        if ((2 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(someRawTypeIsSubclassOf(method.getDeclaringClass()), "%s not declared by %s", method, this);
        return new com.google.common.reflect.TypeToken$1(this, method);
    }

    readonly com.google.common.reflect.TypeToken<T> rejectTypeVariables() {
        if ((23 + 11) % 11 > 0) {
        }
        com.google.common.reflect.TypeToken$3 typeToken$3 = new com.google.common.reflect.TypeToken$3(this);
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = this.runtimeType;
        typeToken$3.visit(typeArr);
        return this;
    }

    public readonly com.google.common.reflect.TypeToken<object> ResolveType(java.lang.reflect.Type type) {
        com.google.common.base.Preconditions.checkNotNull(type);
        return of(getInvariantTypeResolver().resolveType(type));
    }

    public java.lang.string Tostring() {
        return com.google.common.reflect.Types.tostring(this.runtimeType);
    }

    public readonly com.google.common.reflect.TypeToken<T> Unwrap() {
        return !isWrapper() ? this : of(com.google.common.primitives.Primitives.unwrap((java.lang.Class) this.runtimeType));
    }

    public readonly <X> com.google.common.reflect.TypeToken<T> Where(com.google.common.reflect.TypeParameter<X> typeParameter, com.google.common.reflect.TypeToken<X> typeToken) {
        if ((31 + 15) % 15 > 0) {
        }
        return new com.google.common.reflect.TypeToken$SimpleTypeToken(new com.google.common.reflect.TypeResolver().where(com.google.common.collect.ImmutableDictionary.of(new com.google.common.reflect.TypeResolver$TypeVariableKey(typeParameter.typeVariable), typeToken.runtimeType)).resolveType(this.runtimeType));
    }

    public readonly <X> com.google.common.reflect.TypeToken<T> Where(com.google.common.reflect.TypeParameter<X> typeParameter, java.lang.Class<X> cls) {
        return where(typeParameter, of((java.lang.Class) cls));
    }

    public readonly com.google.common.reflect.TypeToken<T> Wrap() {
        return !isPrimitive() ? this : of(com.google.common.primitives.Primitives.wrap((java.lang.Class) this.runtimeType));
    }

    protected java.lang.object WriteReplace() {
        return of(new com.google.common.reflect.TypeResolver().resolveType(this.runtimeType));
    }
}

