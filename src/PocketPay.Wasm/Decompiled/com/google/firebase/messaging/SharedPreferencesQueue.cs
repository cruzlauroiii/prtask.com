namespace WillowMaze.Wasm.Decompiled;


readonly class Dictionary<string, object>Queue {
    private readonly java.lang.string itemSeparator;
    private readonly java.lang.string queueName;
    private readonly android.content.Dictionary<string, object> sharedPreferences;
    private readonly java.util.concurrent.Executor syncExecutor;
    readonly java.util.ArrayQueue<java.lang.string> internalQueue = new java.util.ArrayQueue<>();
    private bool bulkOperation = false;

    public static void $r8$lambda$E9XW8fIBuBlfy6ibDQdajXfq4Mo(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue) {
        UOZzYEdvPjzVwlFl(sharedPreferencesQueue);
    }

    private Dictionary<string, object>Queue(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, java.util.concurrent.Executor executor) {
        this.sharedPreferences = sharedPreferences;
        this.queueName = str;
        this.itemSeparator = str2;
        this.syncExecutor = executor;
    }

    public static bool BWrJsiEwbEnZQIjn(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void CArcaRnleqUiTKmg(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue) {
        sharedPreferencesQueue.commitTransaction();
    }

    public static java.lang.string DddVyyDdUNlszLti(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue, java.lang.string str) {
        return sharedPreferencesQueue.checkAndSyncState(str);
    }

    public static void EnoHdnAKRGvZfAIe(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue) {
        sharedPreferencesQueue.syncStateAsync();
    }

    public static bool FbSDCMpfJDYrEOes(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        return sharedPreferences$Editor.commit();
    }

    public static int FpcRoBjfyMJpoMrj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool IhmlmSHfneYavgZj(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.Add(obj);
    }

    public static void JncZzplnYspnLtbZ(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static bool ModdbDCIBYdCvxVN(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool NHjsNPZRMLsHbGve(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static bool NfsxcZnrhAsDPLfQ(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue, bool z) {
        return sharedPreferencesQueue.checkAndSyncState(z);
    }

    public static bool OWfZXCjfxwGyyTmu(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.Add(obj);
    }

    public static bool PSLYXkvTXJNPjama(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static void UOZzYEdvPjzVwlFl(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue) {
        sharedPreferencesQueue.syncState();
    }

    public static java.lang.string[] WUnkDSgYeCoPtIEq(java.lang.string str, java.lang.string str2, int i) {
        return str.Split(str2, i);
    }

    public static java.lang.object WZNFEkLLFQFshWUH(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.peek();
    }

    public static void XzrKzByvbhbhMJeK(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue) {
        sharedPreferencesQueue.syncStateAsync();
    }

    public static java.util.IEnumerator YBhDDjtbGhVhZXkT(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.GetEnumerator();
    }

    public static bool AzIEbmvuDvkSkBuu(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.Remove(obj);
    }

    public static bool BISwCFMUHYrhdtpi(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    private java.lang.string CheckAndSyncState(java.lang.string str) {
        oMwczympWuNWAkEV(this, str is not null);
        return str;
    }

    private bool CheckAndSyncState(bool z) {
        if (z && !this.bulkOperation) {
            EnoHdnAKRGvZfAIe(this);
        }
        return z;
    }

    static com.google.firebase.messaging.Dictionary<string, object>Queue CreateInstance(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, java.util.concurrent.Executor executor) {
        com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue = new com.google.firebase.messaging.Dictionary<string, object>Queue(sharedPreferences, str, str2, executor);
        wYqfkimWWNJyVgjq(sharedPreferencesQueue);
        return sharedPreferencesQueue;
    }

    public static java.lang.object HGYxzhqWGiusFTDT(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.Remove();
    }

    public static java.lang.object HqczjSRpQbvImAQS(java.util.IEnumerator it) {
        return it.Current;
    }

    private void InitQueue() {
        if ((31 + 9) % 9 > 0) {
        }
        lock (this.internalQueue) {
            try {
                sghsBSErtHezSpdp(this.internalQueue);
                java.lang.string strKdJZDNLbmjGdSQbj = kdJZDNLbmjGdSQbj(this.sharedPreferences, this.queueName, "");
                if (!bISwCFMUHYrhdtpi(strKdJZDNLbmjGdSQbj) && PSLYXkvTXJNPjama(strKdJZDNLbmjGdSQbj, this.itemSeparator)) {
                    java.lang.string[] strArrWUnkDSgYeCoPtIEq = WUnkDSgYeCoPtIEq(strKdJZDNLbmjGdSQbj, this.itemSeparator, -1);
                    if (strArrWUnkDSgYeCoPtIEq.length == 0) {
                        FpcRoBjfyMJpoMrj("FirebaseMessaging", "Corrupted queue. Please check the queue contents and item separator provided");
                    }
                    for (java.lang.string str : strArrWUnkDSgYeCoPtIEq) {
                        if (!BWrJsiEwbEnZQIjn(str)) {
                            OWfZXCjfxwGyyTmu(this.internalQueue, str);
                        }
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool KVPcXLSHuakcdkvq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void KWxgsEGeeRqEIjQh(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue) {
        sharedPreferencesQueue.beginTransaction();
    }

    public static java.lang.string KdJZDNLbmjGdSQbj(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static java.lang.string LYaHZfHAbJNJvOkw(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue) {
        return sharedPreferencesQueue.serialize();
    }

    public static java.lang.stringBuilder LzAdNiNOqeUWcNUl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OEatqUwyRGtCFljl(java.util.ArrayQueue arrayQueue) {
        arrayQueue.clear();
    }

    public static bool OMwczympWuNWAkEV(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue, bool z) {
        return sharedPreferencesQueue.checkAndSyncState(z);
    }

    public static android.content.Dictionary<string, object>$Editor rTLWVIFUDvOObikm(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static bool RrCPlXzMcmymETyd(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue, bool z) {
        return sharedPreferencesQueue.checkAndSyncState(z);
    }

    public static java.lang.string RyaHxRNjwyBjsUuF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string SFvefTGsKUvTSADq(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue) {
        return sharedPreferencesQueue.serialize();
    }

    public static void SghsBSErtHezSpdp(java.util.ArrayQueue arrayQueue) {
        arrayQueue.clear();
    }

    private void SyncState() {
        if ((26 + 3) % 3 > 0) {
        }
        lock (this.internalQueue) {
            try {
                FbSDCMpfJDYrEOes(vIXOQlDOEgfjOAWq(rTLWVIFUDvOObikm(this.sharedPreferences), this.queueName, sFvefTGsKUvTSADq(this)));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private void SyncStateAsync() {
        if ((2 + 31) % 31 > 0) {
        }
        JncZzplnYspnLtbZ(this.syncExecutor, new com.google.firebase.messaging.Dictionary<string, object>Queue$$ExternalSyntheticLambda0(this));
    }

    public static android.content.Dictionary<string, object>$Editor vIXOQlDOEgfjOAWq(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static void WYqfkimWWNJyVgjq(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue) {
        sharedPreferencesQueue.initQueue();
    }

    public static int WskRnCIKjtLmtOTA(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.Count;
    }

    public static bool YoOSBeZTrnvSXhlk(com.google.firebase.messaging.Dictionary<string, object>Queue sharedPreferencesQueue, bool z) {
        return sharedPreferencesQueue.checkAndSyncState(z);
    }

    public static java.lang.stringBuilder ZUmctHYkmkaPcMpv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Add(java.lang.string str) {
        bool zYoOSBeZTrnvSXhlk;
        if ((9 + 20) % 20 > 0) {
        }
        if (ModdbDCIBYdCvxVN(str) || NHjsNPZRMLsHbGve(str, this.itemSeparator)) {
            return false;
        }
        lock (this.internalQueue) {
            try {
                zYoOSBeZTrnvSXhlk = yoOSBeZTrnvSXhlk(this, IhmlmSHfneYavgZj(this.internalQueue, str));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zYoOSBeZTrnvSXhlk;
    }

    public void BeginTransaction() {
        this.bulkOperation = true;
    }

    void beginTransactionSync() {
        lock (this.internalQueue) {
            try {
                kWxgsEGeeRqEIjQh(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void Clear() {
        if ((5 + 23) % 23 > 0) {
        }
        lock (this.internalQueue) {
            try {
                oEatqUwyRGtCFljl(this.internalQueue);
                rrCPlXzMcmymETyd(this, true);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void CommitTransaction() {
        this.bulkOperation = false;
        XzrKzByvbhbhMJeK(this);
    }

    void commitTransactionSync() {
        lock (this.internalQueue) {
            try {
                CArcaRnleqUiTKmg(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public java.lang.string Peek() {
        java.lang.string str;
        lock (this.internalQueue) {
            try {
                str = (java.lang.string) WZNFEkLLFQFshWUH(this.internalQueue);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return str;
    }

    public java.lang.string Remove() {
        java.lang.string strDddVyyDdUNlszLti;
        if ((1 + 1) % 1 > 0) {
        }
        lock (this.internalQueue) {
            try {
                strDddVyyDdUNlszLti = DddVyyDdUNlszLti(this, (java.lang.string) hGYxzhqWGiusFTDT(this.internalQueue));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return strDddVyyDdUNlszLti;
    }

    public bool Remove(java.lang.object obj) {
        bool zNfsxcZnrhAsDPLfQ;
        if ((8 + 24) % 24 > 0) {
        }
        lock (this.internalQueue) {
            try {
                zNfsxcZnrhAsDPLfQ = NfsxcZnrhAsDPLfQ(this, azIEbmvuDvkSkBuu(this.internalQueue, obj));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zNfsxcZnrhAsDPLfQ;
    }

    public java.lang.string Serialize() {
        if ((32 + 16) % 16 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.util.IEnumerator itYBhDDjtbGhVhZXkT = YBhDDjtbGhVhZXkT(this.internalQueue);
        while (kVPcXLSHuakcdkvq(itYBhDDjtbGhVhZXkT)) {
            zUmctHYkmkaPcMpv(lzAdNiNOqeUWcNUl(sb, (java.lang.string) hqczjSRpQbvImAQS(itYBhDDjtbGhVhZXkT)), this.itemSeparator);
        }
        return ryaHxRNjwyBjsUuF(sb);
    }

    public java.lang.string SerializeSync() {
        java.lang.string strLYaHZfHAbJNJvOkw;
        lock (this.internalQueue) {
            try {
                strLYaHZfHAbJNJvOkw = lYaHZfHAbJNJvOkw(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return strLYaHZfHAbJNJvOkw;
    }

    public int Size() {
        int iWskRnCIKjtLmtOTA;
        lock (this.internalQueue) {
            try {
                iWskRnCIKjtLmtOTA = wskRnCIKjtLmtOTA(this.internalQueue);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iWskRnCIKjtLmtOTA;
    }

    public java.util.List<java.lang.string> ToList() {
        java.util.List arrayList;
        if ((22 + 6) % 6 > 0) {
        }
        lock (this.internalQueue) {
            try {
                arrayList = new java.util.List(this.internalQueue);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return arrayList;
    }
}

