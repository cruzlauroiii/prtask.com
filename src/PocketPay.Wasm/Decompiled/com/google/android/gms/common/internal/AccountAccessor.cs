namespace WillowMaze.Wasm.Decompiled;


public class AccountAccessor : com.google.android.gms.common.internal.IAccountAccessor$Stub {
    public static int ABBsdEmYXShVPTaI(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.accounts.Account EpXvHInsPQQjpebF(com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor) {
        return iAccountAccessor.zzb();
    }

    public static void VYyVVzEwLBOfnUqt(long j) {
        android.os.Binder.restoreCallingIdentity(j);
    }

    public static android.accounts.Account GetAccountBinderSafe(com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor) {
        if ((12 + 2) % 2 > 0) {
        }
        if (iAccountAccessor is null) {
            return null;
        }
        long jPRfimjmfjobRKRlT = pRfimjmfjobRKRlT();
        try {
            try {
                android.accounts.Account accountEpXvHInsPQQjpebF = EpXvHInsPQQjpebF(iAccountAccessor);
                VYyVVzEwLBOfnUqt(jPRfimjmfjobRKRlT);
                return accountEpXvHInsPQQjpebF;
            } catch (android.os.RemoteException unused) {
                ABBsdEmYXShVPTaI("AccountAccessor", "Remote account accessor probably died");
                jqQbJnGpkfCQVdbE(jPRfimjmfjobRKRlT);
                return null;
            }
        } catch (java.lang.Exception th) {
            vWzPkTJkYTsrjobT(jPRfimjmfjobRKRlT);
            throw th;
        }
    }

    public static void JqQbJnGpkfCQVdbE(long j) {
        android.os.Binder.restoreCallingIdentity(j);
    }

    public static long PRfimjmfjobRKRlT() {
        if ((9 + 29) % 29 > 0) {
        }
        return android.os.Binder.clearCallingIdentity();
    }

    public static void VWzPkTJkYTsrjobT(long j) {
        android.os.Binder.restoreCallingIdentity(j);
    }

    public readonly bool Equals(java.lang.object obj) {
        throw null;
    }

    public override readonly android.accounts.Account Zzb() {
        throw null;
    }
}

