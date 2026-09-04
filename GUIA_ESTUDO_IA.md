# Guia de Estudo — AI Engineering Aplicada

> **Versão:** 0.1 — fonte editável para revisão antes da geração do PDF.
>
> **Público:** desenvolvedores que querem construir aplicações profissionais com LLMs, especialmente usando C#/.NET e Azure.
>
> **Método:** ler, responder sem consultar o gabarito, executar a atividade prática e explicar as decisões com as próprias palavras.

---

## Como usar este guia

Conforme o assunto, cada módulo combina:

1. objetivos;
2. termos e conceitos;
3. exemplo aplicado;
4. erros, limites e decisões comuns;
5. atividade prática;
6. perguntas de revisão;
7. critérios de conclusão.

Os níveis indicam a profundidade esperada:

- **[ESSENCIAL]** — saber explicar e implementar;
- **[IMPORTANTE]** — saber aplicar e investigar problemas;
- **[AVANÇADO]** — conhecer o propósito e aprofundar quando necessário.

As respostas ficam no final para evitar leitura passiva. Questões abertas possuem critérios de correção, não uma única frase obrigatória.

## Documentos relacionados

- [TRILHA_IA_Profissional.md](TRILHA_IA_Profissional.md) — ordem prática, evidências de mercado e critérios de prontidão profissional;
- [ANOTACOES.md](ANOTACOES.md) — registro resumido do que já foi estudado;
- [TRILHA_IA.md](TRILHA_IA.md) — trilha original e histórico da evolução do estudo.

Este guia é o material teórico e prático para leitura. A trilha profissional continua sendo o roteiro de execução e priorização.

## Mapa do conteúdo

| Parte | Módulos | Resultado principal |
|---|---|---|
| Fundamentos | 1–2 | Entender como LLMs processam e geram texto |
| Prompt e contexto | 3–4 | Controlar instruções e selecionar contexto |
| Contratos e APIs | 5–6 | Integrar modelos com software confiável |
| Tools e protocolos | 7–8 | Conectar modelos a ações e sistemas |
| Retrieval e RAG | 9–12 | Fundamentar respostas em conhecimento externo |
| Agents | 13–14 | Construir workflows agentic com limites |
| Qualidade e segurança | 15–17 | Avaliar, observar e proteger o sistema |
| Adaptação e produção | 18–20 | Entender fine-tuning e operar soluções reais |
| Projeto | 21 | Reunir as competências em um portfólio |

---

# Parte I — Fundamentos

# Módulo 1 — IA, Machine Learning e LLMs

## Objetivos

- diferenciar automação, IA, Machine Learning e Deep Learning;
- entender modelo, treinamento, inferência, pesos e parâmetros;
- diferenciar modelo de aplicação de IA;
- reconhecer modelos proprietários e open-weight.

## 1.1 Automação e Inteligência Artificial [ESSENCIAL]

Uma automação executa regras definidas explicitamente:

```text
SE umidade < 30%
ENTÃO ligar irrigação
```

O comportamento é previsível para a mesma entrada. Isso não exige aprendizado a partir de dados.

Inteligência Artificial é um campo amplo. Historicamente inclui sistemas simbólicos baseados em regras, busca e planejamento, além de métodos que aprendem com dados. No uso profissional atual, é importante dizer qual técnica está sendo usada em vez de chamar qualquer automação de IA.

## 1.2 Machine Learning e Deep Learning [ESSENCIAL]

Machine Learning utiliza dados para ajustar um modelo capaz de produzir previsões ou decisões.

```text
dados + algoritmo de treinamento
             ↓
           modelo
             ↓
entrada nova → previsão
```

Deep Learning é uma subárea de Machine Learning baseada em redes neurais com muitas camadas.

```text
Inteligência Artificial
└── Machine Learning
    └── Deep Learning
        └── Large Language Models
```

Nem todo sistema de IA usa ML. Nem todo ML usa Deep Learning. Nem todo modelo de Deep Learning é um LLM.

## 1.3 Large Language Model [ESSENCIAL]

Um LLM é um modelo de Deep Learning treinado com grandes volumes de texto e outros dados para processar e gerar linguagem. Modelos modernos geralmente usam a arquitetura Transformer.

O LLM não é a aplicação completa. Ele é um componente utilizado por uma aplicação.

```text
Aplicação
├── interface
├── regras de negócio
├── autenticação
├── contexto
├── ferramentas
├── validação
└── chamada ao modelo
```

## 1.4 Treinamento e inferência [ESSENCIAL]

No treinamento, o modelo faz previsões, calcula o erro por meio de uma função de perda e ajusta seus parâmetros. Backpropagation calcula como os parâmetros contribuíram para o erro; um otimizador usa essa informação para atualizar os valores.

```text
Treinamento
entrada → previsão → erro → backpropagation → ajuste dos parâmetros
```

Na inferência, os parâmetros treinados são utilizados para produzir uma saída e normalmente não são alterados.

```text
Inferência
entrada → parâmetros fixos → saída
```

Parâmetro é o termo geral para valores aprendidos. Pesos são os principais parâmetros das conexões do modelo.

## 1.5 Foundation, base e instruction-tuned models [IMPORTANTE]

- **Foundation model:** modelo amplo que pode servir de base para diferentes tarefas.
- **Base model:** treinado principalmente para prever continuações; pode não seguir instruções de forma confiável.
- **Instruction-tuned model:** adaptado para responder a instruções e conversas.
- **Chat model:** expõe convenções de mensagens e papéis voltadas a diálogo.

Essas categorias podem se sobrepor. Sempre consultar a documentação do modelo específico.

## 1.6 Proprietário, open-source e open-weight [ESSENCIAL]

- **Proprietário:** operação, detalhes e pesos normalmente controlados pelo provedor.
- **Open-weight:** os pesos são disponibilizados conforme uma licença.
- **Open-source:** termo mais forte; idealmente inclui código e condições que permitem estudar, modificar e redistribuir.

Open-weight não significa automaticamente open-source. Dados de treinamento, processo e licença podem continuar restritos.

Hospedagem própria oferece controle, mas transfere custos de hardware, serving, segurança, atualizações e observabilidade.

## Erros comuns

- afirmar que toda automação é Machine Learning;
- dizer que inferência treina o modelo;
- confundir modelo com chatbot ou aplicação;
- chamar todo modelo com pesos disponíveis de open-source;
- presumir que parâmetros armazenam respostas como um banco de dados literal.

## Atividade prática 1 — Classificação de sistemas

Classifique cinco sistemas reais como regra, ML, Deep Learning ou aplicação com LLM. Para cada um, registre:

```text
Sistema:
Entrada:
Como produz a saída:
Existe aprendizado a partir de dados?
Classificação:
Justificativa:
```

## Perguntas de revisão

**Q1.** Qual é a relação entre IA, ML, Deep Learning e LLM?

**Q2.** O que muda nos parâmetros durante treinamento e inferência?

**Q3.** Por que um `if` que liga uma bomba d'água não é Machine Learning?

**Q4.** Qual é a diferença entre modelo e aplicação de IA?

**Q5.** Por que open-weight não significa necessariamente open-source?

## Critério de conclusão

- [ ] expliquei as quatro categorias sem consultar;
- [ ] classifiquei cinco sistemas e justifiquei;
- [ ] diferenciei treinamento de inferência;
- [ ] diferenciei modelo de aplicação.

---

# Módulo 2 — Como um LLM processa texto

## Objetivos

- entender tokens, embeddings, Transformer e attention;
- explicar geração token a token;
- entender janela de contexto e parâmetros de geração;
- reconhecer causas e limites relacionados a alucinação.

## 2.1 Token e tokenizer [ESSENCIAL]

Token é uma unidade processada pelo modelo. Pode representar uma palavra, parte de palavra, pontuação, número, espaço ou outra sequência aprendida pelo tokenizer.

```text
texto → tokenizer → IDs de tokens
```

Token não é sinônimo de palavra. A quantidade varia conforme idioma, código, caracteres, vocabulário e tokenizer do modelo.

Tokens influenciam:

- custo;
- latência;
- tamanho máximo da entrada;
- tamanho máximo da saída.

## 2.2 Embedding interno [ESSENCIAL]

O ID do token é transformado em um vetor numérico. Esse vetor é o embedding inicial usado pelas camadas do modelo.

```text
token 4217 → [0.12, -0.31, 0.08, ...]
```

Uma dimensão isolada raramente possui interpretação simples. O significado emerge do conjunto e das relações no espaço vetorial.

Embeddings internos de tokens não são exatamente a mesma coisa que embeddings de frases usados em busca semântica, embora compartilhem a ideia de representação vetorial.

## 2.3 Transformer e attention [ESSENCIAL]

Transformer é uma arquitetura usada tanto no treinamento quanto na inferência. Attention é um de seus mecanismos centrais.

Self-attention permite que a representação de um token seja construída considerando outros tokens da sequência. Isso ajuda a capturar referência, sintaxe, posição e relações de significado.

```text
“Ana colocou o livro na mochila porque ele era pesado.”
                                      ↑
attention relaciona “ele” a possíveis referentes
```

Attention ajuda, mas não elimina ambiguidades que o texto não resolve.

**Multi-head attention** executa diferentes projeções de atenção em paralelo, permitindo capturar tipos distintos de relação. Para AI Engineering, é suficiente compreender o papel; implementar a matemática não é requisito inicial.

## 2.4 Geração token a token [ESSENCIAL]

O modelo produz pontuações chamadas logits para os tokens possíveis. Essas pontuações são convertidas em uma distribuição de probabilidades.

```text
contexto → logits → probabilidades → token selecionado
```

O token gerado é acrescentado à sequência, e o processo se repete.

```text
entrada → token A
entrada + A → token B
entrada + A + B → token C
```

A geração termina por condições como:

- token especial de fim de sequência;
- limite de saída;
- sequência de parada;
- timeout ou cancelamento;
- chamada de ferramenta, dependendo do protocolo.

## 2.5 Temperatura, top-p e limites [ESSENCIAL]

A temperatura altera a forma da distribuição de probabilidades:

```text
temperatura baixa → mais consistência
temperatura alta  → mais diversidade
```

Temperatura não mede verdade nem inteligência. Uma saída consistente pode estar sempre errada.

**Top-p** limita a amostragem a um conjunto cuja probabilidade acumulada alcança determinado valor. Em geral, evitar alterar temperatura e top-p simultaneamente sem experimento controlado.

Outros parâmetros:

- `max_output_tokens`: limite de saída;
- `stop`: sequências de parada;
- `seed`: quando suportado, ajuda na reprodutibilidade, mas não garante igualdade em toda infraestrutura;
- penalidades de presença/frequência: alteram repetição conforme suporte do modelo.

## 2.6 Context Window [ESSENCIAL]

Janela de contexto é a quantidade máxima de tokens que o modelo consegue considerar em uma requisição. Pode incluir:

```text
system/developer instructions
+ histórico enviado
+ mensagem atual
+ documentos
+ resultados de tools
+ tokens gerados
```

Se a entrada ocupa quase todo o limite, sobra pouco espaço para a saída. Compactação, truncamento e resumo são decisões da aplicação ou do cliente; não devem ser presumidos.

## 2.7 Alucinação [ESSENCIAL]

Alucinação é uma afirmação falsa, inventada ou não sustentada pelas fontes, apresentada como válida.

Possíveis causas:

- objetivo de produzir continuação plausível;
- contexto ausente, ambíguo ou contraditório;
- conhecimento desatualizado;
- dados de treinamento com erros ou vieses;
- amostragem;
- prompt que exige uma resposta mesmo sem evidência.

Temperatura zero não elimina alucinação.

Estratégias de redução:

- fornecer fontes relevantes;
- exigir evidência e citações;
- permitir `não informado`;
- separar fato de inferência;
- validar informações críticas;
- usar retrieval/RAG;
- não disponibilizar dados desnecessários.

## Atividade prática 2 — Desenhar a inferência

Desenhe, sem consultar, o fluxo:

```text
texto → tokens → embeddings → Transformer/attention
     → probabilidades → seleção → repetição → resposta
```

Depois explique onde entram Context Window, temperatura e condição de parada.

## Perguntas de revisão

**Q6.** Por que 10 mil tokens não significam 10 mil palavras?

**Q7.** Qual é a diferença entre embedding e attention?

**Q8.** Transformer é arquitetura de treinamento ou de inferência?

**Q9.** Temperatura baixa garante precisão?

**Q10.** O que compõe a janela de contexto?

**Q11.** Como o modelo “sabe” que deve terminar a resposta?

**Q12.** Cite três estratégias para reduzir alucinação.

## Critério de conclusão

- [ ] desenhei e expliquei o fluxo de inferência;
- [ ] diferenciei token, embedding e attention;
- [ ] expliquei contexto e parâmetros de geração;
- [ ] reconheci que fluência não garante verdade.

---

# Parte II — Prompt e contexto

# Módulo 3 — Prompt Engineering

## Objetivos

- diferenciar papéis e mensagens;
- escrever instruções claras e verificáveis;
- usar templates, exemplos e decomposição;
- versionar e comparar prompts.

## 3.1 System, developer, user e assistant messages [ESSENCIAL]

APIs podem expor papéis diferentes. O suporte e a precedência exatos dependem do provedor.

- **System/developer:** comportamento, regras e limites gerais.
- **User:** solicitação e dados do usuário.
- **Assistant/model:** respostas anteriores usadas como histórico ou exemplos.
- **Tool:** resultado de uma ferramenta, quando suportado.

```text
instrução superior → como se comportar
mensagem do usuário → o que realizar agora
```

Prompts não substituem controles de segurança no código.

## 3.2 Anatomia de uma instrução clara [ESSENCIAL]

Um prompt verificável costuma definir:

1. tarefa;
2. fontes disponíveis;
3. formato esperado;
4. restrições;
5. critérios de qualidade;
6. comportamento quando faltarem dados.

Evitar termos subjetivos sem definição:

```text
“faça curto”       → “use no máximo 50 palavras”
“liste os riscos”  → “liste até cinco riscos técnicos”
“avalie a gravidade” → “use baixo, médio ou alto”
```

## 3.3 Zero-shot, one-shot e few-shot [ESSENCIAL]

- **Zero-shot:** apenas instrução, sem demonstração.
- **One-shot:** uma demonstração.
- **Few-shot:** algumas demonstrações.

Exemplos ensinam formato, estilo e critérios. Devem ser corretos, diversos e representativos. Se todos classificarem risco como alto, podem enviesar novas classificações.

## 3.4 Prompt template [ESSENCIAL]

Template é uma estrutura reutilizável com variáveis preenchidas pela aplicação antes da chamada.

```text
Título: {{title}}
Descrição: {{description}}
Comentários: {{comments}}
```

Separar dados de instruções reduz ambiguidade e facilita versionamento, testes e proteção contra conteúdo não confiável.

## 3.5 Decomposição e prompt chaining [ESSENCIAL]

Decomposição define subtarefas. Chaining executa etapas encadeadas, possivelmente com uma chamada de modelo por etapa.

```text
extrair fatos → validar → identificar riscos → gerar dúvidas
```

Benefícios:

- validação intermediária;
- prompts menores;
- localização de falhas;
- regras distintas por etapa.

Custos:

- mais tokens e latência;
- coordenação adicional;
- propagação de erro entre etapas.

## 3.6 Versionamento e experimentação [IMPORTANTE]

Prompts são artefatos de software. Devem possuir:

- identificador ou versão;
- dataset de teste;
- parâmetros registrados;
- métricas comparáveis;
- histórico de mudanças;
- rollback.

Alterar prompt e modelo ao mesmo tempo impede saber qual mudança causou o resultado.

## Erros comuns

- misturar instruções com dados sem delimitadores;
- pedir acesso a sistemas que o modelo não possui;
- adicionar exemplos demais;
- usar linguagem subjetiva;
- exigir resposta mesmo quando faltam fontes;
- otimizar apenas um caso e prejudicar os demais.

## Atividade prática 3 — Prompt do Task Analyzer

Escreva duas versões de um prompt que recebe um work item e retorna resumo, riscos e dúvidas.

- V1: zero-shot;
- V2: instruções mensuráveis e dois exemplos variados.

Teste com cinco tarefas, mantendo modelo e parâmetros iguais. Registre inconsistências observadas.

## Perguntas de revisão

**Q13.** Qual é a diferença entre System Prompt e User Prompt?

**Q14.** Quando few-shot ajuda e qual risco introduz?

**Q15.** Quem preenche as variáveis de um prompt template?

**Q16.** Qual é a diferença entre decomposição e chaining?

**Q17.** Por que modificar apenas uma variável por experimento?

## Critério de conclusão

- [ ] escrevi duas versões do prompt;
- [ ] testei cinco casos;
- [ ] registrei modelo, parâmetros e versão;
- [ ] justifiquei qual versão é melhor com evidências.

---

# Módulo 4 — Context Engineering

## Objetivos

- selecionar contexto relevante e seguro;
- diferenciar contexto global, da tarefa e histórico;
- aplicar pruning, stitching e compactação;
- entender contexto persistente e temporário.

## 4.1 O que é contexto [ESSENCIAL]

Contexto é tudo que o modelo recebe e consegue considerar na requisição. Context Engineering é o trabalho de selecionar, organizar, atualizar e proteger essas informações.

```text
informação certa
+ momento certo
+ formato certo
- ruído
- segredos
```

## 4.2 Contexto global e da tarefa [ESSENCIAL]

**Global:** regras reutilizáveis, idioma, políticas e convenções.

**Da tarefa:** título, descrição, critérios de aceite, comentários e dependências do work item atual.

Uma informação disponível não precisa entrar. Perguntar:

1. ajuda a responder?
2. é confiável e atual?
3. o benefício justifica custo e exposição?

## 4.3 Context pruning [ESSENCIAL]

Pruning remove conteúdo sem utilidade para a decisão atual:

- duplicações;
- mensagens antigas substituídas;
- resultados de busca irrelevantes;
- detalhes excessivos;
- dados pessoais e segredos desnecessários.

Pruning ruim também causa falha se remover uma restrição essencial. Deve ser avaliado, não apenas aplicado por tamanho.

## 4.4 Context stitching [IMPORTANTE]

Stitching combina fragmentos de diferentes fontes em um contexto coerente:

```text
work item + decisão arquitetural + trecho da documentação + resultado da tool
```

Cada fragmento deve preservar origem, data, confiança e relação com a tarefa. Misturar fontes sem rótulo favorece contradições e citações incorretas.

## 4.5 Histórico, resumo e memória [ESSENCIAL]

O modelo não mantém automaticamente memória permanente entre requisições. A aplicação decide o que reenviar.

- **Histórico bruto:** maior fidelidade, maior custo e ruído.
- **Resumo:** menor custo, risco de perder detalhes.
- **Estado estruturado:** campos explícitos, mais fácil de validar.
- **Memória externa:** informações persistidas e recuperadas quando relevantes.

Memória não é sinônimo de Context Window. A memória pode estar num banco; apenas a parte recuperada entra na janela atual.

## 4.6 Persistente e temporário [ESSENCIAL]

- **Persistente:** preferências ou fatos armazenados entre sessões.
- **Temporário:** informações úteis somente na tarefa atual.

Persistência exige consentimento, expiração, correção, exclusão e controle de acesso. Não persistir tudo por padrão.

## 4.7 Custo e qualidade do contexto [ESSENCIAL]

Mais contexto pode aumentar custo, latência e distração. Menos contexto pode omitir evidências. A meta não é contexto mínimo, mas contexto suficiente e relevante.

## Atividade prática 4 — Orçamento de contexto

Receba um work item com 80 comentários. Classifique cada item:

```text
INCLUIR | RESUMIR | RECUPERAR SOB DEMANDA | EXCLUIR
```

Monte um contexto final com origem e data de cada fragmento. Registre o que foi removido e o risco da remoção.

## Perguntas de revisão

**Q18.** Contexto é somente a mensagem atual?

**Q19.** Qual é a diferença entre memória e janela de contexto?

**Q20.** O que é context pruning e qual seu risco?

**Q21.** O que context stitching precisa preservar?

**Q22.** Por que uma informação disponível pode ficar fora do contexto?

## Critério de conclusão

- [ ] classifiquei os 80 comentários;
- [ ] justifiquei inclusão e exclusão;
- [ ] preservei fontes e datas;
- [ ] identifiquei informações sensíveis;
- [ ] estimei impacto em tokens.

---

# Parte III — Contratos e APIs

# Módulo 5 — Structured Output

## Objetivos

- diferenciar JSON válido, contrato e regra de negócio;
- usar JSON Schema e DTOs;
- entender constrained decoding;
- implementar fallback e validação.

## 5.1 Por que estrutura importa [ESSENCIAL]

Texto livre é adequado para pessoas, mas frágil para automação. Uma saída estruturada oferece campos conhecidos.

```json
{
  "description": "Token sem expiração",
  "score": 8,
  "mitigation": "Definir expiração e uso único"
}
```

A aplicação pode filtrar `score >= 7` sem interpretar linguagem natural.

## 5.2 Três níveis de validade [ESSENCIAL]

```text
Sintaxe
→ obedece à gramática JSON

Estrutura
→ campos e tipos correspondem ao contrato

Negócio
→ valores respeitam regras do domínio
```

Um JSON pode ser sintaticamente válido e ainda conter `score: 15`.

## 5.3 JSON Schema [ESSENCIAL]

JSON Schema permite declarar:

- `type`;
- `properties`;
- `required`;
- `enum`;
- `minimum` e `maximum`;
- `minLength`;
- `items`;
- `additionalProperties`.

Exemplo reduzido:

```json
{
  "type": "object",
  "properties": {
    "summary": { "type": "string", "minLength": 1 },
    "score": { "type": "integer", "minimum": 0, "maximum": 10 }
  },
  "required": ["summary", "score"],
  "additionalProperties": false
}
```

## 5.4 Constrained decoding [IMPORTANTE]

Constrained decoding restringe os tokens permitidos durante a geração para respeitar uma gramática ou schema.

```text
schema no prompt → orientação
schema no modo estruturado → restrição de geração
schema na aplicação → validação pós-resposta
```

Ele melhora validade estrutural, mas não garante que valores sejam verdadeiros.

## 5.5 DTO e validação [ESSENCIAL]

Em .NET, a resposta deve ser desserializada para tipos conhecidos e validada.

```csharp
public sealed record RiskDto(
    string Description,
    int Score,
    string Mitigation);
```

Validar:

- objeto e coleções não nulos;
- texto obrigatório não vazio;
- intervalo de score;
- limites de tamanho;
- valores permitidos;
- regras entre campos.

## 5.6 Fallback [IMPORTANTE]

Se a saída falhar:

1. registrar versão do prompt/modelo e tipo de erro;
2. repetir somente se houver chance real de correção;
3. enviar mensagem de reparo ou refazer com schema;
4. limitar tentativas;
5. retornar erro controlado;
6. nunca executar ação crítica com dados inválidos.

## Atividade prática 5 — Contrato do Task Analyzer

Defina schema e DTO para:

```text
summary
technicalTasks[]
risks[{ description, score, evidence, mitigation }]
questions[]
```

Crie testes para:

- JSON correto;
- campo ausente;
- tipo incorreto;
- score fora do intervalo;
- campo extra;
- evidência vazia.

## Perguntas de revisão

**Q23.** JSON sintaticamente válido é suficiente?

**Q24.** O que `additionalProperties: false` controla?

**Q25.** Qual é a diferença entre constrained decoding e validação?

**Q26.** Schema garante veracidade?

**Q27.** Por que DTO não elimina validação de negócio?

## Critério de conclusão

- [ ] escrevi schema e DTO;
- [ ] validei seis casos;
- [ ] tratei resposta inválida sem executar ações;
- [ ] expliquei estrutura versus veracidade.

---

# Módulo 6 — Engenharia de APIs de LLM

## Objetivos

- entender request, response e streaming;
- implementar resiliência sem repetir erros permanentes;
- proteger credenciais;
- observar tokens, latência e custo.

## 6.1 Request e response [ESSENCIAL]

Uma aplicação envia ao provedor modelo, mensagens, parâmetros e opções de saída. O provedor devolve conteúdo, metadados de uso, motivo de parada e possíveis tool calls.

```text
aplicação → HTTPS → API do provedor → modelo
aplicação ← JSON/stream ← resposta
```

Os campos exatos variam. Isolar o cliente do provedor reduz acoplamento.

## 6.2 Streaming [IMPORTANTE]

Sem streaming, a aplicação espera a resposta completa. Com streaming, recebe partes progressivamente.

Benefícios:

- menor tempo percebido até o primeiro conteúdo;
- melhor experiência em respostas longas.

Custos:

- UI e parsing mais complexos;
- erros podem ocorrer após conteúdo parcial;
- moderação e validação estruturada exigem estratégia específica;
- cancelamento e reconexão ficam mais importantes.

## 6.3 Timeout e cancellation [ESSENCIAL]

Timeout limita quanto uma operação pode aguardar. Cancellation permite que usuário ou sistema interrompa o trabalho.

Não confundir:

- timeout do cliente;
- timeout de gateway;
- tempo máximo de geração;
- limite de tokens de saída.

Uma operação cancelada não deve continuar consumindo recursos desnecessariamente.

## 6.4 Retry, backoff e jitter [ESSENCIAL]

Retry é adequado para falhas transitórias, como `429`, `502`, `503` e `504`, observando a documentação do provedor.

```text
tentativa → falha transitória → espera crescente → nova tentativa
```

- **Backoff exponencial:** aumenta a espera a cada falha.
- **Jitter:** adiciona variação para evitar que muitos clientes repitam juntos.
- **Retry-After:** quando presente, deve ser respeitado.

Não repetir automaticamente:

- credencial inválida;
- request inválido;
- modelo inexistente;
- conteúdo proibido;
- operação não idempotente sem proteção.

## 6.5 Rate limiting [ESSENCIAL]

Provedores podem limitar requests por minuto, tokens por minuto e uso diário. A aplicação deve:

- limitar concorrência;
- aplicar fila quando necessário;
- respeitar headers de quota;
- controlar tamanho de entrada/saída;
- evitar retry agressivo;
- apresentar erro compreensível.

## 6.6 Segurança de credenciais [ESSENCIAL]

Chaves não devem entrar em:

- código-fonte;
- prompt;
- repositório;
- logs;
- mensagens de erro para usuários.

Preferir variável de ambiente no desenvolvimento e secret manager/managed identity em produção, quando suportado.

`.gitignore` reduz risco de versionamento, mas não impede leitura local nem substitui gestão de segredos.

## 6.7 Uso, custo e cache [IMPORTANTE]

Registrar quando disponível:

- tokens de entrada;
- tokens de saída;
- tokens adicionais de raciocínio, conforme o provedor;
- modelo;
- latência;
- cache hit/miss;
- custo estimado.

Tipos de cache:

- **response cache:** reutiliza resultado para entrada equivalente;
- **prompt/context cache:** provedor reutiliza processamento de prefixo;
- **semantic cache:** encontra perguntas de significado semelhante.

Cache exige política de expiração, isolamento por usuário e cuidado com dados sensíveis.

## 6.8 Model routing e fallback [AVANÇADO]

Um router escolhe modelo com base em complexidade, custo, latência ou modalidade. Fallback troca de modelo/provedor quando há indisponibilidade.

Riscos:

- qualidade diferente;
- schemas e recursos incompatíveis;
- comportamento de segurança diferente;
- custo inesperado;
- dificuldade de comparar resultados.

## Atividade prática 6 — Cliente resiliente

Evolua `HelloLlm`:

- timeout configurável;
- `CancellationToken`;
- retry limitado para falhas transitórias;
- leitura segura de chave;
- modelo configurável;
- logging sem prompt sensível;
- medição de latência;
- testes com `HttpMessageHandler` falso.

## Perguntas de revisão

**Q28.** Qual é a diferença entre timeout e limite de saída?

**Q29.** Por que não repetir uma resposta `401` com a mesma chave?

**Q30.** Qual problema o jitter reduz?

**Q31.** Streaming reduz necessariamente a latência total?

**Q32.** Por que cache precisa considerar usuário e autorização?

## Critério de conclusão

- [ ] tratei falhas transitórias e permanentes de forma distinta;
- [ ] implementei cancelamento e timeout;
- [ ] não registrei segredos;
- [ ] medi latência e uso;
- [ ] testei o cliente sem API real.

---

# Parte IV — Tools e protocolos

# Módulo 7 — Function e Tool Calling

## Objetivos

- compreender que o modelo solicita, mas a aplicação executa;
- criar tools pequenas, validadas e observáveis;
- limitar ações e tratar falhas.

## 7.1 Fluxo de Tool Calling [ESSENCIAL]

```text
usuário pergunta
      ↓
modelo escolhe uma tool e produz argumentos
      ↓
aplicação valida e autoriza
      ↓
aplicação executa código/API
      ↓
resultado volta ao modelo
      ↓
modelo produz resposta final
```

O modelo não executa a função por mágica. Ele gera uma solicitação estruturada; o runtime da aplicação decide se e como executar.

## 7.2 Schema de uma tool [ESSENCIAL]

Uma tool precisa de:

- nome claro;
- descrição orientada a quando usar;
- parâmetros com tipos e limites;
- campos obrigatórios;
- descrição da saída e possíveis erros.

Tools amplas e vagas aumentam seleção e argumentos incorretos.

## 7.3 Validação e autorização [ESSENCIAL]

Antes da execução:

1. confirmar que a tool está na allowlist;
2. validar schema e regras de negócio;
3. verificar identidade e permissão;
4. limitar escopo;
5. solicitar aprovação para ação crítica;
6. registrar auditoria sem segredos.

Nunca confiar em argumentos apenas porque foram produzidos pelo modelo.

## 7.4 Idempotência e efeitos colaterais [IMPORTANTE]

Uma operação idempotente pode ser repetida sem mudar o resultado além da primeira execução. Leitura costuma ser mais segura que escrita.

Para criar, pagar, enviar, excluir ou publicar:

- usar idempotency key quando disponível;
- confirmar parâmetros;
- evitar retry cego;
- separar proposta de execução;
- exigir aprovação quando necessário.

## 7.5 Resultado e erro da tool [ESSENCIAL]

O resultado deve ser estruturado e pequeno. Erros precisam distinguir:

- entrada inválida;
- não autorizado;
- não encontrado;
- falha transitória;
- falha interna.

O modelo pode reformular uma resposta, mas não deve esconder a falha real.

## 7.6 Múltiplas tools [IMPORTANTE]

Descrições sobrepostas causam roteamento ruim. Avaliar:

- tool correta escolhida;
- argumentos corretos;
- taxa de sucesso;
- chamadas desnecessárias;
- sequência de chamadas;
- custo e latência.

## Atividade prática 7 — Tools do assistente

Implemente:

```text
GetWorkItem(id)
GetProject(projectId)
SearchDocumentation(query, topK)
```

Use dados simulados primeiro. Inclua testes de ID inválido, acesso negado, não encontrado, timeout e seleção da tool errada.

## Perguntas de revisão

**Q33.** Quem executa a tool: o modelo ou a aplicação?

**Q34.** Por que validar os argumentos gerados pelo modelo?

**Q35.** Qual é o risco de retry numa tool de pagamento?

**Q36.** O que uma boa descrição de tool precisa esclarecer?

**Q37.** Quais métricas ajudam a avaliar múltiplas tools?

## Critério de conclusão

- [ ] implementei três tools;
- [ ] validei e autorizei argumentos;
- [ ] tratei cinco tipos de falha;
- [ ] registrei execução e duração;
- [ ] impedi ação crítica sem aprovação.

---

# Módulo 8 — Model Context Protocol (MCP)

## Objetivos

- entender cliente, servidor, tools, resources e prompts;
- diferenciar MCP, Tool Calling e REST;
- criar uma integração segura.

## 8.1 Problema resolvido [ESSENCIAL]

MCP padroniza como clientes de IA descobrem e usam capacidades e contexto expostos por servidores compatíveis.

Sem um protocolo, cada integração define descoberta, schema e transporte de forma própria. MCP fornece convenções comuns, mas não substitui toda API ou regra de negócio.

## 8.2 Componentes [ESSENCIAL]

- **Host:** aplicação em que o usuário interage.
- **Client:** mantém conexão com um servidor MCP.
- **Server:** expõe capacidades.
- **Tool:** ação invocável.
- **Resource:** dado/contexto acessível.
- **Prompt:** template reutilizável oferecido pelo servidor.
- **Transport:** mecanismo de comunicação, como stdio ou HTTP compatível.

Os detalhes variam com a versão da especificação; consultar a documentação vigente ao implementar.

## 8.3 MCP vs. Tool Calling [ESSENCIAL]

```text
Tool Calling
= modelo solicita o uso de uma ferramenta

MCP
= protocolo para disponibilizar e descobrir capacidades/contexto
```

Uma tool disponibilizada por MCP ainda pode participar de um fluxo de Tool Calling.

## 8.4 MCP vs. REST [ESSENCIAL]

REST é um estilo comum para APIs de sistemas. MCP é voltado à integração entre aplicações de IA e provedores de contexto/capacidades.

Um servidor MCP pode internamente chamar APIs REST. Se existe apenas uma integração simples e estável, a chamada REST direta pode ser suficiente.

## 8.5 Segurança [ESSENCIAL]

MCP não torna uma capacidade automaticamente segura. Aplicar:

- autenticação;
- autorização por operação e recurso;
- least privilege;
- validação de parâmetros;
- rate limiting;
- consentimento/aprovação;
- logs de auditoria;
- proteção de tokens;
- limites de rede e filesystem;
- confiança explícita no servidor.

Um servidor MCP de terceiros amplia a superfície de ataque e deve ser tratado como dependência externa.

## 8.6 Quando usar [IMPORTANTE]

Use quando:

- vários clientes precisam das mesmas capacidades;
- descoberta e interoperabilidade têm valor;
- a integração será reutilizada;
- ferramentas e recursos mudam independentemente do host.

Evite adicionar MCP apenas por tendência quando uma função local ou API direta resolve com menos complexidade.

## Atividade prática 8 — Company MCP

Crie um servidor experimental:

```text
Company.MCP
├── tool: get_work_item
├── tool: get_project
├── resource: project_documentation
└── prompt: analyze_work_item
```

Conecte um cliente, teste descoberta, sucesso, autorização negada e indisponibilidade.

## Perguntas de revisão

**Q38.** Qual problema o MCP resolve?

**Q39.** MCP substitui Tool Calling?

**Q40.** Quando uma API direta é mais simples?

**Q41.** Qual é a diferença entre tool e resource?

**Q42.** Por que um servidor MCP exige avaliação de confiança?

## Critério de conclusão

- [ ] expliquei MCP vs. Tool Calling e REST;
- [ ] criei tool, resource e prompt;
- [ ] conectei um cliente;
- [ ] implementei autorização mínima;
- [ ] documentei quando não usar MCP.

---

# Parte V — Retrieval e RAG

# Módulo 9 — Embeddings para busca

## Objetivos

- entender vetor, dimensionalidade e similaridade;
- gerar embeddings de frases;
- reconhecer limitações e requisitos operacionais.

## 9.1 Representação vetorial [ESSENCIAL]

Um embedding representa texto, imagem ou outro conteúdo como vetor numérico. Textos semanticamente semelhantes tendem a ocupar regiões próximas no espaço aprendido.

```text
“redefinir minha senha” ≈ “recuperar acesso à conta”
```

O embedding não é uma explicação legível do significado e não contém garantia de verdade.

## 9.2 Dimensionalidade [IMPORTANTE]

Dimensionalidade é a quantidade de números no vetor. Mais dimensões não significam automaticamente melhor qualidade. Modelo, domínio, idioma, dados e métrica precisam ser avaliados no caso real.

Vetores comparados devem ser compatíveis: usar o mesmo modelo e versão na indexação e na consulta.

## 9.3 Similaridade de cosseno [ESSENCIAL]

Cosine similarity compara o ângulo entre vetores. Valores maiores geralmente indicam maior similaridade, mas intervalo e interpretação dependem da implementação.

```text
consulta → embedding → comparação → documentos mais próximos
```

Limiar não deve ser escolhido apenas por intuição. Usar dataset e medir falsos positivos/negativos.

## 9.4 Limitações [ESSENCIAL]

- proximidade semântica não garante relevância para a tarefa;
- negação, números, códigos e nomes podem exigir busca textual;
- documentos longos precisam ser divididos;
- embeddings podem refletir vieses;
- troca de modelo exige reindexação;
- dados sensíveis continuam sensíveis quando vetorizados.

## Atividade prática 9 — Mapa semântico

Crie 20 frases, gere embeddings e compare:

- paráfrases sem palavras iguais;
- mesma palavra com sentidos diferentes;
- negação;
- códigos de erro;
- português e inglês.

Registre os cinco resultados mais surpreendentes.

## Perguntas de revisão

**Q43.** Por que busca semântica encontra paráfrases?

**Q44.** Dimensão maior garante qualidade maior?

**Q45.** Por que trocar o modelo de embedding exige atenção ao índice?

**Q46.** Um embedding anonimiza dados pessoais?

**Q47.** Por que códigos exatos podem favorecer busca textual?

## Critério de conclusão

- [ ] gerei e comparei embeddings;
- [ ] expliquei cosine similarity;
- [ ] encontrei limitações reais;
- [ ] documentei modelo e versão.

---

# Módulo 10 — Vector Search e Hybrid Search

## Objetivos

- entender índice, top-k, filtro e ANN;
- comparar keyword, vector e hybrid search;
- introduzir reranking.

## 10.1 Índice vetorial [ESSENCIAL]

Um índice organiza vetores para recuperar vizinhos semelhantes. Busca exata compara com todos os vetores; Approximate Nearest Neighbor troca pequena perda potencial de recall por velocidade e escala.

**HNSW** é uma técnica frequente de ANN baseada em grafo. Não é necessário implementá-la do zero, mas é preciso entender trade-offs de memória, indexação, latência e recall.

## 10.2 Top-k e limiar [ESSENCIAL]

- **Top-k:** quantidade máxima de resultados.
- **Threshold:** similaridade mínima aceita.

Top-k alto aumenta cobertura e ruído. Top-k baixo pode omitir evidência. Ambos devem ser avaliados.

## 10.3 Metadados e filtros [ESSENCIAL]

Metadados permitem restringir por:

- projeto;
- versão;
- data;
- idioma;
- tipo de documento;
- autorização;
- status.

Filtro de autorização deve ocorrer de forma segura no retrieval, não depender apenas do prompt.

## 10.4 Keyword Search [ESSENCIAL]

Busca textual é forte para termos exatos, nomes, IDs, datas, códigos e palavras raras. BM25 é um algoritmo comum de ranqueamento textual.

## 10.5 Hybrid Search [ESSENCIAL]

Combina busca textual e vetorial, reunindo precisão lexical e semelhança semântica.

```text
query
├── busca textual
└── busca vetorial
        ↓
fusão dos rankings
```

Reciprocal Rank Fusion (RRF) combina posições de rankings sem exigir que scores diferentes tenham a mesma escala.

## 10.6 Reranking [IMPORTANTE]

Reranker reavalia um conjunto menor de candidatos com um método mais caro e preciso. Pipeline comum:

```text
retrieval rápido → 30 candidatos → reranker → 5 melhores
```

Ele não recupera um documento que nunca entrou nos candidatos.

## Atividade prática 10 — Comparação de busca

Com 30 documentos, execute dez consultas usando:

1. keyword;
2. vector;
3. hybrid;
4. hybrid com filtro;
5. hybrid com reranking, se disponível.

Registre documento esperado, posição encontrada e tempo.

## Perguntas de revisão

**Q48.** Qual trade-off existe em ANN?

**Q49.** O que muda ao aumentar top-k?

**Q50.** Quando metadata filtering é indispensável?

**Q51.** Por que vector search não é sempre melhor que keyword?

**Q52.** O que reranking não consegue corrigir?

## Critério de conclusão

- [ ] comparei três tipos de busca;
- [ ] medi posição e latência;
- [ ] testei IDs, negação e paráfrases;
- [ ] justifiquei top-k e filtros.

---

# Módulo 11 — RAG de ponta a ponta

## Objetivos

- entender ingestion, retrieval e generation;
- produzir respostas fundamentadas e citadas;
- diagnosticar falhas por etapa.

## 11.1 Arquitetura [ESSENCIAL]

Indexação:

```text
fontes → parsing → limpeza → chunking → embeddings → índice
```

Consulta:

```text
pergunta → transformação → retrieval → reranking
         → construção de contexto → LLM → resposta + fontes
```

RAG não treina o modelo com os documentos. Ele recupera conteúdo e o inclui no contexto da inferência.

## 11.2 Parsing e limpeza [ESSENCIAL]

Parsing extrai texto e estrutura de Markdown, HTML, PDF, planilhas, imagens/OCR e outras fontes.

Preservar quando relevante:

- títulos e hierarquia;
- tabelas;
- código;
- página/seção;
- links;
- versão e data;
- ACL/autorização.

Texto extraído incorretamente produz embeddings e retrieval ruins.

## 11.3 Chunking [ESSENCIAL]

Chunk é uma unidade indexada. Estratégias:

- tamanho fixo;
- por parágrafo/seção;
- semântico;
- parent-child;
- específico do tipo de documento.

Chunk pequeno pode perder contexto. Chunk grande pode misturar assuntos, gastar tokens e reduzir precisão.

Overlap repete uma parte entre chunks para preservar continuidade, mas aumenta armazenamento e duplicação.

## 11.4 Query transformation [IMPORTANTE]

- **Rewriting:** torna a pergunta mais adequada à busca.
- **Expansion:** inclui termos relacionados.
- **Decomposition:** divide uma pergunta composta.
- **Multi-query:** gera consultas alternativas.

Transformação incorreta pode afastar a busca da intenção original; preservar e registrar a pergunta inicial.

## 11.5 Grounding e citações [ESSENCIAL]

Grounding busca manter a resposta sustentada pelas fontes fornecidas. Uma citação deve permitir verificar a afirmação:

- documento;
- seção/página;
- link ou identificador;
- trecho ou posição quando possível.

Uma citação existente não prova que ela sustenta a frase. Avaliar source attribution.

## 11.6 Falhas por etapa [ESSENCIAL]

```text
resposta errada
├── fonte ausente?
├── parsing incorreto?
├── chunk inadequado?
├── embedding fraco?
├── filtro excluiu conteúdo?
├── retrieval não encontrou?
├── reranker rebaixou?
├── contexto truncou?
└── geração ignorou a evidência?
```

Sem observabilidade, tudo parece “erro do modelo”.

## Atividade prática 11 — Documentation Assistant

Ingerir documentação do repositório e responder 20 perguntas conhecidas.

Para cada resposta, salvar:

```json
{
  "question": "",
  "expectedSource": "",
  "retrievedSources": [],
  "answer": "",
  "citations": [],
  "latencyMs": 0,
  "notes": ""
}
```

## Perguntas de revisão

**Q53.** RAG altera os pesos do LLM?

**Q54.** Por que não enviar sempre o documento inteiro?

**Q55.** Qual trade-off existe no tamanho do chunk?

**Q56.** Por que overlap existe e qual seu custo?

**Q57.** Uma citação garante grounding?

**Q58.** Como separar falha de retrieval de falha de geração?

## Critério de conclusão

- [ ] implementei indexação e consulta;
- [ ] preservei metadados e autorização;
- [ ] produzi fontes verificáveis;
- [ ] avaliei 20 perguntas;
- [ ] diagnostiquei pelo menos uma falha em cada metade do pipeline.

---

# Módulo 12 — RAG avançado e avaliação de retrieval

## Objetivos

- melhorar retrieval com técnicas justificadas;
- medir qualidade antes e depois;
- reconhecer quando agentic RAG faz sentido.

## 12.1 Técnicas [IMPORTANTE]

- query rewriting e multi-query;
- hybrid search;
- reranking;
- contextual compression;
- parent-child retrieval;
- sentence-window retrieval;
- expansão por metadados;
- recuperação iterativa;
- cache semântico.

Não adicionar técnicas sem baseline e métrica. Complexidade sem avaliação apenas dificulta debugging.

## 12.2 Métricas de retrieval [IMPORTANTE]

- **Recall@k:** o documento relevante apareceu nos primeiros `k`?
- **Precision@k:** quantos dos primeiros `k` são relevantes?
- **MRR:** quão cedo aparece o primeiro resultado relevante?
- **nDCG:** considera posição e graus de relevância.
- **Hit rate:** houve ao menos um acerto?

As métricas exigem julgamento esperado ou rótulos confiáveis.

## 12.3 RAG Triad [IMPORTANTE]

- **Context relevance:** o contexto recuperado é relevante à pergunta?
- **Groundedness:** a resposta é sustentada pelo contexto?
- **Answer relevance:** a resposta atende à pergunta?

Uma resposta pode ser relevante, mas não grounded; ou grounded em um contexto irrelevante.

## 12.4 Agentic RAG [AVANÇADO]

No RAG tradicional, o fluxo de busca é predeterminado. No agentic RAG, o agente pode decidir se, quando e como buscar, reformular e repetir.

Benefícios potenciais:

- perguntas compostas;
- múltiplas fontes;
- recuperação iterativa.

Riscos:

- custo e latência;
- loops;
- consultas desnecessárias;
- maior superfície de segurança;
- avaliação mais difícil.

## Atividade prática 12 — Experimento de melhoria

1. estabeleça baseline de 20 perguntas;
2. escolha uma única mudança;
3. execute novamente;
4. compare retrieval e resposta;
5. documente ganhos e regressões;
6. decida manter ou reverter.

## Perguntas de revisão

**Q59.** Por que melhorar uma métrica de retrieval pode não melhorar a resposta final?

**Q60.** Qual é a diferença entre context relevance e groundedness?

**Q61.** Por que mudar chunking, embedding e reranker ao mesmo tempo é ruim para o experimento?

**Q62.** Quando agentic RAG pode ser excessivo?

**Q63.** O que MRR valoriza?

## Critério de conclusão

- [ ] estabeleci baseline;
- [ ] mudei uma variável por vez;
- [ ] medi retrieval e geração;
- [ ] registrei regressões;
- [ ] justifiquei a complexidade adicionada.

---

# Parte VI — Agents e orquestração

# Módulo 13 — Agents e workflows

## Objetivos

- distinguir um chatbot, um workflow e um agent;
- entender o ciclo de decisão de um agent;
- controlar autonomia, estado, custo e encerramento.

## 13.1 O que é um agent [ESSENCIAL]

Um **AI agent** é um sistema no qual o modelo recebe um objetivo, observa o estado disponível, decide a próxima ação, usa ferramentas quando necessário e repete o ciclo até terminar ou atingir um limite.

```text
objetivo → observar → decidir → agir → receber resultado → atualizar estado
                    ↑                              |
                    └──────── repetir ─────────────┘
```

O LLM é apenas uma parte. Um agent completo também possui código de orquestração, tools, estado, regras de parada, validações e controles de segurança.

## 13.2 Workflow determinístico e fluxo agentic [ESSENCIAL]

Em um **workflow determinístico**, o código define antecipadamente a sequência:

```text
obter tarefa → obter comentários → calcular regras → gerar relatório
```

Em um **fluxo agentic**, o modelo pode escolher o próximo passo:

```text
receber objetivo → decidir qual fonte consultar → analisar resultado
                 → decidir se falta informação → concluir
```

Use workflow quando o processo é conhecido e estável. Use autonomia agentic quando os caminhos variam e não é prático codificar todas as decisões. Muitos sistemas profissionais são híbridos: workflow por fora e decisões limitadas do agent por dentro.

## 13.3 Ciclo de ação e observação [ESSENCIAL]

Um padrão comum separa:

- **ação:** tool escolhida e argumentos;
- **observação:** resultado devolvido pela aplicação;
- **estado:** fatos já coletados e etapas concluídas;
- **resposta final:** conclusão entregue ao usuário.

Para auditoria, registre ações e observações. Não dependa da exposição do raciocínio privado do modelo; uma trilha objetiva de decisões, entradas e resultados é mais segura e útil.

## 13.4 Planejamento, execução e verificação [IMPORTANTE]

Uma tarefa complexa pode ser dividida em:

1. criar um plano curto;
2. executar uma etapa;
3. conferir o resultado com critérios observáveis;
4. corrigir ou avançar;
5. produzir a resposta final.

A etapa de verificação reduz erros, mas não garante verdade. Se o mesmo modelo cria e avalia a resposta sem evidências externas, ele pode repetir o erro.

## 13.5 Estado e memória [IMPORTANTE]

**Estado** é o conjunto de dados necessários para continuar uma execução: objetivo, etapa atual, resultados das tools, erros e orçamento restante.

**Memória de trabalho** contém dados da execução atual. **Memória de sessão** preserva informações durante uma conversa. **Memória persistente** sobrevive a novas sessões, geralmente em banco de dados ou índice. Memória persistente exige consentimento, retenção definida e proteção de dados.

Não coloque tudo na janela de contexto. Guarde dados estruturados fora do prompt e injete somente o necessário para a próxima decisão.

## 13.6 Limites e parada [ESSENCIAL]

Todo agent precisa de limites explícitos:

- máximo de etapas e de chamadas de tools;
- timeout total e por operação;
- orçamento de tokens ou dinheiro;
- ferramentas e recursos permitidos;
- condições de sucesso e de falha;
- aprovação humana para ações sensíveis;
- detecção de repetição ou ausência de progresso.

Sem esses controles, um erro pode se transformar em loop, custo excessivo ou alteração indevida de dados.

## Atividade prática 13 — Agent de análise de tarefa

Desenhe um agent que analise uma tarefa do Azure DevOps:

1. recebe o identificador da tarefa;
2. lê descrição e comentários;
3. identifica ligações diretas;
4. consulta somente as ligações relevantes;
5. detecta informações ausentes;
6. gera resumo, riscos e dúvidas em schema validado;
7. encerra após no máximo oito chamadas;
8. não altera nenhum work item.

Registre em uma tabela: etapa, tool, entrada, saída resumida, duração e erro.

## Perguntas de revisão

**Q64.** O que diferencia um agent de uma única chamada ao LLM?

**Q65.** Quando um workflow determinístico é melhor que um agent?

**Q66.** Por que uma segunda geração do mesmo modelo não garante uma verificação correta?

**Q67.** Qual é a diferença entre estado e memória persistente?

**Q68.** Cite quatro limites necessários em um agent.

**Q69.** Por que registrar ação e observação é melhor do que depender do raciocínio privado do modelo?

## Critério de conclusão

- [ ] distingui workflow e agent;
- [ ] desenhei o ciclo de execução;
- [ ] defini estado e regras de parada;
- [ ] limitei tools, custo e duração;
- [ ] identifiquei ações que exigem aprovação humana.

---

# Módulo 14 — Multi-agent e interoperabilidade

## Objetivos

- reconhecer padrões de colaboração entre agents;
- decidir quando um único agent é suficiente;
- entender delegação, handoff e contratos de comunicação.

## 14.1 Por que dividir agentes [AVANÇADO]

Agentes especializados podem separar responsabilidades, contexto, permissões ou modelos. Exemplos:

- um agent pesquisa documentação;
- outro analisa segurança;
- outro consolida o relatório.

Dividir só vale a pena quando a separação melhora qualidade, isolamento ou paralelismo mais do que aumenta custo e complexidade.

## 14.2 Padrões de orquestração [AVANÇADO]

| Padrão | Funcionamento | Uso típico |
|---|---|---|
| Sequencial | saída de um vira entrada do próximo | pipeline de revisão |
| Paralelo | agentes executam tarefas independentes | análises por especialidade |
| Supervisor | um coordenador delega e consolida | tarefas variáveis |
| Handoff | um agent transfere controle a outro | atendimento especializado |
| Hierárquico | supervisores coordenam subgrupos | processos grandes e raros |

Uma votação entre agentes não transforma uma informação sem fonte em verdade. Diversidade de respostas precisa ser combinada com evidência e avaliação.

## 14.3 Contratos de comunicação [ESSENCIAL]

Cada troca deve especificar:

- objetivo e escopo;
- schema de entrada e saída;
- identificador de correlação;
- erros possíveis;
- prazo e orçamento;
- origem das evidências;
- permissões concedidas.

Textos livres entre muitos agents tornam o sistema difícil de testar. Contratos estruturados reduzem interpretações diferentes.

## 14.4 Delegação e handoff [IMPORTANTE]

**Delegar** significa solicitar que outro componente execute uma subtarefa e depois receber o resultado. **Handoff** significa transferir a responsabilidade pela continuação da interação.

No handoff, preserve apenas o contexto necessário e informe ao novo agent por que a transferência ocorreu. O usuário deve saber quando a mudança de responsabilidade for relevante.

## 14.5 A2A e MCP [AVANÇADO]

MCP padroniza principalmente a conexão de aplicações de IA a tools e fontes de contexto. Protocolos de comunicação **agent-to-agent (A2A)** tratam da descoberta e colaboração entre agents. Os conceitos podem coexistir: um agent conversa com outro e cada um usa tools expostas por MCP.

O protocolo não substitui arquitetura, autenticação, autorização, observabilidade ou avaliação.

## Atividade prática 14 — Um ou vários agents?

Compare duas arquiteturas para o analisador de tarefas:

- A: um agent com três tools;
- B: supervisor, pesquisador e analista de risco.

Avalie qualidade, latência, custo, permissões, facilidade de teste e pontos de falha. Escolha uma e escreva uma decisão arquitetural de até uma página.

## Perguntas de revisão

**Q70.** Quando separar agentes pode trazer valor real?

**Q71.** Qual é a diferença entre execução paralela e sequencial?

**Q72.** Por que um schema é importante na comunicação entre agents?

**Q73.** Qual é a diferença entre delegação e handoff?

**Q74.** Por que multi-agent não deve ser a escolha padrão?

## Critério de conclusão

- [ ] comparei single-agent e multi-agent;
- [ ] reconheci cinco padrões de orquestração;
- [ ] defini um contrato estruturado;
- [ ] justifiquei a arquitetura escolhida.

---

# Parte VII — Qualidade, observabilidade e segurança

# Módulo 15 — Avaliação de sistemas de IA

## Objetivos

- transformar qualidade em critérios mensuráveis;
- criar casos de teste e baseline;
- avaliar respostas, retrieval, tools e trajetórias de agents.

## 15.1 Por que avaliar [ESSENCIAL]

Uma demonstração bem-sucedida não prova que o sistema funciona. Modelos são probabilísticos, entradas reais variam e componentes externos falham. Uma **eval** é um processo repetível para medir comportamento em um conjunto representativo de casos.

Antes de melhorar o sistema, estabeleça uma **baseline**: versão, configuração, dados, métricas e resultados atuais.

## 15.2 Dataset de avaliação [ESSENCIAL]

O conjunto de avaliação deve conter:

- casos normais;
- casos de borda;
- entradas incompletas ou ambíguas;
- tentativas de abuso;
- diferentes idiomas e tamanhos;
- exemplos em que a resposta correta é admitir ausência de dados.

Cada caso pode ter entrada, evidências, saída esperada, propriedades obrigatórias e gravidade da falha. Separe dados de desenvolvimento e avaliação para reduzir ajuste excessivo ao teste.

## 15.3 O que medir [ESSENCIAL]

Métricas comuns:

- **correção:** a conclusão está certa?
- **completude:** os pontos necessários apareceram?
- **relevância:** a resposta atende à pergunta?
- **groundedness:** afirmações são sustentadas pelas fontes?
- **validade estrutural:** o schema foi respeitado?
- **tool success rate:** a tool correta foi chamada com argumentos válidos?
- **latência e custo:** o resultado cabe no orçamento operacional?
- **segurança:** o sistema resistiu a casos adversariais?

Uma média única pode esconder falhas graves. Separe métricas por categoria e acompanhe os piores casos.

## 15.4 Tipos de avaliador [IMPORTANTE]

**Código determinístico** é adequado para schema, ranges, igualdade, presença de citação e regras objetivas.

**Avaliação humana** é valiosa para utilidade, clareza e casos complexos, mas custa mais e precisa de critérios consistentes.

**LLM-as-a-judge** usa um modelo e uma rubrica para avaliar respostas. Escala melhor, porém pode ter viés de posição, estilo ou preferência pelo próprio modelo. Calibre-o contra avaliações humanas e exija justificativa baseada na rubrica.

## 15.5 Regressão e variabilidade [ESSENCIAL]

Ao mudar prompt, modelo, índice ou tool:

1. mantenha o dataset fixo;
2. execute a baseline e a versão candidata;
3. compare as métricas por categoria;
4. investigue melhorias e regressões;
5. repita casos probabilísticos quando necessário;
6. defina critérios objetivos de aprovação.

Uma mudança só deve ser promovida se os ganhos justificarem as perdas, o custo e o risco.

## 15.6 Avaliação de agents [IMPORTANTE]

Além da resposta final, avalie a trajetória:

- selecionou a tool correta?
- usou argumentos corretos?
- repetiu chamadas desnecessárias?
- respeitou permissões e orçamento?
- recuperou-se de erro transitório?
- encerrou no momento adequado?

Uma resposta aparentemente correta pode ter sido produzida por uma sequência insegura ou cara.

## Atividade prática 15 — Suite de evals

Crie 30 casos para o assistente de tarefas:

- 10 casos normais;
- 5 sem informação suficiente;
- 5 com dados conflitantes;
- 5 com falhas de tool;
- 5 adversariais.

Implemente ao menos cinco verificações determinísticas e uma rubrica humana de 1 a 5. Registre a baseline antes de alterar o prompt.

## Perguntas de revisão

**Q75.** O que é uma baseline?

**Q76.** Por que uma demonstração bem-sucedida não basta?

**Q77.** Quando usar um avaliador determinístico?

**Q78.** Qual é o principal cuidado com LLM-as-a-judge?

**Q79.** Por que separar métricas por categoria?

**Q80.** O que deve ser avaliado em um agent além da resposta final?

## Critério de conclusão

- [ ] criei dataset representativo;
- [ ] defini baseline;
- [ ] combinei testes objetivos e rubrica;
- [ ] medi trajetória de tools;
- [ ] defini aprovação e regressão.

---

# Módulo 16 — Observabilidade

## Objetivos

- diferenciar logs, métricas e traces;
- rastrear uma execução ponta a ponta;
- diagnosticar qualidade, falhas, latência e custo.

## 16.1 Os três sinais [ESSENCIAL]

- **Log:** registro de um evento, como erro de uma tool.
- **Métrica:** valor agregado ao longo do tempo, como latência p95.
- **Trace:** caminho de uma requisição através de modelo, retrieval e tools.

Use um **correlation ID** para ligar os eventos da mesma execução.

## 16.2 O que registrar [ESSENCIAL]

Registros úteis incluem:

- versão do prompt, modelo e parâmetros;
- tempo, tokens e custo de cada chamada;
- consulta e identificadores dos documentos recuperados;
- tools chamadas, duração e estado de sucesso;
- validações e tentativas de retry;
- decisão final e feedback do usuário;
- versão do índice, código e configuração.

Evite registrar segredos, credenciais, dados pessoais ou conteúdo integral sem necessidade e autorização.

## 16.3 Métricas operacionais [IMPORTANTE]

Exemplos:

- taxa de sucesso e erro por tipo;
- latência p50, p95 e p99;
- tempo até o primeiro token;
- tokens e custo por solicitação;
- cache hit rate;
- taxa de schema inválido;
- quantidade de chamadas de tools;
- groundedness e satisfação por versão.

Percentis mostram a experiência dos casos lentos melhor que apenas a média.

## 16.4 Diagnóstico por estágio [ESSENCIAL]

Quando a resposta falhar, localize a etapa:

1. entrada ou instrução;
2. recuperação de contexto;
3. seleção ou execução de tool;
4. geração do modelo;
5. parsing e validação;
6. apresentação ao usuário.

Sem traces, todos esses problemas parecem simplesmente “erro da IA”.

## 16.5 Privacidade e retenção [ESSENCIAL]

Defina quais campos são coletados, por que são necessários, quem pode acessá-los e por quanto tempo permanecem armazenados. Aplique mascaramento ou redação antes do armazenamento. Logs de IA podem conter prompts, documentos recuperados e respostas sensíveis.

## Atividade prática 16 — Trace de uma pergunta

Instrumente ou desenhe um trace contendo:

```text
request → validação → retrieval → geração → validação de saída → response
```

Adicione correlation ID, duração, resultado, tokens e erro por etapa. Crie um painel mínimo com taxa de sucesso, latência p95, custo médio e respostas inválidas.

## Perguntas de revisão

**Q81.** Qual é a diferença entre log, métrica e trace?

**Q82.** Por que usar um correlation ID?

**Q83.** Por que p95 pode ser mais útil que a média?

**Q84.** Quais versões devem ser registradas para reproduzir uma resposta?

**Q85.** Por que não se deve armazenar todos os prompts indiscriminadamente?

## Critério de conclusão

- [ ] rastreei a execução ponta a ponta;
- [ ] defini métricas de qualidade e operação;
- [ ] consigo localizar a etapa de uma falha;
- [ ] defini redação e retenção de dados.

---

# Módulo 17 — Segurança e IA responsável

## Objetivos

- reconhecer ameaças específicas de aplicações com LLM;
- limitar dados e ações pelo princípio do menor privilégio;
- incluir segurança e responsabilidade desde o projeto.

## 17.1 Prompt injection [ESSENCIAL]

**Prompt injection direta** ocorre quando a entrada do usuário tenta substituir as instruções da aplicação. **Prompt injection indireta** aparece dentro de conteúdo externo, como documento, página ou comentário lido pelo sistema.

Separar system prompt e conteúdo não torna o dado externo confiável. Trate documentos recuperados como dados, não como novas instruções. Limite tools e valide ações independentemente do texto gerado.

## 17.2 Vazamento e exfiltração [ESSENCIAL]

O modelo pode receber dados de várias fontes e revelar algo ao usuário errado. Controles necessários:

- autorização antes da recuperação, não depois da resposta;
- filtros de tenant, projeto e identidade;
- minimização e classificação de dados;
- mascaramento de PII e segredos;
- isolamento entre usuários e ambientes;
- auditoria de acesso.

RAG não deve permitir que a busca ignore as permissões da fonte original.

## 17.3 Abuso de tools [ESSENCIAL]

Uma tool transforma texto em ação. A aplicação deve:

- autenticar usuário e serviço;
- autorizar cada operação e recurso;
- validar argumentos contra schema e regras de negócio;
- usar credenciais de menor privilégio;
- pedir confirmação humana para efeitos importantes;
- manter allowlists, rate limits e trilha de auditoria;
- usar idempotência quando houver retry.

Nunca conceda permissão apenas porque o modelo afirmou que a ação é necessária.

## 17.4 Saída insegura [ESSENCIAL]

Texto gerado pode conter HTML, comandos, URLs ou código malicioso. Escape conteúdo conforme o destino, valide URLs, não execute código arbitrário e use sandbox quando execução for realmente necessária. Structured output ajuda no formato, mas não garante que os valores sejam seguros.

## 17.5 Dependências, modelos e servidores MCP [IMPORTANTE]

Modelos, pacotes, índices e servidores MCP fazem parte da cadeia de suprimentos. Verifique origem, permissões, atualização, assinatura quando disponível e comportamento observado. Um servidor MCP pode expor tools poderosas; conectá-lo equivale a ampliar a superfície de ataque.

## 17.6 Threat modeling e red teaming [IMPORTANTE]

Um modelo simples de ameaças pergunta:

1. quais ativos precisam de proteção?
2. quem são os atores e quais acessos possuem?
3. por onde dados e comandos circulam?
4. o que pode dar errado?
5. quais controles previnem, detectam e recuperam?

**Red teaming** testa ativamente abuso, evasão e casos inesperados. Os resultados devem virar controles e casos permanentes de regressão.

## 17.7 IA responsável [ESSENCIAL]

Considere:

- **equidade:** desempenho injustamente diferente entre grupos;
- **privacidade:** coleta e uso proporcionais de dados;
- **transparência:** deixar claro limites e uso de IA;
- **responsabilização:** existir um responsável pelas decisões;
- **confiabilidade:** comportamento seguro sob falhas;
- **supervisão humana:** revisão em decisões de alto impacto.

O nível de controle deve acompanhar o impacto. Um resumo interno e uma decisão médica não aceitam o mesmo risco.

## Atividade prática 17 — Threat model

Modele ameaças do assistente de tarefas. Inclua ao menos:

- comentário com prompt injection;
- tentativa de ler projeto sem permissão;
- vazamento de segredo em log;
- tool de escrita chamada indevidamente;
- retry duplicando uma ação;
- resposta com link perigoso.

Para cada ameaça, registre impacto, probabilidade, prevenção, detecção e resposta.

## Perguntas de revisão

**Q86.** Qual é a diferença entre prompt injection direta e indireta?

**Q87.** Por que instruções no system prompt não bastam como controle de segurança?

**Q88.** Em que momento a autorização de documentos deve ocorrer?

**Q89.** O que significa menor privilégio para uma tool?

**Q90.** Por que JSON válido ainda pode ser inseguro?

**Q91.** O que deve acontecer com um caso descoberto em red teaming?

**Q92.** Por que a supervisão humana depende do impacto da decisão?

## Critério de conclusão

- [ ] modelei ameaças e ativos;
- [ ] tratei conteúdo externo como não confiável;
- [ ] apliquei autenticação e autorização fora do modelo;
- [ ] defini aprovação para ações sensíveis;
- [ ] converti riscos em testes.

---

# Parte VIII — Adaptação de modelos e produção

# Módulo 18 — Fine-tuning e pós-treinamento

## Objetivos

- decidir entre prompt, RAG e fine-tuning;
- entender SFT, PEFT, LoRA e QLoRA em nível profissional;
- preparar dados e avaliações antes de treinar.

## 18.1 O que fine-tuning altera [ESSENCIAL]

**Fine-tuning** continua o treinamento de um modelo existente com exemplos selecionados para adaptar seu comportamento. Durante esse processo, pesos do modelo ou parâmetros adicionais treináveis são ajustados.

Ele pode ajudar a ensinar:

- formato e estilo recorrentes;
- classificação especializada;
- uso consistente de tools;
- padrões próprios de uma tarefa;
- comportamento difícil de obter apenas com instruções.

Fine-tuning não é a melhor forma de inserir fatos que mudam frequentemente. Para conhecimento atual, privado e citável, RAG costuma ser mais adequado.

## 18.2 Prompt, RAG ou fine-tuning? [ESSENCIAL]

| Necessidade | Primeira opção |
|---|---|
| melhorar instrução, tom ou formato simples | prompt e structured output |
| fornecer fatos atuais ou documentos privados | RAG ou tools |
| ensinar comportamento repetido com muitos exemplos | fine-tuning |
| realizar ação em sistema externo | tool calling |
| combinar fatos atuais com comportamento especializado | RAG + fine-tuning, somente se medido |

A ordem prática costuma ser: baseline → prompt → contexto/RAG → avaliação → fine-tuning se a lacuna permanecer.

## 18.3 Supervised Fine-Tuning [IMPORTANTE]

No **SFT**, o treinamento usa pares de entrada e resposta desejada. O modelo aprende a aumentar a probabilidade das respostas demonstradas.

Qualidade, cobertura e consistência dos exemplos importam mais que simplesmente acumular volume. Exemplos contraditórios ensinam comportamento contraditório.

## 18.4 Preparação dos dados [ESSENCIAL]

Um processo mínimo inclui:

1. definir o comportamento-alvo;
2. coletar exemplos autorizados;
3. remover duplicatas, segredos e PII desnecessária;
4. padronizar o formato de conversa;
5. revisar qualidade e equilíbrio;
6. separar treino, validação e teste;
7. versionar dataset e critérios de inclusão.

Evite **data leakage**: exemplos do teste não podem aparecer no treino. Caso contrário, a métrica pode medir memorização em vez de generalização.

## 18.5 Hiperparâmetros e overfitting [IMPORTANTE]

- **learning rate:** tamanho dos ajustes feitos durante otimização;
- **batch size:** número de exemplos processados antes de uma atualização;
- **epoch:** uma passagem completa pelo conjunto de treino;
- **loss:** medida usada para otimizar a diferença entre previsão e alvo;
- **overfitting:** bom desempenho nos exemplos de treino, mas pior generalização.

Mais epochs não significam automaticamente melhor modelo. Acompanhe treino e validação e compare sempre com a baseline.

## 18.6 PEFT, LoRA e QLoRA [IMPORTANTE]

**PEFT** reúne técnicas que ajustam uma pequena parte dos parâmetros, reduzindo memória e custo. **LoRA** congela os pesos principais e treina matrizes menores de adaptação. **QLoRA** combina LoRA com um modelo base quantizado durante o ajuste para economizar ainda mais memória.

**Quantização** reduz a precisão numérica usada para representar pesos. Ela pode facilitar inferência local, mas pode causar perda de qualidade. Quantização e fine-tuning são conceitos diferentes, embora possam ser combinados.

## 18.7 Preferências e reinforcement learning [AVANÇADO]

Após SFT, modelos podem ser alinhados com preferências humanas ou sintéticas. **RLHF** usa feedback humano e reinforcement learning; **DPO** otimiza diretamente pares de resposta preferida e rejeitada. Há outras técnicas de pós-treinamento, mas todas dependem de dados, objetivo e avaliação confiáveis.

Esse nível não é requisito para começar a construir aplicações. O importante é reconhecer o problema que cada técnica tenta resolver.

## 18.8 Implantação e rollback [ESSENCIAL]

Um modelo adaptado precisa de:

- versão do modelo base, adapter e dataset;
- suite de evals comparável;
- critérios de aprovação;
- implantação gradual;
- monitoramento por versão;
- capacidade de rollback;
- revisão de licença e privacidade.

Treinar com sucesso não demonstra que o modelo é melhor em produção.

## Atividade prática 18 — Decisão de adaptação

Sem precisar treinar localmente:

1. escolha um comportamento do assistente difícil de estabilizar;
2. crie uma baseline de 20 casos;
3. tente resolver com prompt e schema;
4. descreva por que RAG ajudaria ou não;
5. produza 20 exemplos de SFT revisados;
6. separe treino, validação e teste;
7. defina métricas e critério de rollback.

Treinamento real pode ser feito depois em ambiente gratuito ou pago com GPU, respeitando limites e privacidade. O desenho correto do experimento vem antes da infraestrutura.

## Perguntas de revisão

**Q93.** O que é alterado durante fine-tuning?

**Q94.** Para fatos que mudam toda semana, por que RAG costuma ser melhor?

**Q95.** O que é SFT?

**Q96.** Por que separar treino, validação e teste?

**Q97.** O que caracteriza overfitting?

**Q98.** Qual é a ideia central de LoRA?

**Q99.** Qual é a diferença entre quantização e fine-tuning?

**Q100.** Por que um fine-tuning precisa ser comparado com uma baseline?

## Critério de conclusão

- [ ] escolhi corretamente entre prompt, RAG, tools e fine-tuning;
- [ ] preparei e separei dados;
- [ ] entendi SFT, PEFT, LoRA e QLoRA;
- [ ] defini evals, implantação e rollback.

---

# Módulo 19 — Serving, LLMOps e produção

## Objetivos

- entender os componentes que servem um modelo em produção;
- medir latência, capacidade, custo e confiabilidade;
- versionar e implantar mudanças com segurança.

## 19.1 Serving [ESSENCIAL]

**Serving** é disponibilizar inferência por uma interface utilizável, normalmente uma API. O modelo pode estar:

- em uma API gerenciada;
- em infraestrutura de nuvem própria;
- em servidor local;
- no dispositivo, quando tamanho e hardware permitem.

Open-weight dá mais controle, mas transfere para a equipe custos de hardware, serving, atualização, observabilidade e segurança.

## 19.2 Arquitetura de produção [ESSENCIAL]

Uma arquitetura comum contém:

```text
cliente
  ↓
API/gateway → autenticação → orquestrador
                               ├─ modelo
                               ├─ busca/índice vetorial
                               ├─ tools e sistemas internos
                               └─ cache/fila
                                    ↓
                           logs, métricas e traces
```

Componentes devem ter responsabilidades e contratos claros. O LLM não deve substituir regras de negócio determinísticas.

## 19.3 Capacidade e desempenho [IMPORTANTE]

- **latência:** tempo total da requisição;
- **TTFT:** tempo até o primeiro token;
- **throughput:** volume processado por unidade de tempo;
- **concorrência:** solicitações simultâneas;
- **p50/p95/p99:** percentis da distribuição de latência;
- **tokens por segundo:** velocidade de geração.

Modelos maiores costumam exigir mais memória e computação. Batching, cache, modelos menores, quantização e roteamento podem melhorar custo e desempenho, com possíveis trade-offs de qualidade.

## 19.4 Contêineres e escalabilidade [IMPORTANTE]

Contêineres tornam dependências e configuração reproduzíveis. Escalabilidade exige limites de CPU/GPU/memória, health checks, filas ou backpressure e políticas de autoscaling. Em GPU, memória disponível e concorrência são restrições centrais.

Uma aplicação pequena não precisa começar com uma plataforma complexa. Comece medindo a carga real.

## 19.5 CI/CD e versionamento [ESSENCIAL]

Versione em conjunto:

- código e dependências;
- prompt e schemas;
- modelo e parâmetros;
- dataset de eval;
- embedding model e índice;
- configuração de tools;
- políticas de segurança.

O pipeline deve executar testes convencionais, evals de IA e verificações de segurança antes de promover uma versão. Use implantação gradual e rollback.

## 19.6 Configuração, identidade e rede [ESSENCIAL]

Segredos ficam em armazenamento próprio, não no código ou repositório. Prefira identidade gerenciada quando a plataforma oferecer. Em ambientes sensíveis, use rede privada, políticas de saída, RBAC e auditoria. Separe desenvolvimento, teste e produção.

## 19.7 Custo e confiabilidade [ESSENCIAL]

Calcule custo por fluxo, não apenas por chamada do modelo:

```text
custo = geração + embeddings + busca + tools + armazenamento + observabilidade + infraestrutura
```

Defina SLOs como disponibilidade, latência e taxa de respostas válidas. Planeje falhas de provedor, rate limit, indisponibilidade de índice e degradação de tools.

## Atividade prática 19 — Plano de produção

Crie o diagrama de implantação do assistente e documente:

1. ambientes;
2. identidade e segredos;
3. dependências externas;
4. limites e timeouts;
5. métricas e alertas;
6. estimativa de custo para 100 e 10.000 análises por mês;
7. estratégia de implantação e rollback;
8. comportamento quando modelo, busca ou Azure DevOps estiver indisponível.

## Perguntas de revisão

**Q101.** O que é model serving?

**Q102.** Qual é a diferença entre latência e throughput?

**Q103.** Por que versionar prompt, modelo e índice juntos?

**Q104.** O que quantização pode oferecer e qual é o risco?

**Q105.** Por que o custo deve ser calculado por fluxo?

**Q106.** Quais controles ajudam a proteger credenciais em produção?

## Critério de conclusão

- [ ] desenhei a arquitetura de serving;
- [ ] defini métricas de capacidade;
- [ ] planejei CI/CD e rollback;
- [ ] protegi identidade, configuração e rede;
- [ ] estimei custo por fluxo.

---

# Módulo 20 — Desenvolvimento de software assistido por IA

## Objetivos

- usar assistentes de código com escopo e verificação;
- estruturar contexto reutilizável do repositório;
- preservar responsabilidade humana sobre as mudanças.

## 20.1 Contexto do repositório [ESSENCIAL]

Um assistente trabalha melhor quando recebe instruções verificáveis sobre arquitetura, comandos, padrões e restrições. Arquivos de orientação do repositório podem informar:

- como compilar e testar;
- estrutura e convenções;
- arquivos que não devem ser alterados;
- requisitos de segurança;
- definição de pronto.

Essas instruções precisam ser curtas, atualizadas e compatíveis com a automação real.

## 20.2 Plano, execução e checkpoints [ESSENCIAL]

Para mudanças maiores:

1. inspecione o código e os testes;
2. declare escopo e critérios de aceite;
3. divida em passos verificáveis;
4. faça alterações pequenas;
5. execute testes e revise o diff;
6. pare diante de decisão de produto ou ação destrutiva não autorizada.

Um plano não substitui feedback. Ele permite detectar cedo quando a implementação se afastou do objetivo.

## 20.3 Tools, automações e hooks [IMPORTANTE]

Ferramentas podem ler arquivos, editar código, executar testes e consultar sistemas. Hooks podem executar verificações em eventos definidos, como antes de um commit. Toda automação deve ter escopo, timeout, saída observável e permissões mínimas.

Nunca suponha que um arquivo `.env` será ignorado por todas as ferramentas apenas por estar no `.gitignore`. Configure permissões e evite que segredos entrem no contexto.

## 20.4 Paralelismo e agentes especializados [AVANÇADO]

Subtarefas independentes podem ser analisadas em paralelo, por exemplo segurança, testes e documentação. Isso exige fronteiras de arquivos e consolidação cuidadosa. Para uma mudança pequena e acoplada, um único fluxo costuma ser mais claro.

## 20.5 Revisão da saída [ESSENCIAL]

Código gerado deve passar pelos mesmos controles que código humano:

- compilação e testes;
- análise estática e dependências;
- revisão de segurança;
- verificação de comportamento e performance;
- revisão humana proporcional ao risco.

O assistente acelera produção de hipóteses e alterações; ele não assume a responsabilidade técnica ou de negócio.

## Atividade prática 20 — Trabalho orientado por contrato

Escolha uma melhoria do `HelloLlm` e escreva antes:

- objetivo;
- fora de escopo;
- arquivos prováveis;
- critérios de aceite;
- comandos de validação;
- riscos e rollback.

Peça a um assistente para implementar, revise cada mudança e compare o resultado com o contrato original.

## Perguntas de revisão

**Q107.** Que informações tornam o contexto do repositório útil?

**Q108.** Por que dividir uma mudança em checkpoints?

**Q109.** Por que `.gitignore` não é um controle suficiente para segredos?

**Q110.** Quando paralelizar tarefas de desenvolvimento?

**Q111.** Quem continua responsável por código produzido com IA?

## Critério de conclusão

- [ ] forneci contexto verificável;
- [ ] trabalhei com critérios de aceite;
- [ ] usei permissões mínimas;
- [ ] revisei diff, testes e riscos;
- [ ] mantive responsabilidade humana.

---

# Parte IX — Projeto de portfólio

# Módulo 21 — Developer Work Assistant

## Objetivo do projeto

Construir um assistente que analise uma tarefa de desenvolvimento a partir do Azure DevOps e produza um relatório sustentado por evidências, com riscos, dúvidas e rastreabilidade.

O projeto deve demonstrar integração de software e IA. Não precisa usar toda técnica do guia. Complexidade só entra quando resolve um problema medido.

## 21.1 Escopo mínimo

Entrada:

- organização, projeto e ID do work item;
- identidade autenticada do usuário.

Fontes:

- título, descrição e critérios de aceite;
- comentários;
- relações diretas relevantes;
- documentação autorizada opcional.

Saída sugerida:

```json
{
  "summary": "string não vazia",
  "risks": [
    {
      "description": "string",
      "severity": "low | medium | high",
      "score": 0,
      "impact": "string",
      "mitigation": "string",
      "effort": "low | medium | high",
      "evidenceIds": ["string"]
    }
  ],
  "questions": ["string"]
}
```

Se não houver dúvida sustentada pelos dados, `questions` deve ser `[]`. Se dados essenciais estiverem ausentes, o sistema deve parar a análise e informar objetivamente o que falta.

## 21.2 Fases

### Fase A — Baseline

- chamada simples ao modelo;
- prompt versionado;
- schema e validação;
- erros, timeout e retry;
- 20 casos de avaliação.

### Fase B — Contexto e tools

- tool somente leitura para Azure DevOps;
- autenticação e autorização;
- comentários e relações com limite de profundidade;
- evidências identificadas;
- logs sem segredos.

### Fase C — RAG opcional

- documentação interna pequena;
- chunking versionado;
- filtros de permissão;
- busca híbrida;
- citações e avaliação de retrieval.

### Fase D — Qualidade e segurança

- dataset com casos normais, incompletos e adversariais;
- métricas de resposta e trajetória;
- threat model;
- proteção contra prompt injection indireta;
- painel de latência, custo e falhas.

### Fase E — Entrega

- contêiner e configuração por ambiente;
- pipeline de testes e evals;
- documentação de arquitetura;
- demonstração reproduzível;
- plano de implantação e rollback.

## 21.3 Critérios de aceite

- saída sempre passa pelo schema ou retorna erro controlado;
- nenhuma afirmação de risco importante fica sem evidência;
- ausência de dados nunca é preenchida por invenção;
- usuário sem acesso não recupera documento;
- ações são somente leitura no escopo inicial;
- execução respeita limites de tempo, etapas e custo;
- versões podem ser comparadas por evals;
- logs permitem localizar a etapa da falha;
- segredos não entram no código, prompt ou log;
- documentação permite que outra pessoa execute o projeto.

## 21.4 Entregáveis para o portfólio

- repositório organizado e README;
- diagrama de arquitetura;
- decisão entre workflow e agent;
- schema de entrada e saída;
- coleção de casos de avaliação e resultados;
- threat model;
- relatório de custos e trade-offs;
- vídeo ou roteiro de demonstração;
- retrospectiva: erros encontrados e decisões tomadas.

## 21.5 Como descrever profissionalmente

Em currículo ou entrevista, prefira evidências:

> Desenvolvi um assistente de análise de work items com C#, integração autenticada ao Azure DevOps, saída validada por JSON Schema, retrieval com controle de acesso e suite de evals. Reduzi respostas inválidas de X% para Y% e mantive latência p95 abaixo de Z segundos no conjunto testado.

Substitua X, Y e Z por medidas reais. Não declare ganho que não foi medido.

## Checklist final do projeto

- [ ] problema e usuários definidos;
- [ ] arquitetura proporcional ao problema;
- [ ] baseline e critérios mensuráveis;
- [ ] integração segura;
- [ ] structured output validado;
- [ ] ausência de dados tratada;
- [ ] RAG avaliado separadamente, se usado;
- [ ] agent com limites, se usado;
- [ ] segurança testada;
- [ ] observabilidade implementada;
- [ ] custo estimado;
- [ ] documentação e demonstração concluídas.

---

# Parte X — Material de consulta

# Glossário essencial de AI Engineering

**A2A (Agent-to-Agent):** comunicação padronizada entre agents capazes de descobrir competências, delegar e trocar resultados.

**Agent:** sistema que usa um modelo para decidir e executar passos em direção a um objetivo, dentro de ferramentas e limites definidos.

**Agent loop:** ciclo de observar o estado, decidir, agir, receber o resultado e avaliar se deve continuar.

**ANN (Approximate Nearest Neighbors):** família de métodos que encontra vetores próximos rapidamente sem comparar exaustivamente todos os itens.

**API:** contrato pelo qual softwares trocam solicitações e respostas.

**Attention:** mecanismo que calcula quanto diferentes posições da sequência contribuem para a representação produzida em uma etapa.

**Autenticação:** verificação de quem é a identidade.

**Autorização:** verificação do que uma identidade pode fazer ou acessar.

**Backoff:** aumento progressivo do intervalo entre novas tentativas após falhas transitórias.

**Backpropagation:** cálculo de gradientes que mostra como parâmetros contribuíram para o erro durante o treinamento.

**Baseline:** resultado de referência usado para comparar uma mudança.

**Batch:** conjunto de exemplos processados antes de uma atualização de parâmetros ou grupo de requisições processado em conjunto, conforme o contexto.

**BM25:** função clássica de ranking lexical que considera ocorrência e raridade de termos.

**Cache:** armazenamento temporário de resultados reutilizáveis para reduzir latência e custo.

**Chain ou prompt chaining:** divisão de uma tarefa em chamadas conectadas, com saídas intermediárias controladas.

**Chunk:** trecho de um documento usado como unidade de indexação e recuperação.

**Chunking:** estratégia de dividir documentos em chunks, podendo incluir sobreposição e metadados.

**Constrained decoding:** restrição aplicada durante a geração para permitir apenas tokens compatíveis com uma gramática ou schema.

**Context engineering:** seleção, organização e manutenção das informações e instruções disponíveis ao modelo em cada etapa.

**Context window:** limite de tokens que o modelo consegue considerar em uma chamada, incluindo entrada e saída conforme a API.

**Correlation ID:** identificador que liga eventos e etapas pertencentes à mesma solicitação.

**Cosine similarity:** medida do ângulo entre vetores, muito usada para estimar proximidade semântica.

**Dataset:** coleção organizada de exemplos e atributos usada para treino, validação ou avaliação.

**Deep Learning:** subárea de Machine Learning baseada em redes neurais profundas.

**Dimensionalidade:** quantidade de valores que compõem um vetor de embedding.

**DPO (Direct Preference Optimization):** técnica que ajusta o modelo a partir de pares de respostas preferidas e rejeitadas.

**Embedding:** representação numérica aprendida de um item. Em aplicações, costuma representar semanticamente textos para comparação e busca.

**Epoch:** uma passagem completa pelo conjunto de treinamento.

**Eval:** procedimento reproduzível que mede o comportamento de um sistema de IA sobre casos definidos.

**Few-shot:** prompt que inclui alguns exemplos para demonstrar a tarefa.

**Fine-tuning:** continuação do treinamento de um modelo existente para adaptar seu comportamento.

**Foundation model:** modelo amplo capaz de servir de base para várias tarefas e adaptações.

**Function calling:** nome usado por algumas APIs para o mecanismo de o modelo solicitar uma função estruturada; é uma forma de tool calling.

**Golden set:** conjunto de casos cuidadosamente revisados usado como referência de avaliação.

**Gradient:** indicação matemática da direção e intensidade em que um parâmetro afeta a loss.

**Groundedness:** grau em que as afirmações da resposta são sustentadas pelo contexto ou pelas fontes fornecidas.

**Guardrail:** controle que restringe, valida ou monitora entradas, saídas e ações.

**Hallucination:** conteúdo apresentado como resposta sem sustentação adequada nos dados disponíveis ou na realidade verificável.

**Handoff:** transferência da responsabilidade de uma conversa ou tarefa para outro agent ou sistema.

**HNSW:** estrutura de grafo usada em busca vetorial aproximada eficiente.

**Human-in-the-loop:** participação humana em revisão, aprovação ou correção de uma decisão automatizada.

**Hybrid Search:** combinação de busca lexical e vetorial, frequentemente seguida de fusão dos rankings.

**Idempotência:** propriedade pela qual repetir a mesma operação não produz efeitos adicionais indevidos.

**Inference:** uso dos parâmetros treinados para gerar uma previsão ou resposta, normalmente sem alterá-los.

**Jitter:** variação aleatória adicionada ao backoff para evitar que muitos clientes tentem novamente ao mesmo tempo.

**JSON Schema:** linguagem declarativa para descrever estrutura, tipos e restrições de documentos JSON.

**Latency:** tempo decorrido para concluir uma operação.

**Learning rate:** hiperparâmetro que controla o tamanho das atualizações durante treinamento.

**LLM (Large Language Model):** modelo de linguagem de grande escala, geralmente baseado em Deep Learning e Transformer.

**LLM-as-a-judge:** uso de um LLM, guiado por uma rubrica, para avaliar outra saída.

**LLMOps:** práticas para versionar, avaliar, implantar, observar e governar sistemas baseados em LLMs.

**LoRA:** técnica PEFT que treina matrizes menores de adaptação enquanto mantém os pesos principais congelados.

**Loss:** função que mede o erro usado para otimizar o modelo durante treinamento.

**Machine Learning:** métodos em que padrões são ajustados a partir de dados para produzir previsões ou decisões.

**Managed identity:** identidade administrada pela plataforma, usada para acessar recursos sem distribuir segredos manualmente.

**Memory:** mecanismo externo ou estado selecionado que preserva informações úteis além da entrada imediata.

**Metadata filtering:** restrição da busca por atributos como projeto, data, idioma, tipo ou permissão.

**Model routing:** escolha de modelo ou caminho de execução conforme custo, risco, disponibilidade ou dificuldade.

**MCP (Model Context Protocol):** protocolo para conectar aplicações de IA a tools, resources e prompts por interfaces padronizadas.

**MRR (Mean Reciprocal Rank):** média do inverso da posição do primeiro resultado relevante.

**Multi-agent:** arquitetura na qual mais de um agent especializado colabora em um processo.

**nDCG:** métrica de ranking que considera relevância graduada e dá mais valor às primeiras posições.

**Open-weight:** modelo cujos pesos são disponibilizados sob uma licença; não implica abertura de todo o processo ou código.

**Overfitting:** adaptação excessiva aos dados de treino, com perda de generalização.

**Parâmetro:** valor aprendido pelo modelo durante treinamento; pesos são o principal exemplo.

**PEFT:** conjunto de técnicas de fine-tuning eficiente que treina apenas uma pequena parcela dos parâmetros.

**PII:** informação capaz de identificar uma pessoa, direta ou indiretamente.

**Precision@k:** proporção dos primeiros `k` resultados recuperados que é relevante.

**Prompt:** conteúdo enviado ao modelo para estabelecer instruções, contexto, exemplos e solicitação.

**Prompt injection:** tentativa de conteúdo não confiável alterar instruções ou provocar ações indevidas no sistema.

**Prompt template:** estrutura reutilizável com partes fixas e campos variáveis preenchidos de forma controlada.

**QLoRA:** ajuste LoRA sobre um modelo base quantizado para reduzir consumo de memória.

**Quantização:** representação de pesos com menor precisão numérica para reduzir memória e, em alguns casos, acelerar inferência.

**RAG (Retrieval-Augmented Generation):** recuperação de fontes externas relevantes antes da geração para fundamentar a resposta.

**Rate limit:** restrição de volume de solicitações ou tokens por intervalo de tempo.

**Recall@k:** proporção de todos os itens relevantes que apareceu nos primeiros `k` resultados.

**Reranker:** componente que reordena um conjunto inicial de resultados usando uma análise mais precisa e normalmente mais cara.

**Retry:** nova tentativa após uma falha considerada transitória.

**RRF (Reciprocal Rank Fusion):** técnica que combina rankings atribuindo mais peso a itens bem posicionados em cada lista.

**RLHF:** pós-treinamento que utiliza feedback humano e reinforcement learning para alinhar respostas a preferências.

**Schema:** contrato que define campos, tipos e restrições de uma estrutura de dados.

**Seed:** valor que pode controlar parte da aleatoriedade; não garante repetibilidade absoluta em toda infraestrutura.

**Self-attention:** attention entre posições de uma mesma sequência.

**Semantic Search:** busca baseada em proximidade de significado representada por embeddings.

**SFT (Supervised Fine-Tuning):** fine-tuning supervisionado com exemplos de entrada e resposta desejada.

**Stop condition:** condição que encerra geração ou execução de um agent.

**Streaming:** entrega incremental da saída à medida que ela é gerada.

**Structured output:** saída produzida segundo uma estrutura definida para consumo por software.

**Temperature:** parâmetro que modifica a distribuição de probabilidades na amostragem; em geral, valores maiores aumentam diversidade.

**Token:** unidade produzida pelo tokenizer; pode ser palavra, parte de palavra, pontuação, espaço ou outro fragmento.

**Tokenizer:** algoritmo e vocabulário que convertem conteúdo em tokens e tokens em conteúdo.

**Tool calling:** mecanismo no qual o modelo solicita uma ação estruturada e a aplicação decide validá-la e executá-la.

**Top-k de geração:** restringe a amostragem aos `k` tokens mais prováveis.

**Top-k de retrieval:** quantidade de resultados retornados pela busca; é conceito diferente de top-k de geração.

**Top-p:** amostragem a partir do menor conjunto de tokens cuja probabilidade acumulada alcança `p`.

**Trace:** registro correlacionado da trajetória de uma solicitação pelos componentes do sistema.

**Transformer:** arquitetura neural baseada em attention, blocos de transformação e processamento de sequências.

**TTFT (Time to First Token):** tempo entre enviar a solicitação e receber o primeiro token da geração.

**Vector:** lista ordenada de números que representa características em um espaço matemático.

**Vector database:** sistema especializado em armazenar vetores e executar busca por similaridade com metadados.

**Workflow:** sequência de etapas definida pela aplicação, mesmo que algumas etapas usem modelos probabilísticos.

**Zero-shot:** solicitação sem exemplos demonstrativos no prompt.

---

# Folhas de atividade para impressão

Estas folhas podem ser copiadas para cada experimento. O objetivo é transformar estudo em evidência e evitar mudanças baseadas apenas em impressão subjetiva.

## Folha A — Ficha de conceito

```text
Conceito:
Definição com minhas palavras:

Qual problema resolve:

Exemplo:

Contraexemplo ou confusão comum:

Como eu explicaria para outra pessoa:

O que ainda preciso pesquisar:
```

## Folha B — Experimento de prompt ou RAG

```text
Hipótese:
Baseline e versão:
Mudança única aplicada:
Dataset utilizado:
Métricas escolhidas:

Resultado anterior:
Resultado novo:
Regressões:
Custo e latência:

Decisão: manter / reverter / investigar
Justificativa:
```

## Folha C — Caso de avaliação

```text
ID:
Categoria:
Entrada:
Contexto autorizado:
Saída ou propriedades esperadas:
Comportamento proibido:
Gravidade se falhar:
Resultado obtido:
Aprovado?:
Observações:
```

## Folha D — Decisão arquitetural

```text
Problema:
Restrições:
Opções consideradas:

Decisão:
Por que foi escolhida:
Consequências positivas:
Riscos e consequências negativas:
Como medir se funcionou:
Quando reavaliar:
```

## Folha E — Threat model

| Ativo | Ameaça | Probabilidade | Impacto | Prevenção | Detecção | Resposta |
|---|---|---:|---:|---|---|---|
| | | | | | | |
| | | | | | | |
| | | | | | | |

## Folha F — Sessão de estudo

```text
Data:
Módulo:
Tempo planejado / realizado:

Três ideias que aprendi:
1.
2.
3.

Uma dúvida:

Atividade executada:
Evidência produzida:

Revisar novamente em:
```

---

# Parte XI — Gabarito

Consulte esta seção somente depois de responder. As frases abaixo são respostas mínimas; respostas equivalentes com justificativa também são válidas.

## Módulo 1

**A1.** IA é o campo amplo; ML é uma subárea que aprende com dados; Deep Learning é ML com redes neurais profundas; LLMs são modelos de Deep Learning voltados à linguagem.

**A2.** No treinamento, parâmetros são ajustados para reduzir a loss. Na inferência, são usados e normalmente permanecem fixos.

**A3.** Porque a condição foi programada explicitamente e não aprendida a partir de dados.

**A4.** O modelo produz inferências; a aplicação acrescenta interface, regras, contexto, segurança, tools e validação.

**A5.** Pesos acessíveis não garantem abertura do código, dados, processo nem liberdade ampla de uso; tudo depende da licença.

## Módulo 2

**A6.** Porque token é unidade do tokenizer, não sinônimo de palavra; uma palavra pode virar um ou vários tokens.

**A7.** Embedding representa itens como vetores; attention calcula relações e contribuições entre posições durante o processamento.

**A8.** É a arquitetura usada tanto no treinamento quanto na inferência; o que muda é o objetivo da execução.

**A9.** Não. Ela tende a reduzir diversidade, mas não corrige conhecimento falso, contexto ruim ou raciocínio inadequado.

**A10.** Instruções, mensagens, exemplos, documentos, resultados de tools e tokens de saída, conforme a forma de contagem da API.

**A11.** Pela geração de um token especial de fim ou por limites e condições de parada impostos pela aplicação/API.

**A12.** Exemplos válidos: fornecer fontes relevantes, exigir evidências, permitir admitir ausência, usar tools/RAG e validar fatos importantes.

## Módulo 3

**A13.** System Prompt define comportamento e regras gerais da aplicação; User Prompt expressa a solicitação do usuário dentro desses limites.

**A14.** Ajuda quando exemplos esclarecem formato ou decisão; pode introduzir viés, contradição e maior consumo de contexto.

**A15.** A aplicação deve preencher e validar as variáveis; o usuário fornece dados, mas não deve montar livremente as partes confiáveis do template.

**A16.** Decomposição divide o problema; chaining executa etapas em chamadas conectadas, passando saídas controladas.

**A17.** Para atribuir a mudança de resultado a uma causa e preservar um experimento interpretável.

## Módulo 4

**A18.** Não. Inclui instruções, histórico selecionado, exemplos, conteúdo recuperado, tools e outros dados enviados na chamada.

**A19.** A janela é o limite temporário da chamada; memória é um mecanismo externo ou estado selecionado que pode persistir informações.

**A20.** É remover conteúdo pouco útil para caber no orçamento; o risco é eliminar uma evidência necessária.

**A21.** Origem, ordem, identidade, permissões e relações necessárias entre os trechos reunidos.

**A22.** Porque disponibilidade no sistema não significa seleção para aquela chamada; orçamento, relevância e autorização limitam o que entra.

## Módulo 5

**A23.** Não. Ele também precisa corresponder ao schema e às regras de negócio.

**A24.** Impede propriedades não declaradas no objeto quando configurado como `false`.

**A25.** Constrained decoding restringe tokens durante geração; validação verifica depois se estrutura e valores são aceitáveis.

**A26.** Não. Schema garante forma e restrições declaradas, não a verdade do conteúdo.

**A27.** O DTO expressa tipos no código, mas não confirma autorização, existência, consistência semântica ou regras do domínio.

## Módulo 6

**A28.** Timeout limita duração; limite de saída restringe quantos tokens podem ser gerados.

**A29.** `401` normalmente indica credencial ausente ou inválida; repetir sem corrigi-la tende a produzir a mesma falha.

**A30.** Reduz a sincronização de retries de muitos clientes, evitando novas rajadas simultâneas.

**A31.** Não. Streaming melhora o tempo percebido e o TTFT, mas a geração total pode demorar o mesmo ou mais.

**A32.** Para impedir que resultado de uma identidade ou escopo seja entregue a outro usuário sem permissão.

## Módulo 7

**A33.** A aplicação executa. O modelo apenas propõe a tool e seus argumentos.

**A34.** Porque a saída do modelo é não confiável e pode conter tipos, valores, recursos ou ações inválidos.

**A35.** Cobrança duplicada; use idempotência, verificação do resultado anterior e política adequada de retry.

**A36.** Finalidade, quando usar, parâmetros, restrições, efeitos colaterais e formato do resultado.

**A37.** Seleção correta, argumentos válidos, taxa de sucesso, chamadas desnecessárias, latência, custo e segurança.

## Módulo 8

**A38.** Padroniza como aplicações de IA descobrem e usam tools, resources e prompts oferecidos por servidores.

**A39.** Não. MCP pode expor a tool; o modelo ainda pode solicitá-la por um mecanismo de tool calling.

**A40.** Quando existe uma integração pequena, estável, controlada por uma única aplicação e sem necessidade de descoberta padronizada.

**A41.** Tool representa uma operação chamável; resource fornece conteúdo ou dados endereçáveis para contexto.

**A42.** Porque ele pode acessar dados ou executar ações com as permissões concedidas e faz parte da cadeia de confiança.

## Módulo 9

**A43.** Porque embeddings podem posicionar expressões de significado semelhante próximas no espaço vetorial, mesmo sem palavras idênticas.

**A44.** Não. Qualidade depende do treinamento, domínio, dados e avaliação; mais dimensões também aumentam armazenamento e cálculo.

**A45.** Vetores de modelos diferentes não são diretamente comparáveis; normalmente é preciso gerar novamente os embeddings do índice.

**A46.** Não. Ele pode preservar sinais sensíveis e ser ligado ao texto ou sofrer ataques; continua exigindo proteção.

**A47.** Porque correspondência lexical preserva identificadores, números e grafias exatas que a similaridade semântica pode diluir.

## Módulo 10

**A48.** Ganha velocidade e escala ao custo de poder não encontrar o vizinho exato.

**A49.** Aumenta chance de recuperar evidência, mas também ruído, tokens, latência e custo de reranking.

**A50.** Quando acesso, tenant, projeto, data, idioma ou tipo precisam restringir quais documentos podem competir no ranking.

**A51.** Busca lexical pode ser superior para códigos, nomes e frases exatas; resultados dependem da consulta e do corpus.

**A52.** Não corrige documento relevante ausente do conjunto inicial nem falha de permissão ou ingestão.

## Módulo 11

**A53.** Não. RAG acrescenta contexto na inferência sem alterar os pesos do LLM.

**A54.** Pode exceder a janela, elevar custo e latência e diluir as evidências úteis em conteúdo irrelevante.

**A55.** Chunks pequenos são precisos, mas podem perder contexto; grandes preservam contexto, mas adicionam ruído e custo.

**A56.** Preserva informação nas fronteiras; custa armazenamento e pode criar resultados redundantes.

**A57.** Não. É necessário verificar se a fonte realmente sustenta a afirmação e se a associação foi feita corretamente.

**A58.** Inspecione separadamente se a evidência correta apareceu nos resultados e se a resposta utilizou fielmente essa evidência.

## Módulo 12

**A59.** Porque o gerador ainda pode ignorar, interpretar mal ou ser prejudicado por contexto adicional e ruído.

**A60.** Context relevance mede se o contexto recuperado atende à pergunta; groundedness mede se a resposta é sustentada por esse contexto.

**A61.** Impede identificar qual mudança causou ganho ou regressão.

**A62.** Quando uma recuperação fixa já resolve o problema e as decisões extras só aumentam custo, latência e superfície de falha.

**A63.** A posição do primeiro resultado relevante, recompensando-o mais quanto mais cedo aparece.

## Módulo 13

**A64.** O agent mantém estado e pode decidir, agir com tools, observar resultados e repetir até uma condição de parada.

**A65.** Quando etapas e regras são conhecidas, previsibilidade é importante e não há benefício em delegar decisões ao modelo.

**A66.** Porque ele pode compartilhar os mesmos vieses, lacunas e erro original; verificação forte usa critérios e evidências independentes.

**A67.** Estado descreve a execução atual; memória persistente é armazenada externamente e pode sobreviver a sessões.

**A68.** Quatro entre: máximo de etapas, timeout, orçamento, tools permitidas, escopo de recursos, condições de parada e aprovação humana.

**A69.** Porque ação, argumentos e observação são fatos auditáveis, úteis para reproduzir e avaliar a execução.

## Módulo 14

**A70.** Quando especialização, isolamento de permissões/contexto ou paralelismo trazem ganho mensurável superior à complexidade criada.

**A71.** No paralelo, tarefas independentes ocorrem simultaneamente; no sequencial, uma etapa depende ou sucede à anterior.

**A72.** Ele reduz ambiguidade e permite validar, versionar e testar as trocas.

**A73.** Delegação retorna o resultado da subtarefa ao responsável; handoff transfere a continuação e a responsabilidade.

**A74.** Porque aumenta chamadas, latência, custo, estados, permissões e modos de falha sem garantir melhor qualidade.

## Módulo 15

**A75.** É uma medição de referência de uma versão conhecida contra a qual mudanças são comparadas.

**A76.** Porque cobre poucos casos e não mede variação, bordas, segurança, custo ou comportamento em dados reais.

**A77.** Para propriedades objetivas como schema, range, presença, igualdade, permissão e cálculo conhecido.

**A78.** Ele também possui vieses e erros; precisa de rubrica clara e calibração contra julgamento humano.

**A79.** Para impedir que uma média boa esconda regressões ou falhas graves em um grupo importante.

**A80.** Seleção e argumentos de tools, número de etapas, recuperação de erros, respeito a limites, permissões, custo e parada.

## Módulo 16

**A81.** Log registra eventos; métrica agrega valores; trace conecta a trajetória de uma requisição entre componentes.

**A82.** Para correlacionar chamadas, tools, erros e tempos pertencentes à mesma execução.

**A83.** Porque revela a experiência da cauda lenta que uma média pode esconder.

**A84.** Pelo menos código, prompt, schema, modelo, parâmetros, índice/embedding, tools, configuração e dataset de avaliação.

**A85.** Porque podem conter segredos, PII e documentos sensíveis, além de gerar custo e obrigações de retenção.

## Módulo 17

**A86.** A direta vem da entrada do usuário; a indireta está embutida em conteúdo externo recuperado ou processado.

**A87.** Porque o modelo pode interpretar ou seguir conteúdo malicioso; autorização e validação precisam ser aplicadas pelo código.

**A88.** Antes ou durante a recuperação, garantindo que conteúdo proibido nunca seja inserido no contexto.

**A89.** Conceder somente operações e recursos estritamente necessários para aquela identidade e tarefa.

**A90.** Porque valores válidos no schema ainda podem conter comando, URL, recurso, texto ou decisão perigosa.

**A91.** Deve gerar um controle ou mitigação e um caso permanente na suite de regressão.

**A92.** Quanto maior o dano potencial e menor a reversibilidade, maior a necessidade de revisão e aprovação humana.

## Módulo 18

**A93.** Pesos do modelo ou parâmetros adicionais treináveis são ajustados a partir dos exemplos.

**A94.** Porque atualiza fontes sem retreinar, preserva rastreabilidade e pode citar o conhecimento usado.

**A95.** Fine-tuning supervisionado com exemplos de entrada e resposta desejada.

**A96.** Treino ajusta parâmetros, validação orienta escolhas e teste mede generalização final sem contaminação.

**A97.** Desempenho alto no treino e pior em exemplos novos ou no conjunto de validação/teste.

**A98.** Congelar os pesos principais e treinar pequenas matrizes de adaptação, reduzindo custo e memória.

**A99.** Quantização muda a precisão da representação numérica; fine-tuning aprende comportamento alterando parâmetros.

**A100.** Para provar que a adaptação melhora o objetivo e não apenas adiciona custo ou regressões.

## Módulo 19

**A101.** Disponibilizar a inferência de um modelo por uma interface operacional, normalmente uma API.

**A102.** Latência é tempo por operação; throughput é volume processado por unidade de tempo.

**A103.** Porque todos influenciam a saída e a recuperação; a combinação exata é necessária para reproduzir e comparar resultados.

**A104.** Reduz memória e pode acelerar ou baratear serving; pode degradar qualidade.

**A105.** Porque uma experiência usa geração, embeddings, busca, tools, armazenamento e infraestrutura, não só uma chamada.

**A106.** Cofre de segredos, identidade gerenciada, RBAC, rotação, rede restrita, auditoria e separação de ambientes.

## Módulo 20

**A107.** Arquitetura, convenções, comandos de build/teste, restrições, escopo e definição de pronto atualizados.

**A108.** Para verificar progresso, detectar divergência cedo e limitar o impacto de uma mudança incorreta.

**A109.** Porque ele apenas evita o versionamento comum; não impede leitura local, exposição em logs, prompts ou outras ferramentas.

**A110.** Quando subtarefas são realmente independentes, possuem fronteiras claras e o custo de consolidação é justificável.

**A111.** A equipe e as pessoas que aprovam e entregam o software continuam responsáveis.

---

# Parte XII — Plano de estudo e referências

# Plano sugerido de 18 semanas

Este é um ritmo de referência para quem trabalha. Ajuste pelo domínio demonstrado nas atividades, não apenas pelo calendário.

| Semanas | Módulos | Evidência principal |
|---|---|---|
| 1–2 | 1–2 | explicação dos fundamentos e experimento de geração |
| 3–4 | 3–4 | prompt versionado e montagem de contexto |
| 5 | 5 | contrato JSON validado |
| 6 | 6 | cliente de API resiliente |
| 7–8 | 7–8 | tools seguras e desenho MCP |
| 9 | 9–10 | comparação lexical, vetorial e híbrida |
| 10–11 | 11–12 | RAG com fontes e avaliação de retrieval |
| 12–13 | 13–14 | agent limitado e decisão single/multi-agent |
| 14–15 | 15–17 | suite de evals, trace e threat model |
| 16 | 18 | decisão e dataset de fine-tuning |
| 17 | 19–20 | plano de produção e fluxo assistido por IA |
| 18 | 21 | demonstração e documentação do projeto |

Regra de avanço: marque o critério de conclusão, responda às perguntas sem consultar e guarde uma evidência da atividade. Se não conseguir explicar um conceito com um exemplo e um limite, revise-o.

## O que priorizar para empregabilidade

A ordem deste guia combina currículos atuais de AI Engineering com competências recorrentes em vagas: integração por APIs, RAG e busca, tools/agents, avaliação, observabilidade, segurança, cloud e práticas de engenharia de software. Python aparece frequentemente no mercado; para o projeto desta trilha, C#/.NET continua válido e especialmente coerente com ambientes Azure. Aprender os conceitos de forma transferível é mais importante que decorar uma biblioteca.

Prioridade prática:

1. fundamentos, prompts, contexto e structured output;
2. APIs confiáveis e segurança;
3. embeddings, busca e RAG avaliados;
4. tools e agents com limites;
5. evals, observabilidade e produção;
6. fine-tuning e multi-agent quando o problema justificar.

## Referências principais

As páginas abaixo serviram para conferir a cobertura e devem ser consultadas porque produtos, SDKs e cursos mudam com o tempo.

### Formação e currículos

- [Microsoft Learn — Develop AI agents on Azure](https://learn.microsoft.com/en-us/training/paths/develop-ai-agents-azure/): trilha com agents, tools, MCP, RAG, workflows, teste e implantação.
- [Microsoft Learn — Study guide for AI-103](https://learn.microsoft.com/en-us/credentials/certifications/resources/study-guides/ai-103): competências de soluções generativas e agentic no Azure, incluindo identidade, rede e governança.
- [Microsoft Learn — Generative AI Engineering with Azure Databricks](https://learn.microsoft.com/en-us/training/courses/dp-3028): RAG, fine-tuning, avaliação, IA responsável e LLMOps.
- [Hugging Face Agents Course](https://huggingface.co/learn/agents-course/en/unit0/introduction): fundamentos de agents, tools, RAG agentic, observabilidade e avaliação.
- [DeepLearning.AI — Agentic AI](https://www.deeplearning.ai/courses/agentic-ai/): reflexão, uso de tools, planejamento e workflows multi-agent.
- [DeepLearning.AI — Evaluating AI Agents](https://www.deeplearning.ai/courses/evaluating-ai-agents): avaliação de componentes e trajetórias de agents.
- [DeepLearning.AI — Fine-Tuning and Reinforcement Learning for LLMs](https://www.deeplearning.ai/courses/fine-tuning-and-reinforcement-learning-for-llms-intro-to-post-training): SFT, preferências, LoRA, avaliação e produção.

### Documentação técnica

- [Azure AI Search — Hybrid search](https://learn.microsoft.com/en-us/azure/search/hybrid-search-overview): combinação de consultas textuais e vetoriais e fusão de resultados.
- [Semantic Kernel — Adding MCP plugins](https://learn.microsoft.com/en-us/semantic-kernel/concepts/plugins/adding-mcp-plugins): integração de servidores MCP em aplicações .NET e outras linguagens.
- [Model Context Protocol — Specification](https://modelcontextprotocol.io/specification/latest): definição atual do protocolo, capacidades e ciclo de vida.
- [Hugging Face — Advanced RAG](https://huggingface.co/learn/cookbook/advanced_rag): técnicas de recuperação, reranking e avaliação em um exemplo aplicado.
- [DeepLearning.AI — Building and Evaluating Advanced RAG](https://www.deeplearning.ai/short-courses/building-evaluating-advanced-rag/): avaliação por relevância de contexto, groundedness e relevância da resposta.

## Como manter este guia

- conceitos fundamentais devem permanecer estáveis e independentes de fornecedor;
- nomes de modelos, preços, limites e APIs devem ser verificados na documentação atual antes da prática;
- toda nova ferramenta só entra quando estiver ligada a um objetivo e uma atividade;
- uma revisão do guia deve registrar data, fonte e motivo da mudança;
- o PDF deve ser gerado somente após revisão do Markdown e resolução dos itens pendentes.

---

**Fim da versão 0.1 para revisão.**
