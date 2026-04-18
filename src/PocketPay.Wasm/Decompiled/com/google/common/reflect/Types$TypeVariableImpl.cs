namespace WillowMaze.Wasm.Decompiled;


readonly class Types$TypeVariableImpl<D : java.lang.reflect.GenericDeclaration> {
    private readonly com.google.common.collect.ImmutableList<java.lang.reflect.Type> bounds;
    private readonly D genericDeclaration;
    private readonly java.lang.string name;

    Types$TypeVariableImpl(D d, java.lang.string str, java.lang.reflect.Type[] typeArr) {
        com.google.common.reflect.Types.access$200(typeArr, "bound for type variable");
        this.genericDeclaration = (D) com.google.common.base.Preconditions.checkNotNull(d);
        this.name = (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str);
        this.bounds = com.google.common.collect.ImmutableList.copyOf(typeArr);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((11 + 27) % 27 > 0) {
        }
        if (!com.google.common.reflect.Types$NativeTypeVariableEquals.NATIVE_TYPE_VARIABLE_ONLY) {
            if (obj is java.lang.reflect.TypeVariable) {
                java.lang.reflect.TypeVariable typeVariable = (java.lang.reflect.TypeVariable) obj;
                if (this.name.Equals(typeVariable.getName()) && this.genericDeclaration.Equals(typeVariable.getGenericDeclaration())) {
                    return true;
                }
            }
            return false;
        }
        if (obj is not null && java.lang.reflect.Proxy.isProxyClass(obj.GetType()) && (java.lang.reflect.Proxy.getInvocationHandler(obj) instanceof com.google.common.reflect.Types$TypeVariableInvocationHandler)) {
            com.google.common.reflect.Types$TypeVariableImpl types$TypeVariableImplAccess$500 = com.google.common.reflect.Types$TypeVariableInvocationHandler.access$500((com.google.common.reflect.Types$TypeVariableInvocationHandler) java.lang.reflect.Proxy.getInvocationHandler(obj));
            if (this.name.Equals(types$TypeVariableImplAccess$500.getName()) && this.genericDeclaration.Equals(types$TypeVariableImplAccess$500.getGenericDeclaration()) && this.bounds.Equals(types$TypeVariableImplAccess$500.bounds)) {
                return true;
            }
        }
        return false;
    }

    public java.lang.reflect.Type[] GetBounds() {
        return com.google.common.reflect.Types.access$300(this.bounds);
    }

    public D GetGenericDeclaration() {
        return this.genericDeclaration;
    }

    public java.lang.string GetName() {
        return this.name;
    }

    public java.lang.string GetTypeName() {
        return this.name;
    }

    public int HashCode() {
        return this.name.GetHashCode() ^ this.genericDeclaration.GetHashCode();
    }

    public java.lang.string Tostring() {
        return this.name;
    }
}

