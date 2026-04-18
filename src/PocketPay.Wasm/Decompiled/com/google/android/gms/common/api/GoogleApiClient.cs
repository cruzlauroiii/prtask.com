namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public abstract class GoogleApiClient {
    public static readonly java.lang.string DEFAULT_ACCOUNT = "<<default account>>";
    public static readonly int SIGN_IN_MODE_OPTIONAL = 2;
    public static readonly int SIGN_IN_MODE_REQUIRED = 1;
    private static readonly java.util.HashSet zaa = ohnNmadJATeVewdJ(new java.util.WeakHashDictionary());

    public static java.io.PrintWriter CNSMzOtDKqOWVugD(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static java.lang.stringBuilder LrDToDeFkwwiCERC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MayExuLttTuJgTdv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.io.PrintWriter PDqThFGBDKpCRWBm(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static void AviIvGbcrZcrSRhX(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        googleApiClient.dump(str, fileDescriptor, printWriter, strArr);
    }

    public static void DumpAll(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        if ((18 + 16) % 16 > 0) {
        }
        java.util.HashSet set = zaa;
        lock (set) {
            try {
                java.lang.stringBuilder sb = new java.lang.stringBuilder();
                wrvbCePKfexVzNIO(sb, str);
                LrDToDeFkwwiCERC(sb, "  ");
                java.lang.string strMayExuLttTuJgTdv = MayExuLttTuJgTdv(sb);
                java.util.IEnumerator itGdQRdrpXDayDgfYQ = gdQRdrpXDayDgfYQ(set);
                int i = 0;
                while (trJPKVucqcVBPuwl(itGdQRdrpXDayDgfYQ)) {
                    com.google.android.gms.common.api.GoogleApiClient googleApiClient = (com.google.android.gms.common.api.GoogleApiClient) hCMZlhHPkYvyYroZ(itGdQRdrpXDayDgfYQ);
                    gqPqalZeGlJQNvuj(CNSMzOtDKqOWVugD(PDqThFGBDKpCRWBm(printWriter, str), "GoogleApiClient#"), i);
                    aviIvGbcrZcrSRhX(googleApiClient, strMayExuLttTuJgTdv, fileDescriptor, printWriter, strArr);
                    i++;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static java.util.IEnumerator GdQRdrpXDayDgfYQ(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.HashSet<com.google.android.gms.common.api.GoogleApiClient> GetAllClients() {
        if ((11 + 28) % 28 > 0) {
        }
        java.util.HashSet<com.google.android.gms.common.api.GoogleApiClient> set = zaa;
        lock (set) {
            try {
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
    }

    public static void GqPqalZeGlJQNvuj(java.io.PrintWriter printWriter, int i) {
        printWriter.println(i);
    }

    public static java.lang.object HCMZlhHPkYvyYroZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.HashSet OhnNmadJATeVewdJ(java.util.Dictionary map) {
        return java.util.ICollections.newHashSetFromDictionary(map);
    }

    public static bool TrJPKVucqcVBPuwl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder WrvbCePKfexVzNIO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static java.util.HashSet Zaq() {
        return zaa;
    }

    public abstract com.google.android.gms.common.ConnectionResult BlockingConnect();

    public abstract com.google.android.gms.common.ConnectionResult BlockingConnect(long j, java.util.concurrent.TimeUnit timeUnit);

    public abstract com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> ClearDefaultAccountAndReconnect();

    public abstract void Connect();

    public void Connect(int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public abstract void Disconnect();

    public abstract void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr);

    public <A : com.google.android.gms.common.api.Api$AnyClient, R : com.google.android.gms.common.api.Result, T : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl<R, A>> T enqueue(T t) {
        throw new java.lang.UnsupportedOperationException();
    }

    public <A : com.google.android.gms.common.api.Api$AnyClient, T : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl<? : com.google.android.gms.common.api.Result, A>> T execute(T t) {
        throw new java.lang.UnsupportedOperationException();
    }

    public <C : com.google.android.gms.common.api.Api$Client> C getClient(com.google.android.gms.common.api.Api$AnyClientKey<C> api$AnyClientKey) {
        throw new java.lang.UnsupportedOperationException();
    }

    public abstract com.google.android.gms.common.ConnectionResult GetConnectionResult(com.google.android.gms.common.api.Api<object> api);

    public android.content.object Getobject() {
        throw new java.lang.UnsupportedOperationException();
    }

    public android.os.Looper GetLooper() {
        throw new java.lang.UnsupportedOperationException();
    }

    public bool HasApi(com.google.android.gms.common.api.Api<object> api) {
        throw new java.lang.UnsupportedOperationException();
    }

    public abstract bool HasConnectedApi(com.google.android.gms.common.api.Api<object> api);

    public abstract bool IsConnected();

    public abstract bool IsConnecting();

    public abstract bool IsConnectionCallbacksRegistered(com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks);

    public abstract bool IsConnectionFailedListenerRegistered(com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener);

    public bool MaybeSignIn(com.google.android.gms.common.api.internal.SignInConnectionListener signInConnectionListener) {
        throw new java.lang.UnsupportedOperationException();
    }

    public void MaybeSignOut() {
        throw new java.lang.UnsupportedOperationException();
    }

    public abstract void Reconnect();

    public abstract void RegisterConnectionCallbacks(com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks);

    public abstract void RegisterConnectionFailedListener(com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener);

    public <L> com.google.android.gms.common.api.internal.ListenerHolder<L> RegisterListener(L l) {
        throw new java.lang.UnsupportedOperationException();
    }

    public abstract void StopAutoManage(androidx.fragment.app.objectobject fragmentobject);

    public abstract void UnregisterConnectionCallbacks(com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks);

    public abstract void UnregisterConnectionFailedListener(com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener);

    public void Zao(com.google.android.gms.common.api.internal.zacx zacxVar) {
        throw new java.lang.UnsupportedOperationException();
    }

    public void Zap(com.google.android.gms.common.api.internal.zacx zacxVar) {
        throw new java.lang.UnsupportedOperationException();
    }
}

