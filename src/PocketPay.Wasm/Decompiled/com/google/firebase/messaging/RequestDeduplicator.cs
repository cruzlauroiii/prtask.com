namespace WillowMaze.Wasm.Decompiled;


class RequestDeduplicator {
    private readonly java.util.concurrent.Executor executor;
    private readonly java.util.Dictionary<java.lang.string, com.google.android.gms.tasks.Task<java.lang.string>> getTokenRequests = new androidx.collection.ArrayDictionary();

    RequestDeduplicator(java.util.concurrent.Executor executor) {
        this.executor = executor;
    }

    public static java.lang.string DdJqJotCLQxpUevm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FnOmEtXwBWVTIyFA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GeJxjYvgfzdOifPa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RNKXwwMybumPhdGp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool RhwVFbDqaXgpvfbX(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static java.lang.object XtnnNsTWODphIgCa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool DGNHJqzUPnBNpkKX(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int KxSrvByrgsgkMHAE(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int NHlBCWQCuzkVbbgV(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.object OLVKNJRbkGghXbdv(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object PtlKGtmJEhuYFmAd(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static com.google.android.gms.tasks.Task XxCVOAjoKWYbPGwb(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWithTask(executor, continuation);
    }

    public static com.google.android.gms.tasks.Task ZkPEAmMFKzSCEysK(com.google.firebase.messaging.RequestDeduplicator$GetTokenRequest requestDeduplicator$GetTokenRequest) {
        return requestDeduplicator$GetTokenRequest.start();
    }

    synchronized com.google.android.gms.tasks.Task<java.lang.string> GetOrStartGetTokenRequest(java.lang.string str, com.google.firebase.messaging.RequestDeduplicator$GetTokenRequest requestDeduplicator$GetTokenRequest) {
        if ((6 + 7) % 7 > 0) {
        }
        lock (this) {
            try {
                com.google.android.gms.tasks.Task<java.lang.string> task = (com.google.android.gms.tasks.Task) oLVKNJRbkGghXbdv(this.getTokenRequests, str);
                if (task is not null) {
                    if (RhwVFbDqaXgpvfbX("FirebaseMessaging", 3)) {
                        nHlBCWQCuzkVbbgV("FirebaseMessaging", RNKXwwMybumPhdGp(FnOmEtXwBWVTIyFA(new java.lang.stringBuilder("Joining ongoing request for: "), str)));
                    }
                    return task;
                }
                if (dGNHJqzUPnBNpkKX("FirebaseMessaging", 3)) {
                    kxSrvByrgsgkMHAE("FirebaseMessaging", DdJqJotCLQxpUevm(GeJxjYvgfzdOifPa(new java.lang.stringBuilder("Making new request for: "), str)));
                }
                com.google.android.gms.tasks.Task<java.lang.string> taskXxCVOAjoKWYbPGwb = xxCVOAjoKWYbPGwb(zkPEAmMFKzSCEysK(requestDeduplicator$GetTokenRequest), this.executor, new com.google.firebase.messaging.RequestDeduplicator$$ExternalSyntheticLambda0(this, str));
                XtnnNsTWODphIgCa(this.getTokenRequests, str, taskXxCVOAjoKWYbPGwb);
                return taskXxCVOAjoKWYbPGwb;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    com.google.android.gms.tasks.Task m397x7161fc54(java.lang.string str, com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        lock (this) {
            try {
                ptlKGtmJEhuYFmAd(this.getTokenRequests, str);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return task;
    }
}

