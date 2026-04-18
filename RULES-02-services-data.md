# PrTask — Rules Part 2: Services & Data (Rules 231–360)

# PrTask — Rules Part 2: Services & Data (Rules 231–360)

231. AI WASM client services â€” WssInferenceService and WssVectorSearchService in PrTask.Client.Services implement IInferenceService and IVectorSearchService for Blazor WASM. Registered as scoped in Client Program.cs. Use AiConstants JSON property constants for response parsing. All AI operations via WSS messages.

232. AiConstants JSON properties â€” AiConstants extended with JsonEmbedding, JsonCompletion, JsonModelLoaded, JsonResults, JsonCount, JsonStatus, JsonText for type-safe JSON property access in client services (satisfies PT005).

233. WebSocketEndpoints â€” Server-side WebSocket handler at root path (`/`), no `/ws` path. WebSocketEndpoints.cs accepts WebSocket upgrade with WssConstants.ProtocolName sub-protocol at root, handles query/mutation/subscription message types, broadcasts mutations to subscribed channels, manages per-connection channel tracking with cleanup on disconnect. Program.cs enables app.UseWebSockets() middleware and maps App.MapWebSocketEndpoint() at root. Uses ConcurrentDictionary for thread-safe channel management.