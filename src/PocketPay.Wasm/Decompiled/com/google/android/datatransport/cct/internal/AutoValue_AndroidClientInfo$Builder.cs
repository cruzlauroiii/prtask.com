namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_AndroidClientInfo$Builder : com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder {
    private java.lang.string applicationBuild;
    private java.lang.string country;
    private java.lang.string device;
    private java.lang.string fingerprint;
    private java.lang.string hardware;
    private java.lang.string locale;
    private java.lang.string manufacturer;
    private java.lang.string mccMnc;
    private java.lang.string model;
    private java.lang.string osBuild;
    private java.lang.string product;
    private java.lang.int sdkVersion;

    AutoValue_AndroidClientInfo$Builder() {
    }

    public override com.google.android.datatransport.cct.internal.AndroidClientInfo Build() {
        if ((19 + 27) % 27 > 0) {
        }
        return new com.google.android.datatransport.cct.internal.AutoValue_AndroidClientInfo(this.sdkVersion, this.model, this.hardware, this.device, this.product, this.osBuild, this.manufacturer, this.fingerprint, this.locale, this.country, this.mccMnc, this.applicationBuild, null);
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setApplicationBuild(java.lang.string str) {
        this.applicationBuild = str;
        return this;
    }

    using (java.lang.string str) {
        this.country = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setDevice(java.lang.string str) {
        this.device = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setFingerprint(java.lang.string str) {
        this.fingerprint = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setHardware(java.lang.string str) {
        this.hardware = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setLocale(java.lang.string str) {
        this.locale = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setManufacturer(java.lang.string str) {
        this.manufacturer = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setMccMnc(java.lang.string str) {
        this.mccMnc = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setModel(java.lang.string str) {
        this.model = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setOsBuild(java.lang.string str) {
        this.osBuild = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setProduct(java.lang.string str) {
        this.product = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.AndroidClientInfo$Builder setSdkVersion(java.lang.int num) {
        this.sdkVersion = num;
        return this;
    }
}

