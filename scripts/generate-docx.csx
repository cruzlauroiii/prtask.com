#r "nuget: DocumentFormat.OpenXml, 3.2.0"
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

var OutputPath = Args.Count > 0 ? Args[0] : @"C:\Users\user1\Downloads\Pre_interview_questionnaire.docx";

using (var Doc = WordprocessingDocument.Create(OutputPath, WordprocessingDocumentType.Document))
{
var MainPart = Doc.AddMainDocumentPart();
MainPart.Document = new Document();
var Body = MainPart.Document.AppendChild(new Body());

// Styles
var StylePart = MainPart.AddNewPart<StyleDefinitionsPart>();
var Styles = new Styles();
// Heading1
var H1Style = new Style { Type = StyleValues.Paragraph, StyleId = "Heading1" };
H1Style.Append(new StyleName { Val = "heading 1" });
H1Style.Append(new StyleRunProperties(new Bold(), new FontSize { Val = "32" }, new Color { Val = "1a1a2e" }));
H1Style.Append(new StyleParagraphProperties(new SpacingBetweenLines { After = "120", Before = "240" }));
Styles.Append(H1Style);
// Heading2
var H2Style = new Style { Type = StyleValues.Paragraph, StyleId = "Heading2" };
H2Style.Append(new StyleName { Val = "heading 2" });
H2Style.Append(new StyleRunProperties(new Bold(), new FontSize { Val = "26" }, new Color { Val = "16213e" }));
H2Style.Append(new StyleParagraphProperties(new SpacingBetweenLines { After = "80", Before = "200" }));
Styles.Append(H2Style);
// Heading3
var H3Style = new Style { Type = StyleValues.Paragraph, StyleId = "Heading3" };
H3Style.Append(new StyleName { Val = "heading 3" });
H3Style.Append(new StyleRunProperties(new Bold(), new FontSize { Val = "22" }, new Color { Val = "0f3460" }));
H3Style.Append(new StyleParagraphProperties(new SpacingBetweenLines { After = "60", Before = "160" }));
Styles.Append(H3Style);
StylePart.Styles = Styles;

void AddHeading(string Text, string Level)
{
    var P = Body.AppendChild(new Paragraph());
    P.ParagraphProperties = new ParagraphProperties(new ParagraphStyleId { Val = Level });
    P.AppendChild(new Run(new Text(Text)));
}

void AddPara(string Text, bool IsBold = false)
{
    var P = Body.AppendChild(new Paragraph());
    P.ParagraphProperties = new ParagraphProperties(new SpacingBetweenLines { After = "80", Line = "276", LineRule = LineSpacingRuleValues.Auto });
    var R = P.AppendChild(new Run());
    if (IsBold) R.RunProperties = new RunProperties(new Bold());
    R.RunProperties ??= new RunProperties();
    R.RunProperties.Append(new RunFonts { Ascii = "Calibri", HighAnsi = "Calibri" });
    R.RunProperties.Append(new FontSize { Val = "21" });
    R.AppendChild(new Text(Text) { Space = SpaceProcessingModeValues.Preserve });
}

void AddBullet(string Text)
{
    var P = Body.AppendChild(new Paragraph());
    P.ParagraphProperties = new ParagraphProperties(
        new SpacingBetweenLines { After = "40", Line = "276", LineRule = LineSpacingRuleValues.Auto },
        new Indentation { Left = "360" }
    );
    var R = P.AppendChild(new Run());
    R.RunProperties = new RunProperties(new RunFonts { Ascii = "Calibri", HighAnsi = "Calibri" }, new FontSize { Val = "21" });
    R.AppendChild(new Text("• " + Text) { Space = SpaceProcessingModeValues.Preserve });
}

void AddBlank() => Body.AppendChild(new Paragraph(new ParagraphProperties(new SpacingBetweenLines { After = "40" })));

// === DOCUMENT CONTENT ===

AddHeading("Agentic AI Labor Platform — Pre-Interview Technical Questionnaire", "Heading1");
AddPara("From: Lauro Cruz III (noahblesse@gmail.com)", true);
AddBlank();

// ============ SECTION 1 ============
AddHeading("SECTION 1 — VISION & PRODUCT THINKING", "Heading2");

AddHeading("Q1: Chatbot vs. Agentic AI System", "Heading3");
AddPara("A chatbot is reactive — it waits for input, responds, and stops. No goals, no memory of what to do next, no ability to act in external systems. On a hiring platform, a chatbot answers \"What warehouse jobs are open near me?\" and returns a list. Conversation over.");
AddPara("An agentic system has goals, plans, acts, observes results, and iterates — autonomously between user interactions. On the same platform, it monitors new postings hourly, compares against the worker's profile and salary floor, drafts personalized outreach to matching employers, schedules interviews, and follows up if no response within 48 hours — all without the worker opening the app.");
AddPara("The core difference is the loop. Chatbot: input → output. Agent: goal → plan → act → observe → revise → act again.");
AddPara("I built this pattern in PrTask (prtask.com). When a developer's profile matches a new task, the system scores complexity and surfaces it. When a PR is approved, payment fires automatically — no \"pay me\" button. The system acts on the event.");

AddHeading("Q2: First 5 Minutes of the Personal Career Agent", "Heading3");
AddPara("0:00–0:30 — Warm start, not a form. The agent greets by name (from SSO) and asks one open question: \"What kind of work do you do?\"");
AddPara("0:30–1:30 — Conversational profiling. 3–4 targeted questions in natural language:");
AddBullet("\"What's your most recent role?\" → extracts title, industry, recency");
AddBullet("\"Do you drive? What license?\" → CDL, forklift cert, hazmat (logistics-specific)");
AddBullet("\"What shift works for you?\" → schedule constraints");
AddBullet("\"Minimum pay you'd accept?\" → salary floor for matching");
AddPara("Each answer processed by Claude with a structured extraction prompt — entities (role, certs, location, availability, pay floor) extracted into typed JSON.");
AddPara("1:30–3:00 — Background inference while chatting: experience level from title + years, geocode location for commute radius, cross-reference certs against active jobs, build embedding vector for semantic matching.");
AddPara("3:00–4:00 — First value delivery: \"I found 3 jobs within 15 miles. Top one: [Company], [Role], [$Pay/hr], [Shift]. Want me to apply?\" This is the trust moment — deliver a relevant match in under 4 minutes or lose the worker.");
AddPara("4:00–5:00 — Autonomy setup: \"I can watch for new jobs and apply on your behalf — you'd just confirm. What level of autonomy do you want?\" Explicit consent for agentic behavior.");

AddHeading("Q3: 6 Weeks to Fundable — Build vs. Skip", "Heading3");
AddPara("Build:", true);
AddBullet("Weeks 1–2: Career agent conversation loop. Single-page app, worker talks to agent, profile built via Claude, matches surfaced from seeded database of 200+ real logistics jobs. Supabase for persistence.");
AddBullet("Weeks 3–4: \"Apply for me\" action. Agent drafts outreach, worker confirms, application sent. This is the agentic moment investors need to see.");
AddBullet("Week 5: Employer dashboard — ranked inbox with match reasoning (\"CDL-A, 3yr warehouse, night shift, 8 miles away\").");
AddBullet("Week 6: Polish, demo script, analytics dashboard (profiles created, matches made, response rates).");
AddPara("Deliberately leave out:", true);
AddBullet("Payment processing, mobile app, real ATS integrations, multi-language, production infra (K8s, CI/CD), background job scheduling, compliance (SOC2/GDPR) — document the plan, don't build it");
AddPara("The pitch: \"Agent built a profile through conversation, found a match, and applied — in 4 minutes. Here's what happens at 10,000 workers.\"");

// ============ SECTION 2 ============
AddHeading("SECTION 2 — TECHNICAL APPROACH", "Heading2");

AddHeading("Q4: Architecture", "Heading3");
AddPara("Frontend → API Layer → Agent Orchestrator → Claude API → Data Layer", true);
AddPara("Frontend: Next.js with Vercel AI SDK (built-in Claude streaming + tool call handling). WebSocket for real-time. For production, I'd migrate to Blazor WASM (what I use for PrTask) for offline-first.");
AddPara("Agent Orchestrator: Manages conversation state machine. Calls Claude API with context injection. Executes tool calls (search_jobs, apply_to_job, update_profile). This is the agentic loop — Claude decides which tool to call, orchestrator executes it, feeds result back.");
AddPara("Claude API: Tool use with typed parameters — search_jobs(criteria), apply_to_job(job_id, message), update_profile(fields). Sonnet for speed (80% of calls), Opus for complex reasoning.");
AddPara("State & Memory: Supabase (Postgres) for profiles, jobs, applications. Session state in Redis. Conversation history summarized at session end (50 tokens vs 2,000 raw) and injected into next session's system prompt. pgvector for semantic job matching embeddings.");
AddPara("In PrTask, I built this with: Cloudflare Workers (D1 + KV + R2), WebSocket gatekeeper with 232+ message types, USearch for vector similarity (native C++ with .NET P/Invoke bindings I wrote), and Automerge CRDTs for offline-first sync.");

AddHeading("Q5: Claude Code vs. Lovable", "Heading3");
AddPara("I use Claude Code daily — PrTask (30+ projects, 200+ source files, clean architecture) was built almost entirely through it.");
AddPara("Claude Code handles:", true);
AddBullet("Architecture decisions, backend logic, API endpoints, service layers, business rules");
AddBullet("Complex multi-file refactoring (rename domain entity → updates every layer)");
AddBullet("System prompt engineering, infrastructure-as-code, test generation");
AddPara("Claude Code needs oversight:", true);
AddBullet("Can over-engineer if unconstrained — I use CLAUDE.md rules + 4 Roslyn analyzers that reject violations at build time");
AddBullet("Generates correct code that doesn't match intended runtime behavior — still need to run and test");
AddPara("Lovable handles:", true);
AddBullet("Rapid UI prototyping — description to styled responsive page in minutes");
AddBullet("Component scaffolding (dashboards, forms, cards, tables), design consistency via Tailwind/shadcn");
AddPara("Lovable limits:", true);
AddBullet("Complex state (WebSocket, optimistic updates, offline sync) — scaffolds UI, logic needs handwriting");
AddBullet("Backend logic, auth flows, API orchestration — all Claude Code or manual");
AddPara("Combined workflow: Lovable for first-draft UI (better design sense) → Claude Code for logic, API integration, streaming, state management → hand-written for WebSocket reconnection, agent state machine edge cases, security-critical code.");

AddHeading("Q6: Fast UX with Slow AI Calls", "Heading3");
AddBullet("Streaming responses (most important): Claude's streaming API delivers first token in ~200ms. User sees typing immediately — perceived wait drops from 5s to near-zero. SSE or WebSocket to push tokens.");
AddBullet("Optimistic UI: Message renders instantly on send, typing indicator shows, input disables. \"Apply\" shows success immediately, API fires in background.");
AddBullet("Skeleton loaders + progressive rendering: Dashboard shows skeleton cards, job matches render individually as they arrive (~500ms for first).");
AddBullet("Background pre-fetch: While user reads agent response, fetch full details of all mentioned jobs. Click → instant detail view.");
AddBullet("Cached common patterns: Onboarding greeting/first question cached — no API call. Job details cached aggressively.");
AddBullet("Parallel tool execution: When Claude calls multiple tools (search_jobs + get_profile), execute simultaneously. 6s → 3s.");
AddBullet("Edge compute: API layer on Cloudflare Workers — sub-100ms orchestration. Only latency is the Claude call itself. PrTask runs entirely on edge with D1/KV/R2.");

AddHeading("Q7: System Prompt Structure", "Heading3");
AddPara("Key sections of the system prompt:");
AddBullet("Role definition: \"You are CareerAgent. You help workers find jobs and take action proactively.\"");
AddBullet("Structured worker profile: Name, location, certs, experience, pay floor, availability — injected as typed fields, not conversation replay. Fewer tokens, precise facts.");
AddBullet("Previous session summary: Claude-generated 3-bullet summary from prior session (~50 tokens instead of 2,000 raw history).");
AddBullet("Pending actions: Jobs applied to, responses waiting, reminders set.");
AddBullet("Tool definitions with typed params: search_jobs(criteria), apply_to_job(job_id, message), update_profile(fields), schedule_reminder(datetime, message).");
AddPara("Anti-hallucination rules (critical):", true);
AddBullet("\"NEVER invent job details. Every job MUST come from search_jobs tool call.\" — Claude cannot hallucinate what it must retrieve.");
AddBullet("\"NEVER fabricate salary, company names, or requirements. Only quote data returned by tools.\"");
AddBullet("\"Before any action (apply, message), show the worker your plan and ask for confirmation.\"");
AddBullet("\"If you don't know, say so — do not guess.\"");
AddPara("This tool-first architecture makes responses verifiable: Claude calls search_jobs({location: \"Chicago\", role: \"forklift\"}), orchestrator runs a real DB query, Claude narrates real results. It cannot inject fake entries.");

// ============ SECTION 3 ============
AddHeading("SECTION 3 — SPEED, SCALABILITY & FUNDRAISING MINDSET", "Heading2");

AddHeading("Q8: 3-Week VC Demo Plan", "Heading3");
AddPara("Week 1: The conversation that builds a profile.", true);
AddBullet("Days 1–2: Supabase schema + seed 200 logistics jobs from real data. Claude API + streaming integration.");
AddBullet("Days 3–4: Chat UI (Lovable layout, Claude Code for WebSocket streaming). Worker talks, agent extracts profile, stores in DB.");
AddBullet("Day 5: End-to-end — worker chats 2 min → complete profile.");
AddPara("Week 2: The match and the action.", true);
AddBullet("Days 1–2: Job matching — pgvector embeddings + hard filters (location, certs, pay). Agent surfaces top 3 in conversation.");
AddBullet("Days 3–4: \"Apply for me\" flow — agent drafts, worker confirms, recorded. Employer dashboard shows applications with match scores.");
AddBullet("Day 5: Tune system prompt until conversation feels natural and matches feel relevant.");
AddPara("Week 3: Demo polish.", true);
AddBullet("Days 1–2: Analytics page (profiles, matches, conversion rates with demo data). Landing page.");
AddBullet("Day 3: Record backup demo video. Run live demo 20+ times, fix every edge case in the demo path.");
AddBullet("Days 4–5: Deploy to production URL with SSL + custom domain. Investor opens it on their phone during the pitch.");
AddPara("Demo shows: Worker chats 3 min → matched → says \"apply\" → agent handles it → flip to employer dashboard → application with match score. 5-minute live demo.");
AddPara("Behind the scenes investors don't need to know:", true);
AddBullet("200 jobs were manually seeded, not from live API. \"Employer\" is a demo account. Matching is embeddings + filters, not ML. One server on Railway. Analytics from seeded historical data. No mobile app — responsive web.");
AddPara("None of this is fake — it all works. It's just not production-scale yet. The fundraise buys the time to make it real.");

AddHeading("Q9: Biggest Technical Risk", "Heading3");
AddPara("Cost-per-interaction at scale.", true);
AddPara("A single session (profile extraction + job search + application draft) = 3–5 Claude API calls. At Opus pricing (~$15/$75 per M tokens), each session costs ~$0.15–0.30. At 10,000 daily workers = $1,500–3,000/day = $45K–90K/month before revenue.");
AddPara("Mitigation in V1:", true);
AddBullet("Sonnet for 80% of calls (profile extraction, narration, Q&A). Opus only for complex reasoning. ~5x cost reduction.");
AddBullet("Prompt caching (Anthropic built-in) — repeated system prompt costs drop 90%.");
AddBullet("Summarize, don't replay — previous sessions as 50-token summaries, not full history. Input tokens stay flat.");
AddBullet("Token budget per session — if >4K output tokens, gracefully wrap: \"Great matches found — let me know if you want more tomorrow.\"");
AddBullet("Batch background ops — new-match checking uses embedding similarity (pennies), not full Claude calls. Only invoke Claude when there's something to communicate.");
AddPara("Second risk: Latency. 2–5s Claude calls block synchronous architectures. Mitigation: streaming (hide latency), async WebSocket (not REST), edge compute (sub-100ms non-AI orchestration).");

AddHeading("Q10: Something Live — prtask.com", "Heading3");
AddPara("Link: https://prtask.com", true);
AddPara("PrTask is a developer marketplace — clients post software tasks with payments, developers submit code, payment fires automatically on approval. Live at prtask.com via Cloudflare Worker proxying GitHub Pages. 16 languages. Full legal compliance (Terms, Privacy, Refund, DMCA, Cookie Policy, Accessibility). SSO via GitHub/Google/Azure/Okta. Payment integration with Maya Business.");
AddPara("Stack: .NET 10, Blazor WASM, MAUI Android, Cloudflare Workers (D1 + KV + R2), Automerge CRDTs for real-time sync, USearch vector search, custom multi-language transpiler (Java/JS/TS/C/x86 → C#), custom HTML fingerprinting pipeline. Zero third-party runtime NuGet packages.");
AddPara("Also built: NativeCdpBridge (C:\\work\\NativeCdpBridge) — a CDP bridge making native Android apps controllable via Playwright. Multi-channel routing (Telegram, Viber, SMS, Teams), AI agent integration (Claude, Gemini), accessibility-service-based automation. And a voice chat AI companion with Kokoro TTS, Live2D avatar, and Claude integration (live at cruzlauroiii.github.io/voicechat).");
AddBlank();
AddPara("Decision I'm proud of: Offline-first with Automerge CRDTs.", true);
AddPara("Instead of REST round-trips, the entire data layer uses Automerge CRDTs. Client stores data locally (IndexedDB + OPFS), syncs diffs via WebSocket, merges automatically. I wrote the .NET Automerge bindings from scratch — P/Invoke wrappers around the native C library. Added weeks of work with no existing .NET library. But: app loads instantly (no network wait), works on unreliable mobile connections (critical for Philippines market), sync scales horizontally with no centralized write lock.");
AddBlank();
AddPara("Decision I'd change: Building a full multi-target transpiler.", true);
AddPara("PrTask includes a transpiler converting Java/JS/TS/C/x86 → C# with Android APK decompilation to Blazor components. It works and taught me compiler design deeply, but was over-engineered for the need. 80% of the value could've come from ILSpy + thin wrappers. Consumed weeks that could've gone to user-facing features. Lesson: solve the problem in front of you, not the general case — unless the general case IS the product.");

AddBlank();
AddPara("Thank you for the thorough questionnaire. Happy to dive deeper into any of these during the interview.");
AddBlank();
AddPara("Lauro Cruz III");
AddPara("noahblesse@gmail.com");
AddPara("https://prtask.com");
AddPara("https://linkedin.com/in/lauro-iii-cruz-942a152a2");
}
Console.WriteLine($"Written to {OutputPath}");
