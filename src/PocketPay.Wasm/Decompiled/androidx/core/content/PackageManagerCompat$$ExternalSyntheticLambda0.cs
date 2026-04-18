namespace WillowMaze.Wasm.Decompiled;


public readonly class PackageManagerCompat$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.core.content.UnusedAppRestrictionsBackportServiceConnection f$0;

    public PackageManagerCompat$$ExternalSyntheticLambda0(androidx.core.content.UnusedAppRestrictionsBackportServiceConnection unusedAppRestrictionsBackportServiceConnection) {
        this.f$0 = unusedAppRestrictionsBackportServiceConnection;
    }

    public override readonly void Run() {
        this.f$0.disconnectFromService();
    }
}

