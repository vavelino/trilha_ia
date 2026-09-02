# Trilha Profissional de AI Engineering

> **Objetivo:** preparar um desenvolvedor C#/.NET para construir, avaliar, publicar e operar aplicações de IA generativa com valor de portfólio e aderência às competências encontradas em vagas atuais.
>
> **Duração sugerida:** 10 a 12 semanas, com 6 a 8 horas por semana.
>
> **Abordagem:** 20% conceitos, 70% implementação e 10% comunicação/portfólio.
>
> **Stack principal:** C# / .NET, Azure, REST, Docker e GitHub Actions ou Azure DevOps.
>
> **Stack complementar:** Python funcional para compreender exemplos, avaliações e ferramentas dominantes no ecossistema de IA.

---

# 1. Como esta trilha foi priorizada

Esta trilha foi criada em setembro de 2026 a partir de uma análise qualitativa de vagas recentes de AI Engineer, Generative AI Engineer e Azure Generative AI Developer no Brasil e no exterior. A amostra não representa estatisticamente todo o mercado; ela serve para identificar padrões recorrentes e orientar um plano prático.

## Sinais recorrentes nas vagas

| Competência | Prioridade | Evidência observada |
|---|---:|---|
| Engenharia de software, APIs e integração | Essencial | Aplicações de IA precisam virar serviços confiáveis e integrar sistemas corporativos. |
| LLMs, prompting, contexto e saída estruturada | Essencial | Base para controlar entradas, saídas e integração. |
| RAG, embeddings e busca vetorial/híbrida | Essencial | Um dos requisitos mais recorrentes nas vagas analisadas. |
| Agents, tools e workflows | Muito alta | Frequente em vagas atuais, especialmente para automação corporativa. |
| Evaluation e qualidade | Muito alta | Diferencia protótipo de sistema confiável e aparece com força em vagas maduras. |
| Observabilidade, custo e latência | Muito alta | Requisito de produção recorrente. |
| Segurança, governança e Responsible AI | Muito alta | Especialmente relevante em Azure e ambientes corporativos. |
| Azure/Cloud, Docker e CI/CD | Muito alta | Vagas procuram entrega em produção, não somente notebooks. |
| Python | Alta | É a linguagem mais recorrente nas vagas de AI Engineering pesquisadas. |
| C#/.NET | Alta no nicho Microsoft | Aparece em integrações enterprise; será a stack principal desta trilha. |
| MCP | Média e crescente | Aparece em vagas e na trilha atual de agentes da Microsoft, mas ainda menos que RAG e APIs. |
| Fine-tuning | Opcional | Surge em algumas vagas seniores, geralmente depois de RAG, avaliação e operação. |
| Multi-agent avançado | Opcional | Útil em cenários específicos, não é pré-requisito para um bom portfólio inicial. |

## Evidências de mercado usadas

- Azure OpenAI, RAG, embeddings, vector search, APIs em Python ou C#, identidade, RBAC, CI/CD e MLOps: [TechHuman — Azure Generative AI Developer](https://www.linkedin.com/jobs/view/azure-generative-ai-developer-at-techhuman-4441009099).
- RAG, agents, APIs, Azure, Docker/Kubernetes, CI/CD, segurança, avaliação, observabilidade e MCP: [InterImage — Generative AI Engineer](https://www.linkedin.com/jobs/view/generative-ai-engineer-clearance-required-with-security-clearance-at-interimage-4439063911).
- RAG ponta a ponta, embeddings, bancos vetoriais, avaliação, observabilidade, custo e comunicação: [Luby — Engenheiro de IA](https://br.linkedin.com/jobs/view/profissional-engenheiro-de-ia-fullstack-s%C3%AAnior-remoto-at-luby-4435706242).
- Avaliação de LLMs, RAG avançado, hybrid search, reranking, parsing, agentes, APIs e pipelines: [CWI — Engenheiro de IA](https://br.linkedin.com/jobs/view/engenheiro-de-ia-gcp-at-cwi-software-4381464471).
- Ecossistema Microsoft, prompt engineering, RAG, métricas, governança, segurança e Python: [Meta — IA Generativa e LLMs](https://br.linkedin.com/jobs/view/engenheiro-de-ia-generativa-e-llms-s%C3%AAnior-at-meta-4361084757).
- Parsing, chunking, RAG, modelos locais, citações, avaliação, privacidade e MLflow: [Convergenz — Generative AI Engineer](https://www.linkedin.com/jobs/view/generative-ai-engineer-at-convergenz-4443727282).

## Alinhamento com Microsoft

A trilha atual da Microsoft para AI Engineer inclui Foundry, agentes, custom tools, MCP, RAG/knowledge, testes e deploy. O guia AI-103 de 2026 destaca Python, segurança, managed identity, rede privada e políticas de acesso. [Microsoft Learn — agentes no Azure](https://learn.microsoft.com/en-us/training/paths/develop-ai-agents-azure/), [Microsoft Learn — AI-103](https://learn.microsoft.com/en-us/credentials/certifications/resources/study-guides/ai-103).

---

# 2. Resultado profissional esperado

Ao concluir a trilha, eu devo conseguir:

- [ ] transformar um problema de negócio em caso de uso apropriado para IA;
- [ ] consumir diferentes APIs de LLM sem acoplamento excessivo ao provedor;
- [ ] produzir e validar saídas estruturadas;
- [ ] implementar tools com validação, autorização e tratamento de falhas;
- [ ] construir e avaliar um RAG com fontes e citações;
- [ ] implementar um agent loop limitado e observável;
- [ ] integrar uma capacidade por MCP e justificar seu uso;
- [ ] medir qualidade, retrieval, latência, tokens e custo;
- [ ] aplicar autenticação, autorização, proteção de dados e guardrails;
- [ ] publicar o sistema em container com CI/CD;
- [ ] explicar decisões, trade-offs, falhas e resultados mensuráveis;
- [ ] demonstrar tudo em um projeto de portfólio executável.

## Regra de conclusão

```text
EXPLICAR
   ↓
IMPLEMENTAR
   ↓
TESTAR
   ↓
MEDIR
   ↓
JUSTIFICAR
```

---

# 3. Projeto contínuo de portfólio

## Developer Work Assistant

Construir um assistente que recebe uma tarefa de desenvolvimento e:

- interpreta título, descrição, comentários e relações;
- retorna resumo e tarefas técnicas em JSON validado;
- consulta documentação interna com RAG;
- usa tools para acessar dados simulados de projeto e work items;
- expõe ou consome pelo menos uma capacidade via MCP;
- gera plano, riscos, perguntas e testes sugeridos;
- apresenta fontes;
- registra traces, latência, tokens, custo e chamadas de tools;
- possui dataset de avaliação e relatório comparativo;
- roda localmente com Docker e possui pipeline de CI.

```text
Cliente
  ↓
ASP.NET Core API
  ↓
AI Application Layer
  ├── LLM Provider
  ├── Structured Output
  ├── RAG / Azure AI Search
  ├── Tools / MCP
  ├── Agent Workflow
  └── Evaluation / Telemetry
```

## Portfólio final

- [ ] repositório público sem segredos;
- [ ] README com problema, arquitetura, setup e limitações;
- [ ] diagrama de arquitetura;
- [ ] exemplos reproduzíveis;
- [ ] testes automatizados;
- [ ] dataset de avaliação;
- [ ] relatório com métricas antes/depois;
- [ ] Dockerfile e pipeline CI;
- [ ] vídeo ou GIF curto demonstrando o fluxo;
- [ ] seção “decisões e trade-offs”.

---

# 4. Fase 1 — Aplicações LLM confiáveis

**Duração:** 1 semana.

## Competências

- [ ] revisar tokens, contexto, inferência, temperatura e alucinação;
- [ ] diferenciar modelo, API e aplicação de IA;
- [ ] trabalhar com system/user prompts e templates versionados;
- [ ] separar instruções de dados não confiáveis;
- [ ] implementar Structured Output com JSON Schema;
- [ ] desserializar para DTOs e validar regras de negócio;
- [ ] implementar timeout, cancellation, retry e rate-limit handling;
- [ ] configurar chaves com variáveis de ambiente ou identidade gerenciada;
- [ ] trocar modelo/provedor por configuração;
- [ ] registrar latência, tokens e erros.

## Entrega

Evoluir `HelloLlm` para `TaskAnalyzer`:

- [ ] receber uma tarefa;
- [ ] retornar `summary`, `technicalTasks`, `risks` e `questions`;
- [ ] usar schema;
- [ ] validar a resposta;
- [ ] testar cinco entradas;
- [ ] comparar duas versões do prompt.

---

# 5. Fase 2 — Tool Calling e integrações

**Duração:** 1 a 2 semanas.

## Competências

- [ ] entender o ciclo de tool calling;
- [ ] desenhar schemas pequenos e explícitos;
- [ ] validar parâmetros antes da execução;
- [ ] aplicar allowlist de tools;
- [ ] diferenciar tool de resposta textual;
- [ ] implementar autenticação e autorização por tool;
- [ ] tratar timeout, falha parcial e idempotência;
- [ ] registrar nome, argumentos seguros, duração e resultado;
- [ ] exigir aprovação para ações críticas;
- [ ] integrar APIs REST e banco de dados sem entregar credenciais ao modelo.

## Entrega

Adicionar `GetWorkItem`, `GetProject`, `SearchDocumentation` e `CreateImplementationPlan`.

- [ ] pelo menos três tools funcionais;
- [ ] uma falha controlada;
- [ ] uma tool sujeita a autorização;
- [ ] testes de parâmetros inválidos;
- [ ] logs das decisões e execuções.

---

# 6. Fase 3 — Embeddings, busca e RAG

**Duração:** 2 semanas.

## Competências

- [ ] embeddings e similaridade de cosseno;
- [ ] parsing de Markdown, HTML e PDF;
- [ ] chunking, overlap e metadados;
- [ ] indexação e top-k;
- [ ] busca textual, vetorial e híbrida;
- [ ] metadata filtering;
- [ ] query rewriting e reranking em alto nível;
- [ ] grounding, citações e recusa por falta de evidência;
- [ ] investigação de retrieval ruim;
- [ ] proteção contra prompt injection em documentos.

A busca híbrida é importante no mercado porque combina busca textual e vetorial; no Azure AI Search, ambas rodam em paralelo e os resultados são combinados. [Microsoft Learn — Hybrid Search](https://learn.microsoft.com/en-us/azure/search/hybrid-search-overview).

## Entrega

Ingerir documentação do próprio projeto e responder perguntas com fontes.

- [ ] 20 a 50 documentos ou trechos;
- [ ] pipeline de parsing e chunking;
- [ ] índice local primeiro;
- [ ] adaptação para Azure AI Search depois;
- [ ] citações verificáveis;
- [ ] comparação keyword vs vector vs hybrid;
- [ ] pelo menos 20 perguntas de avaliação.

---

# 7. Fase 4 — Agents, workflows e MCP

**Duração:** 2 semanas.

## Competências

- [ ] entender agent loop, estado, tools e condição de parada;
- [ ] diferenciar workflow determinístico de decisão agentic;
- [ ] aplicar limite de passos, timeout e orçamento;
- [ ] implementar human-in-the-loop;
- [ ] registrar decisões e tool calls;
- [ ] testar falhas, repetição e parada;
- [ ] diferenciar MCP de API REST e tool calling;
- [ ] criar ou consumir um MCP Server;
- [ ] aplicar autenticação, autorização e menor privilégio;
- [ ] usar framework somente após implementar o fluxo básico.

Frameworks recomendados no ecossistema escolhido:

- Microsoft Agent Framework ou Foundry Agent Service para agentes;
- Semantic Kernel para integração .NET, plugins e MCP;
- implementação própria pequena para compreender o loop.

A trilha oficial atual da Microsoft inclui custom tools, MCP, RAG e workflows de agentes. [Microsoft Learn](https://learn.microsoft.com/en-us/training/paths/develop-ai-agents-azure/). O Semantic Kernel possui suporte a C# e integração com MCP. [Microsoft Learn — Semantic Kernel e MCP](https://learn.microsoft.com/en-us/semantic-kernel/concepts/plugins/adding-mcp-plugins).

## Entrega

O assistente deve decidir quando buscar tarefa, documentação ou projeto.

- [ ] pelo menos três tools;
- [ ] máximo de iterações;
- [ ] condição de parada;
- [ ] aprovação para uma ação crítica simulada;
- [ ] uma tool consumida por MCP;
- [ ] trace completo de uma execução.

---

# 8. Fase 5 — Evaluation, observabilidade e segurança

**Duração:** 2 semanas.

## Evaluation

- [ ] criar dataset versionado com entradas e respostas esperadas;
- [ ] medir correctness, relevance, groundedness e completeness;
- [ ] medir precisão do retrieval e source attribution;
- [ ] medir tool success rate;
- [ ] comparar prompts, modelos e configurações;
- [ ] detectar regressões;
- [ ] usar avaliação humana e automatizada;
- [ ] entender limites de LLM-as-a-judge.

## Observabilidade

- [ ] correlation ID e logs estruturados;
- [ ] traces de prompts, retrieval e tools com redaction;
- [ ] latência total e por etapa;
- [ ] tokens e custo por requisição;
- [ ] erros, retries e rate limits;
- [ ] dashboards e alertas mínimos;
- [ ] não registrar segredos ou dados pessoais sem necessidade.

## Segurança

- [ ] prompt injection direta e indireta;
- [ ] vazamento de dados e tratamento de PII;
- [ ] autenticação, RBAC e managed identity;
- [ ] least privilege e allowlist de tools;
- [ ] input/output validation;
- [ ] rate limiting e limites de custo;
- [ ] approval gates;
- [ ] audit trail;
- [ ] threat model simples.

## Entrega

- [ ] dataset com no mínimo 30 casos;
- [ ] casos adversariais e de informação ausente;
- [ ] relatório antes/depois de uma melhoria;
- [ ] dashboard ou relatório de latência, custo e erros;
- [ ] teste de prompt injection;
- [ ] documento de ameaças e mitigações.

---

# 9. Fase 6 — Produção em Azure

**Duração:** 1 a 2 semanas.

## Competências

- [ ] ASP.NET Core API e health checks;
- [ ] configuração por ambiente;
- [ ] Docker e execução reproduzível;
- [ ] CI com build, testes e análise estática;
- [ ] CD para um ambiente de demonstração;
- [ ] Azure Container Apps, App Service ou Functions;
- [ ] Key Vault e managed identity;
- [ ] Application Insights/OpenTelemetry;
- [ ] Azure AI Search;
- [ ] filas para trabalhos longos quando necessário;
- [ ] cache, concorrência e rate limiting;
- [ ] estimativa e limite de custo;
- [ ] rollback e comportamento quando o modelo falha.

## Entrega

- [ ] imagem Docker;
- [ ] pipeline verde;
- [ ] deploy documentado;
- [ ] secrets fora do repositório;
- [ ] telemetria funcionando;
- [ ] teste de carga pequeno;
- [ ] runbook de falhas comuns;
- [ ] estimativa mensal de custo.

---

# 10. Python funcional para empregabilidade

**Duração:** paralela, 30 a 60 minutos por semana.

O objetivo não é trocar C# por Python. É conseguir trabalhar com exemplos, SDKs, notebooks e equipes em que Python é predominante.

- [ ] ambiente virtual, `pip` e `pyproject.toml`;
- [ ] tipos, funções, classes e tratamento de erros;
- [ ] leitura de JSON e chamadas HTTP;
- [ ] FastAPI básico;
- [ ] pytest básico;
- [ ] notebook para experimento e avaliação;
- [ ] executar um exemplo simples de embedding/RAG;
- [ ] converter uma prova de conceito Python em serviço .NET ou vice-versa.

## Entrega mínima

- [ ] um script de avaliação;
- [ ] uma API pequena em FastAPI;
- [ ] README explicando quando escolher C# ou Python.

---

# 11. O que não priorizar antes do portfólio principal

- [ ] treinamento de LLM do zero;
- [ ] matemática profunda de redes neurais;
- [ ] PyTorch/TensorFlow avançado;
- [ ] fine-tuning sem dataset e avaliação claros;
- [ ] multi-agent sem justificativa;
- [ ] muitos frameworks de orquestração;
- [ ] Kubernetes antes de existir necessidade de escala;
- [ ] knowledge graphs antes de dominar RAG básico e híbrido;
- [ ] certificação sem projeto demonstrável.

Esses tópicos podem ser estudados depois, quando uma vaga-alvo ou necessidade real justificar o investimento.

---

# 12. Cronograma sugerido

| Semana | Foco | Entrega verificável |
|---:|---|---|
| 1 | LLM API + prompts + contexto | `HelloLlm` revisado |
| 2 | Structured Output | `TaskAnalyzer` com DTO/schema |
| 3 | Tool Calling | três tools com testes |
| 4 | Embeddings e busca | comparação textual/vetorial |
| 5 | RAG básico | respostas com fontes |
| 6 | RAG avançado e avaliação | relatório de retrieval |
| 7 | Agent loop | agente com limites e traces |
| 8 | MCP + segurança | integração MCP com autorização |
| 9 | Evals + observabilidade | dataset, métricas e regressões |
| 10 | Docker + CI/CD + Azure | deploy reproduzível |
| 11 | Hardening | threat model, carga e custo |
| 12 | Portfólio e entrevistas | README, demo e casos STAR |

Se houver apenas quatro horas por semana, manter a sequência e dobrar a duração, sem cortar testes, avaliação ou segurança.

---

# 13. Critério de prontidão para vagas

## Eu consigo demonstrar

- [ ] uma aplicação LLM em produção ou ambiente de demonstração;
- [ ] um RAG avaliado, não apenas funcionando visualmente;
- [ ] um agent workflow com tools, limites e logs;
- [ ] uma integração MCP simples;
- [ ] um problema real encontrado por observabilidade;
- [ ] uma regressão detectada por evals;
- [ ] uma ameaça mitigada por controle de aplicação;
- [ ] custo e latência medidos;
- [ ] decisão justificada entre regra, workflow e agent;
- [ ] decisão justificada entre C#, Python e serviço gerenciado.

## Eu consigo explicar em entrevista

- [ ] por que RAG foi escolhido em vez de fine-tuning;
- [ ] como chunking afetou retrieval;
- [ ] quando busca híbrida superou busca vetorial;
- [ ] por que temperatura não garante precisão;
- [ ] como evitar que uma tool execute ação indevida;
- [ ] como detectar alucinação ou resposta sem grounding;
- [ ] o que acontece quando o provedor retorna 429/503;
- [ ] como medir se uma mudança de prompt melhorou o sistema;
- [ ] quais dados não devem entrar em logs ou contexto;
- [ ] quais trade-offs foram aceitos no projeto.

## Evidência no currículo

Evitar descrições genéricas como “estudei RAG”. Preferir resultados demonstráveis:

```text
Implementei um assistente RAG em .NET e Azure AI Search,
avaliei 30 perguntas versionadas, melhorei a precisão de retrieval
de X para Y e reduzi a latência p95 de A para B.
```

Usar números reais medidos no projeto; nunca inventar métricas.

---

# 14. Certificações opcionais

Certificações ajudam como complemento, não substituem portfólio e experiência prática.

- AI-103, quando disponível para o perfil: aplicações e agentes no Microsoft Foundry.
- AZ-204: desenvolvimento de soluções Azure.
- Certificação relacionada a Azure AI Search ou dados, se exigida pelas vagas-alvo.

Antes de investir, conferir o guia oficial vigente, pois exames e códigos mudam.

---

# 15. Revisão mensal de mercado

A cada quatro semanas:

1. selecionar 10 vagas-alvo;
2. registrar competências exigidas;
3. separar recorrente de específico;
4. comparar com esta trilha;
5. adicionar somente lacunas recorrentes ou diretamente ligadas a uma vaga-alvo;
6. remover tecnologias sem aplicação prática;
7. atualizar a data e as fontes.

O objetivo não é perseguir toda ferramenta citada em vagas. É construir fundamentos transferíveis e evidências de entrega profissional.
