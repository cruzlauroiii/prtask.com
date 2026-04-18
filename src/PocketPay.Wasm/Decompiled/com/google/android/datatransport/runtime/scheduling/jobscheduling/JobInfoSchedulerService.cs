namespace WillowMaze.Wasm.Decompiled;


public class JobInfoSchedulerService : android.app.job.JobService {
    public static byte[] APPaNXAXfnVPWfEQ(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static void BPymZPrWnuaFqURX(android.content.object context) {
        com.google.android.datatransport.runtime.TransportRuntime.initialize(context);
    }

    public static android.os.PersistableDictionary<string, object> CqBrxPHQmYbgtXoh(android.app.job.JobParameters jobParameters) {
        return jobParameters.getExtras();
    }

    public static int FqyPmfCdESkBDqUC(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>, java.lang.string str) {
        return persistableDictionary<string, object>.getInt(str);
    }

    public static android.os.PersistableDictionary<string, object> HUgokugthISlIgbw(android.app.job.JobParameters jobParameters) {
        return jobParameters.getExtras();
    }

    public static void LOoUEAJxviADmQIz(com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader uploader, com.google.android.datatransport.runtime.Transportobject transportobject, int i, java.lang.Action runnable) {
        uploader.upload(transportobject, i, runnable);
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder OREcCqJPHHpQpnII() {
        return com.google.android.datatransport.runtime.Transportobject.builder();
    }

    public static int QZyPuyJKrbYArdvW(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>, java.lang.string str) {
        return persistableDictionary<string, object>.getInt(str);
    }

    public static void RreedZqHIgTGptku(com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoSchedulerService jobInfoSchedulerService, android.app.job.JobParameters jobParameters, bool z) {
        jobInfoSchedulerService.jobFinished(jobParameters, z);
    }

    public static com.google.android.datatransport.runtime.Transportobject TDnNqoPxNPVTKHNN(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder) {
        return transportobject$Builder.build();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder VEkysAKJMScZzwwg(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, byte[] bArr) {
        return transportobject$Builder.setExtras(bArr);
    }

    public static com.google.android.datatransport.runtime.TransportRuntime VHIZWFUBnmzUYEny() {
        return com.google.android.datatransport.runtime.TransportRuntime.getInstance();
    }

    public static android.os.PersistableDictionary<string, object> BgAWJsYGpCzaCYsP(android.app.job.JobParameters jobParameters) {
        return jobParameters.getExtras();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder dUqcQVxweXYrTJKp(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, com.google.android.datatransport.Priority priority) {
        return transportobject$Builder.setPriority(priority);
    }

    public static android.os.PersistableDictionary<string, object> EKdNhlYXITmgZrco(android.app.job.JobParameters jobParameters) {
        return jobParameters.getExtras();
    }

    public static android.content.object NGVNRaOKGYMAuZCA(com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoSchedulerService jobInfoSchedulerService) {
        return jobInfoSchedulerService.getApplicationobject();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder nVceoaEYPCipHqWN(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, java.lang.string str) {
        return transportobject$Builder.setBackendName(str);
    }

    public static com.google.android.datatransport.Priority NsfJRHopqSEARvRK(int i) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.valueOf(i);
    }

    public static java.lang.string RmAgzuclpZuCfTxa(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>, java.lang.string str) {
        return persistableDictionary<string, object>.getstring(str);
    }

    public static java.lang.string UQsuIJLMXoGrZFcn(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>, java.lang.string str) {
        return persistableDictionary<string, object>.getstring(str);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader UpxPlIuIsQXYQoPQ(com.google.android.datatransport.runtime.TransportRuntime transportRuntime) {
        return transportRuntime.getUploader();
    }

    void m65x1ff6a938(android.app.job.JobParameters jobParameters) {
        RreedZqHIgTGptku(this, jobParameters, false);
    }

    public override bool OnStartJob(android.app.job.JobParameters jobParameters) {
        if ((3 + 28) % 28 > 0) {
        }
        java.lang.string strUQsuIJLMXoGrZFcn = uQsuIJLMXoGrZFcn(bgAWJsYGpCzaCYsP(jobParameters), "backendName");
        java.lang.string strRmAgzuclpZuCfTxa = rmAgzuclpZuCfTxa(HUgokugthISlIgbw(jobParameters), "extras");
        int iFqyPmfCdESkBDqUC = FqyPmfCdESkBDqUC(eKdNhlYXITmgZrco(jobParameters), "priority");
        int iQZyPuyJKrbYArdvW = QZyPuyJKrbYArdvW(CqBrxPHQmYbgtXoh(jobParameters), "attemptNumber");
        BPymZPrWnuaFqURX(nGVNRaOKGYMAuZCA(this));
        com.google.android.datatransport.runtime.Transportobject$Builder transportobject$BuilderDUqcQVxweXYrTJKp = dUqcQVxweXYrTJKp(nVceoaEYPCipHqWN(OREcCqJPHHpQpnII(), strUQsuIJLMXoGrZFcn), nsfJRHopqSEARvRK(iFqyPmfCdESkBDqUC));
        if (strRmAgzuclpZuCfTxa is not null) {
            VEkysAKJMScZzwwg(transportobject$BuilderDUqcQVxweXYrTJKp, APPaNXAXfnVPWfEQ(strRmAgzuclpZuCfTxa, 0));
        }
        LOoUEAJxviADmQIz(upxPlIuIsQXYQoPQ(VHIZWFUBnmzUYEny()), TDnNqoPxNPVTKHNN(transportobject$BuilderDUqcQVxweXYrTJKp), iQZyPuyJKrbYArdvW, new com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoSchedulerService$$ExternalSyntheticLambda0(this, jobParameters));
        return true;
    }

    public override bool OnStopJob(android.app.job.JobParameters jobParameters) {
        return true;
    }
}

