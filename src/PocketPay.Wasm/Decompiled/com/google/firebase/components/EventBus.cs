namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class EventBus : com.google.firebase.events.Subscriber, com.google.firebase.events.Publisher {
    private readonly java.util.concurrent.Executor defaultExecutor;
    private readonly java.util.Dictionary<java.lang.Class<object>, java.util.concurrent.ConcurrentHashDictionary<com.google.firebase.events.EventHandler<java.lang.object>, java.util.concurrent.Executor>> handlerDictionary;
    private java.util.Queue<com.google.firebase.events.Event<object>> pendingEvents;

    EventBus(java.util.concurrent.Executor r2) {
            r1 = this;
            goto L24
        L4:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L38
        La:
            goto L27
        Ld:
            return
        Le:
            goto La
        L12:
            r1.handlerDictionary = r0
            goto L1e
        L18:
            r1.pendingEvents = r0
            goto L32
        L1e:
            java.util.ArrayQueue r0 = new java.util.ArrayQueue
            goto L2b
        L24:
            goto Le
        L27:
            goto L3f
        L2b:
            r0.<init>()
            goto L18
        L32:
            r1.defaultExecutor = r2
            goto Ld
        L38:
            r0.<init>()
            goto L12
        L3f:
            r1.<init>()
            goto L4
    }

    public static void ALLxlIUAppKpQXAC(java.util.Dictionary r0, java.lang.object r1, byte r2, bool r3, float r4, java.lang.string r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            goto L2c
        Ld:
            goto L22
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto L11
        L22:
            r0 = 42
            goto L4
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static void ALLxlIUAppKpQXAC(java.util.Dictionary r0, java.lang.object r1, float r2, bool r3, java.lang.string r4, byte r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L11
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            int r2 = r0 * r1
            goto L1c
    }

    public static void ALLxlIUAppKpQXAC(java.util.Dictionary r0, java.lang.object r1, java.lang.string r2, byte r3, float r4, bool r5) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            goto L26
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            r0 = 42
            goto L2a
        L19:
            return
        L1a:
            goto La
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            goto L1a
        L26:
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static bool ALLxlIUAppKpQXAC(java.util.Dictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.ContainsKey(r2)
            goto L7
    }

    public static void ASjJrzEoRTmbzsLP(com.google.firebase.components.EventBus r0, com.google.firebase.events.Event r1) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.publish(r1)
            goto L4
    }

    public static void ASjJrzEoRTmbzsLP(com.google.firebase.components.EventBus r0, com.google.firebase.events.Event r1, byte r2, java.lang.string r3, float r4, char r5) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L1a
        L15:
            return
        L16:
            goto L2d
        L1a:
            int r3 = r2 + r1
            goto La
        L20:
            r0 = 42
            goto L4
        L26:
            goto L16
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void ASjJrzEoRTmbzsLP(com.google.firebase.components.EventBus r0, com.google.firebase.events.Event r1, char r2, java.lang.string r3, float r4, byte r5) {
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L16:
            goto Lc
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L10
    }

    public static void ASjJrzEoRTmbzsLP(com.google.firebase.components.EventBus r0, com.google.firebase.events.Event r1, java.lang.string r2, byte r3, char r4, float r5) {
            goto Ld
        L4:
            r0 = 42
            goto L1e
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return
        L15:
            goto La
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void BtvomZwTybtXTxPU(java.util.Queue r0, java.lang.object r1, short r2, byte r3, char r4, bool r5) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r0 = 42
            goto L2a
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
        L19:
            int r3 = r2 + r1
            goto L25
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void BtvomZwTybtXTxPU(java.util.Queue r0, java.lang.object r1, bool r2, byte r3, short r4, char r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L20
        La:
            goto Le
        Le:
            r0 = 42
            goto L2a
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            return
        L20:
            goto L4
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void BtvomZwTybtXTxPU(java.util.Queue r0, java.lang.object r1, bool r2, short r3, char r4, byte r5) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L1c
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto Lb
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L21
    }

    public static bool BtvomZwTybtXTxPU(java.util.Queue r1, java.lang.object r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.Add(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void DMQFENxXwgSoEnzG(java.util.IEnumerator r0, byte r1, int r2, char r3, java.lang.string r4) {
            goto L4
        L4:
            goto L1a
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L24
        L11:
            goto L7
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto L11
        L1e:
            int r3 = r2 + r1
            goto L14
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void DMQFENxXwgSoEnzG(java.util.IEnumerator r0, int r1, byte r2, java.lang.string r3, char r4) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L16
        Ld:
            int r3 = r2 + r1
            goto L20
        L13:
            goto L2c
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            return
        L2c:
            goto La
    }

    public static void DMQFENxXwgSoEnzG(java.util.IEnumerator r0, java.lang.string r1, int r2, byte r3, char r4) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r0 = 42
            goto L2a
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
        L19:
            double r0 = (double) r3
            goto L4
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static bool DMQFENxXwgSoEnzG(java.util.IEnumerator r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.MoveNext()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.lang.object DddNWduxHExAPptE(java.lang.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = com.google.firebase.components.Preconditions.checkNotNull(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void DddNWduxHExAPptE(java.lang.object r0, char r1, short r2, int r3, bool r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L27
        Lb:
            int r3 = r2 + r1
            goto L11
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            int r2 = r0 * r1
            goto Lb
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L7
    }

    public static void DddNWduxHExAPptE(java.lang.object r0, int r1, short r2, char r3, bool r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L1e
        La:
            goto L12
        Ld:
            goto L24
        L11:
            return
        L12:
            goto L1b
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            goto Ld
        L1e:
            int r3 = r2 + r1
            goto L16
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void DddNWduxHExAPptE(java.lang.object r0, bool r1, char r2, short r3, int r4) {
            goto Lf
        L4:
            return
        L5:
            goto L1c
        L9:
            int r3 = r2 + r1
            goto L2b
        Lf:
            goto L5
        L12:
            goto L1f
        L16:
            int r2 = r0 * r1
            goto L9
        L1c:
            goto L12
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static java.lang.object ECcrqskCcauQkKvf(java.util.Dictionary r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1[r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void ECcrqskCcauQkKvf(java.util.Dictionary r0, java.lang.object r1, float r2, short r3, bool r4, java.lang.string r5) {
            goto L29
        L4:
            return
        L5:
            goto L1b
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L1e
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            goto L2c
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            r0 = 42
            goto L15
        L29:
            goto L5
        L2c:
            goto L23
    }

    public static void ECcrqskCcauQkKvf(java.util.Dictionary r0, java.lang.object r1, float r2, bool r3, short r4, java.lang.string r5) {
            goto L18
        L4:
            goto L1b
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L24
        L18:
            goto Le
        L1b:
            goto L12
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void ECcrqskCcauQkKvf(java.util.Dictionary r0, java.lang.object r1, bool r2, float r3, java.lang.string r4, short r5) {
            goto L16
        L4:
            int r3 = r2 + r1
            goto L1d
        La:
            r0 = 42
            goto L2a
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L26
        L19:
            goto La
        L1d:
            double r0 = (double) r3
            goto L25
        L22:
            goto L19
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static java.lang.object GgElmhxbvvmTiajJ(java.lang.object r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = com.google.firebase.components.Preconditions.checkNotNull(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void GgElmhxbvvmTiajJ(java.lang.object r0, byte r1, char r2, java.lang.string r3, int r4) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r0 = 42
            goto L2a
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            double r0 = (double) r3
            goto L25
        L1b:
            goto L26
        L1e:
            goto La
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static void GgElmhxbvvmTiajJ(java.lang.object r0, byte r1, java.lang.string r2, int r3, char r4) {
            goto L16
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L16:
            goto L26
        L19:
            goto La
        L1d:
            goto L19
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void GgElmhxbvvmTiajJ(java.lang.object r0, int r1, java.lang.string r2, byte r3, char r4) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            double r0 = (double) r3
            goto L16
        Lf:
            goto L17
        L12:
            goto L21
        L16:
            return
        L17:
            goto L27
        L1b:
            int r2 = r0 * r1
            goto L2a
        L21:
            r0 = 42
            goto L4
        L27:
            goto L12
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static java.lang.Class IWvGmziuveTYxsYu(com.google.firebase.events.Event r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.Class r0 = r1.getType()
            goto Lb
    }

    public static void IWvGmziuveTYxsYu(com.google.firebase.events.Event r0, char r1, java.lang.string r2, bool r3, short r4) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto L1d
        Ld:
            return
        Le:
            goto L4
        L12:
            double r0 = (double) r3
            goto Ld
        L17:
            r0 = 42
            goto L23
        L1d:
            int r3 = r2 + r1
            goto L12
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L29:
            goto Le
        L2c:
            goto L17
    }

    public static void IWvGmziuveTYxsYu(com.google.firebase.events.Event r0, char r1, bool r2, short r3, java.lang.string r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            goto L23
        L18:
            goto L27
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto L1c
        L2d:
            goto L18
    }

    public static void IWvGmziuveTYxsYu(com.google.firebase.events.Event r0, short r1, char r2, bool r3, java.lang.string r4) {
            goto L1b
        L4:
            r0 = 42
            goto Lf
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            goto L23
        L1e:
            goto L4
        L22:
            return
        L23:
            goto L2d
        L27:
            int r2 = r0 * r1
            goto L15
        L2d:
            goto L1e
    }

    public static void IpYCXfAuKzaxpZTC(com.google.firebase.events.EventHandler r0, com.google.firebase.events.Event r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.handle(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void IpYCXfAuKzaxpZTC(com.google.firebase.events.EventHandler r0, com.google.firebase.events.Event r1, byte r2, char r3, float r4, java.lang.string r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L13
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L10:
            goto L2c
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            r0 = 42
            goto La
        L1e:
            return
        L1f:
            goto L10
        L23:
            int r2 = r0 * r1
            goto L4
        L29:
            goto L1f
        L2c:
            goto L18
    }

    public static void IpYCXfAuKzaxpZTC(com.google.firebase.events.EventHandler r0, com.google.firebase.events.Event r1, char r2, byte r3, java.lang.string r4, float r5) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L15:
            goto L21
        L18:
            int r2 = r0 * r1
            goto L9
        L1e:
            goto L2c
        L21:
            goto L25
        L25:
            r0 = 42
            goto Lf
        L2b:
            return
        L2c:
            goto L15
    }

    public static void IpYCXfAuKzaxpZTC(com.google.firebase.events.EventHandler r0, com.google.firebase.events.Event r1, char r2, java.lang.string r3, float r4, byte r5) {
            goto L26
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L2d
        L14:
            r0 = 42
            goto L20
        L1a:
            int r2 = r0 * r1
            goto L9
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L26:
            goto L10
        L29:
            goto L14
        L2d:
            goto L29
    }

    public static java.lang.object JajwfFuDBLtYRXTq(java.lang.object r1) {
            goto Lf
        L4:
            java.lang.object r0 = com.google.firebase.components.Preconditions.checkNotNull(r1)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void JajwfFuDBLtYRXTq(java.lang.object r0, float r1, char r2, java.lang.string r3, short r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L17
        L11:
            r0 = 42
            goto L1d
        L17:
            int r3 = r2 + r1
            goto L26
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L23:
            goto L7
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L23
    }

    public static void JajwfFuDBLtYRXTq(java.lang.object r0, float r1, char r2, short r3, java.lang.string r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L2c
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            int r3 = r2 + r1
            goto La
        L29:
            goto L10
        L2c:
            goto L17
    }

    public static void JajwfFuDBLtYRXTq(java.lang.object r0, float r1, java.lang.string r2, short r3, char r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto L19
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L14:
            return
        L15:
            goto L4
        L19:
            r0 = 42
            goto Le
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L14
    }

    public static java.lang.object MOTCjPARltkbAusL(java.util.Dictionary.Entry r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.object r0 = r1.getValue()
            goto Lb
        L18:
            goto L7
    }

    public static void MOTCjPARltkbAusL(java.util.Dictionary.Entry r0, float r1, int r2, java.lang.string r3, short r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            goto L26
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto La
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1d:
            int r3 = r2 + r1
            goto Ld
        L23:
            goto L13
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L17
    }

    public static void MOTCjPARltkbAusL(java.util.Dictionary.Entry r0, short r1, int r2, float r3, java.lang.string r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L22
        La:
            goto L1e
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            int r2 = r0 * r1
            goto L4
        L2d:
            goto Ld
    }

    public static void MOTCjPARltkbAusL(java.util.Dictionary.Entry r0, short r1, java.lang.string r2, int r3, float r4) {
            goto L26
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L10:
            return
        L11:
            goto L2d
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            int r2 = r0 * r1
            goto L15
        L26:
            goto L11
        L29:
            goto L4
        L2d:
            goto L29
    }

    public static java.util.HashSet MqrTfXLLdVXmKywY(com.google.firebase.components.EventBus r1, com.google.firebase.events.Event r2) {
            goto Lc
        L4:
            java.util.HashSet r0 = r1.getHandlers(r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void MqrTfXLLdVXmKywY(com.google.firebase.components.EventBus r0, com.google.firebase.events.Event r1, int r2, java.lang.string r3, bool r4, char r5) {
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto L1c
        Lf:
            goto L5
        L12:
            goto L22
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1c:
            int r3 = r2 + r1
            goto L28
        L22:
            r0 = 42
            goto L16
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L12
    }

    public static void MqrTfXLLdVXmKywY(com.google.firebase.components.EventBus r0, com.google.firebase.events.Event r1, java.lang.string r2, int r3, char r4, bool r5) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            r0 = 42
            goto L12
        Lf:
            goto L1b
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            goto L26
        L1b:
            goto L9
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            return
        L26:
            goto Lf
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void MqrTfXLLdVXmKywY(com.google.firebase.components.EventBus r0, com.google.firebase.events.Event r1, bool r2, char r3, int r4, java.lang.string r5) {
            goto L16
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            goto L24
        L19:
            goto L4
        L1d:
            int r3 = r2 + r1
            goto L2b
        L23:
            return
        L24:
            goto L28
        L28:
            goto L19
        L2b:
            double r0 = (double) r3
            goto L23
    }

    public static java.util.HashSet SrvGWXXfmcdxdoIO(java.util.Dictionary r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.util.HashSet r0 = r1.entryHashSet()
            goto Lb
    }

    public static void SrvGWXXfmcdxdoIO(java.util.Dictionary r0, float r1, java.lang.string r2, short r3, int r4) {
            goto L4
        L4:
            goto L21
        L7:
            goto L14
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            goto L7
        L14:
            r0 = 42
            goto L1a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L20:
            return
        L21:
            goto L11
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void SrvGWXXfmcdxdoIO(java.util.Dictionary r0, float r1, short r2, java.lang.string r3, int r4) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        La:
            goto L10
        Ld:
            goto L27
        L10:
            goto L14
        L14:
            r0 = 42
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            int r2 = r0 * r1
            goto L1a
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void SrvGWXXfmcdxdoIO(java.util.Dictionary r0, java.lang.string r1, short r2, float r3, int r4) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L21
        La:
            return
        Lb:
            goto L27
        Lf:
            goto Lb
        L12:
            goto L2a
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1c:
            double r0 = (double) r3
            goto La
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L16
    }

    public static void TIfBxQHCcsqGFOYB(java.util.IEnumerator r0, int r1, float r2, char r3, bool r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L1b
        Lb:
            int r2 = r0 * r1
            goto L24
        L11:
            return
        L12:
            goto L21
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            r0 = 42
            goto L2a
        L21:
            goto L7
        L24:
            int r3 = r2 + r1
            goto L16
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static void TIfBxQHCcsqGFOYB(java.util.IEnumerator r0, int r1, float r2, bool r3, char r4) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            return
        Lb:
            goto L2d
        Lf:
            goto Lb
        L12:
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L22
        L1c:
            r0 = 42
            goto L27
        L22:
            double r0 = (double) r3
            goto La
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2d:
            goto L12
    }

    public static void TIfBxQHCcsqGFOYB(java.util.IEnumerator r0, bool r1, float r2, int r3, char r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L18
        L10:
            goto L21
        L13:
            return
        L14:
            goto L10
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1e:
            goto L14
        L21:
            goto La
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static bool TIfBxQHCcsqGFOYB(java.util.IEnumerator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.MoveNext()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void TLUoDQRasYLoZeAx(java.util.concurrent.ConcurrentHashDictionary r0, char r1, float r2, bool r3, java.lang.string r4) {
            goto Lc
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            goto Lf
        Lc:
            goto L20
        Lf:
            goto L19
        L13:
            int r3 = r2 + r1
            goto L4
        L19:
            r0 = 42
            goto L2a
        L1f:
            return
        L20:
            goto L9
        L24:
            int r2 = r0 * r1
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void TLUoDQRasYLoZeAx(java.util.concurrent.ConcurrentHashDictionary r0, java.lang.string r1, bool r2, float r3, char r4) {
            goto L12
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L15
        L12:
            goto L20
        L15:
            goto L2a
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            return
        L20:
            goto Lf
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r0 = 42
            goto L4
    }

    public static void TLUoDQRasYLoZeAx(java.util.concurrent.ConcurrentHashDictionary r0, bool r1, char r2, float r3, java.lang.string r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            return
        Lb:
            goto L26
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            int r2 = r0 * r1
            goto Lf
        L20:
            r0 = 42
            goto L4
        L26:
            goto L2c
        L29:
            goto Lb
        L2c:
            goto L20
    }

    public static bool TLUoDQRasYLoZeAx(java.util.concurrent.ConcurrentHashDictionary r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.Count == 0
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.object TYhfrRsQexqVZqxz(java.util.concurrent.ConcurrentHashDictionary r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.object r0 = r1.Remove(r2)
            goto L4
    }

    public static void TYhfrRsQexqVZqxz(java.util.concurrent.ConcurrentHashDictionary r0, java.lang.object r1, java.lang.string r2, char r3, bool r4, short r5) {
            goto L4
        L4:
            goto L21
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L25
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto Lb
        L1d:
            goto L7
        L20:
            return
        L21:
            goto L1d
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r0 = 42
            goto L11
    }

    public static void TYhfrRsQexqVZqxz(java.util.concurrent.ConcurrentHashDictionary r0, java.lang.object r1, short r2, java.lang.string r3, char r4, bool r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            goto L20
        Lc:
            goto L24
        L10:
            goto Lc
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L19:
            int r3 = r2 + r1
            goto L4
        L1f:
            return
        L20:
            goto L10
        L24:
            r0 = 42
            goto L13
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void TYhfrRsQexqVZqxz(java.util.concurrent.ConcurrentHashDictionary r0, java.lang.object r1, bool r2, java.lang.string r3, short r4, char r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            goto L12
        Ld:
            goto L21
        L11:
            return
        L12:
            goto L2d
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r2 = r0 * r1
            goto L27
        L21:
            r0 = 42
            goto L4
        L27:
            int r3 = r2 + r1
            goto L16
        L2d:
            goto Ld
    }

    public static void WZpwMcnkNUhoBDVz(java.util.Dictionary r0, java.lang.object r1, float r2, char r3, bool r4, java.lang.string r5) {
            goto La
        L4:
            r0 = 42
            goto L1a
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            int r3 = r2 + r1
            goto L26
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto L14
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L11
    }

    public static void WZpwMcnkNUhoBDVz(java.util.Dictionary r0, java.lang.object r1, float r2, java.lang.string r3, bool r4, char r5) {
            goto L13
        L4:
            goto L16
        L7:
            int r3 = r2 + r1
            goto L1a
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            goto L20
        L16:
            goto L24
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L4
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static void WZpwMcnkNUhoBDVz(java.util.Dictionary r0, java.lang.object r1, bool r2, java.lang.string r3, float r4, char r5) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L10:
            goto L27
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            int r2 = r0 * r1
            goto L1a
        L26:
            return
        L27:
            goto L17
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static bool WZpwMcnkNUhoBDVz(java.util.Dictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            bool r0 = r1.ContainsKey(r2)
            goto L4
    }

    public static java.lang.object ALyvoBmynySBsxRA(java.util.Dictionary.Entry r1) {
            goto Lc
        L4:
            java.lang.object r0 = r1.getKey()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void ALyvoBmynySBsxRA(java.util.Dictionary.Entry r0, char r1, byte r2, java.lang.string r3, float r4) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L1b
        L10:
            return
        L11:
            goto L2d
        L15:
            r0 = 42
            goto L20
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            goto L11
        L29:
            goto L15
        L2d:
            goto L29
    }

    public static void ALyvoBmynySBsxRA(java.util.Dictionary.Entry r0, char r1, java.lang.string r2, byte r3, float r4) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            return
        Lb:
            goto L1c
        Lf:
            goto Lb
        L12:
            goto L1f
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            goto L12
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void ALyvoBmynySBsxRA(java.util.Dictionary.Entry r0, float r1, byte r2, char r3, java.lang.string r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto Lf
        La:
            return
        Lb:
            goto L20
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r2 = r0 * r1
            goto L4
        L1a:
            r0 = 42
            goto L2a
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static java.lang.object DqcowqObLglffiuW(java.lang.object r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.object r0 = com.google.firebase.components.Preconditions.checkNotNull(r1)
            goto Lb
    }

    public static void DqcowqObLglffiuW(java.lang.object r0, java.lang.string r1, short r2, byte r3, bool r4) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            goto L21
        L19:
            goto La
        L1d:
            goto L19
        L20:
            return
        L21:
            goto L1d
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void DqcowqObLglffiuW(java.lang.object r0, bool r1, java.lang.string r2, byte r3, short r4) {
            goto L24
        L4:
            return
        L5:
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L18
        Lf:
            goto L27
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            r0 = 42
            goto L12
        L24:
            goto L5
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void DqcowqObLglffiuW(java.lang.object r0, bool r1, short r2, java.lang.string r3, byte r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0 = 42
            goto L1f
        L19:
            int r3 = r2 + r1
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static java.lang.object FDJAtxgHqUVOeXDA(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void FDJAtxgHqUVOeXDA(java.util.Dictionary r0, java.lang.object r1, java.lang.object r2, java.lang.string r3, byte r4, bool r5, char r6) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        La:
            double r0 = (double) r3
            goto L16
        Lf:
            goto L17
        L12:
            goto L1b
        L16:
            return
        L17:
            goto L2d
        L1b:
            r0 = 42
            goto L4
        L21:
            int r3 = r2 + r1
            goto La
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto L12
    }

    public static void FDJAtxgHqUVOeXDA(java.util.Dictionary r0, java.lang.object r1, java.lang.object r2, bool r3, char r4, java.lang.string r5, byte r6) {
            goto L1d
        L4:
            return
        L5:
            goto L14
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L20
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L5
        L20:
            goto L17
        L24:
            int r3 = r2 + r1
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void FDJAtxgHqUVOeXDA(java.util.Dictionary r0, java.lang.object r1, java.lang.object r2, bool r3, java.lang.string r4, char r5, byte r6) {
            goto L9
        L4:
            return
        L5:
            goto L1b
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            int r2 = r0 * r1
            goto L1e
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            goto Lc
        L1e:
            int r3 = r2 + r1
            goto L16
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L2a:
            r0 = 42
            goto L24
    }

    public static java.lang.object FQtRLDuRynzbBaZs(java.util.IEnumerator r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.Current
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void FQtRLDuRynzbBaZs(java.util.IEnumerator r0, byte r1, float r2, bool r3, int r4) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L17:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L1a
        L2b:
            return
        L2c:
            goto L17
    }

    public static void FQtRLDuRynzbBaZs(java.util.IEnumerator r0, byte r1, int r2, float r3, bool r4) {
            goto L1e
        L4:
            goto L21
        L7:
            double r0 = (double) r3
            goto L25
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L12:
            int r2 = r0 * r1
            goto L2a
        L18:
            r0 = 42
            goto Lc
        L1e:
            goto L26
        L21:
            goto L18
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L7
    }

    public static void FQtRLDuRynzbBaZs(java.util.IEnumerator r0, float r1, int r2, byte r3, bool r4) {
            goto L21
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            r0 = 42
            goto L10
        L21:
            goto L2c
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    private java.util.HashSet<java.util.Dictionary.Entry<com.google.firebase.events.EventHandler<java.lang.object>, java.util.concurrent.Executor>> GetHandlers(com.google.firebase.events.Event<object> r2) {
            r1 = this;
            goto L9
        L4:
            monitor-exit(r1)
            goto L31
        L9:
            goto L11
        Lc:
            goto L15
        L10:
            throw r2
        L11:
            goto L38
        L15:
            monitor-enter(r1)
            java.util.Dictionary<java.lang.Class<object>, java.util.concurrent.ConcurrentHashDictionary<com.google.firebase.events.EventHandler<java.lang.object>, java.util.concurrent.Executor>> r0 = r1.handlerDictionary     // Catch: java.lang.Exception -> L32
            java.lang.Class r2 = IWvGmziuveTYxsYu(r2)     // Catch: java.lang.Exception -> L32
            java.lang.object r2 = ECcrqskCcauQkKvf(r0, r2)     // Catch: java.lang.Exception -> L32
            java.util.Dictionary r2 = (java.util.Dictionary) r2     // Catch: java.lang.Exception -> L32
            if (r2 != 0) goto L29
            java.util.HashSet r2 = yeohVLrmXoCsXtuG()     // Catch: java.lang.Exception -> L32
            goto L2d
        L29:
            java.util.HashSet r2 = SrvGWXXfmcdxdoIO(r2)     // Catch: java.lang.Exception -> L32
        L2d:
            goto L4
        L31:
            return r2
        L32:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L32
            goto L10
        L38:
            goto Lc
    }

    private void GetHandlers(com.google.firebase.events.Event r1, float r2, char r3, bool r4, short r5) {
            r0 = this;
            goto L10
        L4:
            r0 = 42
            goto L27
        La:
            int r3 = r2 + r1
            goto L17
        L10:
            goto L23
        L13:
            goto L4
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            int r2 = r0 * r1
            goto La
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L2d:
            goto L13
    }

    private void GetHandlers(com.google.firebase.events.Event r1, short r2, char r3, bool r4, float r5) {
            r0 = this;
            goto La
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L26
        Ld:
            goto L1f
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L11
        L25:
            return
        L26:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    private void GetHandlers(com.google.firebase.events.Event r1, bool r2, float r3, short r4, char r5) {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto L1f
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            int r2 = r0 * r1
            goto L25
        L1f:
            r0 = 42
            goto Lb
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static java.lang.object HGSjTikjnjgkveng(java.util.concurrent.ConcurrentHashDictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
    }

    public static void HGSjTikjnjgkveng(java.util.concurrent.ConcurrentHashDictionary r0, java.lang.object r1, java.lang.object r2, char r3, short r4, bool r5, java.lang.string r6) {
            goto Le
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L5
        L11:
            goto L15
        L15:
            r0 = 42
            goto L1b
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L21:
            goto L11
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    public static void HGSjTikjnjgkveng(java.util.concurrent.ConcurrentHashDictionary r0, java.lang.object r1, java.lang.object r2, java.lang.string r3, char r4, short r5, bool r6) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            goto L26
        Ld:
            goto L1a
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            goto Ld
        L1a:
            r0 = 42
            goto L2a
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void HGSjTikjnjgkveng(java.util.concurrent.ConcurrentHashDictionary r0, java.lang.object r1, java.lang.object r2, short r3, java.lang.string r4, char r5, bool r6) {
            goto L9
        L4:
            return
        L5:
            goto L21
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            goto Lc
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L2a:
            r0 = 42
            goto L24
    }

    public static java.lang.object JRpuFeZFhdwwgQBw(java.util.Dictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.object r0 = r1[r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void JRpuFeZFhdwwgQBw(java.util.Dictionary r0, java.lang.object r1, float r2, byte r3, short r4, char r5) {
            goto L4
        L4:
            goto L20
        L7:
            goto L24
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            goto L7
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L1f:
            return
        L20:
            goto L16
        L24:
            r0 = 42
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void JRpuFeZFhdwwgQBw(java.util.Dictionary r0, java.lang.object r1, short r2, byte r3, float r4, char r5) {
            goto L13
        L4:
            r0 = 42
            goto L1f
        La:
            goto L16
        Ld:
            int r3 = r2 + r1
            goto L1a
        L13:
            goto L2c
        L16:
            goto L4
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto Ld
        L2b:
            return
        L2c:
            goto La
    }

    public static void JRpuFeZFhdwwgQBw(java.util.Dictionary r0, java.lang.object r1, short r2, float r3, char r4, byte r5) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r0 = 42
            goto L1a
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L27
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            goto L16
        L23:
            goto La
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static java.lang.object KUMpLUtwGsNuGFKS(java.util.IEnumerator r1) {
            goto L11
        L4:
            java.lang.object r0 = r1.Current
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void KUMpLUtwGsNuGFKS(java.util.IEnumerator r0, char r1, float r2, bool r3, short r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            return
        Lb:
            goto L21
        Lf:
            r0 = 42
            goto L4
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto L2b
        L21:
            goto L27
        L24:
            goto Lb
        L27:
            goto Lf
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void KUMpLUtwGsNuGFKS(java.util.IEnumerator r0, char r1, short r2, float r3, bool r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Lf:
            r0 = 42
            goto L9
        L15:
            goto L2c
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            return
        L25:
            goto L15
        L29:
            goto L25
        L2c:
            goto Lf
    }

    public static void KUMpLUtwGsNuGFKS(java.util.IEnumerator r0, char r1, bool r2, short r3, float r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L21
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            goto Lb
        L21:
            goto L25
        L25:
            r0 = 42
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void LYsykCARBmnIAuEf(com.google.firebase.components.EventBus r0, java.lang.Class r1, java.util.concurrent.Executor r2, com.google.firebase.events.EventHandler r3) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.subscribe(r1, r2, r3)
            goto L7
    }

    public static void LYsykCARBmnIAuEf(com.google.firebase.components.EventBus r0, java.lang.Class r1, java.util.concurrent.Executor r2, com.google.firebase.events.EventHandler r3, float r4, byte r5, char r6, java.lang.string r7) {
            goto L4
        L4:
            goto L29
        L7:
            goto L22
        Lb:
            double r0 = (double) r3
            goto L28
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L16:
            int r3 = r2 + r1
            goto Lb
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            r0 = 42
            goto L10
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L7
    }

    public static void LYsykCARBmnIAuEf(com.google.firebase.components.EventBus r0, java.lang.Class r1, java.util.concurrent.Executor r2, com.google.firebase.events.EventHandler r3, float r4, byte r5, java.lang.string r6, char r7) {
            goto L23
        L4:
            return
        L5:
            goto L20
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            goto L26
        L23:
            goto L5
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L9
    }

    public static void LYsykCARBmnIAuEf(com.google.firebase.components.EventBus r0, java.lang.Class r1, java.util.concurrent.Executor r2, com.google.firebase.events.EventHandler r3, java.lang.string r4, char r5, byte r6, float r7) {
            goto L1e
        L4:
            return
        L5:
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L18
        Lf:
            goto L21
        L12:
            r0 = 42
            goto L2a
        L18:
            int r3 = r2 + r1
            goto L25
        L1e:
            goto L5
        L21:
            goto L12
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    static /* synthetic */ void lambda$publish$0(java.util.Dictionary.Entry r0, com.google.firebase.events.Event r1) {
            goto L14
        L4:
            java.lang.object r0 = aLyvoBmynySBsxRA(r0)
            goto L22
        Lc:
            goto L17
        Lf:
            return
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
        L1b:
            IpYCXfAuKzaxpZTC(r0, r1)
            goto Lf
        L22:
            com.google.firebase.events.EventHandler r0 = (com.google.firebase.events.EventHandler) r0
            goto L1b
    }

    static /* synthetic */ void lambda$publish$0(java.util.Dictionary.Entry r0, com.google.firebase.events.Event r1, float r2, short r3, java.lang.string r4, int r5) {
            goto L23
        L4:
            r0 = 42
            goto L1d
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L26
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L23:
            goto L16
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto La
    }

    static /* synthetic */ void lambda$publish$0(java.util.Dictionary.Entry r0, com.google.firebase.events.Event r1, int r2, java.lang.string r3, float r4, short r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L1f
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            goto Lc
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2b:
            return
        L2c:
            goto L1c
    }

    static /* synthetic */ void lambda$publish$0(java.util.Dictionary.Entry r0, com.google.firebase.events.Event r1, int r2, java.lang.string r3, short r4, float r5) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0 = 42
            goto L24
        L19:
            double r0 = (double) r3
            goto Le
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void PTRnrpmoeTcyAehj(java.util.concurrent.Executor r0, java.lang.Action r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.execute(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void PTRnrpmoeTcyAehj(java.util.concurrent.Executor r0, java.lang.Action r1, int r2, byte r3, char r4, java.lang.string r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            r0 = 42
            goto L12
        Lf:
            goto L2c
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L18:
            int r3 = r2 + r1
            goto L4
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            return
        L25:
            goto Lf
        L29:
            goto L25
        L2c:
            goto L9
    }

    public static void PTRnrpmoeTcyAehj(java.util.concurrent.Executor r0, java.lang.Action r1, java.lang.string r2, byte r3, char r4, int r5) {
            goto L26
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            r0 = 42
            goto L20
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            return
        L1c:
            goto L2d
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L26:
            goto L1c
        L29:
            goto L9
        L2d:
            goto L29
    }

    public static void PTRnrpmoeTcyAehj(java.util.concurrent.Executor r0, java.lang.Action r1, java.lang.string r2, byte r3, int r4, char r5) {
            goto L19
        L4:
            goto L1c
        L7:
            r0 = 42
            goto L25
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            int r2 = r0 * r1
            goto Ld
        L19:
            goto L21
        L1c:
            goto L7
        L20:
            return
        L21:
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static java.lang.object TnpXCVszIyYRfknm(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = r1.Remove(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void TnpXCVszIyYRfknm(java.util.Dictionary r0, java.lang.object r1, char r2, float r3, java.lang.string r4, short r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L2c
        La:
            goto L20
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L14:
            int r2 = r0 * r1
            goto L1a
        L1a:
            int r3 = r2 + r1
            goto L26
        L20:
            r0 = 42
            goto Le
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    public static void TnpXCVszIyYRfknm(java.util.Dictionary r0, java.lang.object r1, char r2, float r3, short r4, java.lang.string r5) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L1a
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto Lf
        L26:
            goto L5
        L29:
            goto L9
        L2d:
            goto L29
    }

    public static void TnpXCVszIyYRfknm(java.util.Dictionary r0, java.lang.object r1, java.lang.string r2, short r3, char r4, float r5) {
            goto L4
        L4:
            goto L23
        L7:
            goto L27
        Lb:
            double r0 = (double) r3
            goto L22
        L10:
            int r3 = r2 + r1
            goto Lb
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto L1c
        L2d:
            goto L7
    }

    public static java.util.IEnumerator WWvWNfjhXTgmgEWh(java.util.HashSet r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L18:
            goto Lc
    }

    public static void WWvWNfjhXTgmgEWh(java.util.HashSet r0, float r1, byte r2, short r3, java.lang.string r4) {
            goto L24
        L4:
            r0 = 42
            goto L12
        La:
            goto L27
        Ld:
            return
        Le:
            goto La
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto Le
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void WWvWNfjhXTgmgEWh(java.util.HashSet r0, java.lang.string r1, byte r2, float r3, short r4) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r0 = 42
            goto L1a
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            goto L5
        L23:
            goto Le
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    public static void WWvWNfjhXTgmgEWh(java.util.HashSet r0, short r1, java.lang.string r2, byte r3, float r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r0 = 42
            goto L24
        L15:
            return
        L16:
            goto L21
        L1a:
            goto L16
        L1d:
            goto Lf
        L21:
            goto L1d
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static java.util.IEnumerator WXnrtlGDVKrFjmvC(java.util.Queue r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void WXnrtlGDVKrFjmvC(java.util.Queue r0, byte r1, bool r2, java.lang.string r3, short r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L20
        Ld:
            goto L2c
        L10:
            goto L1a
        L14:
            int r2 = r0 * r1
            goto L7
        L1a:
            r0 = 42
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L2b:
            return
        L2c:
            goto L4
    }

    public static void WXnrtlGDVKrFjmvC(java.util.Queue r0, short r1, bool r2, byte r3, java.lang.string r4) {
            goto L23
        L4:
            goto L26
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            double r0 = (double) r3
            goto L7
        L23:
            goto L8
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Lc
    }

    public static void WXnrtlGDVKrFjmvC(java.util.Queue r0, bool r1, java.lang.string r2, short r3, byte r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L21
        L13:
            goto L2a
        L17:
            goto L13
        L1a:
            int r3 = r2 + r1
            goto L25
        L20:
            return
        L21:
            goto L17
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r0 = 42
            goto La
    }

    public static java.lang.object XypLBdrvfWVMPsor(java.util.Dictionary r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1[r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void XypLBdrvfWVMPsor(java.util.Dictionary r0, java.lang.object r1, byte r2, char r3, float r4, java.lang.string r5) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            goto L10
        Ld:
            goto L1b
        L10:
            goto L1f
        L14:
            int r3 = r2 + r1
            goto L2b
        L1a:
            return
        L1b:
            goto La
        L1f:
            r0 = 42
            goto L4
        L25:
            int r2 = r0 * r1
            goto L14
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void XypLBdrvfWVMPsor(java.util.Dictionary r0, java.lang.object r1, float r2, byte r3, char r4, java.lang.string r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L17
        La:
            goto L23
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L2a
        L17:
            int r3 = r2 + r1
            goto L1d
        L1d:
            double r0 = (double) r3
            goto L22
        L22:
            return
        L23:
            goto L27
        L27:
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void XypLBdrvfWVMPsor(java.util.Dictionary r0, java.lang.object r1, java.lang.string r2, char r3, byte r4, float r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L27
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L21
    }

    public static java.lang.object YDINjhwgdUYLNJkY(java.lang.object r1) {
            goto L11
        L4:
            java.lang.object r0 = com.google.firebase.components.Preconditions.checkNotNull(r1)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void YDINjhwgdUYLNJkY(java.lang.object r0, char r1, int r2, bool r3, short r4) {
            goto L18
        L4:
            goto L1b
        L7:
            double r0 = (double) r3
            goto L1f
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L12:
            int r2 = r0 * r1
            goto L24
        L18:
            goto L20
        L1b:
            goto L2a
        L1f:
            return
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L7
        L2a:
            r0 = 42
            goto Lc
    }

    public static void YDINjhwgdUYLNJkY(java.lang.object r0, char r1, bool r2, short r3, int r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L21
        L18:
            r0 = 42
            goto La
        L1e:
            goto L26
        L21:
            goto L18
        L25:
            return
        L26:
            goto L15
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void YDINjhwgdUYLNJkY(java.lang.object r0, short r1, bool r2, char r3, int r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto L2c
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto Lf
        L22:
            int r3 = r2 + r1
            goto La
        L28:
            goto L18
        L2b:
            return
        L2c:
            goto L28
    }

    public static java.lang.object YIcEjWAUZeEdRUeD(java.lang.object r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = com.google.firebase.components.Preconditions.checkNotNull(r1)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void YIcEjWAUZeEdRUeD(java.lang.object r0, char r1, short r2, bool r3, int r4) {
            goto L10
        L4:
            r0 = 42
            goto L22
        La:
            int r3 = r2 + r1
            goto L17
        L10:
            goto L29
        L13:
            goto L4
        L17:
            double r0 = (double) r3
            goto L28
        L1c:
            int r2 = r0 * r1
            goto La
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    public static void YIcEjWAUZeEdRUeD(java.lang.object r0, int r1, bool r2, short r3, char r4) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            double r0 = (double) r3
            goto L22
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            goto L23
        L1e:
            goto L2a
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            r0 = 42
            goto La
    }

    public static void YIcEjWAUZeEdRUeD(java.lang.object r0, short r1, int r2, bool r3, char r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L23
        L13:
            goto L2a
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            return
        L23:
            goto L27
        L27:
            goto L13
        L2a:
            r0 = 42
            goto La
    }

    public static java.util.HashSet YeohVLrmXoCsXtuG() {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.util.HashSet r0 = java.util.ICollections.emptyHashSet()
            goto Lb
        L18:
            goto L7
    }

    public static void YeohVLrmXoCsXtuG(byte r0, int r1, float r2, char r3) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L23
        L1e:
            goto L15
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void YeohVLrmXoCsXtuG(float r0, char r1, int r2, byte r3) {
            goto L18
        L4:
            return
        L5:
            goto L9
        L9:
            goto L1b
        Lc:
            int r3 = r2 + r1
            goto L25
        L12:
            int r2 = r0 * r1
            goto Lc
        L18:
            goto L5
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L2a
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void YeohVLrmXoCsXtuG(int r0, float r1, byte r2, char r3) {
            goto L23
        L4:
            goto L26
        L7:
            r0 = 42
            goto L2a
        Ld:
            return
        Le:
            goto L4
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r2 = r0 * r1
            goto L12
        L23:
            goto Le
        L26:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    void enablePublishingAndFlushPending() {
            r2 = this;
            goto L56
        L4:
            r1 = 28
            goto L4a
        Lb:
            throw r0
        Lc:
            goto L10
        L10:
            goto L77
        L13:
            goto L93
        L17:
            goto L7f
        L18:
            goto L3c
        L1c:
            java.lang.object r1 = fQtRLDuRynzbBaZs(r0)
            goto L66
        L24:
            if (r0 <= 0) goto L29
            goto L77
        L29:
            goto L74
        L2d:
            monitor-enter(r2)
            java.util.Queue<com.google.firebase.events.Event<object>> r0 = r2.pendingEvents     // Catch: java.lang.Exception -> L3d
            r1 = 0
            if (r0 == 0) goto L36
            r2.pendingEvents = r1     // Catch: java.lang.Exception -> L3d
            goto L37
        L36:
            r0 = r1
        L37:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L3d
            goto L5d
        L3c:
            return
        L3d:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L3d
            goto Lb
        L43:
            ASjJrzEoRTmbzsLP(r2, r1)
            goto L17
        L4a:
            int r0 = r0 + r1
            goto L50
        L50:
            int r0 = r0 % r1
            goto L24
        L56:
            goto L13
        L59:
            goto L83
        L5d:
            if (r0 != 0) goto L62
            goto L18
        L62:
            goto L7b
        L66:
            com.google.firebase.events.Event r1 = (com.google.firebase.events.Event) r1
            goto L43
        L6c:
            bool r1 = DMQFENxXwgSoEnzG(r0)
            goto L8a
        L74:
            goto Lc
        L77:
            goto L2d
        L7b:
            java.util.IEnumerator r0 = wXnrtlGDVKrFjmvC(r0)
        L7f:
            goto L6c
        L83:
            r0 = 15
            goto L4
        L8a:
            if (r1 != 0) goto L8f
            goto L18
        L8f:
            goto L1c
        L93:
            goto L59
    }

    @Override // com.google.firebase.events.Publisher
    public void Publish(com.google.firebase.events.Event<object> r4) {
            r3 = this;
            goto La9
        L4:
            return
        L5:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L5
            goto L36
        Lb:
            java.lang.object r1 = MOTCjPARltkbAusL(r0)
            goto L3b
        L13:
            java.util.HashSet r3 = MqrTfXLLdVXmKywY(r3, r4)
            goto L5e
        L1b:
            com.google.firebase.components.EventBus$$ExternalSyntheticLambda0 r2 = new com.google.firebase.components.EventBus$$ExternalSyntheticLambda0
            goto L21
        L21:
            r2.<init>(r0, r4)
            goto Lb0
        L28:
            r1 = 8
            goto L58
        L2f:
            goto L96
        L32:
            goto L47
        L36:
            throw r4
        L37:
            goto L2f
        L3b:
            java.util.concurrent.Executor r1 = (java.util.concurrent.Executor) r1
            goto L1b
        L41:
            java.util.Dictionary$Entry r0 = (java.util.Dictionary.Entry) r0
            goto Lb
        L47:
            goto Lac
        L4a:
            if (r0 <= 0) goto L4f
            goto L96
        L4f:
            goto L93
        L53:
            goto L62
        L54:
            goto L4
        L58:
            int r0 = r0 + r1
            goto L66
        L5e:
            java.util.IEnumerator r3 = wWvWNfjhXTgmgEWh(r3)
        L62:
            goto L9a
        L66:
            int r0 = r0 % r1
            goto L4a
        L6c:
            r0 = 30
            goto L28
        L73:
            java.lang.object r0 = kUMpLUtwGsNuGFKS(r3)
            goto L41
        L7b:
            monitor-enter(r3)
            java.util.Queue<com.google.firebase.events.Event<object>> r0 = r3.pendingEvents     // Catch: java.lang.Exception -> L5
            if (r0 == 0) goto L85
            BtvomZwTybtXTxPU(r0, r4)     // Catch: java.lang.Exception -> L5
            monitor-exit(r3)     // Catch: java.lang.Exception -> L5
            return
        L85:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L5
            goto L13
        L8a:
            if (r0 != 0) goto L8f
            goto L54
        L8f:
            goto L73
        L93:
            goto L37
        L96:
            goto La2
        L9a:
            bool r0 = TIfBxQHCcsqGFOYB(r3)
            goto L8a
        La2:
            yDINjhwgdUYLNJkY(r4)
            goto L7b
        La9:
            goto L32
        Lac:
            goto L6c
        Lb0:
            pTRnrpmoeTcyAehj(r1, r2)
            goto L53
    }

    @Override // com.google.firebase.events.Subscriber
    public <T> void Subscribe(java.lang.Class<T> r2, com.google.firebase.events.EventHandler<T> r3) {
            r1 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L1c
        La:
            goto L15
        Le:
            lYsykCARBmnIAuEf(r1, r2, r0, r3)
            goto L1b
        L15:
            java.util.concurrent.Executor r0 = r1.defaultExecutor
            goto Le
        L1b:
            return
        L1c:
            goto L4
    }

    @Override // com.google.firebase.events.Subscriber
    public <T> void Subscribe(java.lang.Class<T> r3, java.util.concurrent.Executor r4, com.google.firebase.events.EventHandler<T> r5) {
            r2 = this;
            goto L4c
        L4:
            r1 = 19
            goto L72
        Lb:
            goto L5b
        Le:
            goto L12
        L12:
            monitor-enter(r2)
            yIcEjWAUZeEdRUeD(r3)     // Catch: java.lang.Exception -> L54
            DddNWduxHExAPptE(r5)     // Catch: java.lang.Exception -> L54
            dqcowqObLglffiuW(r4)     // Catch: java.lang.Exception -> L54
            java.util.Dictionary<java.lang.Class<object>, java.util.concurrent.ConcurrentHashDictionary<com.google.firebase.events.EventHandler<java.lang.object>, java.util.concurrent.Executor>> r0 = r2.handlerDictionary     // Catch: java.lang.Exception -> L54
            bool r0 = ALLxlIUAppKpQXAC(r0, r3)     // Catch: java.lang.Exception -> L54
            if (r0 != 0) goto L2e
            java.util.Dictionary<java.lang.Class<object>, java.util.concurrent.ConcurrentHashDictionary<com.google.firebase.events.EventHandler<java.lang.object>, java.util.concurrent.Executor>> r0 = r2.handlerDictionary     // Catch: java.lang.Exception -> L54
            java.util.concurrent.ConcurrentHashDictionary r1 = new java.util.concurrent.ConcurrentHashDictionary     // Catch: java.lang.Exception -> L54
            r1.<init>()     // Catch: java.lang.Exception -> L54
            fDJAtxgHqUVOeXDA(r0, r3, r1)     // Catch: java.lang.Exception -> L54
        L2e:
            java.util.Dictionary<java.lang.Class<object>, java.util.concurrent.ConcurrentHashDictionary<com.google.firebase.events.EventHandler<java.lang.object>, java.util.concurrent.Executor>> r0 = r2.handlerDictionary     // Catch: java.lang.Exception -> L54
            java.lang.object r3 = jRpuFeZFhdwwgQBw(r0, r3)     // Catch: java.lang.Exception -> L54
            java.util.concurrent.ConcurrentHashDictionary r3 = (java.util.concurrent.ConcurrentHashDictionary) r3     // Catch: java.lang.Exception -> L54
            hGSjTikjnjgkveng(r3, r5, r4)     // Catch: java.lang.Exception -> L54
            goto L66
        L3d:
            int r0 = r0 % r1
            goto L43
        L43:
            if (r0 <= 0) goto L48
            goto Le
        L48:
            goto Lb
        L4c:
            goto L6e
        L4f:
            goto L5f
        L53:
            return
        L54:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L54
            goto L5a
        L5a:
            throw r3
        L5b:
            goto L6b
        L5f:
            r0 = 28
            goto L4
        L66:
            monitor-exit(r2)
            goto L53
        L6b:
            goto Le
        L6e:
            goto L78
        L72:
            int r0 = r0 + r1
            goto L3d
        L78:
            goto L4f
    }

    @Override // com.google.firebase.events.Subscriber
    public <T> void Unsubscribe(java.lang.Class<T> r2, com.google.firebase.events.EventHandler<T> r3) {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L17
        Lb:
            throw r2
        Lc:
            goto L51
        L10:
            return
        L11:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L11
            goto Lb
        L17:
            monitor-enter(r1)
            JajwfFuDBLtYRXTq(r2)     // Catch: java.lang.Exception -> L11
            GgElmhxbvvmTiajJ(r3)     // Catch: java.lang.Exception -> L11
            java.util.Dictionary<java.lang.Class<object>, java.util.concurrent.ConcurrentHashDictionary<com.google.firebase.events.EventHandler<java.lang.object>, java.util.concurrent.Executor>> r0 = r1.handlerDictionary     // Catch: java.lang.Exception -> L11
            bool r0 = WZpwMcnkNUhoBDVz(r0, r2)     // Catch: java.lang.Exception -> L11
            goto L43
        L28:
            return
        L29:
            java.util.Dictionary<java.lang.Class<object>, java.util.concurrent.ConcurrentHashDictionary<com.google.firebase.events.EventHandler<java.lang.object>, java.util.concurrent.Executor>> r0 = r1.handlerDictionary     // Catch: java.lang.Exception -> L11
            java.lang.object r0 = xypLBdrvfWVMPsor(r0, r2)     // Catch: java.lang.Exception -> L11
            java.util.concurrent.ConcurrentHashDictionary r0 = (java.util.concurrent.ConcurrentHashDictionary) r0     // Catch: java.lang.Exception -> L11
            TYhfrRsQexqVZqxz(r0, r3)     // Catch: java.lang.Exception -> L11
            bool r3 = TLUoDQRasYLoZeAx(r0)     // Catch: java.lang.Exception -> L11
            if (r3 == 0) goto L3f
            java.util.Dictionary<java.lang.Class<object>, java.util.concurrent.ConcurrentHashDictionary<com.google.firebase.events.EventHandler<java.lang.object>, java.util.concurrent.Executor>> r3 = r1.handlerDictionary     // Catch: java.lang.Exception -> L11
            tnpXCVszIyYRfknm(r3, r2)     // Catch: java.lang.Exception -> L11
        L3f:
            goto L4c
        L43:
            if (r0 == 0) goto L48
            goto L29
        L48:
            goto L54
        L4c:
            monitor-exit(r1)
            goto L10
        L51:
            goto L7
        L54:
            monitor-exit(r1)
            goto L28
    }
}

