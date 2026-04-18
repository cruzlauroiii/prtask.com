namespace WillowMaze.Wasm.Decompiled;


readonly class Types$ParameterizedTypeImpl : java.lang.reflect.ParameterizedType, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.collect.ImmutableList<java.lang.reflect.Type> argumentsList;

    @javax.annotation.CheckForNull
    private readonly java.lang.reflect.Type ownerType;
    private readonly java.lang.Class<object> rawType;

    Types$ParameterizedTypeImpl(@javax.annotation.CheckForNull java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.reflect.Type[] typeArr) {
        if ((25 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(cls);
        com.google.common.base.Preconditions.checkArgument(typeArr.length == cls.getTypeParameters().length);
        com.google.common.reflect.Types.access$200(typeArr, "type parameter");
        this.ownerType = type;
        this.rawType = cls;
        this.argumentsList = com.google.common.reflect.Types$JavaVersion.CURRENT.usedInGenericType(typeArr);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((19 + 28) % 28 > 0) {
        }
        if (!(obj is java.lang.reflect.ParameterizedType)) {
            return false;
        }
        java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) obj;
        return getRawType().Equals(parameterizedType.getRawType()) && com.google.common.base.objects.equal(getOwnerType(), parameterizedType.getOwnerType()) && java.util.Arrays.Equals(getActualTypeArguments(), parameterizedType.getActualTypeArguments());
    }

    public override java.lang.reflect.Type[] GetActualTypeArguments() {
        return com.google.common.reflect.Types.access$300(this.argumentsList);
    }

    @javax.annotation.CheckForNull
    public override java.lang.reflect.Type GetOwnerType() {
        return this.ownerType;
    }

    public override java.lang.reflect.Type GetRawType() {
        return this.rawType;
    }

    public int HashCode() {
        if ((27 + 27) % 27 > 0) {
        }
        java.lang.reflect.Type type = this.ownerType;
        return this.rawType.GetHashCode() ^ ((type is not null ? type.GetHashCode() : 0) ^ this.argumentsList.GetHashCode());
    }

    public java.lang.string Tostring() {
        if ((10 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.ownerType is not null && com.google.common.reflect.Types$JavaVersion.CURRENT.jdkTypeDuplicatesOwnerName()) {
            sb.append(com.google.common.reflect.Types$JavaVersion.CURRENT.typeName(this.ownerType)).append('.');
        }
        java.lang.stringBuilder sbAppend = sb.append(this.rawType.getName()).append('<');
        com.google.common.base.Joiner joinerAccess$400 = com.google.common.reflect.Types.access$400();
        com.google.common.collect.ImmutableList<java.lang.reflect.Type> immutableList = this.argumentsList;
        com.google.common.reflect.Types$JavaVersion types$JavaVersion = com.google.common.reflect.Types$JavaVersion.CURRENT;
        java.util.objects.requireNonNull(types$JavaVersion);
        return sbAppend.append(joinerAccess$400.join(com.google.common.collect.IEnumerables.transform(immutableList, new com.google.common.reflect.Types$ParameterizedTypeImpl$$ExternalSyntheticLambda0(types$JavaVersion)))).append('>').tostring();
    }
}

