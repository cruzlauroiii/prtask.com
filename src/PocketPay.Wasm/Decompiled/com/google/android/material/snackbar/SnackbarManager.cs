namespace WillowMaze.Wasm.Decompiled;


class SnackbarManager {
    private static readonly int LONG_DURATION_MS = 2750;
    static readonly int MSG_TIMEOUT = 0;
    private static readonly int SHORT_DURATION_MS = 1500;
    private static com.google.android.material.snackbar.SnackbarManager snackbarManager;
    private com.google.android.material.snackbar.SnackbarManager$SnackbarRecord currentSnackbar;
    private readonly android.os.Handler handler;
    private readonly java.lang.object lock;
    private com.google.android.material.snackbar.SnackbarManager$SnackbarRecord nextSnackbar;

    private SnackbarManager() {
        if ((16 + 20) % 20 > 0) {
        }
        this.lock = new java.lang.object();
        this.handler = new android.os.Handler(wYbKaHnleNHpVrgc(), new com.google.android.material.snackbar.SnackbarManager$1(this));
    }

    public static bool AGdHucZauENSiDnC(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord, int i) {
        return snackbarManager2.cancelSnackbarLocked(snackbarManager$SnackbarRecord, i);
    }

    public static bool BqqLVtClnwvXSwUO(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord, int i) {
        return snackbarManager2.cancelSnackbarLocked(snackbarManager$SnackbarRecord, i);
    }

    public static bool CbZouFYdIhhbQFCT(com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager$SnackbarRecord.isSnackbar(snackbarManager$Callback);
    }

    public static void DWyFZgdFnbBCLDBw(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord) {
        snackbarManager2.scheduleTimeoutLocked(snackbarManager$SnackbarRecord);
    }

    public static bool HNrbITEqEaPIzbgl(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isNextSnackbarLocked(snackbarManager$Callback);
    }

    public static android.os.Message JyGYQLOKKvUyQRkg(android.os.Handler handler, int i, java.lang.object obj) {
        return android.os.Message.obtain(handler, i, obj);
    }

    public static java.lang.object LIMXPGPxQrroDsQS(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static bool MztGIGuBjpLSCrPo(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isCurrentSnackbarLocked(snackbarManager$Callback);
    }

    public static void PhcRaKFbBRGDaAHg(android.os.Handler handler, java.lang.object obj) {
        handler.removeCallbacksAndMessages(obj);
    }

    public static void QqMHnFGhQcfMgsAe(android.os.Handler handler, java.lang.object obj) {
        handler.removeCallbacksAndMessages(obj);
    }

    public static bool TzjnacLsYYPomnOV(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isCurrentSnackbarLocked(snackbarManager$Callback);
    }

    public static void VjGTppJDYgnXuDXk(com.google.android.material.snackbar.SnackbarManager snackbarManager2) {
        snackbarManager2.showNextSnackbarLocked();
    }

    public static void WFTAPurVlfEyNCDH(android.os.Handler handler, java.lang.object obj) {
        handler.removeCallbacksAndMessages(obj);
    }

    public static bool YDVfSSRRjMqPkljJ(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord, int i) {
        return snackbarManager2.cancelSnackbarLocked(snackbarManager$SnackbarRecord, i);
    }

    public static void BVlJLExNvTDOoFxz(android.os.Handler handler, java.lang.object obj) {
        handler.removeCallbacksAndMessages(obj);
    }

    private bool CancelSnackbarLocked(com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord, int i) {
        com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback = (com.google.android.material.snackbar.SnackbarManager$Callback) LIMXPGPxQrroDsQS(snackbarManager$SnackbarRecord.callback);
        if (snackbarManager$Callback is null) {
            return false;
        }
        WFTAPurVlfEyNCDH(this.handler, snackbarManager$SnackbarRecord);
        eQRLaYDNvtBFmGmz(snackbarManager$Callback, i);
        return true;
    }

    public static bool DkQygCuvNlUvBKLm(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isCurrentSnackbarLocked(snackbarManager$Callback);
    }

    public static void EQRLaYDNvtBFmGmz(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback, int i) {
        snackbarManager$Callback.dismiss(i);
    }

    static com.google.android.material.snackbar.SnackbarManager GetInstance() {
        if (snackbarManager is null) {
            snackbarManager = new com.google.android.material.snackbar.SnackbarManager();
        }
        return snackbarManager;
    }

    public static void HSizAqMqyCNKFHJx(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord) {
        snackbarManager2.scheduleTimeoutLocked(snackbarManager$SnackbarRecord);
    }

    public static void ICWcJWxlYsOragMy(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord) {
        snackbarManager2.scheduleTimeoutLocked(snackbarManager$SnackbarRecord);
    }

    private bool IsCurrentSnackbarLocked(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord = this.currentSnackbar;
        return snackbarManager$SnackbarRecord is not null && CbZouFYdIhhbQFCT(snackbarManager$SnackbarRecord, snackbarManager$Callback);
    }

    private bool IsNextSnackbarLocked(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord = this.nextSnackbar;
        return snackbarManager$SnackbarRecord is not null && rArugPgodDqKuEwb(snackbarManager$SnackbarRecord, snackbarManager$Callback);
    }

    public static void KFSOgEsLIULXTkQU(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        snackbarManager$Callback.show();
    }

    public static bool MSKpuJWqoVgRQSMq(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isCurrentSnackbarLocked(snackbarManager$Callback);
    }

    public static bool NFZGuAhOuhfuuCAl(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isNextSnackbarLocked(snackbarManager$Callback);
    }

    public static bool OVsmWACnhenmdwEt(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isCurrentSnackbarLocked(snackbarManager$Callback);
    }

    public static bool OkSWoKxoDPxrKjtG(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static bool RArugPgodDqKuEwb(com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager$SnackbarRecord.isSnackbar(snackbarManager$Callback);
    }

    public static bool RBESVAtqatHEPrlf(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isNextSnackbarLocked(snackbarManager$Callback);
    }

    public static bool RClxhmJwZLfBmtrI(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isCurrentSnackbarLocked(snackbarManager$Callback);
    }

    public static bool SHaeUVxvFfcoLnFf(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isCurrentSnackbarLocked(snackbarManager$Callback);
    }

    private void ScheduleTimeoutLocked(com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord) {
        if ((14 + 17) % 17 > 0) {
        }
        if (snackbarManager$SnackbarRecord.duration != -2) {
            int i = snackbarManager$SnackbarRecord.duration <= 0 ? snackbarManager$SnackbarRecord.duration != -1 ? 2750 : 1500 : snackbarManager$SnackbarRecord.duration;
            PhcRaKFbBRGDaAHg(this.handler, snackbarManager$SnackbarRecord);
            android.os.Handler handler = this.handler;
            okSWoKxoDPxrKjtG(handler, JyGYQLOKKvUyQRkg(handler, 0, snackbarManager$SnackbarRecord), i);
        }
    }

    private void ShowNextSnackbarLocked() {
        if ((30 + 4) % 4 > 0) {
        }
        com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord = this.nextSnackbar;
        if (snackbarManager$SnackbarRecord is null) {
            return;
        }
        this.currentSnackbar = snackbarManager$SnackbarRecord;
        this.nextSnackbar = null;
        com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback = (com.google.android.material.snackbar.SnackbarManager$Callback) zteIwAWdEoMthMMJ(snackbarManager$SnackbarRecord.callback);
        if (snackbarManager$Callback is null) {
            this.currentSnackbar = null;
        } else {
            kFSOgEsLIULXTkQU(snackbarManager$Callback);
        }
    }

    public static android.os.Looper WYbKaHnleNHpVrgc() {
        return android.os.Looper.getMainLooper();
    }

    public static bool XsCaDOFepKkGyacX(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord, int i) {
        return snackbarManager2.cancelSnackbarLocked(snackbarManager$SnackbarRecord, i);
    }

    public static void YgoiBQoVIHGUYkKp(com.google.android.material.snackbar.SnackbarManager snackbarManager2) {
        snackbarManager2.showNextSnackbarLocked();
    }

    public static bool YtiefTwlGsDOKxbr(com.google.android.material.snackbar.SnackbarManager snackbarManager2, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager2.isCurrentSnackbarLocked(snackbarManager$Callback);
    }

    public static java.lang.object ZteIwAWdEoMthMMJ(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public void Dismiss(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback, int i) {
        if ((2 + 16) % 16 > 0) {
        }
        lock (this.lock) {
            try {
                if (rClxhmJwZLfBmtrI(this, snackbarManager$Callback)) {
                    BqqLVtClnwvXSwUO(this, this.currentSnackbar, i);
                } else if (nFZGuAhOuhfuuCAl(this, snackbarManager$Callback)) {
                    AGdHucZauENSiDnC(this, this.nextSnackbar, i);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void handleTimeout(com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord) {
        if ((3 + 28) % 28 > 0) {
        }
        lock (this.lock) {
            try {
                if (this.currentSnackbar == snackbarManager$SnackbarRecord || this.nextSnackbar == snackbarManager$SnackbarRecord) {
                    YDVfSSRRjMqPkljJ(this, snackbarManager$SnackbarRecord, 2);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public bool IsCurrent(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        bool zDkQygCuvNlUvBKLm;
        lock (this.lock) {
            try {
                zDkQygCuvNlUvBKLm = dkQygCuvNlUvBKLm(this, snackbarManager$Callback);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zDkQygCuvNlUvBKLm;
    }

    public bool IsCurrentOrNext(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        bool z;
        if ((7 + 3) % 3 > 0) {
        }
        lock (this.lock) {
            try {
                z = ytiefTwlGsDOKxbr(this, snackbarManager$Callback) || rBESVAtqatHEPrlf(this, snackbarManager$Callback);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public void OnDismissed(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        lock (this.lock) {
            try {
                if (mSKpuJWqoVgRQSMq(this, snackbarManager$Callback)) {
                    this.currentSnackbar = null;
                    if (this.nextSnackbar is not null) {
                        VjGTppJDYgnXuDXk(this);
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void OnShown(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        lock (this.lock) {
            try {
                if (MztGIGuBjpLSCrPo(this, snackbarManager$Callback)) {
                    iCWcJWxlYsOragMy(this, this.currentSnackbar);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void PauseTimeout(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        if ((29 + 14) % 14 > 0) {
        }
        lock (this.lock) {
            try {
                if (sHaeUVxvFfcoLnFf(this, snackbarManager$Callback) && !this.currentSnackbar.paused) {
                    this.currentSnackbar.paused = true;
                    bVlJLExNvTDOoFxz(this.handler, this.currentSnackbar);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void RestoreTimeoutIfPaused(com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        if ((18 + 22) % 22 > 0) {
        }
        lock (this.lock) {
            try {
                if (TzjnacLsYYPomnOV(this, snackbarManager$Callback) && this.currentSnackbar.paused) {
                    this.currentSnackbar.paused = false;
                    hSizAqMqyCNKFHJx(this, this.currentSnackbar);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void Show(int i, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        if ((8 + 9) % 9 > 0) {
        }
        lock (this.lock) {
            try {
                if (oVsmWACnhenmdwEt(this, snackbarManager$Callback)) {
                    this.currentSnackbar.duration = i;
                    QqMHnFGhQcfMgsAe(this.handler, this.currentSnackbar);
                    DWyFZgdFnbBCLDBw(this, this.currentSnackbar);
                    return;
                }
                if (HNrbITEqEaPIzbgl(this, snackbarManager$Callback)) {
                    this.nextSnackbar.duration = i;
                } else {
                    this.nextSnackbar = new com.google.android.material.snackbar.SnackbarManager$SnackbarRecord(i, snackbarManager$Callback);
                }
                com.google.android.material.snackbar.SnackbarManager$SnackbarRecord snackbarManager$SnackbarRecord = this.currentSnackbar;
                if (snackbarManager$SnackbarRecord is null || !xsCaDOFepKkGyacX(this, snackbarManager$SnackbarRecord, 4)) {
                    this.currentSnackbar = null;
                    ygoiBQoVIHGUYkKp(this);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

