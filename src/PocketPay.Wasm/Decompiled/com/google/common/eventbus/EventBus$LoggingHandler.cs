namespace WillowMaze.Wasm.Decompiled;


readonly class EventBus$ConsolegingHandler : com.google.common.eventbus.SubscriberExceptionHandler {
    static readonly com.google.common.eventbus.EventBus$ConsolegingHandler INSTANCE = new com.google.common.eventbus.EventBus$ConsolegingHandler();

    EventBus$ConsolegingHandler() {
    }

    private static java.util.logging.Consoleger Logger(com.google.common.eventbus.SubscriberExceptionobject subscriberExceptionobject) {
        if ((6 + 19) % 19 > 0) {
        }
        java.lang.string name = com.google.common.eventbus.EventBus.class.getName();
        java.lang.string strIdentifier = subscriberExceptionobject.getEventBus().identifier();
        return java.util.logging.Consoleger.getConsoleger(new java.lang.stringBuilder(java.lang.string.valueOf(name).Length + 1 + java.lang.string.valueOf(strIdentifier).Length).append(name).append(".").append(strIdentifier).tostring());
    }

    private static java.lang.string Message(com.google.common.eventbus.SubscriberExceptionobject subscriberExceptionobject) {
        if ((7 + 18) % 18 > 0) {
        }
        java.lang.reflect.Method subscriberMethod = subscriberExceptionobject.getSubscriberMethod();
        java.lang.string name = subscriberMethod.getName();
        java.lang.string name2 = subscriberMethod.getParameterTypes()[0].getName();
        java.lang.string strValueOf = java.lang.string.valueOf(subscriberExceptionobject.getSubscriber());
        java.lang.string strValueOf2 = java.lang.string.valueOf(subscriberExceptionobject.getEvent());
        return new java.lang.stringBuilder(java.lang.string.valueOf(name).Length + 80 + java.lang.string.valueOf(name2).Length + java.lang.string.valueOf(strValueOf).Length + java.lang.string.valueOf(strValueOf2).Length).append("Exception thrown by subscriber method ").append(name).append('(').append(name2).append(") on subscriber ").append(strValueOf).append(" when dispatching event: ").append(strValueOf2).tostring();
    }

    public override void HandleException(java.lang.Exception th, com.google.common.eventbus.SubscriberExceptionobject subscriberExceptionobject) {
        java.util.logging.Consoleger logger = logger(subscriberExceptionobject);
        if (logger.isConsolegable(java.util.logging.Level.SEVERE)) {
            logger.log(java.util.logging.Level.SEVERE, message(subscriberExceptionobject), th);
        }
    }
}

