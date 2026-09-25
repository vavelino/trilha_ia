# Anotações de estudo

## Etapa 1 — Fundamentos de IA Generativa e LLMs

### IA, Machine Learning e Deep Learning

```text
Inteligência Artificial
└── Machine Learning
    └── Deep Learning
        └── LLMs
```

- Regra fixa: `se temperatura > 38, emitir alerta` — automação ou IA baseada em regras, não necessariamente Machine Learning.
- Modelo treinado com históricos para prever risco — Machine Learning.
- Rede neural profunda analisando texto médico — Deep Learning.
- Modelo conversando e produzindo texto — LLM.

```text
Machine Learning
├── regressão
├── árvores de decisão
├── redes neurais simples
└── Deep Learning
    └── redes neurais profundas
```

### LLM, treinamento e inferência

Um LLM é um modelo de Deep Learning, geralmente baseado na arquitetura Transformer e treinado com grandes volumes de texto. O treinamento ajusta bilhões de parâmetros, incluindo os pesos, para que o modelo aprenda padrões da linguagem e consiga prever tokens.

- Treinamento: ajusta os parâmetros para reduzir o erro.
- Inferência: utiliza os parâmetros treinados sem alterá-los.

### Tokens e Context Window

Tokens são as unidades processadas pelo modelo. Podem representar uma palavra, parte de uma palavra, pontuação, número, espaço ou outra sequência.

Context Window é a quantidade máxima de tokens que o modelo consegue processar em uma requisição. Inclui a entrada e os tokens de saída gerados.

### Transformer e attention

“Attention Is All You Need” é o artigo de 2017 que apresentou a arquitetura Transformer.

Transformer é uma arquitetura de modelo que utiliza attention para analisar relações entre tokens de uma sequência e produzir representações contextualizadas.

Attention permite que cada token avalie quais outros tokens do contexto são mais relevantes para construir sua representação.

### Embeddings

Embedding é uma representação numérica que procura capturar características e relações de significado.

- Embeddings internos do LLM transformam tokens em vetores para que o Transformer possa processá-los.
- Embeddings para busca semântica representam frases ou documentos como vetores e permitem encontrar conteúdos com significados semelhantes.

### Alucinação

Alucinação ocorre quando o modelo produz uma afirmação falsa, inventada ou não sustentada pelo contexto, apresentando-a como válida.

### Temperatura e geração

```text
temperatura baixa → mais consistência
temperatura alta  → mais diversidade
```

Temperatura não garante precisão nem formato válido. Temperatura baixa melhora a consistência; JSON Schema controla o formato; validação na aplicação verifica se os dados são aceitáveis para o sistema.

```text
temperatura → diversidade da geração
JSON Schema → estrutura da saída
validação   → dados aceitáveis para a aplicação
```

### Context Engineering — selecionar informações úteis

Context Engineering envolve escolher e organizar as informações disponíveis para o modelo realizar uma tarefa: instruções, regras, documentos, trechos de código e resultados de ferramentas.

- Contexto global: informações compartilhadas entre tarefas, como arquitetura e padrões do projeto.
- Contexto da tarefa: objetivo atual, regras específicas, arquivos envolvidos e decisões pendentes.
- Uma informação deve entrar quando ajuda a resolver a tarefa ou evita uma solução incorreta.
- Históricos sem relação com o pedido, repetições e decisões superadas podem ser removidos.

Pergunta prática: **se eu retirar esta informação, a solução pode ficar incorreta ou desrespeitar algum requisito?**

Contexto enxuto preserva o que muda a solução. Um pedido curto demais pode obrigar a investigar mais arquivos, mas o risco principal é omitir regras que nem o código revela. Acesso ao projeto depende das ferramentas disponíveis; o modelo não descobre automaticamente requisitos ausentes.

#### Exercício — validação de CPF duplicado

Para propor um plano de implementação, foram relevantes:

- C#/.NET, endpoint existente, `ClienteService` e SQL Server;
- CPF recebido com ou sem pontuação;
- inclusão de clientes inativos na verificação;
- possibilidade de duas requisições simultâneas;
- decisões pendentes sobre a resposta de erro.

Mudança de logotipo e reunião de outro módulo foram retiradas por não contribuírem para a tarefa.

O aluno explicou que duas requisições podem consultar o banco antes de qualquer uma gravar, ambas não encontrarem o CPF e tentarem cadastrá-lo. A discussão mostrou como um detalhe do contexto muda o plano de implementação. A proteção de unicidade precisa considerar a representação normalizada do CPF e o tratamento da tentativa rejeitada.

#### Regras pendentes e decisões provisórias

Uma regra indefinida deve ser apresentada como pendência. Comentários e código fácil de alterar não definem o comportamento atual.

Exemplo: “Ainda não foi definido se clientes inativos entram na validação. Destaque a pendência no plano e solicite a definição antes de implementar essa regra.”

Uma decisão provisória pode ser usada quando explicitamente autorizada. Uma mensagem genérica em uma constante define apenas o texto; status HTTP e formato da resposta ainda podem estar pendentes.

### Context pruning — retirar o que perdeu utilidade

É revisar o contexto acumulado e remover informações irrelevantes, repetidas ou superadas, preservando requisitos atuais, restrições e decisões pendentes.

Exemplo discutido:

| Histórico | Tratamento no resumo atual |
|---|---|
| Validar somente clientes ativos | Remover: regra substituída. |
| Considerar uma configuração para incluir inativos | Remover: proposta descartada. |
| Decisão aprovada: ativos e inativos, sem configuração | Preservar. |
| CPF com e sem pontuação representa o mesmo documento | Preservar. |

Resumo produzido pelo aluno e complementado na revisão:

> Implementar validação de CPF duplicado considerando clientes ativos e inativos, sem configuração para alternar essa regra. Comparar os CPFs desconsiderando pontuação, pois diferenças de formatação não representam documentos diferentes.

Uma nova conversa pode começar com esse resumo quando o histórico anterior não tiver mais utilidade. Abrir uma conversa por decisão não é necessário, e abrir uma conversa vazia não substitui levar os requisitos relevantes. Outra opção é manter uma seção “Decisões atuais” atualizada no arquivo do projeto.

### Exercício integrado — tarefa para JSON (24/09/2026)

O aluno escreveu o prompt inicial. A revisão definiu `summary` como texto e `technicalTasks`, `risks` e `questions` como listas de textos, porque cada uma pode conter vários itens. Usar os nomes exatos, sem crases nas chaves; listas vazias são `[]`.

Decisões indefinidas devem virar perguntas. No caso de CPF, o status HTTP ficou pendente e possíveis duplicidades na base foram tratadas como hipótese, sem inventar fatos.

Na revisão da saída ilustrativa, o aluno identificou atividades excessivamente fragmentadas. Ajuste do prompt: agrupar passos relacionados sem perder requisitos. JSON sintaticamente válido ainda pode apresentar conteúdo redundante ou incompleto.

Prompt consolidado: `Praticas/HelloLlm/Prompts/analisar-tarefa.md`. O exemplo foi revisado na conversa, não executado na aplicação. Próxima prática: contrato C#, desserialização/validação e cinco tarefas de teste. Pedir JSON no prompt não substitui validar a resposta no código.

### Contexto persistente vs temporário

Persistente é a informação mantida para apoiar outras tarefas ou sessões; temporário é o contexto necessário para uma tarefa ou investigação atual.

No exercício de 15/09/2026, o aluno classificou corretamente:

| Informação | Classificação |
|---|---|
| O projeto usa C#/.NET e SQL Server | Persistente |
| Erros da API seguem `code` e `message` | Persistente |
| Nesta tarefa, gerar um plano e aguardar revisão | Temporário |
| Mensagem de falha da última execução do teste | Temporário |

Uma informação salva em arquivo precisa ser carregada pela aplicação ou ferramenta para entrar no contexto. Persistente não significa imutável: atualizar padrões quando mudarem. Uma investigação temporária pode produzir uma decisão que mereça documentação duradoura.

Se planejar e aguardar revisão fosse uma regra geral do projeto, poderia ser uma instrução persistente. O escopo explícito determina como reutilizá-la.

### Custo de contexto

Em uma API cobrada por tokens, retirar informações desnecessárias reduz os tokens de entrada e esse componente do custo. A saída também pode ser cobrada, com preço diferente. Preservar requisitos: um contexto incompleto pode causar erros e novas chamadas, anulando a economia.

Exemplo com preço fictício de R$ 2 por milhão de tokens de entrada, sem cache:

| Entrada por chamada | Chamadas | Total de tokens de entrada | Custo de entrada |
|---|---:|---:|---:|
| 10.000 tokens | 100 | 1.000.000 | R$ 2,00 |
| 2.000 tokens | 100 | 200.000 | R$ 0,40 |

Fórmula: tokens por chamada × chamadas ÷ 1.000.000 × preço por milhão. Nesse exemplo, a redução do custo de entrada é de 80%; o custo da saída não foi incluído.

Reenviar histórico pode repetir o consumo de entrada. Cache e cobrança dependem do serviço. Em aplicativos com assinatura, menos tokens não significa necessariamente uma mensalidade menor.

O aluno explicou a relação entre menos contexto desnecessário, menos tokens e menor custo. O cálculo foi apresentado pelo tutor; não houve medição real.

### Reuso de contexto

É reaproveitar informações relevantes que continuam válidas entre tarefas, como arquitetura, stack e padrões da API. Antes de reutilizar, conferir se a informação permanece atual e se realmente se aplica ao novo pedido.

No exercício de trocar o cadastro de clientes por uma consulta de pedidos, o aluno escolheu reutilizar C#/.NET, SQL Server e o formato de erro `code`/`message`, por serem informações gerais da aplicação. As regras de CPF e concorrência no cadastro ficaram fora por pertencerem à funcionalidade anterior.

Reutilizar texto não garante desconto nem memória automática: o conteúdo precisa estar disponível na chamada. Eventuais mecanismos de cache e sua cobrança dependem do serviço usado.

### Context stitching em alto nível — reunir fontes

Neste estudo, o termo descreve reunir informações relevantes de fontes diferentes em um contexto coerente para a tarefa. Por exemplo: juntar a regra aprovada no work item, os padrões da documentação e o comportamento encontrado no código.

Identificar a origem das informações e distinguir comportamento existente de comportamento desejado. Se duas fontes divergirem, verificar se existe uma decisão explícita que resolva a divergência; caso contrário, registrar o conflito como pendência. Não combinar regras incompatíveis silenciosamente.

Context pruning ajuda a selecionar o que permanece; Context stitching ajuda a organizar as partes selecionadas.

Exercício concluído: o aluno reuniu a regra da tarefa, o contrato da documentação e o comportamento atual do código. Pedido consolidado após revisão:

> Proponha um plano de alteração, sem implementar ainda. A validação de CPF deve considerar clientes ativos e inativos, conforme a tarefa aprovada. Os erros devem seguir o formato `code` e `message` definido na documentação da API. Hoje, o `ClienteService` obtém apenas clientes ativos; identifique a alteração necessária para atender à nova regra.

### Structured Output — prévia

Constrained decoding controla a geração token por token, permitindo somente continuações compatíveis com regras como uma gramática ou JSON Schema. Isso pode garantir a estrutura, mas não a veracidade dos valores.

### Modelos proprietários e open-weight

- Proprietário: pesos e operação normalmente controlados pelo provedor.
- Open-weight: pesos disponíveis para execução própria, conforme as condições da licença.
- Open-weight não significa necessariamente open-source.

Hospedar um modelo oferece maior controle, mas transfere para a empresa os custos de infraestrutura, implantação, segurança, monitoramento e manutenção.

### Limitações dos LLMs

- Podem alucinar e apresentar erros com confiança.
- Possuem janela de contexto limitada.
- O conhecimento pode estar desatualizado.
- Podem refletir vieses dos dados de treinamento.
- São sensíveis à qualidade do prompt e do contexto.
- Não possuem memória permanente entre requisições por conta própria.
- Precisam de validação antes de ações ou decisões críticas.

## Próximo passo

### Projeto `HelloLlm`

```text
Usuário
  ↓
ConsoleUserInterface
  ↓
Program
  ↓
GeminiClient
  ↓ HTTP
API do Gemini
  ↓
Modelo
  ↓ JSON
GeminiClient extrai o texto
  ↓
ConsoleUserInterface exibe resposta e duração
```

- O modelo é o componente treinado e probabilístico que processa o contexto e gera tokens.
- A aplicação é o software que usa o modelo e adiciona interface, configuração, tratamento de erros e regras determinísticas.
- A chave é lida de `GEMINI_API_KEY` e não é armazenada no repositório.
- O modelo pode ser trocado por `GEMINI_MODEL` sem alteração do código.
- Falhas transitórias usam até três tentativas com espera crescente.

## Próximo passo

Revisar o projeto `HelloLlm` e seguir a próxima atividade pendente da trilha.

## Etapa 2 — Prompt Engineering e Context Engineering

### System Prompt e User Prompt

1. System Prompt
   → define o papel, o comportamento e regras gerais, como regras de segurança.

2. User Prompt
   → contém a solicitação específica do usuário, como revisar um método.

```text
System Prompt → como o modelo deve se comportar
User Prompt   → o que o usuário quer realizar na interação
```

Um User Prompt útil explicita a tarefa, as fontes disponíveis, o resultado esperado, as restrições e como agir quando faltarem dados. Mencionar um sistema, como Azure DevOps, não concede acesso a ele; a aplicação precisa buscar os dados por API ou ferramenta e incluí-los no contexto.

```text
Se uma fonte não estiver disponível, informe isso explicitamente.
Não invente informações ausentes.
Diferencie fatos encontrados de suposições.
```

### Instruções claras

Instruções verificáveis definem quantidade, formato, fontes, restrições e comportamento quando faltarem dados. Termos subjetivos como “curto”, “completo” e “adequado” devem ser substituídos por critérios mensuráveis.

```text
Resumo: no máximo 50 palavras.
Riscos: até cinco.
Impacto: baixo, médio ou alto.
Sem dados suficientes: “não determinado”.
```

### Few-shot examples

Few-shot inclui algumas demonstrações de entrada e saída para ensinar formato, estilo ou critérios de classificação.

```text
zero-shot → nenhuma demonstração
one-shot  → uma demonstração
few-shot  → algumas demonstrações
```

Exemplos devem ser corretos e variados. Exemplos enviesados podem induzir um valor constante ou um padrão incorreto. Eles também consomem tokens, aumentam custo e ocupam a janela de contexto.

### Prompt templates

Template é uma estrutura reutilizável com campos que a aplicação preenche antes de enviar o prompt ao modelo.

```text
Título: {{title}}
Descrição: {{description}}
Máximo de riscos: {{maxRisks}}
```

- Partes fixas: instruções, rótulos, regras e estrutura.
- Partes variáveis: dados da tarefa, limites e idioma.
- Benefícios: estabilidade, repetibilidade, testes, versionamento e separação entre instruções e dados.

### Prompt chaining

Prompt chaining divide um processo em chamadas encadeadas, nas quais a saída de uma etapa alimenta a seguinte.

```text
extrair fatos
    ↓
validar fatos
    ↓
identificar riscos
    ↓
gerar dúvidas
    ↓
montar resposta final
```

Vantagens: etapas menores, validação intermediária e melhor localização de erros.

Custos: mais chamadas, tokens e latência; erros de uma etapa podem contaminar as próximas; a aplicação precisa coordenar o fluxo.

### Decomposição de tarefas

Decomposição divide um problema complexo em subtarefas menores e bem definidas. Ela define as partes do problema; prompt chaining é uma forma possível de executar essas partes em chamadas encadeadas.

```text
Decomposição
→ define as partes e responsabilidades

Prompt chaining
→ executa partes em sequência, passando resultados adiante
```

Subtarefas podem ter pré-condições. Se a recuperação não encontrar um work item obrigatório, a análise de riscos deve parar, informar os dados ausentes e evitar apresentar uma avaliação incompleta como confiável.

### Estratégias para diminuir respostas inconsistentes

Inconsistência ocorre quando entradas semelhantes produzem respostas com formato, critérios ou conteúdo muito diferentes.

- Usar instruções específicas e mensuráveis.
- Reduzir a temperatura para aumentar consistência.
- Restringir valores com enumerações, como `baixo`, `médio` ou `alto`.
- Usar JSON Schema quando houver suporte.
- Fornecer exemplos few-shot corretos e variados.
- Validar a saída na aplicação.
- Versionar templates e critérios de classificação.
- Decompor tarefas complexas e validar etapas intermediárias.

```text
“crítico”, “alto”, “grave”
        ↓ restringir valores
“baixo”, “médio”, “alto”
```

### Estratégias para reduzir alucinações

- Fornecer fontes relevantes e limitar a resposta ao contexto.
- Permitir respostas como `informação insuficiente` ou `não informado`.
- Separar fatos de inferências e suposições.
- Exigir evidências ou indicar a fonte de cada afirmação.
- Não solicitar dados aos quais o modelo não tem acesso.
- Validar informações críticas na aplicação.

```text
Não invente dados ausentes.
Se o prazo não estiver explicitamente nas fontes, responda:
“Prazo não informado”.
Quando uma estimativa for solicitada, identifique-a como suposição.
```

Essas instruções reduzem alucinações, mas não garantem sua eliminação, pois a geração continua sendo probabilística.

### Structured Output — solicitação de JSON

Structured Output busca produzir uma saída com estrutura previsível para integração entre sistemas.

```text
Retorne exclusivamente um JSON neste formato:

{
  "summary": "string",
  "risks": ["string"],
  "questions": ["string"]
}

Não inclua Markdown nem texto antes ou depois do JSON.
```

Pedir JSON apenas no prompt orienta o modelo, mas não garante sintaxe, campos ou tipos. JSON Schema e constrained decoding fornecem restrições mais fortes; a aplicação ainda precisa desserializar e validar o resultado.

#### Níveis de validação

```text
Sintaxe
→ obedece à gramática JSON

Estrutura
→ possui campos e tipos esperados

Regras de negócio
→ valores obrigatórios, não vazios e dentro dos limites
```

#### JSON Schema

JSON Schema descreve formalmente o contrato da saída.

- `type`: tipo esperado.
- `properties`: campos definidos.
- `required`: campos obrigatórios.
- `minLength`: tamanho mínimo do texto.
- `minimum` e `maximum`: intervalo numérico.
- `additionalProperties: false`: proíbe campos extras.

```text
schema no prompt
→ orientação mais clara

schema no Structured Output
→ restrição durante a geração

schema na aplicação
→ validação depois da resposta
```

#### Integração entre sistemas

Saída estruturada permite acessar campos conhecidos e comparar valores permitidos de forma determinística. Por exemplo, a aplicação pode filtrar `severity == "high"` sem interpretar um texto livre.

```text
temperatura → diversidade da geração
schema      → estrutura e valores permitidos
validação   → dados aceitáveis para a aplicação
```
