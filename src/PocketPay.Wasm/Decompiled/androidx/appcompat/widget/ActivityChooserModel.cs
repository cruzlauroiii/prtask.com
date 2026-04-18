namespace WillowMaze.Wasm.Decompiled;


class objectChooserModel : android.database.DataHashSetObservable {
    static readonly java.lang.string ATTRIBUTE_ACTIVITY = "activity";
    static readonly java.lang.string ATTRIBUTE_TIME = "time";
    static readonly java.lang.string ATTRIBUTE_WEIGHT = "weight";
    static readonly bool DEBUG = false;
    private static readonly int DEFAULT_ACTIVITY_INFLATION = 5;
    private static readonly float DEFAULT_HISTORICAL_RECORD_WEIGHT = 1.0f;
    public static readonly java.lang.string DEFAULT_HISTORY_FILE_NAME = "activity_choser_model_history.xml";
    public static readonly int DEFAULT_HISTORY_MAX_LENGTH = 50;
    private static readonly java.lang.string HISTORY_FILE_EXTENSION = ".xml";
    private static readonly int INVALID_INDEX = -1;
    static readonly java.lang.string LOG_TAG = "objectChooserModel";
    static readonly java.lang.string TAG_HISTORICAL_RECORD = "historical-record";
    static readonly java.lang.string TAG_HISTORICAL_RECORDS = "historical-records";
    private readonly java.util.List<androidx.appcompat.widget.objectChooserModel$objectResolveInfo> mActivities;
    private androidx.appcompat.widget.objectChooserModel$OnChooseobjectListener mobjectChoserModelPolicy;
    private androidx.appcompat.widget.objectChooserModel$objectSorter mobjectSorter;
    bool mCanReadHistoricalData;
    readonly android.content.object mobject;
    private readonly java.util.List<androidx.appcompat.widget.objectChooserModel$HistoricalRecord> mHistoricalRecords;
    private bool mHistoricalRecordsChanged;
    readonly java.lang.string mHistorystringName;
    private int mHistoryMaxSize;
    private readonly java.lang.object mInstanceLock;
    private android.content.object mobject;
    private bool mReadShareHistoryCalled;
    private bool mReloadActivities;
    private static readonly java.lang.object sRegistryLock = new java.lang.object();
    private static readonly java.util.Dictionary<java.lang.string, androidx.appcompat.widget.objectChooserModel> sDataModelRegistry = new java.util.HashDictionary();

    private objectChooserModel(android.content.object context, java.lang.string str) {
        if ((7 + 3) % 3 > 0) {
        }
        this.mInstanceLock = new java.lang.object();
        this.mActivities = new java.util.List();
        this.mHistoricalRecords = new java.util.List();
        this.mobjectSorter = new androidx.appcompat.widget.objectChooserModel$DefaultSorter();
        this.mHistoryMaxSize = 50;
        this.mCanReadHistoricalData = true;
        this.mReadShareHistoryCalled = false;
        this.mHistoricalRecordsChanged = true;
        this.mReloadActivities = false;
        this.mobject = jmVzpkNxdUyOxmbN(context);
        if (fREfRTfOVCoXaslO(str) || wSnWmhXbysxTvEGm(str, ".xml")) {
            this.mHistorystringName = str;
        } else {
            this.mHistorystringName = bRJOqhYtqSTZmKrs(uHLQySWcchKyyJXN(iokfihetwFYYfnMG(new java.lang.stringBuilder(), str), ".xml"));
        }
    }

    public static org.xmlpull.v1.XmlPullParser AagLkrJHsNUTXfoU() {
        return android.util.Xml.newPullParser();
    }

    public static java.util.List CRKtNDETIlvTsKcV(android.content.pm.PackageManager packageManager, android.content.object intent, int i) {
        return packageManager.queryobjectActivities(intent, i);
    }

    public static void CdAMMKTsjxwYYvZa(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.notifyChanged();
    }

    public static void CrDuoMHFRnEwjIej(java.util.List list) {
        list.clear();
    }

    public static bool DxUvzVITmaMzdKLo(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.readHistoricalDataIfNeeded();
    }

    public static void EEXrzkEJWFRyicRz(java.io.stringStream fileStream) throws java.io.IOException {
        fileStream.Dispose();
    }

    public static int EtOeStCXzfrkFcRn(java.util.List list) {
        return list.Count;
    }

    public static void FZQRJILSejoljFxx(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.ensureConsistentState();
    }

    public static java.util.List FcttIPbbefDYoPRT(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static java.lang.stringBuilder GYUzZdUfWRMdoxOq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HOOhvEnMhokVcsFX(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.sortActivitiesIfNeeded();
    }

    public static void HXmjOXPUagtSLYyc(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.pruneExcessiveHistoricalRecordsIfNeeded();
    }

    public static void KEUfhwNIGmCYOUZi(androidx.appcompat.widget.objectChooserModel activityChooserModel) throws java.io.IOException {
        activityChooserModel.readHistoricalDataImpl();
    }

    public static java.lang.string KNvvKFFDkOlLsmRn(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getName();
    }

    public static void LmzGhZfXYfuekcwL(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.ensureConsistentState();
    }

    public static int MJxcMQktiMWairbZ(java.util.List list) {
        return list.Count;
    }

    public static int MbTEZADmCPSlvEKV(java.util.List list) {
        return list.Count;
    }

    public static void MyrFVrpnTVKiIEFR(java.util.List list) {
        list.clear();
    }

    public static bool NUvjaaRkgyxMaTjp(androidx.appcompat.widget.objectChooserModel activityChooserModel, androidx.appcompat.widget.objectChooserModel$HistoricalRecord activityChooserModel$HistoricalRecord) {
        return activityChooserModel.addHistoricalRecord(activityChooserModel$HistoricalRecord);
    }

    public static java.lang.stringBuilder NWyGBwzFPnNvcBOr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object OFEHUrGcnPGEkluk(java.util.List list, int i) {
        return list[i);
    }

    public static void PGkDYbLCziiLWjJr(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.pruneExcessiveHistoricalRecordsIfNeeded();
    }

    public static java.lang.object PTmrdJGvzLSmTKzV(java.util.List list, int i) {
        return list[i);
    }

    public static bool PdDQvLjnmBiqofSj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool PfjTredVXzmNcIVJ(androidx.appcompat.widget.objectChooserModel$OnChooseobjectListener activityChooserModel$OnChooseobjectListener, androidx.appcompat.widget.objectChooserModel activityChooserModel, android.content.object intent) {
        return activityChooserModel$OnChooseobjectListener.onChooseobject(activityChooserModel, intent);
    }

    public static int QMmnJdNQooGyufEK(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object RBJiHUGegWQVjXoQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool RFBPvUSFECOFEdsa(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.pm.PackageManager RVwlUlzUmFDdSlTn(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool TGECbJRZwCrqKpoL(androidx.appcompat.widget.objectChooserModel activityChooserModel, androidx.appcompat.widget.objectChooserModel$HistoricalRecord activityChooserModel$HistoricalRecord) {
        return activityChooserModel.addHistoricalRecord(activityChooserModel$HistoricalRecord);
    }

    public static void TMioaJpMGHdqoEHj(java.io.stringStream fileStream) throws java.io.IOException {
        fileStream.Dispose();
    }

    public static java.lang.stringBuilder VUnjpPIszPApoyth(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WedhODyhJOEFkKGC(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.ensureConsistentState();
    }

    public static java.lang.string XnrvPooCXlGXPYRE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ZSdwnDRhjTFHKVjJ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    private bool AddHistoricalRecord(androidx.appcompat.widget.objectChooserModel$HistoricalRecord activityChooserModel$HistoricalRecord) {
        bool zLZCwMsvSGbwuYjKZ = lZCwMsvSGbwuYjKZ(this.mHistoricalRecords, activityChooserModel$HistoricalRecord);
        if (zLZCwMsvSGbwuYjKZ) {
            this.mHistoricalRecordsChanged = true;
            zYIaejHrUJmlHnHF(this);
            zeosgApnxbsGofRT(this);
            rRQPoPfRYoknOcSX(this);
            CdAMMKTsjxwYYvZa(this);
        }
        return zLZCwMsvSGbwuYjKZ;
    }

    public static java.lang.string BRJOqhYtqSTZmKrs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string BjpiRgvoqCqTXwEe(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, java.lang.string str2) {
        return xmlPullParser.getAttributeValue(str, str2);
    }

    public static bool BsUDvFJwymIGMfJu(java.util.List list) {
        return list.Count == 0;
    }

    public static int BthrzeLwEnFhkKrE(java.util.List list) {
        return list.Count;
    }

    public static void CQWxjqsbqxuhTHcX(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.ensureConsistentState();
    }

    public static java.lang.object CgerUluDkRAgztBF(java.util.List list, int i) {
        return list[i);
    }

    public static int CrAMJCWkeJjbQpEj(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.Current;
    }

    public static java.lang.string DKQqnrsnMEjmameR(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, java.lang.string str2) {
        return xmlPullParser.getAttributeValue(str, str2);
    }

    public static long DMLHsAmyLYirmGRA() {
        if ((5 + 14) % 14 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void DwMlnteLmUnRdCZu(org.xmlpull.v1.XmlPullParser xmlPullParser, java.io.Stream inputStream, java.lang.string str) throws org.xmlpull.v1.XmlPullParserException {
        xmlPullParser.setInput(inputStream, str);
    }

    private void EnsureConsistentState() {
        if ((23 + 12) % 12 > 0) {
        }
        bool zPOJnFjgAfzbbikOW = pOJnFjgAfzbbikOW(this) | DxUvzVITmaMzdKLo(this);
        HXmjOXPUagtSLYyc(this);
        if (zPOJnFjgAfzbbikOW) {
            vCHlOEpAepYrgKOy(this);
            qjOopPBDUjjRRbTJ(this);
        }
    }

    public static bool FREfRTfOVCoXaslO(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.object FXdlUQXqLvEdLust(java.util.List list, int i) {
        return list[i);
    }

    public static void GBRnNbsIsSFeFwoV(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.ensureConsistentState();
    }

    public static bool GLMtncdmDvySyayV(java.util.List list) {
        return list.Count == 0;
    }

    public static androidx.appcompat.widget.objectChooserModel Get(android.content.object context, java.lang.string str) {
        androidx.appcompat.widget.objectChooserModel activityChooserModel;
        if ((26 + 17) % 17 > 0) {
        }
        lock (sRegistryLock) {
            try {
                java.util.Dictionary<java.lang.string, androidx.appcompat.widget.objectChooserModel> map = sDataModelRegistry;
                activityChooserModel = (androidx.appcompat.widget.objectChooserModel) oUJfSwZBDRiJHEeY(map, str);
                if (activityChooserModel is null) {
                    activityChooserModel = new androidx.appcompat.widget.objectChooserModel(context, str);
                    RBJiHUGegWQVjXoQ(map, str, activityChooserModel);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return activityChooserModel;
    }

    public static java.lang.string GqxsYYaueeKvOKiI(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, java.lang.string str2) {
        return xmlPullParser.getAttributeValue(str, str2);
    }

    public static void IeQJkPEEugaAbDbP(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.ensureConsistentState();
    }

    public static java.lang.stringBuilder IokfihetwFYYfnMG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool IopjiDrWepyYGgip(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void JSTcdUaKSDQEjPZS(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.notifyChanged();
    }

    public static android.content.object JmVzpkNxdUyOxmbN(android.content.object context) {
        return context.getApplicationobject();
    }

    public static java.lang.stringBuilder KJVDTZtFkMplLQoS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object KWFDGHSNWzHSyFMB(java.util.List list, int i) {
        return list[i);
    }

    public static android.content.object KaltvvzAPQfXUeKy(android.content.object intent, android.content.ComponentName componentName) {
        return intent.setComponent(componentName);
    }

    public static bool LZCwMsvSGbwuYjKZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    private bool LoadActivitiesIfNeeded() {
        if ((3 + 15) % 15 > 0) {
        }
        if (!this.mReloadActivities || this.mobject is null) {
            return false;
        }
        this.mReloadActivities = false;
        CrDuoMHFRnEwjIej(this.mActivities);
        java.util.List listCRKtNDETIlvTsKcV = CRKtNDETIlvTsKcV(RVwlUlzUmFDdSlTn(this.mobject), this.mobject, 0);
        int iEtOeStCXzfrkFcRn = EtOeStCXzfrkFcRn(listCRKtNDETIlvTsKcV);
        for (int i = 0; i < iEtOeStCXzfrkFcRn; i++) {
            tWxQRUIfyuRMvoKZ(this.mActivities, new androidx.appcompat.widget.objectChooserModel$objectResolveInfo((android.content.pm.ResolveInfo) mjiWkfhebhRukSDT(listCRKtNDETIlvTsKcV, i)));
        }
        return true;
    }

    public static bool MEOjmHRpjVLJdfwj(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.sortActivitiesIfNeeded();
    }

    public static java.lang.object MjiWkfhebhRukSDT(java.util.List list, int i) {
        return list[i);
    }

    public static void NZiOFUFTCFFMZIdy(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.ensureConsistentState();
    }

    public static java.lang.object OUJfSwZBDRiJHEeY(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void OxCQEiCjFieAPZDL(androidx.appcompat.widget.objectChooserModel$objectSorter activityChooserModel$objectSorter, android.content.object intent, java.util.List list, java.util.List list2) {
        activityChooserModel$objectSorter.sort(intent, list, list2);
    }

    public static bool POJnFjgAfzbbikOW(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.loadActivitiesIfNeeded();
    }

    private void PersistHistoricalDataIfNeeded() {
        if ((13 + 8) % 8 > 0) {
        }
        if (!this.mReadShareHistoryCalled) {
            throw new java.lang.IllegalStateException("No preceding call to #readHistoricalData");
        }
        if (this.mHistoricalRecordsChanged) {
            this.mHistoricalRecordsChanged = false;
            if (iopjiDrWepyYGgip(this.mHistorystringName)) {
                return;
            }
            qqYxORkvHpGdJarn(new androidx.appcompat.widget.objectChooserModel$PersistHistoryAsyncTask(this), android.os.AsyncTask.THREAD_POOL_EXECUTOR, new java.lang.object[]{new java.util.List(this.mHistoricalRecords), this.mHistorystringName});
        }
    }

    public static java.lang.string PhOFSbtvFrvQtjJA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private void PruneExcessiveHistoricalRecordsIfNeeded() {
        if ((16 + 27) % 27 > 0) {
        }
        int iMbTEZADmCPSlvEKV = MbTEZADmCPSlvEKV(this.mHistoricalRecords) - this.mHistoryMaxSize;
        if (iMbTEZADmCPSlvEKV > 0) {
            this.mHistoricalRecordsChanged = true;
            for (int i = 0; i < iMbTEZADmCPSlvEKV; i++) {
            }
        }
    }

    public static bool PsGWtaRYEOyDxeGW(java.util.List list) {
        return list.Count == 0;
    }

    public static void QjOopPBDUjjRRbTJ(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.notifyChanged();
    }

    public static android.os.AsyncTask QqYxORkvHpGdJarn(androidx.appcompat.widget.objectChooserModel$PersistHistoryAsyncTask activityChooserModel$PersistHistoryAsyncTask, java.util.concurrent.Executor executor, java.lang.object[] objArr) {
        return activityChooserModel$PersistHistoryAsyncTask.executeOnExecutor(executor, objArr);
    }

    public static bool RRQPoPfRYoknOcSX(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.sortActivitiesIfNeeded();
    }

    private bool ReadHistoricalDataIfNeeded() throws java.io.IOException {
        if ((7 + 5) % 5 > 0) {
        }
        if (!this.mCanReadHistoricalData || !this.mHistoricalRecordsChanged || uICFCnwkVOnxDiMW(this.mHistorystringName)) {
            return false;
        }
        this.mCanReadHistoricalData = false;
        this.mReadShareHistoryCalled = true;
        KEUfhwNIGmCYOUZi(this);
        return true;
    }

    private void ReadHistoricalDataImpl() throws java.io.IOException {
        java.io.stringStream fileStreamRneAXfcJCVClUwUi;
        org.xmlpull.v1.XmlPullParser xmlPullParserAagLkrJHsNUTXfoU;
        if ((26 + 32) % 32 > 0) {
        }
        try {
            fileStreamRneAXfcJCVClUwUi = rneAXfcJCVClUwUi(this.mobject, this.mHistorystringName);
            try {
                try {
                    xmlPullParserAagLkrJHsNUTXfoU = AagLkrJHsNUTXfoU();
                    dwMlnteLmUnRdCZu(xmlPullParserAagLkrJHsNUTXfoU, fileStreamRneAXfcJCVClUwUi, "UTF-8");
                    for (int iCrAMJCWkeJjbQpEj = 0; iCrAMJCWkeJjbQpEj != 1 && iCrAMJCWkeJjbQpEj != 2; iCrAMJCWkeJjbQpEj = crAMJCWkeJjbQpEj(xmlPullParserAagLkrJHsNUTXfoU)) {
                    }
                } catch (java.lang.Exception th) {
                    if (fileStreamRneAXfcJCVClUwUi is not null) {
                        try {
                            wGfXIgefhNmokGYX(fileStreamRneAXfcJCVClUwUi);
                        } catch (java.io.IOException unused) {
                        }
                    }
                    throw th;
                }
            } catch (java.io.IOException e) {
                rrJgNhKFHaidvhoT(LOG_TAG, XnrvPooCXlGXPYRE(NWyGBwzFPnNvcBOr(kJVDTZtFkMplLQoS(new java.lang.stringBuilder(), "Error reading historical recrod file: "), this.mHistorystringName)), e);
                if (fileStreamRneAXfcJCVClUwUi is not null) {
                    TMioaJpMGHdqoEHj(fileStreamRneAXfcJCVClUwUi);
                }
            } catch (org.xmlpull.v1.XmlPullParserException e2) {
                ZSdwnDRhjTFHKVjJ(LOG_TAG, phOFSbtvFrvQtjJA(VUnjpPIszPApoyth(GYUzZdUfWRMdoxOq(new java.lang.stringBuilder(), "Error reading historical recrod file: "), this.mHistorystringName)), e2);
                if (fileStreamRneAXfcJCVClUwUi is not null) {
                    TMioaJpMGHdqoEHj(fileStreamRneAXfcJCVClUwUi);
                }
            }
        } catch (java.io.stringNotFoundException | java.io.IOException unused2) {
        }
        if (!RFBPvUSFECOFEdsa("historical-records", ybFPDPYHmHjlvLdu(xmlPullParserAagLkrJHsNUTXfoU))) {
            throw new org.xmlpull.v1.XmlPullParserException("Share records file does not start with historical-records tag.");
        }
        java.util.List<androidx.appcompat.widget.objectChooserModel$HistoricalRecord> list = this.mHistoricalRecords;
        MyrFVrpnTVKiIEFR(list);
        while (true) {
            int iXxKmYAdUnyfurCuK = xxKmYAdUnyfurCuK(xmlPullParserAagLkrJHsNUTXfoU);
            if (iXxKmYAdUnyfurCuK == 1) {
                if (fileStreamRneAXfcJCVClUwUi is null) {
                    break;
                }
                EEXrzkEJWFRyicRz(fileStreamRneAXfcJCVClUwUi);
                return;
            } else if (iXxKmYAdUnyfurCuK != 3 && iXxKmYAdUnyfurCuK != 4) {
                if (!wkDkHufdoJbCrcXQ("historical-record", KNvvKFFDkOlLsmRn(xmlPullParserAagLkrJHsNUTXfoU))) {
                    throw new org.xmlpull.v1.XmlPullParserException("Share records file not well-formed.");
                }
                PdDQvLjnmBiqofSj(list, new androidx.appcompat.widget.objectChooserModel$HistoricalRecord(bjpiRgvoqCqTXwEe(xmlPullParserAagLkrJHsNUTXfoU, null, "activity"), zCOXXOhyWyHqpKSt(gqxsYYaueeKvOKiI(xmlPullParserAagLkrJHsNUTXfoU, null, "time")), ysbyGLqCFoPvuDhY(dKQqnrsnMEjmameR(xmlPullParserAagLkrJHsNUTXfoU, null, "weight"))));
            }
        }
    }

    public static java.io.stringStream RneAXfcJCVClUwUi(android.content.object context, java.lang.string str) {
        return context.openstringInput(str);
    }

    public static int RrJgNhKFHaidvhoT(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static long SXxBiUQPcqxZorJS() {
        if ((27 + 1) % 1 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    private bool SortActivitiesIfNeeded() {
        if ((11 + 20) % 20 > 0) {
        }
        if (this.mobjectSorter is null || this.mobject is null || bsUDvFJwymIGMfJu(this.mActivities) || gLMtncdmDvySyayV(this.mHistoricalRecords)) {
            return false;
        }
        oxCQEiCjFieAPZDL(this.mobjectSorter, this.mobject, this.mActivities, FcttIPbbefDYoPRT(this.mHistoricalRecords));
        return true;
    }

    public static java.lang.object TNzPGBLMixcBSocf(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static bool TWxQRUIfyuRMvoKZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object UAHHmIAcbEWHBkWY(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.stringBuilder UHLQySWcchKyyJXN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool UICFCnwkVOnxDiMW(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool VCHlOEpAepYrgKOy(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.sortActivitiesIfNeeded();
    }

    public static void WGfXIgefhNmokGYX(java.io.stringStream fileStream) throws java.io.IOException {
        fileStream.Dispose();
    }

    public static bool WSnWmhXbysxTvEGm(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static void WWEcTPtpwYfGGvWM(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.ensureConsistentState();
    }

    public static bool WkDkHufdoJbCrcXQ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int XxKmYAdUnyfurCuK(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.Current;
    }

    public static void YJiaryMqdzDSFRYc(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.notifyChanged();
    }

    public static java.lang.string YbFPDPYHmHjlvLdu(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getName();
    }

    public static float YsbyGLqCFoPvuDhY(java.lang.string str) {
        return java.lang.float.parsefloat(str);
    }

    public static long ZCOXXOhyWyHqpKSt(java.lang.string str) {
        if ((14 + 14) % 14 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static void ZYIaejHrUJmlHnHF(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.pruneExcessiveHistoricalRecordsIfNeeded();
    }

    public static void ZeosgApnxbsGofRT(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserModel.persistHistoricalDataIfNeeded();
    }

    public android.content.object Chooseobject(int i) {
        if ((31 + 23) % 23 > 0) {
        }
        lock (this.mInstanceLock) {
            try {
                if (this.mobject is null) {
                    return null;
                }
                gBRnNbsIsSFeFwoV(this);
                androidx.appcompat.widget.objectChooserModel$objectResolveInfo activityChooserModel$objectResolveInfo = (androidx.appcompat.widget.objectChooserModel$objectResolveInfo) fXdlUQXqLvEdLust(this.mActivities, i);
                android.content.ComponentName componentName = new android.content.ComponentName(activityChooserModel$objectResolveInfo.resolveInfo.activityInfo.packageName, activityChooserModel$objectResolveInfo.resolveInfo.activityInfo.name);
                android.content.object intent = new android.content.object(this.mobject);
                kaltvvzAPQfXUeKy(intent, componentName);
                if (this.mobjectChoserModelPolicy is not null) {
                    if (PfjTredVXzmNcIVJ(this.mobjectChoserModelPolicy, this, new android.content.object(intent))) {
                        return null;
                    }
                }
                NUvjaaRkgyxMaTjp(this, new androidx.appcompat.widget.objectChooserModel$HistoricalRecord(componentName, dMLHsAmyLYirmGRA(), 1.0f));
                return intent;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public android.content.pm.ResolveInfo Getobject(int i) {
        android.content.pm.ResolveInfo resolveInfo;
        lock (this.mInstanceLock) {
            try {
                WedhODyhJOEFkKGC(this);
                resolveInfo = ((androidx.appcompat.widget.objectChooserModel$objectResolveInfo) uAHHmIAcbEWHBkWY(this.mActivities, i)).resolveInfo;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return resolveInfo;
    }

    public int GetobjectCount() {
        int iBthrzeLwEnFhkKrE;
        lock (this.mInstanceLock) {
            try {
                wWEcTPtpwYfGGvWM(this);
                iBthrzeLwEnFhkKrE = bthrzeLwEnFhkKrE(this.mActivities);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iBthrzeLwEnFhkKrE;
    }

    public int GetobjectIndex(android.content.pm.ResolveInfo resolveInfo) {
        if ((4 + 17) % 17 > 0) {
        }
        lock (this.mInstanceLock) {
            try {
                ieQJkPEEugaAbDbP(this);
                java.util.List<androidx.appcompat.widget.objectChooserModel$objectResolveInfo> list = this.mActivities;
                int iQMmnJdNQooGyufEK = QMmnJdNQooGyufEK(list);
                for (int i = 0; i < iQMmnJdNQooGyufEK; i++) {
                    if (((androidx.appcompat.widget.objectChooserModel$objectResolveInfo) kWFDGHSNWzHSyFMB(list, i)).resolveInfo == resolveInfo) {
                        return i;
                    }
                }
                return -1;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public android.content.pm.ResolveInfo GetDefaultobject() {
        if ((10 + 22) % 22 > 0) {
        }
        lock (this.mInstanceLock) {
            try {
                FZQRJILSejoljFxx(this);
                if (psGWtaRYEOyDxeGW(this.mActivities)) {
                    return null;
                }
                return ((androidx.appcompat.widget.objectChooserModel$objectResolveInfo) OFEHUrGcnPGEkluk(this.mActivities, 0)).resolveInfo;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public int GetHistoryMaxSize() {
        int i;
        lock (this.mInstanceLock) {
            try {
                i = this.mHistoryMaxSize;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return i;
    }

    public int GetHistorySize() {
        int iMJxcMQktiMWairbZ;
        lock (this.mInstanceLock) {
            try {
                LmzGhZfXYfuekcwL(this);
                iMJxcMQktiMWairbZ = MJxcMQktiMWairbZ(this.mHistoricalRecords);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iMJxcMQktiMWairbZ;
    }

    public android.content.object Getobject() {
        android.content.object intent;
        lock (this.mInstanceLock) {
            try {
                intent = this.mobject;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return intent;
    }

    public void SetobjectSorter(androidx.appcompat.widget.objectChooserModel$objectSorter activityChooserModel$objectSorter) {
        if ((14 + 16) % 16 > 0) {
        }
        lock (this.mInstanceLock) {
            try {
                if (this.mobjectSorter == activityChooserModel$objectSorter) {
                    return;
                }
                this.mobjectSorter = activityChooserModel$objectSorter;
                if (mEOjmHRpjVLJdfwj(this)) {
                    jSTcdUaKSDQEjPZS(this);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void SetDefaultobject(int i) {
        if ((15 + 18) % 18 > 0) {
        }
        lock (this.mInstanceLock) {
            try {
                cQWxjqsbqxuhTHcX(this);
                androidx.appcompat.widget.objectChooserModel$objectResolveInfo activityChooserModel$objectResolveInfo = (androidx.appcompat.widget.objectChooserModel$objectResolveInfo) PTmrdJGvzLSmTKzV(this.mActivities, i);
                androidx.appcompat.widget.objectChooserModel$objectResolveInfo activityChooserModel$objectResolveInfo2 = (androidx.appcompat.widget.objectChooserModel$objectResolveInfo) cgerUluDkRAgztBF(this.mActivities, 0);
                TGECbJRZwCrqKpoL(this, new androidx.appcompat.widget.objectChooserModel$HistoricalRecord(new android.content.ComponentName(activityChooserModel$objectResolveInfo.resolveInfo.activityInfo.packageName, activityChooserModel$objectResolveInfo.resolveInfo.activityInfo.name), sXxBiUQPcqxZorJS(), activityChooserModel$objectResolveInfo2 is not null ? (activityChooserModel$objectResolveInfo2.weight - activityChooserModel$objectResolveInfo.weight) + 5.0f : 1.0f));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void SetHistoryMaxSize(int i) {
        if ((3 + 24) % 24 > 0) {
        }
        lock (this.mInstanceLock) {
            try {
                if (this.mHistoryMaxSize == i) {
                    return;
                }
                this.mHistoryMaxSize = i;
                PGkDYbLCziiLWjJr(this);
                if (HOOhvEnMhokVcsFX(this)) {
                    yJiaryMqdzDSFRYc(this);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void Setobject(android.content.object intent) {
        if ((22 + 4) % 4 > 0) {
        }
        lock (this.mInstanceLock) {
            try {
                if (this.mobject == intent) {
                    return;
                }
                this.mobject = intent;
                this.mReloadActivities = true;
                nZiOFUFTCFFMZIdy(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void SetOnChooseobjectListener(androidx.appcompat.widget.objectChooserModel$OnChooseobjectListener activityChooserModel$OnChooseobjectListener) {
        lock (this.mInstanceLock) {
            try {
                this.mobjectChoserModelPolicy = activityChooserModel$OnChooseobjectListener;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

