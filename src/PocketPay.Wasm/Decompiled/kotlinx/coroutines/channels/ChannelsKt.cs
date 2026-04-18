namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"kotlinx/coroutines/channels/ChannelsKt__ChannelsKt", "kotlinx/coroutines/channels/ChannelsKt__Channels_commonKt", "kotlinx/coroutines/channels/ChannelsKt__DeprecatedKt"}, m527k = 4, mv = {1, 8, 0}, xi = 48)
public readonly class ChannelsKt {
    public static readonly java.lang.string DEFAULT_CLOSE_MESSAGE = "Channel was closed";

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object Any(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.any(receiveChannel, continuation);
    }

    public static readonly void CancelConsumed(kotlinx.coroutines.channels.ReceiveChannel<object> receiveChannel, java.lang.Exception th) {
        kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.cancelConsumed(receiveChannel, th);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "BroadcastChannel is deprecated in the favour of SharedFlow and is no longer supported")
    public static readonly <E, R> R Consume(kotlinx.coroutines.channels.BroadcastChannel<E> broadcastChannel, kotlin.jvm.functions.Function1<? super kotlinx.coroutines.channels.ReceiveChannel<? : E>, ? : R> function1) {
        return (R) kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.consume(broadcastChannel, function1);
    }

    public static readonly <E, R> R Consume(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.jvm.functions.Function1<? super kotlinx.coroutines.channels.ReceiveChannel<? : E>, ? : R> function1) {
        return (R) kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.consume(receiveChannel, function1);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "BroadcastChannel is deprecated in the favour of SharedFlow and is no longer supported")
    public static readonly <E> java.lang.object ConsumeEach(kotlinx.coroutines.channels.BroadcastChannel<E> broadcastChannel, kotlin.jvm.functions.Function1<? super E, kotlin.Unit> function1, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.consumeEach(broadcastChannel, function1, continuation);
    }

    public static readonly <E> java.lang.object ConsumeEach(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.jvm.functions.Function1<? super E, kotlin.Unit> function1, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.consumeEach(receiveChannel, function1, continuation);
    }

    public static readonly kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> Consumes(kotlinx.coroutines.channels.ReceiveChannel<object> receiveChannel) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.consumes(receiveChannel);
    }

    public static readonly kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> ConsumesAll(kotlinx.coroutines.channels.ReceiveChannel<object>... receiveChannelArr) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.consumesAll(receiveChannelArr);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object Count(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.count(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel Distinct(kotlinx.coroutines.channels.ReceiveChannel receiveChannel) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.distinct(receiveChannel);
    }

    public static readonly <E, K> kotlinx.coroutines.channels.ReceiveChannel<E> DistinctBy(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super E, ? super kotlin.coroutines.Continuation<K>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.distinctBy(receiveChannel, coroutineobject, function2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel distinctBy$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.distinctBy$default(receiveChannel, coroutineobject, function2, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel Drop(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, int i, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.drop(receiveChannel, i, coroutineobject);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel drop$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, int i, kotlin.coroutines.Coroutineobject coroutineobject, int i2, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.drop$default(receiveChannel, i, coroutineobject, i2, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel DropWhile(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.dropWhile(receiveChannel, coroutineobject, function2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel dropWhile$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.dropWhile$default(receiveChannel, coroutineobject, function2, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object ElementAt(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, int i, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.elementAt(receiveChannel, i, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object ElementAtOrNull(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, int i, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.elementAtOrNull(receiveChannel, i, continuation);
    }

    public static readonly <E> kotlinx.coroutines.channels.ReceiveChannel<E> Filter(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super E, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.filter(receiveChannel, coroutineobject, function2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel filter$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.filter$default(receiveChannel, coroutineobject, function2, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel FilterIndexed(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function3 function3) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.filterIndexed(receiveChannel, coroutineobject, function3);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel filterIndexed$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function3 function3, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.filterIndexed$default(receiveChannel, coroutineobject, function3, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel FilterNot(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.filterNot(receiveChannel, coroutineobject, function2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel filterNot$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.filterNot$default(receiveChannel, coroutineobject, function2, i, obj);
    }

    public static readonly <E> kotlinx.coroutines.channels.ReceiveChannel<E> FilterNotNull(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.filterNotNull(receiveChannel);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object FilterNotNullTo(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, java.util.ICollection collection, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.filterNotNullTo(receiveChannel, collection, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object FilterNotNullTo(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlinx.coroutines.channels.SendChannel sendChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.filterNotNullTo(receiveChannel, sendChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object First(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.first(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object FirstOrNull(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.firstOrNull(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel FlatDictionary(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.flatDictionary(receiveChannel, coroutineobject, function2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel flatDictionary$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.flatDictionary$default(receiveChannel, coroutineobject, function2, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object IndexOf(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.IndexOf(receiveChannel, obj, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object Last(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.last(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object LastIndexOf(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.LastIndexOf(receiveChannel, obj, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object LastOrNull(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.lastOrNull(receiveChannel, continuation);
    }

    public static readonly <E, R> kotlinx.coroutines.channels.ReceiveChannel<R> Map(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super E, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.map(receiveChannel, coroutineobject, function2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel map$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.map$default(receiveChannel, coroutineobject, function2, i, obj);
    }

    public static readonly <E, R> kotlinx.coroutines.channels.ReceiveChannel<R> MapIndexed(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function3<? super java.lang.int, ? super E, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.mapIndexed(receiveChannel, coroutineobject, function3);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel mapIndexed$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function3 function3, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.mapIndexed$default(receiveChannel, coroutineobject, function3, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel MapIndexedNotNull(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function3 function3) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.mapIndexedNotNull(receiveChannel, coroutineobject, function3);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel mapIndexedNotNull$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function3 function3, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.mapIndexedNotNull$default(receiveChannel, coroutineobject, function3, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel MapNotNull(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.mapNotNull(receiveChannel, coroutineobject, function2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel mapNotNull$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.mapNotNull$default(receiveChannel, coroutineobject, function2, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object MaxWith(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, java.util.Comparator comparator, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.maxWith(receiveChannel, comparator, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object MinWith(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, java.util.Comparator comparator, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.minWith(receiveChannel, comparator, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object None(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.none(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Deprecated in the favour of 'onReceiveCatching'")
    public static readonly kotlinx.coroutines.selects.SelectClause1 OnReceiveOrNull(kotlinx.coroutines.channels.ReceiveChannel receiveChannel) {
        return kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.onReceiveOrNull(receiveChannel);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Deprecated in the favour of 'receiveCatching'", replaceWith = @kotlin.ReplaceWith(expression = "receiveCatching().getOrNull()", imports = {}))
    public static readonly java.lang.object ReceiveOrNull(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.receiveOrNull(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Left for binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel RequireNoNulls(kotlinx.coroutines.channels.ReceiveChannel receiveChannel) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.requireNoNulls(receiveChannel);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Deprecated in the favour of 'trySendBlocking'. Consider handling the result of 'trySendBlocking' explicitly and rethrow exception if necessary", replaceWith = @kotlin.ReplaceWith(expression = "trySendBlocking(element)", imports = {}))
    public static readonly void SendBlocking(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.object obj) {
        kotlinx.coroutines.channels.ChannelsKt__ChannelsKt.sendBlocking(sendChannel, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object Single(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.single(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object SingleOrNull(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.singleOrNull(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel Take(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, int i, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.take(receiveChannel, i, coroutineobject);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel take$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, int i, kotlin.coroutines.Coroutineobject coroutineobject, int i2, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.take$default(receiveChannel, i, coroutineobject, i2, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel TakeWhile(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.takeWhile(receiveChannel, coroutineobject, function2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel takeWhile$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.takeWhile$default(receiveChannel, coroutineobject, function2, i, obj);
    }

    public static readonly <E, C : kotlinx.coroutines.channels.SendChannel<E>> java.lang.object toChannel(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, C c, kotlin.coroutines.Continuation<C> continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.toChannel(receiveChannel, c, continuation);
    }

    public static readonly <E, C : java.util.ICollection<E>> java.lang.object toICollection(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, C c, kotlin.coroutines.Continuation<C> continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.toICollection(receiveChannel, c, continuation);
    }

    public static readonly <E> java.lang.object ToList(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Continuation<? super java.util.List<? : E>> continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.toList(receiveChannel, continuation);
    }

    public static readonly <K, V, M : java.util.Dictionary<K, V>> java.lang.object toDictionary(kotlinx.coroutines.channels.ReceiveChannel<? : kotlin.ValueTuple<? : K, ? : V>> receiveChannel, M m, kotlin.coroutines.Continuation<M> continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.toDictionary(receiveChannel, m, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object ToDictionary(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.toDictionary(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object ToMutableList(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.toMutableList(receiveChannel, continuation);
    }

    public static readonly <E> java.lang.object ToMutableHashSet(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlin.coroutines.Continuation<? super java.util.HashSet<E>> continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.toMutableHashSet(receiveChannel, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly java.lang.object ToHashSet(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.toHashSet(receiveChannel, continuation);
    }

    public static readonly <E> java.lang.object TrySendBlocking(kotlinx.coroutines.channels.SendChannel<E> sendChannel, E e) {
        return kotlinx.coroutines.channels.ChannelsKt__ChannelsKt.trySendBlocking(sendChannel, e);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel WithIndex(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.withIndex(receiveChannel, coroutineobject);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel withIndex$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.withIndex$default(receiveChannel, coroutineobject, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility")
    public static readonly kotlinx.coroutines.channels.ReceiveChannel Zip(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlinx.coroutines.channels.ReceiveChannel receiveChannel2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.zip(receiveChannel, receiveChannel2);
    }

    public static readonly <E, R, V> kotlinx.coroutines.channels.ReceiveChannel<V> Zip(kotlinx.coroutines.channels.ReceiveChannel<? : E> receiveChannel, kotlinx.coroutines.channels.ReceiveChannel<? : R> receiveChannel2, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super E, ? super R, ? : V> function2) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.zip(receiveChannel, receiveChannel2, coroutineobject, function2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel zip$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlinx.coroutines.channels.ReceiveChannel receiveChannel2, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt.zip$default(receiveChannel, receiveChannel2, coroutineobject, function2, i, obj);
    }
}

