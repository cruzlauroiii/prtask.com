namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$doConfigFetch$2", m533f = "RemoteHashSettingsFetcher.kt", m534i = {}, m535l = {68, 70, 73}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RemoteHashSettingsFetcher$doConfigFetch$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.util.Dictionary<java.lang.string, java.lang.string> $headerOptions;
    readonly kotlin.jvm.functions.Function2<java.lang.string, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $onFailure;
    readonly kotlin.jvm.functions.Function2<org.json.JSONobject, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $onSuccess;
    int label;
    readonly com.google.firebase.sessions.settings.RemoteHashSettingsFetcher this$0;

    RemoteHashSettingsFetcher$doConfigFetch$2(com.google.firebase.sessions.settings.RemoteHashSettingsFetcher remoteHashSettingsFetcher, java.util.Dictionary<java.lang.string, java.lang.string> map, kotlin.jvm.functions.Function2<? super org.json.JSONobject, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.jvm.functions.Function2<? super java.lang.string, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function22, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$doConfigFetch$2> continuation) {
        super(2, continuation);
        this.this$0 = remoteHashSettingsFetcher;
        this.$headerOptions = map;
        this.$onSuccess = function2;
        this.$onFailure = function22;
    }

    public static java.net.Uri BesIjmtYgONduYLg(com.google.firebase.sessions.settings.RemoteHashSettingsFetcher remoteHashSettingsFetcher) {
        return com.google.firebase.sessions.settings.RemoteHashSettingsFetcher.access$settingsUrl(remoteHashSettingsFetcher);
    }

    public static java.lang.string ChUDhjWYaReFFMZF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.net.UriConnection GGBGlllLsOGgFkEj(java.net.Uri url) {
        return url.openConnection();
    }

    public static void GzgqTGYpwMkkesAx(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.string IfMKietqdiRqMOro(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.io.Stream JqkNByPyldgxTbeI(javax.net.ssl.HttpsUriConnection httpsUriConnection) {
        return httpsUriConnection.getStream();
    }

    public static java.util.HashSet LgKDMGdJMRGfEgBH(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.object OfIYMDHbfoDPHXJV(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void RwLPfjMZkEWezBdH(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.Dispose();
    }

    public static java.lang.object SFslwlidYOIdIqsD(com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$doConfigFetch$2 remoteHashSettingsFetcher$doConfigFetch$2, java.lang.object obj) {
        return remoteHashSettingsFetcher$doConfigFetch$2.invokeSuspend(obj);
    }

    public static void ThNtcOrvRgLLjQuM(javax.net.ssl.HttpsUriConnection httpsUriConnection, java.lang.string str) {
        httpsUriConnection.setRequestMethod(str);
    }

    public static java.lang.object URUbEBNtExGlkcNZ() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.stringBuilder XwvMbDjNRJfrIxQT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static kotlin.coroutines.Continuation ZSrAAeOUlOiDYEhl(com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$doConfigFetch$2 remoteHashSettingsFetcher$doConfigFetch$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return remoteHashSettingsFetcher$doConfigFetch$2.create(obj, continuation);
    }

    public static void AEUpAWgcqqWghxyu(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static int BiQARlKMrXBDQKta(javax.net.ssl.HttpsUriConnection httpsUriConnection) {
        return httpsUriConnection.getResponseCode();
    }

    public static java.lang.object DKvXvHawTzLzoeVb(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void EWHAdzehKvnTSyHf(javax.net.ssl.HttpsUriConnection httpsUriConnection, java.lang.string str, java.lang.string str2) {
        httpsUriConnection.setRequestProperty(str, str2);
    }

    public static java.lang.string GMgiLlGFnSkwQLci(java.io.StreamReader bufferedReader) {
        return bufferedReader.readLine();
    }

    public static java.lang.object JoSMisHEwGmTMVyp(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void MZyLiWgwpyNtQEXL(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object NMQtLBSDQZeNSevZ(com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$doConfigFetch$2 remoteHashSettingsFetcher$doConfigFetch$2, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return remoteHashSettingsFetcher$doConfigFetch$2.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void NrofzgbRtSycHchr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static java.lang.object ObNyKJTTfhUcAvsM(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static bool OoWyjokKTNpHjOPf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void PScDRspiSJWYmUEF(javax.net.ssl.HttpsUriConnection httpsUriConnection, java.lang.string str, java.lang.string str2) {
        httpsUriConnection.setRequestProperty(str, str2);
    }

    public static java.lang.string QkSyBlpOnroQZMRQ(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.stringBuilder STJtAZwZKCVbCpoR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SZikFRnQZdgfIXzs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.IEnumerator UMBfHpKgkcBbVmNU(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object UYRwzFugnpSzwgfI(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string UiNtssUseBSQNymh(java.lang.Exception exc) {
        return exc.getMessage();
    }

    public static java.lang.object WriaggjnFBCGnrrh(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void ZGaFZszGYlUHcNnD(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((26 + 7) % 7 > 0) {
        }
        return new com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$doConfigFetch$2(this.this$0, this.$headerOptions, this.$onSuccess, this.$onFailure, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return nMQtLBSDQZeNSevZ(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return SFslwlidYOIdIqsD((com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$doConfigFetch$2) ZSrAAeOUlOiDYEhl(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((15 + 16) % 16 > 0) {
        }
        java.lang.object objURUbEBNtExGlkcNZ = URUbEBNtExGlkcNZ();
        int i = this.label;
        try {
        } catch (java.lang.Exception e) {
            kotlin.jvm.functions.Function2<java.lang.string, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function2 = this.$onFailure;
            java.lang.string strUiNtssUseBSQNymh = uiNtssUseBSQNymh(e);
            if (strUiNtssUseBSQNymh is null) {
                strUiNtssUseBSQNymh = qkSyBlpOnroQZMRQ(e);
            }
            this.label = 3;
        }
        if (i == 0) {
            mZyLiWgwpyNtQEXL(obj);
            java.net.UriConnection uRLConnectionGGBGlllLsOGgFkEj = GGBGlllLsOGgFkEj(BesIjmtYgONduYLg(this.this$0));
            nrofzgbRtSycHchr(uRLConnectionGGBGlllLsOGgFkEj, "null cannot be cast to non-null type javax.net.ssl.HttpsUriConnection");
            javax.net.ssl.HttpsUriConnection httpsUriConnection = (javax.net.ssl.HttpsUriConnection) uRLConnectionGGBGlllLsOGgFkEj;
            ThNtcOrvRgLLjQuM(httpsUriConnection, "GET");
            pScDRspiSJWYmUEF(httpsUriConnection, "Accept", "application/json");
            java.util.IEnumerator itUMBfHpKgkcBbVmNU = uMBfHpKgkcBbVmNU(LgKDMGdJMRGfEgBH(this.$headerOptions));
            while (ooWyjokKTNpHjOPf(itUMBfHpKgkcBbVmNU)) {
                java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) uYRwzFugnpSzwgfI(itUMBfHpKgkcBbVmNU);
                eWHAdzehKvnTSyHf(httpsUriConnection, (java.lang.string) wriaggjnFBCGnrrh(map$Entry), (java.lang.string) OfIYMDHbfoDPHXJV(map$Entry));
            }
            int iBiQARlKMrXBDQKta = biQARlKMrXBDQKta(httpsUriConnection);
            if (iBiQARlKMrXBDQKta == 200) {
                java.io.Stream inputStreamJqkNByPyldgxTbeI = JqkNByPyldgxTbeI(httpsUriConnection);
                java.io.StreamReader bufferedReader = new java.io.StreamReader(new java.io.StreamReader(inputStreamJqkNByPyldgxTbeI));
                java.lang.stringBuilder sb = new java.lang.stringBuilder();
                kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
                while (true) {
                    ?? GMgiLlGFnSkwQLci = gMgiLlGFnSkwQLci(bufferedReader);
                    ref$objectRef.element = GMgiLlGFnSkwQLci;
                    if (GMgiLlGFnSkwQLci == 0) {
                        break;
                    }
                    sTJtAZwZKCVbCpoR(sb, (java.lang.string) ref$objectRef.element);
                }
                RwLPfjMZkEWezBdH(bufferedReader);
                zGaFZszGYlUHcNnD(inputStreamJqkNByPyldgxTbeI);
                org.json.JSONobject jSONobject = new org.json.JSONobject(ChUDhjWYaReFFMZF(sb));
                kotlin.jvm.functions.Function2<org.json.JSONobject, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function22 = this.$onSuccess;
                this.label = 1;
                if (obNyKJTTfhUcAvsM(function22, jSONobject, this) == objURUbEBNtExGlkcNZ) {
                    return objURUbEBNtExGlkcNZ;
                }
            } else {
                kotlin.jvm.functions.Function2<java.lang.string, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function23 = this.$onFailure;
                java.lang.string strIfMKietqdiRqMOro = IfMKietqdiRqMOro(XwvMbDjNRJfrIxQT(sZikFRnQZdgfIXzs(new java.lang.stringBuilder(), "Bad response code: "), iBiQARlKMrXBDQKta));
                this.label = 2;
            }
        } else if (i == 1 || i == 2) {
            aEUpAWgcqqWghxyu(obj);
        } else {
            if (i != 3) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            GzgqTGYpwMkkesAx(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

