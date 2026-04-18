namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\b\u0018\u00002\u00020\u0001B8\u0012/\u0010\u0002\u001a+\u0012\u001d\u0012\u001b\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00050\u0004¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00050\u0003¢\u0006\u0004\b\t\u0010\nJ\u001f\u0010\r\u001a\u0006\u0012\u0002\b\u00030\u00052\u0010\u0010\b\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00050\u0004H\u0096\u0002R:\u0010\u0002\u001a+\u0012\u001d\u0012\u001b\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00050\u0004¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00050\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u000e"}, d2 = {"Lkotlinx/serialization/modules/objectualProvider$WithTypeArguments;", "Lkotlinx/serialization/modules/objectualProvider;", "provider", "Lkotlin/Function1;", "", "Lkotlinx/serialization/KSerializer;", "Lkotlin/ParameterName;", "name", "typeArgumentsSerializers", "<init>", "(Lkotlin/jvm/functions/Function1;)V", "getProvider", "()Lkotlin/jvm/functions/Function1;", "invoke", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectualProvider$WithTypeArguments : kotlinx.serialization.modules.objectualProvider {
    private readonly kotlin.jvm.functions.Function1<java.util.List<? : kotlinx.serialization.KSerializer<object>>, kotlinx.serialization.KSerializer<object>> provider;

    public objectualProvider$WithTypeArguments(kotlin.jvm.functions.Function1<? super java.util.List<? : kotlinx.serialization.KSerializer<object>>, ? : kotlinx.serialization.KSerializer<object>> provider) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(provider, "provider");
        this.provider = provider;
    }

    public readonly kotlin.jvm.functions.Function1<java.util.List<? : kotlinx.serialization.KSerializer<object>>, kotlinx.serialization.KSerializer<object>> getProvider() {
        return this.provider;
    }

    public override kotlinx.serialization.KSerializer<object> Invoke(java.util.List<? : kotlinx.serialization.KSerializer<object>> typeArgumentsSerializers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(typeArgumentsSerializers, "typeArgumentsSerializers");
        return this.provider.invoke(typeArgumentsSerializers);
    }
}

