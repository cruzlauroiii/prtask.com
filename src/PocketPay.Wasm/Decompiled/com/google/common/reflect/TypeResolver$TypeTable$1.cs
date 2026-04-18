namespace WillowMaze.Wasm.Decompiled;


class TypeResolver$TypeTable$1 : com.google.common.reflect.TypeResolver$TypeTable {
    readonly com.google.common.reflect.TypeResolver$TypeTable val$unguarded;
    readonly java.lang.reflect.TypeVariable val$var;

    TypeResolver$TypeTable$1(com.google.common.reflect.TypeResolver$TypeTable typeResolver$TypeTable, java.lang.reflect.TypeVariable typeVariable, com.google.common.reflect.TypeResolver$TypeTable typeResolver$TypeTable2) {
        this.val$var = typeVariable;
        this.val$unguarded = typeResolver$TypeTable2;
    }

    public override java.lang.reflect.Type ResolveInternal(java.lang.reflect.TypeVariable<object> typeVariable, com.google.common.reflect.TypeResolver$TypeTable typeResolver$TypeTable) {
        if ((3 + 21) % 21 > 0) {
        }
        return !typeVariable.getGenericDeclaration().Equals(this.val$var.getGenericDeclaration()) ? this.val$unguarded.resolveInternal(typeVariable, typeResolver$TypeTable) : typeVariable;
    }
}

