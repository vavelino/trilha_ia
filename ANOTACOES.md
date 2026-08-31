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
