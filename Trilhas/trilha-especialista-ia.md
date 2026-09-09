# Trilha: de dev .NET/Dynamics a especialista em Engenharia de IA

**Versão:** setembro/2026
**Escopo:** engenharia de IA aplicada (agentes, RAG, integração em produto). Não cobre pesquisa nem treinamento de modelos do zero.
**Ritmo assumido:** 4–6 h/semana, ~6 meses até o primeiro patamar de especialista.

---

## 1. O que o mercado está pedindo (leitura de vagas, set/2026)

Amostra: Glassdoor BR, Vagas.com, Indeed BR, BeBee e vagas diretas (Experian, Editora Globo, Senior Sistemas, Digisystem).

### Aparece em quase toda vaga

| Requisito | Observação |
|---|---|
| **Python avançado** | Pedido como linguagem principal, com código limpo, assincronismo e design patterns. É o requisito mais repetido. |
| **Pipelines de RAG ponta a ponta** | Chunking → embedding → retrieval → geração. Não "sabe o que é", e sim "já construiu". |
| **Agentes e multi-agente** | Orquestrador + agentes especializados, delegação, handoff. |
| **Evals de LLM** | Avaliação de qualidade de output, testes automatizados de agentes. Subiu muito de frequência. |
| **Observabilidade / LLMOps** | Monitorar latência, **custo** e qualidade em produção. |
| **Bancos vetoriais** | Pinecone, Weaviate, Chroma, pgvector, Azure AI Search. |
| **Cloud + DevOps** | Azure ou AWS, Docker, CI/CD, Git. |
| **APIs de LLM** | OpenAI, Azure OpenAI, Anthropic (Claude), Gemini — integração multi-provedor. |
| **Frameworks** | LangChain, LlamaIndex, LangGraph, CrewAI, Semantic Kernel. |

### Aparece com frequência média

- Trade-off explícito: fine-tuning vs. prompt engineering vs. RAG, com justificativa de arquitetura.
- Prompt engineering / context engineering como disciplina, não como truque.
- Rastreabilidade, explicabilidade e governança de IA (auditoria, controles, padrões técnicos).
- Inglês C1+ nas vagas remotas para fora / LATAM.
- Diferencial: noções de frontend (React/Vue) para construir interfaces de agente.

### Contexto de carreira

- Guia Salarial Robert Half 2026: engenheiro de IA no Brasil entre **R$ 19.500 e R$ 27.100**.
- Barômetro PwC 2026: vagas júnior expostas a IA têm ~7× mais chance de exigir competências sêniores; no Brasil, 13% das vagas de TMT já são ligadas a IA.
- Belo Horizonte aparece entre as praças com mais vagas de IA no país.

### Leitura honesta do seu posicionamento

**A favor:** .NET/C# sênior, Azure de verdade (Logic Apps, Key Vault, DevOps), SQL/modelagem, Dataverse/Dynamics, integração de dados. O mercado tem muito prompt-engineer sem engenharia; você tem a engenharia. E o lado .NET ficou legítimo: com o **Microsoft Agent Framework 1.0 (GA em 02–03/abr/2026)**, C# tem um SDK de agentes de primeira classe, com as mesmas capacidades da versão Python.

**Contra (os três gaps que fecham a distância):**

1. **Python.** Não dá para contornar. Mesmo que você entregue em .NET no BHS, as vagas filtram por Python e o ecossistema de avaliação/experimentação vive lá.
2. **Evals e observabilidade.** É o que mais separa "fez um POC" de "botou em produção" — e é o que mais aparece nas vagas sênior.
3. **Portfólio público.** Currículo de IA hoje é repositório + texto técnico, não certificado.

> Decisão prática: **.NET/MAF é a sua entrega no trabalho; Python é a sua entrega para o mercado.** Faça os dois nas mesmas fases, resolvendo o mesmo problema duas vezes. Isso não é retrabalho, é o que te faz entender a abstração.

---

## 2. Estado do ecossistema (o que mudou e você precisa saber)

Base para não estudar material vencido:

- **MCP 2026-07-28** (spec final em 28/jul/2026): núcleo **stateless**, Multi Round-Trip Requests, roteamento por header, resultados de lista cacheáveis, framework formal de extensões e política de depreciação. O handshake `initialize`/`initialized` e o header `Mcp-Session-Id` foram removidos — versão, identidade e capabilities do cliente viajam no `_meta` de cada requisição. Servidor MCP escrito antes disso tem migração pendente.
- **Agent Plugins 1.0.0** (06/ago/2026): padrão neutro para empacotar Agent Skills + servidores MCP. Um plugin é um diretório com `plugin.json`, `skills/` e `mcp.json`. Mantenedores: Amazon, Cursor, Microsoft, OpenAI, Vercel (Google entrou depois). **Ponto de atenção:** a v1 não define modelo de permissão, sandbox, assinatura nem mecanismo de segredos — tudo listado como trabalho futuro.
- **Microsoft Agent Framework 1.0** (abr/2026): sucessor de Semantic Kernel + AutoGen, com suporte nativo a MCP e A2A. Semantic Kernel está em modo manutenção. Renomeações que quebram na migração: `AgentThread` → `AgentSession`, `GetNewThread()` → `CreateSessionAsync()`, `AgentRunResponse` → `AgentResponse`, `CreateAIAgent()` → `AsAIAgent()`.
- **Camadas do stack .NET:** `Microsoft.Extensions.AI` (`IChatClient`, abstração de provedor) → Agent Framework (agentes e workflows) → provedor (Azure OpenAI, OpenAI, Anthropic, Ollama). Conflatar essas camadas é o erro de arquitetura mais comum.

---

## 3. A trilha

### Fase 0 — Nivelamento do cenário (2 semanas) · *em andamento*

**Estudar:** spec MCP 2026-07-28 (changelog completo), Agent Plugins 1.0, panorama MAF 1.0, Claude Agent SDK.
**Entregável:** um resumo seu de uma página por spec, com o que muda no código que você já escreveu.
**Cobre do mercado:** vocabulário e atualidade — o filtro de entrevista técnica.

---

### Fase 1 — Fundamentos que não envelhecem (3 semanas)

**Estudar:**
- Tokenização e custo real por chamada (tokens de entrada/saída, cache de prompt).
- Embeddings, espaço vetorial, similaridade de cosseno, dimensionalidade.
- Janela de contexto: o que acontece quando enche, truncamento, context rot.
- Sampling: temperatura, top-p, e quando determinismo importa.
- Structured output / tool calling: schema, validação, e por que falha.
- Context engineering: o que entra no prompt, em que ordem, e o que fica de fora.

**Em paralelo — Python (o gap #1):** ambiente (uv/venv), tipagem, `async`/`await`, Pydantic, pytest, `httpx`. Não é curso de Python do zero — é portar o que você já sabe fazer em C#.

**Entregável:** um documento curto explicando por que uma chamada específica do seu app custa X e demora Y, com número medido, não estimado.
**Cobre do mercado:** Python, prompt/context engineering, noção de custo.

---

### Fase 2 — Recuperação sobre dados reais (4 semanas)

Aqui está sua vantagem competitiva real: quase ninguém sabe fazer RAG bem em cima de Dataverse.

**Estudar:**
- Estratégias de chunking (fixo, semântico, por estrutura de documento) e por que a escolha domina o resultado.
- Busca híbrida: BM25 + vetorial, e reranking.
- Metadados e filtro de segurança **por linha** — o problema real em Dataverse, onde permissão não é opcional.
- Azure AI Search + pgvector como as duas opções que você vai defender em reunião.
- Métricas de retrieval: recall@k, precision@k, MRR.

**Entregável:** buscador sobre uma entidade real do BHS.Outsourcing, **medido**. Não "parece bom" — número em cima de um conjunto de perguntas que você escreveu.
**Cobre do mercado:** pipeline RAG ponta a ponta, vector DB, dados corporativos com segurança.

---

### Fase 3 — Agentes em produção (5 semanas)

**Estudar:**
- MAF 1.0 em .NET como base, MCP como camada de ferramentas.
- Design de tool: descrição, schema, idempotência, e erro que o modelo consegue ler e corrigir.
- Orquestração: sequencial, concorrente, handoff, group chat, Magentic-One.
- Human-in-the-loop e checkpointing.
- Retry, timeout, teto de custo por execução. Fan-out concorrente multiplica chamadas — e conta.
- **Espelho em Python:** o mesmo agente com LangGraph ou Claude Agent SDK, para ter o vocabulário das vagas.

**Entregável:** um agente que resolve uma tarefa chata e repetitiva do seu dia (candidato natural: algo de Dataverse/integração), rodando de verdade, com custo por execução conhecido.
**Cobre do mercado:** agentes, multi-agente, orquestração, frameworks, integração de APIs de LLM.

---

### Fase 4 — Avaliação e observabilidade (4 semanas) · **fase que mais rende**

É aqui que se separa quem é especialista. Também é o requisito que mais cresceu nas vagas sênior.

**Estudar:**
- Construção de dataset de avaliação a partir de casos reais.
- LLM-as-judge: como montar, e os vieses conhecidos (posição, verbosidade, auto-preferência).
- Testes de regressão de qualidade em CI (Azure DevOps — você já domina o pipeline).
- Tracing com OpenTelemetry; custo e latência por trace.
- Ferramentas: Promptfoo, LangSmith, Azure AI Foundry evaluations.

**Entregável:** suíte de evals que roda no Azure DevOps e **quebra o build** quando a qualidade cai. Este é o artefato mais valioso da trilha inteira para entrevista.
**Cobre do mercado:** LLM evals, LLMOps, observabilidade, monitoramento de latência/custo/qualidade.

---

### Fase 5 — Segurança e governança (3 semanas)

**Estudar:**
- Prompt injection direta e indireta (via documento indexado e via resultado de tool).
- Confused deputy: o agente age com a permissão de quem?
- Escopo de identidade do agente sobre Dataverse; segredos em Key Vault.
- A lacuna explícita do Agent Plugins 1.0 (sem permissão, sandbox, assinatura ou segredos).
- OWASP Top 10 para aplicações LLM.

**Entregável:** threat model de uma página do agente da Fase 3, com mitigação e risco residual assumido.
**Cobre do mercado:** governança, rastreabilidade, auditoria, controles — cada vez mais explícito nas vagas.

---

### Fase 6 — Especialização visível (contínua, começa na Fase 3)

**Fazer:**
- Publicar um plugin interno no padrão Agent Plugins.
- Escrever sobre a migração MCP stateless em .NET — tem pouquíssimo material em português e quase nada com C#.
- Ser a referência do BHS no assunto: revisar arquitetura de IA dos outros times.
- Palestrar em meetup de BH ou comunidade .NET.

**Entregável:** dois repositórios públicos e dois textos técnicos.
**Cobre do mercado:** o filtro real de contratação sênior em IA hoje.

---

## 4. Cronograma resumido

| Semanas | Fase | Entregável |
|---|---|---|
| 1–2 | Nivelamento do cenário | Resumos das specs |
| 3–5 | Fundamentos + Python | Análise de custo/latência medida |
| 6–9 | Recuperação sobre dados reais | Buscador sobre Dataverse, com métrica |
| 10–14 | Agentes em produção | Agente rodando (.NET + espelho Python) |
| 15–18 | Avaliação e observabilidade | Suíte de evals no CI |
| 19–21 | Segurança e governança | Threat model |
| 22+ | Especialização visível | Repositórios + textos |

---

## 5. O que eu pularia

- **Treinar modelo do zero.** Não é o trabalho, e não é o que a vaga pede.
- **Fine-tuning antes de esgotar prompt + RAG.** As vagas pedem que você *saiba escolher* entre as três abordagens, não que faça fine-tuning por padrão.
- **Certificação como objetivo.** AI-102 e a credencial Applied Skills de agentes com Azure OpenAI são úteis se o BHS pagar e valorizar internamente. Não substituem repositório.
- **Colecionar frameworks.** Dominar um de cada lado (MAF no .NET, LangGraph ou Claude Agent SDK no Python) e entender o padrão por trás vale mais que tocar em seis.
- **Material de Semantic Kernel como base.** SK está em manutenção; muito tutorial de 2025 está vencido.

---

## 6. Fontes

- MCP 2026-07-28: https://blog.modelcontextprotocol.io/posts/2026-07-28/ · https://modelcontextprotocol.io/specification/2026-07-28
- Agent Plugins 1.0.0: https://agent-plugins.org/specification · https://developers.googleblog.com/agent-plugins-package-your-skills-tools-and-more/
- Microsoft Agent Framework 1.0: https://devblogs.microsoft.com/agent-framework/microsoft-agent-framework-version-1-0/ · https://visualstudiomagazine.com/articles/2026/04/06/microsoft-ships-production-ready-agent-framework-1-0-for-net-and-python.aspx
- Stack .NET para agentes em 2026: https://managed-code.com/blog-post/building-ai-agents-with-csharp-dotnet
- Vagas: https://www.glassdoor.com.br/Vaga/engenheiro-de-ia-sr-vagas-SRCH_KO0,19.htm · https://jobs.experian.com/job/engenheiro-de-genai-llms-rag-e-arquiteturas-de-agentes-in-sao-paulo-brazil-jid-3428 · https://www.vagas.com.br/vagas/v2811925/engenheiro-de-inteligencia-artificial-ia
- Salários e contexto: https://forbes.com.br/carreira/2026/02/engenheiro-de-ia-o-que-faz-quanto-ganha-profissao-mais-cresce-brasil/
