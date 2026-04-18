namespace WillowMaze.Wasm.Decompiled;


class ServiceManager$ServiceManagerState$1 : com.google.common.base.Function<java.util.Dictionary$Entry<com.google.common.util.concurrent.Service, java.lang.long>, java.lang.long> {
    ServiceManager$ServiceManagerState$1(com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState) {
    }

    public java.lang.long Apply2(java.util.Dictionary$Entry<com.google.common.util.concurrent.Service, java.lang.long> map$Entry) {
        return map$Entry.getValue();
    }

    public override java.lang.long Apply(java.util.Dictionary$Entry<com.google.common.util.concurrent.Service, java.lang.long> map$Entry) {
        return apply2(map$Entry);
    }
}

