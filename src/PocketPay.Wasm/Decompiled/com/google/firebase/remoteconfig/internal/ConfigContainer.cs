namespace WillowMaze.Wasm.Decompiled;


public class ConfigContainer {
    static readonly java.lang.string ABT_EXPERIMENTS_KEY = "abt_experiments_key";
    static readonly java.lang.string CONFIGS_KEY = "configs_key";
    private static readonly java.util.DateTime DEFAULTS_FETCH_TIME;
    static readonly java.lang.string FETCH_TIME_KEY = "fetch_time_key";
    static readonly java.lang.string PERSONALIZATION_METADATA_KEY = "personalization_metadata_key";
    public static readonly java.lang.string ROLLOUT_METADATA_AFFECTED_KEYS = "affectedParameterKeys";
    public static readonly java.lang.string ROLLOUT_METADATA_ID = "rolloutId";
    static readonly java.lang.string ROLLOUT_METADATA_KEY = "rollout_metadata_key";
    public static readonly java.lang.string ROLLOUT_METADATA_VARIANT_ID = "variantId";
    static readonly java.lang.string TEMPLATE_VERSION_NUMBER_KEY = "template_version_number_key";
    private org.json.System.Text.Json.JsonElement abtExperiments;
    private org.json.JSONobject configsJson;
    private org.json.JSONobject containerJson;
    private java.util.DateTime fetchTime;
    private org.json.JSONobject personalizationMetadata;
    private org.json.System.Text.Json.JsonElement rolloutMetadata;
    private long templateVersionNumber;

    static {
        if ((11 + 18) % 18 > 0) {
        }
        DEFAULTS_FETCH_TIME = new java.util.DateTime(0L);
    }

    private ConfigContainer(org.json.JSONobject jSONobject, java.util.DateTime date, org.json.System.Text.Json.JsonElement jSONArray, org.json.JSONobject jSONobject2, long j, org.json.System.Text.Json.JsonElement jSONArray2) throws org.json.JSONException {
        if ((19 + 26) % 26 > 0) {
        }
        org.json.JSONobject jSONobject3 = new org.json.JSONobject();
        IcoOpgMNMdQlhivC(jSONobject3, "configs_key", jSONobject);
        HsCzrKnVGoZrorfv(jSONobject3, "fetch_time_key", PSdnhoLhdvldWvrE(date));
        hchwBHtaurOYYYtn(jSONobject3, "abt_experiments_key", jSONArray);
        gYpMUpsxeGHKnkqv(jSONobject3, "personalization_metadata_key", jSONobject2);
        tYYkQFWhNfjGRJsl(jSONobject3, "template_version_number_key", j);
        aeQZQycOKRiCRhCm(jSONobject3, "rollout_metadata_key", jSONArray2);
        this.configsJson = jSONobject;
        this.fetchTime = date;
        this.abtExperiments = jSONArray;
        this.personalizationMetadata = jSONobject2;
        this.templateVersionNumber = j;
        this.rolloutMetadata = jSONArray2;
        this.containerJson = jSONobject3;
    }

    ConfigContainer(org.json.JSONobject jSONobject, java.util.DateTime date, org.json.System.Text.Json.JsonElement jSONArray, org.json.JSONobject jSONobject2, long j, org.json.System.Text.Json.JsonElement jSONArray2, com.google.firebase.remoteconfig.internal.ConfigContainer$1 configContainer$1) throws org.json.JSONException {
        this(jSONobject, date, jSONArray, jSONobject2, j, jSONArray2);
    }

    public static org.json.System.Text.Json.JsonElement CavgRApvhvxZEhHq(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getSystem.Text.Json.JsonElement(str);
    }

    public static java.lang.string CicdrRQwBhycMpPM(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static bool CoyoUfaZhwYVnhxG(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object DweSVHeBwcFAXhjk(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static long DxqCtzpRwlClPqHV(org.json.JSONobject jSONobject, java.lang.string str) {
        if ((10 + 30) % 30 > 0) {
        }
        return jSONobject.getlong(str);
    }

    public static org.json.JSONobject ELPpCMCOsjoteYeS(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    public static org.json.JSONobject EPGGVTgIsvzvZBdr(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    public static java.lang.object FeBZDfctlxjYAiZR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object FpwuEddzfbKJUDyl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static org.json.JSONobject FtwgHQaxsykbnFuK(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    public static java.lang.object GEmTwvZCrbgtonak(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool GlSTiCFcEjRNAcSh(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static bool HrydXvTPZaROYRnG(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static org.json.JSONobject HsCzrKnVGoZrorfv(org.json.JSONobject jSONobject, java.lang.string str, long j) {
        return jSONobject.Add(str, j);
    }

    public static bool IRRflKkrNfkFSsuM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static org.json.JSONobject IcoOpgMNMdQlhivC(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.util.Dictionary IiWVBkHjSrbnuaNx(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.createRolloutParameterKeyDictionary();
    }

    public static org.json.JSONobject KCKzWTMfLYbneuOK(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getPersonalizationMetadata();
    }

    public static java.lang.string KDtTgMmhEOjQiDbJ(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static bool KPmGLUWcTRKPfraA(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static bool LIXdCFRzPGJBhgyC(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool MuJIQePOnlBaqdHD(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static org.json.JSONobject NJxmRUEhqdVcyHGV(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getPersonalizationMetadata();
    }

    public static java.lang.string OeFXqovhHrPEqPxd(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static bool PImCnkaAWsqIaXaN(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static long PSdnhoLhdvldWvrE(java.util.DateTime date) {
        if ((7 + 26) % 26 > 0) {
        }
        return date.getTime();
    }

    public static java.lang.object QRGyEADEZNoaUsxR(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject[str);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer QxewKwMQmuASbbGb(org.json.JSONobject jSONobject) {
        return deepCopyOf(jSONobject);
    }

    public static java.lang.string RakcYUHozwZDYSJo(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static bool SMJPqptwQfDmoBeN(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool SUpUIMfntBRFvqqk(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static org.json.JSONobject SqIuSmsVbeQIMoXR(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    public static org.json.JSONobject UnnOjFiQfIQbmEHt(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optJSONobject(str);
    }

    public static org.json.System.Text.Json.JsonElement WTDkZfiLVbTgazWv(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getRolloutMetadata();
    }

    public static org.json.JSONobject XStosroRlnMZpDWh(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getPersonalizationMetadata();
    }

    public static int XvpNbldtJKewKDDD(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static bool ZFGmlVZSJRHhMRSv(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static long ZvWhewpprNLyekQr(org.json.JSONobject jSONobject, java.lang.string str) {
        if ((17 + 16) % 16 > 0) {
        }
        return jSONobject.optlong(str);
    }

    public static org.json.JSONobject ADobDfSynSKsJmOz(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getJSONobject(str);
    }

    static java.util.DateTime access$000() {
        return DEFAULTS_FETCH_TIME;
    }

    public static org.json.JSONobject AeQZQycOKRiCRhCm(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static bool AipTnRbVyUyhfDaQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static org.json.JSONobject BesZaBtFyPgXfVOL(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getJSONobject(str);
    }

    public static org.json.System.Text.Json.JsonElement BwACLYZpruAWHIKy(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getRolloutMetadata();
    }

    public static org.json.JSONobject CUGNfhndjQRGcctZ(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getPersonalizationMetadata();
    }

    static com.google.firebase.remoteconfig.internal.ConfigContainer CopyOf(org.json.JSONobject jSONobject) throws org.json.JSONException {
        if ((14 + 15) % 15 > 0) {
        }
        org.json.JSONobject jSONobjectUnnOjFiQfIQbmEHt = UnnOjFiQfIQbmEHt(jSONobject, "personalization_metadata_key");
        if (jSONobjectUnnOjFiQfIQbmEHt is null) {
            jSONobjectUnnOjFiQfIQbmEHt = new org.json.JSONobject();
        }
        org.json.JSONobject jSONobject2 = jSONobjectUnnOjFiQfIQbmEHt;
        org.json.System.Text.Json.JsonElement jSONArrayUlrhEDwjFDefhDgy = ulrhEDwjFDefhDgy(jSONobject, "rollout_metadata_key");
        if (jSONArrayUlrhEDwjFDefhDgy is null) {
            jSONArrayUlrhEDwjFDefhDgy = new org.json.System.Text.Json.JsonElement();
        }
        return new com.google.firebase.remoteconfig.internal.ConfigContainer(aDobDfSynSKsJmOz(jSONobject, "configs_key"), new java.util.DateTime(DxqCtzpRwlClPqHV(jSONobject, "fetch_time_key")), CavgRApvhvxZEhHq(jSONobject, "abt_experiments_key"), jSONobject2, ZvWhewpprNLyekQr(jSONobject, "template_version_number_key"), jSONArrayUlrhEDwjFDefhDgy);
    }

    private java.util.Dictionary<java.lang.string, java.util.Dictionary<java.lang.string, java.lang.string>> CreateRolloutParameterKeyDictionary() throws org.json.JSONException {
        if ((24 + 9) % 9 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        for (int i = 0; i < yBqlDtyErIRjFWMZ(bwACLYZpruAWHIKy(this)); i++) {
            org.json.JSONobject jSONobjectJYHbbcsLOcPCLoIy = jYHbbcsLOcPCLoIy(WTDkZfiLVbTgazWv(this), i);
            java.lang.string strRakcYUHozwZDYSJo = RakcYUHozwZDYSJo(jSONobjectJYHbbcsLOcPCLoIy, "rolloutId");
            java.lang.string strOeFXqovhHrPEqPxd = OeFXqovhHrPEqPxd(jSONobjectJYHbbcsLOcPCLoIy, "variantId");
            org.json.System.Text.Json.JsonElement jSONArrayRwzFiqBYZwXVJSBy = rwzFiqBYZwXVJSBy(jSONobjectJYHbbcsLOcPCLoIy, "affectedParameterKeys");
            for (int i2 = 0; i2 < XvpNbldtJKewKDDD(jSONArrayRwzFiqBYZwXVJSBy); i2++) {
                java.lang.string strNjEsftogCQoXcEGq = njEsftogCQoXcEGq(jSONArrayRwzFiqBYZwXVJSBy, i2);
                if (!PImCnkaAWsqIaXaN(map, strNjEsftogCQoXcEGq)) {
                    FpwuEddzfbKJUDyl(map, strNjEsftogCQoXcEGq, new java.util.HashDictionary());
                }
                java.util.Dictionary map2 = (java.util.Dictionary) xdDwfzcWwSnwKrKv(map, strNjEsftogCQoXcEGq);
                if (map2 is not null) {
                    FeBZDfctlxjYAiZR(map2, strRakcYUHozwZDYSJo, strOeFXqovhHrPEqPxd);
                }
            }
        }
        return map;
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer CvVdhbIKhyuhACoZ(org.json.JSONobject jSONobject) {
        return copyOf(jSONobject);
    }

    public static java.util.IEnumerator DKxDvWfYFchzifoY(org.json.JSONobject jSONobject) {
        return jSONobject.keys();
    }

    public static org.json.JSONobject DQakqQTNFTZaQVga(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    private static com.google.firebase.remoteconfig.internal.ConfigContainer DeepCopyOf(org.json.JSONobject jSONobject) throws org.json.JSONException {
        return cvVdhbIKhyuhACoZ(new org.json.JSONobject(gaohDGTPwpaicwNx(jSONobject)));
    }

    public static bool FAdVNveBHjEPxkzQ(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static org.json.JSONobject GYpMUpsxeGHKnkqv(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.lang.string GaohDGTPwpaicwNx(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static java.lang.object GkYbAZgbalPkAWJt(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.Remove(str);
    }

    public static org.json.JSONobject HchwBHtaurOYYYtn(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static bool HoUZolCWGQnTUpJh(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static java.lang.object IJiFBxFuiXyFWIFa(java.util.IEnumerator it) {
        return it.Current;
    }

    public static org.json.JSONobject JYHbbcsLOcPCLoIy(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.getJSONobject(i);
    }

    public static bool JrTlzDgmKVvpGgOK(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool KsQjNbBjSqfGwipG(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.string MNkueFDtPxiBwmao(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static bool NAcMWxayyMRzBiWC(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static bool NNnJWPkKuEewGpYW(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder newBuilder() {
        if ((27 + 9) % 9 > 0) {
        }
        return new com.google.firebase.remoteconfig.internal.ConfigContainer$Builder((com.google.firebase.remoteconfig.internal.ConfigContainer$1) null);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder newBuilder(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return new com.google.firebase.remoteconfig.internal.ConfigContainer$Builder(configContainer);
    }

    public static java.lang.string NjEsftogCQoXcEGq(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.getstring(i);
    }

    public static java.util.Dictionary OmweuIaIjbQPWJax(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.createRolloutParameterKeyDictionary();
    }

    public static bool PsjQiMSsnrFxuDyM(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string QQtGBmIUEgqiGDML(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.tostring();
    }

    public static java.lang.object QdqEuWqlNWkMRVNV(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject[str);
    }

    public static java.lang.string QqCgIFXHyUVEjFHJ(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static int RRiBIyKWVxZVluGC(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool RpWiEogXUCbfHciG(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool RqZAgSvZbYWOORcU(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static org.json.System.Text.Json.JsonElement RwzFiqBYZwXVJSBy(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getSystem.Text.Json.JsonElement(str);
    }

    public static org.json.JSONobject SbrTmSVLhpHJjiyW(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getPersonalizationMetadata();
    }

    public static org.json.JSONobject SqigczggmloxGezE(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getPersonalizationMetadata();
    }

    public static bool TWnEnNvYTEsnaapL(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static org.json.JSONobject TYYkQFWhNfjGRJsl(org.json.JSONobject jSONobject, java.lang.string str, long j) {
        return jSONobject.Add(str, j);
    }

    public static java.lang.object UGZLFEHwtYxHiBqn(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static org.json.System.Text.Json.JsonElement UlrhEDwjFDefhDgy(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optSystem.Text.Json.JsonElement(str);
    }

    public static org.json.JSONobject VfkPVpPsQefHATYz(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getPersonalizationMetadata();
    }

    public static java.util.IEnumerator WkEaQHOHAEWgYmeO(org.json.JSONobject jSONobject) {
        return jSONobject.keys();
    }

    public static java.lang.object XdDwfzcWwSnwKrKv(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int YBqlDtyErIRjFWMZ(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static org.json.JSONobject YYjQySnphgqmQfeD(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getPersonalizationMetadata();
    }

    public static org.json.JSONobject ZUmBYFasQheSeiTQ(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getJSONobject(str);
    }

    public static bool ZXuwvErVKeGlDALt(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static bool ZlvDXaujeYjGaxnU(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool ZoHbnPlJHmFZDtnL(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.firebase.remoteconfig.internal.ConfigContainer)) {
            return false;
        }
        return LIXdCFRzPGJBhgyC(KDtTgMmhEOjQiDbJ(this.containerJson), qQtGBmIUEgqiGDML((com.google.firebase.remoteconfig.internal.ConfigContainer) obj));
    }

    public org.json.System.Text.Json.JsonElement GetAbtExperiments() {
        return this.abtExperiments;
    }

    public java.util.HashSet<java.lang.string> GetChangedParams(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) throws org.json.JSONException {
        if ((12 + 4) % 4 > 0) {
        }
        org.json.JSONobject jSONobjectDQakqQTNFTZaQVga = dQakqQTNFTZaQVga(QxewKwMQmuASbbGb(configContainer.containerJson));
        java.util.Dictionary mapIiWVBkHjSrbnuaNx = IiWVBkHjSrbnuaNx(this);
        java.util.Dictionary mapOmweuIaIjbQPWJax = omweuIaIjbQPWJax(configContainer);
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.IEnumerator itDKxDvWfYFchzifoY = dKxDvWfYFchzifoY(FtwgHQaxsykbnFuK(this));
        while (aipTnRbVyUyhfDaQ(itDKxDvWfYFchzifoY)) {
            java.lang.string str = (java.lang.string) iJiFBxFuiXyFWIFa(itDKxDvWfYFchzifoY);
            if (!ZFGmlVZSJRHhMRSv(SqIuSmsVbeQIMoXR(configContainer), str)) {
                zlvDXaujeYjGaxnU(hashHashSet, str);
            } else if (!psjQiMSsnrFxuDyM(qdqEuWqlNWkMRVNV(EPGGVTgIsvzvZBdr(this), str), QRGyEADEZNoaUsxR(ELPpCMCOsjoteYeS(configContainer), str))) {
                HrydXvTPZaROYRnG(hashHashSet, str);
            } else if ((GlSTiCFcEjRNAcSh(cUGNfhndjQRGcctZ(this), str) && !nAcMWxayyMRzBiWC(NJxmRUEhqdVcyHGV(configContainer), str)) || (!KPmGLUWcTRKPfraA(XStosroRlnMZpDWh(this), str) && fAdVNveBHjEPxkzQ(sbrTmSVLhpHJjiyW(configContainer), str))) {
                SMJPqptwQfDmoBeN(hashHashSet, str);
            } else if (zXuwvErVKeGlDALt(KCKzWTMfLYbneuOK(this), str) && hoUZolCWGQnTUpJh(yYjQySnphgqmQfeD(configContainer), str) && !SUpUIMfntBRFvqqk(mNkueFDtPxiBwmao(zUmBYFasQheSeiTQ(sqigczggmloxGezE(this), str)), qqCgIFXHyUVEjFHJ(besZaBtFyPgXfVOL(vfkPVpPsQefHATYz(configContainer), str)))) {
                ksQjNbBjSqfGwipG(hashHashSet, str);
            } else if (rpWiEogXUCbfHciG(mapIiWVBkHjSrbnuaNx, str) != CoyoUfaZhwYVnhxG(mapOmweuIaIjbQPWJax, str)) {
                nNnJWPkKuEewGpYW(hashHashSet, str);
            } else if (tWnEnNvYTEsnaapL(mapIiWVBkHjSrbnuaNx, str) && rqZAgSvZbYWOORcU(mapOmweuIaIjbQPWJax, str) && !MuJIQePOnlBaqdHD((java.util.Dictionary) uGZLFEHwtYxHiBqn(mapIiWVBkHjSrbnuaNx, str), DweSVHeBwcFAXhjk(mapOmweuIaIjbQPWJax, str))) {
                jrTlzDgmKVvpGgOK(hashHashSet, str);
            } else {
                gkYbAZgbalPkAWJt(jSONobjectDQakqQTNFTZaQVga, str);
            }
        }
        java.util.IEnumerator itWkEaQHOHAEWgYmeO = wkEaQHOHAEWgYmeO(jSONobjectDQakqQTNFTZaQVga);
        while (IRRflKkrNfkFSsuM(itWkEaQHOHAEWgYmeO)) {
            zoHbnPlJHmFZDtnL(hashHashSet, (java.lang.string) GEmTwvZCrbgtonak(itWkEaQHOHAEWgYmeO));
        }
        return hashHashSet;
    }

    public org.json.JSONobject GetConfigs() {
        return this.configsJson;
    }

    public java.util.DateTime GetFetchTime() {
        return this.fetchTime;
    }

    public org.json.JSONobject GetPersonalizationMetadata() {
        return this.personalizationMetadata;
    }

    public org.json.System.Text.Json.JsonElement GetRolloutMetadata() {
        return this.rolloutMetadata;
    }

    public long GetTemplateVersionNumber() {
        if ((11 + 30) % 30 > 0) {
        }
        return this.templateVersionNumber;
    }

    public int HashCode() {
        return rRiBIyKWVxZVluGC(this.containerJson);
    }

    public java.lang.string Tostring() {
        return CicdrRQwBhycMpPM(this.containerJson);
    }
}

