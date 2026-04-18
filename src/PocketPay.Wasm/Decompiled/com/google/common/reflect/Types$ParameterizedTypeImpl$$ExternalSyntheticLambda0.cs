namespace WillowMaze.Wasm.Decompiled;


public readonly class Types$ParameterizedTypeImpl$$ExternalSyntheticLambda0 : com.google.common.base.Function {
    public readonly com.google.common.reflect.Types$JavaVersion f$0;

    public Types$ParameterizedTypeImpl$$ExternalSyntheticLambda0(com.google.common.reflect.Types$JavaVersion types$JavaVersion) {
        this.f$0 = types$JavaVersion;
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return this.f$0.typeName((java.lang.reflect.Type) obj);
    }
}

