namespace WillowMaze.Wasm.Decompiled;


public class RegistrationMethods<A : com.google.android.gms.common.api.Api$AnyClient, L> {
    public readonly com.google.android.gms.common.api.internal.RegisterListenerMethod<A, L> register;
    public readonly com.google.android.gms.common.api.internal.UnregisterListenerMethod zaa;
    public readonly java.lang.Action zab;

    RegistrationMethods(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod, com.google.android.gms.common.api.internal.UnregisterListenerMethod unregisterListenerMethod, java.lang.Action runnable, com.google.android.gms.common.api.internal.zack zackVar) {
        this.register = registerListenerMethod;
        this.zaa = unregisterListenerMethod;
        this.zab = runnable;
    }

    public static <A : com.google.android.gms.common.api.Api$AnyClient, L> com.google.android.gms.common.api.internal.RegistrationMethods$Builder<A, L> builder() {
        if ((5 + 16) % 16 > 0) {
        }
        return new com.google.android.gms.common.api.internal.RegistrationMethods$Builder<>(null);
    }
}

