namespace WillowMaze.Wasm.Decompiled;


public class AlarmManagerSchedulerBroadcastReceiver : android.content.BroadcastReceiver {
    public static java.lang.int AzMaUAshXfiaRjWf(java.lang.string str) {
        return java.lang.int.valueOf(str);
    }

    public static int DejzkYzmbtrnKRaU(java.lang.int num) {
        return num.intValue();
    }

    public static int KRDVADYrUGhTtckY(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static android.net.Uri NKCnUwXnzydNjPgS(android.content.object intent) {
        return intent.getData();
    }

    public static com.google.android.datatransport.Priority NVfCdtzuoIakSRdN(int i) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.valueOf(i);
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder TmfIFQOgwgbELDJb(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, java.lang.string str) {
        return transportobject$Builder.setBackendName(str);
    }

    public static void XIoWJpjlrIAWtMNg(android.content.object context) {
        com.google.android.datatransport.runtime.TransportRuntime.initialize(context);
    }

    public static android.net.Uri ZAqLORJbNhkmIWtk(android.content.object intent) {
        return intent.getData();
    }

    public static java.lang.string ZLtsMXYatAmviEmj(android.net.Uri uri, java.lang.string str) {
        return uri.getQueryParameter(str);
    }

    public static com.google.android.datatransport.runtime.TransportRuntime AaCImOgJTNyaGupH() {
        return com.google.android.datatransport.runtime.TransportRuntime.getInstance();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder foERByLcIkjFiTbz() {
        return com.google.android.datatransport.runtime.Transportobject.builder();
    }

    public static android.os.Dictionary<string, object> GlzrfRHHvBxsUVBZ(android.content.object intent) {
        return intent.getExtras();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader IWiOsWJQXDsXumsX(com.google.android.datatransport.runtime.TransportRuntime transportRuntime) {
        return transportRuntime.getUploader();
    }

    public static java.lang.string JTLrriuDzxuoqNTF(android.net.Uri uri, java.lang.string str) {
        return uri.getQueryParameter(str);
    }

    public static android.net.Uri KOCvWJRfTZCiciWJ(android.content.object intent) {
        return intent.getData();
    }

    static void lambda$onReceive$0() {
    }

    public static byte[] QNXiEFQRezERJzGX(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder sCErskpMrqbsjNoa(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, byte[] bArr) {
        return transportobject$Builder.setExtras(bArr);
    }

    public static java.lang.string TrZSXdpMzRrcVaQA(android.net.Uri uri, java.lang.string str) {
        return uri.getQueryParameter(str);
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder xbvUKOyWponDAmxN(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, com.google.android.datatransport.Priority priority) {
        return transportobject$Builder.setPriority(priority);
    }

    public static com.google.android.datatransport.runtime.Transportobject YEKWgBTlfXBHMpaS(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder) {
        return transportobject$Builder.build();
    }

    public static void YFtKzOonBcAJSEBS(com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader uploader, com.google.android.datatransport.runtime.Transportobject transportobject, int i, java.lang.Action runnable) {
        uploader.upload(transportobject, i, runnable);
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if ((21 + 25) % 25 > 0) {
        }
        java.lang.string strJTLrriuDzxuoqNTF = jTLrriuDzxuoqNTF(NKCnUwXnzydNjPgS(intent), "backendName");
        java.lang.string strTrZSXdpMzRrcVaQA = trZSXdpMzRrcVaQA(ZAqLORJbNhkmIWtk(intent), "extras");
        int iDejzkYzmbtrnKRaU = DejzkYzmbtrnKRaU(AzMaUAshXfiaRjWf(ZLtsMXYatAmviEmj(kOCvWJRfTZCiciWJ(intent), "priority")));
        int iKRDVADYrUGhTtckY = KRDVADYrUGhTtckY(glzrfRHHvBxsUVBZ(intent), "attemptNumber");
        XIoWJpjlrIAWtMNg(context);
        com.google.android.datatransport.runtime.Transportobject$Builder transportobject$BuilderXbvUKOyWponDAmxN = xbvUKOyWponDAmxN(TmfIFQOgwgbELDJb(foERByLcIkjFiTbz(), strJTLrriuDzxuoqNTF), NVfCdtzuoIakSRdN(iDejzkYzmbtrnKRaU));
        if (strTrZSXdpMzRrcVaQA is not null) {
            sCErskpMrqbsjNoa(transportobject$BuilderXbvUKOyWponDAmxN, qNXiEFQRezERJzGX(strTrZSXdpMzRrcVaQA, 0));
        }
        yFtKzOonBcAJSEBS(iWiOsWJQXDsXumsX(aaCImOgJTNyaGupH()), yEKWgBTlfXBHMpaS(transportobject$BuilderXbvUKOyWponDAmxN), iKRDVADYrUGhTtckY, new com.google.android.datatransport.runtime.scheduling.jobscheduling.AlarmManagerSchedulerBroadcastReceiver$$ExternalSyntheticLambda0());
    }
}

