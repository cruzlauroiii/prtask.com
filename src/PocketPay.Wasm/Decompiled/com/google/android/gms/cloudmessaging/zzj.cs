namespace WillowMaze.Wasm.Decompiled;


public readonly class zzj : java.lang.Action {
    public readonly com.google.android.gms.cloudmessaging.zzp zza;

    public zzj(com.google.android.gms.cloudmessaging.zzp zzpVar) {
        this.zza = zzpVar;
    }

    public static java.lang.string AOTpPIrtWdkkzmML(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static android.os.Message HKpSOmxatvxRCfmI() {
        return android.os.Message.obtain();
    }

    public static void MZwrvnyRvtoqeNqz(com.google.android.gms.cloudmessaging.zzq zzqVar, android.os.Message message) throws android.os.RemoteException {
        zzqVar.zza(message);
    }

    public static void REkGiWJxneAoxbnr(com.google.android.gms.cloudmessaging.zzp zzpVar) {
        zzpVar.zzf();
    }

    public static bool SBStxSdcGLZxRgrA(com.google.android.gms.cloudmessaging.zzs zzsVar) {
        return zzsVar.zzb();
    }

    public static void UIfszsIDrHgwLCBu(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.string WaZxuuuhRMPfRKkw(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static android.content.object YRlbSUlgcpGGpPzw(com.google.android.gms.cloudmessaging.zzv zzvVar) {
        return com.google.android.gms.cloudmessaging.zzv.zza(zzvVar);
    }

    public static void ZGwzXEySxyuRsYLH(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void CmdyoZCULChZhenR(android.os.Message message, android.os.Dictionary<string, object> bundle) {
        message.setData(bundle);
    }

    public static java.lang.string GIkLbMSlxzCswVMI(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void IcuwGqLlLYSfbatq(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2) {
        bundle.putDictionary<string, object>(str, bundle2);
    }

    public static java.lang.string KQvIbgURuqyzdxFu(android.content.object context) {
        return context.getPackageName();
    }

    public static bool MKdsDeuePnpdozct(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static java.lang.string NeRztCNKQQJjYVCt(android.os.RemoteException remoteException) {
        return remoteException.getMessage();
    }

    public static java.util.concurrent.ScheduledTask OXQTcOvzrXuSuSxN(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(runnable, j, timeUnit);
    }

    public static java.lang.object VOMrWkexrIzmYHYO(java.util.Queue queue) {
        return queue.poll();
    }

    public static int WUYBtbLRsNqvCwdp(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool WqSDuZykMaHDEths(java.util.Queue queue) {
        return queue.Count == 0;
    }

    public static void WzAEBxvzdwjGOIIP(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        bundle.putbool(str, z);
    }

    public static void XgBZHwACRWwFfYXw(com.google.android.gms.cloudmessaging.zzp zzpVar, int i, java.lang.string str) {
        zzpVar.zza(i, str);
    }

    public static java.util.concurrent.ScheduledTaskScheduler XtnbkwMNVkreYmUJ(com.google.android.gms.cloudmessaging.zzv zzvVar) {
        return com.google.android.gms.cloudmessaging.zzv.zze(zzvVar);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override readonly void Run() {
        /*
            Method dump skipped, instruction units count: 378
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.android.gms.cloudmessaging.zzj.run():void");
    }
}

