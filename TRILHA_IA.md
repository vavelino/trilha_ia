# Trilha de Estudos — AI Engineering Aplicada ao Desenvolvimento

> **Objetivo:** aprender IA aplicada ao desenvolvimento de software de forma prática, com foco em LLMs, ferramentas de coding assistido por IA, Context Engineering, Tool Calling, MCP, RAG, Agents, avaliação, segurança e arquitetura.
>
> **Abordagem:** 30% teoria + 70% prática.
>
> **Stack principal:** C# / .NET + Azure.
>
> **Ferramentas de apoio:** Claude Code, Codex e outras ferramentas de AI Coding.
>
> **Regra da trilha:** um tópico só é considerado concluído quando eu consigo **explicar, implementar, testar e justificar** o que fiz.

---

# 0. Como usar este arquivo

Este arquivo deve ser a **fonte principal de progresso da trilha**.

Ao iniciar uma sessão no Codex:

1. Leia este arquivo inteiro.
2. Localize a primeira tarefa ainda não marcada.
3. Trabalhe somente na etapa atual, salvo se eu pedir para avançar.
4. Explique o conceito antes ou durante a implementação.
5. Não entregue somente código: explique as decisões importantes.
6. Sempre proponha um pequeno exercício prático.
7. Ao finalizar uma atividade:
   - validar o código;
   - executar os testes;
   - revisar o que aprendi;
   - atualizar o checklist.
8. Não marcar um item como concluído apenas porque o código foi gerado.
9. Se eu não conseguir explicar o conceito com minhas palavras, o tópico ainda não está concluído.

## Fluxo de estudo

```text
TEORIA
  ↓
EXEMPLO
  ↓
IMPLEMENTAÇÃO
  ↓
TESTES
  ↓
EXPLICAÇÃO COM MINHAS PALAVRAS
  ↓
REVISÃO
  ↓
CHECK ✅
```

---

# 1. Visão geral da trilha

```text
Fundamentos de LLM
        ↓
Prompt + Context Engineering
        ↓
AI Coding / Claude Code
        ↓
APIs de LLM
        ↓
Structured Output
        ↓
Tool / Function Calling
        ↓
MCP
        ↓
Embeddings
        ↓
Vector Search
        ↓
RAG
        ↓
Agents
        ↓
Agentic Workflows
        ↓
Evaluation
        ↓
Observability
        ↓
Security / Guardrails
        ↓
Arquitetura
        ↓
Projeto Integrador
```

## Prioridade

### Prioridade muito alta

- Claude Code / AI Coding
- Context Engineering
- Skills
- Tools / Function Calling
- MCP
- RAG

### Prioridade alta

- Embeddings
- Vector Search
- Agents
- Evaluation
- Observability
- Segurança

### Depois

- Multi-Agent avançado
- Fine-tuning
- LoRA / PEFT
- Machine Learning tradicional
- treinamento de redes neurais
- frameworks muito específicos

---

# 2. Cronograma sugerido

| Etapa | Duração |
|---|---:|
| Fundamentos de LLM | 1–2 semanas |
| Prompt + Context Engineering | 1 semana |
| AI Coding / Claude Code | 2 semanas |
| APIs + Tool Calling | 2 semanas |
| MCP | 2 semanas |
| Embeddings + Vector Search + RAG | 3 semanas |
| Agents | 3 semanas |
| Evaluation + Segurança + Observabilidade | 2 semanas |
| Arquitetura + Capstone | 2–3 semanas |

**Total estimado:** 16–18 semanas.

Sugestão de ritmo:

- 4 a 6 horas por semana.
- 2 ou 3 sessões de estudo.
- Sempre produzir código ou algum artefato verificável.

---

# 3. ETAPA 1 — Fundamentos de IA Generativa e LLMs

## Objetivo

Entender como aplicações baseadas em LLM funcionam sem entrar profundamente em matemática ou treinamento de redes neurais.

## Conceitos

- [x] Diferenciar IA, Machine Learning e Deep Learning.
- [x] Entender o que é um Large Language Model.
- [x] Entender o que é inferência.
- [x] Entender tokens.
- [x] Entender context window.
- [x] Entender Transformer em alto nível.
- [x] Entender Attention em alto nível.
- [x] Entender embeddings conceitualmente.
- [x] Entender hallucination.
- [x] Entender temperatura e parâmetros de geração.
- [x] Diferenciar modelos proprietários e open-source.
- [x] Entender limitações básicas de LLMs.

## Não priorizar agora

- [ ] Treinar uma rede neural do zero.
- [ ] Matemática profunda de redes neurais.
- [ ] TensorFlow/PyTorch avançado.
- [ ] ML para visão computacional.
- [ ] treinamento completo de modelos.

Esses itens podem ser estudados posteriormente caso exista uma necessidade real.

## Prática

### Projeto 1 — Hello LLM

Criar uma aplicação console em .NET que:

- [x] receba uma pergunta;
- [x] envie a pergunta para um LLM;
- [x] imprima a resposta;
- [x] registre quantidade de tempo da requisição;
- [x] trate erros básicos;
- [x] permita trocar o modelo por configuração.

## Definition of Done

Eu consigo explicar:

- [x] O que acontece entre minha aplicação e o modelo.
- [x] O que é um token.
- [x] Por que contexto tem limite.
- [x] Por que um LLM pode alucinar.
- [x] Qual a diferença entre modelo e aplicação de IA.

---

# 4. ETAPA 2 — Prompt Engineering e Context Engineering

## Objetivo

Aprender a controlar melhor o comportamento de LLMs e fornecer o contexto correto.

## Prompt Engineering

- [ ] System Prompt.
- [ ] User Prompt.
- [ ] Instruções claras.
- [ ] Few-shot examples.
- [ ] Prompt templates.
- [ ] Prompt chaining.
- [ ] Decomposição de tarefas.
- [ ] Estratégias para diminuir respostas inconsistentes.
- [ ] Estratégias para reduzir alucinações.

## Structured Output

- [ ] Solicitar JSON.
- [ ] Validar JSON.
- [ ] Utilizar schema.
- [ ] Entender por que saída estruturada é melhor para integração entre sistemas.

## Context Engineering

- [ ] O que é contexto.
- [ ] Contexto global vs contexto da tarefa.
- [ ] O que deve entrar no contexto.
- [ ] O que não deve entrar no contexto.
- [ ] Como evitar contexto desnecessário.
- [ ] Context pruning.
- [ ] Context stitching em alto nível.
- [ ] Reuso de contexto.
- [ ] Custo de contexto.
- [ ] Contexto persistente vs temporário.

## Exercício

Criar um prompt que recebe uma descrição de tarefa do Azure DevOps e retorna:

```json
{
  "summary": "",
  "technicalTasks": [],
  "risks": [],
  "questions": []
}
```

Checklist:

- [ ] criar prompt inicial;
- [ ] testar com 5 tarefas diferentes;
- [ ] identificar inconsistências;
- [ ] melhorar prompt;
- [ ] definir formato estruturado;
- [ ] validar a saída.

## Definition of Done

- [ ] Consigo explicar Prompt Engineering.
- [ ] Consigo explicar Context Engineering.
- [ ] Sei a diferença entre prompt e contexto.
- [ ] Sei quando uma informação deveria ficar fora do contexto.
- [ ] Consigo gerar uma saída estruturada confiável.

---

# 5. ETAPA 3 — AI Coding e Claude Code

## Objetivo

Deixar de usar AI Coding apenas como "gerador de código" e aprender a configurar o agente como parte do ambiente de desenvolvimento.

## Conceitos gerais de AI Coding

- [ ] Agentic Coding.
- [ ] Context management.
- [ ] Planning.
- [ ] Permissions.
- [ ] Tools.
- [ ] Skills.
- [ ] Hooks.
- [ ] Subagents.
- [ ] Checkpoints.
- [ ] Sessões paralelas.
- [ ] Memória e instruções persistentes.

---

## Claude Code — fundamentos

- [ ] Entender contexto da sessão.
- [ ] Criar e utilizar `CLAUDE.md`.
- [ ] Entender Plan Mode.
- [ ] Entender permissões.
- [ ] Entender retomada de sessões.
- [ ] Entender compactação de contexto.
- [ ] Saber dividir tarefas grandes.

---

## `/btw` e Side Questions

Entender que uma side question serve para tirar uma dúvida sem desviar a tarefa principal.

Exemplos:

```text
/btw por que você escolheu essa implementação?
```

```text
/btw qual arquivo contém a configuração dessa integração?
```

Checklist:

- [ ] Usar `/btw` durante uma tarefa real.
- [ ] Entender quando usar uma side question.
- [ ] Diferenciar side question de uma nova tarefa.
- [ ] Diferenciar side question de subagent.
- [ ] Experimentar perguntas técnicas rápidas sem alterar o foco principal.

---

## CLAUDE.md

Criar um `CLAUDE.md` para um projeto .NET contendo:

- [ ] visão da arquitetura;
- [ ] tecnologias;
- [ ] estrutura de pastas;
- [ ] padrões de código;
- [ ] como criar endpoints;
- [ ] como testar;
- [ ] regras de banco;
- [ ] regras de logging;
- [ ] o que não fazer.

### Experimento

Executar a mesma tarefa:

- [ ] sem `CLAUDE.md`;
- [ ] com `CLAUDE.md`;
- [ ] comparar os resultados.

---

## Skills

Entender Skill como conhecimento/instrução reutilizável para tarefas recorrentes.

Criar:

- [ ] Skill `create-endpoint`.
- [ ] Skill `code-review`.
- [ ] Skill `create-tests`.

Exemplo conceitual:

```text
create-endpoint
    ↓
Controller
    ↓
Service
    ↓
Repository
    ↓
DTO
    ↓
Validation
    ↓
Tests
```

## Hooks

- [ ] Entender o conceito.
- [ ] Criar pelo menos um Hook simples.
- [ ] Testar execução automática.
- [ ] Entender riscos de Hooks que executam comandos.

## Subagents

- [ ] Entender o que é um subagent.
- [ ] Entender isolamento de contexto.
- [ ] Criar um subagent especializado.
- [ ] Comparar tarefa normal vs subagent.
- [ ] Entender quando NÃO usar subagent.

## Definition of Done

- [ ] Uso Claude Code de forma consciente.
- [ ] Tenho um `CLAUDE.md` funcional.
- [ ] Tenho pelo menos 3 Skills úteis.
- [ ] Entendo `/btw`.
- [ ] Sei diferenciar Skill, Hook, Tool e Subagent.

---

# 6. ETAPA 4 — APIs de LLM + Structured Output + Tool Calling

## Objetivo

Aprender como uma aplicação de software conversa programaticamente com um modelo e como o modelo pode acionar funcionalidades externas.

## APIs

- [ ] Requests e responses.
- [ ] System/User messages.
- [ ] Streaming.
- [ ] Timeouts.
- [ ] Retry.
- [ ] Rate limiting.
- [ ] Tratamento de erro.
- [ ] Tokens.
- [ ] Custos.
- [ ] Cache.
- [ ] Configuração segura de API Keys.

## Structured Output

- [ ] JSON Schema.
- [ ] DTOs.
- [ ] Desserialização.
- [ ] Validação.
- [ ] Fallback em saída inválida.

---

## Function Calling / Tool Calling

Entender o fluxo:

```text
Usuário
   ↓
LLM
   ↓
"Preciso usar uma ferramenta"
   ↓
Aplicação executa a ferramenta
   ↓
Resultado volta ao LLM
   ↓
Resposta final
```

Checklist:

- [ ] Entender Tool Calling.
- [ ] Entender schema de ferramentas.
- [ ] Criar primeira Tool.
- [ ] Criar Tools com parâmetros.
- [ ] Validar parâmetros.
- [ ] Tratar falha de ferramenta.
- [ ] Trabalhar com múltiplas Tools.
- [ ] Registrar qual Tool foi executada.

## Projeto

Criar:

```text
DeveloperAssistant
    ↓
LLM
    ↓
Tools
├── GetProject()
├── GetWorkItem()
├── GetCustomer()
└── SearchDocumentation()
```

### Requisitos

- [ ] projeto .NET;
- [ ] pelo menos 3 Tools;
- [ ] logging;
- [ ] tratamento de erros;
- [ ] testes;
- [ ] README.

## Definition of Done

- [ ] Consigo explicar Tool Calling.
- [ ] Consigo desenhar um schema de Tool.
- [ ] Consigo integrar Tool Calling em C#.
- [ ] Entendo a diferença entre resposta textual e ação executável.

---

# 7. ETAPA 5 — MCP — Model Context Protocol

## Objetivo

Aprender a expor capacidades e informações de sistemas de maneira padronizada para ferramentas e agentes de IA.

## Fundamentos

- [ ] Entender o problema que MCP resolve.
- [ ] Entender Client.
- [ ] Entender Server.
- [ ] Entender Tools.
- [ ] Entender Resources.
- [ ] Entender Prompts.
- [ ] Entender comunicação cliente/servidor.

## MCP vs Tool Calling

Ser capaz de explicar:

```text
Tool Calling
= o modelo decide utilizar uma ferramenta.

MCP
= protocolo/padrão para disponibilizar capacidades e contexto
  para clientes e agentes de IA.
```

Checklist:

- [ ] Diferenciar MCP e Tool Calling.
- [ ] Diferenciar MCP e API REST.
- [ ] Entender quando MCP faz sentido.
- [ ] Entender quando uma integração direta é mais simples.

## Criando MCP

Criar:

```text
Company.MCP
│
├── get_work_item
├── get_project
├── get_customer
└── search_documentation
```

Checklist:

- [ ] criar MCP Server;
- [ ] criar primeira Tool;
- [ ] expor Resource;
- [ ] conectar a um client;
- [ ] testar chamadas;
- [ ] tratar erros;
- [ ] adicionar logs.

## Segurança

- [ ] autenticação;
- [ ] autorização;
- [ ] menor privilégio;
- [ ] service tokens;
- [ ] rate limiting;
- [ ] logging;
- [ ] secrets;
- [ ] exposição segura de recursos internos.

## Projeto

**MCP corporativo experimental**

```text
Claude Code / outro client
           ↓
           MCP
           ↓
 ┌─────────┼──────────┐
 ↓         ↓          ↓
Azure    API       Documentação
DevOps   interna
```

## Definition of Done

- [ ] Tenho um MCP Server funcional.
- [ ] Consigo conectá-lo a um client.
- [ ] Consigo explicar MCP vs Tool Calling.
- [ ] Entendo riscos de segurança.
- [ ] Tenho pelo menos uma integração útil.

---

# 8. ETAPA 6 — Embeddings e Vector Search

## Objetivo

Entender a base técnica utilizada por grande parte dos sistemas RAG.

## Embeddings

Conceito:

```text
Texto
  ↓
Embedding Model
  ↓
Vetor
```

Checklist:

- [ ] Entender embedding.
- [ ] Entender similaridade semântica.
- [ ] Entender cosine similarity.
- [ ] Entender dimensionalidade em alto nível.
- [ ] Gerar embeddings.
- [ ] Comparar embeddings de frases.

## Vector Search

- [ ] Vector index.
- [ ] Top-K.
- [ ] Similarity Search.
- [ ] Metadata.
- [ ] Metadata filtering.
- [ ] Keyword Search.
- [ ] Vector Search.
- [ ] Hybrid Search.

## Experimento

Utilizar 20–50 textos.

- [ ] gerar embeddings;
- [ ] indexar;
- [ ] executar uma busca semântica;
- [ ] comparar busca textual e semântica;
- [ ] testar frases semanticamente semelhantes sem palavras iguais.

## Definition of Done

- [ ] Consigo explicar embedding.
- [ ] Consigo explicar busca semântica.
- [ ] Sei por que Vector Search é útil para RAG.
- [ ] Consigo executar uma busca vetorial simples.

---

# 9. ETAPA 7 — RAG

## Objetivo

Construir aplicações que utilizam conhecimento externo para fundamentar respostas do LLM.

## Arquitetura básica

```text
Documentos
    ↓
Parsing
    ↓
Chunking
    ↓
Embeddings
    ↓
Vector Store
```

Pergunta:

```text
Pergunta
   ↓
Retrieval
   ↓
Chunks relevantes
   ↓
LLM
   ↓
Resposta fundamentada
```

## Conceitos

- [ ] Retrieval-Augmented Generation.
- [ ] Ingestion.
- [ ] Parsing.
- [ ] Chunking.
- [ ] Chunk size.
- [ ] Chunk overlap.
- [ ] Embeddings.
- [ ] Retrieval.
- [ ] Top-K.
- [ ] Metadata filtering.
- [ ] Hybrid Search.
- [ ] Query rewriting.
- [ ] Reranking.
- [ ] Grounding.
- [ ] Citations.
- [ ] Controle de contexto.

## Perguntas importantes

Ser capaz de responder:

- [ ] Por que não mandar o documento inteiro para o modelo?
- [ ] Como escolher chunk size?
- [ ] Por que overlap existe?
- [ ] Quando metadata filtering ajuda?
- [ ] Vector Search é sempre melhor?
- [ ] O que Hybrid Search resolve?
- [ ] O que fazer quando o retrieval encontra conteúdo ruim?

## Projeto — Documentation Assistant

Fontes:

- Markdown
- PDF
- READMEs
- documentação técnica

Arquitetura:

```text
Documentação
     ↓
Ingestion
     ↓
Chunking
     ↓
Embeddings
     ↓
Vector Search
     ↓
Retrieval
     ↓
LLM
     ↓
Resposta + Fonte
```

Checklist:

- [ ] ingestão de documentos;
- [ ] chunking;
- [ ] embeddings;
- [ ] indexação;
- [ ] busca;
- [ ] resposta;
- [ ] fonte/citação;
- [ ] logs;
- [ ] testes.

## Evaluation inicial

Criar pelo menos 20 perguntas conhecidas:

- [ ] pergunta;
- [ ] resposta esperada;
- [ ] documento esperado;
- [ ] resultado encontrado;
- [ ] qualidade da resposta.

## Definition of Done

- [ ] Tenho um RAG funcional.
- [ ] Entendo cada etapa do pipeline.
- [ ] Sei investigar retrieval ruim.
- [ ] Consigo explicar RAG para outro desenvolvedor.

---

# 10. ETAPA 8 — Agents

## Objetivo

Entender quando permitir que um modelo tome decisões sobre quais passos e ferramentas utilizar.

## Fundamento

```text
Goal
 ↓
LLM
 ↓
Decision
 ↓
Action / Tool
 ↓
Observation
 ↓
LLM
 ↓
...
 ↓
Final
```

## Conceitos

- [ ] Agent Loop.
- [ ] Planner.
- [ ] Executor.
- [ ] Tools.
- [ ] State.
- [ ] Context.
- [ ] Memory.
- [ ] Feedback loop.
- [ ] Stop condition.
- [ ] Human-in-the-loop.

## Tipos de Agent

- [ ] Task-based.
- [ ] Interactive.
- [ ] Goal-oriented.
- [ ] Autonomous.

## Padrões

- [ ] ReAct.
- [ ] Plan-and-Execute.
- [ ] Reflection.
- [ ] Routing.
- [ ] Supervisor em alto nível.

## Exercício

Criar um agente:

```text
Developer Task Agent
        │
        ├── GetWorkItem
        ├── SearchDocumentation
        ├── SearchCode
        └── GeneratePlan
```

Entrada:

```text
Analise a tarefa 123 e proponha uma implementação.
```

Fluxo esperado:

```text
1. Buscar a tarefa
2. Identificar contexto
3. Buscar documentação
4. Buscar código relacionado
5. Criar plano
6. Identificar riscos
7. Responder
```

Checklist:

- [ ] implementar agent loop;
- [ ] usar pelo menos 3 Tools;
- [ ] registrar decisões;
- [ ] adicionar limite de iterações;
- [ ] tratar erro de Tool;
- [ ] adicionar condição de parada;
- [ ] testar cenários de falha.

---

# 11. Agent + MCP + RAG

## Objetivo

Combinar os conceitos da trilha.

```text
                  Agent
                    │
        ┌───────────┼───────────┐
        ↓           ↓           ↓
       RAG         MCP         API
        │           │
   Vector DB    Sistemas
               internos
```

Checklist:

- [ ] Agent usa RAG.
- [ ] Agent usa uma Tool via MCP.
- [ ] Agent decide quando buscar documentação.
- [ ] Agent decide quando consultar sistema externo.
- [ ] Logs mostram cada etapa.
- [ ] Existem limites de autonomia.
- [ ] Existe tratamento de falhas.

---

# 12. Multi-Agent — somente depois do Single Agent

## Conceitos

- [ ] Supervisor.
- [ ] Sequential.
- [ ] Parallel.
- [ ] Hierarchical.
- [ ] Delegation.
- [ ] Group Chat.
- [ ] Handoff.
- [ ] Consensus em alto nível.

## Regra importante

Não assumir:

```text
mais agents = solução melhor
```

Antes de criar um sistema Multi-Agent, justificar:

- [ ] Por que um único Agent não resolve?
- [ ] Existe paralelismo real?
- [ ] Existem papéis claramente independentes?
- [ ] O ganho justifica complexidade, custo e observabilidade adicionais?

## Exercício opcional

```text
Supervisor
   │
   ├── Requirements Agent
   ├── Developer Agent
   └── Review Agent
```

---

# 13. ETAPA 9 — Evaluation

## Objetivo

Parar de avaliar aplicações de IA apenas com "parece que funciona".

## Conceitos

- [ ] Evaluation dataset.
- [ ] Groundedness.
- [ ] Relevance.
- [ ] Correctness.
- [ ] Completeness.
- [ ] Hallucination.
- [ ] Tool success rate.
- [ ] Retrieval quality.
- [ ] Latency.
- [ ] Token usage.
- [ ] Custo.

## Dataset de avaliação

Criar:

```text
/evals
    questions.json
```

Cada exemplo deve ter:

```json
{
  "question": "",
  "expectedAnswer": "",
  "expectedSource": "",
  "notes": ""
}
```

Checklist:

- [ ] criar 20 casos;
- [ ] automatizar execução;
- [ ] salvar resultados;
- [ ] comparar versões;
- [ ] analisar regressões.

## Definition of Done

- [ ] Tenho testes de qualidade.
- [ ] Consigo detectar regressões.
- [ ] Consigo medir mudanças em prompts/RAG.
- [ ] Não dependo apenas de avaliação manual.

---

# 14. ETAPA 10 — Observability

## Objetivo

Conseguir investigar o que uma aplicação de IA fez.

## Observar

```text
Request
  ↓
Prompt / Context
  ↓
Model
  ↓
Retrieval
  ↓
Tool Calls
  ↓
Agent Steps
  ↓
Response
```

Checklist:

- [ ] logs estruturados;
- [ ] correlation id;
- [ ] latência;
- [ ] tokens;
- [ ] custo;
- [ ] Tool Calls;
- [ ] erros;
- [ ] retries;
- [ ] retrieval results;
- [ ] número de etapas do Agent.

## Pergunta-chave

Se uma resposta estiver errada, eu consigo identificar se o problema foi:

- [ ] prompt?
- [ ] contexto?
- [ ] retrieval?
- [ ] documento?
- [ ] Tool?
- [ ] modelo?
- [ ] agent loop?
- [ ] configuração?

---

# 15. ETAPA 11 — Segurança, Governança e Guardrails

## Fundamentos

- [ ] Prompt Injection.
- [ ] Data leakage.
- [ ] Secrets.
- [ ] Authentication.
- [ ] Authorization.
- [ ] Least privilege.
- [ ] Input validation.
- [ ] Output validation.
- [ ] Rate limiting.
- [ ] Audit trail.
- [ ] Guardrails.
- [ ] Human-in-the-loop.
- [ ] Approval gates.
- [ ] Limite de iterações.
- [ ] Limite de custo.

## Regra para ações críticas

```text
Agent
  ↓
Proposta de ação
  ↓
Validação
  ↓
Human Approval
  ↓
Execução
```

Exemplos que normalmente exigem atenção:

- deploy;
- exclusão;
- alterações em banco;
- envio de comunicação externa;
- alteração de infraestrutura;
- execução com credenciais privilegiadas.

## Exercício

Adicionar ao projeto Agent:

- [ ] limite de 10 iterações;
- [ ] timeout;
- [ ] allowlist de Tools;
- [ ] aprovação humana para Tool crítica;
- [ ] logs de auditoria.

---

# 16. ETAPA 12 — Arquitetura de Sistemas com IA

## Objetivo

Conseguir tomar decisões de arquitetura, não apenas utilizar frameworks.

## Perguntas que devo saber responder

- [ ] Preciso realmente de IA?
- [ ] Uma regra determinística resolveria?
- [ ] Preciso de RAG?
- [ ] Preciso de Agent?
- [ ] Preciso de MCP?
- [ ] Preciso de Multi-Agent?
- [ ] Preciso de fine-tuning?
- [ ] Qual é o custo esperado?
- [ ] Qual é a latência aceitável?
- [ ] Onde haverá observabilidade?
- [ ] O que acontece quando o modelo falha?

## Patterns

- [ ] Basic RAG.
- [ ] Hybrid RAG.
- [ ] Agentic RAG.
- [ ] Model Router.
- [ ] Intent-Based Routing.
- [ ] Semantic Cache.
- [ ] Prompt Cache.
- [ ] Streaming.
- [ ] Approval Gates.
- [ ] Confidence Threshold.
- [ ] Audit Trail.

## Arquitetura exemplo

```text
                 API Gateway
                     ↓
                AI Service
                     │
        ┌────────────┼────────────┐
        ↓            ↓            ↓
      Agent         RAG          Tools
        │            │            │
       MCP       Vector DB       APIs
        │
 Sistemas corporativos
```

---

# 17. Projeto Integrador — Developer AI Assistant

## Objetivo

Construir um projeto único que reúna os principais conhecimentos da trilha.

## Caso de uso

Um assistente para desenvolvedor capaz de:

- ler tarefa;
- buscar documentação;
- localizar código relacionado;
- explicar contexto;
- criar plano de implementação;
- apontar riscos;
- sugerir testes;
- utilizar dados de sistemas externos.

## Arquitetura

```text
                       Developer
                           ↓
                     AI Assistant
                           │
          ┌────────────────┼────────────────┐
          ↓                ↓                ↓
        Agent             RAG              MCP
          │                │                │
          │           Vector Store    Azure DevOps
          │                         APIs internas
          │                         outros serviços
          ↓
       Tools
```

## Fase 1 — Base

- [ ] Criar repositório.
- [ ] Criar solução .NET.
- [ ] Criar README.
- [ ] Criar configuração.
- [ ] Integrar primeiro LLM.

## Fase 2 — Tools

- [ ] Criar Tool de tarefa.
- [ ] Criar Tool de documentação.
- [ ] Criar Tool de projeto.
- [ ] Testar seleção automática de Tools.

## Fase 3 — MCP

- [ ] Criar MCP Server.
- [ ] Expor Tools.
- [ ] Conectar a um client.
- [ ] Implementar segurança mínima.

## Fase 4 — RAG

- [ ] Ingestion.
- [ ] Chunking.
- [ ] Embeddings.
- [ ] Vector Search.
- [ ] Retrieval.
- [ ] Citations.

## Fase 5 — Agent

- [ ] Agent loop.
- [ ] Planning.
- [ ] Tool execution.
- [ ] RAG.
- [ ] MCP.
- [ ] Stop condition.

## Fase 6 — Evaluation

- [ ] Dataset de perguntas.
- [ ] Métricas.
- [ ] Comparação de versões.

## Fase 7 — Segurança

- [ ] permissões;
- [ ] allowlist;
- [ ] limits;
- [ ] logs;
- [ ] approval gate.

## Fase 8 — Entrega

- [ ] README completo.
- [ ] Diagrama de arquitetura.
- [ ] Instruções de execução.
- [ ] Exemplos.
- [ ] Testes.
- [ ] Demonstração funcional.
- [ ] Explicação das decisões arquiteturais.

---

# 18. Tópicos para estudar depois

## Fine-tuning

Somente depois de dominar RAG e avaliação.

- [ ] Quando usar Fine-Tuning.
- [ ] RAG vs Fine-Tuning.
- [ ] Dataset.
- [ ] JSONL.
- [ ] Fine-Tuning API.
- [ ] LoRA.
- [ ] PEFT.
- [ ] Overfitting.
- [ ] Evaluation.

## Machine Learning tradicional

Opcional, dependendo da necessidade profissional:

- [ ] Redes neurais.
- [ ] Treinamento.
- [ ] Validação.
- [ ] Deep Learning.
- [ ] Tensores.
- [ ] Frameworks de ML.

---

# 19. Especializações opcionais

A ementa original também aborda áreas que podem ser estudadas depois como trilhas independentes.

## AI + DevOps

- [ ] IaC Copilot.
- [ ] Terraform assistido por IA.
- [ ] Kubernetes Agents.
- [ ] Troubleshooting assistido.
- [ ] Observability.
- [ ] ChatOps.
- [ ] CI/CD Copilot.
- [ ] FinOps.
- [ ] RAG de runbooks.
- [ ] Auto-remediation com guardrails.

## AI + UX/UI

- [ ] Text-to-UI.
- [ ] prototipação assistida;
- [ ] AI Coding para front-end;
- [ ] testes E2E com agentes.

## AI + Gestão de Projetos

- [ ] Requirements Copilot.
- [ ] decomposição de tarefas.
- [ ] critérios de aceite.
- [ ] priorização de backlog.
- [ ] resumos de reunião.
- [ ] status reports.

---

# 20. Checklist de domínio final

## Conceitos

- [ ] LLM.
- [ ] Token.
- [ ] Context Window.
- [ ] Embedding.
- [ ] Prompt Engineering.
- [ ] Context Engineering.
- [ ] Structured Output.
- [ ] Tool Calling.
- [ ] MCP.
- [ ] RAG.
- [ ] Agent.
- [ ] Memory.
- [ ] Agent Loop.
- [ ] Evaluation.
- [ ] Guardrails.

## Prática

- [ ] Consumo uma API de LLM em .NET.
- [ ] Crio outputs estruturados.
- [ ] Crio Tools.
- [ ] Crio MCP Server.
- [ ] Crio embeddings.
- [ ] Implemento Vector Search.
- [ ] Implemento RAG.
- [ ] Implemento Agent.
- [ ] Integro Agent + RAG + MCP.
- [ ] Crio avaliações automatizadas.
- [ ] Implemento logs e observabilidade.
- [ ] Implemento guardrails.

## AI Coding

- [ ] Uso `CLAUDE.md`.
- [ ] Uso `/btw`.
- [ ] Crio Skills.
- [ ] Entendo Hooks.
- [ ] Crio Subagents.
- [ ] Sei gerenciar contexto.
- [ ] Sei dividir tarefas grandes.
- [ ] Sei revisar código produzido por IA.

---

# 21. Diário de estudo

Copiar o template abaixo a cada sessão.

---

## Sessão 2026-08-27

### Tópico

Fundamentos de LLMs e implementação do projeto `HelloLlm`.

### O que estudei

IA, Machine Learning, Deep Learning, LLMs, inferência, tokens, Context Window, Transformer, attention, embeddings, alucinação, temperatura, modelos proprietários/open-weight e limitações dos LLMs.

### O que implementei

Aplicação console .NET integrada ao Gemini, com configuração por variável de ambiente, troca de modelo, medição de duração, tratamento de erros transitórios e retry.

### O que entendi

O modelo é o componente treinado e probabilístico que gera tokens. A aplicação coordena entrada, configuração, chamada HTTP, validação, erros e apresentação da resposta.

### O que ainda ficou confuso

Nenhum bloqueio conceitual identificado. Structured Output e constrained decoding foram vistos apenas como prévia e serão aprofundados em etapa posterior.

### Código produzido

Projeto `Praticas/HelloLlm` organizado em `Clients`, `Configuration` e `UI`.

### Testes realizados

Compilação sem erros ou avisos; entrada vazia; encerramento; ausência de chave; erros HTTP 404 e 503; retries; troca de modelo; chamada bem-sucedida; exibição da resposta e da duração.

### Próximo passo

Revisar o projeto e iniciar a próxima atividade pendente sem avançar automaticamente para outro módulo.

---

## Sessão YYYY-MM-DD

### Tópico

...

### O que estudei

...

### O que implementei

...

### O que entendi

...

### O que ainda ficou confuso

...

### Código produzido

...

### Testes realizados

...

### Próximo passo

...

---

# 22. Perguntas de revisão

Ao final de cada etapa, pedir ao Codex para me fazer perguntas sem mostrar as respostas imediatamente.

Exemplos:

```text
Faça 10 perguntas sobre o módulo atual.

Misture:
- conceito;
- comparação;
- cenário prático;
- arquitetura;
- debugging.

Faça uma pergunta por vez.
Espere minha resposta.
Corrija e explique.
```

---

# 23. Regra para Coding Assistido

Durante o estudo, o Codex pode ajudar a produzir código, mas não deve eliminar o aprendizado.

Fluxo recomendado:

```text
1. Eu explico o que pretendo fazer.
2. Codex corrige meu entendimento.
3. Eu tento implementar.
4. Codex ajuda quando eu travar.
5. Executamos testes.
6. Revisamos o código.
7. Eu explico a solução.
8. Marcamos o checklist.
```

Evitar:

```text
"Faça todo o projeto para mim."
```

Preferir:

```text
"Estou estudando Tool Calling.

Não implemente tudo de uma vez.

Primeiro explique a arquitetura.
Depois me ajude a implementar uma Tool.
Quero entender cada passo antes de continuar."
```

---

# 24. Prompt inicial para usar no Codex

```text
Este repositório é minha trilha prática de AI Engineering.

Leia o arquivo TRILHA_IA.md antes de começarmos.

Regras:

1. Identifique a primeira atividade pendente.
2. Não avance automaticamente para outro módulo.
3. Explique os conceitos importantes.
4. Priorize C#/.NET e Azure.
5. Use outras linguagens somente quando fizer sentido.
6. Sempre associe teoria a um exercício prático.
7. Não escreva todo o projeto de uma vez.
8. Ajude-me a raciocinar e implementar por etapas.
9. Sempre execute ou proponha testes.
10. Ao finalizar um tópico, faça perguntas para verificar se eu realmente entendi.
11. Só marque um checkbox quando houver evidência de que o tópico foi entendido ou implementado.
12. Registre decisões e aprendizados relevantes no próprio arquivo quando apropriado.

Comece informando:
- módulo atual;
- objetivo;
- o que vamos estudar;
- exercício prático;
- critério para considerar a sessão concluída.
```

---

# 25. Primeiro passo

Começar por:

```text
ETAPA 1 — Fundamentos de IA Generativa e LLMs
```

Primeira sessão:

- [x] IA vs ML vs Deep Learning.
- [x] O que é um LLM.
- [x] Tokens.
- [x] Context Window.
- [x] Inferência.
- [x] Criar o projeto `HelloLlm`.
- [x] Fazer a primeira chamada a um modelo.
- [x] Explicar o fluxo completo com minhas palavras.

Depois disso, seguir a primeira tarefa pendente deste arquivo.

---

# 26. Princípio da trilha

O objetivo não é decorar ferramentas.

O objetivo é entender os conceitos suficientemente bem para que a tecnologia possa mudar sem invalidar o aprendizado.

```text
CONCEITO
   ↓
PADRÃO
   ↓
IMPLEMENTAÇÃO
   ↓
FERRAMENTA
```

Exemplos:

```text
Tool Calling
    ↓
Claude / OpenAI / Microsoft

RAG
    ↓
Azure AI Search / outro Vector Store

Agent
    ↓
Framework A / Framework B / implementação própria

MCP
    ↓
Clientes e servidores compatíveis
```

A ferramenta pode mudar.

O conhecimento permanece.
