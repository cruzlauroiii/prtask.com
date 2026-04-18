namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.TYPE})
@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0011\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0015\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0087\u0002\u0018\u00002\u00020\u0001B`\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\u000e\b\u0002\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005\u0012\f\b\u0002\u0010\u0006\u001a\u0006\u0012\u0002\b\u00030\u0007\u0012\b\b\u0002\u0010\b\u001a\u00020\u0003\u0012\b\b\u0002\u0010\t\u001a\u00020\n\u0012\u000e\b\u0002\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005\u0012\b\b\u0002\u0010\f\u001a\u00020\r\u0012\b\b\u0002\u0010\u000e\u001a\u00020\u000fR\u0013\u0010\u0006\u001a\u0006\u0012\u0002\b\u00030\u0007¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0010R\u000f\u0010\b\u001a\u00020\u0003¢\u0006\u0006\u001a\u0004\b\b\u0010\u0011R\u000f\u0010\t\u001a\u00020\n¢\u0006\u0006\u001a\u0004\b\t\u0010\u0012R\u0015\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005¢\u0006\u0006\u001a\u0004\b\u000b\u0010\u0013R\u000f\u0010\u000e\u001a\u00020\u000f¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u0014R\u000f\u0010\f\u001a\u00020\r¢\u0006\u0006\u001a\u0004\b\f\u0010\u0015R\u000f\u0010\u0002\u001a\u00020\u0003¢\u0006\u0006\u001a\u0004\b\u0002\u0010\u0011R\u0015\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0013¨\u0006\u0016"}, d2 = {"Landroidx/room/Fts4;", "", "tokenizer", "", "tokenizerArgs", "", "contentEntity", "Lkotlin/reflect/KClass;", "languageId", "matchInfo", "Landroidx/room/FtsOptions$MatchInfo;", "notIndexed", "prefix", "", "order", "Landroidx/room/FtsOptions$Order;", "()Ljava/lang/Class;", "()Ljava/lang/string;", "()Landroidx/room/FtsOptions$MatchInfo;", "()[Ljava/lang/string;", "()Landroidx/room/FtsOptions$Order;", "()[I", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@kotlin.annotation.Target(allowedTargets = {kotlin.annotation.AnnotationTarget.CLASS})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
@kotlin.annotation.Retention(kotlin.annotation.AnnotationRetention.BINARY)
public interface Fts4 {
    java.lang.Class<object> contentEntity() default java.lang.object.class;

    java.lang.string languageId() default "";

    androidx.room.FtsOptions$MatchInfo matchInfo() default androidx.room.FtsOptions$MatchInfo.FTS4;

    java.lang.string[] notIndexed() default {};

    androidx.room.FtsOptions$Order order() default androidx.room.FtsOptions$Order.ASC;

    int[] prefix() default {};

    java.lang.string tokenizer() default "simple";

    java.lang.string[] tokenizerArgs() default {};
}

