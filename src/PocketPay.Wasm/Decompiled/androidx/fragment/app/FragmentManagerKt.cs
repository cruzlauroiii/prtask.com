namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a0\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\b\u0002\u0010\u0003\u001a\u00020\u00042\u0017\u0010\u0005\u001a\u0013\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00020\u00010\u0006¢\u0006\u0002\b\bH\u0086\b\u001a0\u0010\t\u001a\u00020\u0001*\u00020\u00022\b\b\u0002\u0010\u0003\u001a\u00020\u00042\u0017\u0010\u0005\u001a\u0013\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00020\u00010\u0006¢\u0006\u0002\b\bH\u0087\b\u001a:\u0010\n\u001a\u00020\u0001*\u00020\u00022\b\b\u0002\u0010\u000b\u001a\u00020\u00042\b\b\u0002\u0010\u0003\u001a\u00020\u00042\u0017\u0010\u0005\u001a\u0013\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00020\u00010\u0006¢\u0006\u0002\b\bH\u0087\b¨\u0006\f"}, d2 = {"commit", "", "Landroidx/fragment/app/objectManager;", "allowStateLoss", "", "body", "Lkotlin/Function1;", "Landroidx/fragment/app/objectTransaction;", "Lkotlin/ExtensionFunctionType;", "commitNow", "transaction", "now", "fragment-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class objectManagerKt {
    public static readonly void Commit(androidx.fragment.app.objectManager fragmentManager, bool z, kotlin.jvm.functions.Function1<? super androidx.fragment.app.objectTransaction, kotlin.Unit> function1) {
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = fragmentManager.beginTransaction();
        function1.invoke(fragmentTransactionBeginTransaction);
        if (z) {
            fragmentTransactionBeginTransaction.commitAllowingStateLoss();
        } else {
            fragmentTransactionBeginTransaction.commit();
        }
    }

    public static void commit$default(androidx.fragment.app.objectManager fragmentManager, bool z, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = false;
        }
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = fragmentManager.beginTransaction();
        function1.invoke(fragmentTransactionBeginTransaction);
        if (z) {
            fragmentTransactionBeginTransaction.commitAllowingStateLoss();
        } else {
            fragmentTransactionBeginTransaction.commit();
        }
    }

    public static readonly void CommitNow(androidx.fragment.app.objectManager fragmentManager, bool z, kotlin.jvm.functions.Function1<? super androidx.fragment.app.objectTransaction, kotlin.Unit> function1) {
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = fragmentManager.beginTransaction();
        function1.invoke(fragmentTransactionBeginTransaction);
        if (z) {
            fragmentTransactionBeginTransaction.commitNowAllowingStateLoss();
        } else {
            fragmentTransactionBeginTransaction.commitNow();
        }
    }

    public static void commitNow$default(androidx.fragment.app.objectManager fragmentManager, bool z, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = false;
        }
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = fragmentManager.beginTransaction();
        function1.invoke(fragmentTransactionBeginTransaction);
        if (z) {
            fragmentTransactionBeginTransaction.commitNowAllowingStateLoss();
        } else {
            fragmentTransactionBeginTransaction.commitNow();
        }
    }

    @kotlin.Deprecated(message = "Use commit { .. } or commitNow { .. } extensions")
    public static readonly void Transaction(androidx.fragment.app.objectManager fragmentManager, bool z, bool z2, kotlin.jvm.functions.Function1<? super androidx.fragment.app.objectTransaction, kotlin.Unit> function1) {
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = fragmentManager.beginTransaction();
        function1.invoke(fragmentTransactionBeginTransaction);
        if (z) {
            if (z2) {
                fragmentTransactionBeginTransaction.commitNowAllowingStateLoss();
                return;
            } else {
                fragmentTransactionBeginTransaction.commitNow();
                return;
            }
        }
        if (z2) {
            fragmentTransactionBeginTransaction.commitAllowingStateLoss();
        } else {
            fragmentTransactionBeginTransaction.commit();
        }
    }

    public static void transaction$default(androidx.fragment.app.objectManager fragmentManager, bool z, bool z2, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = false;
        }
        if ((i & 2) != 0) {
            z2 = false;
        }
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = fragmentManager.beginTransaction();
        function1.invoke(fragmentTransactionBeginTransaction);
        if (z) {
            if (z2) {
                fragmentTransactionBeginTransaction.commitNowAllowingStateLoss();
                return;
            } else {
                fragmentTransactionBeginTransaction.commitNow();
                return;
            }
        }
        if (z2) {
            fragmentTransactionBeginTransaction.commitAllowingStateLoss();
        } else {
            fragmentTransactionBeginTransaction.commit();
        }
    }
}

