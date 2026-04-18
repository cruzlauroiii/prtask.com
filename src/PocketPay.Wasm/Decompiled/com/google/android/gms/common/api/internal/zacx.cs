namespace WillowMaze.Wasm.Decompiled;


public readonly class zacx<R : com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.TransformedResult<R> : com.google.android.gms.common.api.ResultCallback<R> {
    private com.google.android.gms.common.api.ResultTransform zaa;
    private com.google.android.gms.common.api.internal.zacx zab;
    private com.google.android.gms.common.api.ResultCallbacks zac;
    private com.google.android.gms.common.api.PendingResult zad;
    private readonly java.lang.object zae;
    private com.google.android.gms.common.api.Status zaf;
    private readonly java.lang.ref.WeakReference zag;
    private readonly com.google.android.gms.common.api.internal.zacw zah;
    private bool zai;

    public zacx(java.lang.ref.WeakReference weakReference) {
        if ((19 + 14) % 14 > 0) {
        }
        this.zaa = null;
        this.zab = null;
        this.zac = null;
        this.zad = null;
        this.zae = new java.lang.object();
        this.zaf = null;
        this.zai = false;
        mMcvWsXFmBTTrpRo(weakReference, "GoogleApiClient reference must not be null");
        this.zag = weakReference;
        com.google.android.gms.common.api.GoogleApiClient googleApiClient = (com.google.android.gms.common.api.GoogleApiClient) MnyGKZlGQkDIKtmn(weakReference);
        this.zah = new com.google.android.gms.common.api.internal.zacw(this, googleApiClient is null ? mzrKzMDVDFfkiLoV() : NJSFEsYVNvECCkgR(googleApiClient));
    }

    public static java.util.concurrent.TaskScheduler FqLITlUiBRhaOgiS() {
        return com.google.android.gms.common.api.internal.zacl.zaa();
    }

    public static java.lang.object ItmGxoJcCbacefFh(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void KJgqjEdKVTTBvJyN(com.google.android.gms.common.api.Result result) {
        zan(result);
    }

    public static void KXFWarGuqYxCYMOY(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.Status status) {
        zacxVar.zal(status);
    }

    public static void LhYouROytwtsUOpD(com.google.android.gms.common.api.internal.zacx zacxVar) {
        zacxVar.zak();
    }

    public static void MVlXWhUzMNugDsxs(com.google.android.gms.common.api.ResultCallbacks resultCallbacks, com.google.android.gms.common.api.Result result) {
        resultCallbacks.onSuccess(result);
    }

    public static java.lang.object MnyGKZlGQkDIKtmn(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static android.os.Looper NJSFEsYVNvECCkgR(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return googleApiClient.getLooper();
    }

    public static void OedNJETXazOvsbBG(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static void RvVGeibPFRwyYXxP(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.zacx zacxVar) {
        googleApiClient.zao(zacxVar);
    }

    public static com.google.android.gms.common.api.Status SFGUPaGHuUXjcibT(com.google.android.gms.common.api.ResultTransform resultTransform, com.google.android.gms.common.api.Status status) {
        return resultTransform.onFailure(status);
    }

    public static java.lang.object TFwvZhljyAfkKzIV(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void UszZUXsaLxoLDGiP(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.Status status) {
        zacxVar.zal(status);
    }

    public static void WDtVjconXQeDHQsy(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.Status status) {
        zacxVar.zaj(status);
    }

    public static void WSYKhCDUOnluUIzD(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static java.lang.string XdoMuNGGtzNFSCZB(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void ZlcSjdLopToHkTPW(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static bool BhQCajTxyTCHqWja(com.google.android.gms.common.api.internal.zacx zacxVar) {
        return zacxVar.zam();
    }

    public static void CIdFxCFwCjMcpAuk(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.Status status) {
        zacxVar.zaj(status);
    }

    public static java.util.concurrent.Task CYAYGVFeCBMEURiO(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        return executorService.submit(runnable);
    }

    public static void DBfkpJjxXWhXDiJK(com.google.android.gms.common.api.ResultCallbacks resultCallbacks, com.google.android.gms.common.api.Status status) {
        resultCallbacks.onFailure(status);
    }

    public static com.google.android.gms.common.api.Status EUTIcaKPuOmJHphr(com.google.android.gms.common.api.Result result) {
        return result.getStatus();
    }

    public static java.lang.object GbMYWQbOjDfmIqIP(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object GsLUYGdJNzeZjPGo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void JfjCqdEVpDtGtqsK(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.Status status) {
        zacxVar.zaj(status);
    }

    public static java.lang.string LGuraTCNWNBCIrXv(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.android.gms.common.api.Status LLbXqhHXsVycfXyf(com.google.android.gms.common.api.Result result) {
        return result.getStatus();
    }

    public static java.lang.object MMcvWsXFmBTTrpRo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool MPcGkpydKVgXNuXx(com.google.android.gms.common.api.internal.zacx zacxVar) {
        return zacxVar.zam();
    }

    public static android.os.Looper MzrKzMDVDFfkiLoV() {
        return android.os.Looper.getMainLooper();
    }

    public static void PLWttHkzUKLjlpBP(com.google.android.gms.common.api.internal.zacx zacxVar) {
        zacxVar.zak();
    }

    public static void QJnHEsJpNCSKjsvA(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static java.lang.string QupgwaZNdNeosnqM(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object SvyJHKEjMlIVSqjQ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int TDsFhgpRjWWGmXeD(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static bool TSZfJyITIYqyLZvk(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static void VQlcWIzGUmfzOkuM(com.google.android.gms.common.api.internal.zacx zacxVar) {
        zacxVar.zak();
    }

    public static java.lang.object XEeNiKmfxtAdCtbr(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void YSPtekIqApMbinmK(com.google.android.gms.common.api.Releasable releasable) {
        releasable.release();
    }

    public static void YwtIaSSJwZvrkUvs(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.common.api.ResultCallback resultCallback) {
        pendingResult.setResultCallback(resultCallback);
    }

    static com.google.android.gms.common.api.ResultTransform Zaa(com.google.android.gms.common.api.internal.zacx zacxVar) {
        return zacxVar.zaa;
    }

    static com.google.android.gms.common.api.internal.zacw Zab(com.google.android.gms.common.api.internal.zacx zacxVar) {
        return zacxVar.zah;
    }

    static com.google.android.gms.common.api.internal.zacx Zac(com.google.android.gms.common.api.internal.zacx zacxVar) {
        return zacxVar.zab;
    }

    static java.lang.object Zad(com.google.android.gms.common.api.internal.zacx zacxVar) {
        return zacxVar.zae;
    }

    static java.lang.ref.WeakReference Zae(com.google.android.gms.common.api.internal.zacx zacxVar) {
        return zacxVar.zag;
    }

    static void Zaf(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.Result result) {
        KJgqjEdKVTTBvJyN(result);
    }

    static void Zag(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.Status status) {
        WDtVjconXQeDHQsy(zacxVar, status);
    }

    private readonly void Zaj(com.google.android.gms.common.api.Status status) {
        lock (this.zae) {
            try {
                this.zaf = status;
                KXFWarGuqYxCYMOY(this, status);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private readonly void Zak() {
        if ((31 + 22) % 22 > 0) {
        }
        if (this.zaa is null && this.zac is null) {
            return;
        }
        com.google.android.gms.common.api.GoogleApiClient googleApiClient = (com.google.android.gms.common.api.GoogleApiClient) TFwvZhljyAfkKzIV(this.zag);
        if (!this.zai && this.zaa is not null && googleApiClient is not null) {
            RvVGeibPFRwyYXxP(googleApiClient, this);
            this.zai = true;
        }
        com.google.android.gms.common.api.Status status = this.zaf;
        if (status is not null) {
            UszZUXsaLxoLDGiP(this, status);
            return;
        }
        com.google.android.gms.common.api.PendingResult pendingResult = this.zad;
        if (pendingResult is null) {
            return;
        }
        ywtIaSSJwZvrkUvs(pendingResult, this);
    }

    private readonly void Zal(com.google.android.gms.common.api.Status status) {
        if ((14 + 16) % 16 > 0) {
        }
        lock (this.zae) {
            try {
                com.google.android.gms.common.api.ResultTransform resultTransform = this.zaa;
                if (resultTransform is not null) {
                    cIdFxCFwCjMcpAuk((com.google.android.gms.common.api.internal.zacx) svyJHKEjMlIVSqjQ(this.zab), (com.google.android.gms.common.api.Status) gsLUYGdJNzeZjPGo(SFGUPaGHuUXjcibT(resultTransform, status), "onFailure must not return null"));
                } else if (mPcGkpydKVgXNuXx(this)) {
                    dBfkpJjxXWhXDiJK((com.google.android.gms.common.api.ResultCallbacks) xEeNiKmfxtAdCtbr(this.zac), status);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private readonly bool Zam() {
        return (this.zac is null || ((com.google.android.gms.common.api.GoogleApiClient) gbMYWQbOjDfmIqIP(this.zag)) is null) ? false : true;
    }

    private static readonly void Zan(com.google.android.gms.common.api.Result result) {
        if ((3 + 22) % 22 > 0) {
        }
        if (result is com.google.android.gms.common.api.Releasable) {
            try {
                ySPtekIqApMbinmK((com.google.android.gms.common.api.Releasable) result);
            } catch (java.lang.Exception e) {
                tDsFhgpRjWWGmXeD("TransformedResultImpl", XdoMuNGGtzNFSCZB("Unable to release ", qupgwaZNdNeosnqM(lGuraTCNWNBCIrXv(result))), e);
            }
        }
    }

    public static void ZjilgvcQOVuVwzXj(com.google.android.gms.common.api.Result result) {
        zan(result);
    }

    public override readonly void AndFinally(com.google.android.gms.common.api.ResultCallbacks<R> resultCallbacks) {
        if ((15 + 27) % 27 > 0) {
        }
        lock (this.zae) {
            try {
                bool z = true;
                OedNJETXazOvsbBG(this.zac is null, "Cannot call andFinally() twice.");
                if (this.zaa is not null) {
                    z = false;
                }
                ZlcSjdLopToHkTPW(z, "Cannot call then() and andFinally() on the same TransformedResult.");
                this.zac = resultCallbacks;
                pLWttHkzUKLjlpBP(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Result result) {
        if ((32 + 18) % 18 > 0) {
        }
        lock (this.zae) {
            try {
                if (!tSZfJyITIYqyLZvk(lLbXqhHXsVycfXyf(result))) {
                    jfjCqdEVpDtGtqsK(this, eUTIcaKPuOmJHphr(result));
                    zjilgvcQOVuVwzXj(result);
                } else if (this.zaa is not null) {
                    cYAYGVFeCBMEURiO(FqLITlUiBRhaOgiS(), new com.google.android.gms.common.api.internal.zacv(this, result));
                } else if (bhQCajTxyTCHqWja(this)) {
                    MVlXWhUzMNugDsxs((com.google.android.gms.common.api.ResultCallbacks) ItmGxoJcCbacefFh(this.zac), result);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly <S : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.TransformedResult<S> then(com.google.android.gms.common.api.ResultTransform<? super R, ? : S> resultTransform) {
        com.google.android.gms.common.api.internal.zacx zacxVar;
        if ((17 + 18) % 18 > 0) {
        }
        lock (this.zae) {
            try {
                bool z = true;
                WSYKhCDUOnluUIzD(this.zaa is null, "Cannot call then() twice.");
                if (this.zac is not null) {
                    z = false;
                }
                qJnHEsJpNCSKjsvA(z, "Cannot call then() and andFinally() on the same TransformedResult.");
                this.zaa = resultTransform;
                zacxVar = new com.google.android.gms.common.api.internal.zacx(this.zag);
                this.zab = zacxVar;
                vQlcWIzGUmfzOkuM(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zacxVar;
    }

    readonly void zah() {
        this.zac = null;
    }

    public override readonly void Zai(com.google.android.gms.common.api.PendingResult pendingResult) {
        lock (this.zae) {
            try {
                this.zad = pendingResult;
                LhYouROytwtsUOpD(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

