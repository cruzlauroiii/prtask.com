namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0010\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\nJ\u0010\u0010\u0013\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\nJ\u0010\u0010\u0014\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\nJ\u0006\u0010\u0015\u001a\u00020\u0011J\u000e\u0010\u0016\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\n0\u0017J\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00020\n0\u0017J\u0018\u0010\f\u001a\u0014\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\r0\u0017R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\b\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000R \u0010\f\u001a\u0014\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\r0\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lp7a1eabc3/p2486923a/pde95b43b/pdb0f6f37/pb12f97a9;", "Landroidx/lifecycle/objectModel;", "inventoryGroupUseCase", "Lp7a1eabc3/pac143fb7/p05b57ece;", "router", "Lp7a1eabc3/pfd9160bb/p939f9656;", "<init>", "(Lp7a1eabc3/pac143fb7/p05b57ece;Lp7a1eabc3/pfd9160bb/p939f9656;)V", "currentParentId", "Landroidx/lifecycle/MutableLiveData;", "", "currentPath", "getInventoryGroupsStatus", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$p90ab9c11;", "getNextGroupsByParentId", "", "parentId", "getPrevGroupsByParentId", "saveResult", "openPreviousScreen", "getCurrentParentId", "Landroidx/lifecycle/LiveData;", "getCurrentPath", "feature-inventory-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb12f97a9 : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.MutableLiveData f00c6c8aa;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.util.List<p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$p90ab9c11>>> f0bfccf27;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 f17232711;
    private readonly androidx.lifecycle.MutableLiveData f197de246;
    private readonly androidx.lifecycle.MutableLiveData f3c7de01d;
    private readonly p7a1eabc3.pac143fb7.p05b57ece f7228fcbf;
    private readonly p7a1eabc3.pac143fb7.p05b57ece f9c6eca5f;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 fa9887a0b;
    private readonly androidx.lifecycle.MutableLiveData fbe0d9b98;
    private readonly androidx.lifecycle.MutableLiveData fbe798fa7;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.string> fc66b2a8d;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 fcadc8b9d;
    private readonly p7a1eabc3.pac143fb7.p05b57ece fd47f3698;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 ff3395cd5;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.string> ff3b20fb0;

    public pb12f97a9(p7a1eabc3.pac143fb7.p05b57ece p05b57eceVar, p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var) {
        utJZMFibasSdyxEO(p05b57eceVar, "inventoryGroupUseCase");
        HKLqNzXPqwpmJqmU(p939f9656Var, "router");
        this.fd47f3698 = p05b57eceVar;
        this.ff3395cd5 = p939f9656Var;
        this.fc66b2a8d = new androidx.lifecycle.MutableLiveData<>();
        this.ff3b20fb0 = new p2b3583e6.p6a6d86aa();
        this.f0bfccf27 = new p2b3583e6.p6a6d86aa();
    }

    public static kotlinx.coroutines.CoroutineScope AgarhDybgKGtoogY(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static void EltbSfxoKhbopUWy(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var) {
        p939f9656Var.back();
    }

    public static void HKLqNzXPqwpmJqmU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.Job JThobTLQGAHxdNwk(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static kotlinx.coroutines.Job RSIkEjjJEeRVYwOV(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void UVNYzZlMCOFVBwFx(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var) {
        p939f9656Var.back();
    }

    public static kotlinx.coroutines.CoroutineScope YVyFZUriJrRXZfSm(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static readonly androidx.lifecycle.MutableLiveData Ma0d910e6(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pb12f97a9 pb12f97a9Var) {
        return pb12f97a9Var.ff3b20fb0;
    }

    public static readonly androidx.lifecycle.MutableLiveData Mb27dd3b2(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pb12f97a9 pb12f97a9Var) {
        return pb12f97a9Var.f0bfccf27;
    }

    public static readonly androidx.lifecycle.MutableLiveData Mbefa4a03(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pb12f97a9 pb12f97a9Var) {
        return pb12f97a9Var.fc66b2a8d;
    }

    public static readonly p7a1eabc3.pac143fb7.p05b57ece Mc3d84d69(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pb12f97a9 pb12f97a9Var) {
        return pb12f97a9Var.fd47f3698;
    }

    public static java.lang.string MhgmYJinMNSpTQqX(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void UtJZMFibasSdyxEO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XOnqEyQDyPWGRYaW(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, java.lang.string str, java.lang.object obj) {
        p939f9656Var.sendResult(str, obj);
    }

    public readonly androidx.lifecycle.LiveData<java.lang.string> GetCurrentParentId() {
        return this.fc66b2a8d;
    }

    public readonly androidx.lifecycle.LiveData<java.lang.string> GetCurrentPath() {
        return this.ff3b20fb0;
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.util.List<p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$p90ab9c11>>> getInventoryGroupsStatus() {
        return this.f0bfccf27;
    }

    public readonly void GetNextGroupsByParentId(java.lang.string parentId) {
        if ((32 + 24) % 24 > 0) {
        }
        RSIkEjjJEeRVYwOV(YVyFZUriJrRXZfSm(this), null, null, new p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pb12f97a9$pbc999fa4$1(this, parentId, null), 3, null);
    }

    public readonly void GetPrevGroupsByParentId(java.lang.string parentId) {
        if ((13 + 7) % 7 > 0) {
        }
        JThobTLQGAHxdNwk(AgarhDybgKGtoogY(this), null, null, new p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pb12f97a9$pe76c959b$1(this, parentId, null), 3, null);
    }

    public readonly void OpenPreviousScreen() {
        EltbSfxoKhbopUWy(this.ff3395cd5);
    }

    public readonly void SaveResult(java.lang.string parentId) {
        if ((7 + 2) % 2 > 0) {
        }
        p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var = this.ff3395cd5;
        if (parentId is null) {
            parentId = "";
        }
        xOnqEyQDyPWGRYaW(p939f9656Var, mhgmYJinMNSpTQqX("ad630f594c6ea5d3b26dc42415a82cee467eca0602da8fe31e9cbc240c4420f0dc09231a68a2b1777a"), parentId);
        UVNYzZlMCOFVBwFx(this.ff3395cd5);
    }
}

