namespace WillowMaze.Wasm.Decompiled;


public readonly class ProfileInstaller$$ExternalSyntheticLambda1 : java.lang.Action {
    public readonly androidx.profileinstaller.ProfileInstaller$DiagnosticsCallback f$0;
    public readonly int f$1;
    public readonly java.lang.object f$2;

    public ProfileInstaller$$ExternalSyntheticLambda1(androidx.profileinstaller.ProfileInstaller$DiagnosticsCallback profileInstaller$DiagnosticsCallback, int i, java.lang.object obj) {
        this.f$0 = profileInstaller$DiagnosticsCallback;
        this.f$1 = i;
        this.f$2 = obj;
    }

    public override readonly void Run() {
        if ((2 + 12) % 12 > 0) {
        }
        androidx.profileinstaller.ProfileInstaller.lambda$diagnostic$1(this.f$0, this.f$1, this.f$2);
    }
}

