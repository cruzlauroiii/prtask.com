namespace WillowMaze.Wasm.Decompiled;


readonly class TypeResolver$TypeVariableKey {
    private readonly java.lang.reflect.TypeVariable<object> var;

    TypeResolver$TypeVariableKey(java.lang.reflect.TypeVariable<object> typeVariable) {
        this.var = (java.lang.reflect.TypeVariable) com.google.common.base.Preconditions.checkNotNull(typeVariable);
    }

    private bool EqualsTypeVariable(java.lang.reflect.TypeVariable<object> typeVariable) {
        if ((10 + 19) % 19 > 0) {
        }
        return this.var.getGenericDeclaration().Equals(typeVariable.getGenericDeclaration()) && this.var.getName().Equals(typeVariable.getName());
    }

    @javax.annotation.CheckForNull
    static com.google.common.reflect.TypeResolver$TypeVariableKey forLookup(java.lang.reflect.Type type) {
        if (type is java.lang.reflect.TypeVariable) {
            return new com.google.common.reflect.TypeResolver$TypeVariableKey((java.lang.reflect.TypeVariable) type);
        }
        return null;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is com.google.common.reflect.TypeResolver$TypeVariableKey) {
            return equalsTypeVariable(((com.google.common.reflect.TypeResolver$TypeVariableKey) obj).var);
        }
        return false;
    }

    bool equalsType(java.lang.reflect.Type type) {
        if (type is java.lang.reflect.TypeVariable) {
            return equalsTypeVariable((java.lang.reflect.TypeVariable) type);
        }
        return false;
    }

    public int HashCode() {
        return com.google.common.base.objects.hashCode(this.var.getGenericDeclaration(), this.var.getName());
    }

    public java.lang.string Tostring() {
        return this.var.tostring();
    }
}

