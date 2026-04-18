namespace WillowMaze.Wasm.Decompiled;


public class CustomSignals$Builder {
    private java.util.Dictionary<java.lang.string, java.lang.string> customSignals = new java.util.HashDictionary();

    public static java.lang.object SAVFemrOMhhmILok(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object WGSCwJKmHOVpaayE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    static java.util.Dictionary access$000(com.google.firebase.remoteconfig.CustomSignals$Builder customSignals$Builder) {
        return customSignals$Builder.customSignals;
    }

    public static java.lang.string CbulHzzkuybjFyPd(long j) {
        return java.lang.long.tostring(j);
    }

    public static java.lang.string MlOpWmMEhOkMNYko(double d) {
        return java.lang.double.tostring(d);
    }

    public static java.lang.object NkCpcAAluchWIeGv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public com.google.firebase.remoteconfig.CustomSignals Build() {
        return new com.google.firebase.remoteconfig.CustomSignals(this);
    }

    public com.google.firebase.remoteconfig.CustomSignals$Builder put(java.lang.string str, double d) {
        SAVFemrOMhhmILok(this.customSignals, str, mlOpWmMEhOkMNYko(d));
        return this;
    }

    public com.google.firebase.remoteconfig.CustomSignals$Builder put(java.lang.string str, long j) {
        nkCpcAAluchWIeGv(this.customSignals, str, cbulHzzkuybjFyPd(j));
        return this;
    }

    public com.google.firebase.remoteconfig.CustomSignals$Builder put(java.lang.string str, java.lang.string str2) {
        WGSCwJKmHOVpaayE(this.customSignals, str, str2);
        return this;
    }
}

