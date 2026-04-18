# Repo Conversion Report: Native .NET PrTask Infrastructure

Generated: 2026-03-20

---

## 1. chrome-devtools-mcp (v0.20.2)

**Source**: `C:\work\chrome-devtools-mcp`
**License**: Apache-2.0 (Google LLC)
**Architecture**: MCP server wrapping Puppeteer (which uses CDP under the hood). Tools are registered via `defineTool`/`definePageTool` pattern with Zod schemas. Single-threaded with a `Mutex` ensuring one tool runs at a time. Browser managed via `puppeteer.launch()` or `puppeteer.connect()`.

### 1.1 All Tools (31 total)

#### Navigation (8 tools)

| Source Tool | Parameters | CDP Domains | Target .NET Class |
|---|---|---|---|
| `list_pages` | (none) | Target.getTargets | `CdpPageService.ListPages()` |
| `select_page` | `pageId: number, bringToFront?: bool` | Target.activateTarget | `CdpPageService.SelectPage()` |
| `close_page` | `pageId: number` | Target.closeTarget | `CdpPageService.ClosePage()` |
| `new_page` | `url: string, background?: bool, isolatedContext?: string, timeout?: number` | Target.createTarget, Page.navigate | `CdpPageService.NewPage()` |
| `navigate_page` | `type?: 'url'\|'back'\|'forward'\|'reload', url?: string, ignoreCache?: bool, handleBeforeUnload?: 'accept'\|'decline', initScript?: string, timeout?: number` | Page.navigate, Page.navigateToHistoryEntry, Page.reload, Page.addScriptToEvaluateOnNewDocument | `CdpPageService.NavigatePage()` |
| `wait_for` | `text: string[], timeout?: number` | Runtime.evaluate (polling) | `CdpPageService.WaitFor()` |
| `resize_page` | `width: number, height: number` | Browser.getWindowBounds, Browser.setWindowBounds, Emulation.setDeviceMetricsOverride | `CdpPageService.ResizePage()` |
| `get_tab_id` | `pageId: number` | (internal Puppeteer _tabId) | `CdpPageService.GetTabId()` |

#### Input (10 tools)

| Source Tool | Parameters | CDP Domains | Target .NET Class |
|---|---|---|---|
| `click` | `uid: string, dblClick?: bool, includeSnapshot?: bool` | DOM.resolveNode, Input.dispatchMouseEvent | `CdpInputService.Click()` |
| `click_at` | `x: number, y: number, dblClick?: bool, includeSnapshot?: bool` | Input.dispatchMouseEvent | `CdpInputService.ClickAt()` |
| `hover` | `uid: string, includeSnapshot?: bool` | DOM.resolveNode, Input.dispatchMouseEvent | `CdpInputService.Hover()` |
| `fill` | `uid: string, value: string, includeSnapshot?: bool` | DOM.resolveNode, Input.dispatchKeyEvent, DOM.focus | `CdpInputService.Fill()` |
| `fill_form` | `elements: [{uid, value}], includeSnapshot?: bool` | DOM.resolveNode, Input.dispatchKeyEvent (batch) | `CdpInputService.FillForm()` |
| `type_text` | `text: string, submitKey?: string` | Input.dispatchKeyEvent | `CdpInputService.TypeText()` |
| `press_key` | `key: string, includeSnapshot?: bool` | Input.dispatchKeyEvent | `CdpInputService.PressKey()` |
| `drag` | `from_uid: string, to_uid: string, includeSnapshot?: bool` | Input.dispatchDragEvent, Input.dispatchMouseEvent | `CdpInputService.Drag()` |
| `upload_file` | `uid: string, filePath: string, includeSnapshot?: bool` | DOM.setFileInputFiles | `CdpInputService.UploadFile()` |
| `handle_dialog` | `action: 'accept'\|'dismiss', promptText?: string` | Page.handleJavaScriptDialog | `CdpInputService.HandleDialog()` |

#### Debugging/Snapshot (6 tools)

| Source Tool | Parameters | CDP Domains | Target .NET Class |
|---|---|---|---|
| `take_snapshot` | `verbose?: bool, filePath?: string` | Accessibility.getFullAXTree | `CdpSnapshotService.TakeSnapshot()` |
| `take_screenshot` | `format?: 'png'\|'jpeg'\|'webp', quality?: number, uid?: string, fullPage?: bool, filePath?: string` | Page.captureScreenshot | `CdpSnapshotService.TakeScreenshot()` |
| `evaluate_script` | `function: string, args?: string[], serviceWorkerId?: string` | Runtime.evaluate, Runtime.callFunctionOn | `CdpScriptService.EvaluateScript()` |
| `list_console_messages` | `pageSize?: number, pageIdx?: number, types?: string[], includePreservedMessages?: bool` | Runtime.consoleAPICalled, Log.entryAdded | `CdpConsoleService.ListConsoleMessages()` |
| `get_console_message` | `msgid: number` | (from cached messages) | `CdpConsoleService.GetConsoleMessage()` |
| `lighthouse_audit` | `mode?: 'navigation'\|'snapshot', device?: 'desktop'\|'mobile', outputDirPath?: string` | (full Lighthouse via Puppeteer page) | `CdpLighthouseService.LighthouseAudit()` |

#### Network (2 tools)

| Source Tool | Parameters | CDP Domains | Target .NET Class |
|---|---|---|---|
| `list_network_requests` | `pageSize?: number, pageIdx?: number, resourceTypes?: string[], includePreservedRequests?: bool` | Network.requestWillBeSent, Network.responseReceived | `CdpNetworkService.ListNetworkRequests()` |
| `get_network_request` | `reqid?: number, requestFilePath?: string, responseFilePath?: string` | Network.getRequestPostData, Network.getResponseBody | `CdpNetworkService.GetNetworkRequest()` |

#### Performance (3 tools)

| Source Tool | Parameters | CDP Domains | Target .NET Class |
|---|---|---|---|
| `performance_start_trace` | `reload?: bool, autoStop?: bool, filePath?: string` | Tracing.start, Page.navigate | `CdpPerformanceService.StartTrace()` |
| `performance_stop_trace` | `filePath?: string` | Tracing.end, Tracing.tracingComplete | `CdpPerformanceService.StopTrace()` |
| `performance_analyze_insight` | `insightSetId: string, insightName: string` | (post-processing of trace data via DevTools frontend) | `CdpPerformanceService.AnalyzeInsight()` |

#### Emulation (1 tool)

| Source Tool | Parameters | CDP Domains | Target .NET Class |
|---|---|---|---|
| `emulate` | `networkConditions?: string, cpuThrottlingRate?: number, geolocation?: string, userAgent?: string, colorScheme?: string, viewport?: string` | Network.emulateNetworkConditions, Emulation.setCPUThrottlingRate, Emulation.setGeolocationOverride, Emulation.setUserAgentOverride, Emulation.setEmulatedMedia, Emulation.setDeviceMetricsOverride | `CdpEmulationService.Emulate()` |

#### Memory (1 tool)

| Source Tool | Parameters | CDP Domains | Target .NET Class |
|---|---|---|---|
| `take_memory_snapshot` | `filePath: string` | HeapProfiler.takeHeapSnapshot | `CdpMemoryService.TakeMemorySnapshot()` |

#### Screencast (2 tools)

| Source Tool | Parameters | CDP Domains | Target .NET Class |
|---|---|---|---|
| `screencast_start` | `path?: string` | Page.startScreencast (via Puppeteer screencast) | `CdpScreencastService.StartScreencast()` |
| `screencast_stop` | (none) | Page.stopScreencast | `CdpScreencastService.StopScreencast()` |

#### Extensions (5 tools)

| Source Tool | Parameters | CDP Domains | Target .NET Class |
|---|---|---|---|
| `install_extension` | `path: string` | (Puppeteer extension load via --load-extension) | `CdpExtensionService.InstallExtension()` |
| `uninstall_extension` | `id: string` | (browser context manipulation) | `CdpExtensionService.UninstallExtension()` |
| `list_extensions` | (none) | (internal registry) | `CdpExtensionService.ListExtensions()` |
| `reload_extension` | `id: string` | (reinstall from path) | `CdpExtensionService.ReloadExtension()` |
| `trigger_extension_action` | `id: string` | Extensions.triggerAction | `CdpExtensionService.TriggerExtensionAction()` |

#### Slim Mode (3 tools - simplified subset)

| Source Tool | Parameters | Target .NET Class |
|---|---|---|
| `screenshot` (slim) | (none) | `CdpSlimService.Screenshot()` |
| `navigate` (slim) | `url: string` | `CdpSlimService.Navigate()` |
| `evaluate` (slim) | `script: string` | `CdpSlimService.Evaluate()` |

### 1.2 CDP Domains Used

| CDP Domain | Commands Used |
|---|---|
| **Page** | navigate, reload, captureScreenshot, handleJavaScriptDialog, addScriptToEvaluateOnNewDocument, removeScriptToEvaluateOnNewDocument, startScreencast, stopScreencast |
| **Runtime** | evaluate, callFunctionOn, consoleAPICalled |
| **DOM** | resolveNode, setFileInputFiles, focus, getDocument |
| **Input** | dispatchMouseEvent, dispatchKeyEvent, dispatchDragEvent |
| **Network** | emulateNetworkConditions, requestWillBeSent, responseReceived, getRequestPostData, getResponseBody |
| **Emulation** | setDeviceMetricsOverride, setCPUThrottlingRate, setGeolocationOverride, setUserAgentOverride, setEmulatedMedia |
| **Tracing** | start, end, tracingComplete |
| **HeapProfiler** | takeHeapSnapshot |
| **Accessibility** | getFullAXTree |
| **Target** | getTargets, createTarget, closeTarget, activateTarget |
| **Browser** | getWindowBounds, setWindowBounds |
| **Log** | entryAdded |
| **Audits** | enable, disable |
| **Extensions** | triggerAction |

### 1.3 Dependencies Needing .NET Equivalents

| JS Dependency | Purpose | .NET Equivalent |
|---|---|---|
| `puppeteer` (24.39.1) | Browser automation via CDP | Direct CDP WebSocket client (System.Net.WebSockets) |
| `lighthouse` (13.0.3) | Web audits | In-process lighthouse (see Section 3) |
| `@modelcontextprotocol/sdk` (1.27.1) | MCP server protocol | Custom MCP host or direct tool invocation |
| `chrome-devtools-frontend` | Trace parsing / CrUX / insights | Port `DevTools.PerformanceTraceFormatter` |
| `zod` | Schema validation | System.ComponentModel.DataAnnotations or FluentValidation |
| `debug` | Logging | Microsoft.Extensions.Logging |

### 1.4 Target .NET Project Structure

```
PrTask.Infrastructure.Cdp/
  Services/
    CdpConnectionService.cs    -- WebSocket connection to Chrome
    CdpPageService.cs          -- Page navigation, tabs, resize
    CdpInputService.cs         -- Click, fill, type, drag, key, dialog
    CdpSnapshotService.cs      -- A11y tree snapshot, screenshot
    CdpScriptService.cs        -- JS evaluation
    CdpConsoleService.cs       -- Console message collection
    CdpNetworkService.cs       -- Network request interception
    CdpPerformanceService.cs   -- Trace start/stop/analyze
    CdpEmulationService.cs     -- Device/network/geo emulation
    CdpMemoryService.cs        -- Heap snapshots
    CdpScreencastService.cs    -- Video recording
    CdpExtensionService.cs     -- Extension management
    CdpLighthouseService.cs    -- In-process Lighthouse audit
  Protocol/
    CdpMessage.cs              -- JSON message types
    CdpDomain.cs               -- Domain command/event definitions
```

---

## 2. OpenClaw (v2026.3.14)

**Source**: `C:\work\openclaw`
**License**: MIT
**Architecture**: Multi-channel AI gateway with plugin SDK. Hono-based HTTP server, WebSocket gateway, CLI (Commander). Plugin system with channel plugins (Telegram, Discord, Slack, WhatsApp, etc.) and provider plugins (OpenAI, Anthropic, Google, etc.). Sessions managed with SQLite (sqlite-vec). Agent framework with ACP (Agent Client Protocol) support.

### 2.1 Core Architecture Layers

#### Gateway Server (`src/gateway/`)
The central hub that:
- Manages WebSocket connections (`server.ts`, `client.ts`)
- Routes messages between channels and AI providers
- Handles authentication (API keys, tokens, device pairing)
- Manages sessions and conversation history
- Runs cron jobs, hooks, and plugins

| Source Module | Purpose | Target .NET Class |
|---|---|---|
| `server.ts` | Main gateway server | `OpenClawGatewayService.cs` |
| `client.ts` | WebSocket client handler | `OpenClawClientService.cs` |
| `auth.ts` | Authentication middleware | `OpenClawAuthService.cs` |
| `boot.ts` | Server initialization | `OpenClawBootService.cs` |
| `credentials.ts` | Credential management | `OpenClawCredentialService.cs` |
| `server-channels.ts` | Channel management | `OpenClawChannelManagerService.cs` |
| `server-chat.ts` | Chat routing/processing | `OpenClawChatService.cs` |
| `server-cron.ts` | Scheduled tasks | `OpenClawCronService.cs` |
| `server-http.ts` | HTTP API endpoints | `OpenClawHttpService.cs` |
| `server-plugins.ts` | Plugin lifecycle | `OpenClawPluginManagerService.cs` |
| `server-sessions-*.ts` | Session management | `OpenClawSessionService.cs` |
| `hooks.ts` / `hooks-mapping.ts` | Hook system | `OpenClawHookService.cs` |
| `openai-http.ts` | OpenAI-compatible HTTP API | `OpenClawOpenAiHttpService.cs` |
| `openresponses-http.ts` | Open Responses API | `OpenClawOpenResponsesService.cs` |
| `probe.ts` | Health/readiness probes | `OpenClawProbeService.cs` |
| `control-ui.ts` | Admin control panel | `OpenClawControlUiService.cs` |

#### Channel Plugins (`src/channels/`)

| Channel | Source Files | Target .NET Class |
|---|---|---|
| Telegram | `plugins/telegram/` | `OpenClawTelegramChannel.cs` |
| Discord | `plugins/discord/` | `OpenClawDiscordChannel.cs` |
| Slack | `plugins/slack/` | `OpenClawSlackChannel.cs` |
| WhatsApp | `plugins/whatsapp/` | `OpenClawWhatsAppChannel.cs` |
| iMessage | `plugins/imessage/` | `OpenClawIMessageChannel.cs` |
| Matrix | `plugins/matrix/` | `OpenClawMatrixChannel.cs` |
| Signal | `plugins/signal/` | `OpenClawSignalChannel.cs` |
| IRC | `plugins/irc/` | `OpenClawIrcChannel.cs` |
| MS Teams | `plugins/msteams/` | `OpenClawMsTeamsChannel.cs` |
| Google Chat | `plugins/googlechat/` | `OpenClawGoogleChatChannel.cs` |
| Feishu/Lark | `plugins/feishu/` | `OpenClawFeishuChannel.cs` |
| LINE | `plugins/line/` | `OpenClawLineChannel.cs` |
| Mattermost | `plugins/mattermost/` | `OpenClawMattermostChannel.cs` |
| Nostr | `plugins/nostr/` | `OpenClawNostrChannel.cs` |
| Twitch | `plugins/twitch/` | `OpenClawTwitchChannel.cs` |
| Web | `web/` | `OpenClawWebChannel.cs` |
| BlueBubbles | `plugins/bluebubbles/` | `OpenClawBlueBubblesChannel.cs` |
| Synology Chat | `plugins/synology-chat/` | `OpenClawSynologyChatChannel.cs` |
| Nextcloud Talk | `plugins/nextcloud-talk/` | `OpenClawNextcloudTalkChannel.cs` |
| Zalo | `plugins/zalo/` | `OpenClawZaloChannel.cs` |

#### Core Library Exports (`src/library.ts`)

| Source Function | Purpose | Target .NET Method |
|---|---|---|
| `loadConfig` | Load YAML/JSON config | `OpenClawConfigService.LoadAsync()` |
| `loadSessionStore` | Load session data | `OpenClawSessionService.LoadStoreAsync()` |
| `saveSessionStore` | Persist session data | `OpenClawSessionService.SaveStoreAsync()` |
| `deriveSessionKey` | Generate session encryption key | `OpenClawSessionService.DeriveKeyAsync()` |
| `resolveSessionKey` | Resolve existing session key | `OpenClawSessionService.ResolveKeyAsync()` |
| `resolveStorePath` | Resolve data directory path | `OpenClawSessionService.ResolveStorePathAsync()` |
| `getReplyFromConfig` | Generate auto-reply from config | `OpenClawAutoReplyService.GetReplyAsync()` |
| `applyTemplate` | Apply message template | `OpenClawAutoReplyService.ApplyTemplateAsync()` |
| `runExec` | Execute shell command | `OpenClawProcessService.RunExecAsync()` |
| `runCommandWithTimeout` | Execute with timeout | `OpenClawProcessService.RunWithTimeoutAsync()` |
| `ensureBinary` | Download/verify binary dependency | `OpenClawInfraService.EnsureBinaryAsync()` |
| `ensurePortAvailable` | Check port availability | `OpenClawInfraService.EnsurePortAvailableAsync()` |
| `describePortOwner` | Identify process using port | `OpenClawInfraService.DescribePortOwnerAsync()` |
| `handlePortError` | Handle port conflict | `OpenClawInfraService.HandlePortErrorAsync()` |
| `monitorWebChannel` | Monitor WhatsApp web session | `OpenClawChannelService.MonitorWebAsync()` |
| `assertWebChannel` | Validate web channel connection | `OpenClawChannelService.AssertWebAsync()` |
| `normalizeE164` | Normalize phone number to E.164 | `OpenClawUtils.NormalizeE164()` |
| `toWhatsappJid` | Convert phone to WhatsApp JID | `OpenClawUtils.ToWhatsappJid()` |
| `promptYesNo` | CLI yes/no prompt | `OpenClawCliService.PromptYesNoAsync()` |
| `waitForever` | Block indefinitely | `OpenClawCliService.WaitForeverAsync()` |
| `createDefaultDeps` | Create default CLI dependencies | `OpenClawCliService.CreateDefaultDeps()` |

#### Plugin System (`src/plugins/`)

| Component | Source | Target .NET Class |
|---|---|---|
| Plugin loader | `loader.ts` | `OpenClawPluginLoader.cs` |
| Plugin registry | `registry.ts` | `OpenClawPluginRegistry.cs` |
| Plugin discovery | `discovery.ts` | `OpenClawPluginDiscovery.cs` |
| Plugin CLI | `cli.ts` | `OpenClawPluginCli.cs` |
| Provider runtime | `provider-runtime.ts` | `OpenClawProviderRuntime.cs` |
| Provider catalog | `provider-catalog.ts` | `OpenClawProviderCatalog.cs` |
| Provider auth | `provider-auth-*.ts` | `OpenClawProviderAuth.cs` |
| MCP bundle | `bundle-mcp.ts` | `OpenClawMcpBundle.cs` |
| Hook runner | `hook-runner-global.ts` | `OpenClawHookRunner.cs` |
| Manifest | `manifest.ts` | `OpenClawPluginManifest.cs` |
| Web search | `web-search-providers.ts` | `OpenClawWebSearchProviders.cs` |

#### ACP (Agent Client Protocol) (`src/acp/`)

| Component | Source | Target .NET Class |
|---|---|---|
| ACP server | `server.ts` | `OpenClawAcpServer.cs` |
| ACP client | `client.ts` | `OpenClawAcpClient.cs` |
| ACP session | `session.ts` | `OpenClawAcpSession.cs` |
| ACP translator | `translator.ts` | `OpenClawAcpTranslator.cs` |
| ACP policy | `policy.ts` | `OpenClawAcpPolicy.cs` |

#### CLI Commands (`src/commands/`)

| Source Command | Purpose | Target .NET Method |
|---|---|---|
| `agent` | Run AI agent | `OpenClawCli.AgentAsync()` |
| `agents` | Manage agent configurations | `OpenClawCli.AgentsAsync()` |
| `auth-choice` | Configure authentication | `OpenClawCli.AuthChoiceAsync()` |
| `backup` | Backup/restore data | `OpenClawCli.BackupAsync()` |
| `channels` | Add/remove/list channels | `OpenClawCli.ChannelsAsync()` |
| `configure` | Configuration wizard | `OpenClawCli.ConfigureAsync()` |
| `dashboard` | Open web dashboard | `OpenClawCli.DashboardAsync()` |
| `doctor` | Diagnose issues | `OpenClawCli.DoctorAsync()` |
| `gateway` | Start gateway server | `OpenClawCli.GatewayAsync()` |
| `health` | Health check | `OpenClawCli.HealthAsync()` |
| `message` | Send message | `OpenClawCli.MessageAsync()` |
| `models` | Manage AI models | `OpenClawCli.ModelsAsync()` |
| `onboard` | First-time setup | `OpenClawCli.OnboardAsync()` |
| `reset` | Reset configuration | `OpenClawCli.ResetAsync()` |
| `sandbox` | Manage execution sandbox | `OpenClawCli.SandboxAsync()` |
| `sessions` | Manage chat sessions | `OpenClawCli.SessionsAsync()` |
| `setup` | Install/configure | `OpenClawCli.SetupAsync()` |
| `status` | Show runtime status | `OpenClawCli.StatusAsync()` |
| `tui` | Terminal UI | `OpenClawCli.TuiAsync()` |
| `uninstall` | Remove openclaw | `OpenClawCli.UninstallAsync()` |
| `update` | Update openclaw | `OpenClawCli.UpdateAsync()` |

#### Other Core Services

| Component | Source Path | Target .NET Class |
|---|---|---|
| Config system | `src/config/` | `OpenClawConfigService.cs` |
| Memory/LanceDB | `src/memory/` | `OpenClawMemoryService.cs` |
| Media processing | `src/media/` | `OpenClawMediaService.cs` |
| Media understanding | `src/media-understanding/` | `OpenClawMediaUnderstandingService.cs` |
| Image generation | `src/image-generation/` | `OpenClawImageGenerationService.cs` |
| TTS (Text-to-speech) | `src/tts/` | `OpenClawTtsService.cs` |
| Web search | `src/web-search/` | `OpenClawWebSearchService.cs` |
| Security | `src/security/` | `OpenClawSecurityService.cs` |
| Secrets | `src/secrets/` | `OpenClawSecretsService.cs` |
| I18N | `src/i18n/` | `OpenClawI18NService.cs` |
| Cron | `src/cron/` | `OpenClawCronService.cs` |
| Daemon | `src/daemon/` | `OpenClawDaemonService.cs` |
| CLI | `src/cli/` | `OpenClawCliService.cs` |
| Process mgmt | `src/process/` | `OpenClawProcessService.cs` |
| Browser | `src/browser/` | `OpenClawBrowserService.cs` |
| Infra | `src/infra/` | `OpenClawInfraService.cs` |
| Hooks | `src/hooks/` | `OpenClawHooksService.cs` |
| Routing | `src/routing/` | `OpenClawRoutingService.cs` |
| Sessions | `src/sessions/` | `OpenClawSessionsService.cs` |
| Interactive | `src/interactive/` | `OpenClawInteractiveService.cs` |
| Canvas host | `src/canvas-host/` | `OpenClawCanvasHostService.cs` |
| Terminal | `src/terminal/` | `OpenClawTerminalService.cs` |
| TUI | `src/tui/` | `OpenClawTuiService.cs` |

### 2.2 Dependencies Needing .NET Equivalents

| JS Dependency | Purpose | .NET Equivalent |
|---|---|---|
| `hono` (4.12.8) | HTTP framework | ASP.NET Core Minimal APIs / Kestrel |
| `ws` (8.19.0) | WebSocket server | System.Net.WebSockets |
| `express` (5.2.1) | HTTP server | ASP.NET Core |
| `sharp` (0.34.5) | Image processing | ImageSharp or SkiaSharp |
| `sqlite-vec` (0.1.7) | Vector search in SQLite | Microsoft.Data.Sqlite + custom vector ext |
| `playwright-core` (1.58.2) | Browser automation | CDP direct or Playwright .NET |
| `@modelcontextprotocol/sdk` (1.27.1) | MCP protocol | Custom MCP implementation |
| `@agentclientprotocol/sdk` (0.16.1) | ACP protocol | Custom ACP implementation |
| `zod` (4.3.6) | Schema validation | FluentValidation / DataAnnotations |
| `pdfjs-dist` (5.5.207) | PDF parsing | PdfPig or iText7 |
| `linkedom` (0.18.12) | HTML parsing | AngleSharp |
| `yaml` (2.8.2) | YAML parsing | YamlDotNet |
| `commander` (14.0.3) | CLI framework | System.CommandLine |
| `chokidar` (5.0.0) | File watcher | System.IO.FileSystemWatcher |
| `node-edge-tts` (1.2.10) | TTS | Azure Cognitive Services Speech SDK |
| `@mozilla/readability` (0.6.0) | Article extraction | SmartReader |
| `markdown-it` (14.1.1) | Markdown parsing | Markdig |

### 2.3 Target .NET Project Structure

```
PrTask.Infrastructure.OpenClaw/
  Gateway/
    OpenClawGatewayService.cs
    OpenClawClientService.cs
    OpenClawAuthService.cs
    OpenClawSessionService.cs
    OpenClawChatService.cs
    OpenClawHttpService.cs
  Channels/
    OpenClawTelegramChannel.cs
    OpenClawDiscordChannel.cs
    OpenClawSlackChannel.cs
    OpenClawWhatsAppChannel.cs
    ... (20 channels)
  Providers/
    OpenClawProviderRuntime.cs
    OpenClawProviderCatalog.cs
    OpenClawProviderAuth.cs
  Plugins/
    OpenClawPluginLoader.cs
    OpenClawPluginRegistry.cs
    OpenClawPluginManifest.cs
  Agents/
    OpenClawAcpServer.cs
    OpenClawAcpClient.cs
    OpenClawAgentSandbox.cs
  Services/
    OpenClawConfigService.cs
    OpenClawMemoryService.cs
    OpenClawMediaService.cs
    OpenClawWebSearchService.cs
    OpenClawSecurityService.cs
```

---

## 3. Lighthouse (v13.0.3)

**Source**: `C:\work\lighthouse`
**License**: Apache-2.0 (Google LLC)
**Architecture**: Gather-then-audit pipeline. Gatherers use CDP to collect artifacts from the page (via Puppeteer). Audits analyze artifacts and produce scored results. Runner orchestrates the pipeline. Config defines which gatherers/audits to run and how to score categories.

### 3.1 API Surface

#### Core Entry Points (`core/index.js`)

| Source Function | Parameters | Target .NET Method |
|---|---|---|
| `lighthouse(url, flags, config, page)` | URL + Puppeteer page | `LighthouseService.Run()` |
| `navigation(page, requestor, options)` | Page + options | `LighthouseService.Navigation()` |
| `snapshot(page, options)` | Page + options | `LighthouseService.Snapshot()` |
| `startTimespan(page, options)` | Page + options | `LighthouseService.StartTimespan()` |
| `startFlow(page, options)` | Page + options | `LighthouseService.StartFlow()` |
| `generateReport(result, format)` | LHR + format | `LighthouseReportService.GenerateReport()` |
| `auditFlowArtifacts(flowArtifacts, config)` | Flow artifacts | `LighthouseService.AuditFlowArtifacts()` |
| `getAuditList()` | (none) | `LighthouseService.GetAuditList()` |

#### Scoring Algorithm (`core/scoring.js`)

| Source Method | Logic | Target .NET Method |
|---|---|---|
| `ReportScoring.arithmeticMean(items)` | Weighted average, null if any null | `LighthouseScoringService.ArithmeticMean()` |
| `ReportScoring.scoreAllCategories(categories, results)` | Score each category, zero-weight N/A | `LighthouseScoringService.ScoreAllCategories()` |

**Performance scoring weights**: FCP=10, LCP=25, TBT=30, CLS=25, SI=10 (INP=0, TTI=0)

### 3.2 Audit Categories (5 categories, 150+ audits)

#### Performance (7 scored metrics + 17 insights + 12 diagnostics + 8 hidden)

**Scored Metrics:**

| Audit ID | Weight | CDP Commands | Target .NET Class |
|---|---|---|---|
| `first-contentful-paint` | 10 | Tracing.start/end (trace events) | `LighthouseAudits.FirstContentfulPaint` |
| `largest-contentful-paint` | 25 | Tracing (trace events) | `LighthouseAudits.LargestContentfulPaint` |
| `total-blocking-time` | 30 | Tracing (long tasks from trace) | `LighthouseAudits.TotalBlockingTime` |
| `cumulative-layout-shift` | 25 | Tracing (layout shift events) | `LighthouseAudits.CumulativeLayoutShift` |
| `speed-index` | 10 | Tracing + screenshots | `LighthouseAudits.SpeedIndex` |
| `interaction-to-next-paint` | 0 | Tracing (event timing) | `LighthouseAudits.InteractionToNextPaint` |
| `interactive` (TTI) | 0 | Tracing | `LighthouseAudits.Interactive` |

**Insights (17):**

| Audit ID | Target .NET Class |
|---|---|
| `cache-insight` | `LighthouseInsights.CacheInsight` |
| `cls-culprits-insight` | `LighthouseInsights.ClsCulpritsInsight` |
| `document-latency-insight` | `LighthouseInsights.DocumentLatencyInsight` |
| `dom-size-insight` | `LighthouseInsights.DomSizeInsight` |
| `duplicated-javascript-insight` | `LighthouseInsights.DuplicatedJavascriptInsight` |
| `font-display-insight` | `LighthouseInsights.FontDisplayInsight` |
| `forced-reflow-insight` | `LighthouseInsights.ForcedReflowInsight` |
| `image-delivery-insight` | `LighthouseInsights.ImageDeliveryInsight` |
| `inp-breakdown-insight` | `LighthouseInsights.InpBreakdownInsight` |
| `lcp-breakdown-insight` | `LighthouseInsights.LcpBreakdownInsight` |
| `lcp-discovery-insight` | `LighthouseInsights.LcpDiscoveryInsight` |
| `legacy-javascript-insight` | `LighthouseInsights.LegacyJavascriptInsight` |
| `modern-http-insight` | `LighthouseInsights.ModernHttpInsight` |
| `network-dependency-tree-insight` | `LighthouseInsights.NetworkDependencyTreeInsight` |
| `render-blocking-insight` | `LighthouseInsights.RenderBlockingInsight` |
| `third-parties-insight` | `LighthouseInsights.ThirdPartiesInsight` |
| `viewport-insight` | `LighthouseInsights.ViewportInsight` |

**Diagnostics (12):**

| Audit ID | Target .NET Class |
|---|---|
| `unminified-css` | `LighthouseDiagnostics.UnminifiedCss` |
| `unminified-javascript` | `LighthouseDiagnostics.UnminifiedJavascript` |
| `unused-css-rules` | `LighthouseDiagnostics.UnusedCssRules` |
| `unused-javascript` | `LighthouseDiagnostics.UnusedJavascript` |
| `total-byte-weight` | `LighthouseDiagnostics.TotalByteWeight` |
| `user-timings` | `LighthouseDiagnostics.UserTimings` |
| `bootup-time` | `LighthouseDiagnostics.BootupTime` |
| `mainthread-work-breakdown` | `LighthouseDiagnostics.MainthreadWorkBreakdown` |
| `long-tasks` | `LighthouseDiagnostics.LongTasks` |
| `non-composited-animations` | `LighthouseDiagnostics.NonCompositedAnimations` |
| `unsized-images` | `LighthouseDiagnostics.UnsizedImages` |
| `bf-cache` | `LighthouseDiagnostics.BfCache` |

#### Accessibility (55 audits + 10 manual)

All accessibility audits run axe-core via `Accessibility.getFullAXTree` CDP domain.

| Audit Group | Count | Example Audits | Target .NET Namespace |
|---|---|---|---|
| ARIA | 22 | `aria-allowed-attr`, `aria-roles`, `aria-valid-attr` | `LighthouseAudits.Accessibility.Aria` |
| Names & Labels | 14 | `button-name`, `image-alt`, `label`, `link-name` | `LighthouseAudits.Accessibility.NamesLabels` |
| Navigation | 4 | `accesskeys`, `bypass`, `tabindex`, `heading-order` | `LighthouseAudits.Accessibility.Navigation` |
| Color Contrast | 2 | `color-contrast`, `link-in-text-block` | `LighthouseAudits.Accessibility.Contrast` |
| Tables & Lists | 6 | `definition-list`, `dlitem`, `td-headers-attr` | `LighthouseAudits.Accessibility.TablesLists` |
| Best Practices | 5 | `meta-refresh`, `meta-viewport`, `target-size` | `LighthouseAudits.Accessibility.BestPractices` |
| Audio/Video | 1 | `video-caption` | `LighthouseAudits.Accessibility.AudioVideo` |
| Language | 4 | `html-has-lang`, `html-lang-valid`, `valid-lang` | `LighthouseAudits.Accessibility.Language` |
| Manual | 10 | `focus-traps`, `logical-tab-order` | `LighthouseAudits.Accessibility.Manual` |

#### Best Practices (20 audits)

| Audit Group | Audits | Target .NET Namespace |
|---|---|---|
| Trust & Safety | `is-on-https`, `redirects-http`, `geolocation-on-start`, `notification-on-start`, `csp-xss`, `has-hsts`, `origin-isolation`, `clickjacking-mitigation`, `trusted-types-xss` | `LighthouseAudits.BestPractices.TrustSafety` |
| User Experience | `paste-preventing-inputs`, `image-aspect-ratio`, `image-size-responsive` | `LighthouseAudits.BestPractices.Ux` |
| Browser Compat | `doctype`, `charset` | `LighthouseAudits.BestPractices.BrowserCompat` |
| General | `js-libraries`, `deprecations`, `third-party-cookies`, `errors-in-console`, `valid-source-maps`, `inspector-issues` | `LighthouseAudits.BestPractices.General` |

#### SEO (11 audits + 1 manual)

| Audit ID | Weight | CDP Commands | Target .NET Class |
|---|---|---|---|
| `is-crawlable` | 4.04 | Network (robots meta, X-Robots-Tag) | `LighthouseAudits.Seo.IsCrawlable` |
| `document-title` | 1 | DOM.getDocument | `LighthouseAudits.Seo.DocumentTitle` |
| `meta-description` | 1 | DOM (meta tags) | `LighthouseAudits.Seo.MetaDescription` |
| `http-status-code` | 1 | Network.responseReceived | `LighthouseAudits.Seo.HttpStatusCode` |
| `link-text` | 1 | DOM (anchor elements) | `LighthouseAudits.Seo.LinkText` |
| `crawlable-anchors` | 1 | DOM (anchor elements) | `LighthouseAudits.Seo.CrawlableAnchors` |
| `robots-txt` | 1 | Network (fetch /robots.txt) | `LighthouseAudits.Seo.RobotsTxt` |
| `image-alt` | 1 | DOM (img elements) | `LighthouseAudits.Seo.ImageAlt` |
| `hreflang` | 1 | DOM (link[hreflang]) | `LighthouseAudits.Seo.Hreflang` |
| `canonical` | 1 | DOM (link[rel=canonical]) | `LighthouseAudits.Seo.Canonical` |
| `structured-data` | 0 (manual) | N/A | `LighthouseAudits.Seo.StructuredData` |

### 3.3 Gatherers (25 total, all CDP-based)

| Gatherer | Artifact | CDP Domains | Target .NET Class |
|---|---|---|---|
| `devtools-log` | DevtoolsLog | Network.*, Page.* (full CDP log) | `LighthouseGatherers.DevtoolsLog` |
| `trace` | Trace | Tracing.start/end/tracingComplete | `LighthouseGatherers.Trace` |
| `accessibility` | Accessibility | Runtime.evaluate (axe-core injection) | `LighthouseGatherers.Accessibility` |
| `anchor-elements` | AnchorElements | DOM.querySelectorAll, Runtime.evaluate | `LighthouseGatherers.AnchorElements` |
| `console-messages` | ConsoleMessages | Log.entryAdded, Runtime.consoleAPICalled | `LighthouseGatherers.ConsoleMessages` |
| `css-usage` | CSSUsage | CSS.startRuleUsageTracking/stopRuleUsageTracking | `LighthouseGatherers.CssUsage` |
| `doctype` | Doctype | DOM.getDocument | `LighthouseGatherers.Doctype` |
| `inputs` | Inputs | DOM.querySelectorAll | `LighthouseGatherers.Inputs` |
| `iframe-elements` | IFrameElements | DOM.querySelectorAll | `LighthouseGatherers.IframeElements` |
| `image-elements` | ImageElements | DOM.querySelectorAll, Runtime.evaluate | `LighthouseGatherers.ImageElements` |
| `inspector-issues` | InspectorIssues | Audits.enable/issueAdded | `LighthouseGatherers.InspectorIssues` |
| `js-usage` | JsUsage | Profiler.startPreciseCoverage/stopPreciseCoverage | `LighthouseGatherers.JsUsage` |
| `link-elements` | LinkElements | DOM.querySelectorAll | `LighthouseGatherers.LinkElements` |
| `main-document-content` | MainDocumentContent | Network.getResponseBody | `LighthouseGatherers.MainDocumentContent` |
| `meta-elements` | MetaElements | DOM.querySelectorAll | `LighthouseGatherers.MetaElements` |
| `network-user-agent` | NetworkUserAgent | Network (from headers) | `LighthouseGatherers.NetworkUserAgent` |
| `scripts` | Scripts | Runtime.evaluate, Debugger.getScriptSource | `LighthouseGatherers.Scripts` |
| `source-maps` | SourceMaps | Network (fetch .map files) | `LighthouseGatherers.SourceMaps` |
| `stacks` | Stacks | Runtime.evaluate (detect frameworks) | `LighthouseGatherers.Stacks` |
| `stylesheets` | Stylesheets | CSS.getStyleSheetText | `LighthouseGatherers.Stylesheets` |
| `trace-elements` | TraceElements | DOM + Tracing cross-reference | `LighthouseGatherers.TraceElements` |
| `viewport-dimensions` | ViewportDimensions | Runtime.evaluate | `LighthouseGatherers.ViewportDimensions` |
| `full-page-screenshot` | FullPageScreenshot | Page.captureScreenshot | `LighthouseGatherers.FullPageScreenshot` |
| `bf-cache-failures` | BFCacheFailures | Page.backForwardCacheNotUsed | `LighthouseGatherers.BfCacheFailures` |
| `seo/robots-txt` | RobotsTxt | Network (fetch /robots.txt) | `LighthouseGatherers.RobotsTxt` |

### 3.4 CDP Domains Used by Lighthouse

| CDP Domain | Commands/Events |
|---|---|
| **Tracing** | start, end, dataCollected, tracingComplete |
| **Page** | enable, navigate, captureScreenshot, backForwardCacheNotUsed, lifecycleEvent, createIsolatedWorld, getFrameTree, addScriptToEvaluateOnNewDocument |
| **Network** | enable, requestWillBeSent, responseReceived, loadingFinished, getResponseBody, loadNetworkResource |
| **DOM** | enable, disable, getDocument, pushNodeByPathToFrontend, resolveNode, querySelectorAll, getOuterHTML |
| **Runtime** | enable, evaluate, consoleAPICalled, executionContextCreated |
| **CSS** | enable, disable, getStyleSheetText, startRuleUsageTracking, stopRuleUsageTracking, getMatchedStylesForNode |
| **Profiler** | enable, startPreciseCoverage, stopPreciseCoverage, takePreciseCoverage |
| **Accessibility** | getFullAXTree |
| **Audits** | enable, disable, issueAdded |
| **Log** | enable, entryAdded, startViolationsReport |
| **Emulation** | setDeviceMetricsOverride, setTouchEmulationEnabled, setUserAgentOverride |
| **Debugger** | enable, disable, getScriptSource, scriptParsed |
| **DOMDebugger** | getEventListeners |
| **Target** | setAutoAttach, attachedToTarget, getTargetInfo |
| **ServiceWorker** | enable, registrations |
| **IO** | read |

### 3.5 Dependencies Needing .NET Equivalents

| JS Dependency | Purpose | .NET Equivalent |
|---|---|---|
| `puppeteer-core` (24.23.0) | CDP connection | Direct CDP WebSocket (shared with chrome-devtools-mcp) |
| `chrome-launcher` (1.2.1) | Chrome process management | Process.Start with Chrome flags |
| `axe-core` (4.11.0) | Accessibility testing | Deque.AxeCore.Selenium or inject axe-core.js via CDP |
| `@paulirish/trace_engine` (0.0.61) | Trace parsing | Port trace parser to .NET |
| `speedline-core` (1.4.3) | Speed Index calculation | Port algorithm |
| `third-party-web` (0.27.0) | Third-party entity database | Embed as static JSON resource |
| `csp_evaluator` (1.1.5) | CSP analysis | Port or use NuGet CSP parser |
| `js-library-detector` (6.7.0) | JS framework detection | Embed detection patterns |
| `robots-parser` (3.0.1) | robots.txt parsing | RobotsParser NuGet |
| `http-link-header` (1.1.1) | Link header parsing | System.Net.Http.Headers |
| `intl-messageformat` (10.5.3) | ICU message formatting | MessageFormat.NET |
| `lodash-es` (4.17.21) | Utility functions | Built-in LINQ |
| `devtools-protocol` (0.0.1527314) | CDP type definitions | Generate C# types from protocol.json |

### 3.6 Target .NET Project Structure

```
PrTask.Infrastructure.Lighthouse/
  Services/
    LighthouseService.cs           -- Main entry (navigation, snapshot, timespan, flow)
    LighthouseReportService.cs     -- Report generation (JSON, HTML)
    LighthouseScoringService.cs    -- Category scoring algorithm
  Config/
    LighthouseDefaultConfig.cs     -- Default audit/gatherer configuration
    LighthouseDesktopConfig.cs     -- Desktop overrides
    LighthouseConstants.cs         -- Throttling settings, emulation
  Gatherers/
    BaseGatherer.cs                -- Abstract base
    TraceGatherer.cs
    AccessibilityGatherer.cs
    NetworkGatherer.cs
    DomGatherer.cs
    CssUsageGatherer.cs
    JsUsageGatherer.cs
    ... (25 gatherers)
  Audits/
    BaseAudit.cs                   -- Abstract base
    Performance/                   -- 7 metrics + 17 insights + 12 diagnostics
    Accessibility/                 -- 55 axe-core audits
    BestPractices/                 -- 20 audits
    Seo/                           -- 11 audits
    ByteEfficiency/                -- 5 byte audits
    Insights/                      -- 17 insight audits
  Protocol/
    CdpTypes.cs                    -- Shared CDP types (from devtools-protocol)
```

---

## 4. Cross-Repo Summary

### 4.1 Shared CDP Infrastructure

Both chrome-devtools-mcp and lighthouse use CDP heavily. The shared CDP connection layer should be in a base project:

```
PrTask.Infrastructure.Cdp/         -- Shared CDP WebSocket client + protocol types
PrTask.Infrastructure.CdpTools/    -- chrome-devtools-mcp tools (31 tools)
PrTask.Infrastructure.Lighthouse/  -- Lighthouse audits (150+ audits)
PrTask.Infrastructure.OpenClaw/    -- OpenClaw gateway + channels + providers
```

### 4.2 Total Conversion Scope

| Repo | Source Functions/Tools | Target .NET Classes | CDP Domains |
|---|---|---|---|
| chrome-devtools-mcp | 31 tools | ~15 service classes | 14 domains |
| lighthouse | 150+ audits, 25 gatherers, 8 entry points | ~200 classes | 16 domains |
| openclaw | ~60 core services, 20 channels, 21 CLI commands | ~100 service classes | 0 (HTTP/WS only) |
| **Total** | **~295 functions** | **~315 classes** | **16 unique CDP domains** |

### 4.3 Priority Order for Conversion

1. **PrTask.Infrastructure.Cdp** -- Foundation: CDP WebSocket client, protocol types
2. **PrTask.Infrastructure.CdpTools** -- Replace Playwright with CDP tools (Step 4)
3. **PrTask.Infrastructure.Lighthouse** -- Replace Lighthouse npx with in-process (Step 5)
4. **PrTask.Infrastructure.OpenClaw** -- AI gateway for PrTask (Step 3 completion)

### 4.4 CDP Protocol Types Required

Generate C# strongly-typed CDP domain classes from `devtools-protocol` npm package (v0.0.1527314):

```
CdpDomains/
  Accessibility.cs    -- getFullAXTree
  Audits.cs           -- enable, disable, issueAdded
  Browser.cs          -- getWindowBounds, setWindowBounds
  CSS.cs              -- enable, disable, getStyleSheetText, startRuleUsageTracking, stopRuleUsageTracking, getMatchedStylesForNode
  DOM.cs              -- enable, disable, getDocument, pushNodeByPathToFrontend, resolveNode, querySelectorAll, setFileInputFiles, focus
  DOMDebugger.cs      -- getEventListeners
  Debugger.cs         -- enable, disable, getScriptSource, scriptParsed
  Emulation.cs        -- setDeviceMetricsOverride, setCPUThrottlingRate, setGeolocationOverride, setUserAgentOverride, setEmulatedMedia, setTouchEmulationEnabled
  Extensions.cs       -- triggerAction
  HeapProfiler.cs     -- takeHeapSnapshot, addHeapSnapshotChunk
  IO.cs               -- read
  Input.cs            -- dispatchMouseEvent, dispatchKeyEvent, dispatchDragEvent
  Log.cs              -- enable, entryAdded, startViolationsReport
  Network.cs          -- enable, emulateNetworkConditions, requestWillBeSent, responseReceived, loadingFinished, getRequestPostData, getResponseBody, loadNetworkResource
  Page.cs             -- enable, navigate, reload, captureScreenshot, handleJavaScriptDialog, startScreencast, stopScreencast, addScriptToEvaluateOnNewDocument, removeScriptToEvaluateOnNewDocument, lifecycleEvent, backForwardCacheNotUsed, createIsolatedWorld, getFrameTree
  Profiler.cs         -- enable, startPreciseCoverage, stopPreciseCoverage, takePreciseCoverage
  Runtime.cs          -- enable, evaluate, callFunctionOn, consoleAPICalled, executionContextCreated
  ServiceWorker.cs    -- enable, registrations
  Target.cs           -- getTargets, createTarget, closeTarget, activateTarget, setAutoAttach, attachedToTarget, getTargetInfo
  Tracing.cs          -- start, end, dataCollected, tracingComplete
```
