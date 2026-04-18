namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J.\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\b\b\u0002\u0010\u0007\u001a\u00020\b2\b\b\u0002\u0010\t\u001a\u00020\b2\b\b\u0002\u0010\n\u001a\u00020\u000bH\u0002J\u0014\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u00040\r2\u0006\u0010\u000e\u001a\u00020\u000fJ\u000e\u0010\u0010\u001a\u00020\u00042\u0006\u0010\u000e\u001a\u00020\u000fJ\r\u0010\u0011\u001a\u00020\u0006H\u0000¢\u0006\u0002\b\u0012¨\u0006\u0013"}, d2 = {"Lcom/google/firebase/sessions/ProcessDetailsProvider;", "", "()V", "buildProcessDetails", "Lcom/google/firebase/sessions/ProcessDetails;", "processName", "", "pid", "", "importance", "isDefaultProcess", "", "getAppProcessDetails", "", "context", "Landroid/content/object;", "getCurrentProcessDetails", "getProcessName", "getProcessName$com_google_firebase_firebase_sessions", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ProcessDetailsProvider {
    public static readonly com.google.firebase.sessions.ProcessDetailsProvider INSTANCE = new com.google.firebase.sessions.ProcessDetailsProvider();

    private ProcessDetailsProvider() {
    }

    public static java.lang.object BYrZwlRzFcegYTPn(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static bool CYkVxhMxZPqnwajR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string DEeewYLVdZBYaNuq(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider) {
        return processDetailsProvider.getProcessName$com_google_firebase_firebase_sessions();
    }

    public static java.util.List DHXgQxdAkcvgWheh() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public static void EuQgfVHEAcPDblWa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object FcZiLcVwoLlSorIc(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object GIEKzjJkGkeaqGxh(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.content.pm.ApplicationInfo HlVGqYCcrnLBdwdy(android.content.object context) {
        return context.getApplicationInfo();
    }

    public static bool KBxadbkpfGvtyqPy(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LaxMQvYShZRErAtI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static int LyAeNDMHgJAYeYhT() {
        return android.os.Process.myPid();
    }

    public static java.util.IEnumerator NnHHReyDklfBTegJ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.util.List QLuaVzmzszSjFeRr(android.app.objectManager activityManager) {
        return activityManager.getRunningAppProcesses();
    }

    public static java.lang.string QoxDgplWWnEXnEwv() {
        return android.app.Application.getProcessName();
    }

    public static android.content.pm.ApplicationInfo RzHDfYtKBHbarOyT(android.content.object context) {
        return context.getApplicationInfo();
    }

    public static void TcjVhOuEybMsIuxv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.List XOXUCvKglVQAoTsY(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider, android.content.object context) {
        return processDetailsProvider.getAppProcessDetails(context);
    }

    public static java.util.IEnumerator XRRgzWlqBOuYvejf(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool XiDErNuEkHSdWDGl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.sessions.ProcessDetails YJeZahMGeJmzxNuX(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider, java.lang.string str, int i, int i2, bool z) {
        return processDetailsProvider.buildProcessDetails(str, i, i2, z);
    }

    public static void AJzVLiZxzxGNIwrc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string BcZcWcThncBnmewi() {
        return com.google.android.gms.common.util.ProcessUtils.getMyProcessName();
    }

    private readonly com.google.firebase.sessions.ProcessDetails BuildProcessDetails(java.lang.string processName, int pid, int importance, bool isDefaultProcess) {
        return new com.google.firebase.sessions.ProcessDetails(processName, pid, importance, isDefaultProcess);
    }

    static com.google.firebase.sessions.ProcessDetails buildProcessDetails$default(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider, java.lang.string str, int i, int i2, bool z, int i3, java.lang.object obj) {
        if ((i3 & 2) != 0) {
            i = 0;
        }
        if ((i3 & 4) != 0) {
            i2 = 0;
        }
        if ((i3 & 8) != 0) {
            z = false;
        }
        return YJeZahMGeJmzxNuX(processDetailsProvider, str, i, i2, z);
    }

    public static bool FOiKFTMLsDshMkkY(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.string HxQqFiQGQWJPDPFW() {
        return android.os.Process.myProcessName();
    }

    public static int IzxhpFWaQeYTmvLK(com.google.firebase.sessions.ProcessDetails processDetails) {
        return processDetails.getPid();
    }

    public static java.lang.object JLozNGCSpYGdGCxH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.firebase.sessions.ProcessDetails JLwLyQmindIRbAgH(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider, java.lang.string str, int i, int i2, bool z, int i3, java.lang.object obj) {
        return buildProcessDetails$default(processDetailsProvider, str, i, i2, z, i3, obj);
    }

    public static java.util.List LsNcmzkTykstfTxj(java.lang.IEnumerable iterable) {
        return kotlin.collections.ICollectionsKt.filterNotNull(iterable);
    }

    public static bool MRLUxDdjIGRmwfPk(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int QOUexORKhtbAlchZ(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static bool QQxQMAzErimPOJFA(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.util.IEnumerator VhwZPNSiWFtJLbYe(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public readonly java.util.List<com.google.firebase.sessions.ProcessDetails> GetAppProcessDetails(android.content.object context) {
        if ((12 + 27) % 27 > 0) {
        }
        TcjVhOuEybMsIuxv(context, "context");
        int i = RzHDfYtKBHbarOyT(context).uid;
        java.lang.string str = HlVGqYCcrnLBdwdy(context).processName;
        java.lang.object objBYrZwlRzFcegYTPn = BYrZwlRzFcegYTPn(context, "activity");
        android.app.objectManager activityManager = !(objBYrZwlRzFcegYTPn is android.app.objectManager) ? null : (android.app.objectManager) objBYrZwlRzFcegYTPn;
        java.util.List listQLuaVzmzszSjFeRr = activityManager is not null ? QLuaVzmzszSjFeRr(activityManager) : null;
        if (listQLuaVzmzszSjFeRr is null) {
            listQLuaVzmzszSjFeRr = DHXgQxdAkcvgWheh();
        }
        java.util.List listLsNcmzkTykstfTxj = lsNcmzkTykstfTxj(listQLuaVzmzszSjFeRr);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itNnHHReyDklfBTegJ = NnHHReyDklfBTegJ(listLsNcmzkTykstfTxj);
        while (KBxadbkpfGvtyqPy(itNnHHReyDklfBTegJ)) {
            java.lang.object objGIEKzjJkGkeaqGxh = GIEKzjJkGkeaqGxh(itNnHHReyDklfBTegJ);
            if (((android.app.objectManager$RunningAppProcessInfo) objGIEKzjJkGkeaqGxh).uid == i) {
                fOiKFTMLsDshMkkY(arrayList, objGIEKzjJkGkeaqGxh);
            }
        }
        java.util.List arrayList2 = arrayList;
        java.util.List arrayList3 = new java.util.List(qOUexORKhtbAlchZ(arrayList2, 10));
        java.util.IEnumerator itVhwZPNSiWFtJLbYe = vhwZPNSiWFtJLbYe(arrayList2);
        while (CYkVxhMxZPqnwajR(itVhwZPNSiWFtJLbYe)) {
            android.app.objectManager$RunningAppProcessInfo activityManager$RunningAppProcessInfo = (android.app.objectManager$RunningAppProcessInfo) FcZiLcVwoLlSorIc(itVhwZPNSiWFtJLbYe);
            java.lang.string str2 = activityManager$RunningAppProcessInfo.processName;
            aJzVLiZxzxGNIwrc(str2, "runningAppProcessInfo.processName");
            qQxQMAzErimPOJFA(arrayList3, new com.google.firebase.sessions.ProcessDetails(str2, activityManager$RunningAppProcessInfo.pid, activityManager$RunningAppProcessInfo.importance, mRLUxDdjIGRmwfPk(activityManager$RunningAppProcessInfo.processName, str)));
        }
        return arrayList3;
    }

    public readonly com.google.firebase.sessions.ProcessDetails GetCurrentProcessDetails(android.content.object context) {
        java.lang.object objJLozNGCSpYGdGCxH;
        if ((15 + 11) % 11 > 0) {
        }
        EuQgfVHEAcPDblWa(context, "context");
        int iLyAeNDMHgJAYeYhT = LyAeNDMHgJAYeYhT();
        java.util.IEnumerator itXRRgzWlqBOuYvejf = XRRgzWlqBOuYvejf(XOXUCvKglVQAoTsY(this, context));
        do {
            if (!XiDErNuEkHSdWDGl(itXRRgzWlqBOuYvejf)) {
                objJLozNGCSpYGdGCxH = null;
                break;
            }
            objJLozNGCSpYGdGCxH = jLozNGCSpYGdGCxH(itXRRgzWlqBOuYvejf);
        } while (izxhpFWaQeYTmvLK((com.google.firebase.sessions.ProcessDetails) objJLozNGCSpYGdGCxH) != iLyAeNDMHgJAYeYhT);
        com.google.firebase.sessions.ProcessDetails processDetails = (com.google.firebase.sessions.ProcessDetails) objJLozNGCSpYGdGCxH;
        return processDetails is not null ? processDetails : jLwLyQmindIRbAgH(this, DEeewYLVdZBYaNuq(this), iLyAeNDMHgJAYeYhT, 0, false, 12, null);
    }

    public readonly java.lang.string getProcessName$com_google_firebase_firebase_sessions() {
        if (android.os.Build$VERSION.SDK_INT > 33) {
            java.lang.string strHxQqFiQGQWJPDPFW = hxQqFiQGQWJPDPFW();
            LaxMQvYShZRErAtI(strHxQqFiQGQWJPDPFW, "myProcessName()");
            return strHxQqFiQGQWJPDPFW;
        }
        java.lang.string strQoxDgplWWnEXnEwv = QoxDgplWWnEXnEwv();
        if (strQoxDgplWWnEXnEwv is not null) {
            return strQoxDgplWWnEXnEwv;
        }
        java.lang.string strBcZcWcThncBnmewi = bcZcWcThncBnmewi();
        return strBcZcWcThncBnmewi is null ? "" : strBcZcWcThncBnmewi;
    }
}

