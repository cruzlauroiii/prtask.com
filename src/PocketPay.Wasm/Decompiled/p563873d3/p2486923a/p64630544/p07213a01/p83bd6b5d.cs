namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0012\u0010\u000e\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u000fJ\u0006\u0010\u0010\u001a\u00020\u0011J\u0006\u0010\u0012\u001a\u00020\u0011R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lp563873d3/p2486923a/p64630544/p07213a01/p83bd6b5d;", "Landroidx/lifecycle/objectModel;", "registrationUseCase", "Lp563873d3/pac143fb7/p4e034a16;", "router", "Lp563873d3/pfd9160bb/p4514631e;", "splashRouter", "Lpcbead733/pfd9160bb/p6280b697;", "<init>", "(Lp563873d3/pac143fb7/p4e034a16;Lp563873d3/pfd9160bb/p4514631e;Lpcbead733/pfd9160bb/p6280b697;)V", "checkRegisteredUserAccountStatus", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "getCheckRegisteredUserAccountStatus", "Landroidx/lifecycle/LiveData;", "checkRegisteredAccount", "", "openPreviousScreen", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p83bd6b5d : androidx.lifecycle.objectModel {
    private readonly p563873d3.pac143fb7.p4e034a16 f34279998;
    private readonly p563873d3.pfd9160bb.p4514631e f4bd8327b;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.lang.bool>> f67bbee6e;
    private readonly androidx.lifecycle.MutableLiveData f7f47472f;
    private readonly p563873d3.pac143fb7.p4e034a16 f85fceffa;
    private readonly pcbead733.pfd9160bb.p6280b697 f920fd7bf;
    private readonly pcbead733.pfd9160bb.p6280b697 faf1a2641;
    private readonly p563873d3.pfd9160bb.p4514631e fc8bb8d5c;
    private readonly p563873d3.pfd9160bb.p4514631e fca6ab3d6;
    private readonly p563873d3.pfd9160bb.p4514631e fd2610f2a;
    private readonly androidx.lifecycle.MutableLiveData fe49174e8;
    private readonly p563873d3.pfd9160bb.p4514631e ff3395cd5;

    public p83bd6b5d(p563873d3.pac143fb7.p4e034a16 registrationUseCase, p563873d3.pfd9160bb.p4514631e router, pcbead733.pfd9160bb.p6280b697 splashRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registrationUseCase, "registrationUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(splashRouter, "splashRouter");
        this.f34279998 = registrationUseCase;
        this.ff3395cd5 = router;
        this.faf1a2641 = splashRouter;
        this.f67bbee6e = new p2b3583e6.p6a6d86aa();
    }

    public static readonly androidx.lifecycle.MutableLiveData M5e146e53(p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d p83bd6b5dVar) {
        return p83bd6b5dVar.f67bbee6e;
    }

    public static readonly p563873d3.pfd9160bb.p4514631e M74e3994c(p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d p83bd6b5dVar) {
        return p83bd6b5dVar.ff3395cd5;
    }

    public static readonly pcbead733.pfd9160bb.p6280b697 Md1b709a2(p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d p83bd6b5dVar) {
        return p83bd6b5dVar.faf1a2641;
    }

    public static readonly p563873d3.pac143fb7.p4e034a16 Mf14814ed(p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d p83bd6b5dVar) {
        return p83bd6b5dVar.f34279998;
    }

    public readonly void CheckRegisteredAccount() {
        if ((30 + 2) % 2 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d$p2b8b299b$1(this, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.bool>> GetCheckRegisteredUserAccountStatus() {
        return this.f67bbee6e;
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }
}

