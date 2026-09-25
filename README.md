# Meu caminho de estudo em IA

> **Comece sempre por este arquivo.** Ele define a ordem e o escopo do estudo.
> Objetivo: aprender IA aplicada ao desenvolvimento em C#/.NET, construir uma aplicação útil e saber explicar e avaliar seu funcionamento.
> **Agora:** criar o prompt inicial do exercício integrado da Etapa 2. Conceitos introdutórios de contexto concluídos; prática integrada e revisão final pendentes.

## Uma direção para os materiais existentes

Não é necessário fazer três trilhas. Vamos continuar o aprendizado já iniciado, usando o recorte abaixo como caminho principal.

| Material | Como usar |
|---|---|
| Este README | Decidir o que estudar agora, a sequência e o ponto de chegada. |
| [Trilha original](Trilhas/TRILHA_IA.md) | Consultar explicações, exercícios e registrar o progresso detalhado dos tópicos escolhidos aqui. |
| [Anotações](ANOTACOES.md) | Registrar conceitos com minhas palavras e dúvidas. |
| [Guia de estudo](GuiaEstudo/GUIA_ESTUDO_IA.md) | Consultar somente o assunto da sessão. Não é uma leitura obrigatória do começo ao fim. |
| [Trilha profissional](Trilhas/TRILHA_IA_Profissional.md) | Consultar depois para aprofundar publicação, operação e portfólio. |
| [Trilha de especialista](Trilhas/trilha-especialista-ia.md) | Referência para uma especialização futura, sem tarefas obrigatórias agora. |

**Se os arquivos sugerirem ordens diferentes, seguir este README.** Checkboxes opcionais em aberto na trilha original não bloqueiam o avanço. Não procurar simplesmente o primeiro checkbox vazio do arquivo inteiro.

## O que já estudei

Resumo dos registros existentes em 09/09/2026; não representa uma nova avaliação de domínio.

| Assunto | Situação registrada |
|---|---|
| Fundamentos: IA, ML, LLMs, inferência, tokens, janela de contexto, Transformer/attention, alucinação e limitações | Etapa 1 concluída. |
| Embeddings | Conceito estudado; implementação e busca ainda pendentes. |
| Projeto `HelloLlm` em .NET | Concluído: chamada ao modelo, configuração, duração e tratamento de erros. |
| Prompt Engineering | Conceitos marcados como estudados. |
| JSON, validação e schema | Marcados como estudados; exercício integrado da Etapa 2 ainda pendente. |
| Context Engineering | Em andamento: contexto global/da tarefa, seleção do que incluir, como evitar contexto desnecessário, Context pruning e Context stitching em alto nível já estudados. |

Não reiniciar os fundamentos. Revisar pontualmente quando uma dúvida aparecer na prática.

## Caminho principal: o que concluir agora

Seguir uma linha por vez. As referências abaixo são seções da [trilha original](Trilhas/TRILHA_IA.md), não uma exigência de concluir todos os seus checkboxes.

| Ordem | O que aprender | Entrega para avançar | Onde consultar |
|---|---|---|---|
| 1 — Em andamento | Prompt, seleção/reuso de contexto, custo e saída estruturada | Transformar descrições de tarefas em JSON validado; testar cinco tarefas e explicar as escolhas de contexto. | Etapa 2 |
| 2 — Pendente | IA no desenvolvimento: contexto do projeto, planejamento, revisão, testes e instruções reutilizáveis | Realizar uma pequena alteração com IA, revisar o resultado, testar e explicar o código. Experimentar uma instrução reutilizável. | Etapa 3, usando a ferramenta disponível |
| 3 — Pendente | APIs, erros, streaming, Tool Calling e MCP | Implementar tools com parâmetros validados e tratamento de falhas; conectar uma capacidade por MCP e explicar sua diferença para Tool Calling. | Etapas 4 e 5 |
| 4 — Pendente | Embeddings, busca e RAG | Consultar um pequeno conjunto de documentos, responder com fontes e testar perguntas com e sem resposta na base. | Etapas 6 e 7 |
| 5 — Pendente | Agente simples e workflows | Integrar busca e tools com limite de passos, condição de parada e tratamento de falhas; explicar quando um fluxo fixo basta. | Etapa 8 e seção “Agent + MCP + RAG” |
| 6 — Pendente | Avaliação, observabilidade, segurança e decisões de arquitetura | Consolidar o projeto, executar 20 casos de avaliação e documentar qualidade, falhas, tempo, tokens/custo e limites de acesso. | Etapas 9 a 12 e Projeto Integrador |

**Praticar qualidade desde a primeira etapa:** validar saídas, testar falhas, proteger credenciais e registrar o necessário para entender o resultado. A etapa final consolida essas práticas.

Usar C#/.NET como linguagem principal. Aproveitar o `HelloLlm` e evoluir um assistente de tarefas de desenvolvimento conforme fizer sentido, evitando começar um projeto novo para cada conceito. Dados simulados e documentos locais são suficientes para estudar integrações.

## Próxima sessão, sem precisar escolher novamente

**Tema:** exercício integrado da Etapa 2 — analisar uma tarefa e retornar JSON.

1. Escrever o prompt inicial para retornar `summary`, `technicalTasks`, `risks` e `questions` a partir de uma tarefa.
2. Revisar o contrato da saída e testar uma tarefa por vez, até completar cinco.
3. Validar as saídas, melhorar o prompt e realizar a revisão final da etapa.

Contexto persistente vs temporário concluído em 15/09/2026: o aluno classificou stack e padrão de erros como persistentes; mensagem do último teste e instrução específica de aguardar revisão como temporárias.

Custo de contexto concluído em nível introdutório: o aluno explicou que retirar informações desnecessárias reduz tokens e custo. O tutor apresentou o cálculo hipotético e a ressalva de preservar requisitos; não houve medição real de consumo.

Reuso de contexto concluído: para uma consulta de pedidos, o aluno selecionou stack e padrão de erros, excluindo regras específicas do cadastro de CPF. A revisão destacou conferir se as informações reutilizadas continuam válidas.

Context stitching concluído: o aluno reuniu a regra de validar ativos/inativos, o padrão de erro da documentação e o comportamento atual do ClienteService. A revisão acrescentou o pedido explícito de propor um plano sem implementar.

Context pruning concluído: o aluno resumiu a validação de CPF preservando ativos/inativos e equivalência entre formatos, retirando a regra antiga. A revisão acrescentou a decisão explícita de não oferecer configuração para alternar esse comportamento.

Atividade anterior concluída: seleção de contexto para um plano de validação de CPF duplicado, com discussão de normalização, concorrência e requisitos indefinidos. O exercício integrado com cinco tarefas continua pendente.

A Etapa 2 permanece em andamento até concluir o exercício integrado e a revisão final.

Uma sessão termina com um pequeno resultado e uma explicação com minhas palavras. Não é necessário terminar a etapa inteira de uma vez.

## Quando esta trilha estará concluída

Quando eu conseguir demonstrar e explicar um assistente .NET que:

- recebe uma tarefa e produz uma saída estruturada validada;
- consulta documentos e apresenta as fontes;
- usa ferramentas, incluindo uma integração de estudo via MCP;
- executa um fluxo com limites e trata falhas;
- tem casos de avaliação, registros de execução e controles básicos de acesso e custo;
- possui instruções de execução e uma explicação das decisões tomadas.

Esse é o fim deste ciclo de formação prática em IA aplicada. Não exige dominar todas as ferramentas nem representa, por si só, experiência de especialista.

## O que é bom aprofundar depois

Após concluir o caminho principal, escolher conforme uma necessidade real:

- **Entrega profissional:** Docker, CI/CD, publicação no Azure, monitoramento e operação — usar a trilha profissional.
- **Python funcional:** para aproveitar bibliotecas, exemplos ou oportunidades que precisem dele; não é uma segunda trilha paralela obrigatória agora.
- **RAG e avaliação mais completos:** busca híbrida, reranking, autorização por documento e conjuntos de testes maiores.
- **Ferramentas de desenvolvimento:** mais skills, hooks e automações, conforme surgirem tarefas recorrentes.

## Avançado: fica para uma especialização

Multiagentes, orquestração complexa, fine-tuning, LoRA/PEFT, treinamento de modelos e matemática aprofundada. Escolher um tema quando houver um problema concreto que justifique estudá-lo. Não são requisitos para concluir este ciclo.

## Como continuar com ajuda da IA

Copiar ao iniciar uma sessão:

```text
Leia o README.md da raiz para seguir meu caminho de estudo.
Consulte na Trilhas/TRILHA_IA.md apenas a etapa atual e seu progresso.
Continue do ponto pendente dentro do escopo escolhido no README.
Explique de forma curta e proponha um exercício por vez.
Deixe-me tentar e explicar antes de entregar uma implementação completa.
Não adicione novos módulos ou transforme aprofundamentos em obrigações.
Só marque um tópico como concluído com evidência de aprendizado.
Ao encerrar, atualize o progresso detalhado na trilha original e o próximo
passo neste README. Atualize a situação da etapa quando ela for concluída.
```

Os detalhes de comandos, SDKs e serviços devem ser conferidos na documentação vigente quando forem usados. Novidades não mudam automaticamente a sequência do estudo.
